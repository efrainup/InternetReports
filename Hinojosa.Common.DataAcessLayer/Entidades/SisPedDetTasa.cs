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

    // sis_ped_det_tasas
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisPedDetTasa
    {
        [Required]
        [Display(Name = "Id tasa")]
        public int IdTasa { get; set; } // id_tasa (Primary key)

        [Required]
        [Display(Name = "Id ped")]
        public int IdPed { get; set; } // id_ped

        [Required]
        [Display(Name = "Cve contrib")]
        public int CveContrib { get; set; } // cve_contrib

        [Required]
        [Display(Name = "Tasa contrib")]
        public decimal TasaContrib { get; set; } // tasa_contrib

        [Required]
        [Display(Name = "Cve ident tasa")]
        public int CveIdentTasa { get; set; } // cve_ident_tasa
    }

}
// </auto-generated>