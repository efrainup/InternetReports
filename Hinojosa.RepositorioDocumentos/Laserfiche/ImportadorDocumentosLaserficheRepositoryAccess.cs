using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Laserfiche.DocumentServices;
using Laserfiche.RepositoryAccess;

namespace Hinojosa.RepositorioDocumentos.Laserfiche
{
    public class ImportadorDocumentosLaserficheRepositoryAccess : IImportadorDocumentos<DocumentoRepositorio>, IDisposable
    {
        public Session LFSesion { get; set; }

        public ImportadorDocumentosLaserficheRepositoryAccess(Session LaserficheSesion)
        {
            LFSesion = LaserficheSesion;
        }

        public ImportadorDocumentosLaserficheRepositoryAccess(string servidor = "ServerWA", string repositorio = "DA-HINOJOSA", string usuario = "ADMIN", string contraseña = "A12345678")
        {
            LFSesion = Session.Create(servidor, repositorio, usuario, contraseña);
        }

        public DocumentoRepositorio CrearDocumentoRepositorio(string nombre, string ruta, string referencia, string pedimento)
        {
            
            

            return new DocumentoRepositorio()
            {
                Nombre = nombre,
                //Ruta = informacionEntrada.Path,
                Referencia = referencia,
                Pedimento = pedimento,
                 Directorio = false
                  
            };
        }

        public void Import(object file, DocumentoRepositorio DocumentoRepositorio)
        {

            FolderInfo folderInfo = Folder.GetFolderInfo(DocumentoRepositorio.Ruta, LFSesion);
            int documentoResultado = Document.Create(folderInfo, DocumentoRepositorio.Nombre, EntryNameOption.None, LFSesion);

            DocumentInfo docInfo = Document.GetDocumentInfo(documentoResultado, LFSesion);
            DocumentImporter di = new DocumentImporter();
            di.Document = docInfo;

            string mimeType = ObtenerTipoMime((Stream)file);

            di.ImportEdoc(mimeType, (Stream)file);
        }

        public void Import(string fileLocation, DocumentoRepositorio DocumentoRepositorio)
        {
            FileStream file = File.OpenRead(fileLocation);
            FolderInfo folderInfo = Folder.GetFolderInfo(DocumentoRepositorio.Ruta, LFSesion);
            int documentoResultado = Document.Create(folderInfo, DocumentoRepositorio.Nombre, EntryNameOption.None, LFSesion);

            DocumentInfo docInfo = Document.GetDocumentInfo(documentoResultado, LFSesion);
            DocumentImporter di = new DocumentImporter();
            di.Document = docInfo;

            string mimeType = ObtenerTipoMime(file);

            di.ImportEdoc(mimeType, file);

        }

        public void Import(Stream file, DocumentoRepositorio DocumentoRepositorio)
        {
            FolderInfo folderInfo = Folder.GetFolderInfo(DocumentoRepositorio.Ruta, LFSesion);
            int documentoResultado = Document.Create(folderInfo, DocumentoRepositorio.Nombre, EntryNameOption.None, LFSesion);
            
            DocumentInfo docInfo = Document.GetDocumentInfo(documentoResultado, LFSesion);
            DocumentImporter di = new DocumentImporter();
            di.Document = docInfo;

            string mimeType = ObtenerTipoMime(file);

            di.ImportEdoc(mimeType, file);

            

        }

        private static string ObtenerTipoMime(Stream file)
        {
            long posicionInicial = file.Position;
            byte[] fileBytes = new byte[256];
            if (file.Length >= 256)
            {
                file.Read(fileBytes, 0, 256);
            }
            else
            {
                file.Read(fileBytes, 0, (int)file.Length);
            }

            //Regresamos a la posicion inicial
            file.Position = posicionInicial;

            uint mimetype;
            FindMimeFromData(0, null, fileBytes, 256, null, 0, out mimetype, 0);
            System.IntPtr mimeTypePtr = new IntPtr(mimetype);
            string mime = Marshal.PtrToStringUni(mimeTypePtr);

            return mime;
        }

        [DllImport(@"urlmon.dll", CharSet = CharSet.Auto)]
        private extern static System.UInt32 FindMimeFromData(
              System.UInt32 pBC,
              [MarshalAs(UnmanagedType.LPStr)] System.String pwzUrl,
              [MarshalAs(UnmanagedType.LPArray)] byte[] pBuffer,
              System.UInt32 cbSize,
              [MarshalAs(UnmanagedType.LPStr)] System.String pwzMimeProposed,
              System.UInt32 dwMimeFlags,
              out System.UInt32 ppwzMimeOut,
              System.UInt32 dwReserverd
          );


        public void Dispose()
        {
            if (LFSesion.IsConnected)
            {
                LFSesion.Close();
            }
        }

        public Task ImportAsync(object file, DocumentoRepositorio DocumentoRepositorio)
        {
            return Task.Run(() => Import(file,DocumentoRepositorio));
        }

        public Task ImportAsync(string fileLocation, DocumentoRepositorio DocumentoRepositorio)
        {
            return Task.Run(() => Import(fileLocation, DocumentoRepositorio));
        }

