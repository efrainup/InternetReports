using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternetReports.Areas.Reportes.Models
{
    [Table("EdicionesReportes")]
    public class EdicionReporte
    {
        [Key]
        public int EdicionId { get; set; }
        public string ReporteId { get; set; }
        public string ClienteId { get; set; }
        public string IdentificadorRegistro { get; set; }
        public string Valor { get; set; }
        public string Campo { get; set; }
        public string TipoNet { get; set; }
        public string TipoSql { get; set; }

    }
}