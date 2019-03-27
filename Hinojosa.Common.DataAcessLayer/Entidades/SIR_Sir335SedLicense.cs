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

    // SIR_335_SED_LICENSES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir335SedLicense
    {
        [Required]
        [Display(Name = "N ID licenses 335")]
        public int NIdLicenses335 { get; set; } // nIdLicenses335 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "S code")]
        public string SCode { get; set; } // sCode (length: 3)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "S name")]
        public string SName { get; set; } // sName

        [Required]
        [Display(Name = "B activo")]
        public bool BActivo { get; set; } // bActivo

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir352SedCommodiTy where [SIR_352_SED_COMMODITIES].[nIdTipoLicencia335] point to this entity (FK_SIR_352_SED_COMMODITIES_SIR_335_SED_LICENSES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir352SedCommodiTy> SIR_Sir352SedCommodiTy { get; set; } // SIR_352_SED_COMMODITIES.FK_SIR_352_SED_COMMODITIES_SIR_335_SED_LICENSES
        /// <summary>
        /// Child SIR_Sir353FraccionesAmericana where [SIR_353_FRACCIONES_AMERICANAS].[nIdTipoLicencia335] point to this entity (FK_SIR_353_FRACCIONES_AMERICANAS_SIR_335_SED_LICENSES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir353FraccionesAmericana> SIR_Sir353FraccionesAmericana { get; set; } // SIR_353_FRACCIONES_AMERICANAS.FK_SIR_353_FRACCIONES_AMERICANAS_SIR_335_SED_LICENSES
        /// <summary>
        /// Child SIRAdmin_Sira57ConfiguracionShipper where [SIRA_57_CONFIGURACION_SHIPPER].[nIdLicenses335] point to this entity (FK_SIRA_57_CONFIGURACION_SHIPPER_SIR_335_SED_LICENSES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira57ConfiguracionShipper> SIRAdmin_Sira57ConfiguracionShipper { get; set; } // SIRA_57_CONFIGURACION_SHIPPER.FK_SIRA_57_CONFIGURACION_SHIPPER_SIR_335_SED_LICENSES

        public SIR_Sir335SedLicense()
        {
            SIR_Sir352SedCommodiTy = new System.Collections.Generic.List<SIR_Sir352SedCommodiTy>();
            SIR_Sir353FraccionesAmericana = new System.Collections.Generic.List<SIR_Sir353FraccionesAmericana>();
            SIRAdmin_Sira57ConfiguracionShipper = new System.Collections.Generic.List<SIRAdmin_Sira57ConfiguracionShipper>();
        }
    }

}
// </auto-generated>
