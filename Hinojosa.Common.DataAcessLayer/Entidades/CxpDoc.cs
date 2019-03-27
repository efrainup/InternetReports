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

    // cxp_doc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CxpDoc
    {
        [Required]
        [Display(Name = "Id cxp doc")]
        public int IdCxpDoc { get; set; } // id_cxp_doc (Primary key)

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc

        [Required]
        [Display(Name = "Id prov")]
        public int IdProv { get; set; } // id_prov

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [Display(Name = "Id suc")]
        public int IdSuc { get; set; } // id_suc

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required]
        [Display(Name = "Num doc")]
        public int NumDoc { get; set; } // num_doc

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Referencia")]
        public string Referencia { get; set; } // referencia (length: 50)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec doc")]
        public System.DateTime FecDoc { get; set; } // fec_doc

        [Required]
        [Display(Name = "Dias")]
        public int Dias { get; set; } // dias

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec venc")]
        public System.DateTime FecVenc { get; set; } // fec_venc

        [Required]
        [Display(Name = "Dcto ptg")]
        public double DctoPtg { get; set; } // dcto_ptg

        [Required]
        [Display(Name = "Mto dcto")]
        public double MtoDcto { get; set; } // mto_dcto

        [Required]
        [Display(Name = "Imp doc")]
        public double ImpDoc { get; set; } // imp_doc

        [Required]
        [Display(Name = "Cargos misc")]
        public double CargosMisc { get; set; } // cargos_misc

        [Required]
        [Display(Name = "Flete")]
        public double Flete { get; set; } // flete

        [Required]
        [Display(Name = "Iva flete")]
        public double IvaFlete { get; set; } // iva_flete

        [Required]
        [Display(Name = "Flete ret")]
        public double FleteRet { get; set; } // flete_ret

        [Required]
        [Display(Name = "Ptg ret fle")]
        public double PtgRetFle { get; set; } // ptg_ret_fle

        [Required]
        [Display(Name = "Isr ret")]
        public double IsrRet { get; set; } // isr_ret

        [Required]
        [Display(Name = "Ptg isr ret")]
        public double PtgIsrRet { get; set; } // ptg_isr_ret

        [Required]
        [Display(Name = "Imptos")]
        public double Imptos { get; set; } // imptos

        [Required]
        [Display(Name = "Total")]
        public double Total { get; set; } // total

        [Required]
        [Display(Name = "Saldo")]
        public double Saldo { get; set; } // saldo

        ///<summary>
        /// 1=Abierto 2=Cerrado 3=cancelado 4=pendiente
        ///</summary>
        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [Display(Name = "Id proy")]
        public int IdProy { get; set; } // id_proy

        [Required]
        [Display(Name = "Id ent")]
        public int IdEnt { get; set; } // id_ent

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
        [Display(Name = "Mto dcto bse")]
        public double MtoDctoBse { get; set; } // mto_dcto_bse

        [Required]
        [Display(Name = "Imp doc bse")]
        public double ImpDocBse { get; set; } // imp_doc_bse

        [Required]
        [Display(Name = "Cargos misc bse")]
        public double CargosMiscBse { get; set; } // cargos_misc_bse

        [Required]
        [Display(Name = "Flete bse")]
        public double FleteBse { get; set; } // flete_bse

        [Required]
        [Display(Name = "Iva flete bse")]
        public double IvaFleteBse { get; set; } // iva_flete_bse

        [Required]
        [Display(Name = "Flete ret bse")]
        public double FleteRetBse { get; set; } // flete_ret_bse

        [Required]
        [Display(Name = "Isr ret bse")]
        public double IsrRetBse { get; set; } // isr_ret_bse

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
        [Display(Name = "Ptg iva ret")]
        public double PtgIvaRet { get; set; } // ptg_iva_ret

        [Required]
        [Display(Name = "Iva ret")]
        public double IvaRet { get; set; } // iva_ret

        [Required]
        [Display(Name = "Ptg ieps")]
        public double PtgIeps { get; set; } // ptg_ieps

        [Required]
        [Display(Name = "Ieps")]
        public double Ieps { get; set; } // ieps

        [Required]
        [Display(Name = "Iva ret bse")]
        public double IvaRetBse { get; set; } // iva_ret_bse

        [Required]
        [Display(Name = "Ieps bse")]
        public double IepsBse { get; set; } // ieps_bse

        ///<summary>
        /// Número de Factura
        ///</summary>
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "No fact")]
        public string NoFact { get; set; } // no_fact (length: 40)

        [Required]
        [Display(Name = "Id cpt")]
        public int IdCpt { get; set; } // id_cpt

        [Required]
        [Display(Name = "Id cnd")]
        public int IdCnd { get; set; } // id_cnd

        [Required]
        [Display(Name = "Id prov pad")]
        public int IdProvPad { get; set; } // id_prov_pad

        [Required]
        [Display(Name = "Id pol")]
        public int IdPol { get; set; } // id_pol

        ///<summary>
        /// clasificacion contable del proveedor
        ///</summary>
        [Required]
        [Display(Name = "Id clas prov")]
        public int IdClasProv { get; set; } // id_clas_prov

        [Required]
        [Display(Name = "Id rel imp doc")]
        public int IdRelImpDoc { get; set; } // id_rel_imp_doc

        [Required]
        [Display(Name = "Id prov fis")]
        public int IdProvFis { get; set; } // id_prov_fis

        [Required]
        [Display(Name = "Id cli cta de")]
        public int IdCliCtaDe { get; set; } // id_cli_cta_de

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec rec")]
        public System.DateTime FecRec { get; set; } // fec_rec

        [Required]
        [Display(Name = "Tip venc")]
        public int TipVenc { get; set; } // tip_venc

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec est cob")]
        public System.DateTime FecEstCob { get; set; } // fec_est_cob

        ///<summary>
        /// 0=No es NC, 1=Cancelación, 2=Devolución, 3=Bonificación
        ///</summary>
        [Required]
        [Display(Name = "Tip nc")]
        public byte TipNc { get; set; } // tip_nc

        [Required]
        [Display(Name = "Id reg nom")]
        public int IdRegNom { get; set; } // id_reg_nom

        [Required]
        [Display(Name = "Id per apl")]
        public int IdPerApl { get; set; } // id_per_apl

        [Required]
        [Display(Name = "C desde cfd")]
        public byte CDesdeCfd { get; set; } // c_desde_cfd

        [Required(AllowEmptyStrings = true)]
        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Archivo xml")]
        public string ArchivoXml { get; set; } // archivo_xml (length: 200)

        [Required]
        [Display(Name = "Descto xml")]
        public double DesctoXml { get; set; } // descto_xml

        [Required]
        [Display(Name = "Subtotal xml")]
        public double SubtotalXml { get; set; } // subtotal_xml

        [Required]
        [Display(Name = "Imptos xml")]
        public double ImptosXml { get; set; } // imptos_xml

        [Required]
        [Display(Name = "Total xml")]
        public double TotalXml { get; set; } // total_xml

        [Required]
        [Display(Name = "Id tip pas")]
        public int IdTipPas { get; set; } // id_tip_pas

        [Required]
        [Display(Name = "C val xml")]
        public byte CValXml { get; set; } // c_val_xml

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec val xml")]
        public System.DateTime FecValXml { get; set; } // fec_val_xml

        [Required]
        [Display(Name = "Id usr val")]
        public int IdUsrVal { get; set; } // id_usr_val

        [Required(AllowEmptyStrings = true)]
        [MaxLength(36)]
        [StringLength(36)]
        [Display(Name = "Uuid")]
        public string Uuid { get; set; } // uuid (length: 36)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Status sat")]
        public string StatusSat { get; set; } // statusSAT (length: 20)

        [Required]
        [Display(Name = "Id rcn iva")]
        public int IdRcnIva { get; set; } // id_rcn_iva

        [Required]
        [Display(Name = "Id sesion")]
        public int IdSesion { get; set; } // id_sesion

        // Foreign keys

        /// <summary>
        /// Parent CatDocto pointed by [cxp_doc].([IdTipDoc]) (FK_cxp_doc_cat_doctos)
        /// </summary>
        public virtual CatDocto CatDocto { get; set; } // FK_cxp_doc_cat_doctos

        /// <summary>
        /// Parent CatUsr pointed by [cxp_doc].([IdUsr]) (FK_cxp_doc_cat_usr)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_cxp_doc_cat_usr

        public CxpDoc()
        {
            IdTipDoc = 0;
            IdProv = 0;
            IdUsr = 0;
            IdSuc = 0;
            IdNota = 0;
            NumDoc = 0;
            Referencia = "";
            Dias = 0;
            DctoPtg = 0;
            MtoDcto = 0;
            ImpDoc = 0;
            CargosMisc = 0;
            Flete = 0;
            IvaFlete = 0;
            FleteRet = 0;
            PtgRetFle = 0;
            IsrRet = 0;
            PtgIsrRet = 0;
            Imptos = 0;
            Total = 0;
            Saldo = 0;
            Status = 0;
            IdProy = 0;
            IdEnt = 0;
            IdMda = 0;
            Oper = 0;
            Tc = 0;
            MtoDctoBse = 0;
            ImpDocBse = 0;
            CargosMiscBse = 0;
            FleteBse = 0;
            IvaFleteBse = 0;
            FleteRetBse = 0;
            IsrRetBse = 0;
            ImptosBse = 0;
            TotalBse = 0;
            SaldoBse = 0;
            PtgIvaRet = 0;
            IvaRet = 0;
            PtgIeps = 0;
            Ieps = 0;
            IvaRetBse = 0;
            IepsBse = 0;
            NoFact = "0";
            IdCpt = 0;
            IdCnd = 0;
            IdProvPad = 0;
            IdPol = 0;
            IdClasProv = 0;
            IdRelImpDoc = 0;
            IdProvFis = 0;
            IdCliCtaDe = 0;
            TipVenc = 1;
            TipNc = 0;
            IdRegNom = 0;
            IdPerApl = 0;
            CDesdeCfd = 0;
            ArchivoXml = "";
            DesctoXml = 0;
            SubtotalXml = 0;
            ImptosXml = 0;
            TotalXml = 0;
            IdTipPas = 0;
            CValXml = 0;
            IdUsrVal = 0;
            Uuid = "";
            StatusSat = "";
            IdRcnIva = 0;
            IdSesion = 0;
        }
    }

}
// </auto-generated>