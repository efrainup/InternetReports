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

    // cat_sat_mun
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatSatMun
    {
        [Required]
        [Display(Name = "Id mun")]
        public int IdMun { get; set; } // id_mun (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(6)]
        [StringLength(6)]
        [Display(Name = "Mun")]
        public string Mun { get; set; } // mun (length: 6)

        [Required]
        [Display(Name = "Id edo")]
        public int IdEdo { get; set; } // id_edo

        [Required(AllowEmptyStrings = true)]
        [MaxLength(125)]
        [StringLength(125)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (length: 125)

        public CatSatMun()
        {
            IdMun = 0;
            Mun = "0";
            IdEdo = 0;
            Des = "";
        }
    }

}
// </auto-generated>
