using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InternetReports.Areas.Reportes.Models
{
    public class OperacionViewModel
    {
        public int ObservacionesId { get; set; }
        public string ClienteId { get; set; }
        public string Referencia { get; set; }
        public string Proceso { get; set; }
        public string Observaciones { get; set; }

        public int FechaSalidaId { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DisplayName("Fecha de salida")]
        public DateTime? FechaSalida { get; set; }
        public string Callback { get; set; }
    }
}