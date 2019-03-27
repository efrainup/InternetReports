using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RepositorioDocumentos
{
    /// <summary>
    /// Enumera los tipos de repositorios que se han utilizado. 
    /// Agregar uno nuevo en caso de que el repositorio de documentos cambie.
    /// </summary>
    public enum Repositorio
    {
        Laserfiche,
        FileSystem,
        SIREFile
    }
}
