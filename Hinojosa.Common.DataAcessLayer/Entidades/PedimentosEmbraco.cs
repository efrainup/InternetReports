// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning

using System.ComponentModel.DataAnnotations;

namespace Hinojosa.Common.DataAccessLayer.Entidades
{

    // Pedimentos_Embraco
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class PedimentosEmbraco
    {
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Referencia")]
        public string Referencia { get; set; } // Referencia (length: 15)

        [MaxLength(8)]
        [StringLength(8)]
        [Display(Name = "Pedimento")]
        public string Pedimento { get; set; } // Pedimento (length: 8)

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha pago")]
        public System.DateTime? FechaPago { get; set; } // Fecha Pago

        [Display(Name = "Movimiento")]
        public int? Movimiento { get; set; } // Movimiento

        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Clave pedimento")]
        public string ClavePedimento { get; set; } // Clave Pedimento (length: 3)

        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Patente")]
        public string Patente { get; set; } // Patente (length: 5)

        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "Aduana")]
        public string Aduana { get; set; } // Aduana (length: 2)

        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Seccion")]
        public string Seccion { get; set; } // Seccion (length: 1)

        [MaxLength(8)]
        [StringLength(8)]
        [Display(Name = "Serie")]
        public string Serie { get; set; } // Serie (length: 8)

        [Display(Name = "Numero")]
        public int? Numero { get; set; } // Numero

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha cuenta")]
        public System.DateTime? FechaCuenta { get; set; } // Fecha Cuenta

        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Fecha envio")]
        public string FechaEnvio { get; set; } // Fecha Envio (length: 25)

        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "Pendiente")]
        public string Pendiente { get; set; } // Pendiente (length: 2)

        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Nota")]
        public string Nota { get; set; } // Nota (length: 250)

        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Fecha actualiza")]
        public string FechaActualiza { get; set; } // FechaActualiza (length: 25)

        [Required]
        [Display(Name = "Cuenta g")]
        public int CuentaG { get; set; } // CuentaG (Primary key)

        [Required]
        [Display(Name = "Comprobante")]
        public int Comprobante { get; set; } // Comprobante (Primary key)

        [Display(Name = "Env completo")]
        public int? EnvCompleto { get; set; } // EnvCompleto

        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Fecha completo")]
        public string FechaCompleto { get; set; } // FechaCompleto (length: 25)

        [Display(Name = "Pedimento s")]
        public int? PedimentoS { get; set; } // PedimentoS

        [Display(Name = "Pedimento p")]
        public int? PedimentoP { get; set; } // PedimentoP

        [Display(Name = "Factura")]
        public int? Factura { get; set; } // Factura

        [Display(Name = "Detalle c")]
        public int? DetalleC { get; set; } // DetalleC

        [Display(Name = "Acuse c")]
        public int? AcuseC { get; set; } // AcuseC

        [Display(Name = "Xml c")]
        public int? XmlC { get; set; } // XmlC

        [Display(Name = "Hyc")]
        public int? Hyc { get; set; } // HYC

        [Display(Name = "Vucem")]
        public int? Vucem { get; set; } // Vucem

        [Display(Name = "Expediente")]
        public int? Expediente { get; set; } // Expediente

        [Display(Name = "Listo enviar")]
        public int? ListoEnviar { get; set; } // ListoEnviar

        [Display(Name = "Es oc")]
        public int? EsOc { get; set; } // EsOC

        [Display(Name = "Ed ocument")]
        public int? EDocument { get; set; } // EDocument

        public PedimentosEmbraco()
        {
            CuentaG = 0;
            Comprobante = 0;
            Expediente = 0;
            ListoEnviar = 0;
            EsOc = 0;
        }
    }

}
// </auto-generated>
