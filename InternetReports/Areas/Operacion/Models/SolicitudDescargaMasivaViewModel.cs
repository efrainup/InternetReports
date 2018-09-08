using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace InternetReports.Areas.Operacion.Models
{
    public class SolicitudDescargaMasivaViewModel
    {
        
        [DisplayName("Solicitud")]
        public string NombreSolicitud { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Descripcion { get; set; }
        public string Notificar { get; set; }
    }
}