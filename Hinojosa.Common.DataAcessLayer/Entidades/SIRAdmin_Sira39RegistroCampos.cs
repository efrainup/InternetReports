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

    // SIRA_39_REGISTRO_CAMPOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira39RegistroCampos
    {
        [Required]
        [Display(Name = "N ID num reg 37")]
        public int NIdNumReg37 { get; set; } // nIdNumReg37 (Primary key)

        [Required]
        [Display(Name = "N ID campo 38")]
        public int NIdCampo38 { get; set; } // nIdCampo38 (Primary key)

        [Required]
        [Display(Name = "N orden")]
        public int NOrden { get; set; } // nOrden (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent SIRAdmin_Sira37NumRegistro pointed by [SIRA_39_REGISTRO_CAMPOS].([NIdNumReg37]) (FK_SIRA_39_REGISTRO_CAMPOS_SIRA_37_NUM_REGISTROS)
        /// </summary>
        public virtual SIRAdmin_Sira37NumRegistro SIRAdmin_Sira37NumRegistro { get; set; } // FK_SIRA_39_REGISTRO_CAMPOS_SIRA_37_NUM_REGISTROS

        /// <summary>
        /// Parent SIRAdmin_Sira38Campos pointed by [SIRA_39_REGISTRO_CAMPOS].([NIdCampo38]) (FK_SIRA_39_REGISTRO_CAMPOS_SIRA_38_CAMPOS)
        /// </summary>
        public virtual SIRAdmin_Sira38Campos SIRAdmin_Sira38Campos { get; set; } // FK_SIRA_39_REGISTRO_CAMPOS_SIRA_38_CAMPOS
    }

}
// </auto-generated>
