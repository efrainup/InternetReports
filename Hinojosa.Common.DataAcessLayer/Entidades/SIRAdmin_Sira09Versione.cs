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

    // SIRA_09_VERSIONES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira09Versione
    {
        [Required]
        [Display(Name = "N ID ver 09")]
        public long NIdVer09 { get; set; } // nIdVer09 (Primary key)

        [Required]
        [Display(Name = "D fecha")]
        public System.DateTime DFecha { get; set; } // dFecha

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "S version")]
        public string SVersion { get; set; } // sVersion (length: 10)

        [Required]
        [Display(Name = "B aplicada")]
        public bool BAplicada { get; set; } // bAplicada

        [Required]
        [Display(Name = "N tipo")]
        public byte NTipo { get; set; } // nTipo

        [Required]
        [Display(Name = "N ver sistema")]
        public int NVerSistema { get; set; } // nVerSistema

        // Reverse navigation

        /// <summary>
        /// Child SIRAdmin_Sira93VersionesGenerale where [SIRA_93_VERSIONES_GENERALES].[nIdVer09] point to this entity (FK_SIRA_93_VERSIONES_GENERALES_SIRA_09_VERSIONES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira93VersionesGenerale> SIRAdmin_Sira93VersionesGenerale { get; set; } // SIRA_93_VERSIONES_GENERALES.FK_SIRA_93_VERSIONES_GENERALES_SIRA_09_VERSIONES

        public SIRAdmin_Sira09Versione()
        {
            NVerSistema = 0;
            SIRAdmin_Sira93VersionesGenerale = new System.Collections.Generic.List<SIRAdmin_Sira93VersionesGenerale>();
        }
    }

}
// </auto-generated>
