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

    // bco_doc_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class BcoDocDet
    {
        [Required]
        [Display(Name = "Id bco doc det")]
        public int IdBcoDocDet { get; set; } // id_bco_doc_det (Primary key)

        [Required]
        [Display(Name = "Id bco doc")]
        public int IdBcoDoc { get; set; } // id_bco_doc

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required]
        [Display(Name = "Id ent")]
        public int IdEnt { get; set; } // id_ent

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Ref")]
        public string @Ref { get; set; } // ref (length: 50)

        [Required]
        [Display(Name = "Importe")]
        public double Importe { get; set; } // importe

        [Required]
        [Display(Name = "Monto simpto")]
        public double MontoSimpto { get; set; } // monto_simpto

        [Required]
        [Display(Name = "Imptos")]
        public double Imptos { get; set; } // imptos

        [Required]
        [Display(Name = "Total")]
        public double Total { get; set; } // total

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
        [Display(Name = "Importe bse")]
        public double ImporteBse { get; set; } // importe_bse

        [Required]
        [Display(Name = "Monto simpto bse")]
        public double MontoSimptoBse { get; set; } // monto_simpto_bse

        [Required]
        [Display(Name = "Imptos bse")]
        public double ImptosBse { get; set; } // imptos_bse

        [Required]
        [Display(Name = "Total bse")]
        public double TotalBse { get; set; } // total_bse

        [Required]
        [Display(Name = "Id impto")]
        public int IdImpto { get; set; } // id_impto

        [Required]
        [Display(Name = "Id cen cto")]
        public int IdCenCto { get; set; } // id_cen_cto

        [Required]
        [Display(Name = "Id cod srv")]
        public int IdCodSrv { get; set; } // id_cod_srv

        [Required]
        [Display(Name = "Id ref")]
        public int IdRef { get; set; } // id_ref

        [Required]
        [Display(Name = "Id rel imp")]
        public int IdRelImp { get; set; } // id_rel_imp

        [Required]
        [Display(Name = "Id tip doc ref")]
        public int IdTipDocRef { get; set; } // id_tip_doc_ref

        [Required]
        [Display(Name = "Id cli prov")]
        public int IdCliProv { get; set; } // id_cli_prov

        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Num doc ref")]
        public string NumDocRef { get; set; } // num_doc_ref (length: 40)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha")]
        public System.DateTime Fecha { get; set; } // fecha

        [Required]
        [Display(Name = "Viaje")]
        public int Viaje { get; set; } // viaje

        [Required]
        [Display(Name = "Tip cli prov ref")]
        public int TipCliProvRef { get; set; } // tip_cli_prov_ref

        [Required]
        [Display(Name = "Id cli cta de")]
        public int IdCliCtaDe { get; set; } // id_cli_cta_de

        [Required]
        [Display(Name = "Id cli cxc")]
        public int IdCliCxc { get; set; } // id_cli_cxc

        [Required]
        [Display(Name = "Id cli fa")]
        public int IdCliFa { get; set; } // id_cli_fa

        [Required]
        [Display(Name = "C mod impto")]
        public byte CModImpto { get; set; } // c_mod_impto

        [Required]
        [Display(Name = "Id cli a cta de")]
        public int IdCliACtaDe { get; set; } // Id_Cli_A_Cta_De

        [Required]
        [Display(Name = "Cant")]
        public double Cant { get; set; } // cant

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro

        [Required]
        [Display(Name = "Pre cto")]
        public double PreCto { get; set; } // pre_cto

        [Required]
        [Display(Name = "Id udm")]
        public int IdUdm { get; set; } // id_udm

        [Required]
        [Display(Name = "Id alm")]
        public int IdAlm { get; set; } // id_alm

        [Required]
        [Display(Name = "Id ref det")]
        public int IdRefDet { get; set; } // id_ref_det

        [Required]
        [Display(Name = "Id int")]
        public int IdInt { get; set; } // id_int

        [Required]
        [Display(Name = "Id fis rel")]
        public int IdFisRel { get; set; } // id_fis_rel

        [Required(AllowEmptyStrings = true)]
        [MaxLength(64)]
        [StringLength(64)]
        [Display(Name = "Ref ext")]
        public string RefExt { get; set; } // ref_ext (length: 64)

        [Required]
        [Display(Name = "Id sis imp pag")]
        public int IdSisImpPag { get; set; } // id_sis_imp_pag

        [Required]
        [Display(Name = "Id ref det doc apl")]
        public int IdRefDetDocApl { get; set; } // id_ref_det_doc_apl

        [Required]
        [Display(Name = "Id bco trn det")]
        public int IdBcoTrnDet { get; set; } // id_bco_trn_det

        [Required]
        [Display(Name = "Id prov")]
        public int IdProv { get; set; } // id_prov

        [Required]
        [Display(Name = "Id cli")]
        public int IdCli { get; set; } // id_cli

        [Required]
        [Display(Name = "C impto")]
        public byte CImpto { get; set; } // c_impto

        [Required]
        [Display(Name = "Porfac")]
        public double Porfac { get; set; } // porfac

        [Required]
        [Display(Name = "Id cli aso")]
        public int IdCliAso { get; set; } // id_cli_aso

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

        [Required]
        [Display(Name = "Id cat viaje")]
        public int IdCatViaje { get; set; } // id_cat_viaje

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

        [Required(AllowEmptyStrings = true)]
        [MaxLength(36)]
        [StringLength(36)]
        [Display(Name = "Uuid")]
        public string Uuid { get; set; } // uuid (length: 36)

        [Required]
        [Display(Name = "Dcto ptg")]
        public double DctoPtg { get; set; } // dcto_ptg

        [Required]
        [Display(Name = "Monto descto")]
        public double MontoDescto { get; set; } // monto_descto

        [Required]
        [Display(Name = "Importe s dcto")]
        public double ImporteSDcto { get; set; } // importe_s_dcto

        [Required]
        [Display(Name = "C impto local")]
        public byte CImptoLocal { get; set; } // c_impto_local

        [Required]
        [Display(Name = "Impto loc ret")]
        public double ImptoLocRet { get; set; } // impto_loc_ret

        [Required]
        [Display(Name = "Impto loc tras")]
        public double ImptoLocTras { get; set; } // impto_loc_tras

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Status sat")]
        public string StatusSat { get; set; } // statusSAT (length: 20)

        // Foreign keys

        /// <summary>
        /// Parent BcoDoc pointed by [bco_doc_det].([IdBcoDoc]) (FK_bco_doc_det_bco_doc)
        /// </summary>
        public virtual BcoDoc BcoDoc { get; set; } // FK_bco_doc_det_bco_doc

        /// <summary>
        /// Parent MonMoneda pointed by [bco_doc_det].([IdMda]) (FK_bco_doc_det_mon_monedas)
        /// </summary>
        public virtual MonMoneda MonMoneda { get; set; } // FK_bco_doc_det_mon_monedas

        /// <summary>
        /// Parent SisNota pointed by [bco_doc_det].([IdNota]) (FK_bco_doc_det_sis_notas)
        /// </summary>
        public virtual SisNota SisNota { get; set; } // FK_bco_doc_det_sis_notas

        public BcoDocDet()
        {
            IdBcoDocDet = 0;
            IdBcoDoc = 0;
            @Ref = "";
            IdImpto = 0;
            IdCenCto = 0;
            IdCodSrv = 0;
            IdRef = 0;
            IdRelImp = 0;
            IdTipDocRef = 0;
            IdCliProv = 0;
            NumDocRef = "0";
            Viaje = 0;
            TipCliProvRef = 0;
            IdCliCtaDe = 0;
            IdCliCxc = 0;
            IdCliFa = 0;
            CModImpto = 0;
            IdCliACtaDe = 0;
            Cant = 0;
            IdPro = 0;
            PreCto = 0;
            IdUdm = 0;
            IdAlm = 0;
            IdRefDet = 0;
            IdInt = 0;
            IdFisRel = 0;
            RefExt = "";
            IdSisImpPag = 0;
            IdRefDetDocApl = 0;
            IdBcoTrnDet = 0;
            IdProv = 0;
            IdCli = 0;
            CImpto = 0;
            Porfac = 0;
            IdCliAso = 0;
            IdTipPas = 0;
            CValXml = 0;
            IdUsrVal = 0;
            IdCatViaje = 0;
            CDesdeCfd = 0;
            ArchivoXml = "";
            DesctoXml = 0;
            SubtotalXml = 0;
            ImptosXml = 0;
            TotalXml = 0;
            Uuid = "";
            DctoPtg = 0;
            MontoDescto = 0;
            ImporteSDcto = 0;
            CImptoLocal = 0;
            ImptoLocRet = 0;
            ImptoLocTras = 0;
            StatusSat = "";
        }
    }

}
// </auto-generated>
