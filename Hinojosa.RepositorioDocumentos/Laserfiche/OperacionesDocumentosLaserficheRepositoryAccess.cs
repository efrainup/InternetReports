using Laserfiche.RepositoryAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RepositorioDocumentos.Laserfiche
{
    public class OperacionesDocumentosLaserficheRepositoryAccess : IOperacionesRepositorio<DocumentoRepositorio>
    {
        


        public Session sesion { get; protected set; }

        public OperacionesDocumentosLaserficheRepositoryAccess(Session sesion)
        {
            this.sesion = sesion;
        }

        public OperacionesDocumentosLaserficheRepositoryAccess(string servidor = "ServerWA", string repositorio = "DA-HINOJOSA", string usuario = "ADMIN", string contraseña = "A12345678")
        {
            sesion = Session.Create(servidor, repositorio, usuario, contraseña);
        }

        public DocumentoRepositorio CopiarDocumento(DocumentoRepositorio Documento, string Ruta)
        {
            Ruta += Ruta.EndsWith("\\") ? "" : "\\";
            DocumentInfo informacionDocumento = Documento.DocumentoAsociado as DocumentInfo;
            int idResultante = informacionDocumento.CopyTo(Ruta +  Documento.Nombre);

            DocumentInfo documentoCopiado = Document.GetDocumentInfo(idResultante, sesion);

            DocumentoRepositorio documentoResultante = new DocumentoRepositorio()
            {
                Directorio = false,
                Nombre = documentoCopiado.Name,
                Plantilla = documentoCopiado.TemplateName,
                Ruta = documentoCopiado.Path,
                Repositorio = Repositorio.Laserfiche,
                IdDocumento = documentoCopiado.Id.ToString(),
                DocumentoAsociado = documentoCopiado
            };

            return documentoResultante;
        }

        public DocumentoRepositorio RenombrarArchivo(DocumentoRepositorio Archivo, string Nombre)
        {
            DocumentInfo informacionDocumento = Archivo.DocumentoAsociado as DocumentInfo;
            informacionDocumento.RenameTo(Nombre);

            Archivo.Nombre = Nombre;
            return Archivo;
        }

        public DocumentoRepositorio AgregarPlantillaArchivo(DocumentoRepositorio Archivo, string Plantilla)
        {
            DocumentInfo informacionDocumento = Archivo.DocumentoAsociado as DocumentInfo;
            informacionDocumento.RemoveTemplate();
            informacionDocumento.SetTemplate(Plantilla, true);
            
            return Archivo;
        }

        public DocumentoRepositorio ObtenerArchivoPorId(string Identificador)
        {
            DocumentInfo documentoCopiado = Document.GetDocumentInfo(Convert.ToInt32(Identificador), sesion);

            DocumentoRepositorio documentoResultante = new DocumentoRepositorio()
            {
                Directorio = false,
                Nombre = documentoCopiado.Name,
                Plantilla = documentoCopiado.TemplateName,
                Ruta = documentoCopiado.Path,
                Repositorio = Repositorio.Laserfiche,
                IdDocumento = documentoCopiado.Id.ToString(),
                DocumentoAsociado = documentoCopiado
            };

            return documentoResultante;
        }

        public DocumentoRepositorio ObtenerArchivoPorRuta(string Ruta)
        {
            DocumentInfo documentoCopiado = null;
            try
            {
                documentoCopiado = Document.GetDocumentInfo(Ruta, sesion);
            }
            catch(LaserficheRepositoryException lfException)
            {
                return null;
            }
            catch(Exception exception)
            {
                throw exception;
            }
            DocumentoRepositorio documentoResultante = new DocumentoRepositorio()
            {
                Directorio = false,
                Nombre = documentoCopiado.Name,
                Plantilla = documentoCopiado.TemplateName,
                Ruta = documentoCopiado.Path,
                Repositorio = Repositorio.Laserfiche,
                IdDocumento = documentoCopiado.Id.ToString(),
                DocumentoAsociado = documentoCopiado
            };

            return documentoResultante;
        }

        public DocumentoRepositorio CrearDirectorio(string Ruta)
        {
            int idFolder =  Folder.Create(Ruta, "DA-HINOJOSA", EntryNameOption.AutoRename, sesion);

            if(idFolder == 0)
            {
                return null;
            }

            FolderInfo folderInfo =  Folder.GetFolderInfo(idFolder,sesion);
            return new DocumentoRepositorio()
            {
                IdDocumento = idFolder.ToString(),
                Ruta = folderInfo.Path,
                Nombre = folderInfo.Name,
                DocumentoAsociado = folderInfo,
                Directorio = true,
                Repositorio = Repositorio.Laserfiche
            };
        }

        public DocumentoRepositorio CrearDirectorio(DocumentoRepositorio DirectorioPadre, string NombreDirectorio)
        {
            if (!DirectorioPadre.Directorio)
            {
                throw new Exception("No es un directorio");
            }

            FolderInfo FolderInfoParent = (DirectorioPadre.DocumentoAsociado as FolderInfo);

            int idFolder = Folder.Create(FolderInfoParent, NombreDirectorio, EntryNameOption.AutoRename, sesion);

            if (idFolder == 0)
            {
                return null;
            }

            FolderInfo folderInfo = Folder.GetFolderInfo(idFolder, sesion);
            return new DocumentoRepositorio()
            {
                IdDocumento = idFolder.ToString(),
                Ruta = folderInfo.Path,
                Nombre = folderInfo.Name,
                DocumentoAsociado = folderInfo,
                Directorio = true,
                Repositorio = Repositorio.Laserfiche
            };
        }

        public string[] RecuperarPlantillas()
        {
            return Template.EnumAll(sesion).Select(s => s.Name).ToArray();
        }
    }
}
