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

    // reg_nom_cfdi_clie
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class RegNomCfdiClie
    {
        [Required]
        [Display(Name = "Id reg nom cfdi")]
        public int IdRegNomCfdi { get; set; } // id_reg_nom_cfdi (Primary key via unique index IX_id_reg_nom_cfdi)

        [Required]
        [Display(Name = "Id reg nom")]
        public int IdRegNom { get; set; } // id_reg_nom

        [Required]
        [Display(Name = "Id emp")]
        public int IdEmp { get; set; } // id_emp

        [Required(AllowEmptyStrings = true)]
        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "Nom 1")]
        public string Nom1 { get; set; } // nom1 (length: 128)

        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "Nom 2")]
        public string Nom2 { get; set; } // nom2 (length: 128)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Dir 1")]
        public string Dir1 { get; set; } // dir1 (length: 255)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Dir 2")]
        public string Dir2 { get; set; } // dir2 (length: 255)

        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Ciu")]
        public string Ciu { get; set; } // ciu (length: 80)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Est")]
        public string Est { get; set; } // est (length: 30)

        [MaxLength(8)]
        [StringLength(8)]
        [Display(Name = "Cp")]
        public string Cp { get; set; } // cp (length: 8)

        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Rfc")]
        public string Rfc { get; set; } // rfc (length: 15)

        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Tel 1")]
        public string Tel1 { get; set; } // tel1 (length: 15)

        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Tel 2")]
        public string Tel2 { get; set; } // tel2 (length: 15)

        [Required]
        [Display(Name = "C most")]
        public byte CMost { get; set; } // c_most

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Contacto 1")]
        public string Contacto1 { get; set; } // contacto1 (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Depto")]
        public string Depto { get; set; } // depto (length: 25)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Sello digi")]
        public string SelloDigi { get; set; } // sello_digi (length: 255)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Certifi")]
        public string Certifi { get; set; } // certifi (length: 100)

        [Required]
        [Display(Name = "Num apr")]
        public long NumApr { get; set; } // num_apr

        [Required]
        [Display(Name = "Anio apr")]
        public int AnioApr { get; set; } // anio_apr

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required]
        [Display(Name = "Cfd status")]
        public int CfdStatus { get; set; } // cfd_status

        [Required]
        [Display(Name = "Id tip grp")]
        public int IdTipGrp { get; set; } // id_tip_grp

        [Required]
        [Display(Name = "Id cert")]
        public int IdCert { get; set; } // id_cert

        [Required]
        [Display(Name = "Id sis doctos ser fol")]
        public int IdSisDoctosSerFol { get; set; } // id_sis_doctos_ser_fol

        [Required]
        [Display(Name = "Tip pag")]
        public int TipPag { get; set; } // tip_pag

        [Required]
        [Display(Name = "C ieps desg")]
        public byte CIepsDesg { get; set; } // c_ieps_desg

        [Required]
        [Display(Name = "Id tip ser")]
        public int IdTipSer { get; set; } // id_tip_ser

        [Required(AllowEmptyStrings = true)]
        [MaxLength(36)]
        [StringLength(36)]
        [Display(Name = "Uuid")]
        public string Uuid { get; set; } // uuid (length: 36)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Sello sat")]
        public string SelloSat { get; set; } // sello_sat (length: 255)

        [MaxLength(2147483647)]
        [Display(Name = "Cbb")]
        public byte[] Cbb { get; set; } // CBB (length: 2147483647)

        [Required]
        [Display(Name = "Id pac")]
        public int IdPac { get; set; } // id_pac

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Calle")]
        public string Calle { get; set; } // calle (length: 80)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(13)]
        [StringLength(13)]
        [Display(Name = "Num int")]
        public string NumInt { get; set; } // num_int (length: 13)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(11)]
        [StringLength(11)]
        [Display(Name = "Num ext")]
        public string NumExt { get; set; } // num_ext (length: 11)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Col")]
        public string Col { get; set; } // col (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Deleg")]
        public string Deleg { get; set; } // deleg (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Calles")]
        public string Calles { get; set; } // calles (length: 40)

        [Required]
        [Display(Name = "Id pais")]
        public int IdPais { get; set; } // id_pais

        [Required]
        [Display(Name = "Id edo")]
        public int IdEdo { get; set; } // id_edo

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec tim pac")]
        public System.DateTime FecTimPac { get; set; } // fec_tim_pac

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Cert sat")]
        public string CertSat { get; set; } // cert_sat (length: 100)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Xml canc")]
        public string XmlCanc { get; set; } // xml_canc

        [Required]
        [Display(Name = "C timb")]
        public byte CTimb { get; set; } // c_timb

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Cfd dir exp")]
        public string CfdDirExp { get; set; } // cfd_dir_exp

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Ult dig cta")]
        public string UltDigCta { get; set; } // ult_dig_cta

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Reg fis")]
        public string RegFis { get; set; } // reg_fis

        [Required(AllowEmptyStrings = true)]
        [MaxLength(36)]
        [StringLength(36)]
        [Display(Name = "Id sugar")]
        public string IdSugar { get; set; } // id_sugar (length: 36)

        [Required]
        [Display(Name = "Id cli cta")]
        public int IdCliCta { get; set; } // id_cli_cta

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Tip pag cta")]
        public string TipPagCta { get; set; } // tip_pag_cta

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Bco cta")]
        public string BcoCta { get; set; } // bco_cta

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Idis cta")]
        public string IdisCta { get; set; } // idis_cta

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Registropatronal")]
        public string Registropatronal { get; set; } // registropatronal

        public RegNomCfdiClie()
        {
            IdEmp = 0;
            CMost = 0;
            Contacto1 = "";
            Depto = "";
            SelloDigi = "";
            Certifi = "";
            NumApr = 0;
            AnioApr = 0;
            IdNota = 0;
            CfdStatus = 0;
            IdTipGrp = 0;
            IdCert = 0;
            IdSisDoctosSerFol = 0;
            TipPag = 0;
            CIepsDesg = 0;
            IdTipSer = 0;
            Uuid = "";
            SelloSat = "";
            IdPac = 0;
            Calle = "";
            NumInt = "";
            NumExt = "";
            Col = "";
            Deleg = "";
            Calles = "";
            IdPais = 0;
            IdEdo = 0;
            CertSat = "";
            XmlCanc = "";
            CTimb = 0;
            CfdDirExp = "";
            UltDigCta = "";
            RegFis = "";
            IdSugar = "";
            IdCliCta = 0;
            TipPagCta = "";
            BcoCta = "";
            IdisCta = "";
            Registropatronal = "";
        }
    }

}
// </auto-generated>
