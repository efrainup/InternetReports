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

    // TBL_DASHBOARDS_DET
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TblDashboardsDet
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; } // id (Primary key)

        [Required]
        [Display(Name = "Id dash")]
        public int IdDash { get; set; } // id_dash

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Display(Name = "Status")]
        public int? Status { get; set; } // status

        [Display(Name = "Layout usr")]
        public string LayoutUsr { get; set; } // layout_usr

        public TblDashboardsDet()
        {
            IdDash = 0;
            IdUsr = 0;
            Status = 0;
            LayoutUsr = "";
        }
    }

}
// </auto-generated>
