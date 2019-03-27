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

    // SIR_322_SED_COUNTRIES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir322SedCountRy
    {
        [Required]
        [Display(Name = "N ID countries 322")]
        public int NIdCountries322 { get; set; } // nIdCountries322 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "S code")]
        public string SCode { get; set; } // sCode (length: 2)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "S name")]
        public string SName { get; set; } // sName

        [Required]
        [Display(Name = "B kimberly")]
        public bool BKimberly { get; set; } // bKimberly

        [Required]
        [Display(Name = "B activo")]
        public bool BActivo { get; set; } // bActivo

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir346SedDocument where [SIR_346_SED_DOCUMENTS].[nIdCountriesDestination322] point to this entity (FK_SIR_346_SED_DOCUMENTS_SIR_322_SED_COUNTRIES1)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir346SedDocument> SIR_Sir346SedDocument_NIdCountriesDestination322 { get; set; } // SIR_346_SED_DOCUMENTS.FK_SIR_346_SED_DOCUMENTS_SIR_322_SED_COUNTRIES1
        /// <summary>
        /// Child SIR_Sir346SedDocument where [SIR_346_SED_DOCUMENTS].[nIdCountryFF322] point to this entity (FK_SIR_346_SED_DOCUMENTS_SIR_322_SED_COUNTRIES4)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir346SedDocument> SIR_Sir346SedDocument_NIdCountryFf322 { get; set; } // SIR_346_SED_DOCUMENTS.FK_SIR_346_SED_DOCUMENTS_SIR_322_SED_COUNTRIES4
        /// <summary>
        /// Child SIR_Sir346SedDocument where [SIR_346_SED_DOCUMENTS].[nIdCountryIntCons322] point to this entity (FK_SIR_346_SED_DOCUMENTS_SIR_322_SED_COUNTRIES3)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir346SedDocument> SIR_Sir346SedDocument_NIdCountryIntCons322 { get; set; } // SIR_346_SED_DOCUMENTS.FK_SIR_346_SED_DOCUMENTS_SIR_322_SED_COUNTRIES3
        /// <summary>
        /// Child SIR_Sir346SedDocument where [SIR_346_SED_DOCUMENTS].[nIdCountryUltCons322] point to this entity (FK_SIR_346_SED_DOCUMENTS_SIR_322_SED_COUNTRIES2)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir346SedDocument> SIR_Sir346SedDocument_NIdCountryUltCons322 { get; set; } // SIR_346_SED_DOCUMENTS.FK_SIR_346_SED_DOCUMENTS_SIR_322_SED_COUNTRIES2
        /// <summary>
        /// Child SIR_Sir346SedDocument where [SIR_346_SED_DOCUMENTS].[nIdVesselFlag322] point to this entity (FK_SIR_346_SED_DOCUMENTS_SIR_322_SED_COUNTRIES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir346SedDocument> SIR_Sir346SedDocument_NIdVesselFlag322 { get; set; } // SIR_346_SED_DOCUMENTS.FK_SIR_346_SED_DOCUMENTS_SIR_322_SED_COUNTRIES

        public SIR_Sir322SedCountRy()
        {
            SIR_Sir346SedDocument_NIdCountriesDestination322 = new System.Collections.Generic.List<SIR_Sir346SedDocument>();
            SIR_Sir346SedDocument_NIdCountryFf322 = new System.Collections.Generic.List<SIR_Sir346SedDocument>();
            SIR_Sir346SedDocument_NIdCountryIntCons322 = new System.Collections.Generic.List<SIR_Sir346SedDocument>();
            SIR_Sir346SedDocument_NIdCountryUltCons322 = new System.Collections.Generic.List<SIR_Sir346SedDocument>();
            SIR_Sir346SedDocument_NIdVesselFlag322 = new System.Collections.Generic.List<SIR_Sir346SedDocument>();
        }
    }

}
// </auto-generated>
