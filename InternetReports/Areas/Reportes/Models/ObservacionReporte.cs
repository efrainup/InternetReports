using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetReports.Areas.Reportes.Models
{
    [Table("ObservacionesReportes")]
    public class ObservacionReporte
    {
        [Key]
        public int IdAtributo { get; set; }
        public string ReporteId { get; set; }
        public string ClienteId { get; set; }
        public string IdentificadorRegistro { get; set; }
        public string Observacion { get; set; }
    }
}