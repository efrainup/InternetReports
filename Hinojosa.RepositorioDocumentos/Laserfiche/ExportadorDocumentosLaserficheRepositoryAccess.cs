using Laserfiche.DocumentServices;
using Laserfiche.RepositoryAccess;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RepositorioDocumentos.Laserfiche
{
    public class ExportadorDocumentosLaserficheRepositoryAccess : IExportadorDocumentos<DocumentoRepositorio>
    {
        #region Propiedades
        public Session Sesion { get; protected set; }

        object IConectable.Sesion => Sesion;
        #endregion

        public ExportadorDocumentosLaserficheRepositoryAccess(Session sesion)
        {
            Sesion = sesion;
        }

        public ExportadorDocumentosLaserficheRepositoryAccess(string servidor = "ServerWA", string repositorio = "DA-HINOJOSA", string usuario = "ADMIN", string contraseña = "A12345678")
        {
            Sesion = Session.Create(servidor, repositorio, usuario, contraseña);
        }

        #region Metodos
        public void Close()
        {
            Sesion.Close();
        }

        public void Exportar(IEnumerable<DocumentoRepositorio> documentos, string ruta, bool zip)
        {
            Exportar(documentos, ruta, zip, documentoRepositorio => "");
        }

        public void Exportar(IEnumerable<DocumentoRepositorio> documentos, string ruta, bool zip, Func<DocumentoRepositorio, string> rutaInterna)
        {
            foreach(DocumentoRepositorio documento in documentos)
            {
                DocumentInfo informacionDocumento = documento.DocumentoAsociado as DocumentInfo;
                string directorioInterno = rutaInterna.Invoke(documento);

                //Crear los directorios internos
                string[] subdirectorios = directorioInterno.Split('\\');
                string rutaActual = ruta;
                rutaActual += !rutaActual.EndsWith("\\") ? "\\" : "";
                
                for (int i = 0; i < subdirectorios.Length; i++)
                {
                    rutaActual += subdirectorios[i];
                    DirectoryInfo directorio = new DirectoryInfo(rutaActual);
                    if (!directorio.Exists)
                    {
                        directorio.Create();
                    }

                    rutaActual += "\\";
                }

                rutaActual += !rutaActual.EndsWith("\\") ? "\\" : "";

                var exportadorDocumentos = new DocumentExporter();
                

                if (informacionDocumento.IsElectronicDocument)
                {
                    if (!File.Exists(rutaActual + documento.Nombre + "." + informacionDocumento.Extension))
                    {
                        documento.Nombre = documento.Nombre.Replace("/", "_").Replace("*", "_").Replace("\\", "_").Replace(":", "_").Replace("\"", "_").Replace('<', '_').Replace('>', '_').Replace('|', '_');
                        exportadorDocumentos.ExportElecDoc(informacionDocumento, rutaActual + documento.Nombre + "." + informacionDocumento.Extension);
                    }
                }
                else
                {
                    
                        //En ocasiones hay documentos TIFF (escaneados) que no tienen páginas, en este caso bypasear
                        if (informacionDocumento.PageCount <= 0)
                        {
                            continue;
                        }
                        var rangoPaginas = new PageRange(1, informacionDocumento.PageCount);
                        var configuracionPaginas = new PageSet(rangoPaginas);

                        string nombre = informacionDocumento.Name;
                        if (nombre.Contains("*") && string.IsNullOrEmpty(informacionDocumento.TemplateName))
                        {
                            nombre = informacionDocumento.TemplateName;
                        }
                        nombre = nombre.Replace("/", "_").Replace("*", "_").Replace("\\", "_").Replace(":", "_").Replace("\"", "_").Replace('<', '_').Replace('>', '_').Replace('|', '_');
                    if (!File.Exists(rutaActual + nombre + ".pdf"))
                    {
                        exportadorDocumentos.ExportPdf(informacionDocumento, configuracionPaginas, PdfExportOptions.None, rutaActual + nombre + ".pdf");
                    }
                }
            }

            if (zip)
            {
                Zippear(ruta);
            }
        }

        public async Task ExportarAsync(IEnumerable<DocumentoRepositorio> documentos, string ruta, bool zip)
        {
            await Task.Run(() => Exportar(documentos, ruta, zip));
        }

        public async Task ExportarAsync(IEnumerable<DocumentoRepositorio> documentos, string ruta, bool zip, Func<DocumentoRepositorio, string> rutaInterna)
        {
            await Task.Run(() => Exportar(documentos, ruta, zip, rutaInterna));
        }

        public void Open()
        {
            Sesion.Connect(Sesion.Repository);
        }

        public async Task OpenAsync()
        {
            await Task.Run(() => Open());
        }

        private static void Zippear(string ruta)
        {
            string nombreZip = ".zip";
            ZipFile.CreateFromDirectory(ruta, ruta.Substring(0, ruta.Length - (ruta[ruta.Length - 1] == '/' ? 1 : 0)) + nombreZip);
        }
        #endregion

    }
}
