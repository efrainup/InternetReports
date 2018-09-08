using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinojosa.RepositorioDocumentos
{
    /// <summary>
    /// Abstraccion de un documento proveniente de un repositorio de archivos, 
    /// el documento se puede asociar a una referencia o pedimento
    /// </summary>
    public class DocumentoRepositorio
    {
        public string IdDocumento { get; set; }
        /// <summary>
        /// Pedimento al que se asocia el documento
        /// </summary>
        public string Pedimento { get; set; }
        /// <summary>
        /// Referencia a la que se asocia el documento
        /// </summary>
        public string Referencia { get; set; }
        /// <summary>
        /// Nombre del documento
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Ruta del documento en el repositorio
        /// </summary>
        public string Ruta { get; set; }
        /// <summary>
        /// Nombre de la plantilla a la que pertenece el documento en el repositorio
        /// </summary>
        public string Plantilla { get; set; }
        /// <summary>
        /// Tipo del documento en el repositorio
        /// </summary>
        public string TipoMime { get; set; }
        /// <summary>
        /// Documento del repositorio asociado
        /// </summary>
        public object DocumentoAsociado { get; set; }
        /// <summary>
        /// Diccionario de metadatos del documento
        /// </summary>
        public IDictionary<string,string> Metadatos { get; set; }
        /// <summary>
        /// Nombre del repositorio de archivos de donde se recuperó el documento
        /// </summary>
        public Repositorio Repositorio { get; set; }
        /// <summary>
        /// Indica si el documento es un directorio
        /// </summary>
        public bool Directorio { get; set; }
    }
}
