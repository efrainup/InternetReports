using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RepositorioDocumentos.SIREFile
{
    public class ExportadorDocumentosSIREFile : IExportadorDocumentos<DocumentoRepositorio>
    {
        public WsDocumentosSirEfile.RECOValidHeader RecoToken  { get; set; }
        public object Sesion => throw new NotImplementedException();

        public ExportadorDocumentosSIREFile()
        {

        }

        public ExportadorDocumentosSIREFile(WsDocumentosSirEfile.RECOValidHeader RecoToken)
        {
            this.RecoToken = RecoToken;
        }

        public void Close()
        {
            throw new NotImplementedException();
        }

        public void Exportar(IEnumerable<DocumentoRepositorio> documentos, string ruta, bool zip)
        {
            throw new NotImplementedException();
        }

        public void Exportar(IEnumerable<DocumentoRepositorio> documentos, string ruta, bool zip, Func<DocumentoRepositorio, string> rutaInterna)
        {
            throw new NotImplementedException();
        }

        public Task ExportarAsync(IEnumerable<DocumentoRepositorio> documentos, string ruta, bool zip)
        {
            throw new NotImplementedException();
        }

        public Task ExportarAsync(IEnumerable<DocumentoRepositorio> documentos, string ruta, bool zip, Func<DocumentoRepositorio, string> rutaInterna)
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
