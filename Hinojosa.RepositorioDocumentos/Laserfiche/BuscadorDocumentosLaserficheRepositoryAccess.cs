using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Laserfiche.RepositoryAccess;

namespace Hinojosa.RepositorioDocumentos.Laserfiche
{
    public class BuscadorDocumentosLaserficheRepositoryAccess : IBuscadorDocumentos<DocumentoRepositorio>, IDisposable
    {
        public Session Sesion { get; protected set; }

        object IConectable.Sesion => Sesion;

        public BuscadorDocumentosLaserficheRepositoryAccess(Session sesion)
        {
            Sesion = sesion;
        }

        public BuscadorDocumentosLaserficheRepositoryAccess(string servidor = "ServerWA", string repositorio = "DA-HINOJOSA", string usuario = "ADMIN", string contraseña = "A12345678")
        {
            Sesion = Session.Create(servidor, repositorio, usuario, contraseña);
        }


        public IEnumerable<DocumentoRepositorio> BuscarDocumentosExpediente(IEnumerable<string> referencias, IEnumerable<string> nombreDocumentos)
        {
            List<DocumentoRepositorio> resultado = new List<DocumentoRepositorio>();
            StringBuilder busquedaStr = new StringBuilder();
            foreach (string referencia in referencias)
            {
                busquedaStr.Append("({LF:Name=\"" + referencia + "\", Type=\"F\" } & ({LF:ParentName=\"IMPO\"}|{LF:ParentName=\"EXPO\"})) |");
            }
            busquedaStr.Remove(busquedaStr.Length - 1, 1);

            Search busqueda = new Search(Sesion, busquedaStr.ToString());
            busqueda.Run();

            SearchListingSettings configuracionResultadoBusqueda = new SearchListingSettings();
            configuracionResultadoBusqueda.EntryFilter = EntryTypeFilter.Folders;

            SearchResultListing resultadosBusqueda = busqueda.GetResultListing(configuracionResultadoBusqueda);

            //Atencion: Este listado esta en base 1
            for (int i = 1; i <= resultadosBusqueda.RowCount; i++)
            {
                EntryInfo informacionEntrada = resultadosBusqueda.GetEntryInfo(i);
                ExplorarDirectorio(informacionEntrada, informacionEntrada.Name, ref resultado);
            }

            busqueda.Close();



            return resultado;
        }

        public async Task<IEnumerable<DocumentoRepositorio>> BuscarDocumentosExpedienteAsync(IEnumerable<string> referencias, IEnumerable<string> nombreDocumentos)
        {
            return await Task.Run(() => BuscarDocumentosExpediente(referencias, nombreDocumentos));
        }

        public void Dispose()
        {
            Close();

        }

        public void Open()
        {
            RepositoryRegistration repositorio = Sesion.Repository;
            Sesion.Connect(repositorio);
        }

        public async Task OpenAsync()
        {
            await Task.Run(() => Open());
        }

        public void Close()
        {
            Sesion.Close();
        }

        protected void ExplorarDirectorio(EntryInfo informacionEntrada, string referencia, ref List<DocumentoRepositorio> listadoDocumentos)
        {
            if (informacionEntrada.EntryType == EntryType.Folder)
            {
                FolderInfo directorioLF = Folder.GetFolderInfo(informacionEntrada.Id, Sesion);

                var configuracionListadoEntrada = new EntryListingSettings();
                FolderListing contenidoDirectorio = directorioLF.OpenFolderListing(configuracionListadoEntrada);

                for (int j = 1; j <= contenidoDirectorio.RowCount; j++)
                {

                    EntryInfo informacionEntradaLF = contenidoDirectorio.GetEntryInfo(j);

                    if (informacionEntradaLF.EntryType == EntryType.Document)
                    {
                        DocumentInfo informacionDocumentoLF = Document.GetDocumentInfo(informacionEntradaLF.Id, Sesion);
                        DocumentoRepositorio documentoRepositorio = new DocumentoRepositorio()
                        {
                            Directorio = false,
                            DocumentoAsociado = informacionDocumentoLF,
                            IdDocumento = informacionDocumentoLF.Id.ToString(),
                            Nombre = informacionDocumentoLF.Name,
                            Referencia = referencia,
                            Plantilla = informacionDocumentoLF.TemplateName,
                            Repositorio = Repositorio.Laserfiche,
                            Ruta = informacionDocumentoLF.Path,
                            TipoMime = informacionDocumentoLF.MimeType
                        };

                        listadoDocumentos.Add(documentoRepositorio);
                    }
                    else if (informacionEntradaLF.EntryType == EntryType.Folder)
                    {
                        ExplorarDirectorio(informacionEntradaLF, referencia, ref listadoDocumentos);
                    }
                }

            }
        }



        public DocumentoRepositorio BuscaCarpetaContenedora(string Ruta)
        {
            FolderInfo directorio;
            try
            {
                directorio = Folder.GetFolderInfo(Ruta, Sesion);
            }catch(Exception e)
            {
                return null;
            }
            DocumentoRepositorio documento = new DocumentoRepositorio()
            {
                Directorio = true,
                DocumentoAsociado = directorio,
                Nombre = directorio.Name,
                Repositorio = Repositorio.Laserfiche
            };

            return documento;
        }

        public DocumentoRepositorio BuscarCarpetaReferencia(string Referencia)
        {
            string busquedaStr = "{LF:Name=\"" + Referencia + "\", Type=\"F\" } & ({LF:ParentName=\"IMPO\"}|{LF:ParentName=\"EXPO\"})";
            using (Search busqueda = new Search(Sesion, busquedaStr))
            {
                busqueda.Run();

                SearchListingSettings configuracionResultadoBusqueda = new SearchListingSettings();
                configuracionResultadoBusqueda.EntryFilter = EntryTypeFilter.Folders;
                FolderInfo informacionEntrada;

                SearchResultListing resultadosBusqueda = busqueda.GetResultListing(configuracionResultadoBusqueda);
                try
                {
                    informacionEntrada = (FolderInfo)resultadosBusqueda.GetEntryInfo(1);
                }
                catch (Exception exc)
                {
                    return null;
                }
                finally
                {
                    busqueda.Close();
                }


                DocumentoRepositorio documento = new DocumentoRepositorio()
                {
                    Directorio = true,
                    Nombre = informacionEntrada.Name,
                    Repositorio = Repositorio.Laserfiche,
                    IdDocumento = informacionEntrada.Id.ToString(),
                    Referencia = Referencia,
                    Ruta = informacionEntrada.Path
                };

                return documento;
            }
        }
    }
}
