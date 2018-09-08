using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Hinojosa.RepositorioDocumentos;
using LFSO100Lib;

namespace ConsoleApp1
{
    class Program
    {
        protected static  ILFConnection conexionLF = new LFConnection();
        protected static  ILFApplication aplicacionLF;
        protected static  ILFServer servidorLF;
        protected static  ILFDatabase baseDeDatosLF;

        static void Main(string[] args)
        {
            string server = "ServerWA";
            string database = "DA-HINOJOSA";
            string user = "ADMIN";
            string password = "A12345678";
            
                conexionLF.UserName = user;
                conexionLF.Password = password;

                aplicacionLF = new LFApplication();
                servidorLF = aplicacionLF.GetServerByName(server);
                baseDeDatosLF = servidorLF.GetDatabaseByName(database);
            try
            {
                conexionLF.Create((LFDatabase)baseDeDatosLF);
                IBuscadorDocumentos<Hinojosa.RepositorioDocumentos.DocumentoRepositorio> buscador = new Hinojosa.RepositorioDocumentos.Laserfiche.BuscadorDocumentosLaserfiche(conexionLF, baseDeDatosLF);
                var s = buscador.BuscarDocumentosExpediente(new string[] { "Z1802672-00" }, null);

                IExportadorDocumentos<DocumentoRepositorio> Exportador = new Hinojosa.RepositorioDocumentos.Laserfiche.ExportadorDocumentosLaserfiche<DocumentoRepositorio>(); ;
                Exportador.Exportar(s, @"C:\Algo", true);

                foreach (var ss in s)
                {
                    Console.WriteLine(ss.Nombre);
                }
            }catch(Exception e)
            {

            }
            finally
            {
                if (!conexionLF.IsTerminated)
                {
                    conexionLF.Terminate();
                }
            }
            Console.ReadKey();
        }
    }
}
