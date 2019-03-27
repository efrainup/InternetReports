using Hinojosa.RECOVFP.DataAccessLayer.Entidades.SAAI;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RECOVFP.DataAccessLayer.Repositorios.SAAI
{
    public class Ssdage01RepositorioODBC : AReportSource<Ssdage01Entity>, ISsdage01, IDisposable
    {
        Database database;

        public Ssdage01RepositorioODBC(string nombreConfiguracion = "DBFS_SAAI_DATASOURCE")
        {
            database = base.DbProvider.Create(nombreConfiguracion);
        }


       

        public List<Ssdage01Entity> RecuperarPorPedimentoAñoAduana(string pedimento, int año, int aduana)
        {
            DateTime fechaInicio = Convert.ToDateTime($"01/01/{año}");
            DateTime fechaFin = Convert.ToDateTime($"31/12/{año}");


            using (DbConnection conexion = database.CreateConnection())
            {
                conexion.Open();
                DbCommand comando = conexion.CreateCommand();
                PrepareCommandRecuperarPorPedimentoAñoAduana(pedimento, fechaInicio, fechaFin, comando);

                DbDataReader dataReader = comando.ExecuteReader();

                return Fill(dataReader).ToList();
            }
        }

        private static void PrepareCommandRecuperarPorPedimentoAñoAduana(string pedimento, DateTime fechaInicio, DateTime fechaFin, DbCommand comando)
        {
            comando.CommandText = "SELECT * FROM Ssdage01 WHERE Numped01=? AND Fecpag01 BETWEEN ? AND ? ";

            //Agregando los parametros
            DbParameter ParametroPedimento = comando.CreateParameter();
            ParametroPedimento.DbType = System.Data.DbType.String;
            ParametroPedimento.ParameterName = "?";
            ParametroPedimento.Value = pedimento;
            comando.Parameters.Add(ParametroPedimento);

            DbParameter ParametroFechaPagoInicio = comando.CreateParameter();
            ParametroFechaPagoInicio.DbType = System.Data.DbType.Date;
            ParametroFechaPagoInicio.ParameterName = "?";
            ParametroFechaPagoInicio.Value = fechaInicio;
            comando.Parameters.Add(ParametroFechaPagoInicio);

            DbParameter ParametroFechaPagoFin = comando.CreateParameter();
            ParametroFechaPagoFin.DbType = System.Data.DbType.Date;
            ParametroFechaPagoFin.ParameterName = "?";
            ParametroFechaPagoFin.Value = fechaFin;
            comando.Parameters.Add(ParametroFechaPagoFin);

            

        }

        public async Task<List<Ssdage01Entity>> RecuperarPorPedimentoAñoAduanaAsync(string pedimento, int año, int aduana)
        {
            DateTime fechaInicio = Convert.ToDateTime($"01/01/{año}");
            DateTime fechaFin = Convert.ToDateTime($"31/12/{año}");


            using (DbConnection conexion = database.CreateConnection())
            {
                await conexion.OpenAsync();
                DbCommand comando = conexion.CreateCommand();
                PrepareCommandRecuperarPorPedimentoAñoAduana(pedimento, fechaInicio, fechaFin, comando);

                DbDataReader dataReader = await comando.ExecuteReaderAsync();

                return Fill(dataReader).ToList();
            }
        }

        public List<Ssdage01Entity> RecuperarPorReferencia(string referencia)
        {
            
            using (DbConnection conexion = database.CreateConnection())
            {
                conexion.Open();
                DbCommand comando = conexion.CreateCommand();
                PrepareCommandRecuperarPorReferencia(referencia, comando);

                DbDataReader dataReader = comando.ExecuteReader();

                return Fill(dataReader).ToList();
            }
        }

        private static void PrepareCommandRecuperarPorReferencia(string referencia, DbCommand comando)
        {
            comando.CommandText = "SELECT * FROM Ssdage01 WHERE Refcia01=?";

            //Agregando los parametros
            DbParameter ParametroPedimento = comando.CreateParameter();
            ParametroPedimento.DbType = System.Data.DbType.String;
            ParametroPedimento.ParameterName = "?";
            ParametroPedimento.Value = referencia;
            comando.Parameters.Add(ParametroPedimento);

           
        }

        public async Task<List<Ssdage01Entity>> RecuperarPorReferenciaAsync(string referencia)
        {
            using (DbConnection conexion = database.CreateConnection())
            {
                await conexion.OpenAsync();
                DbCommand comando = conexion.CreateCommand();
                PrepareCommandRecuperarPorReferencia(referencia, comando);

                DbDataReader dataReader = await comando.ExecuteReaderAsync();

                return Fill(dataReader).ToList();
            }
        }

        public void Dispose()
        {
            
        }
    }
}
