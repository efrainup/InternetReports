using Hinojosa.RepositorioDocumentos.WsDocumentosSirEfile;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RepositorioDocumentos.SIREFile
{
    public class ImportadorDocumentosSIREFile : IImportadorDocumentos<DocumentoRepositorio>
    {
        public RECOValidHeader Sesion { get; set; }
        public ConexionEfile Conexion { get; set; }

        public ImportadorDocumentosSIREFile()
        {

        }

        public ImportadorDocumentosSIREFile(RECOValidHeader Sesion)
        {
            this.Sesion = Sesion;
        }

        public ImportadorDocumentosSIREFile(ConexionEfile ConexionEfile)
        {
            this.Conexion = ConexionEfile;
            this.Sesion = ConexionEfile.RecoToken;
        }

        public ImportadorDocumentosSIREFile(object Sesion)
        {
            this.Sesion = (RECOValidHeader)Sesion;
        }

        public DocumentoRepositorio CrearDocumentoRepositorio(string nombre, string ruta, string referencia, string pedimento)
        {
            return new DocumentoRepositorio()
            {
                Nombre = nombre,
                //Ruta = informacionEntrada.Path,
                Referencia = referencia,
                Pedimento = pedimento,
                Directorio = false,
                Repositorio = Repositorio.SIREFile
            };
        }

        public void Import(object file, DocumentoRepositorio DocumentoRepositorio)
        {
            if (file is Stream)
            {
                Import((Stream)file, DocumentoRepositorio);
            }
        }

        public void Import(string fileLocation, DocumentoRepositorio DocumentoRepositorio)
        {
            
            string DocumentoBase64 = ObtieneFileBase64(fileLocation);
            bool resultado = Conexion.WSDocumentos.ProcesarDocumentosPorArchivosReferencia(DocumentoRepositorio.Referencia, DocumentoRepositorio.Plantilla, DocumentoBase64, DocumentoRepositorio.Nombre);
            //ControlDocumentos[] t = Conexion.WSDocumentos.ObtenerDocumentosFiltradosPorNumeroReferencia(this.Sesion, DocumentoRepositorio.Referencia, eCategoriaTipoDocumento.General);

        }

        public void Import(Stream file, DocumentoRepositorio DocumentoRepositorio)
        {
            string DocumentoBase64 = ObtieneFileBase64(file);
            bool resultado = Conexion.WSDocumentos.ProcesarDocumentosPorArchivosReferencia(DocumentoRepositorio.Referencia, DocumentoRepositorio.Plantilla, DocumentoBase64, DocumentoRepositorio.Nombre);
            //ControlDocumentos[] t = Conexion.WSDocumentos.ObtenerDocumentosFiltradosPorNumeroReferencia(this.Sesion, DocumentoRepositorio.Referencia, eCategoriaTipoDocumento.General);
        }

        public void Import(object file, bool overwrite, DocumentoRepositorio DocumentoRepositorio)
        {
            if(file is Stream)
            {
                Import((Stream)file, DocumentoRepositorio);
            }
        }

        public void Import(string fileLocation, bool overwrite, DocumentoRepositorio DocumentoRepositorio)
        {
            Import(fileLocation, DocumentoRepositorio);
        }

        public void Import(Stream file, bool overwrite, DocumentoRepositorio DocumentoRepositorio)
        {
            Import(file, DocumentoRepositorio);
        }

        public Task ImportAsync(object file, DocumentoRepositorio DocumentoRepositorio)
        {
            throw new NotImplementedException();
        }

        public async Task ImportAsync(string fileLocation, DocumentoRepositorio DocumentoRepositorio)
        {
            string DocumentoBase64 = ObtieneFileBase64(fileLocation);
            bool resultado = await Conexion.WSDocumentos.ProcesarDocumentosPorArchivosReferenciaAsync(DocumentoRepositorio.Referencia, DocumentoRepositorio.Plantilla, DocumentoBase64, DocumentoRepositorio.Nombre);
        }

        public async Task ImportAsync(Stream file, DocumentoRepositorio DocumentoRepositorio)
        {
            string DocumentoBase64 = ObtieneFileBase64(file);
            bool resultado = await Conexion.WSDocumentos.ProcesarDocumentosPorArchivosReferenciaAsync(DocumentoRepositorio.Referencia, DocumentoRepositorio.Plantilla, DocumentoBase64, DocumentoRepositorio.Nombre);
        }

        public async Task ImportAsync(object file, bool overwrite, DocumentoRepositorio DocumentoRepositorio)
        {
            if (file is Stream)
            {
                string DocumentoBase64 = ObtieneFileBase64((Stream)file);
                bool resultado = await Conexion.WSDocumentos.ProcesarDocumentosPorArchivosReferenciaAsync(DocumentoRepositorio.Referencia, DocumentoRepositorio.Plantilla, DocumentoBase64, DocumentoRepositorio.Nombre);
            }
        }

        public async Task ImportAsync(string fileLocation, bool overwrite, DocumentoRepositorio DocumentoRepositorio)
        {
            await ImportAsync(fileLocation, DocumentoRepositorio);
        }

        public async Task ImportAsync(Stream file, bool overwrite, DocumentoRepositorio DocumentoRepositorio)
        {
            await ImportAsync(file, DocumentoRepositorio);
        }

        protected string ObtieneFileBase64(string strPathExportacion)
        {
            try
            {
                string empty = string.Empty;
                if (!File.Exists(strPathExportacion))
                    throw new Exception("No existe el path: " + strPathExportacion + ". Revise por favor.");
                FileInfo fileInfo = new FileInfo(strPathExportacion);
                BinaryReader binaryReader = new BinaryReader((Stream)fileInfo.OpenRead());
                byte[] inArray = binaryReader.ReadBytes(Convert.ToInt32(fileInfo.Length));
                binaryReader.Close();
                return Convert.ToBase64String(inArray);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        protected string ObtieneFileBase64(Stream strPathExportacion)
        {
            try
            {
                string empty = string.Empty;

                strPathExportacion.Position = 0;
                BinaryReader binaryReader = new BinaryReader(strPathExportacion);
                byte[] inArray = binaryReader.ReadBytes(Convert.ToInt32(strPathExportacion.Length));
                binaryReader.Close();
                return Convert.ToBase64String(inArray);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
