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

    // SIRA_40_CONFIG_VERSIONADOR
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira40ConfigVersionador
    {
        [Required]
        [Display(Name = "N ID config ver 40")]
        public int NIdConfigVer40 { get; set; } // nIdConfigVer40 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S cliente svn")]
        public string SClienteSvn { get; set; } // sClienteSvn (length: 100)

        [Required]
        [MaxLength(50)]
        [Display(Name = "V password svn")]
        public byte[] VPasswordSvn { get; set; } // vPasswordSvn (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S repositorio local")]
        public string SRepositorioLocal { get; set; } // sRepositorioLocal (length: 500)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S url repositorio")]
        public string SUrlRepositorio { get; set; } // sUrlRepositorio (length: 500)

        [Required]
        [Display(Name = "N tipo operacion")]
        public byte NTipoOperacion { get; set; } // nTipoOperacion

        [Required]
        [Display(Name = "B clean up")]
        public bool BCleanUp { get; set; } // bCleanUp

        [Required]
        [Display(Name = "B respaldar version")]
        public bool BRespaldarVersion { get; set; } // bRespaldarVersion

        [Required]
        [Display(Name = "B bloqueada")]
        public bool BBloqueada { get; set; } // bBloqueada

        [Required]
        [Display(Name = "N num version log")]
        public int NNumVersionLog { get; set; } // nNumVersionLog

        public SIRAdmin_Sira40ConfigVersionador()
        {
            BBloqueada = false;
        }
    }

}
// </auto-generated>