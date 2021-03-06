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

    // vta_fac_enc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaFacEnc
    {
        [Required]
        [Display(Name = "Id fac")]
        public int IdFac { get; set; } // id_fac (Primary key)

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [Display(Name = "Id cli")]
        public int IdCli { get; set; } // id_cli

        [Required]
        [Display(Name = "Id tipo doc")]
        public int IdTipoDoc { get; set; } // id_tipo_doc

        [Required]
        [Display(Name = "Numero")]
        public int Numero { get; set; } // numero

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha")]
        public System.DateTime Fecha { get; set; } // fecha

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
        [Display(Name = "Dcto")]
        public double Dcto { get; set; } // dcto

        [Required]
        [Display(Name = "Dcto mto")]
        public double DctoMto { get; set; } // dcto_mto

        [Required]
        [Display(Name = "Id suc")]
        public int IdSuc { get; set; } // id_suc

        ///<summary>
        /// 1=Abiertal 3=Cancelada 2=Cerrada 4 = Pendiente 5=Eliminada
        ///</summary>
        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Display(Name = "Dias")]
        public int? Dias { get; set; } // dias

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha venc")]
        public System.DateTime FechaVenc { get; set; } // fecha_venc

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required]
        [Display(Name = "Id proy")]
        public int IdProy { get; set; } // id_proy

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Ref")]
        public string @Ref { get; set; } // ref (length: 50)

        [Required]
        [Display(Name = "Id vend")]
        public int IdVend { get; set; } // id_vend

        [Required]
        [Display(Name = "Ptg com")]
        public double PtgCom { get; set; } // ptg_com

        ///<summary>
        /// Monto de la Comisión Total
        ///</summary>
        [Required]
        [Display(Name = "Com monto")]
        public double ComMonto { get; set; } // com_monto

        ///<summary>
        /// Monto que se ha pagado de la comisión
        ///</summary>
        [Required]
        [Display(Name = "Com pag mto")]
        public double ComPagMto { get; set; } // com_pag_mto

        ///<summary>
        /// 1=Sobre Factura Pagada, 2=Factura Emitida
        ///</summary>
        [Required]
        [Display(Name = "Tipo com")]
        public byte TipoCom { get; set; } // tipo_com

        ///<summary>
        /// 1=Factura de Notas 2=Factura directa
        ///</summary>
        [Required]
        [Display(Name = "Tipo fac")]
        public byte TipoFac { get; set; } // tipo_fac

        [Required]
        [Display(Name = "Id mda")]
        public int IdMda { get; set; } // id_mda

        [Required]
        [Display(Name = "Tip cam")]
        public double TipCam { get; set; } // tip_cam

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
        [Display(Name = "Dcto mto bse")]
        public double DctoMtoBse { get; set; } // dcto_mto_bse

        [Required]
        [Display(Name = "Id lab")]
        public int IdLab { get; set; } // id_lab

        [Required]
        [Display(Name = "Id med env 1")]
        public int IdMedEnv1 { get; set; } // id_med_env1

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "No guia 1")]
        public string NoGuia1 { get; set; } // no_guia1 (length: 25)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec guia 1")]
        public System.DateTime FecGuia1 { get; set; } // fec_guia1

        [Required]
        [Display(Name = "Id med env 2")]
        public int IdMedEnv2 { get; set; } // id_med_env2

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "No guia 2")]
        public string NoGuia2 { get; set; } // no_guia2 (length: 25)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec guia 2")]
        public System.DateTime FecGuia2 { get; set; } // fec_guia2

        ///<summary>
        /// Fecha de Entrega
        ///</summary>
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ent")]
        public System.DateTime FecEnt { get; set; } // fec_ent

        ///<summary>
        /// Id del empleado que realizo el movimiento
        ///</summary>
        [Required]
        [Display(Name = "Id emp realizo")]
        public int IdEmpRealizo { get; set; } // id_emp_realizo

        ///<summary>
        /// id del empleado que lo autorizó
        ///</summary>
        [Required]
        [Display(Name = "Id emp aut")]
        public int IdEmpAut { get; set; } // id_emp_aut

        ///<summary>
        /// 1=Surtido Completamente 0=No Surtido Completamente
        ///</summary>
        [Required]
        [Display(Name = "C surt")]
        public byte CSurt { get; set; } // c_surt

        [Required]
        [Display(Name = "Prioridad")]
        public byte Prioridad { get; set; } // prioridad

        [Required]
        [Display(Name = "Id sis edo act")]
        public int IdSisEdoAct { get; set; } // id_sis_edo_act

        [MaxLength(512)]
        [StringLength(512)]
        [Display(Name = "Falla")]
        public string Falla { get; set; } // falla (length: 512)

        [Required]
        [Display(Name = "Id cpt")]
        public int IdCpt { get; set; } // id_cpt

        [Required]
        [Display(Name = "Id cnd")]
        public int IdCnd { get; set; } // id_cnd

        [Required]
        [Display(Name = "Id cli pad")]
        public int IdCliPad { get; set; } // id_cli_pad

        [Required]
        [Display(Name = "Id clas cli")]
        public int IdClasCli { get; set; } // id_clas_cli

        [Required]
        [Display(Name = "Id cli fa")]
        public int IdCliFa { get; set; } // id_cli_fa

        [Required]
        [Display(Name = "Id cli da")]
        public int IdCliDa { get; set; } // id_cli_da

        [Required]
        [Display(Name = "Id cto")]
        public int IdCto { get; set; } // id_cto

        [Required]
        [Display(Name = "Id rel imp doc")]
        public int IdRelImpDoc { get; set; } // id_rel_imp_doc

        [Required]
        [Display(Name = "Id pol")]
        public int IdPol { get; set; } // id_pol

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Serie")]
        public string Serie { get; set; } // serie (length: 10)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "C dis")]
        public byte CDis { get; set; } // c_dis

        [Required]
        [Display(Name = "Dis")]
        public int Dis { get; set; } // dis

        [Required]
        [Display(Name = "Ptg dis")]
        public double PtgDis { get; set; } // ptg_dis

        [Required]
        [Display(Name = "Id fac sust")]
        public int IdFacSust { get; set; } // id_fac_sust

        [Required]
        [Display(Name = "Id nota sust")]
        public int IdNotaSust { get; set; } // id_nota_sust

        [Required]
        [Display(Name = "Id tip vta")]
        public int IdTipVta { get; set; } // Id_Tip_Vta

        [Required]
        [Display(Name = "Mto ant")]
        public double MtoAnt { get; set; } // mto_ant

        [Required]
        [Display(Name = "Sdo ant")]
        public double SdoAnt { get; set; } // sdo_ant

        [Required]
        [Display(Name = "Mto apl")]
        public double MtoApl { get; set; } // mto_apl

        [Required]
        [Display(Name = "Sdo apl")]
        public double SdoApl { get; set; } // sdo_apl

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec est cob")]
        public System.DateTime FecEstCob { get; set; } // fec_est_cob

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec rev")]
        public System.DateTime FecRev { get; set; } // fec_rev

        [Required]
        [Display(Name = "Status prc")]
        public byte StatusPrc { get; set; } // status_prc

        [Required]
        [Display(Name = "Id cli da mer")]
        public int IdCliDaMer { get; set; } // id_cli_da_mer

        ///<summary>
        /// 0=No es NC, 1=Cancelación, 2=Devolución, 3=Bonificación
        ///</summary>
        [Required]
        [Display(Name = "Tip nc")]
        public byte TipNc { get; set; } // tip_nc

        [Required]
        [Display(Name = "C comp")]
        public byte CComp { get; set; } // c_comp

        [Required]
        [Display(Name = "Status surt")]
        public byte StatusSurt { get; set; } // status_surt

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ult mod")]
        public System.DateTime FecUltMod { get; set; } // fec_ult_mod

        [Required]
        [Display(Name = "C imp ley")]
        public byte CImpLey { get; set; } // c_imp_ley

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Leyenda")]
        public string Leyenda { get; set; } // leyenda (length: 50)

        [Required]
        [Display(Name = "Id aut")]
        public int IdAut { get; set; } // id_aut

        [Required]
        [Display(Name = "Deducible")]
        public double Deducible { get; set; } // deducible

        [Required]
        [Display(Name = "Coaseguro")]
        public double Coaseguro { get; set; } // coaseguro

        [Required]
        [Display(Name = "Cargos no cub")]
        public double CargosNoCub { get; set; } // cargos_no_cub

        [Required]
        [Display(Name = "Descuento 1")]
        public double Descuento1 { get; set; } // descuento1

        [Required]
        [Display(Name = "Descuento 2")]
        public double Descuento2 { get; set; } // descuento2

        [Required]
        [Display(Name = "Honorarios medicos")]
        public double HonorariosMedicos { get; set; } // honorarios_medicos

        [Required]
        [Display(Name = "Nc afe doc pad")]
        public int NcAfeDocPad { get; set; } // nc_afe_doc_pad

        [Required]
        [Display(Name = "Id tip uso")]
        public int IdTipUso { get; set; } // id_tip_uso

        [Required]
        [Display(Name = "Id operador")]
        public int IdOperador { get; set; } // id_operador

        [Required]
        [Display(Name = "Id equipo")]
        public int IdEquipo { get; set; } // id_equipo

        [Required]
        [Display(Name = "Id porteador")]
        public int IdPorteador { get; set; } // id_porteador

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec recoleccion")]
        public System.DateTime FecRecoleccion { get; set; } // fec_recoleccion

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec prometida")]
        public System.DateTime FecPrometida { get; set; } // fec_prometida

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ent real")]
        public System.DateTime FecEntReal { get; set; } // fec_ent_real

        [Required]
        [Display(Name = "Id caja")]
        public int IdCaja { get; set; } // id_caja

        // Reverse navigation

        /// <summary>
        /// Child VtaFacDets where [vta_fac_det].[id_fac] point to this entity (FK_vta_fac_det_vta_fac_enc)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<VtaFacDet> VtaFacDets { get; set; } // vta_fac_det.FK_vta_fac_det_vta_fac_enc
        /// <summary>
        /// Child VtaMovDocs where [vta_mov_doc].[id_fact] point to this entity (FK_vta_mov_doc_vta_fac_enc)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<VtaMovDoc> VtaMovDocs { get; set; } // vta_mov_doc.FK_vta_mov_doc_vta_fac_enc
        /// <summary>
        /// Parent (One-to-One) VtaFacEnc pointed by [vta_fac_enc_clie].[id_fact] (FK_vta_fac_enc_clie_vta_fac_enc)
        /// </summary>
        public virtual VtaFacEncClie VtaFacEncClie { get; set; } // vta_fac_enc_clie.FK_vta_fac_enc_clie_vta_fac_enc

        // Foreign keys

        /// <summary>
        /// Parent CatCliente pointed by [vta_fac_enc].([IdCli]) (FK_vta_fac_enc_cat_clientes)
        /// </summary>
        public virtual CatCliente CatCliente { get; set; } // FK_vta_fac_enc_cat_clientes

        /// <summary>
        /// Parent CatUsr pointed by [vta_fac_enc].([IdUsr]) (FK_vta_fac_enc_cat_usr)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_vta_fac_enc_cat_usr

        /// <summary>
        /// Parent SisCto pointed by [vta_fac_enc].([IdCto]) (FK_vta_fac_enc_sis_cto)
        /// </summary>
        public virtual SisCto SisCto { get; set; } // FK_vta_fac_enc_sis_cto

        public VtaFacEnc()
        {
            Status = 1;
            Dias = 0;
            IdNota = 0;
            IdProy = 0;
            @Ref = "";
            IdVend = 0;
            PtgCom = 0;
            ComMonto = 0;
            ComPagMto = 0;
            TipoCom = 1;
            TipoFac = 1;
            IdMda = 0;
            TipCam = 0;
            Oper = 0;
            SubBse = 0;
            ImptosBse = 0;
            TotalBse = 0;
            SaldoBse = 0;
            DctoMtoBse = 0;
            IdLab = 0;
            IdMedEnv1 = 0;
            NoGuia1 = "";
            IdMedEnv2 = 0;
            NoGuia2 = "";
            IdEmpRealizo = 0;
            IdEmpAut = 0;
            CSurt = 0;
            Prioridad = 0;
            IdSisEdoAct = 0;
            Falla = "";
            IdCpt = 0;
            IdCnd = 0;
            IdCliPad = 0;
            IdClasCli = 0;
            IdCliFa = 0;
            IdCliDa = 0;
            IdCto = 0;
            IdRelImpDoc = 0;
            IdPol = 0;
            Serie = "0";
            CDis = 0;
            Dis = 0;
            PtgDis = 0;
            IdFacSust = 0;
            IdNotaSust = 0;
            IdTipVta = 0;
            MtoAnt = 0;
            SdoAnt = 0;
            MtoApl = 0;
            SdoApl = 0;
            StatusPrc = 0;
            IdCliDaMer = 0;
            TipNc = 0;
            CComp = 0;
            StatusSurt = 99;
            CImpLey = 0;
            Leyenda = "";
            IdAut = 0;
            Deducible = 0;
            Coaseguro = 0;
            CargosNoCub = 0;
            Descuento1 = 0;
            Descuento2 = 0;
            HonorariosMedicos = 0;
            NcAfeDocPad = 0;
            IdTipUso = 0;
            IdOperador = 0;
            IdEquipo = 0;
            IdPorteador = 0;
            IdCaja = 0;
            VtaFacDets = new System.Collections.Generic.List<VtaFacDet>();
            VtaMovDocs = new System.Collections.Generic.List<VtaMovDoc>();
        }
    }

}
// </auto-generated>
