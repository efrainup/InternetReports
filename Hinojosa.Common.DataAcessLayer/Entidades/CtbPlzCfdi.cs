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

    // ctb_plz_cfdi
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CtbPlzCfdi
    {
        [Required]
        [Display(Name = "Id ctb plz cfd")]
        public int IdCtbPlzCfd { get; set; } // Id_ctb_plz_cfd (Primary key)

        [Required]
        [Display(Name = "Id tip cta sat")]
        public int IdTipCtaSat { get; set; } // id_tip_cta_sat

        [Required]
        [Display(Name = "Periodo")]
        public int Periodo { get; set; } // periodo

        [Required(AllowEmptyStrings = true)]
        [MaxLength(4)]
        [StringLength(4)]
        [Display(Name = "Version")]
        public string Version { get; set; } // version (length: 4)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Rfc")]
        public string Rfc { get; set; } // RFC (length: 15)

        [Required]
        [Display(Name = "Mes")]
        public int Mes { get; set; } // mes

        [Required]
        [Display(Name = "Anio")]
        public int Anio { get; set; } // anio

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Numunidenpol")]
        public string Numunidenpol { get; set; } // numunidenpol

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec pol")]
        public System.DateTime FecPol { get; set; } // fec_pol

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Concepto")]
        public string Concepto { get; set; } // concepto

        [Required]
        [Display(Name = "Id tip tran pol")]
        public int IdTipTranPol { get; set; } // id_tip_tran_pol

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Num cta")]
        public string NumCta { get; set; } // NumCta (length: 30)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Des cta")]
        public string DesCta { get; set; } // DesCta

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Concepto cta")]
        public string ConceptoCta { get; set; } // concepto_cta

        [Required]
        [Display(Name = "Debe")]
        public double Debe { get; set; } // Debe

        [Required]
        [Display(Name = "Haber")]
        public double Haber { get; set; } // Haber

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Uuid")]
        public string Uuid { get; set; } // UUID (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Rfc comp")]
        public string RfcComp { get; set; } // RFC_comp (length: 15)

        [Required]
        [Display(Name = "Monto total")]
        public double MontoTotal { get; set; } // MontoTotal

        [Required]
        [Display(Name = "Id mda")]
        public int IdMda { get; set; } // id_mda

        [Required(AllowEmptyStrings = true)]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Des mda")]
        public string DesMda { get; set; } // des_mda (length: 3)

        [Required]
        [Display(Name = "Tc")]
        public double Tc { get; set; } // tc

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Cfd cbb serie")]
        public string CfdCbbSerie { get; set; } // CFD_CBB_Serie (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Cfd cbb num fol")]
        public string CfdCbbNumFol { get; set; } // CFD_CBB_NumFol (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Num fact ext")]
        public string NumFactExt { get; set; } // NumFactExt (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Tax ID")]
        public string TaxId { get; set; } // TaxID (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Num cheq")]
        public string NumCheq { get; set; } // NumCheq (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Ban emis nal")]
        public string BanEmisNal { get; set; } // BanEmisNal (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Ban emis ext")]
        public string BanEmisExt { get; set; } // BanEmisExt (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Cta orig")]
        public string CtaOrig { get; set; } // CtaOrig (length: 40)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec doc")]
        public System.DateTime FecDoc { get; set; } // fec_doc

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Benef")]
        public string Benef { get; set; } // Benef (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Banco ori nal")]
        public string BancoOriNal { get; set; } // BancoOriNal (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Banco ori ext")]
        public string BancoOriExt { get; set; } // BancoOriExt (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Cta dest")]
        public string CtaDest { get; set; } // CtaDest (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Banco dest nal")]
        public string BancoDestNal { get; set; } // BancoDestNal (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Banco dest ext")]
        public string BancoDestExt { get; set; } // BancoDestExt (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Met pago pol")]
        public string MetPagoPol { get; set; } // MetPagoPol (length: 40)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        public CtbPlzCfdi()
        {
            IdTipCtaSat = 0;
            Periodo = 0;
            Version = "";
            Rfc = "";
            Mes = 0;
            Anio = 0;
            Numunidenpol = "";
            Concepto = "";
            IdTipTranPol = 0;
            NumCta = "";
            DesCta = "";
            ConceptoCta = "";
            Debe = 0;
            Haber = 0;
            Uuid = "";
            RfcComp = "";
            MontoTotal = 0;
            IdMda = 0;
            DesMda = "";
            Tc = 0;
            CfdCbbSerie = "";
            CfdCbbNumFol = "";
            NumFactExt = "";
            TaxId = "";
            NumCheq = "";
            BanEmisNal = "";
            BanEmisExt = "";
            CtaOrig = "";
            Benef = "";
            BancoOriNal = "";
            BancoOriExt = "";
            CtaDest = "";
            BancoDestNal = "";
            BancoDestExt = "";
            MetPagoPol = "";
            IdUsr = 0;
        }
    }

}
// </auto-generated>