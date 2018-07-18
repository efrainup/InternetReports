using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reports.Models
{
    public class Partida
    {
        public string Referencia { get; set; }
        public string Movimiento { get; set; }
        public string Proceso { get; set; }
        public string Patente { get; set; }
        public string Aduana { get; set; }
        public string Seccion { get; set; }
        public string Pedimento { get; set; }
        [Column("Clave Pedimento")]
        [DisplayName("Clave Pedimento")]
        public string ClavePedimento { get; set; }

        [DisplayName("Fecha de pago")]
        //[Column("Fecha Pago")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? FechaPago { get; set; }
        //[Column("DescripcionAA")]
        public string Descripcion { get; set; }

        //Propiedades
        public string Status { get; set; }

        [Column("FechaApertura")]
        [DisplayName("Fecha de apertura")]
        public DateTime? FechaApertura { get; set; }

        [DisplayName("Fecha de arribo de buque")]
        public DateTime? FechaArriboDeBuque { get; set; }
        [DisplayName("Fecha de revalidación de BL")]
        public DateTime? FechaRevalidacionBL { get; set; }
        [DisplayName("Fecha de clasificación")]
        public DateTime? FechaClasificaion { get; set; }
        [DisplayName("Fecha de envío de cuenta de gastos")]
        public DateTime? FechaDeEnvioCuentaDeGastos { get; set; }
        [DisplayName("Fecha de previo")]
        public DateTime? FechaPrevio { get; set; }
        [DisplayName("Fecha de conclusión de previo")]
        public DateTime? FechaConclusionPrevio { get; set; }
        public string Observaciones { get; set; }
    }
}