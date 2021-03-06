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

    // SIR_393_MERCANCIAS_COVE
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir393MercanciasCove
    {
        [Required]
        [Display(Name = "N ID mercancia cove 393")]
        public int NIdMercanciaCove393 { get; set; } // nIdMercanciaCove393 (Primary key)

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S marca")]
        public string SMarca { get; set; } // sMarca (length: 100)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S modelo")]
        public string SModelo { get; set; } // sModelo (length: 50)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S sub modelo")]
        public string SSubModelo { get; set; } // sSubModelo (length: 50)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S numero serie")]
        public string SNumeroSerie { get; set; } // sNumeroSerie (length: 50)

        [Required]
        [Display(Name = "N ID factura partida 11")]
        public int NIdFacturaPartida11 { get; set; } // nIdFacturaPartida11

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S lote")]
        public string SLote { get; set; } // sLote (length: 100)

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir11FacturasPartida pointed by [SIR_393_MERCANCIAS_COVE].([NIdFacturaPartida11]) (FK_SIR_393_MERCANCIAS_COVE_SIR_11_FACTURAS_PARTIDAS)
        /// </summary>
        public virtual SIR_Sir11FacturasPartida SIR_Sir11FacturasPartida { get; set; } // FK_SIR_393_MERCANCIAS_COVE_SIR_11_FACTURAS_PARTIDAS
    }

}
// </auto-generated>
