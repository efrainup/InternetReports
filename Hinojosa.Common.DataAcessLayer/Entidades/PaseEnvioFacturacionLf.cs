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

    // Pase_Envio_Facturacion_LF
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class PaseEnvioFacturacionLf
    {
        [Required]
        [Display(Name = "N ID pase fact")]
        public int NIdPaseFact { get; set; } // nIdPaseFact (Primary key)

        [Required]
        [Display(Name = "N ID referencia")]
        public int NIdReferencia { get; set; } // nIdReferencia

        [Required]
        [Display(Name = "N ID factura")]
        public int NIdFactura { get; set; } // nIdFactura

        [Required]
        [Display(Name = "B autorizado")]
        public bool BAutorizado { get; set; } // bAutorizado

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha autorizado")]
        public System.DateTime DFechaAutorizado { get; set; } // dFechaAutorizado

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime? DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "B enviado cliente")]
        public bool BEnviadoCliente { get; set; } // bEnviadoCliente

        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "S fecha envio")]
        public string SFechaEnvio { get; set; } // sFechaEnvio (length: 25)

        [Display(Name = "N enviar a")]
        public int? NEnviarA { get; set; } // nEnviarA

        [Display(Name = "N excepcion")]
        public int? NExcepcion { get; set; } // nExcepcion

        public PaseEnvioFacturacionLf()
        {
            BAutorizado = false;
            BEnviadoCliente = false;
        }
    }

}
// </auto-generated>