﻿using Microsoft.Practices.EnterpriseLibrary.Data;
using RECO.Models.Trafico;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RECOVFP.DataAccessLayer.Repositorios.Trafico
{
    /// <summary>
    /// Realiza operaciones de acceso a datos para el reconocimiento de previos. El acceso a los archivos dbf se realiza mediante ODBC.
    /// </summary>
    public class ReconocimientoDePreviosRepositorioODBC : AReportSource<Stprev26>, IReconocimientoDePreviosRepositorio
    {
        protected Database database;
        
        public ReconocimientoDePreviosRepositorioODBC(string nombreDeCadenaDeConexion = "DBFS_FOXPRO_DATASOURCE")
        {
            database = base.DbProvider.Create(nombreDeCadenaDeConexion);
        }

        /// <summary>
        /// Recupera los datos de los reconocimientos de previo hecho en el sistema de RECO Tráfico (VFP)
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<Stprev26>> RecuperarReconocimientosDePrevioPorReferenciasAsync(IEnumerable<string> referencias)
        {
            var referenciasComillas = referencias.Select(s => "'" + s.Trim() + "'");
            string referenciasCadena = "";

            if (referencias.Count() == 0)
            {
                return new List<Stprev26>();
            }
            else if (referencias.Count() == 1)
            {
                referenciasCadena = "'" + referencias.First() + "'";
            }
            else if (referenciasComillas.Count() > 1)
            {
                referenciasCadena = referenciasComillas.Aggregate((prev, sig) => prev + "," + sig);
            }

            string sqlQuery = string.Format(@"SELECT Refcia26,
                                                     Frecon26,
                                                     Hinici26,
                                                     Hfinal26,
                                                     Nomter26,
                                                     Patent26,
                                                     Cveadu26
                                              FROM Stprev26.dbf 
                                              WHERE REFCIA26 IN (" + referenciasCadena + ")");

            DbCommand dbCommand = database.GetSqlStringCommand(sqlQuery);

            //Se recupera mediante ODBC
            using (dbCommand.Connection = database.CreateConnection())
            {
                await dbCommand.Connection.OpenAsync();
                DbDataReader dataReader = await dbCommand.ExecuteReaderAsync();

                return Fill(dataReader);
            }
        }
    }
}