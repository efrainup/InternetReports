using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RepositorioDocumentos
{
    public interface IImportadorDocumentos
    {
        void Import(object file);
        void Import(Stream file);
    }
}
