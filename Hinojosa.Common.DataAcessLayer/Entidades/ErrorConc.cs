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

    // error_conc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ErrorConc
    {
        [Required]
        [Display(Name = "Id conc")]
        public int IdConc { get; set; } // id_conc (Primary key)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Error")]
        public string Error { get; set; } // error (Primary key)

        public ErrorConc()
        {
            IdConc = 0;
            Error = "";
        }
    }

}
// </auto-generated>