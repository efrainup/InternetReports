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

    // sis_img
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_SisImg
    {
        [Required]
        [Display(Name = "Id img")]
        public int IdImg { get; set; } // id_img (Primary key)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Img")]
        public string Img { get; set; } // img

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Cod")]
        public string Cod { get; set; } // cod (length: 5)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Alt")]
        public string Alt { get; set; } // alt (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Tooltip")]
        public string Tooltip { get; set; } // tooltip (length: 100)

        public crm_SisImg()
        {
            IdImg = 0;
            Img = "";
            Des = "";
            Cod = "";
        }
    }

}
// </auto-generated>
