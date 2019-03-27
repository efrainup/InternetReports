using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RepositorioDocumentos.SIREFile
{
    public class OperacionesDocumentosSIREFile : IOperacionesRepositorio<DocumentoRepositorio>
    {
        public ConexionEfile Conexion { get; set; }
        public WsDocumentosSirEfile.RECOValidHeader RecoToken { get; set; }
        public OperacionesDocumentosSIREFile()
        {

        }

        public OperacionesDocumentosSIREFile(WsDocumentosSirEfile.RECOValidHeader RecoToken)
        {
            this.RecoToken = RecoToken;
            Conexion = Conexion ?? new ConexionEfile();
            Conexion.RecoToken = RecoToken;
        }

        public OperacionesDocumentosSIREFile(ConexionEfile Conexion)
        {
            this.Conexion = Conexion;
        }

        public DocumentoRepositorio AgregarPlantillaArchivo(DocumentoRepositorio Archivo, string Plantilla)
        {
            throw new NotImplementedException();
        }

        public DocumentoRepositorio CopiarDocumento(DocumentoRepositorio Documento, string Ruta)
        {
            throw new NotImplementedException();
        }

        public DocumentoRepositorio CrearDirectorio(string Ruta)
        {
            throw new NotImplementedException();
        }

        public DocumentoRepositorio CrearDirectorio(DocumentoRepositorio DirectorioPadre, string NombreDirectorio)
        {
            throw new NotImplementedException();
        }

        public DocumentoRepositorio ObtenerArchivoPorId(string Identificador)
        {
            throw new NotImplementedException();
        }

        public DocumentoRepositorio ObtenerArchivoPorRuta(string Ruta)
        {
            
            throw new NotImplementedException();
        }

        public string[] RecuperarPlantillas()
        {
            
            return Conexion.WSDocumentos.ObtenerTiposDocumentosSecure(Conexion.RecoToken).Select(s => s.Descripcion).ToArray();
        }

        public DocumentoRepositorio RenombrarArchivo(DocumentoRepositorio Archivo, string Nombre)
        {
            throw new NotImplementedException();
        }
    }
}
