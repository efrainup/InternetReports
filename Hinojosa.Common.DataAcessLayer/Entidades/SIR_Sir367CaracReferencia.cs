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

    // SIR_367_CARAC_REFERENCIA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir367CaracReferencia
    {
        [Required]
        [Display(Name = "N ID carac ref 367")]
        public int NIdCaracRef367 { get; set; } // nIdCaracRef367 (Primary key)

        [Required]
        [Display(Name = "N ID carac 130")]
        public int NIdCarac130 { get; set; } // nIdCarac130

        [Required]
        [Display(Name = "N ID referencia 60")]
        public int NIdReferencia60 { get; set; } // nIdReferencia60

        [Display(Name = "S valor")]
        public string SValor { get; set; } // sValor

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir130Caracteristica pointed by [SIR_367_CARAC_REFERENCIA].([NIdCarac130]) (FK_367_CARAC_REFERENCIA_SIR_130_CARACTERISTICAS)
        /// </summary>
        public virtual SIR_Sir130Caracteristica SIR_Sir130Caracteristica { get; set; } // FK_367_CARAC_REFERENCIA_SIR_130_CARACTERISTICAS

        /// <summary>
        /// Parent SIR_Sir60Referencia pointed by [SIR_367_CARAC_REFERENCIA].([NIdReferencia60]) (FK_367_CARAC_REFERENCIA_SIR_60_REFERENCIAS)
        /// </summary>
        public virtual SIR_Sir60Referencia SIR_Sir60Referencia { get; set; } // FK_367_CARAC_REFERENCIA_SIR_60_REFERENCIAS
    }

}
// </auto-generated>