using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Reflection;
using System.Linq;

namespace Reports.DAL
{
    public class MabeReportSource : AReportSource<Models.Partida>, IReportSource<Models.Partida>
    {
        private string idCliente;
        private DateTime inicio;
        private DateTime final;
        Database db;
        Database dbSAAI;

        public MabeReportSource(string connectionString = null)
        {
            db = new DatabaseProviderFactory().Create("ARCHIVOS_ALT");
        }



        public MabeReportSource(string clienteId, DateTime fechaInicio, DateTime fechaFin)
        {
            idCliente = clienteId;
            inicio = fechaInicio;
            final = fechaFin;
            DatabaseProviderFactory dbFactory = new DatabaseProviderFactory();

            db = dbFactory.Create("ARCHIVOS_ALT");
            dbSAAI = dbFactory.Create("DBFS_FOXPRO_DATASOURCE");
            
            // db = DatabaseFactory.CreateDatabase();
        }

        /// <summary>
        /// Obtiene la informacion del sistema SIR
        /// </summary>
        /// <returns></returns>
        protected async Task<IEnumerable<Models.Partida>> CreateGetReportQueryAsync()
        {
            //Obtenemos las referencias del sistema de Trafico que se van a buscar
            var referenciasTrafico = await GetDataFromSAAI();

            //Creamos un parámetro para la búsqueda
            string referenciasABuscar = "";
            if (referenciasTrafico.Count() > 1)
            {
                referenciasABuscar = referenciasTrafico.Select(sel => sel.Refcia21).Aggregate((a, b) => (a.StartsWith("'") ? a : "'" + a + "'") + ",'" + b + "'");
            }
            else if (referenciasTrafico.Count() == 1)
            {
                referenciasABuscar = "'" + referenciasTrafico.First().Refcia21 + "'";
            }



            IEnumerable<Models.Partida> t;
            

            string sqlQuery2 = @"SELECT 
                                    R.sReferencia AS Referencia,
                                    COALESCE(REFSAAI.sPedimento ,PED.sPedimento) AS Pedimento,
                                    CASE R.nTipoOperacion WHEN 0 THEN 'IMPORT/EXPORT'     
                                                        WHEN 1 THEN 'IMPORT'            
                                                        WHEN 2 THEN 'EXPORT'            
                                                        ELSE '' END AS Movimiento, 
                                    ADU.sClaveAduana AS Aduana,
                                    R.sMercanciaDesc AS Descripcion,                       
                                    R.dFechaApertura AS FechaApertura,
                                    COALESCE(PED.dfechapago,REFSAAI.dFechaPago) AS FechaPago,
                                    P.sNumProceso AS Proceso,
                                    EF.sFechaEnvio AS FechaDeEnvioCuentaDeGastos,
                                    REVA.dFechaRevalidacion AS FechaRevalidacionBL,
									PREV.dRecInicio AS [FechaPrevio],
									PREV.dRecFin AS [FechaConclusionPrevio]
                                 FROM [1G_DAH_AA].[SIR].[SIR_60_REFERENCIAS] R
                                 LEFT JOIN [1G_DAH_AA].[Admin].[ADMINC_06_ADUANA_SEC] ADU ON ADU.[nIdAduSec06]=R.[nIdAduSec06]
                                 LEFT JOIN [1G_DAH_AA].[SIR].SIR_149_PEDIMENTO PED ON R.nIdPedimento149 = PED.nIdPedimento149
                                 LEFT JOIN dbo.GT_PROCESOS P ON R.sReferencia=P.sReferencia
                                 LEFT JOIN [dbo].[db_referencias_SAAI] REFSAAI ON REFSAAI.sReferencia=R.sReferencia
                                 LEFT JOIN [dbo].[Pase_Envio_Facturacion_LF] EF ON EF.nIdReferencia=R.nIdReferencia60
                                 LEFT JOIN 
									( SELECT ROW_NUMBER() OVER (PARTITION BY sReferencia ORDER BY dFechaRevalidacion desc) id, nIdReferencia60, sReferencia, dFechaRevalidacion FROM SIR.SIR_50_REVALIDACION REV 
										
									) AS REVA on REVA.sReferencia=R.sReferencia and REVA.id=1
                                 LEFT JOIN [1G_DAH_AA].[SIR].[SIR_161_PROG_PREVIOS_REF] PREV ON PREV.nIdReferencia60=R.nIdReferencia60 
                                 WHERE (R.dFechaApertura BETWEEN '{1}' AND '{2}'     
                                 AND R.nIdCliente = {0}) ";

            if (referenciasABuscar.Length > 0) {
                sqlQuery2 += $" OR R.sReferencia IN({referenciasABuscar})";
            }

            sqlQuery2 += " GROUP BY R.sReferencia,REFSAAI.sPedimento,PED.sPedimento,R.nTipoOperacion,ADU.sClaveAduana,R.sMercanciaDesc,R.dFechaApertura,P.sNumProceso,EF.sFechaEnvio,REVA.dFechaRevalidacion,PREV.dRecInicio,PREV.dRecFin,PED.dfechapago,REFSAAI.dFechaPago";

            DbCommand dbCommand = db.GetSqlStringCommand(string.Format(sqlQuery2,idCliente,inicio.ToString("s"),final.ToString("s")));
            using (dbCommand.Connection = db.CreateConnection())
            {
                dbCommand.Connection.Open();
                DbDataReader reportResultReader = await dbCommand.ExecuteReaderAsync();
                 t = Fill(reportResultReader);
            }

            //Se hace un "join" para asignar la fecha de alta
            t.GroupJoin(referenciasTrafico, a => a.Referencia, b => b.Refcia21, (partida, referenciasDeTrafico) =>
               {
                   if (referenciasTrafico.Any()) {
                       partida.FechaApertura = referenciasTrafico.First().Frecep21;
                    }

                   return partida;
               });

            return t;
        }

