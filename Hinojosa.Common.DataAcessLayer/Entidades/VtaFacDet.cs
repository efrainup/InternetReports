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

    // vta_fac_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaFacDet
    {
        [Required]
        [Display(Name = "Id fac det")]
        public int IdFacDet { get; set; } // id_fac_det (Primary key)

        [Required]
        [Display(Name = "Id fac")]
        public int IdFac { get; set; } // id_fac

        [Required]
        [Display(Name = "Id doc vta")]
        public int IdDocVta { get; set; } // id_doc_vta

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
        [Display(Name = "Id suc")]
        public int IdSuc { get; set; } // id_suc

        [Required]
        [Display(Name = "No part")]
        public int NoPart { get; set; } // no_part

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Udm")]
        public string Udm { get; set; } // udm (length: 10)

        [Required]
        [Display(Name = "Cant")]
        public double Cant { get; set; } // cant

        [Required]
        [Display(Name = "Precio orig")]
        public double PrecioOrig { get; set; } // precio_orig

        [Required]
        [Display(Name = "Promoc")]
        public double Promoc { get; set; } // promoc

        [Required]
        [Display(Name = "Precio pub")]
        public double PrecioPub { get; set; } // precio_pub

        [Required]
        [Display(Name = "Dcto ptg")]
        public double DctoPtg { get; set; } // dcto_ptg

        [Required]
        [Display(Name = "Precio cimptos")]
        public double PrecioCimptos { get; set; } // precio_cimptos

        [Required]
        [Display(Name = "Importe cimptos")]
        public double ImporteCimptos { get; set; } // importe_cimptos

        [Required]
        [Display(Name = "Precio pub simptos")]
        public double PrecioPubSimptos { get; set; } // precio_pub_simptos

        [Required]
        [Display(Name = "Precio simptos")]
        public double PrecioSimptos { get; set; } // precio_simptos

        [Required]
        [Display(Name = "Importe simptos")]
        public double ImporteSimptos { get; set; } // importe_simptos

        [Required]
        [Display(Name = "Montos imptos")]
        public double MontosImptos { get; set; } // montos_imptos

        [Required]
        [Display(Name = "Id impto")]
        public int IdImpto { get; set; } // id_impto

        [Required]
        [Display(Name = "C cambio prec")]
        public byte CCambioPrec { get; set; } // c_cambio_prec

        [Required]
        [Display(Name = "Costo")]
        public double Costo { get; set; } // costo

        [Required]
        [Display(Name = "Monto descto")]
        public double MontoDescto { get; set; } // monto_descto

        [Required]
        [Display(Name = "Costo total")]
        public double CostoTotal { get; set; } // costo_total

        [Required]
        [Display(Name = "Id almac")]
        public int IdAlmac { get; set; } // id_almac

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        ///<summary>
        /// 0=factura de una venta 1=Factura Directa
        ///</summary>
        [Required]
        [Display(Name = "Tipo")]
        public byte Tipo { get; set; } // tipo

        ///<summary>
        /// 1=Inventariable 2=No inventariable 3=kit
        ///</summary>
        [Required]
        [Display(Name = "Tipo pro")]
        public byte TipoPro { get; set; } // tipo_pro

        [Required]
        [Display(Name = "Es sub")]
        public byte EsSub { get; set; } // es_sub

        [Required]
        [Display(Name = "Cant dev")]
        public double CantDev { get; set; } // cant_dev

        ///<summary>
        /// por facturar o remisionar, por pedir
        ///</summary>
        [Required]
        [Display(Name = "Por facturar")]
        public double PorFacturar { get; set; } // por_facturar

        ///<summary>
        /// Id del Encabezado de la Remisión de la que se esta facturando
        ///</summary>
        [Required]
        [Display(Name = "Id rem")]
        public int IdRem { get; set; } // id_rem

        ///<summary>
        /// Id de la Partida de la Remisión de la que se está facturando
        ///</summary>
        [Required]
        [Display(Name = "Id rem part")]
        public int IdRemPart { get; set; } // id_rem_part

        [Required]
        [Display(Name = "Id fac det kit")]
        public int IdFacDetKit { get; set; } // id_fac_det_kit

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
        [Display(Name = "Precio orig bse")]
        public double PrecioOrigBse { get; set; } // precio_orig_bse

        [Required]
        [Display(Name = "Precio pub bse")]
        public double PrecioPubBse { get; set; } // precio_pub_bse

        [Required]
        [Display(Name = "Precio cimptos bse")]
        public double PrecioCimptosBse { get; set; } // precio_cimptos_bse

        [Required]
        [Display(Name = "Importe cimptos bse")]
        public double ImporteCimptosBse { get; set; } // importe_cimptos_bse

        [Required]
        [Display(Name = "Precio pub simptos bse")]
        public double PrecioPubSimptosBse { get; set; } // precio_pub_simptos_bse

        [Required]
        [Display(Name = "Precio simptos bse")]
        public double PrecioSimptosBse { get; set; } // precio_simptos_bse

        [Required]
        [Display(Name = "Importe simptos bse")]
        public double ImporteSimptosBse { get; set; } // importe_simptos_bse

        [Required]
        [Display(Name = "Monto imptos bse")]
        public double MontoImptosBse { get; set; } // monto_imptos_bse

        [Required]
        [Display(Name = "Monto descto bse")]
        public double MontoDesctoBse { get; set; } // monto_descto_bse

        [Required]
        [Display(Name = "Id com ser lot")]
        public int IdComSerLot { get; set; } // id_com_ser_lot

        ///<summary>
        /// Tiempo de entrega en dias
        ///</summary>
        [Required]
        [Display(Name = "Dias ent")]
        public int DiasEnt { get; set; } // dias_ent

        ///<summary>
        /// Fecha Prometida
        ///</summary>
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec prom")]
        public System.DateTime FecProm { get; set; } // fec_prom

        ///<summary>
        /// Fecha de ulitmo Embarque
        ///</summary>
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec emb")]
        public System.DateTime FecEmb { get; set; } // fec_emb

        ///<summary>
        /// Fecha Requerido el Producto en un pedido
        ///</summary>
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec req")]
        public System.DateTime FecReq { get; set; } // fec_req

        ///<summary>
        /// id con el programa de entregas
        ///</summary>
        [Required]
        [Display(Name = "Id prg ent fac det")]
        public int IdPrgEntFacDet { get; set; } // id_prg_ent_fac_det

        ///<summary>
        /// Cantidad Surtida
        ///</summary>
        [Required]
        [Display(Name = "Cant surt")]
        public double CantSurt { get; set; } // cant_surt

        ///<summary>
        /// Cantidad por Solicitar de un Pedido
        ///</summary>
        [Required]
        [Display(Name = "Por solic")]
        public double PorSolic { get; set; } // por_solic

        ///<summary>
        /// id de la partida padre (cotizacion,solicitud,pedido)
        ///</summary>
        [Required]
        [Display(Name = "Id part pad")]
        public int IdPartPad { get; set; } // id_part_pad

        ///<summary>
        /// id de la orden de producción
        ///</summary>
        [Required]
        [Display(Name = "Id pro ord")]
        public int IdProOrd { get; set; } // id_pro_ord

        ///<summary>
        /// Cantidad que se encuentra en ordenes de produccion
        ///</summary>
        [Required]
        [Display(Name = "Cant ord pro")]
        public double CantOrdPro { get; set; } // cant_ord_pro

        [Required]
        [Display(Name = "Id pro lis")]
        public int IdProLis { get; set; } // id_pro_lis

        [Required]
        [Display(Name = "Id lis pre")]
        public int IdLisPre { get; set; } // id_lis_pre

        [Required]
        [Display(Name = "C prec modif")]
        public int CPrecModif { get; set; } // c_prec_modif

        [Required]
        [Display(Name = "Id kardex")]
        public int IdKardex { get; set; } // id_kardex

        [Required]
        [Display(Name = "Id cod srv")]
        public int IdCodSrv { get; set; } // id_cod_srv

        [Required]
        [Display(Name = "Id cen cto")]
        public int IdCenCto { get; set; } // id_cen_cto

        [Required]
        [Display(Name = "Id ref")]
        public int IdRef { get; set; } // id_ref

        [Required]
        [Display(Name = "Id udm")]
        public int IdUdm { get; set; } // id_udm

        [Required]
        [Display(Name = "Ftr")]
        public double Ftr { get; set; } // ftr

        [Required]
        [Display(Name = "Id ped")]
        public int IdPed { get; set; } // id_ped

        [Required]
        [Display(Name = "Id ped part")]
        public int IdPedPart { get; set; } // id_ped_part

        [Required]
        [Display(Name = "Num ped")]
        public int NumPed { get; set; } // num_ped

        [Required]
        [Display(Name = "Id cot")]
        public int IdCot { get; set; } // id_cot

        [Required]
        [Display(Name = "Id cot part")]
        public int IdCotPart { get; set; } // id_cot_part

        [Required]
        [Display(Name = "Num cot")]
        public int NumCot { get; set; } // num_cot

        [Required]
        [Display(Name = "Id spt")]
        public int IdSpt { get; set; } // id_spt

        [Required]
        [Display(Name = "Id spt part")]
        public int IdSptPart { get; set; } // id_spt_part

        [Required]
        [Display(Name = "Num spt")]
        public int NumSpt { get; set; } // num_spt

        [Required]
        [Display(Name = "Id pad")]
        public int IdPad { get; set; } // id_pad

        [Required]
        [Display(Name = "Id tip doc pad")]
        public int IdTipDocPad { get; set; } // id_tip_doc_pad

        [Required]
        [Display(Name = "Num pad")]
        public int NumPad { get; set; } // num_pad

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Num ped cli")]
        public string NumPedCli { get; set; } // num_ped_cli (length: 25)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Num req cli")]
        public string NumReqCli { get; set; } // num_req_cli (length: 25)

        [Required]
        [Display(Name = "Id clas pro")]
        public int IdClasPro { get; set; } // id_clas_pro

        [Required]
        [Display(Name = "Id rel impto")]
        public int IdRelImpto { get; set; } // id_rel_impto

        [Required]
        [Display(Name = "Num rem")]
        public int NumRem { get; set; } // num_rem

        ///<summary>
        /// id de activo fijo
        ///</summary>
        [Required]
        [Display(Name = "Id act")]
        public int IdAct { get; set; } // id_act

        ///<summary>
        /// id de la clasificacion del activo
        ///</summary>
        [Required]
        [Display(Name = "Id clas act")]
        public int IdClasAct { get; set; } // id_clas_act

        [Required]
        [Display(Name = "Valor base")]
        public double ValorBase { get; set; } // valor_base

        [Required]
        [Display(Name = "Dep acu")]
        public double DepAcu { get; set; } // dep_acu

        [Required]
        [Display(Name = "Dep rem")]
        public double DepRem { get; set; } // dep_rem

        [Required]
        [Display(Name = "Campo 1")]
        public int Campo1 { get; set; } // campo1

        [Required]
        [Display(Name = "Campo 2")]
        public int Campo2 { get; set; } // campo2

        [Required]
        [Display(Name = "Campo 3")]
        public int Campo3 { get; set; } // campo3

        [Display(Name = "Campo 4")]
        public double? Campo4 { get; set; } // campo4

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Campo 5")]
        public string Campo5 { get; set; } // campo5 (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Campo 6")]
        public string Campo6 { get; set; } // campo6 (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Campo 7")]
        public string Campo7 { get; set; } // campo7 (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Campo 8")]
        public string Campo8 { get; set; } // campo8 (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Campo 9")]
        public string Campo9 { get; set; } // campo9 (length: 50)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Campo 10")]
        public System.DateTime Campo10 { get; set; } // campo10

        [Required]
        [Display(Name = "C prg")]
        public byte CPrg { get; set; } // c_prg

        [Required]
        [Display(Name = "Id pro paq")]
        public int IdProPaq { get; set; } // id_pro_paq

        [Required]
        [Display(Name = "Id part ori")]
        public int IdPartOri { get; set; } // id_part_ori

        [Required]
        [Display(Name = "Sec")]
        public int Sec { get; set; } // sec

        [Required]
        [Display(Name = "Id int")]
        public int IdInt { get; set; } // id_int

        [Required]
        [Display(Name = "Id cli cta de")]
        public int IdCliCtaDe { get; set; } // id_cli_cta_de

        [Required]
        [Display(Name = "Id ref det")]
        public int IdRefDet { get; set; } // id_ref_det

        [Required]
        [Display(Name = "Ptg kit")]
        public double PtgKit { get; set; } // ptg_kit

        [Required(AllowEmptyStrings = true)]
        [MaxLength(64)]
        [StringLength(64)]
        [Display(Name = "Ref ext")]
        public string RefExt { get; set; } // ref_ext (length: 64)

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
        [Display(Name = "Mod impto")]
        public byte ModImpto { get; set; } // mod_impto

        [Required]
        [Display(Name = "Precio ext")]
        public double PrecioExt { get; set; } // precio_ext

        [Required]
        [Display(Name = "Campo 11")]
        public int Campo11 { get; set; } // Campo11

        [Required]
        [Display(Name = "Campo 12")]
        public int Campo12 { get; set; } // Campo12

        [Required]
        [Display(Name = "Campo 13")]
        public int Campo13 { get; set; } // Campo13

        [Required]
        [Display(Name = "Campo 14")]
        public int Campo14 { get; set; } // Campo14

        [Required]
        [Display(Name = "Campo 15")]
        public int Campo15 { get; set; } // Campo15

        [Required]
        [Display(Name = "Campo 16")]
        public int Campo16 { get; set; } // Campo16

        [Required]
        [Display(Name = "Campo 17")]
        public double Campo17 { get; set; } // Campo17

        [Required]
        [Display(Name = "Campo 18")]
        public double Campo18 { get; set; } // Campo18

        [Required]
        [Display(Name = "Campo 19")]
        public double Campo19 { get; set; } // Campo19

        [Required]
        [Display(Name = "Campo 20")]
        public double Campo20 { get; set; } // Campo20

        [Required]
        [Display(Name = "Campo 21")]
        public double Campo21 { get; set; } // Campo21

        [Required]
        [Display(Name = "Campo 22")]
        public double Campo22 { get; set; } // Campo22

        [Required]
        [Display(Name = "Campo 23")]
        public double Campo23 { get; set; } // Campo23

        [Required]
        [Display(Name = "Campo 24")]
        public double Campo24 { get; set; } // Campo24

        [Required]
        [Display(Name = "Campo 25")]
        public double Campo25 { get; set; } // Campo25

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Campo 26")]
        public System.DateTime Campo26 { get; set; } // Campo26

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Campo 27")]
        public System.DateTime Campo27 { get; set; } // Campo27

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Campo 28")]
        public System.DateTime Campo28 { get; set; } // Campo28

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Campo 29")]
        public System.DateTime Campo29 { get; set; } // Campo29

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Campo 30")]
        public string Campo30 { get; set; } // Campo30 (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Campo 31")]
        public string Campo31 { get; set; } // Campo31 (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Campo 32")]
        public string Campo32 { get; set; } // Campo32 (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Campo 33")]
        public string Campo33 { get; set; } // Campo33 (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Campo 34")]
        public string Campo34 { get; set; } // Campo34 (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Campo 35")]
        public string Campo35 { get; set; } // Campo35 (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Campo 36")]
        public string Campo36 { get; set; } // Campo36 (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Campo 37")]
        public string Campo37 { get; set; } // Campo37 (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Campo 38")]
        public string Campo38 { get; set; } // Campo38 (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Campo 39")]
        public string Campo39 { get; set; } // Campo39 (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Campo 40")]
        public string Campo40 { get; set; } // Campo40 (length: 50)

        [Required]
        [Display(Name = "Id nota 2")]
        public int IdNota2 { get; set; } // id_Nota2

        [Required]
        [Display(Name = "Id nota 3")]
        public int IdNota3 { get; set; } // id_Nota3

        [Required]
        [Display(Name = "Tip com")]
        public byte TipCom { get; set; } // tip_com

        [Required]
        [Display(Name = "Ptg com")]
        public double PtgCom { get; set; } // ptg_com

        [Required]
        [Display(Name = "Mto com")]
        public double MtoCom { get; set; } // mto_com

        [Required]
        [Display(Name = "Id sis lis pre")]
        public int IdSisLisPre { get; set; } // id_sis_lis_pre

        [Required]
        [Display(Name = "Id tar hon")]
        public int IdTarHon { get; set; } // id_tar_hon

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Des tar hon")]
        public string DesTarHon { get; set; } // des_tar_hon (length: 50)

        [Required]
        [Display(Name = "Id fis rel")]
        public int IdFisRel { get; set; } // id_fis_rel

        [Required]
        [Display(Name = "Id ope ext")]
        public int IdOpeExt { get; set; } // id_ope_ext

        [Required]
        [Display(Name = "Id part alm sir")]
        public int IdPartAlmSir { get; set; } // id_part_alm_sir

        [Required]
        [Display(Name = "Dias alm sir")]
        public double DiasAlmSir { get; set; } // dias_alm_sir

        [Required]
        [Display(Name = "Dias lib alm sir")]
        public double DiasLibAlmSir { get; set; } // dias_lib_alm_sir

        [Required]
        [Display(Name = "Dias dcto alm sir")]
        public double DiasDctoAlmSir { get; set; } // dias_dcto_alm_sir

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec corte alm sir")]
        public System.DateTime FecCorteAlmSir { get; set; } // fec_corte_alm_sir

        [Required]
        [Display(Name = "Id almje gral")]
        public int IdAlmjeGral { get; set; } // id_almje_gral

        [Required]
        [Display(Name = "Id almje esp")]
        public int IdAlmjeEsp { get; set; } // id_almje_esp

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Cmt")]
        public string Cmt { get; set; } // cmt (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Des hon")]
        public string DesHon { get; set; } // des_hon (length: 50)

        [MaxLength(254)]
        [StringLength(254)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (length: 254)

        [Required]
        [Display(Name = "C afe exis vta")]
        public int CAfeExisVta { get; set; } // c_afe_exis_vta

        [Required]
        [Display(Name = "Id com")]
        public int IdCom { get; set; } // id_com

        [Required]
        [Display(Name = "Num grp")]
        public int NumGrp { get; set; } // num_grp

        [Required]
        [Display(Name = "Cant surt aut")]
        public double CantSurtAut { get; set; } // cant_surt_aut

        [Required]
        [Display(Name = "Apartado")]
        public double Apartado { get; set; } // apartado

        [Required]
        [Display(Name = "Backorder")]
        public double Backorder { get; set; } // backorder

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ped cli")]
        public System.DateTime FecPedCli { get; set; } // fec_ped_cli

        [Required]
        [Display(Name = "Aum ptg")]
        public double AumPtg { get; set; } // aum_ptg

        [Required]
        [Display(Name = "Cant trasp")]
        public double CantTrasp { get; set; } // cant_trasp

        [Required]
        [Display(Name = "Partcerrpedcot")]
        public byte Partcerrpedcot { get; set; } // partcerrpedcot

        // Reverse navigation

        /// <summary>
        /// Child VtaFacDetKits where [vta_fac_det_kit].[id_fac_det] point to this entity (FK_vta_fac_det_kit_vta_fac_det)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<VtaFacDetKit> VtaFacDetKits { get; set; } // vta_fac_det_kit.FK_vta_fac_det_kit_vta_fac_det

        // Foreign keys

        /// <summary>
        /// Parent CatAlmac pointed by [vta_fac_det].([IdAlmac]) (FK_vta_fac_det_cat_almac)
        /// </summary>
        public virtual CatAlmac CatAlmac { get; set; } // FK_vta_fac_det_cat_almac

        /// <summary>
        /// Parent CatPro pointed by [vta_fac_det].([IdPro]) (FK_vta_fac_det_cat_pro)
        /// </summary>
        public virtual CatPro CatPro { get; set; } // FK_vta_fac_det_cat_pro

        /// <summary>
        /// Parent VtaFacEnc pointed by [vta_fac_det].([IdFac]) (FK_vta_fac_det_vta_fac_enc)
        /// </summary>
        public virtual VtaFacEnc VtaFacEnc { get; set; } // FK_vta_fac_det_vta_fac_enc

        public VtaFacDet()
        {
            NoPart = 0;
            IdPro = 0;
            Udm = "";
            Cant = 0;
            PrecioOrig = 0;
            Promoc = 0;
            PrecioPub = 0;
            DctoPtg = 0;
            PrecioCimptos = 0;
            ImporteCimptos = 0;
            PrecioPubSimptos = 0;
            PrecioSimptos = 0;
            ImporteSimptos = 0;
            MontosImptos = 0;
            IdImpto = 0;
            CCambioPrec = 0;
            Costo = 0;
            MontoDescto = 0;
            CostoTotal = 0;
            IdAlmac = 0;
            IdNota = 0;
            Tipo = 0;
            TipoPro = 1;
            EsSub = 0;
            CantDev = 0;
            PorFacturar = 0;
            IdRem = 0;
            IdRemPart = 0;
            IdFacDetKit = 0;
            IdMda = 0;
            Tc = 0;
            Oper = 0;
            SubBse = 0;
            ImptosBse = 0;
            TotalBse = 0;
            PrecioOrigBse = 0;
            PrecioPubBse = 0;
            PrecioCimptosBse = 0;
            ImporteCimptosBse = 0;
            PrecioPubSimptosBse = 0;
            PrecioSimptosBse = 0;
            ImporteSimptosBse = 0;
            MontoImptosBse = 0;
            MontoDesctoBse = 0;
            IdComSerLot = 0;
            DiasEnt = 0;
            IdPrgEntFacDet = 0;
            CantSurt = 0;
            PorSolic = 0;
            IdPartPad = 0;
            IdProOrd = 0;
            CantOrdPro = 0;
            IdProLis = 0;
            IdLisPre = 0;
            CPrecModif = 0;
            IdKardex = 0;
            IdCodSrv = 0;
            IdCenCto = 0;
            IdRef = 0;
            IdUdm = 0;
            Ftr = 0;
            IdPed = 0;
            IdPedPart = 0;
            NumPed = 0;
            IdCot = 0;
            IdCotPart = 0;
            NumCot = 0;
            IdSpt = 0;
            IdSptPart = 0;
            NumSpt = 0;
            IdPad = 0;
            IdTipDocPad = 0;
            NumPad = 0;
            NumPedCli = "";
            NumReqCli = "";
            IdClasPro = 0;
            IdRelImpto = 0;
            NumRem = 0;
            IdAct = 0;
            IdClasAct = 0;
            ValorBase = 0;
            DepAcu = 0;
            DepRem = 0;
            Campo1 = 0;
            Campo2 = 0;
            Campo3 = 0;
            Campo4 = 0;
            Campo5 = "";
            Campo6 = "";
            Campo7 = "";
            Campo8 = "";
            Campo9 = "";
            CPrg = 0;
            IdProPaq = 0;
            IdPartOri = 0;
            Sec = 0;
            IdInt = 0;
            IdCliCtaDe = 0;
            IdRefDet = 0;
            PtgKit = 0;
            RefExt = "";
            BaseGrav = 0;
            TipHon = 0;
            PtgHon = 0;
            ModImpto = 0;
            PrecioExt = 0;
            Campo11 = 0;
            Campo12 = 0;
            Campo13 = 0;
            Campo14 = 0;
            Campo15 = 0;
            Campo16 = 0;
            Campo17 = 0;
            Campo18 = 0;
            Campo19 = 0;
            Campo20 = 0;
            Campo21 = 0;
            Campo22 = 0;
            Campo23 = 0;
            Campo24 = 0;
            Campo25 = 0;
            Campo30 = "";
            Campo31 = "";
            Campo32 = "";
            Campo33 = "";
            Campo34 = "";
            Campo35 = "";
            Campo36 = "";
            Campo37 = "";
            Campo38 = "";
            Campo39 = "";
            Campo40 = "";
            IdNota2 = 0;
            IdNota3 = 0;
            TipCom = 0;
            PtgCom = 0;
            MtoCom = 0;
            IdSisLisPre = 0;
            IdTarHon = 0;
            DesTarHon = "0";
            IdFisRel = 0;
            IdOpeExt = 0;
            IdPartAlmSir = 0;
            DiasAlmSir = 0;
            DiasLibAlmSir = 0;
            DiasDctoAlmSir = 0;
            IdAlmjeGral = 0;
            IdAlmjeEsp = 0;
            Cmt = "";
            DesHon = "";
            Des = "";
            CAfeExisVta = 1;
            IdCom = 0;
            NumGrp = 0;
            CantSurtAut = 0;
            Apartado = 0;
            Backorder = 0;
            AumPtg = 0;
            CantTrasp = 0;
            Partcerrpedcot = 0;
            VtaFacDetKits = new System.Collections.Generic.List<VtaFacDetKit>();
        }
    }

}
// </auto-generated>
