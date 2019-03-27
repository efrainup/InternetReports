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

    // bco_edo_cta_cmp
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class BcoEdoCtaCmp
    {
        [Required]
        [Display(Name = "Id cmp")]
        public int IdCmp { get; set; } // id_cmp (Primary key)

        [Required]
        [Display(Name = "Id cta")]
        public int IdCta { get; set; } // id_cta (Primary key)

        [Required]
        [Display(Name = "Cmp erp")]
        public int CmpErp { get; set; } // cmp_erp (Primary key)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Cmp lay")]
        public string CmpLay { get; set; } // cmp_lay (length: 50)

        [Required]
        [Display(Name = "Orden")]
        public int Orden { get; set; } // orden (Primary key)
    }

}
// </auto-generated>
