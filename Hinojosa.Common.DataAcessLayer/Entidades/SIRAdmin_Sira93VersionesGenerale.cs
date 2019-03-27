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

    // SIRA_93_VERSIONES_GENERALES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira93VersionesGenerale
    {
        [Required]
        [Display(Name = "N ID ver 09")]
        public long NIdVer09 { get; set; } // nIdVer09 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (Primary key) (length: 500)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "S script")]
        public string SScript { get; set; } // sScript (Primary key)

        [Required]
        [Display(Name = "B aplicada")]
        public bool BAplicada { get; set; } // bAplicada (Primary key)

        // Foreign keys

        /// <summary>
        /// Parent SIRAdmin_Sira09Versione pointed by [SIRA_93_VERSIONES_GENERALES].([NIdVer09]) (FK_SIRA_93_VERSIONES_GENERALES_SIRA_09_VERSIONES)
        /// </summary>
        public virtual SIRAdmin_Sira09Versione SIRAdmin_Sira09Versione { get; set; } // FK_SIRA_93_VERSIONES_GENERALES_SIRA_09_VERSIONES
    }

}
// </auto-generated>