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

    // cat_sat_cp
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatSatCp
    {
        [Required]
        [Display(Name = "Id cp")]
        public int IdCp { get; set; } // id_cp (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Cp")]
        public string Cp { get; set; } // cp (length: 10)

        [Required]
        [Display(Name = "Id edo")]
        public int IdEdo { get; set; } // id_edo

        [Required]
        [Display(Name = "Id mun")]
        public int IdMun { get; set; } // id_mun

        [Required]
        [Display(Name = "Id loc")]
        public int IdLoc { get; set; } // id_loc

        public CatSatCp()
        {
            IdCp = 0;
            Cp = "0";
            IdEdo = 0;
            IdMun = 0;
            IdLoc = 0;
        }
    }

}
// </auto-generated>
