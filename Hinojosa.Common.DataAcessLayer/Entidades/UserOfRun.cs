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

    // USER_OF_RUN
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class UserOfRun
    {
        [Required]
        [Display(Name = "Userid")]
        public int Userid { get; set; } // USERID (Primary key)

        [Required]
        [Display(Name = "Num of run ID")]
        public int NumOfRunId { get; set; } // NUM_OF_RUN_ID (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Startdate")]
        public System.DateTime Startdate { get; set; } // STARTDATE (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Enddate")]
        public System.DateTime Enddate { get; set; } // ENDDATE (Primary key)

        [Display(Name = "Isnotof run")]
        public int? IsnotofRun { get; set; } // ISNOTOF_RUN

        [Display(Name = "Order run")]
        public int? OrderRun { get; set; } // ORDER_RUN

        public UserOfRun()
        {
            IsnotofRun = 0;
        }
    }

}
// </auto-generated>