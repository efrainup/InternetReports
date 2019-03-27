using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data.Common;
using System.Threading.Tasks;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Reflection;
using System.Linq;
using Hinojosa.RECOVFP.Entidades.Trafico;
using Hinojosa.RECOVFP.DataAccessLayer.Repositorios.SORF;
using Hinojosa.RECOVFP.DataAccessLayer.Repositorios.Trafico;

namespace Reports.DAL
{
    public class MabeReportSource : AReportSource<Models.Partida>, IReportSource<Models.Partida>
    {
        private string idCliente;
        private DateTime inicio;
        private DateTime final;
        Database db;
        Database dbSAAI;

        public string TraficoPath { get; set; }
        public string SorfPath { get; set; }

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
            //var referenciasTrafico = await GetDataFromSAAI();
            IReferenciasTraficoRepositorio repositorioTrafico = new ReferenciasTraficoRepositorioVFPInterop(TraficoPath);
            IEnumerable<Stctrl21Entity> referenciasTrafico = await repositorioTrafico.RecuperarPorFechaAltaClienteAsync(this.inicio,this.final, idCliente);

            //Creamos un parámetro para la búsqueda
            string referenciasSeparadasPorComa = "";
            string[] referencias = referenciasTrafico.Select(sel => sel.Refcia21).ToArray();
            Srsoli10Filter[] srsoli10Filters = referenciasTrafico.Select(sel => new Srsoli10Filter() { Patente=sel.Patent21, Referencia=sel.Refcia21, Aduana=sel.Cveadu21 }).ToArray();

            if (referenciasTrafico.Count() > 1)
            {
                referenciasSeparadasPorComa = referenciasTrafico.Select(sel => sel.Refcia21).Aggregate((a, b) => (a.StartsWith("'") ? a : "'" + a + "'") + ",'" + b + "'");
            }
            else if (referenciasTrafico.Count() == 1)
            {
                referenciasSeparadasPorComa = "'" + referenciasTrafico.First().Refcia21 + "'";
            }

            //Se recupera la información de los previos
            //Se obtiene la información mediante interoperabilidad con la dll RecoVFPInteropLibraries
            IReconocimientoDePreviosRepositorio previosRepositorio = new ReconocimientoDePreviosRepositorioVFPInterop(TraficoPath);
            
            var informacionDePrevios = await previosRepositorio.RecuperarReconocimientosDePrevioPorReferenciasAsync(referencias);

            //Se recupera información de los servicios de traslados
            var tt = new ServiciosRepositorioVFPInterop(TraficoPath,SorfPath); //new ServiciosRepositorioODBC();
            var listaDeServicios = await tt.RecuperarListaDeServiciosAsync(srsoli10Filters);

            IEnumerable<Models.Partida> t = await RecuperarReporte(referenciasSeparadasPorComa);


            //Se hace un "join" para asignar la fecha de alta
            return t.GroupJoin(referenciasTrafico, a => a.Referencia.Trim().ToLowerInvariant(), b => b.Refcia21.Trim().ToLowerInvariant(), (partida, referenciasTraficoCoincidentes) =>
            {
                if (referenciasTraficoCoincidentes.Any())
                {
                    partida.FechaApertura = referenciasTraficoCoincidentes.First().Frecep21;
                    partida.FechaArriboDeBuque = referenciasTraficoCoincidentes.First().Fecbar21;
                }

                return partida;
            }).GroupJoin(listaDeServicios, a => a.Referencia, b => b.Refcia01.Trim(), (referencia, servicios) =>
            {
                //Se agregan las fechas de traslado, arribo de buque y salida capturados en la terminal
                if (servicios.Any())
                {
                    referencia.FechaTraslado = servicios.Max(m => m.Fecini01);
                    referencia.FechaArriboDeBuque = servicios.Max(m => m.Fechaimp); //Incorrecto o comprobar si lo que capturan en la terminal es mas exacto que lo que se captura en tráfico
                    referencia.FechaSalida = servicios.Max(m => m.Fecsal01);
                }
                return referencia;
            }).GroupJoin(informacionDePrevios, a => a.Referencia, b => b.Refcia26.Trim(), (referencia, previos) =>
              {
                  var ultimoPrevio = previos.FirstOrDefault(f => f.Frecon26 == previos.Max(m => m.Frecon26));

                  if (ultimoPrevio != null)
                  {
                      TimeSpan horaDeInicioDePrevio = TimeSpan.FromHours(0);
                      TimeSpan horaFinalDePrevio = TimeSpan.FromHours(0);

                      if (TimeSpan.TryParse(ultimoPrevio.Hinici26, out horaDeInicioDePrevio))
                      {
                          referencia.FechaPrevio = ultimoPrevio.Frecon26.Value.Add(horaDeInicioDePrevio);
                      }

                      if (TimeSpan.TryParse(ultimoPrevio.Hfinal26, out horaFinalDePrevio))
                      {
                          referencia.FechaConclusionPrevio = ultimoPrevio.Frecon26.Value.Add(horaFinalDePrevio);
                      }

                      
                  }

                  return referencia;
              });

        }

