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

    // sis_rel_img_tbl
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_SisRelImgTbl
    {
        [Required]
        [Display(Name = "Id rel img reg")]
        public int IdRelImgReg { get; set; } // id_rel_img_reg (Primary key)

        [Required]
        [Display(Name = "Id img")]
        public int IdImg { get; set; } // id_img

        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; } // id

        [Required]
        [Display(Name = "Id tbl")]
        public int IdTbl { get; set; } // id_tbl

        public crm_SisRelImgTbl()
        {
            IdImg = 0;
            Id = 0;
            IdTbl = 0;
        }
    }

}
// </auto-generated>
