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

    // SIR_723_ARCHIVO_AVISO_ELECT
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir723ArchivoAvisoElect
    {
        [Required]
        [Display(Name = "N ID arc aviso elect 723")]
        public int NIdArcAvisoElect723 { get; set; } // nIdArcAvisoElect723 (Primary key)

        [Required]
        [Display(Name = "N ID aviso eletronico 709")]
        public int NIdAvisoEletronico709 { get; set; } // nIdAvisoEletronico709

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

        [Display(Name = "N status")]
        public byte? NStatus { get; set; } // nStatus

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir709AvisosEletronico pointed by [SIR_723_ARCHIVO_AVISO_ELECT].([NIdAvisoEletronico709]) (FK_SIR_723_ARCHIVO_AVISO_ELECT_SIR_709_AVISOS_ELETRONICOS)
        /// </summary>
        public virtual SIR_Sir709AvisosEletronico SIR_Sir709AvisosEletronico { get; set; } // FK_SIR_723_ARCHIVO_AVISO_ELECT_SIR_709_AVISOS_ELETRONICOS
    }

}
// </auto-generated>