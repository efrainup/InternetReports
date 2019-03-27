using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RepositorioDocumentos
{
    public interface IConectable
    {
        /// <summary>
        /// Abre una conexión al repositorio de documentos
        /// </summary>
        void Open();
        /// <summary>
        /// Abre una conexión asíncronamente al repositorio de documentos
        /// </summary>
        /// <returns></returns>
        Task OpenAsync();
        /// <summary>
        /// Cierra una conexión al repositorio de documentos
        /// </summary>
        void Close();
        /// <summary>
        /// Obtiene el objeto de sesion
        /// </summary>
        object Sesion { get;}
    }
}
