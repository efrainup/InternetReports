using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetReports.Areas.Operacion.Models
{
    public class Expediente
    {
        public string Referencia { get; set; }
        public string Pedimento { get; set; }
        public DateTime FechaPago { get; set; }
        public string UrlDescarga { get; set; }
    }
}