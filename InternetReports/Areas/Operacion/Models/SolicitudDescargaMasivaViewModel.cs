using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InternetReports.Areas.Operacion.Models
{
    public class SolicitudDescargaMasivaViewModel
    {
        
        [DisplayName("Solicitud")]
        public string NombreSolicitud { get; set; }
        [Required]
        public DateTime FechaInicio { get; set; }
        [Required]
        public DateTime FechaFin { get; set; }
        public string Descripcion { get; set; }
        [Required]
        public string Notificar { get; set; }
    }
}