        public Task ImportAsync(Stream file, DocumentoRepositorio DocumentoRepositorio)
        {
            return Task.Run(() => Import(file, DocumentoRepositorio));
        }

        public void Import(object file, bool overwrite, DocumentoRepositorio DocumentoRepositorio)
        {
            EntryNameOption TipoOpcionDeEntradaSeleccionada = overwrite ? EntryNameOption.Overwrite : EntryNameOption.None;

            FolderInfo folderInfo = Folder.GetFolderInfo(DocumentoRepositorio.Ruta, LFSesion);
            DocumentInfo documentInfo = null;
            //Si el archivo existe borrar y crear nuevamente
            try
            {
                documentInfo = Document.GetDocumentInfo(folderInfo, DocumentoRepositorio.Nombre, LFSesion);
            }
            catch (Exception e)
            {
                documentInfo = null;
            }

            int documentoResultado;
            if (documentInfo == null)
            {
                documentoResultado = Document.Create(folderInfo, DocumentoRepositorio.Nombre, TipoOpcionDeEntradaSeleccionada, LFSesion);
            }
            else if (overwrite)
            {
                documentoResultado = documentInfo.Id;
            }
            else
            {
                throw new Exception("Cannot overwrite");
            }



            DocumentInfo docInfo = Document.GetDocumentInfo(documentoResultado, LFSesion);
            DocumentImporter di = new DocumentImporter();
            di.OverwritePages = overwrite;
            di.Document = docInfo;

            string mimeType = ObtenerTipoMime((Stream)file);

            di.ImportEdoc(mimeType, (Stream)file);
        }

        public void Import(string fileLocation, bool overwrite, DocumentoRepositorio DocumentoRepositorio)
        {
            EntryNameOption TipoOpcionDeEntradaSeleccionada = overwrite ? EntryNameOption.Overwrite : EntryNameOption.None;

            FileStream file = File.OpenRead(fileLocation);
            FolderInfo folderInfo = Folder.GetFolderInfo(DocumentoRepositorio.Ruta, LFSesion);
            DocumentInfo documentInfo = null;
            //Si el archivo existe borrar y crear nuevamente
            try
            {
                documentInfo = Document.GetDocumentInfo(folderInfo, DocumentoRepositorio.Nombre, LFSesion);
            }
            catch (Exception e)
            {
                documentInfo = null;
            }

            int documentoResultado;
            if (documentInfo == null)
            {
                documentoResultado = Document.Create(folderInfo, DocumentoRepositorio.Nombre, TipoOpcionDeEntradaSeleccionada, LFSesion);
            }
            else if(overwrite)
            {
                documentoResultado = documentInfo.Id;
            }
            else
            {
                throw new Exception("Cannot overwrite");
            }
            

            DocumentInfo docInfo = Document.GetDocumentInfo(documentoResultado, LFSesion);
            DocumentImporter di = new DocumentImporter();
            di.OverwritePages = overwrite;
            di.Document = docInfo;

            string mimeType = ObtenerTipoMime(file);

            di.ImportEdoc(mimeType, file);
        }

        public void Import(Stream file, bool overwrite, DocumentoRepositorio DocumentoRepositorio)
        {
            EntryNameOption TipoOpcionDeEntradaSeleccionada = overwrite ? EntryNameOption.Overwrite : EntryNameOption.None;

            FolderInfo folderInfo = Folder.GetFolderInfo(DocumentoRepositorio.Ruta, LFSesion);
            DocumentInfo documentInfo = null;
            //Si el archivo existe borrar y crear nuevamente
            try
            {
                documentInfo = Document.GetDocumentInfo(folderInfo, DocumentoRepositorio.Nombre, LFSesion);
            }
            catch (Exception e)
            {
                documentInfo = null;
            }

            int documentoResultado;
            if (documentInfo == null)
            {
                documentoResultado = Document.Create(folderInfo, DocumentoRepositorio.Nombre, TipoOpcionDeEntradaSeleccionada, LFSesion);
            }
            else if (overwrite)
            {
                documentoResultado = documentInfo.Id;
            }
            else
            {
                throw new Exception("Cannot overwrite");
            }


            DocumentInfo docInfo = Document.GetDocumentInfo(documentoResultado, LFSesion);
            DocumentImporter di = new DocumentImporter();
            di.OverwritePages = overwrite;
            di.Document = docInfo;

            string mimeType = ObtenerTipoMime(file);

            di.ImportEdoc(mimeType, file);
        }

        public Task ImportAsync(object file, bool overwrite, DocumentoRepositorio DocumentoRepositorio)
        {
            return Task.Run(() => Import(file,overwrite, DocumentoRepositorio));
        }

        public Task ImportAsync(string fileLocation, bool overwrite, DocumentoRepositorio DocumentoRepositorio)
        {
            return Task.Run(() => Import(fileLocation,overwrite, DocumentoRepositorio));
        }

        public Task ImportAsync(Stream file, bool overwrite, DocumentoRepositorio DocumentoRepositorio)
        {
            return Task.Run(() => Import(file,overwrite, DocumentoRepositorio));
        }
    }
}
