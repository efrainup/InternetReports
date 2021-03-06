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

    // sis_imptos_cta_de_barbara
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisImptosCtaDeBarbara
    {
        [Required]
        [Display(Name = "Id sis imp")]
        public int IdSisImp { get; set; } // id_sis_imp (Primary key)

        [Required]
        [Display(Name = "Id rel imp")]
        public int IdRelImp { get; set; } // id_rel_imp (Primary key)

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc (Primary key)

        [Required]
        [Display(Name = "Id doc")]
        public int IdDoc { get; set; } // id_doc (Primary key)

        [Required]
        [Display(Name = "Id doc part")]
        public int IdDocPart { get; set; } // id_doc_part (Primary key)

        [Required]
        [Display(Name = "Num doc")]
        public int NumDoc { get; set; } // num_doc (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec doc")]
        public System.DateTime FecDoc { get; set; } // fec_doc (Primary key)

        [Required]
        [Display(Name = "Id cli")]
        public int IdCli { get; set; } // id_cli (Primary key)

        [Required]
        [Display(Name = "Id prov")]
        public int IdProv { get; set; } // id_prov (Primary key)

        [Required]
        [Display(Name = "Id impto")]
        public int IdImpto { get; set; } // id_impto (Primary key)

        [Required]
        [Display(Name = "Id cod imp")]
        public int IdCodImp { get; set; } // id_cod_imp (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (Primary key) (length: 30)

        [Required]
        [Display(Name = "Tasa")]
        public double Tasa { get; set; } // tasa (Primary key)

        [Required]
        [Display(Name = "C iva")]
        public byte CIva { get; set; } // c_iva (Primary key)

        [Required]
        [Display(Name = "C ret")]
        public byte CRet { get; set; } // c_ret (Primary key)

        [Required]
        [Display(Name = "C exe")]
        public byte CExe { get; set; } // c_exe (Primary key)

        [Required]
        [Display(Name = "Mto base")]
        public double MtoBase { get; set; } // mto_base (Primary key)

        [Required]
        [Display(Name = "Mto imp")]
        public double MtoImp { get; set; } // mto_imp (Primary key)

        [Required]
        [Display(Name = "Id mda")]
        public int IdMda { get; set; } // id_mda (Primary key)

        [Required]
        [Display(Name = "Oper")]
        public byte Oper { get; set; } // oper (Primary key)

        [Required]
        [Display(Name = "Tc")]
        public double Tc { get; set; } // tc (Primary key)

        [Required]
        [Display(Name = "Mto base bse")]
        public double MtoBaseBse { get; set; } // mto_base_bse (Primary key)

        [Required]
        [Display(Name = "Mto imp bse")]
        public double MtoImpBse { get; set; } // mto_imp_bse (Primary key)

        [Required]
        [Display(Name = "Id cta")]
        public int IdCta { get; set; } // id_cta (Primary key)

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg (Primary key)

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status (Primary key)

        [Required]
        [Display(Name = "C afe ctb")]
        public byte CAfeCtb { get; set; } // c_afe_ctb (Primary key)

        [Required]
        [Display(Name = "Dcto glb")]
        public double DctoGlb { get; set; } // dcto_glb (Primary key)

        [Required]
        [Display(Name = "Mto imp s dcto")]
        public double MtoImpSDcto { get; set; } // mto_imp_s_dcto (Primary key)

        [Required]
        [Display(Name = "Mto base s dcto")]
        public double MtoBaseSDcto { get; set; } // mto_base_s_dcto (Primary key)

        [Required]
        [Display(Name = "Id rel imp doc")]
        public int IdRelImpDoc { get; set; } // id_rel_imp_doc (Primary key)

        [Required]
        [Display(Name = "C mod imptos")]
        public byte CModImptos { get; set; } // c_mod_imptos (Primary key)

        [Required]
        [Display(Name = "Iva apl")]
        public double IvaApl { get; set; } // iva_apl (Primary key)

        [Required]
        [Display(Name = "Iva sdo")]
        public double IvaSdo { get; set; } // iva_sdo (Primary key)

        [Required]
        [Display(Name = "Mto pag ret")]
        public double MtoPagRet { get; set; } // mto_pag_ret (Primary key)

        [Required]
        [Display(Name = "Mto acr ret")]
        public double MtoAcrRet { get; set; } // mto_acr_ret (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec pgo")]
        public System.DateTime FecPgo { get; set; } // fec_pgo (Primary key)

        [Required]
        [Display(Name = "Id bco aux")]
        public int IdBcoAux { get; set; } // id_bco_aux (Primary key)

        [Required]
        [Display(Name = "Id cli fa")]
        public int IdCliFa { get; set; } // id_cli_fa (Primary key)

        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "No fact")]
        public string NoFact { get; set; } // no_fact (length: 40)

        [Required]
        [Display(Name = "C rec iva")]
        public byte CRecIva { get; set; } // c_rec_iva (Primary key)

        [Required]
        [Display(Name = "Id fis rel")]
        public int IdFisRel { get; set; } // id_fis_rel (Primary key)

        [Required]
        [Display(Name = "Id cen cto")]
        public int IdCenCto { get; set; } // id_cen_cto (Primary key)

        [Required]
        [Display(Name = "Id ref")]
        public int IdRef { get; set; } // id_ref (Primary key)

        [Required]
        [Display(Name = "Id cod srv")]
        public int IdCodSrv { get; set; } // id_cod_srv (Primary key)

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro (Primary key)

        [Required]
        [Display(Name = "Id alm")]
        public int IdAlm { get; set; } // id_alm (Primary key)

        [Required]
        [Display(Name = "Id ent")]
        public int IdEnt { get; set; } // id_ent (Primary key)
    }

}
// </auto-generated>
