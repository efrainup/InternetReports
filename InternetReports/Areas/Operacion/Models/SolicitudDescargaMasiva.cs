using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace InternetReports.Areas.Operacion.Models
{
    public class SolicitudDescargaMasiva
    {
        [Key()]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdSolicitudDescargaMasiva { get; set; }
        public string IdCliente { get; set; }
        public string Cliente { get; set; }
        [DisplayName("Solicitud")]
        public string NombreSolicitud { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }

        [DisplayName("Fecha de solicitud")]
        public DateTime FechaSolicitud { get; set; }
        public DateTime? FechaProcesado { get; set; }
        public DateTime? FechaUltimaDescarga { get; set; }
        public DateTime? FechaVigencia { get; set; }
        public string Descripcion { get; set; }
        public string UrlDescarga { get; set; }
        [DefaultValue(false)]
        public bool Procesado { get; set; }
        public string UsuarioSolicito { get; set; }
        public string RutaArchivo { get; set; }
        public string Notificar { get; set; }

    }
}