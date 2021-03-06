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

    // SIRA_60_ENSAMBLADOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira60Ensamblado
    {
        [Required]
        [Display(Name = "N ID ensamblado 60")]
        public int NIdEnsamblado60 { get; set; } // nIdEnsamblado60 (Primary key)

        [MaxLength(300)]
        [StringLength(300)]
        [Display(Name = "S ensamblado")]
        public string SEnsamblado { get; set; } // sEnsamblado (length: 300)

        [MaxLength(3000)]
        [StringLength(3000)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 3000)
    }

}
// </auto-generated>
