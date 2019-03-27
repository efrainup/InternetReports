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

    // sis_img_rec
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_SisImgRec
    {
        [Required]
        [Display(Name = "Id img")]
        public int IdImg { get; set; } // id_img (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(2147483647)]
        [StringLength(2147483647)]
        [Display(Name = "Ruta")]
        public string Ruta { get; set; } // ruta (length: 2147483647)

        public crm_SisImgRec()
        {
            Ruta = "";
        }
    }

}
// </auto-generated>
