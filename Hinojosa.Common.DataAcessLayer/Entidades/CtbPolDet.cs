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

    // ctb_pol_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CtbPolDet
    {

        ///<summary>
        /// ID del detalle de la poliza
        ///</summary>
        [Required]
        [Display(Name = "Id pol det")]
        public int IdPolDet { get; set; } // id_pol_det (Primary key)

        [Required]
        [Display(Name = "Id pol")]
        public int IdPol { get; set; } // id_pol

        [Required]
        [Display(Name = "Id per")]
        public int IdPer { get; set; } // id_per

        [Required]
        [Display(Name = "Id cta")]
        public int IdCta { get; set; } // id_cta

        [Required]
        [Display(Name = "Id cen cto")]
        public int IdCenCto { get; set; } // id_cen_cto

        [Required]
        [Display(Name = "Id cod srv")]
        public int IdCodSrv { get; set; } // id_cod_srv

        [Required]
        [Display(Name = "Id tip dia")]
        public int IdTipDia { get; set; } // id_tip_dia

        [Required]
        [Display(Name = "Id emp")]
        public int IdEmp { get; set; } // id_emp

        [Required]
        [Display(Name = "Num part")]
        public int NumPart { get; set; } // num_part

        [Required]
        [Display(Name = "Id ref")]
        public int IdRef { get; set; } // id_ref

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Ref")]
        public string @Ref { get; set; } // ref (length: 50)

        [Required]
        [Display(Name = "Id cpt")]
        public int IdCpt { get; set; } // id_cpt

        [Required(AllowEmptyStrings = true)]
        [MaxLength(2147483647)]
        [StringLength(2147483647)]
        [Display(Name = "Concepto")]
        public string Concepto { get; set; } // concepto (length: 2147483647)

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Cargo")]
        public decimal Cargo { get; set; } // cargo

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Abono")]
        public decimal Abono { get; set; } // abono

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc

        [Required]
        [Display(Name = "Id doc")]
        public int IdDoc { get; set; } // id_doc

        [Required]
        [Display(Name = "Id mod")]
        public int IdMod { get; set; } // id_mod

        [Required]
        [Display(Name = "Num doc")]
        public int NumDoc { get; set; } // num_doc

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Serie")]
        public string Serie { get; set; } // serie (length: 10)

        [Required]
        [Display(Name = "Tipo")]
        public byte Tipo { get; set; } // tipo

        [Required]
        [Display(Name = "Id cli prov")]
        public int IdCliProv { get; set; } // id_cli_prov

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro

        [Required]
        [Display(Name = "Id mda")]
        public int IdMda { get; set; } // id_mda

        [Required]
        [Display(Name = "Tc")]
        public double Tc { get; set; } // tc

        [Required]
        [Display(Name = "Oper")]
        public byte Oper { get; set; } // oper

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Cargo ext")]
        public decimal CargoExt { get; set; } // cargo_ext

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Abono ext")]
        public decimal AbonoExt { get; set; } // abono_ext

        [Required]
        [Display(Name = "Origen")]
        public byte Origen { get; set; } // origen

        [Required]
        [Display(Name = "Id pol det ori")]
        public int IdPolDetOri { get; set; } // id_pol_det_ori

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec pol")]
        public System.DateTime FecPol { get; set; } // fec_pol

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec doc")]
        public System.DateTime FecDoc { get; set; } // fec_doc

        [Required]
        [Display(Name = "Id ent")]
        public int IdEnt { get; set; } // id_ent

        [Required]
        [Display(Name = "Id part")]
        public int IdPart { get; set; } // id_part

        [Required]
        [Display(Name = "Id clas")]
        public int IdClas { get; set; } // id_clas

        [Required]
        [Display(Name = "Id tip obj")]
        public int IdTipObj { get; set; } // id_tip_obj

        [Required]
        [Display(Name = "Id tip rub")]
        public int IdTipRub { get; set; } // id_tip_rub

        [Required]
        [Display(Name = "Id campo")]
        public int IdCampo { get; set; } // id_campo

        [Required]
        [Display(Name = "Id impto")]
        public int IdImpto { get; set; } // id_impto

        [Required]
        [Display(Name = "Orden asi")]
        public int OrdenAsi { get; set; } // orden_asi

        [Required]
        [Display(Name = "Bloque")]
        public int Bloque { get; set; } // bloque

        [Required]
        [Display(Name = "Id cli cta de")]
        public int IdCliCtaDe { get; set; } // id_cli_cta_de

        [Required]
        [Display(Name = "Id cli fa da")]
        public int IdCliFaDa { get; set; } // id_cli_fa_da

        [Required]
        [Display(Name = "Id cta bco")]
        public int IdCtaBco { get; set; } // id_cta_bco

        [Required]
        [Display(Name = "Id tip doc apl")]
        public int IdTipDocApl { get; set; } // id_tip_doc_apl

        [Required]
        [Display(Name = "Id doc apl")]
        public int IdDocApl { get; set; } // id_doc_apl

        [Required]
        [Display(Name = "Num doc apl")]
        public int NumDocApl { get; set; } // num_doc_apl

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Serie apl")]
        public string SerieApl { get; set; } // serie_apl (length: 10)

        [Required]
        [Display(Name = "Ref num apl")]
        public int RefNumApl { get; set; } // ref_num_apl

        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "No fact")]
        public string NoFact { get; set; } // no_fact (length: 80)

        [Required]
        [Display(Name = "Ref num")]
        public int RefNum { get; set; } // ref_num

        [Required]
        [Display(Name = "Num chq")]
        public int NumChq { get; set; } // num_chq

        [Required]
        [Display(Name = "Id act")]
        public int IdAct { get; set; } // id_act

        [Required]
        [Display(Name = "Id alm")]
        public int IdAlm { get; set; } // id_alm

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Rfc")]
        public string Rfc { get; set; } // rfc (length: 40)

        [Required]
        [Display(Name = "Id fis rel")]
        public int IdFisRel { get; set; } // id_fis_rel

        [Required]
        [Display(Name = "Id suc")]
        public int IdSuc { get; set; } // id_suc

        [Required]
        [Display(Name = "Num reg lay")]
        public int NumRegLay { get; set; } // num_reg_lay

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Uuid")]
        public string Uuid { get; set; } // UUID (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Bco cod dest")]
        public string BcoCodDest { get; set; } // bco_cod_dest (length: 25)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Des bco dest")]
        public string DesBcoDest { get; set; } // des_bco_dest (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Cta dest")]
        public string CtaDest { get; set; } // cta_dest (length: 25)

        [Required]
        [Display(Name = "C bco ext dest")]
        public byte CBcoExtDest { get; set; } // c_bco_ext_dest

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Cta ori")]
        public string CtaOri { get; set; } // cta_ori (length: 25)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Bco cod ori")]
        public string BcoCodOri { get; set; } // bco_cod_ori (length: 20)

        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Des bco ori")]
        public string DesBcoOri { get; set; } // des_bco_ori (length: 40)

        [Required]
        [Display(Name = "C bco ext ori")]
        public byte CBcoExtOri { get; set; } // c_bco_ext_ori

        [Required]
        [Display(Name = "Id emp nom")]
        public int IdEmpNom { get; set; } // id_emp_nom

        [Required(AllowEmptyStrings = true)]
        [MaxLength(150)]
        [StringLength(150)]
        [Display(Name = "Nom emp")]
        public string NomEmp { get; set; } // nom_emp (length: 150)

        [Required]
        [Display(Name = "Id tip trn")]
        public int IdTipTrn { get; set; } // id_tip_trn

        [Required(AllowEmptyStrings = true)]
        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "Cve met pag")]
        public string CveMetPag { get; set; } // cve_met_pag (length: 2)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Tax ID")]
        public string TaxId { get; set; } // tax_id (length: 40)

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Saldo")]
        public decimal Saldo { get; set; } // saldo

        [Required]
        [Display(Name = "Tip trn bco")]
        public int TipTrnBco { get; set; } // tip_trn_bco

        public CtbPolDet()
        {
            IdPolDet = 0;
            IdPol = 0;
            IdPer = 0;
            IdCta = 0;
            IdCenCto = 0;
            IdCodSrv = 0;
            IdTipDia = 0;
            IdEmp = 0;
            NumPart = 0;
            IdRef = 0;
            @Ref = "";
            IdCpt = 0;
            Concepto = "";
            Cargo = 0m;
            Abono = 0m;
            IdTipDoc = 0;
            IdDoc = 0;
            IdMod = 0;
            NumDoc = 0;
            Serie = "";
            Tipo = 0;
            IdCliProv = 0;
            IdPro = 0;
            IdMda = 0;
            Tc = 0;
            Oper = 0;
            CargoExt = 0m;
            AbonoExt = 0m;
            Origen = 0;
            IdPolDetOri = 0;
            IdEnt = 0;
            IdPart = 0;
            IdClas = 0;
            IdTipObj = 0;
            IdTipRub = 0;
            IdCampo = 0;
            IdImpto = 0;
            OrdenAsi = 0;
            Bloque = 0;
            IdCliCtaDe = 0;
            IdCliFaDa = 0;
            IdCtaBco = 0;
            IdTipDocApl = 0;
            IdDocApl = 0;
            NumDocApl = 0;
            SerieApl = "";
            RefNumApl = 0;
            NoFact = "";
            RefNum = 0;
            NumChq = 0;
            IdAct = 0;
            IdAlm = 0;
            Rfc = "";
            IdFisRel = 0;
            IdSuc = 0;
            NumRegLay = 0;
            Uuid = "";
            BcoCodDest = "";
            DesBcoDest = "";
            CtaDest = "";
            CBcoExtDest = 0;
            CtaOri = "";
            BcoCodOri = "";
            DesBcoOri = "";
            CBcoExtOri = 0;
            IdEmpNom = 0;
            NomEmp = "";
            IdTipTrn = 0;
            CveMetPag = "";
            TaxId = "";
            Saldo = 0m;
            TipTrnBco = 0;
        }
    }

}
// </auto-generated>
