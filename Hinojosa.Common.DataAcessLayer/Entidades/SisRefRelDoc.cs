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

    // sis_ref_rel_doc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisRefRelDoc
    {
        [Required]
        [Display(Name = "Id ref det doc")]
        public int IdRefDetDoc { get; set; } // id_ref_det_doc (Primary key)

        [Required]
        [Display(Name = "Id ref rel det")]
        public int IdRefRelDet { get; set; } // id_ref_rel_det

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Id int")]
        public int IdInt { get; set; } // id_int

        [Required]
        [Display(Name = "Id cli")]
        public int IdCli { get; set; } // id_cli

        [Required]
        [Display(Name = "Id prov")]
        public int IdProv { get; set; } // id_prov

        [Required]
        [Display(Name = "Id mda")]
        public int IdMda { get; set; } // id_mda

        [Required]
        [Display(Name = "Oper")]
        public byte Oper { get; set; } // oper

        [Required]
        [Display(Name = "Tc")]
        public double Tc { get; set; } // tc

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc

        [Required]
        [Display(Name = "Id doc")]
        public int IdDoc { get; set; } // id_doc

        [Required]
        [Display(Name = "Id doc det")]
        public int IdDocDet { get; set; } // id_doc_det

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec doc")]
        public System.DateTime FecDoc { get; set; } // fec_doc

        [Required]
        [Display(Name = "Num doc")]
        public int NumDoc { get; set; } // num_doc

        [Required]
        [Display(Name = "Cant")]
        public double Cant { get; set; } // cant

        [Required]
        [Display(Name = "Costo")]
        public double Costo { get; set; } // costo

        [Required]
        [Display(Name = "Precio")]
        public double Precio { get; set; } // precio

        [Required]
        [Display(Name = "Costo tot")]
        public double CostoTot { get; set; } // costo_tot

        [Required]
        [Display(Name = "Imp tot")]
        public double ImpTot { get; set; } // imp_tot

        [Required]
        [Display(Name = "Id impto")]
        public int IdImpto { get; set; } // id_impto

        [Required]
        [Display(Name = "Id ref")]
        public int IdRef { get; set; } // id_ref

        [Required]
        [Display(Name = "Id cod srv")]
        public int IdCodSrv { get; set; } // id_cod_srv

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [Display(Name = "Id cli cta de")]
        public int IdCliCtaDe { get; set; } // id_cli_cta_de

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Serie")]
        public string Serie { get; set; } // serie (length: 10)

        [Required]
        [Display(Name = "Id aux")]
        public int IdAux { get; set; } // id_aux

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

        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Ref num")]
        public string RefNum { get; set; } // ref_num (length: 40)

        [Required]
        [Display(Name = "Num chq")]
        public int NumChq { get; set; } // num_chq

        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Ref num apl")]
        public string RefNumApl { get; set; } // ref_num_apl (length: 40)

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
        [Display(Name = "Costo bse")]
        public double CostoBse { get; set; } // costo_bse

        [Required]
        [Display(Name = "Precio bse")]
        public double PrecioBse { get; set; } // precio_bse

        [Required]
        [Display(Name = "Costo tot bse")]
        public double CostoTotBse { get; set; } // costo_tot_bse

        [Required]
        [Display(Name = "Imp tot bse")]
        public double ImpTotBse { get; set; } // imp_tot_bse

        [Required]
        [Display(Name = "Id tip sol")]
        public int IdTipSol { get; set; } // id_tip_sol

        [Required]
        [Display(Name = "C en cga")]
        public byte CEnCga { get; set; } // c_en_cga

        [Required]
        [Display(Name = "Imptos")]
        public double Imptos { get; set; } // imptos

        [Required]
        [Display(Name = "Imptos bse")]
        public double ImptosBse { get; set; } // imptos_bse

        [Required]
        [Display(Name = "Costo tot cimptos")]
        public double CostoTotCimptos { get; set; } // costo_tot_cimptos

        [Required]
        [Display(Name = "Imp tot cimptos")]
        public double ImpTotCimptos { get; set; } // imp_tot_cimptos

        [Required]
        [Display(Name = "Costo tot cimptos bse")]
        public double CostoTotCimptosBse { get; set; } // costo_tot_cimptos_bse

        [Required]
        [Display(Name = "Imp tot cimptos bse")]
        public double ImpTotCimptosBse { get; set; } // imp_tot_cimptos_bse

        [Required]
        [Display(Name = "Cant apl")]
        public double CantApl { get; set; } // cant_apl

        [Required]
        [Display(Name = "Sec")]
        public int Sec { get; set; } // sec

        [Required]
        [Display(Name = "Ptg kit")]
        public double PtgKit { get; set; } // ptg_kit

        [Required]
        [Display(Name = "Base grav")]
        public double BaseGrav { get; set; } // base_grav

        [Required]
        [Display(Name = "Tip hon")]
        public int TipHon { get; set; } // tip_hon

        [Required]
        [Display(Name = "Ptg hon")]
        public double PtgHon { get; set; } // ptg_hon

        [Required]
        [Display(Name = "Id cga")]
        public int IdCga { get; set; } // id_cga

        [Required]
        [Display(Name = "Id fac")]
        public int IdFac { get; set; } // id_fac

        [Required]
        [Display(Name = "Id cac")]
        public int IdCac { get; set; } // id_cac

        [Required]
        [Display(Name = "Precio ext")]
        public double PrecioExt { get; set; } // precio_ext

        [Required]
        [Display(Name = "Cant real gto")]
        public double CantRealGto { get; set; } // cant_real_gto

        [Required]
        [Display(Name = "Id doc det apl")]
        public int IdDocDetApl { get; set; } // id_doc_det_apl

        [Required]
        [Display(Name = "C dev")]
        public int CDev { get; set; } // c_dev

        [Required]
        [Display(Name = "Id nc")]
        public int IdNc { get; set; } // id_nc

        [Required]
        [Display(Name = "Mto dev bse")]
        public double MtoDevBse { get; set; } // mto_dev_bse

        [Required]
        [Display(Name = "C car 26")]
        public int CCar26 { get; set; } // c_car_26

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir60Referencia pointed by [sis_ref_rel_doc].([IdRef]) (FK_sis_ref_rel_doc_SIR_60_REFERENCIAS)
        /// </summary>
        public virtual SIR_Sir60Referencia SIR_Sir60Referencia { get; set; } // FK_sis_ref_rel_doc_SIR_60_REFERENCIAS

        public SisRefRelDoc()
        {
            IdRefRelDet = 0;
            IdUsr = 0;
            IdInt = 0;
            IdCli = 0;
            IdProv = 0;
            IdMda = 0;
            Oper = 0;
            Tc = 0;
            IdPro = 0;
            IdTipDoc = 0;
            IdDoc = 0;
            IdDocDet = 0;
            NumDoc = 0;
            Cant = 0;
            Costo = 0;
            Precio = 0;
            CostoTot = 0;
            ImpTot = 0;
            IdImpto = 0;
            IdRef = 0;
            IdCodSrv = 0;
            Status = 0;
            IdCliCtaDe = 0;
            Serie = "";
            IdAux = 0;
            IdCliFaDa = 0;
            IdCtaBco = 0;
            IdTipDocApl = 0;
            IdDocApl = 0;
            RefNum = "0";
            NumChq = 0;
            RefNumApl = "0";
            IdAct = 0;
            IdAlm = 0;
            Rfc = "";
            CostoBse = 0;
            PrecioBse = 0;
            CostoTotBse = 0;
            ImpTotBse = 0;
            IdTipSol = 0;
            CEnCga = 0;
            Imptos = 0;
            ImptosBse = 0;
            CostoTotCimptos = 0;
            ImpTotCimptos = 0;
            CostoTotCimptosBse = 0;
            ImpTotCimptosBse = 0;
            CantApl = 0;
            Sec = 0;
            PtgKit = 0;
            BaseGrav = 0;
            TipHon = 0;
            PtgHon = 0;
            IdCga = 0;
            IdFac = 0;
            IdCac = 0;
            PrecioExt = 0;
            CantRealGto = 0;
            IdDocDetApl = 0;
            CDev = 0;
            IdNc = 0;
            MtoDevBse = 0;
            CCar26 = 0;
        }
    }

}
// </auto-generated>
