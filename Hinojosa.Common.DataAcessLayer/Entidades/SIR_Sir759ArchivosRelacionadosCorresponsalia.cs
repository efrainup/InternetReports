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

    // SIR_759_ARCHIVOS_RELACIONADOS_CORRESPONSALIA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir759ArchivosRelacionadosCorresponsalia
    {
        [Required]
        [Display(Name = "N ID archivo relacion 759")]
        public int NIdArchivoRelacion759 { get; set; } // nIdArchivoRelacion759 (Primary key)

        [Required]
        [Display(Name = "N ID bitacora m 3704")]
        public int NIdBitacoraM3704 { get; set; } // nIdBitacoraM3704

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S archivo")]
        public string SArchivo { get; set; } // sArchivo (length: 50)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "S ruta")]
        public string SRuta { get; set; } // sRuta

        [Required(AllowEmptyStrings = true)]
        [MaxLength(7)]
        [StringLength(7)]
        [Display(Name = "S pedimento")]
        public string SPedimento { get; set; } // sPedimento (length: 7)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha recibido")]
        public System.DateTime DFechaRecibido { get; set; } // dFechaRecibido

        [Required]
        [Display(Name = "N estatus")]
        public byte NEstatus { get; set; } // nEstatus

        [Required]
        [Display(Name = "N tipo archivo")]
        public byte NTipoArchivo { get; set; } // nTipoArchivo

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir704BitacoraM3 pointed by [SIR_759_ARCHIVOS_RELACIONADOS_CORRESPONSALIA].([NIdBitacoraM3704]) (FK_SIR_759_ARCHIVOS_RELACIONADOS_CORRESPONSALIA_SIR_704_BITACORA_M3)
        /// </summary>
        public virtual SIR_Sir704BitacoraM3 SIR_Sir704BitacoraM3 { get; set; } // FK_SIR_759_ARCHIVOS_RELACIONADOS_CORRESPONSALIA_SIR_704_BITACORA_M3
    }

}
// </auto-generated>
