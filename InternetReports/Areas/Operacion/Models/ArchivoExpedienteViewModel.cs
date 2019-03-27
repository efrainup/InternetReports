using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InternetReports.Areas.Operacion.Models
{
    /// <summary>
    /// Identifica cada archivo perteneciente al expediente
    /// </summary>
    [System.ComponentModel.DefaultBindingProperty("Identificador")]
    public class ArchivoExpedienteViewModel
    {
        /// <summary>
        /// Determina el nombre del archivo
        /// </summary>
        public string Nombre { get; set; }
        /// <summary>
        /// Identificador del archivo en el sistema del que se obtenga
        /// </summary>
        
        public string Identificador { get; set; }
        /// <summary>
        /// Atributo para determinar si el archivo se seleccionó en la vista
        /// </summary>
        public bool Seleccionado { get; set; }
        /// <summary>
        /// Identificador del repositorio de archivos (SIR EFile, Laserfiche ...)
        /// </summary>
        public string SistemaId { get; set; }
    }
}