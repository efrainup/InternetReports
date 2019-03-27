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

    // Correos_RevisionLF
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CorreosRevisionLf
    {
        [Required]
        [Display(Name = "N ID revisado")]
        public int NIdRevisado { get; set; } // nIdRevisado (Primary key)

        [Required]
        [Display(Name = "N ID rel documento")]
        public int NIdRelDocumento { get; set; } // nIdRelDocumento

        [Required]
        [Display(Name = "N ID referencia 60")]
        public int NIdReferencia60 { get; set; } // nIdReferencia60

        [Display(Name = "B esta")]
        public bool? BEsta { get; set; } // bEsta

        [Display(Name = "B duplicado")]
        public bool? BDuplicado { get; set; } // bDuplicado

        public CorreosRevisionLf()
        {
            BEsta = false;
            BDuplicado = false;
        }
    }

}
// </auto-generated>
