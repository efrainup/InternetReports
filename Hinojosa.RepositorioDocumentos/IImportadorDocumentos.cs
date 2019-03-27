using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RepositorioDocumentos
{
    public interface IImportadorDocumentos<T>
    {
        T CrearDocumentoRepositorio(string nombre, string ruta, string referencia, string pedimento);
        void Import(object file, T DocumentoRepositorio);
        void Import(string fileLocation, T DocumentoRepositorio);
        void Import(Stream file, T DocumentoRepositorio);
        void Import(object file,bool overwrite, T DocumentoRepositorio);
        void Import(string fileLocation, bool overwrite, T DocumentoRepositorio);
        void Import(Stream file, bool overwrite, T DocumentoRepositorio);
        Task ImportAsync(object file, T DocumentoRepositorio);
        Task ImportAsync(string fileLocation, T DocumentoRepositorio);
        Task ImportAsync(Stream file, T DocumentoRepositorio);
        Task ImportAsync(object file, bool overwrite, T DocumentoRepositorio);
        Task ImportAsync(string fileLocation, bool overwrite, T DocumentoRepositorio);
        Task ImportAsync(Stream file, bool overwrite, T DocumentoRepositorio);
    }
}
