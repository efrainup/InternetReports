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

    // SQ_TiposOperacion
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SqTiposOperacion
    {
        [Required]
        [Display(Name = "N ID operacion")]
        public int NIdOperacion { get; set; } // nIdOperacion (Primary key)

        [Required]
        [Display(Name = "N tipo operacion")]
        public int NTipoOperacion { get; set; } // nTipoOperacion

        [Required(AllowEmptyStrings = true)]
        [MaxLength(12)]
        [StringLength(12)]
        [Display(Name = "S operacion")]
        public string SOperacion { get; set; } // sOperacion (length: 12)
    }

}
// </auto-generated>