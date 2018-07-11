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
    public class MabeReportSource<T> : AReportSource<T>, IReportSource<T> where T : class
    {
        private string id;
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
            id = clienteId;
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
        protected async Task<IEnumerable<T>> CreateGetReportQueryAsync()
        {
            

            
            string sqlQuery = "SELECT " +
                               "   R.sReferencia as Referencia, " +
                               "   CASE R.nTipoOperacion WHEN 1 THEN 'IMPORT' WHEN 2 THEN 'EXPORT' WHEN 0 THEN 'IMPORT/EXPORT' ELSE '' END as Movimiento, " +
                               "   PT.sPatente as Patente, " +
                               "   A.sClaveAduana as Aduana, " +
                               "   A.sClaveSeccion as Seccion, " +
                               "   P.sPedimento as Pedimento, " +
                               "   CD.sClave as [Clave Pedimento], " +
                               "   Convert(varchar(10), P.dFechaPago, 103) as [Fecha Pago], " +
                               "   '' as DescripcionAA " +
                               "FROM SIR.SIR_60_REFERENCIAS R " +
                               "	LEFT JOIN SIR.SIR_149_PEDIMENTO P ON R.nIdPedimento149 = P.nIdPedimento149 " +
                               "	LEFT JOIN SIR.SIR_71_SUCURSAL_PATENTE_ADUANA SPA ON R.nIdSucPatAdu71 = SPA.nIdSucPatAdu71 " +
                               "	LEFT JOIN SIR.SIR_70_PATENTES PT ON SPA.nIdPatente70 = PT.nIdPatente70 " +
                               "	LEFT JOIN SIR.SIR_06_ADUANA_SEC A ON R.nIdAduSec06 = A.nIdAduSec06 " +
                               "	LEFT JOIN SIR.SIR_28_CLAVES_DOCTOS CD ON R.nIdClaveDocto28 = CD.nIdClaveDocto28 " +
                               "WHERE (P.sFirmaPedimento <> '' AND P.sFirmaPedimento IS NOT NULL) " +
                               "	AND R.nIdImex = " + id +
                               "	AND P.dFechaPago >= '" + inicio.ToString("s") + "' AND P.dFechaPago <= '" + final.ToString("s") + "'";


            string sqlQuery2 = @"SELECT 
                                    R.sReferencia AS Referencia,
                                    COALESCE(REFSAAI.sPedimento ,PED.sPedimento) AS Pedimento,
                                    CASE R.nTipoOperacion WHEN 0 THEN 'IMPORT/EXPORT'     
                                                        WHEN 1 THEN 'IMPORT'            
                                                        WHEN 2 THEN 'EXPORT'            
                                                        ELSE '' END AS Movimiento,     
                                    R.sMercanciaDesc AS Descripcion,                       
                                    R.dFechaApertura AS FechaApertura,
                                    P.sNumProceso AS Proceso,
                                    EF.sFechaEnvio AS FechaDeEnvioCuentaDeGastos,
                                    REVA.dFechaRevalidacion AS FechaRevalidacionBL,
									PREV.dRecInicio AS [FechaPrevio],
									PREV.dRecFin AS [FechaConclusionPrevio]
                                 FROM [1G_DAH_AA].[SIR].[SIR_60_REFERENCIAS] R
                                 LEFT JOIN [1G_DAH_AA].[SIR].SIR_149_PEDIMENTO PED ON R.nIdPedimento149 = PED.nIdPedimento149
                                 LEFT JOIN dbo.GT_PROCESOS P ON R.sReferencia=P.sReferencia
                                 LEFT JOIN [dbo].[db_referencias_SAAI] REFSAAI ON REFSAAI.sReferencia=R.sReferencia
                                 LEFT JOIN [dbo].[Pase_Envio_Facturacion_LF] EF ON EF.nIdReferencia=R.nIdReferencia60
                                 LEFT JOIN 
									( SELECT ROW_NUMBER() OVER (PARTITION BY sReferencia ORDER BY sReferencia,dFechaCaptura) id, nIdReferencia60, sReferencia, dFechaRevalidacion FROM SIR.SIR_50_REVALIDACION REV 
										
									) AS REVA on REVA.sReferencia=R.sReferencia and REVA.id=1
                                 LEFT JOIN [1G_DAH_AA].[SIR].[SIR_161_PROG_PREVIOS_REF] PREV ON PREV.nIdReferencia60=R.nIdReferencia60 
                                 WHERE R.dFechaApertura BETWEEN '{1}' AND '{2}'     
                                 AND R.nIdCliente = {0}";

            DbCommand dbCommand = db.GetSqlStringCommand(string.Format(sqlQuery2,id,inicio.ToString("s"),final.ToString("s")));
            using (dbCommand.Connection = db.CreateConnection())
            {
                dbCommand.Connection.Open();
                DbDataReader reportResultReader = await dbCommand.ExecuteReaderAsync();
                return Fill(reportResultReader);
            }
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
        /// Obtiene la información del sistema SAAI
        /// </summary>
        /// <returns></returns>
        protected async Task<IEnumerable<T>> GetDataFromSAAI()
        {
            DateTime inicio = this.inicio;
            DateTime fin = this.final;
            string sqlQuery = string.Format("SELECT E.refcia01 as Referencia " +
                            " FROM ssdage01.dbf as E" +
                            " WHERE E.fecpag01 >= DATE({0}) and E.fecpag01 <= DATE({1})",inicio.ToString("yyyy,MM,dd"),final.ToString("yyyy,MM,dd"));
            
            DbCommand dbCommand = dbSAAI.GetSqlStringCommand(sqlQuery);
            using (dbCommand.Connection = dbSAAI.CreateConnection())
            {
                await dbCommand.Connection.OpenAsync();
                DbDataReader dataReader = await dbCommand.ExecuteReaderAsync();

                return Fill(dataReader);
            }
        }

        public async Task<IEnumerable<T>> GetReportAsync()
        {
//            return await GetDataFromSAAI();
            return await CreateGetReportQueryAsync(); 
        }
    }
}
