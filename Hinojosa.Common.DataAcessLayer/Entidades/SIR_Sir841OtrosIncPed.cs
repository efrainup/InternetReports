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

    // SIR_841_OTROS_INC_PED
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir841OtrosIncPed
    {
        [Required]
        [Display(Name = "N ID otros inc ped 841")]
        public int NIdOtrosIncPed841 { get; set; } // nIdOtrosIncPed841 (Primary key)

        [Display(Name = "N ID pedimento 149")]
        public int? NIdPedimento149 { get; set; } // nIdPedimento149

        [Display(Name = "N importe")]
        public decimal? NImporte { get; set; } // nImporte

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "S moneda")]
        public string SMoneda { get; set; } // sMoneda (length: 10)

        [Display(Name = "N ID cat increment mv 840")]
        public int? NIdCatIncrementMv840 { get; set; } // nIdCatIncrementMV840

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir149Pedimento pointed by [SIR_841_OTROS_INC_PED].([NIdPedimento149]) (FK_SIR_841_OTROS_INC_PED_SIR_149_PEDIMENTO)
        /// </summary>
        public virtual SIR_Sir149Pedimento SIR_Sir149Pedimento { get; set; } // FK_SIR_841_OTROS_INC_PED_SIR_149_PEDIMENTO

        /// <summary>
        /// Parent SIR_Sir840CatalogoIncrementablesMv pointed by [SIR_841_OTROS_INC_PED].([NIdCatIncrementMv840]) (FK_SIR_841_OTROS_INC_PED_SIR_840_CATALOGO_INCREMENTABLES_MV)
        /// </summary>
        public virtual SIR_Sir840CatalogoIncrementablesMv SIR_Sir840CatalogoIncrementablesMv { get; set; } // FK_SIR_841_OTROS_INC_PED_SIR_840_CATALOGO_INCREMENTABLES_MV
    }

}
// </auto-generated>
