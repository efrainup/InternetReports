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

    // vta_aux_cot
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaAuxCot
    {
        [Required]
        [Display(Name = "Id vta aux")]
        public int IdVtaAux { get; set; } // id_vta_aux (Primary key)

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [Display(Name = "Id suc")]
        public int IdSuc { get; set; } // id_suc

        [Required]
        [Display(Name = "Id cli")]
        public int IdCli { get; set; } // id_cli

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc

        [Required]
        [Display(Name = "Id doc")]
        public int IdDoc { get; set; } // id_doc

        [Required]
        [Display(Name = "Num doc")]
        public int NumDoc { get; set; } // num_doc

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Ref")]
        public string @Ref { get; set; } // ref (length: 25)

        [Required]
        [Display(Name = "Id a tip doc")]
        public int IdATipDoc { get; set; } // id_a_tip_doc

        [Required]
        [Display(Name = "Id a doc")]
        public int IdADoc { get; set; } // id_a_doc

        [Required]
        [Display(Name = "A num doc")]
        public int ANumDoc { get; set; } // a_num_doc

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "A ref")]
        public string ARef { get; set; } // a_ref (length: 25)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha")]
        public System.DateTime Fecha { get; set; } // fecha

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Vence")]
        public System.DateTime Vence { get; set; } // vence

        [Required]
        [Display(Name = "Sub")]
        public double Sub { get; set; } // sub

        [Required]
        [Display(Name = "Imptos")]
        public double Imptos { get; set; } // imptos

        [Required]
        [Display(Name = "Total")]
        public double Total { get; set; } // total

        [Required]
        [Display(Name = "Saldo")]
        public double Saldo { get; set; } // saldo

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha reg")]
        public System.DateTime FechaReg { get; set; } // fecha_reg

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
        [Display(Name = "Sub bse")]
        public double SubBse { get; set; } // sub_bse

        [Required]
        [Display(Name = "Imptos bse")]
        public double ImptosBse { get; set; } // imptos_bse

        [Required]
        [Display(Name = "Total bse")]
        public double TotalBse { get; set; } // total_bse

        [Required]
        [Display(Name = "Saldo bse")]
        public double SaldoBse { get; set; } // saldo_bse

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec pag")]
        public System.DateTime FecPag { get; set; } // fec_pag

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Serie")]
        public string Serie { get; set; } // serie (length: 10)

        [Required]
        [Display(Name = "Id sis cnl")]
        public int IdSisCnl { get; set; } // id_sis_cnl

        [Required]
        [Display(Name = "Id cpt")]
        public int IdCpt { get; set; } // id_cpt

        [Required]
        [Display(Name = "Id cnd")]
        public int IdCnd { get; set; } // id_cnd

        [Required]
        [Display(Name = "No chq")]
        public int NoChq { get; set; } // no_chq

        [Required]
        [Display(Name = "Id bco cta")]
        public int IdBcoCta { get; set; } // id_bco_cta

        [Required]
        [Display(Name = "C cnl")]
        public byte CCnl { get; set; } // c_cnl

        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Ref num")]
        public string RefNum { get; set; } // ref_num (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "A serie")]
        public string ASerie { get; set; } // A_Serie (length: 10)

        [Required]
        [Display(Name = "Id mon")]
        public int IdMon { get; set; } // id_mon

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec est pag")]
        public System.DateTime FecEstPag { get; set; } // fec_est_pag

        [Required]
        [Display(Name = "Uti per")]
        public double UtiPer { get; set; } // uti_per

        [Required]
        [Display(Name = "Total apl bse")]
        public double TotalAplBse { get; set; } // total_apl_bse

        [Required]
        [Display(Name = "Id caja")]
        public int IdCaja { get; set; } // id_caja

        [Required]
        [Display(Name = "Id corte")]
        public int IdCorte { get; set; } // id_corte

        [Required]
        [Display(Name = "Id tipo pago")]
        public int IdTipoPago { get; set; } // id_tipo_pago

        [Required]
        [Display(Name = "Tot pag")]
        public double TotPag { get; set; } // tot_pag

        [Required(AllowEmptyStrings = true)]
        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "Banco")]
        public string Banco { get; set; } // Banco (length: 128)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Tar")]
        public string Tar { get; set; } // Tar (length: 20)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(256)]
        [StringLength(256)]
        [Display(Name = "Tit")]
        public string Tit { get; set; } // tit (length: 256)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Venc")]
        public System.DateTime Venc { get; set; } // venc

        [Required(AllowEmptyStrings = true)]
        [MaxLength(8)]
        [StringLength(8)]
        [Display(Name = "Cods")]
        public string Cods { get; set; } // cods (length: 8)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Autoriz")]
        public string Autoriz { get; set; } // autoriz (length: 20)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(512)]
        [StringLength(512)]
        [Display(Name = "Cadt")]
        public string Cadt { get; set; } // cadt (length: 512)

        [Required]
        [Display(Name = "Abo mon")]
        public double AboMon { get; set; } // abo_mon

        [Required]
        [Display(Name = "Id vale")]
        public int IdVale { get; set; } // id_vale

        [Display(Name = "Id print")]
        public int? IdPrint { get; set; } // ID_PRINT

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Display(Name = "Id tur")]
        public int? IdTur { get; set; } // id_tur

        [Required]
        [Display(Name = "C ped")]
        public int CPed { get; set; } // c_ped

        [Required]
        [Display(Name = "Ped status")]
        public int PedStatus { get; set; } // ped_status

        [Required]
        [Display(Name = "C surt")]
        public int CSurt { get; set; } // c_surt

        [Required]
        [Display(Name = "Surt status")]
        public int SurtStatus { get; set; } // surt_status

        [Required(AllowEmptyStrings = true)]
        [MaxLength(512)]
        [StringLength(512)]
        [Display(Name = "Nom cli mos")]
        public string NomCliMos { get; set; } // nom_cli_mos (length: 512)

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required]
        [Display(Name = "Id cli fa da")]
        public int IdCliFaDa { get; set; } // id_cli_fa_da

        public VtaAuxCot()
        {
            IdVtaAux = 0;
            IdUsr = 0;
            IdSuc = 0;
            IdCli = 0;
            IdTipDoc = 0;
            IdDoc = 0;
            NumDoc = 0;
            @Ref = "";
            IdATipDoc = 0;
            IdADoc = 0;
            ANumDoc = 0;
            ARef = "";
            Sub = 0;
            Imptos = 0;
            Total = 0;
            Saldo = 0;
            IdMda = 0;
            Tc = 0;
            Oper = 0;
            SubBse = 0;
            ImptosBse = 0;
            TotalBse = 0;
            SaldoBse = 0;
            Serie = "";
            IdSisCnl = 0;
            IdCpt = 0;
            IdCnd = 0;
            NoChq = 0;
            IdBcoCta = 0;
            CCnl = 0;
            RefNum = "0";
            ASerie = "";
            IdMon = 0;
            UtiPer = 0.00;
            TotalAplBse = 0.00;
            IdCaja = 0;
            IdCorte = 0;
            IdTipoPago = 0;
            TotPag = 0;
            Banco = "";
            Tar = "";
            Tit = "";
            Cods = "";
            Autoriz = "";
            Cadt = "";
            AboMon = 0.00;
            IdVale = 0;
            Status = 0;
            CPed = 0;
            PedStatus = 0;
            CSurt = 0;
            SurtStatus = 0;
            NomCliMos = "0";
            IdNota = 0;
            IdCliFaDa = 0;
        }
    }

}
// </auto-generated>