        //protected async Task<IEnumerable<T>> GetClasification(List<InternetReports.Reports.Models.Partida> partidas)
        //{
        //    string referencias = partidas
        //        .Select(s => s.GetType().GetProperty("Referencia").GetValue(s).ToString())
        //        .Aggregate((prev, next) => prev + "," + next);
        //    string sqlQuery = string.Format("SELECT RefCia01 FROM ssdagp01.dbf WHERE RefCia01 IN ({0})",referencias);

        //    DbCommand dbCommand = dbSAAI.GetSqlStringCommand(sqlQuery);
        //    using(dbCommand.Connection = dbSAAI.CreateConnection())
        //    {
        //        await dbCommand.Connection.OpenAsync();
        //        DbDataReader reader = await dbCommand.ExecuteReaderAsync();

        //        while (await reader.NextResultAsync()) {
        //            string referencia = reader.GetString(0);
        //            partidas.FirstOrDefault(f => f.Referencia.Equals(referencia));
                    
        //        }

        //    }
        //}

        /// <summary>
        /// Obtiene la información de la tabla stctrl21
        /// </summary>
        /// <returns></returns>
        protected async Task<IEnumerable<Trafico.Models.Stcrl21Entity>> GetDataFromSAAI()
        {
            DateTime inicio = this.inicio;
            DateTime fin = this.final;
            string sqlQuery = string.Format(@"SELECT REFCIA21 AS REFCIA21,
                                                     FRECEP21 as FRECEP21 
                                              FROM stctrl21.dbf 
                                              WHERE DTOS(FRECEP21) BETWEEN '{0}' AND '{1}' AND cvecli21={2}"
            , inicio.ToString("yyyyMMdd"),final.ToString("yyyyMMdd"),idCliente);
            
            DbCommand dbCommand = dbSAAI.GetSqlStringCommand(sqlQuery);
            using (dbCommand.Connection = dbSAAI.CreateConnection())
            {
                await dbCommand.Connection.OpenAsync();
                DbDataReader dataReader = await dbCommand.ExecuteReaderAsync();

                return Fill<Trafico.Models.Stcrl21Entity>(dataReader);
            }
        }

        public async Task<IEnumerable<Models.Partida>> GetReportAsync()
        {
            //var s = await GetDataFromSAAI();
            return await CreateGetReportQueryAsync(); 
        }
    }
}
