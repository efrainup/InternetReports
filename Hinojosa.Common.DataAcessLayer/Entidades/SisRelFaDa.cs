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

    // sis_rel_fa_da
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisRelFaDa
    {
        [Required]
        [Display(Name = "Id rel fa da")]
        public int IdRelFaDa { get; set; } // id_rel_fa_da (Primary key)

        [Required]
        [Display(Name = "Id cli fa da")]
        public int IdCliFaDa { get; set; } // id_cli_fa_da (Primary key)

        [Required]
        [Display(Name = "C principal")]
        public byte CPrincipal { get; set; } // c_principal

        public SisRelFaDa()
        {
            IdRelFaDa = 0;
            IdCliFaDa = 0;
            CPrincipal = 0;
        }
    }

}
// </auto-generated>
