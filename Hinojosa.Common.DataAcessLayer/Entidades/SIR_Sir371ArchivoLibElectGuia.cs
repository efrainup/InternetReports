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

    // SIR_371_ARCHIVO_LIB_ELECT_GUIAS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir371ArchivoLibElectGuia
    {
        [Required]
        [Display(Name = "N ID archivo leg 371")]
        public int NIdArchivoLeg371 { get; set; } // nIdArchivoLEG371 (Primary key)

        [Required]
        [Display(Name = "N ID liberacion guias 370")]
        public int NIdLiberacionGuias370 { get; set; } // nIdLiberacionGuias370

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S archivo envio")]
        public string SArchivoEnvio { get; set; } // sArchivoEnvio (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S directorio envio")]
        public string SDirectorioEnvio { get; set; } // sDirectorioEnvio (length: 500)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S archivo respuesta")]
        public string SArchivoRespuesta { get; set; } // sArchivoRespuesta (length: 50)

        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "S directorio respuesta")]
        public string SDirectorioRespuesta { get; set; } // sDirectorioRespuesta (length: 1000)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D validacion")]
        public System.DateTime DValidacion { get; set; } // dValidacion

        [DataType(DataType.DateTime)]
        [Display(Name = "D respuesta")]
        public System.DateTime? DRespuesta { get; set; } // dRespuesta

        [Required]
        [Display(Name = "N status")]
        public int NStatus { get; set; } // nStatus

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir370LiberacionElectronicaGuia pointed by [SIR_371_ARCHIVO_LIB_ELECT_GUIAS].([NIdLiberacionGuias370]) (FK_SIR_371_ARCH_LIB_ELECT_GUIAS_SIR_370_LIB_ELECT_GUIAS)
        /// </summary>
        public virtual SIR_Sir370LiberacionElectronicaGuia SIR_Sir370LiberacionElectronicaGuia { get; set; } // FK_SIR_371_ARCH_LIB_ELECT_GUIAS_SIR_370_LIB_ELECT_GUIAS
    }

}
// </auto-generated>