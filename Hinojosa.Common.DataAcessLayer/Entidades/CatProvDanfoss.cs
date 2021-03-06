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

    // The table 'CatProvDanfoss' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    // CatProvDanfoss
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatProvDanfoss
    {
        [Display(Name = "Id prov sir")]
        public int? IdProvSir { get; set; } // idProvSIR

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Clave")]
        public string Clave { get; set; } // Clave (length: 10)

        [Display(Name = "Tipo operacion")]
        public int? TipoOperacion { get; set; } // TipoOperacion

        [Display(Name = "Id prov saai")]
        public int? IdProvSaai { get; set; } // idProvSAAI
    }

}
// </auto-generated>
