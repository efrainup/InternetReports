using System;
using System.Collections.Generic;
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
        public string Callback { get; set; }
    }
}