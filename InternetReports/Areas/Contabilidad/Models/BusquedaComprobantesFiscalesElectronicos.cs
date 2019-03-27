using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternetReports.Areas.Contabilidad.Models
{
    public class BusquedaComprobantesFiscalesElectronicosViewModel
    {
        public DateTime FechaDeInicio { get; set; }
        public DateTime FechaDeFin { get; set; }
        public string CuentaDeGastos { get; set; }
    }
}