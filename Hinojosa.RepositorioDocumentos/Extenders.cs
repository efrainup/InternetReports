using Laserfiche.RepositoryAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RepositorioDocumentos
{
    public static class Extenders
    {
        [Obsolete("Utilice la extensión ExtraerDocumentos",false)]
        public static IEnumerable<DocumentoRepositorio> RecuperarDocumentos(this DocumentoRepositorio directorio, Session sesion)
        {
            if (!directorio.Directorio)
            {
                throw new Exception("No es directorio");
            }


            if(directorio.Repositorio == Repositorio.Laserfiche)
            {
                FolderInfo directorioAsociado = (FolderInfo)directorio.DocumentoAsociado;
                var ens = new EntryListingSettings();
                ens.EntryFilter = EntryTypeFilter.Documents;
                ens.AddColumn(SystemColumn.Name);
                ens.AddColumn(SystemColumn.Uuid);
                FolderListing listado =  directorioAsociado.OpenFolderListing(ens);

                List<DocumentoRepositorio> documentoRepositorios = new List<DocumentoRepositorio>();

                DocumentoRepositorio documentoRepositorio = new DocumentoRepositorio();

                for (int registro = 1; registro <= listado.RowCount; registro++)
                {
                    EntryInfo informacionEntrada = listado.GetEntryInfo(registro);

                    

                    documentoRepositorio.Directorio = informacionEntrada.EntryType == EntryType.Folder;
                    DocumentInfo documentInfo = null;
                    FolderInfo folderInfo = null;
                    if (documentoRepositorio.Directorio)
                    {
                        folderInfo = Folder.GetFolderInfo(informacionEntrada.Id, sesion);
                        documentoRepositorio.DocumentoAsociado = folderInfo;
                        
                    }
                    else
                    {
                        documentInfo = Document.GetDocumentInfo(informacionEntrada.Id, sesion);
                        documentoRepositorio.DocumentoAsociado = documentInfo;
                    }
                    documentoRepositorio.Repositorio = Repositorio.Laserfiche;
                    documentoRepositorio.Nombre = documentoRepositorio.Directorio ? folderInfo.Name : documentInfo.Name;
                    documentoRepositorio.Plantilla = documentInfo.TemplateName;
                    documentoRepositorios.Add(documentoRepositorio);
                }


                return documentoRepositorios;

            }

            return new List<DocumentoRepositorio>();
        }

        /// <summary>
        /// Obtiene los documentos contenidos en una carpeta de repositorio
        /// </summary>
        /// <param name="directorio">Objeto que representa una carpeta</param>
        /// <param name="sesion">Objeto de sesión del repositorio</param>
        /// <returns>Lista de documentos</returns>
        public static IEnumerable<DocumentoRepositorio> ExtraerDocumentos(this DocumentoRepositorio directorio, object sesion = null)
        {
            if (!directorio.Directorio)
            {
                throw new Exception("No es directorio");
            }

            if (directorio.Repositorio == Repositorio.Laserfiche)
            {
                FolderInfo directorioAsociado = (FolderInfo)directorio.DocumentoAsociado;
                var ens = new EntryListingSettings();
                ens.EntryFilter = EntryTypeFilter.Documents;
                ens.AddColumn(SystemColumn.Name);
                ens.AddColumn(SystemColumn.Uuid);
                FolderListing listado = directorioAsociado.OpenFolderListing(ens);

                List<DocumentoRepositorio> documentoRepositorios = new List<DocumentoRepositorio>();


                for (int registro = 1; registro <= listado.RowCount; registro++)
                {
                    DocumentoRepositorio documentoRepositorio = new DocumentoRepositorio();
                    EntryInfo informacionEntrada = listado.GetEntryInfo(registro);



                    documentoRepositorio.Directorio = informacionEntrada.EntryType == EntryType.Folder;
                    DocumentInfo documentInfo = null;
                    FolderInfo folderInfo = null;
                    if (documentoRepositorio.Directorio)
                    {
                        folderInfo = Folder.GetFolderInfo(informacionEntrada.Id, (Session)sesion);
                        documentoRepositorio.DocumentoAsociado = folderInfo;

                    }
                    else
                    {
                        documentInfo = Document.GetDocumentInfo(informacionEntrada.Id, (Session)sesion);
                        documentoRepositorio.DocumentoAsociado = documentInfo;
                    }
                    documentoRepositorio.Repositorio = Repositorio.Laserfiche;
                    documentoRepositorio.Nombre = documentoRepositorio.Directorio ? folderInfo.Name : documentInfo.Name;
                    documentoRepositorio.Plantilla = documentInfo.TemplateName;
                    documentoRepositorio.Ruta = documentoRepositorio.Directorio ? folderInfo.Path : documentInfo.Path;
                    documentoRepositorios.Add(documentoRepositorio);
                }


                return documentoRepositorios;

            }

            return new List<DocumentoRepositorio>();
        }

        /// <summary>
        /// Obtiene los documentos contenidos en una carpeta de repositorio asincrónicamente
        /// </summary>
        /// <param name="directorio">Objeto que representa una carpeta</param>
        /// <param name="sesion">Objeto de sesión del repositorio</param>
        /// <returns>Lista de documentos</returns>
        public static Task<IEnumerable<DocumentoRepositorio>> ExtraerDocumentosAsync(this DocumentoRepositorio directorio, object sesion = null)
        {
            if (!directorio.Directorio)
            {
                throw new Exception("No es directorio");
            }

            return Task.Run<IEnumerable<DocumentoRepositorio>>(() =>
            {
                if (directorio.Repositorio == Repositorio.Laserfiche)
                {
                    FolderInfo directorioAsociado = (FolderInfo)directorio.DocumentoAsociado;
                    var ens = new EntryListingSettings();
                    ens.EntryFilter = EntryTypeFilter.Documents;
                    ens.AddColumn(SystemColumn.Name);
                    ens.AddColumn(SystemColumn.Uuid);
                    FolderListing listado = directorioAsociado.OpenFolderListing(ens);

                    List<DocumentoRepositorio> documentoRepositorios = new List<DocumentoRepositorio>();


                    for (int registro = 1; registro <= listado.RowCount; registro++)
                    {
                        DocumentoRepositorio documentoRepositorio = new DocumentoRepositorio();
                        EntryInfo informacionEntrada = listado.GetEntryInfo(registro);



                        documentoRepositorio.Directorio = informacionEntrada.EntryType == EntryType.Folder;
                        DocumentInfo documentInfo = null;
                        FolderInfo folderInfo = null;
                        if (documentoRepositorio.Directorio)
                        {
                            folderInfo = Folder.GetFolderInfo(informacionEntrada.Id, (Session)sesion);
                            documentoRepositorio.DocumentoAsociado = folderInfo;

                        }
                        else
                        {
                            documentInfo = Document.GetDocumentInfo(informacionEntrada.Id, (Session)sesion);
                            documentoRepositorio.DocumentoAsociado = documentInfo;
                        }
                        documentoRepositorio.Repositorio = Repositorio.Laserfiche;
                        documentoRepositorio.Nombre = documentoRepositorio.Directorio ? folderInfo.Name : documentInfo.Name;
                        documentoRepositorio.Plantilla = documentInfo.TemplateName;
                        documentoRepositorio.Ruta = documentoRepositorio.Directorio ? folderInfo.Path: documentInfo.Path;
                        documentoRepositorios.Add(documentoRepositorio);
                    }


                    return documentoRepositorios;

                }

                return new List<DocumentoRepositorio>();
            });
        }

        /// <summary>
        /// Obtiene los directorios contenidos en una carpeta de repositorio
        /// </summary>
        /// <param name="directorio">Objeto que representa una carpeta</param>
        /// <param name="sesion">Objeto de sesión del repositorio</param>
        /// <returns>Lista de documentos</returns>
        public static IEnumerable<DocumentoRepositorio> ExtraerDirectorios(this DocumentoRepositorio directorio, object sesion = null)
        {
            if (!directorio.Directorio)
            {
                throw new Exception("No es directorio");
            }

            if (directorio.Repositorio == Repositorio.Laserfiche)
            {
                FolderInfo directorioAsociado = (FolderInfo)directorio.DocumentoAsociado;
                var ens = new EntryListingSettings();
                ens.EntryFilter = EntryTypeFilter.Folders;
                ens.AddColumn(SystemColumn.Name);
                ens.AddColumn(SystemColumn.Uuid);
                FolderListing listado = directorioAsociado.OpenFolderListing(ens);

                List<DocumentoRepositorio> documentoRepositorios = new List<DocumentoRepositorio>();


                for (int registro = 1; registro <= listado.RowCount; registro++)
                {
                    DocumentoRepositorio documentoRepositorio = new DocumentoRepositorio();
                    EntryInfo informacionEntrada = listado.GetEntryInfo(registro);



                    documentoRepositorio.Directorio = informacionEntrada.EntryType == EntryType.Folder;
                    DocumentInfo documentInfo = null;
                    FolderInfo folderInfo = null;
                    if (documentoRepositorio.Directorio)
                    {
                        folderInfo = Folder.GetFolderInfo(informacionEntrada.Id, (Session)sesion);
                        documentoRepositorio.DocumentoAsociado = folderInfo;

                    }
                    else
                    {
                        documentInfo = Document.GetDocumentInfo(informacionEntrada.Id, (Session)sesion);
                        documentoRepositorio.DocumentoAsociado = documentInfo;
                    }
                    documentoRepositorio.Repositorio = Repositorio.Laserfiche;
                    documentoRepositorio.Nombre = documentoRepositorio.Directorio ? folderInfo.Name : documentInfo.Name;
                    documentoRepositorio.Ruta = folderInfo.Path;
                    //documentoRepositorio.Plantilla = documentInfo.TemplateName;
                    documentoRepositorios.Add(documentoRepositorio);
                }


                return documentoRepositorios;

            }

            return new List<DocumentoRepositorio>();
        }

        /// <summary>
        /// Obtiene los directorios contenidos en una carpeta de repositorio asincrónicamente
        /// </summary>
        /// <param name="directorio">Objeto que representa una carpeta</param>
        /// <param name="sesion">Objeto de sesión del repositorio</param
        /// 
        /// <returns>Lista de documentos</returns>
        public static Task<IEnumerable<DocumentoRepositorio>> ExtraerDirectoriosAsync(this DocumentoRepositorio directorio, object sesion = null)
        {
            if (!directorio.Directorio)
            {
                throw new Exception("No es directorio");
            }

            return Task.Run<IEnumerable<DocumentoRepositorio>>(() =>
            {
                if (directorio.Repositorio == Repositorio.Laserfiche)
                {
                    FolderInfo directorioAsociado = (FolderInfo)directorio.DocumentoAsociado;
                    var ens = new EntryListingSettings();
                    ens.EntryFilter = EntryTypeFilter.Folders;
                    ens.AddColumn(SystemColumn.Name);
                    ens.AddColumn(SystemColumn.Uuid);
                    FolderListing listado = directorioAsociado.OpenFolderListing(ens);

                    List<DocumentoRepositorio> documentoRepositorios = new List<DocumentoRepositorio>();


                    for (int registro = 1; registro <= listado.RowCount; registro++)
                    {
                        DocumentoRepositorio documentoRepositorio = new DocumentoRepositorio();
                        EntryInfo informacionEntrada = listado.GetEntryInfo(registro);



                        documentoRepositorio.Directorio = informacionEntrada.EntryType == EntryType.Folder;
                        DocumentInfo documentInfo = null;
                        FolderInfo folderInfo = null;
                        if (documentoRepositorio.Directorio)
                        {
                            folderInfo = Folder.GetFolderInfo(informacionEntrada.Id, (Session)sesion);
                            documentoRepositorio.DocumentoAsociado = folderInfo;

                        }
                        else
                        {
                            documentInfo = Document.GetDocumentInfo(informacionEntrada.Id, (Session)sesion);
                            documentoRepositorio.DocumentoAsociado = documentInfo;
                        }
                        documentoRepositorio.Repositorio = Repositorio.Laserfiche;
                        documentoRepositorio.Nombre = documentoRepositorio.Directorio ? folderInfo.Name : documentInfo.Name;
                        //documentoRepositorio.Plantilla = documentInfo.TemplateName;
                        documentoRepositorio.Ruta = folderInfo.Path;
                        documentoRepositorios.Add(documentoRepositorio);
                    }


                    return documentoRepositorios;

                }

                return new List<DocumentoRepositorio>();
            });
        }
    }
}
