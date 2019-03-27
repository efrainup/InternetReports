using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace InternetReports.Areas.Operacion.Models
{
    /// <summary>
    /// Abstraccion de la vista para la búsqueda de expedientes
    /// </summary>
    public class BusquedaExpedienteViewModel
    {
        [MaxLength(11)]
        [RegularExpression(@"\w{0,2}\d{6,7}\-[\w\d]{2}")]
        public string Referencia { get; set; }
        [MaxLength(7)]
        [RegularExpression(@"\d{7}")]
        public string Pedimento { get; set; }
        [MaxLength(3)]
        [RegularExpression(@"\d{2,3}")]
        public string Aduana { get; set; }
        [MaxLength(4)]
        [RegularExpression(@"\d{4}")]
        public string Año { get; set; }
        public List<ArchivoExpedienteViewModel> ArchivosExpediente { get; set; }
    }
}