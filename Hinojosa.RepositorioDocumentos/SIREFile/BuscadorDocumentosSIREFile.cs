using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RepositorioDocumentos.SIREFile
{
    public class BuscadorDocumentosSIREFile : IBuscadorDocumentos<DocumentoRepositorio>
    {
        public object Sesion => throw new NotImplementedException();
        public WsDocumentosSirEfile.RECOValidHeader RecoToken { get; set; }
        public ConexionEfile Conexion { get; set; }
        public BuscadorDocumentosSIREFile()
        {

        }

        public BuscadorDocumentosSIREFile(ConexionEfile Conexion)
        {
            this.Conexion = Conexion;
        }
        public BuscadorDocumentosSIREFile(WsDocumentosSirEfile.RECOValidHeader RecoToken)
        {
            this.RecoToken = RecoToken;
            this.Conexion = Conexion ?? new ConexionEfile();
            this.Conexion.RecoToken = RecoToken;
        }


        public DocumentoRepositorio BuscaCarpetaContenedora(string Ruta)
        {
            throw new NotImplementedException();
        }

        public DocumentoRepositorio BuscarCarpetaReferencia(string Referencia)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<DocumentoRepositorio> BuscarDocumentosExpediente(IEnumerable<string> referencias, IEnumerable<string> nombreDocumentos)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<DocumentoRepositorio>> BuscarDocumentosExpedienteAsync(IEnumerable<string> referencias, IEnumerable<string> nombreDocumentos)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Open()
        {
            throw new NotImplementedException();
        }

        public Task OpenAsync()
        {
            throw new NotImplementedException();
        }
    }
}
