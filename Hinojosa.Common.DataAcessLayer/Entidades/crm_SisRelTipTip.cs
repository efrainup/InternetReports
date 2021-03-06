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

    // sis_rel_tip_tip
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_SisRelTipTip
    {
        [Required]
        [Display(Name = "Id rel tip tip")]
        public int IdRelTipTip { get; set; } // id_rel_tip_tip (Primary key)

        [Required]
        [Display(Name = "Id tip 1")]
        public int IdTip1 { get; set; } // id_tip1

        [Required]
        [Display(Name = "Id tip 2")]
        public int IdTip2 { get; set; } // id_tip2

        [Required]
        [Display(Name = "Id tbl")]
        public int IdTbl { get; set; } // id_tbl

        public crm_SisRelTipTip()
        {
            IdTip1 = 0;
            IdTip2 = 0;
            IdTbl = 0;
        }
    }

}
// </auto-generated>
