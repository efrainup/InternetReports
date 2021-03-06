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

    // SIR_387_SED_ARCHIVOS_SHIPPER
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir387SedArchivosShipper
    {
        [Required]
        [Display(Name = "N ID archivos shipper 385")]
        public int NIdArchivosShipper385 { get; set; } // nIdArchivosShipper385 (Primary key)

        [Required]
        [Display(Name = "N ID shipper 346")]
        public int NIdShipper346 { get; set; } // nIdShipper346

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "S numero")]
        public string SNumero { get; set; } // sNumero

        [MaxLength(2147483647)]
        [StringLength(2147483647)]
        [Display(Name = "S contenido")]
        public string SContenido { get; set; } // sContenido (length: 2147483647)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha envio")]
        public System.DateTime DFechaEnvio { get; set; } // dFechaEnvio

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir346SedDocument pointed by [SIR_387_SED_ARCHIVOS_SHIPPER].([NIdShipper346]) (FK_SIR_387_SED_ARCHIVOS_SHIPPER_SIR_346_SED_DOCUMENTS)
        /// </summary>
        public virtual SIR_Sir346SedDocument SIR_Sir346SedDocument { get; set; } // FK_SIR_387_SED_ARCHIVOS_SHIPPER_SIR_346_SED_DOCUMENTS
    }

}
// </auto-generated>
