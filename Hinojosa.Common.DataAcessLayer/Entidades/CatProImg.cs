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

    // cat_pro_img
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatProImg
    {
        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro (Primary key)

        [MaxLength(2147483647)]
        [Display(Name = "Foto")]
        public byte[] Foto { get; set; } // foto (length: 2147483647)

        // Foreign keys

        /// <summary>
        /// Parent CatPro pointed by [cat_pro_img].([IdPro]) (FK_cat_pro_img_cat_pro)
        /// </summary>
        public virtual CatPro CatPro { get; set; } // FK_cat_pro_img_cat_pro
    }

}
// </auto-generated>