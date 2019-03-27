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

    // SIR_347_PAGOS_CONTRIBUCIONES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir347PagosContribucione
    {
        [Required]
        [Display(Name = "N ID pago cont 347")]
        public int NIdPagoCont347 { get; set; } // nIdPagoCont347 (Primary key)

        [Required]
        [Display(Name = "N ID fac part agrupada 100")]
        public int NIdFacPartAgrupada100 { get; set; } // nIdFacPartAgrupada100

        [Display(Name = "N ID tipos imp 30")]
        public int? NIdTiposImp30 { get; set; } // nIdTiposImp30

        [Display(Name = "N ID forma pago 32")]
        public int? NIdFormaPago32 { get; set; } // nIdFormaPago32

        [Display(Name = "N importe")]
        public int? NImporte { get; set; } // nImporte

        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "S tipo imp")]
        public string STipoImp { get; set; } // sTipoImp (length: 5)

        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "S forma pago")]
        public string SFormaPago { get; set; } // sFormaPago (length: 2)

        [Display(Name = "N inpc")]
        public decimal? NInpc { get; set; } // nINPC

        [Display(Name = "N importe sin operar")]
        public int? NImporteSinOperar { get; set; } // nImporteSinOperar

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir100FacPartAgrupada pointed by [SIR_347_PAGOS_CONTRIBUCIONES].([NIdFacPartAgrupada100]) (FK_SIR_347_PAGOS_CONTRIBUCIONES_SIR_100_FAC_PART_AGRUPADAS)
        /// </summary>
        public virtual SIR_Sir100FacPartAgrupada SIR_Sir100FacPartAgrupada { get; set; } // FK_SIR_347_PAGOS_CONTRIBUCIONES_SIR_100_FAC_PART_AGRUPADAS

        /// <summary>
        /// Parent SIR_Sir30TiposImpuesto pointed by [SIR_347_PAGOS_CONTRIBUCIONES].([NIdTiposImp30]) (FK_SIR_347_PAGOS_CONTRIBUCIONES_SIR_30_TIPOS_IMPUESTOS)
        /// </summary>
        public virtual SIR_Sir30TiposImpuesto SIR_Sir30TiposImpuesto { get; set; } // FK_SIR_347_PAGOS_CONTRIBUCIONES_SIR_30_TIPOS_IMPUESTOS

        /// <summary>
        /// Parent SIR_Sir32FormasPago pointed by [SIR_347_PAGOS_CONTRIBUCIONES].([NIdFormaPago32]) (FK_SIR_347_PAGOS_CONTRIBUCIONES_SIR_32_FORMAS_PAGO)
        /// </summary>
        public virtual SIR_Sir32FormasPago SIR_Sir32FormasPago { get; set; } // FK_SIR_347_PAGOS_CONTRIBUCIONES_SIR_32_FORMAS_PAGO
    }

}
// </auto-generated>