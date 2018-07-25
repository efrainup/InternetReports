using Microsoft.Practices.EnterpriseLibrary.Data;
using RECO.Models.SORF;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RECOVFP.DataAccessLayer.Repositorios.SORF
{
    /// <summary>
    /// Repositorio que devuelve información de los servicios de traslados
    /// </summary>
    public class ServiciosRepositorio : AReportSource<Srsoli01> 
    {
        Database database;

        public ServiciosRepositorio(string nombreConfiguracion = "DBFS_SORF_DATASOURCE")
        {
            database = base.DbProvider.Create(nombreConfiguracion);
        }

        /// <summary>
        /// Recupera el resumen de servicios en terminal D.A. Hinojosa para las referencias especificadas
        /// </summary>
        /// <param name="referencias">Referencias de las cuales se van a buscar los servicios</param>
        /// <returns></returns>
        public async Task<IEnumerable<Srsoli01>> RecuperarListaDeServicios(IEnumerable<string> referencias)
        {
            var referenciasComillas = referencias.Select(s => "'" + s.Trim() + "'");
            string referenciasCadena = "";

            if(referencias.Count() == 0)
            {
                return new List<Srsoli01>();
            }
            else if (referencias.Count() == 1)
            {
                referenciasCadena = referenciasComillas.First();
            }
            else if (referenciasComillas.Count() > 1)
            {
                referenciasCadena = referenciasComillas.Aggregate((prev, sig) => prev + "," + sig);
            }

            string sqlQuery = string.Format(@"SELECT REFCIA01,
                                                     FECINI01,
                                                     FECHAIMP,
                                                     Fecsal01
                                              FROM SRSOLI01.dbf 
                                              WHERE REFCIA01 IN (" + referenciasCadena + ")");
            
            DbCommand dbCommand = database.GetSqlStringCommand(sqlQuery);
            using (dbCommand.Connection = database.CreateConnection())
            {
                await dbCommand.Connection.OpenAsync();
                DbDataReader dataReader = await dbCommand.ExecuteReaderAsync();

                return Fill(dataReader);
            }
        }
    }
}
