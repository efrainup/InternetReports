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

    // SECURITYDETAILS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Securitydetail
    {
        [Required]
        [Display(Name = "Securitydetailid")]
        public int Securitydetailid { get; set; } // SECURITYDETAILID (Primary key)

        [Display(Name = "Userid")]
        public short? Userid { get; set; } // USERID

        [Display(Name = "Deptid")]
        public short? Deptid { get; set; } // DEPTID

        [Display(Name = "Schedule")]
        public short? Schedule { get; set; } // SCHEDULE

        [Display(Name = "Userinfo")]
        public short? Userinfo { get; set; } // USERINFO

        [Display(Name = "Enrollfingers")]
        public short? Enrollfingers { get; set; } // ENROLLFINGERS

        [Display(Name = "Reportview")]
        public short? Reportview { get; set; } // REPORTVIEW

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Report")]
        public string Report { get; set; } // REPORT (length: 10)
    }

}
// </auto-generated>
