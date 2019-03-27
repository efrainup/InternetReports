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

    // cxp_pag_enc_aux_prov
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CxpPagEncAuxProv
    {
        [Required]
        [Display(Name = "Id pag aux")]
        public int IdPagAux { get; set; } // id_pag_aux (Primary key)

        [Required]
        [Display(Name = "Id pago")]
        public int IdPago { get; set; } // id_pago

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc

        [Required]
        [Display(Name = "Id prov")]
        public int IdProv { get; set; } // id_prov

        [Required(AllowEmptyStrings = true)]
        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "Nom 1")]
        public string Nom1 { get; set; } // nom1 (length: 128)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Rfc")]
        public string Rfc { get; set; } // rfc (length: 15)

        [Required]
        [Display(Name = "Id pais")]
        public int IdPais { get; set; } // id_pais

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Res fis")]
        public string ResFis { get; set; } // res_fis (length: 5)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Num reg ID fis")]
        public string NumRegIdFis { get; set; } // num_reg_id_fis (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Uso cfdi")]
        public string UsoCfdi { get; set; } // uso_cfdi (length: 5)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(4000)]
        [StringLength(4000)]
        [Display(Name = "Sello digi")]
        public string SelloDigi { get; set; } // sello_digi (length: 4000)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Certifi")]
        public string Certifi { get; set; } // certifi (length: 100)

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required]
        [Display(Name = "Cfd status")]
        public int CfdStatus { get; set; } // cfd_status

        [Required]
        [Display(Name = "Id cert")]
        public int IdCert { get; set; } // id_cert

        [Required(AllowEmptyStrings = true)]
        [MaxLength(36)]
        [StringLength(36)]
        [Display(Name = "Uuid")]
        public string Uuid { get; set; } // uuid (length: 36)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(4000)]
        [StringLength(4000)]
        [Display(Name = "Sello sat")]
        public string SelloSat { get; set; } // sello_sat (length: 4000)

        [Required]
        [MaxLength(2147483647)]
        [Display(Name = "Cbb")]
        public byte[] Cbb { get; set; } // cbb (length: 2147483647)

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
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Cp exp")]
        public string CpExp { get; set; } // cp_exp (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Confirmacion")]
        public string Confirmacion { get; set; } // confirmacion (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(4)]
        [StringLength(4)]
        [Display(Name = "Ver")]
        public string Ver { get; set; } // ver (length: 4)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec pago")]
        public System.DateTime FecPago { get; set; } // fec_pago

        [Required(AllowEmptyStrings = true)]
        [MaxLength(4)]
        [StringLength(4)]
        [Display(Name = "Forma pago")]
        public string FormaPago { get; set; } // forma_pago (length: 4)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Metodo pago")]
        public string MetodoPago { get; set; } // metodo_pago (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Mda pago")]
        public string MdaPago { get; set; } // mda_pago (length: 5)

        [Required]
        [Display(Name = "Tc pago")]
        public double TcPago { get; set; } // tc_pago

        [Required]
        [Display(Name = "Mto pago")]
        public double MtoPago { get; set; } // mto_pago

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Num oper pago")]
        public string NumOperPago { get; set; } // num_oper_pago (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Rfc emi ori")]
        public string RfcEmiOri { get; set; } // rfc_emi_ori (length: 15)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(300)]
        [StringLength(300)]
        [Display(Name = "Nom emi ext ori")]
        public string NomEmiExtOri { get; set; } // nom_emi_ext_ori (length: 300)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Cta pago")]
        public string CtaPago { get; set; } // cta_pago (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Rfc rec dest")]
        public string RfcRecDest { get; set; } // rfc_rec_dest (length: 15)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Cta benef")]
        public string CtaBenef { get; set; } // cta_benef (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(4)]
        [StringLength(4)]
        [Display(Name = "Tip cad pago")]
        public string TipCadPago { get; set; } // tip_cad_pago (length: 4)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(4000)]
        [StringLength(4000)]
        [Display(Name = "Cert pago")]
        public string CertPago { get; set; } // cert_pago (length: 4000)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(4000)]
        [StringLength(4000)]
        [Display(Name = "Cad pago")]
        public string CadPago { get; set; } // cad_pago (length: 4000)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(4000)]
        [StringLength(4000)]
        [Display(Name = "Sello pago")]
        public string SelloPago { get; set; } // sello_pago (length: 4000)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Reg fis des")]
        public string RegFisDes { get; set; } // reg_fis_des (length: 250)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Tip pag cta des")]
        public string TipPagCtaDes { get; set; } // tip_pag_cta_des (length: 250)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Met pag des")]
        public string MetPagDes { get; set; } // met_pag_des (length: 250)

        [Required]
        [Display(Name = "Id tip cfd")]
        public int IdTipCfd { get; set; } // id_tip_cfd

        [Required]
        [Display(Name = "Id pro fis")]
        public int IdProFis { get; set; } // id_pro_fis

        [Required]
        [Display(Name = "Status concil")]
        public byte StatusConcil { get; set; } // status_concil

        [Required]
        [Display(Name = "Mail env")]
        public bool MailEnv { get; set; } // mail_env

        public CxpPagEncAuxProv()
        {
            IdProv = 0;
            Nom1 = "";
            Rfc = "";
            IdPais = 0;
            ResFis = "";
            NumRegIdFis = "";
            UsoCfdi = "";
            SelloDigi = "";
            Certifi = "";
            IdNota = 0;
            CfdStatus = 0;
            IdCert = 0;
            Uuid = "";
            SelloSat = "";
            CertSat = "";
            XmlCanc = "";
            CTimb = 0;
            CpExp = "";
            Confirmacion = "";
            Ver = "";
            FormaPago = "";
            MetodoPago = "";
            MdaPago = "";
            TcPago = 0;
            MtoPago = 0;
            NumOperPago = "";
            RfcEmiOri = "";
            NomEmiExtOri = "";
            CtaPago = "";
            RfcRecDest = "";
            CtaBenef = "";
            TipCadPago = "";
            CertPago = "";
            CadPago = "";
            SelloPago = "";
            RegFisDes = "";
            TipPagCtaDes = "";
            MetPagDes = "";
            IdTipCfd = 0;
            IdProFis = 0;
            StatusConcil = 0;
            MailEnv = false;
        }
    }

}
// </auto-generated>