        private async Task<IEnumerable<Models.Partida>> RecuperarReporte(string referenciasABuscar)
        {
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
                                    FCG.fecha AS [FechaDeCuentaDeGastos],
                                    EF.sFechaEnvio AS FechaDeEnvioCuentaDeGastos,
                                    REVA.dFechaRevalidacion AS FechaRevalidacionBL,
									PREV.dRecInicio AS [FechaPrevio],
									PREV.dRecFin AS [FechaConclusionPrevio],
                                    RT.dFechaETA AS [FechaArriboDeBuque]
                                 FROM [1G_DAH_AA].[SIR].[SIR_60_REFERENCIAS] R WITH(NOLOCK)
                                 LEFT JOIN [1G_DAH_AA].[SIR].[SIR_41_REG_TRANSPORTES] RT WITH(NOLOCK) ON RT.nIdRegTrans41=R.nIdRegTrans41
                                 LEFT JOIN [1G_DAH_AA].[Admin].[ADMINC_06_ADUANA_SEC] ADU WITH(NOLOCK) ON ADU.[nIdAduSec06]=R.[nIdAduSec06]
                                 LEFT JOIN [1G_DAH_AA].[SIR].SIR_149_PEDIMENTO PED WITH(NOLOCK) ON R.nIdPedimento149 = PED.nIdPedimento149
                                 LEFT JOIN dbo.GT_PROCESOS P WITH(NOLOCK) ON R.sReferencia=P.sReferencia
                                 LEFT JOIN [dbo].[db_referencias_SAAI] REFSAAI WITH(NOLOCK) ON REFSAAI.sReferencia=R.sReferencia
                                 LEFT JOIN [dbo].[Pase_Envio_Facturacion_LF] EF WITH(NOLOCK) ON EF.nIdReferencia=R.nIdReferencia60
                                 LEFT JOIN 
									( SELECT ROW_NUMBER() OVER (PARTITION BY sReferencia ORDER BY dFechaRevalidacion desc) id, nIdReferencia60, sReferencia, dFechaRevalidacion FROM SIR.SIR_50_REVALIDACION REV WITH(NOLOCK) 
										
									) AS REVA on REVA.sReferencia=R.sReferencia and REVA.id=1
                                 LEFT JOIN [1G_DAH_AA].[SIR].[SIR_161_PROG_PREVIOS_REF] PREV WITH(NOLOCK) ON PREV.nIdReferencia60=R.nIdReferencia60 
                                 LEFT JOIN dbo.sis_ref_info IR WITH (NOLOCK) ON IR.id_ref = R.nIdReferencia60
                                 LEFT JOIN [dbo].[vta_fac_enc] FCG WITH(NOLOCK) ON IR.id_fac = FCG.id_fac
                                 WHERE (R.dFechaApertura BETWEEN '{1}' AND '{2}'     
                                 AND R.nIdCliente = {0}) ";

            if (referenciasABuscar.Length > 0)
            {
                sqlQuery2 += $" OR R.sReferencia IN({referenciasABuscar})";
            }

            sqlQuery2 += " GROUP BY R.sReferencia,REFSAAI.sPedimento,PED.sPedimento,R.nTipoOperacion,ADU.sClaveAduana,R.sMercanciaDesc,R.dFechaApertura,P.sNumProceso,EF.sFechaEnvio,REVA.dFechaRevalidacion,PREV.dRecInicio,PREV.dRecFin,PED.dfechapago,REFSAAI.dFechaPago,FCG.fecha,RT.dFechaETA";

            DbCommand dbCommand = db.GetSqlStringCommand(string.Format(sqlQuery2, idCliente, inicio.ToString("s"), final.ToString("s")));
            using (dbCommand.Connection = db.CreateConnection())
            {
                dbCommand.Connection.Open();
                DbDataReader reportResultReader = await dbCommand.ExecuteReaderAsync();
                t = Fill(reportResultReader);
            }

            return t;
        }
        
        /// <summary>
        /// Obtiene la información de la tabla stctrl21
        /// </summary>
        /// <returns></returns>
        protected async Task<IEnumerable<Stctrl21Entity>> GetDataFromSAAI()
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

                return Fill<Stctrl21Entity>(dataReader);
            }
        }

        public async Task<IEnumerable<Models.Partida>> GetReportAsync()
        {
            //var s = await GetDataFromSAAI();
            return await CreateGetReportQueryAsync(); 
        }
    }
}
