using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RepositorioDocumentos
{
    public interface IExportadorDocumentos<T> : IConectable where T: class
    {
        /// <summary>
        /// Exporta los documentos ala ruta especificada
        /// </summary>
        /// <param name="documentos">Documentos que se van a exportar</param>
        /// <param name="ruta">Ruta a donde se van exportar los documentos</param>
        /// <param name="zip">Indica si se van a zippear los documentos</param>
        void Exportar(IEnumerable<T> documentos, string ruta, bool zip);
        /// <summary>
        /// Exporta los documentos ala ruta especificada
        /// </summary>
        /// <param name="documentos">Documentos que se van a exportar</param>
        /// <param name="ruta">Ruta a donde se van exportar los documentos</param>
        /// <param name="zip">Indica si se van a zippear los documentos</param>
        /// <param name="rutaInterna">Especifica la estructura interna de las rutas</param>
        void Exportar(IEnumerable<T> documentos,string ruta, bool zip , Func<T, string> rutaInterna);

        /// <summary>
        /// Exporta asincronamente los documentos ala ruta especificada
        /// </summary>
        /// <param name="documentos">Documentos que se van a exportar</param>
        /// <param name="ruta">Ruta a donde se van exportar los documentos</param>
        /// <param name="zip">Indica si se van a zippear los documentos</param>
        Task ExportarAsync(IEnumerable<T> documentos, string ruta, bool zip);

        /// <summary>
        /// Exporta asincronamente los documentos ala ruta especificada
        /// </summary>
        /// <param name="documentos">Documentos que se van a exportar</param>
        /// <param name="ruta">Ruta a donde se van exportar los documentos</param>
        /// <param name="zip">Indica si se van a zippear los documentos</param>
        /// <param name="rutaInterna">Especifica la estructura interna de las rutas</param>
        Task ExportarAsync(IEnumerable<T> documentos, string ruta, bool zip, Func<T, string> rutaInterna);
    }
}
