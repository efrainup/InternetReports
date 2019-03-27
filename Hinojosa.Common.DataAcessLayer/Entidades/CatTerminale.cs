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

    // Cat_Terminales
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatTerminale
    {
        [Required]
        [Display(Name = "N ID terminal")]
        public int NIdTerminal { get; set; } // nIdTerminal (Primary key)

        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "S clave")]
        public string SClave { get; set; } // sClave (length: 5)

        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "S terminal")]
        public string STerminal { get; set; } // sTerminal (length: 200)

        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "S corto terminal")]
        public string SCortoTerminal { get; set; } // sCortoTerminal (length: 25)

        [Display(Name = "N ID area")]
        public int? NIdArea { get; set; } // nIdArea

        [Display(Name = "Estado")]
        public int? Estado { get; set; } // estado

        public CatTerminale()
        {
            Estado = 1;
        }
    }

}
// </auto-generated>