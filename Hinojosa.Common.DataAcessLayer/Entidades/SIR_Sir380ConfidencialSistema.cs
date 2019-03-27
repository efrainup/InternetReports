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

    // SIR_380_CONFIDENCIAL_SISTEMA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir380ConfidencialSistema
    {
        [Required]
        [Display(Name = "N ID confidencial sistema 380")]
        public int NIdConfidencialSistema380 { get; set; } // nIdConfidencialSistema380 (Primary key)

        [Required]
        [Display(Name = "N tipo bloqueo")]
        public byte NTipoBloqueo { get; set; } // nTipoBloqueo

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha")]
        public System.DateTime DFecha { get; set; } // dFecha

        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "S mensaje")]
        public string SMensaje { get; set; } // sMensaje (length: 250)

        [Display(Name = "N aviso")]
        public int? NAviso { get; set; } // nAviso

        [MaxLength(4)]
        [StringLength(4)]
        [Display(Name = "S patente")]
        public string SPatente { get; set; } // sPatente (length: 4)

        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "S aduana")]
        public string SAduana { get; set; } // sAduana (length: 2)
    }

}
// </auto-generated>
