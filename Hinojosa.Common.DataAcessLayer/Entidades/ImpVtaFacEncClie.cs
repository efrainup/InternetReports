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

    // imp_vta_fac_enc_clie
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ImpVtaFacEncClie
    {
        [Required]
        [Display(Name = "Imp ID fact")]
        public int ImpIdFact { get; set; } // imp_id_fact (Primary key via unique index IX_imp_id_Fact)

        [Required]
        [Display(Name = "Imp ID clie")]
        public int ImpIdClie { get; set; } // imp_id_clie

        [Required(AllowEmptyStrings = true)]
        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "Imp nom 1")]
        public string ImpNom1 { get; set; } // imp_nom1 (length: 128)

        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "Imp nom 2")]
        public string ImpNom2 { get; set; } // imp_nom2 (length: 128)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Imp dir 1")]
        public string ImpDir1 { get; set; } // imp_dir1 (length: 255)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Imp dir 2")]
        public string ImpDir2 { get; set; } // imp_dir2 (length: 255)

        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Imp ciu")]
        public string ImpCiu { get; set; } // imp_ciu (length: 80)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Imp est")]
        public string ImpEst { get; set; } // imp_est (length: 30)

        [MaxLength(8)]
        [StringLength(8)]
        [Display(Name = "Imp cp")]
        public string ImpCp { get; set; } // imp_cp (length: 8)

        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Imp rfc")]
        public string ImpRfc { get; set; } // imp_rfc (length: 15)

        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Imp tel 1")]
        public string ImpTel1 { get; set; } // imp_tel1 (length: 15)

        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Imp tel 2")]
        public string ImpTel2 { get; set; } // imp_tel2 (length: 15)

        [Required]
        [Display(Name = "Imp c most")]
        public byte ImpCMost { get; set; } // imp_c_most

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Imp contacto 1")]
        public string ImpContacto1 { get; set; } // imp_contacto1 (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Imp depto")]
        public string ImpDepto { get; set; } // imp_depto (length: 25)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(1200)]
        [StringLength(1200)]
        [Display(Name = "Imp sello digi")]
        public string ImpSelloDigi { get; set; } // imp_sello_digi (length: 1200)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Imp certifi")]
        public string ImpCertifi { get; set; } // imp_certifi (length: 100)

        [Required]
        [Display(Name = "Imp num apr")]
        public long ImpNumApr { get; set; } // imp_num_apr

        [Required]
        [Display(Name = "Imp anio apr")]
        public int ImpAnioApr { get; set; } // imp_anio_apr

        [Required]
        [Display(Name = "Imp ID nota")]
        public int ImpIdNota { get; set; } // imp_id_nota

        [Required]
        [Display(Name = "Imp cfd status")]
        public int ImpCfdStatus { get; set; } // imp_cfd_status

        [Required]
        [Display(Name = "Imp ID tip grp")]
        public int ImpIdTipGrp { get; set; } // imp_id_tip_grp

        [Required]
        [Display(Name = "Imp ID cert")]
        public int ImpIdCert { get; set; } // imp_id_cert

        [Required]
        [Display(Name = "Imp ID sis doctos ser fol")]
        public int ImpIdSisDoctosSerFol { get; set; } // imp_id_sis_doctos_ser_fol

        [Required]
        [Display(Name = "Imp tip pag")]
        public int ImpTipPag { get; set; } // imp_tip_pag

        [Required]
        [Display(Name = "Imp c ieps desg")]
        public byte ImpCIepsDesg { get; set; } // imp_c_ieps_desg

        [Required]
        [Display(Name = "Imp ID tip ser")]
        public int ImpIdTipSer { get; set; } // imp_id_tip_ser

        [Required(AllowEmptyStrings = true)]
        [MaxLength(36)]
        [StringLength(36)]
        [Display(Name = "Imp uuid")]
        public string ImpUuid { get; set; } // imp_uuid (length: 36)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(1200)]
        [StringLength(1200)]
        [Display(Name = "Imp sello sat")]
        public string ImpSelloSat { get; set; } // imp_sello_sat (length: 1200)

        [MaxLength(2147483647)]
        [Display(Name = "Imp cbb")]
        public byte[] ImpCbb { get; set; } // imp_CBB (length: 2147483647)

        [Required]
        [Display(Name = "Imp ID pac")]
        public int ImpIdPac { get; set; } // imp_id_pac

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Imp calle")]
        public string ImpCalle { get; set; } // imp_calle (length: 80)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Imp num int")]
        public string ImpNumInt { get; set; } // imp_num_int (length: 30)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Imp num ext")]
        public string ImpNumExt { get; set; } // imp_num_ext (length: 30)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Imp col")]
        public string ImpCol { get; set; } // imp_col (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Imp deleg")]
        public string ImpDeleg { get; set; } // imp_deleg (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Imp calles")]
        public string ImpCalles { get; set; } // imp_calles (length: 40)

        [Required]
        [Display(Name = "Imp ID pais")]
        public int ImpIdPais { get; set; } // imp_id_pais

        [Required]
        [Display(Name = "Imp ID edo")]
        public int ImpIdEdo { get; set; } // imp_id_edo

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Imp fec tim pac")]
        public System.DateTime ImpFecTimPac { get; set; } // imp_fec_tim_pac

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Imp cert sat")]
        public string ImpCertSat { get; set; } // imp_cert_sat (length: 100)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Imp xml canc")]
        public string ImpXmlCanc { get; set; } // imp_xml_canc

        [Required]
        [Display(Name = "Imp c timb")]
        public byte ImpCTimb { get; set; } // imp_c_timb

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Imp cfd dir exp")]
        public string ImpCfdDirExp { get; set; } // imp_cfd_dir_exp

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Imp ult dig cta")]
        public string ImpUltDigCta { get; set; } // imp_ult_dig_cta

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Imp reg fis")]
        public string ImpRegFis { get; set; } // imp_reg_fis

        [Required(AllowEmptyStrings = true)]
        [MaxLength(36)]
        [StringLength(36)]
        [Display(Name = "Imp ID sugar")]
        public string ImpIdSugar { get; set; } // imp_id_sugar (length: 36)

        [Required]
        [Display(Name = "Imp ID cli cta")]
        public int ImpIdCliCta { get; set; } // imp_id_cli_cta

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Imp tip pag cta")]
        public string ImpTipPagCta { get; set; } // imp_tip_pag_cta

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Imp bco cta")]
        public string ImpBcoCta { get; set; } // imp_bco_cta

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Imp idis cta")]
        public string ImpIdisCta { get; set; } // imp_idis_cta

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Imp pais")]
        public string ImpPais { get; set; } // imp_pais (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Imp mail")]
        public string ImpMail { get; set; } // imp_mail (length: 200)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Imp nom")]
        public string ImpNom { get; set; } // imp_nom (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Imp apep")]
        public string ImpApep { get; set; } // imp_apep (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Imp apem")]
        public string ImpApem { get; set; } // imp_apem (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Imp nacionalidad")]
        public string ImpNacionalidad { get; set; } // imp_nacionalidad (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Imp ID fis ext")]
        public string ImpIdFisExt { get; set; } // imp_id_fis_ext (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Imp codsat pais")]
        public string ImpCodsatPais { get; set; } // imp_codsat_pais (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Imp codsat edo")]
        public string ImpCodsatEdo { get; set; } // imp_codsat_edo (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Imp codsat mundel")]
        public string ImpCodsatMundel { get; set; } // imp_codsat_mundel (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Imp codsat loc")]
        public string ImpCodsatLoc { get; set; } // imp_codsat_loc (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Imp codsat col")]
        public string ImpCodsatCol { get; set; } // imp_codsat_col (length: 10)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Imp cad ori")]
        public string ImpCadOri { get; set; } // imp_cad_ori

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "Imp pdf")]
        public string ImpPdf { get; set; } // imp_pdf (length: 500)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Imp xml")]
        public string ImpXml { get; set; } // imp_xml

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Imp codsat uso cfdi")]
        public string ImpCodsatUsoCfdi { get; set; } // imp_codsat_uso_cfdi (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Imp mtd pag")]
        public string ImpMtdPag { get; set; } // imp_mtd_pag (length: 10)

        public ImpVtaFacEncClie()
        {
            ImpCMost = 0;
            ImpContacto1 = "";
            ImpDepto = "";
            ImpSelloDigi = "";
            ImpCertifi = "";
            ImpNumApr = 0;
            ImpAnioApr = 0;
            ImpIdNota = 0;
            ImpCfdStatus = 0;
            ImpIdTipGrp = 0;
            ImpIdCert = 0;
            ImpIdSisDoctosSerFol = 0;
            ImpTipPag = 0;
            ImpCIepsDesg = 0;
            ImpIdTipSer = 0;
            ImpUuid = "";
            ImpSelloSat = "";
            ImpIdPac = 0;
            ImpCalle = "";
            ImpNumInt = "";
            ImpNumExt = "";
            ImpCol = "";
            ImpDeleg = "";
            ImpCalles = "";
            ImpIdPais = 0;
            ImpIdEdo = 0;
            ImpCertSat = "";
            ImpXmlCanc = "";
            ImpCTimb = 0;
            ImpCfdDirExp = "";
            ImpUltDigCta = "";
            ImpRegFis = "";
            ImpIdSugar = "";
            ImpIdCliCta = 0;
            ImpTipPagCta = "";
            ImpBcoCta = "";
            ImpIdisCta = "";
            ImpPais = "";
            ImpMail = "";
            ImpNom = "";
            ImpApep = "";
            ImpApem = "";
            ImpNacionalidad = "";
            ImpIdFisExt = "";
            ImpCodsatPais = "";
            ImpCodsatEdo = "";
            ImpCodsatMundel = "";
            ImpCodsatLoc = "";
            ImpCodsatCol = "";
            ImpCadOri = "";
            ImpPdf = "";
            ImpXml = "";
            ImpCodsatUsoCfdi = "";
            ImpMtdPag = "";
        }
    }

}
// </auto-generated>
