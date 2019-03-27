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

    // SIR_828_CAT_MENS_VALIDACION
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir828CatMensValidacion
    {
        [Required]
        [Display(Name = "N ID cat mens val 828")]
        public int NIdCatMensVal828 { get; set; } // nIdCatMensVal828 (Primary key)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S clave")]
        public string SClave { get; set; } // sClave (length: 30)

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 500)

        [Display(Name = "B m 3")]
        public bool? BM3 { get; set; } // bM3

        [Display(Name = "B archivo pago")]
        public bool? BArchivoPago { get; set; } // bArchivoPago
    }

}
// </auto-generated>
