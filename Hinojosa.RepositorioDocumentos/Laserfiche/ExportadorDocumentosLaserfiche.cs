using LFSO100Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocumentProcessor100;
using PdfExporter;
using System.IO.Compression;
using System.IO;

namespace Hinojosa.RepositorioDocumentos.Laserfiche
{
    public class ExportadorDocumentosLaserfiche<T> : IExportadorDocumentos<DocumentoRepositorio> 
    {
        protected ILFConnection conexionLF = new LFConnection();
        protected LFApplication aplicacionLF;
        protected LFServer servidorLF;
        protected ILFDatabase baseDeDatosLF;

        public object Sesion => conexionLF;

        public ExportadorDocumentosLaserfiche(string server = "ServerWA", string database = "DA-HINOJOSA", string user = "ADMIN", string password = "A12345678")
        {
            conexionLF.UserName = user;
            conexionLF.Password = password;

            aplicacionLF = new LFApplication();
            servidorLF = aplicacionLF.GetServerByName(server);
            baseDeDatosLF = servidorLF.GetDatabaseByName(database);

            //conexionLF.Create(baseDeDatosLF);
        }

        public ExportadorDocumentosLaserfiche(ILFConnection conexionLF, ILFDatabase databaseLF)
        {
            this.conexionLF = conexionLF;
            this.baseDeDatosLF = databaseLF;
        }

        protected void ExportarDocumento(string ruta, LFDocument documentoLaserfiche, bool throwError=false)
        {
            if (documentoLaserfiche.Name.ToLowerInvariant().Contains("cove"))
            {
                return;
            }
            //Verificar el tipo de documento ya que los documentos escaneados se descargan como TIFF
            //documentoLaserfiche.
            try
            {
                if (documentoLaserfiche.ElectFile.IsEmpty)
                {
                    //Descargar documento escaneado TIFF
                    var exportadorPdf = new PdfExporter.PdfExporter();
                    
                    exportadorPdf.ExportPagesToFile(documentoLaserfiche, ruta + documentoLaserfiche.Name + ".pdf");
                }
                else
                {
                    try
                    {
                        
                        documentoLaserfiche.ElectFile.ReadStream.Open();
                         documentoLaserfiche.ElectFile.ReadStream.Export(ruta + documentoLaserfiche.Name + "." + documentoLaserfiche.ElectFile.Extension);
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally
                    {
                        documentoLaserfiche.ElectFile.ReadStream.Close();
                    }
                    
                }
            }
            catch (Exception e)
            {
                //if (!throwError)
                //{
                //    conexionLF.Connect(documentoLaserfiche.Database);
                //    ExportarDocumento(ruta, documentoLaserfiche, true);
                //}
                //else
                //{
                //    throw e;
                //}
            }
        }

        public void Exportar(IEnumerable<DocumentoRepositorio> documentos, string ruta, bool zip)
        {
            if (!ruta.EndsWith("/"))
            {
                ruta += "/";
            }


            foreach (DocumentoRepositorio documento in documentos)
            {
                LFDocument documentoLaserfiche = documento.DocumentoAsociado as LFDocument;

                ExportarDocumento(ruta, documentoLaserfiche);
            }

            Zippear(ruta, zip);
        }

        private static void Zippear(string ruta, bool zip)
        {
            if (zip)
            {
                string nombreZip = ".zip";
                ZipFile.CreateFromDirectory(ruta, ruta.Substring(0, ruta.Length - 1) + nombreZip);
            }
        }

        public void Exportar(IEnumerable<DocumentoRepositorio> documentos, string ruta, bool zip, Func<DocumentoRepositorio, string> rutaInterna)
        {
            if (!ruta.EndsWith("\\"))
            {
                ruta += "\\";
            }

            foreach (DocumentoRepositorio documento in documentos)
            {
                LFDocument documentoLaserfiche = documento.DocumentoAsociado as LFDocument;

                string directorioInterno = rutaInterna.Invoke(documento);

                string[] subdirs = directorioInterno.Split('\\');
                string rutaActual = ruta;
                for(int i=0; i < subdirs.Length; i++)
                {
                    rutaActual += subdirs[i];
                    DirectoryInfo directorio = new DirectoryInfo(rutaActual);
                    if (!directorio.Exists)
                    {
                        directorio.Create();
                    }
                }


                ExportarDocumento(ruta + directorioInterno, documentoLaserfiche);
            }

            Zippear(ruta, zip);
        }

        public async Task ExportarAsync(IEnumerable<DocumentoRepositorio> documentos, string ruta, bool zip)
        {
            await Task.Run(() =>
            {
                Exportar(documentos, ruta, zip);
            });
        }

        public async Task ExportarAsync(IEnumerable<DocumentoRepositorio> documentos, string ruta, bool zip, Func<DocumentoRepositorio, string> rutaInterna)
        {
            await Task.Run(() => Exportar(documentos, ruta, zip, rutaInterna));
        }

        public void Open()
        {
            throw new NotImplementedException();
        }

        public Task OpenAsync()
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }
    }
}
