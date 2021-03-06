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

    // SIR_390_VINS_PENDIENTES_HONDA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir390VinsPendientesHonda
    {
        [Required]
        [Display(Name = "N ID vins pendiente 390")]
        public int NIdVinsPendiente390 { get; set; } // nIdVinsPendiente390 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S factura")]
        public string SFactura { get; set; } // sFactura (length: 30)

        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "S contador")]
        public string SContador { get; set; } // sContador (length: 3)

        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "S partida")]
        public string SPartida { get; set; } // sPartida (length: 3)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S num vin")]
        public string SNumVin { get; set; } // sNumVIN (length: 30)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S engine num")]
        public string SEngineNum { get; set; } // sEngineNum (length: 30)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S num caja")]
        public string SNumCaja { get; set; } // sNumCaja (length: 30)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S color")]
        public string SColor { get; set; } // sColor (length: 30)
    }

}
// </auto-generated>
