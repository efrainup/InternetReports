using Hinojosa.Common.DataAccessLayer.Entidades;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.Common.DataAccessLayer.Repositorios
{
    public class ClientesRepositorio : AReportSource<CatCliente>
    {
        protected Database database;

        public ClientesRepositorio()
        {
            database = base.DbProvider.Create("ARCHIVOS_ALT");
        }

        public async Task<IEnumerable<CatCliente>> Recuperar()
        {
            string sqlQuery = "SELECT * FROM Cat_Clientes WITH(NOLOCK)";
            DbCommand command = database.GetSqlStringCommand(sqlQuery);

            using(DbConnection conexion = database.CreateConnection())
            {
                await conexion.OpenAsync();
                command.Connection = conexion;

                var reader = await command.ExecuteReaderAsync();
                return Fill(reader);
            }

        }
    }
}
