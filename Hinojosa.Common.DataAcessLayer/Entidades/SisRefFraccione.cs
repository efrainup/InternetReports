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

    // sis_ref_fracciones
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisRefFraccione
    {
        [Required]
        [Display(Name = "Id fac")]
        public int IdFac { get; set; } // id_fac (Primary key)

        [Required]
        [Display(Name = "Id ref")]
        public int IdRef { get; set; } // id_ref (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(8)]
        [StringLength(8)]
        [Display(Name = "Numfrac")]
        public string Numfrac { get; set; } // numfrac (Primary key) (length: 8)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(254)]
        [StringLength(254)]
        [Display(Name = "Mercancia")]
        public string Mercancia { get; set; } // mercancia (Primary key) (length: 254)

        public SisRefFraccione()
        {
            IdFac = 0;
            IdRef = 0;
            Numfrac = "";
            Mercancia = "";
        }
    }

}
// </auto-generated>
