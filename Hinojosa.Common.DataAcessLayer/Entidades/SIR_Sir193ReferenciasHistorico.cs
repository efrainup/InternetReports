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

    // SIR_193_REFERENCIAS_HISTORICO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir193ReferenciasHistorico
    {
        [Required]
        [Display(Name = "N ID ref hist 193")]
        public int NIdRefHist193 { get; set; } // nIdRefHist193 (Primary key)

        [MaxLength(18)]
        [StringLength(18)]
        [Display(Name = "S rfci mex")]
        public string SRfcImex { get; set; } // sRFCImex (length: 18)

        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "S curpi mex")]
        public string SCurpImex { get; set; } // sCURPImex (length: 40)

        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "S rs ocial imex")]
        public string SRSocialImex { get; set; } // sRSocialImex (length: 128)

        [MaxLength(12)]
        [StringLength(12)]
        [Display(Name = "S clave imex")]
        public string SClaveImex { get; set; } // sClaveImex (length: 12)

        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "S nombre imex")]
        public string SNombreImex { get; set; } // sNombreImex (length: 128)

        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "S direccion imex")]
        public string SDireccionImex { get; set; } // sDireccionImex (length: 80)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "S num ext imex")]
        public string SNumExtImex { get; set; } // sNumExtImex (length: 10)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "S num int imex")]
        public string SNumIntImex { get; set; } // sNumIntImex (length: 10)

        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "S colonia imex")]
        public string SColoniaImex { get; set; } // sColoniaImex (length: 80)

        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "S ciudad imex")]
        public string SCiudadImex { get; set; } // sCiudadImex (length: 250)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S cpi mex")]
        public string SCpImex { get; set; } // sCPImex (length: 50)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S entidad imex")]
        public string SEntidadImex { get; set; } // sEntidadImex (length: 30)

        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "S pais imex")]
        public string SPaisImex { get; set; } // sPaisImex (length: 3)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "S responsable imex")]
        public string SResponsableImex { get; set; } // sResponsableImex (length: 255)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S telefono 1 imex")]
        public string STelefono1Imex { get; set; } // sTelefono1Imex (length: 30)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S telefono 2 imex")]
        public string STelefono2Imex { get; set; } // sTelefono2Imex (length: 30)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S fax imex")]
        public string SFaxImex { get; set; } // sFaxImex (length: 50)

        [MaxLength(12)]
        [StringLength(12)]
        [Display(Name = "S clave cliente")]
        public string SClaveCliente { get; set; } // sClaveCliente (length: 12)

        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "S nombre cliente")]
        public string SNombreCliente { get; set; } // sNombreCliente (length: 128)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "S rs ocial aa")]
        public string SRSocialAa { get; set; } // sRSocialAA (length: 255)

        [MaxLength(18)]
        [StringLength(18)]
        [Display(Name = "S rfcaa")]
        public string SRfcaa { get; set; } // sRFCAA (length: 18)

        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "S curpaa")]
        public string SCurpaa { get; set; } // sCURPAA (length: 40)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "S nombre man")]
        public string SNombreMan { get; set; } // sNombreMan (length: 255)

        [MaxLength(18)]
        [StringLength(18)]
        [Display(Name = "S rfcm an")]
        public string SRfcMan { get; set; } // sRFCMan (length: 18)

        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "S curpm an")]
        public string SCurpMan { get; set; } // sCURPMan (length: 40)

        [MaxLength(17)]
        [StringLength(17)]
        [Display(Name = "S clave barco")]
        public string SClaveBarco { get; set; } // sClaveBarco (length: 17)

        [MaxLength(120)]
        [StringLength(120)]
        [Display(Name = "S nombre barco")]
        public string SNombreBarco { get; set; } // sNombreBarco (length: 120)

        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "S num viaje")]
        public string SNumViaje { get; set; } // sNumViaje (length: 15)

        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "S clave pais barco")]
        public string SClavePaisBarco { get; set; } // sClavePaisBarco (length: 3)

        [MaxLength(12)]
        [StringLength(12)]
        [Display(Name = "S clave naviera")]
        public string SClaveNaviera { get; set; } // sClaveNaviera (length: 12)

        [MaxLength(64)]
        [StringLength(64)]
        [Display(Name = "N num expediente")]
        public string NNumExpediente { get; set; } // nNumExpediente (length: 64)

        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "S clave docto")]
        public string SClaveDocto { get; set; } // sClaveDocto (length: 2)

        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "S nombre ejecutivo")]
        public string SNombreEjecutivo { get; set; } // sNombreEjecutivo (length: 128)

        [Display(Name = "N patente")]
        public int? NPatente { get; set; } // nPatente

        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "S aduana seccion")]
        public string SAduanaSeccion { get; set; } // sAduanaSeccion (length: 3)

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir60Referencia where [SIR_60_REFERENCIAS].[nIdRefHist193] point to this entity (FK_SIR_60_REFERENCIAS_SIR_193_REFERENCIAS_HISTORICO)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir60Referencia> SIR_Sir60Referencia { get; set; } // SIR_60_REFERENCIAS.FK_SIR_60_REFERENCIAS_SIR_193_REFERENCIAS_HISTORICO

        public SIR_Sir193ReferenciasHistorico()
        {
            SIR_Sir60Referencia = new System.Collections.Generic.List<SIR_Sir60Referencia>();
        }
    }

}
// </auto-generated>
