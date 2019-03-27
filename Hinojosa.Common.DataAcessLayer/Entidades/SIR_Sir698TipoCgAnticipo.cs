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

    // SIR_698_TIPO_CG_ANTICIPO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir698TipoCgAnticipo
    {
        [Required]
        [Display(Name = "N ID tipo cga nticipo 698")]
        public int NIdTipoCgAnticipo698 { get; set; } // nIdTipoCGAnticipo698 (Primary key)

        [Required]
        [Display(Name = "N clave")]
        public int NClave { get; set; } // nClave

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 500)

        [Required]
        [Display(Name = "N tipo")]
        public int NTipo { get; set; } // nTipo

        [Required]
        [Display(Name = "B activo")]
        public bool BActivo { get; set; } // bActivo

        [Required]
        [Display(Name = "D fecha")]
        public System.DateTime DFecha { get; set; } // dFecha
    }

}
// </auto-generated>
