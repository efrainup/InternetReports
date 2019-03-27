using LFSO100Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RepositorioDocumentos.Laserfiche
{
    public class BuscadorDocumentosLaserfiche : IBuscadorDocumentos<DocumentoRepositorio>, IDisposable
    {
        protected ILFConnection conexionLF = new LFConnection();
        protected ILFApplication aplicacionLF;
        protected ILFServer servidorLF;
        protected ILFDatabase baseDeDatosLF;

        public object Sesion => conexionLF;

        public BuscadorDocumentosLaserfiche(string server = "ServerWA", string database = "DA-HINOJOSA", string user= "ADMIN", string password = "A12345678")
        {
            conexionLF.UserName = user;
            conexionLF.Password = password;

            aplicacionLF = new LFApplication();
            servidorLF = aplicacionLF.GetServerByName(server);
            baseDeDatosLF = servidorLF.GetDatabaseByName(database);

            //conexionLF.Create((LFDatabase)baseDeDatosLF);
        }

        public BuscadorDocumentosLaserfiche(ILFConnection conexionLF ,ILFDatabase databaseLF)
        {
            this.conexionLF = conexionLF;
            this.baseDeDatosLF = databaseLF;
        }

       

        public IEnumerable<DocumentoRepositorio> BuscarDocumentosExpediente(IEnumerable<string> referencias, IEnumerable<string> nombreDocumentos)
        {
            //Primero se abre conexion
            //conexionLF.Create((LFDatabase)baseDeDatosLF);

            try
            {
                
                List<DocumentoRepositorio> resultado = new List<DocumentoRepositorio>();

                //Para cada referencia se buscan los documentos requeridos
                foreach (string referencia in referencias)
                {
                    LFSearch busqueda = baseDeDatosLF.CreateSearch();

                    //Se busca una carpeta con el nombre de la referencia, pero debe estar bajo una carpeta IMPO o EXPO
                    busqueda.Command = "{LF:Name=\""+referencia+ "\",Type=\"F\" } & ({LF:ParentName=\"IMPO\"}|{LF:ParentName=\"EXPO\"})";
                    busqueda.BeginSearch(true);
                    ILFCollection coleccionHitsLF = busqueda.GetSearchHits();

                    
                    foreach (LFSearchHit searchHitLF in coleccionHitsLF)
                    {
                        LFBriefcaseExporter bfex = new LFBriefcaseExporter();
                        bfex.AddFolder(searchHitLF.Entry as LFFolder);
                       
                        ExtraerDocumentos(resultado, referencia, searchHitLF.Entry);

                    }
                }

                return resultado;
            }catch(Exception exception)
            {
                throw exception;
            }
            finally
            {
                //if (!conexionLF.IsTerminated)
                //{
                //    conexionLF.Terminate();
                //}
            }
            return null;
        }

        private static void ExtraerDocumentos(List<DocumentoRepositorio> resultado, string referencia, LFFolder documentoLaserfiches)
        {
            //LFDocument documentoLaserfiche = searchHitLF.Entry as LFDocument;
            //LFDirectoryEntry documentoLaserfiches = searchHitLF.Entry as LFDirectoryEntry;
            //ILFEntry documentoLaserfichevs = searchHitLF.Entry as ILFEntry;
            //documentoLaserfichevs.EntryType == Entry_Type.ENTRY_TYPE_DOCUMENT;

            
            ILFCollection coleccionLaserfiche = documentoLaserfiches.GetChildren();
            foreach (ILFEntry entrada in coleccionLaserfiche)
            {
                if (entrada.EntryType == Entry_Type.ENTRY_TYPE_DOCUMENT)
                {
                    LFDocument documentoLaserfiche = entrada as LFDocument;
                    var documentoRepositorio = new DocumentoRepositorio();
                    documentoRepositorio.Referencia = referencia;
                    documentoRepositorio.DocumentoAsociado = entrada;
                    documentoRepositorio.IdDocumento = documentoLaserfiche.ID.ToString();
                    documentoRepositorio.Nombre = documentoLaserfiche.Name;
                    documentoRepositorio.Ruta = documentoLaserfiche.FullPath;

                    if (documentoLaserfiche.ElectFile != null)
                    {
                        documentoRepositorio.TipoMime = documentoLaserfiche.ElectFile.MimeType;
                    }

                    if (documentoLaserfiche.Template != null)
                    {
                        documentoRepositorio.Plantilla = documentoLaserfiche.Template.Name;
                    }

                    resultado.Add(documentoRepositorio);
                }
                else if(entrada.EntryType == Entry_Type.ENTRY_TYPE_FOLDER)
                {
                    ExtraerDocumentos(resultado, referencia, entrada as LFFolder);
                }
            }
        }

        public async Task<IEnumerable<DocumentoRepositorio>> BuscarDocumentosExpedienteAsync(IEnumerable<string> referencias, IEnumerable<string> nombreDocumentos)
        {
            return await Task.Run(() => BuscarDocumentosExpediente(referencias, nombreDocumentos));
        }

        public void Dispose()
        {
            if (!conexionLF.IsTerminated)
            {
                conexionLF.Terminate();
            }
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

        public DocumentoRepositorio BuscaCarpetaContenedora(string Ruta)
        {
            throw new NotImplementedException();
        }

        public DocumentoRepositorio BuscarCarpetaReferencia(string Referencia)
        {
            throw new NotImplementedException();
        }
    }
}
