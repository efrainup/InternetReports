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

    // cat_pro
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatPro
    {
        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro (Primary key)

        [Display(Name = "Id impto")]
        public int? IdImpto { get; set; } // id_impto

        [Display(Name = "Id clas 1")]
        public int? IdClas1 { get; set; } // id_clas1

        [Display(Name = "Id clas 2")]
        public int? IdClas2 { get; set; } // id_clas2

        ///<summary>
        /// identificador de la ubicacion
        ///</summary>
        [Display(Name = "Id ubi")]
        public int? IdUbi { get; set; } // id_ubi

        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Clave")]
        public string Clave { get; set; } // clave (length: 25)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Codigo")]
        public string Codigo { get; set; } // codigo (length: 30)

        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (length: 250)

        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Presentacion")]
        public string Presentacion { get; set; } // presentacion (length: 40)

        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Marca")]
        public string Marca { get; set; } // marca (length: 40)

        [Required]
        [Display(Name = "Existencia")]
        public double Existencia { get; set; } // existencia

        [Required]
        [Display(Name = "Costo vta")]
        public double CostoVta { get; set; } // costo_vta

        [Required]
        [Display(Name = "Costo prom")]
        public double CostoProm { get; set; } // costo_prom

        [Required]
        [Display(Name = "Costo ult")]
        public double CostoUlt { get; set; } // costo_ult

        [Required]
        [Display(Name = "Precio")]
        public double Precio { get; set; } // precio

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Udm inv")]
        public string UdmInv { get; set; } // udm_inv (length: 5)

        [Required]
        [Display(Name = "Und com")]
        public double UndCom { get; set; } // und_com

        [Required]
        [Display(Name = "Imp com")]
        public double ImpCom { get; set; } // imp_com

        [Required]
        [Display(Name = "Und ent")]
        public double UndEnt { get; set; } // und_ent

        [Required]
        [Display(Name = "Und vta")]
        public double UndVta { get; set; } // und_vta

        [Required]
        [Display(Name = "Imp vta")]
        public double ImpVta { get; set; } // imp_vta

        [Required]
        [Display(Name = "Und sal")]
        public double UndSal { get; set; } // und_sal

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        ///<summary>
        /// 1=Si permite modificar el precio 0=no permite modificar el precio
        ///</summary>
        [Required]
        [Display(Name = "C camb precio")]
        public byte CCambPrecio { get; set; } // c_camb_precio

        [Required]
        [Display(Name = "Dcto ptg")]
        public double DctoPtg { get; set; } // dcto_ptg

        [Required]
        [Display(Name = "Precio pub")]
        public double PrecioPub { get; set; } // precio_pub

        [Display(Name = "Id suc")]
        public int? IdSuc { get; set; } // id_suc

        [Display(Name = "Id padre")]
        public int? IdPadre { get; set; } // id_padre

        ///<summary>
        /// 1=sub producto
        ///</summary>
        [Display(Name = "Es sub")]
        public byte? EsSub { get; set; } // es_sub

        ///<summary>
        /// 0=Multiplica, 1=Divide
        ///</summary>
        [Display(Name = "Operacion")]
        public byte? Operacion { get; set; } // Operacion

        [Display(Name = "Factor")]
        public double? Factor { get; set; } // factor

        ///<summary>
        /// 1=Disponible para vender 0=No Disponible
        ///</summary>
        [Required]
        [Display(Name = "C ventas")]
        public byte CVentas { get; set; } // c_ventas

        ///<summary>
        /// 0=No disponible para Comprar 1=Disponible para Comprar
        ///</summary>
        [Required]
        [Display(Name = "C compras")]
        public byte CCompras { get; set; } // c_compras

        [Required]
        [Display(Name = "Id impto 2")]
        public int IdImpto2 { get; set; } // id_impto2

        [Required]
        [Display(Name = "Id prov")]
        public int IdProv { get; set; } // id_prov

        [Required]
        [Display(Name = "Id prov uc")]
        public int IdProvUc { get; set; } // id_prov_uc

        ///<summary>
        /// 1=Inventariable 2=No Inventariable 3=Kit
        ///</summary>
        [Required]
        [Display(Name = "Tipo pro")]
        public byte TipoPro { get; set; } // tipo_pro

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fch uc")]
        public System.DateTime FchUc { get; set; } // fch_uc

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fch uv")]
        public System.DateTime FchUv { get; set; } // fch_uv

        [Required]
        [Display(Name = "Precio siva")]
        public double PrecioSiva { get; set; } // precio_siva

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fch alta")]
        public System.DateTime FchAlta { get; set; } // fch_alta

        [Required]
        [Display(Name = "Und dev")]
        public double UndDev { get; set; } // und_dev

        [Required]
        [Display(Name = "Imp dev")]
        public double ImpDev { get; set; } // imp_dev

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fch ud")]
        public System.DateTime FchUd { get; set; } // fch_ud

        ///<summary>
        /// 0=No Seriado 1=Seriado
        ///</summary>
        [Required]
        [Display(Name = "C serie")]
        public byte CSerie { get; set; } // c_serie

        ///<summary>
        /// Material que se tienne enn consignacio (ventas)
        ///</summary>
        [Required]
        [Display(Name = "En consignacion")]
        public double EnConsignacion { get; set; } // en_consignacion

        ///<summary>
        /// Material que tenemos consignado (Recepciones)
        ///</summary>
        [Required]
        [Display(Name = "Consignado")]
        public double Consignado { get; set; } // consignado

        ///<summary>
        /// 1=Pernmite Negativos 0=No Permite Negativos
        ///</summary>
        [Required]
        [Display(Name = "C negativos")]
        public byte CNegativos { get; set; } // c_negativos

        ///<summary>
        /// 1=Comercializado 2=Fabricado 3=Materia Prima
        ///</summary>
        [Required]
        [Display(Name = "Manejo")]
        public byte Manejo { get; set; } // manejo

        ///<summary>
        /// Fecha de la Ultima vez que se reporto produccion
        ///</summary>
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fch uf")]
        public System.DateTime FchUf { get; set; } // fch_uf

        ///<summary>
        /// Unidades que actualmente estan en proceso de produccion
        ///</summary>
        [Required]
        [Display(Name = "Und en orden")]
        public double UndEnOrden { get; set; } // und_en_orden

        ///<summary>
        /// Unidades que han sido Ordenadas en Prodccion
        ///</summary>
        [Required]
        [Display(Name = "Und ordenadas")]
        public double UndOrdenadas { get; set; } // und_ordenadas

        ///<summary>
        /// unidades que se han fabricado
        ///</summary>
        [Required]
        [Display(Name = "Und fabricadas")]
        public double UndFabricadas { get; set; } // und_fabricadas

        [Required]
        [Display(Name = "Und consumo")]
        public double UndConsumo { get; set; } // und_consumo

        [Required]
        [Display(Name = "Csto consumo")]
        public double CstoConsumo { get; set; } // csto_consumo

        ///<summary>
        /// Costo de lo Fabricado
        ///</summary>
        [Required]
        [Display(Name = "Csto fab")]
        public double CstoFab { get; set; } // csto_fab

        ///<summary>
        /// Id de la Moneda
        ///</summary>
        [Required]
        [Display(Name = "Id mda")]
        public int IdMda { get; set; } // id_mda

        ///<summary>
        /// 1=Control por lotes 0=Sin Control de Lotes
        ///</summary>
        [Required]
        [Display(Name = "C lot")]
        public byte CLot { get; set; } // c_lot

        ///<summary>
        /// 1=Maneja Pedimentos 0=No maneja
        ///</summary>
        [Required]
        [Display(Name = "C ped")]
        public byte CPed { get; set; } // c_ped

        ///<summary>
        /// Parte Fija del Lote
        ///</summary>
        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Ini lot")]
        public string IniLot { get; set; } // ini_lot (length: 10)

        ///<summary>
        /// Consecutivo de la part numerica
        ///</summary>
        [Required]
        [Display(Name = "Cons lot")]
        public int ConsLot { get; set; } // cons_lot

        ///<summary>
        /// Mascara para la parte numerica del Lote  (000000)
        ///</summary>
        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Mas lot")]
        public string MasLot { get; set; } // mas_lot (length: 40)

        [Required]
        [Display(Name = "Und en oc")]
        public double UndEnOc { get; set; } // und_en_oc

        ///<summary>
        /// 0=No se envasa 1=Se envasa
        ///</summary>
        [Required]
        [Display(Name = "C env")]
        public byte CEnv { get; set; } // c_env

        [Required]
        [Display(Name = "Id pro lis")]
        public int IdProLis { get; set; } // id_pro_lis

        [Required]
        [Display(Name = "Contenido")]
        public double Contenido { get; set; } // contenido

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Udm cont")]
        public string UdmCont { get; set; } // udm_cont (length: 5)

        [Required]
        [Display(Name = "Apartado")]
        public double Apartado { get; set; } // apartado

        [Required]
        [Display(Name = "Backorder")]
        public double Backorder { get; set; } // backorder

        [Required]
        [Display(Name = "Disponible")]
        public double Disponible { get; set; } // disponible

        [Required]
        [Display(Name = "Id imp com")]
        public int IdImpCom { get; set; } // id_imp_com

        [Required]
        [Display(Name = "C srv")]
        public byte CSrv { get; set; } // c_srv

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Udm com")]
        public string UdmCom { get; set; } // udm_com (length: 5)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Udm vta")]
        public string UdmVta { get; set; } // udm_vta (length: 5)

        [Required]
        [Display(Name = "Ftr inv")]
        public double FtrInv { get; set; } // ftr_inv

        [Required]
        [Display(Name = "Ftr com")]
        public double FtrCom { get; set; } // ftr_com

        [Required]
        [Display(Name = "Ftr vta")]
        public double FtrVta { get; set; } // ftr_vta

        [Required]
        [Display(Name = "Id alm")]
        public int IdAlm { get; set; } // id_alm

        [Required]
        [Display(Name = "Margen min")]
        public double MargenMin { get; set; } // margen_min

        [Required]
        [Display(Name = "Csto stnd")]
        public double CstoStnd { get; set; } // csto_stnd

        [Required]
        [Display(Name = "Id udm inv")]
        public int IdUdmInv { get; set; } // id_udm_inv

        [Required]
        [Display(Name = "Id udm vta")]
        public int IdUdmVta { get; set; } // id_udm_vta

        [Required]
        [Display(Name = "Id udm com")]
        public int IdUdmCom { get; set; } // id_udm_com

        ///<summary>
        /// id de la unidad de medida del contenido
        ///</summary>
        [Required]
        [Display(Name = "Id udm cnt")]
        public int IdUdmCnt { get; set; } // id_udm_cnt

        ///<summary>
        /// 1=Activo Fijo 0=No es Activo
        ///</summary>
        [Required]
        [Display(Name = "C act fij")]
        public byte CActFij { get; set; } // c_act_fij

        ///<summary>
        /// 1=Servicio/paquete en Cuenta de Gastos
        ///</summary>
        [Required]
        [Display(Name = "C cga")]
        public byte CCga { get; set; } // c_cga

        [Required]
        [Display(Name = "Id rel pro pre cga")]
        public int IdRelProPreCga { get; set; } // id_rel_pro_pre_cga

        [Required]
        [Display(Name = "Id sis tip cga")]
        public int IdSisTipCga { get; set; } // id_sis_tip_cga

        [Required]
        [Display(Name = "Id sis tip cpt")]
        public int IdSisTipCpt { get; set; } // id_sis_tip_cpt

        [Required]
        [Display(Name = "Id rel car")]
        public int IdRelCar { get; set; } // id_rel_car

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Id otr sis")]
        public string IdOtrSis { get; set; } // id_otr_sis (length: 25)

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
        [Display(Name = "Id cpt")]
        public int IdCpt { get; set; } // id_cpt

        [Required]
        [Display(Name = "C cambio precio comp")]
        public byte CCambioPrecioComp { get; set; } // c_cambio_precio_comp

        [Required]
        [Display(Name = "C libre")]
        public byte CLibre { get; set; } // c_libre

        [Required]
        [Display(Name = "Id rel clas")]
        public int IdRelClas { get; set; } // id_rel_clas

        [Required]
        [Display(Name = "C edit impto")]
        public byte CEditImpto { get; set; } // c_edit_impto

        [Required]
        [Display(Name = "Margen sug")]
        public double MargenSug { get; set; } // margen_sug

        [Required]
        [Display(Name = "C calc pre costo")]
        public byte CCalcPreCosto { get; set; } // c_calc_pre_costo

        [Required]
        [Display(Name = "C cgo dir")]
        public byte CCgoDir { get; set; } // c_cgo_dir

        [Required]
        [Display(Name = "Gto adu")]
        public double GtoAdu { get; set; } // gto_adu

        [Required]
        [Display(Name = "C cad")]
        public byte CCad { get; set; } // c_cad

        [Required]
        [Display(Name = "Id alm dev")]
        public int IdAlmDev { get; set; } // id_alm_dev

        [Required]
        [Display(Name = "C sol ser")]
        public int CSolSer { get; set; } // c_sol_ser

        [Required]
        [Display(Name = "C mod des")]
        public byte CModDes { get; set; } // c_mod_des

        [Required]
        [Display(Name = "C ser num")]
        public byte CSerNum { get; set; } // c_ser_num

        [Required]
        [Display(Name = "C met cost")]
        public byte CMetCost { get; set; } // c_met_cost

        [Required]
        [Display(Name = "C afe exis vta")]
        public int CAfeExisVta { get; set; } // c_afe_exis_vta

        [Required]
        [Display(Name = "C disp nc")]
        public int CDispNc { get; set; } // c_disp_nc

        [Required]
        [Display(Name = "C bkr")]
        public byte CBkr { get; set; } // c_bkr

        [Required]
        [Display(Name = "C config")]
        public byte CConfig { get; set; } // c_config

        [Required]
        [Display(Name = "C crea requi aut")]
        public byte CCreaRequiAut { get; set; } // c_crea_requi_aut

        [Required]
        [Display(Name = "C crea oc aut")]
        public byte CCreaOcAut { get; set; } // c_crea_oc_aut

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ult mod")]
        public System.DateTime FecUltMod { get; set; } // fec_ult_mod

        [Required]
        [Display(Name = "Id tip ope srv")]
        public int IdTipOpeSrv { get; set; } // id_tip_ope_srv

        [Required]
        [Display(Name = "C ide")]
        public byte CIde { get; set; } // c_IDE

        [Required]
        [Display(Name = "C isr pm")]
        public byte CIsrPm { get; set; } // c_ISR_pm

        [Required]
        [Display(Name = "C isr arr")]
        public byte CIsrArr { get; set; } // c_ISR_arr

        [Required]
        [Display(Name = "C isr hon")]
        public byte CIsrHon { get; set; } // c_ISR_hon

        [Required]
        [Display(Name = "C isr sal")]
        public byte CIsrSal { get; set; } // c_ISR_sal

        [Required]
        [Display(Name = "C isr asi")]
        public byte CIsrAsi { get; set; } // c_ISR_asi

        [Required]
        [Display(Name = "C iva")]
        public byte CIva { get; set; } // c_IVA

        [Required]
        [Display(Name = "C ret iva")]
        public byte CRetIva { get; set; } // c_RET_IVA

        [Required]
        [Display(Name = "C ietu")]
        public byte CIetu { get; set; } // c_IETU

        [Required]
        [Display(Name = "Und en ped")]
        public double UndEnPed { get; set; } // und_en_ped

        [Required]
        [Display(Name = "Und en prod")]
        public double UndEnProd { get; set; } // und_en_prod

        [Required]
        [Display(Name = "C renta")]
        public byte CRenta { get; set; } // c_renta

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Cta predial")]
        public string CtaPredial { get; set; } // cta_predial (length: 50)

        [Required]
        [Display(Name = "C apl cto srv")]
        public byte CAplCtoSrv { get; set; } // c_apl_cto_srv

        [Required]
        [Display(Name = "Id tip area")]
        public int IdTipArea { get; set; } // id_tip_area

        [Required]
        [Display(Name = "Id sub cat")]
        public int IdSubCat { get; set; } // id_sub_cat

        [Required]
        [Display(Name = "C ter")]
        public int CTer { get; set; } // c_ter

        ///<summary>
        /// Define si es un costo indirecto, 1=Es costo indirecto, permite elegir almacen de productos
        ///</summary>
        [Required]
        [Display(Name = "C ind")]
        public byte CInd { get; set; } // c_ind

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Imp comp des")]
        public string ImpCompDes { get; set; } // imp_comp_des (length: 25)

        [Required]
        [Display(Name = "Imp comp tasa")]
        public double ImpCompTasa { get; set; } // imp_comp_tasa

        [Required]
        [Display(Name = "Imp comp ftr")]
        public double ImpCompFtr { get; set; } // imp_comp_ftr

        [Required]
        [Display(Name = "C usa pref")]
        public byte CUsaPref { get; set; } // c_usa_pref

        [Required]
        [Display(Name = "Num car pref")]
        public int NumCarPref { get; set; } // num_car_pref

        [Required]
        [Display(Name = "Num dias ent prov")]
        public int NumDiasEntProv { get; set; } // num_dias_ent_prov

        [Required]
        [Display(Name = "Num dias ent prov real")]
        public int NumDiasEntProvReal { get; set; } // num_dias_ent_prov_real

        [Required]
        [Display(Name = "Num dias max inv")]
        public int NumDiasMaxInv { get; set; } // num_dias_max_inv

        [Required]
        [Display(Name = "Mult comp inv")]
        public double MultCompInv { get; set; } // mult_comp_inv

        [Required]
        [Display(Name = "Uni min comp")]
        public double UniMinComp { get; set; } // uni_min_comp

        [Required]
        [Display(Name = "Peso brt")]
        public double PesoBrt { get; set; } // peso_brt

        [Required]
        [Display(Name = "Peso nto")]
        public double PesoNto { get; set; } // peso_nto

        [Required]
        [Display(Name = "Long")]
        public double @Long { get; set; } // long

        [Required]
        [Display(Name = "Area")]
        public double Area { get; set; } // area

        [Required]
        [Display(Name = "Vol")]
        public double Vol { get; set; } // vol

        [Required]
        [Display(Name = "Id udm pbrt")]
        public int IdUdmPbrt { get; set; } // id_udm_Pbrt

        [Required]
        [Display(Name = "Id udm pnto")]
        public int IdUdmPnto { get; set; } // id_udm_Pnto

        [Required]
        [Display(Name = "Id udm long")]
        public int IdUdmLong { get; set; } // id_udm_long

        [Required]
        [Display(Name = "Id udm area")]
        public int IdUdmArea { get; set; } // id_udm_area

        [Required]
        [Display(Name = "Id udm vol")]
        public int IdUdmVol { get; set; } // id_udm_vol

        [Required]
        [Display(Name = "C sol ser oc")]
        public byte CSolSerOc { get; set; } // c_sol_ser_oc

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; } // modelo (length: 80)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Submodelo")]
        public string Submodelo { get; set; } // Submodelo (length: 80)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Ce cert orig")]
        public string CeCertOrig { get; set; } // ce_cert_orig (length: 40)

        [Required]
        [Display(Name = "Ce ID frac")]
        public int CeIdFrac { get; set; } // ce_id_frac

        [Required]
        [Display(Name = "Id udm adu")]
        public int IdUdmAdu { get; set; } // id_udm_adu

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Ce udm adu")]
        public string CeUdmAdu { get; set; } // ce_udm_adu (length: 10)

        [Required]
        [Display(Name = "Ftr adu")]
        public double FtrAdu { get; set; } // ftr_adu

        [Required]
        [Display(Name = "Id tip mat prim")]
        public int IdTipMatPrim { get; set; } // id_tip_mat_prim

        [Required]
        [Display(Name = "Id cve sat")]
        public int IdCveSat { get; set; } // id_cve_sat

        [Required]
        [Display(Name = "C lote auto")]
        public byte CLoteAuto { get; set; } // c_lote_auto

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Head compe")]
        public string HeadCompe { get; set; } // head_compe (length: 20)

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) CatPro pointed by [cat_pro_img].[id_pro] (FK_cat_pro_img_cat_pro)
        /// </summary>
        public virtual CatProImg CatProImg { get; set; } // cat_pro_img.FK_cat_pro_img_cat_pro
        /// <summary>
        /// Child CatKits where [cat_kit].[id_pro] point to this entity (FK_cat_kit_cat_pro)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<CatKit> CatKits { get; set; } // cat_kit.FK_cat_kit_cat_pro
        /// <summary>
        /// Child InvKardexes where [inv_kardex].[id_pro] point to this entity (FK_inv_kardex_cat_pro)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<InvKardex> InvKardexes { get; set; } // inv_kardex.FK_inv_kardex_cat_pro
        /// <summary>
        /// Child InvMovParts where [inv_mov_part].[id_pro] point to this entity (FK_inv_mov_part_cat_pro)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<InvMovPart> InvMovParts { get; set; } // inv_mov_part.FK_inv_mov_part_cat_pro
        /// <summary>
        /// Child InvProAlmacs where [inv_pro_almac].[id_pro] point to this entity (FK_inv_pro_almac_cat_pro)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<InvProAlmac> InvProAlmacs { get; set; } // inv_pro_almac.FK_inv_pro_almac_cat_pro
        /// <summary>
        /// Child InvSerLots where [inv_ser_lot].[id_pro] point to this entity (FK_inv_ser_lot_cat_pro)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<InvSerLot> InvSerLots { get; set; } // inv_ser_lot.FK_inv_ser_lot_cat_pro
        /// <summary>
        /// Child ProEstProCtoes where [pro_est_pro_cto].[id_pro_pad] point to this entity (FK_pro_est_pro_cto_cat_pro)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<ProEstProCto> ProEstProCtoes { get; set; } // pro_est_pro_cto.FK_pro_est_pro_cto_cat_pro
        /// <summary>
        /// Child ProLisMats where [pro_lis_mat].[id_pro_pad] point to this entity (FK_pro_lis_mat_cat_pro)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<ProLisMat> ProLisMats { get; set; } // pro_lis_mat.FK_pro_lis_mat_cat_pro
        /// <summary>
        /// Child ProRptEncs where [pro_rpt_enc].[id_pro] point to this entity (FK_pro_rpt_enc_cat_pro)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<ProRptEnc> ProRptEncs { get; set; } // pro_rpt_enc.FK_pro_rpt_enc_cat_pro
        /// <summary>
        /// Child SIR_Sir122SolCheqConcepto where [SIR_122_SOL_CHEQ_CONCEPTOS].[nIdProducto] point to this entity (FK_SIR_122_SOL_CHEQ_CONCEPTOS_cat_pro)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir122SolCheqConcepto> SIR_Sir122SolCheqConcepto { get; set; } // SIR_122_SOL_CHEQ_CONCEPTOS.FK_SIR_122_SOL_CHEQ_CONCEPTOS_cat_pro
        /// <summary>
        /// Child SIR_Sir172ConsultasActividade where [SIR_172_CONSULTAS_ACTIVIDADES].[nIdActividad] point to this entity (FK_SIR_172_CONSULTAS_ACTIVIDADES_cat_pro)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir172ConsultasActividade> SIR_Sir172ConsultasActividade { get; set; } // SIR_172_CONSULTAS_ACTIVIDADES.FK_SIR_172_CONSULTAS_ACTIVIDADES_cat_pro
        /// <summary>
        /// Child SIR_Sir210Operacione where [SIR_210_OPERACIONES].[nIdConcepto] point to this entity (FK_SIR_210_OPERACIONES_cat_pro)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir210Operacione> SIR_Sir210Operacione { get; set; } // SIR_210_OPERACIONES.FK_SIR_210_OPERACIONES_cat_pro
        /// <summary>
        /// Child SIR_Sir242AlmjeBodEspecifico where [SIR_242_ALMJE_BOD_ESPECIFICO].[nIdConcepto] point to this entity (FK_SIR_242_ALMJE_BOD_ESPECIFICO_cat_pro)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir242AlmjeBodEspecifico> SIR_Sir242AlmjeBodEspecifico { get; set; } // SIR_242_ALMJE_BOD_ESPECIFICO.FK_SIR_242_ALMJE_BOD_ESPECIFICO_cat_pro
        /// <summary>
        /// Child SIR_Sir34ReferenciasCatPro where [SIR_34_REFERENCIAS_CAT_PRO].[nIdPaquete] point to this entity (FK_SIR_34_REFERENCIAS_CAT_PRO_cat_proPAQ)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir34ReferenciasCatPro> SIR_Sir34ReferenciasCatPro_NIdPaquete { get; set; } // SIR_34_REFERENCIAS_CAT_PRO.FK_SIR_34_REFERENCIAS_CAT_PRO_cat_proPAQ
        /// <summary>
        /// Child SIR_Sir34ReferenciasCatPro where [SIR_34_REFERENCIAS_CAT_PRO].[nIdProducto] point to this entity (FK_SIR_34_REFERENCIAS_CAT_PRO_cat_proPRO)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir34ReferenciasCatPro> SIR_Sir34ReferenciasCatPro_NIdProducto { get; set; } // SIR_34_REFERENCIAS_CAT_PRO.FK_SIR_34_REFERENCIAS_CAT_PRO_cat_proPRO
        /// <summary>
        /// Child SIR_Sir37ActividadesUsuario where [SIR_37_ACTIVIDADES_USUARIO].[nIdConcepto] point to this entity (FK_SIR_37_ACTIVIDADES_USUARIO_cat_pro)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir37ActividadesUsuario> SIR_Sir37ActividadesUsuario { get; set; } // SIR_37_ACTIVIDADES_USUARIO.FK_SIR_37_ACTIVIDADES_USUARIO_cat_pro
        /// <summary>
        /// Child SIR_Sir50Revalidacion where [SIR_50_REVALIDACION].[nIdGarantia] point to this entity (FK_SIR_50_REVALIDACION_cat_pro)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir50Revalidacion> SIR_Sir50Revalidacion_NIdGarantia { get; set; } // SIR_50_REVALIDACION.FK_SIR_50_REVALIDACION_cat_pro
        /// <summary>
        /// Child SIR_Sir50Revalidacion where [SIR_50_REVALIDACION].[nIdProducto] point to this entity (FK_SIR_50_REVALIDACION_cat_pro1)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir50Revalidacion> SIR_Sir50Revalidacion_NIdProducto { get; set; } // SIR_50_REVALIDACION.FK_SIR_50_REVALIDACION_cat_pro1
        /// <summary>
        /// Child SIR_Sir762ConfigPagoPrevalidavor where [SIR_762_CONFIG_PAGO_PREVALIDAVOR].[nIdConcepto] point to this entity (FK_SIR_762_CONFIG_PAGO_PREVALIDAVOR_cat_pro)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir762ConfigPagoPrevalidavor> SIR_Sir762ConfigPagoPrevalidavor { get; set; } // SIR_762_CONFIG_PAGO_PREVALIDAVOR.FK_SIR_762_CONFIG_PAGO_PREVALIDAVOR_cat_pro
        /// <summary>
        /// Child SIRAdmin_Sira23ConfPagoElectronico where [SIRA_23_CONF_PAGO_ELECTRONICO].[nIdProducto] point to this entity (FK_SIRA_23_CONF_PAGO_ELECTRONICO_cat_pro)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira23ConfPagoElectronico> SIRAdmin_Sira23ConfPagoElectronico { get; set; } // SIRA_23_CONF_PAGO_ELECTRONICO.FK_SIRA_23_CONF_PAGO_ELECTRONICO_cat_pro
        /// <summary>
        /// Child VtaFacDets where [vta_fac_det].[id_pro] point to this entity (FK_vta_fac_det_cat_pro)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<VtaFacDet> VtaFacDets { get; set; } // vta_fac_det.FK_vta_fac_det_cat_pro
        /// <summary>
        /// Child VtaFacDetKits where [vta_fac_det_kit].[id_pro] point to this entity (FK_vta_fac_det_kit_cat_pro)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<VtaFacDetKit> VtaFacDetKits { get; set; } // vta_fac_det_kit.FK_vta_fac_det_kit_cat_pro
        /// <summary>
        /// Child VtaFacDetTmps where [vta_fac_det_tmp].[id_pro] point to this entity (FK_vta_fac_det_tmp_cat_pro)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<VtaFacDetTmp> VtaFacDetTmps { get; set; } // vta_fac_det_tmp.FK_vta_fac_det_tmp_cat_pro

        // Foreign keys

        /// <summary>
        /// Parent CatImpto pointed by [cat_pro].([IdImpto]) (FK_cat_pro_cat_impto)
        /// </summary>
        public virtual CatImpto CatImpto { get; set; } // FK_cat_pro_cat_impto

        /// <summary>
        /// Parent CatUbicacion pointed by [cat_pro].([IdUbi]) (FK_cat_pro_cat_ubicacion)
        /// </summary>
        public virtual CatUbicacion CatUbicacion { get; set; } // FK_cat_pro_cat_ubicacion

        public CatPro()
        {
            IdPro = 0;
            IdImpto = 0;
            IdClas1 = 0;
            IdClas2 = 0;
            IdUbi = 0;
            Clave = "";
            Codigo = "";
            Des = "";
            Presentacion = "";
            Marca = "";
            Existencia = 0;
            CostoVta = 0;
            CostoProm = 0;
            CostoUlt = 0;
            Precio = 0;
            UdmInv = "";
            UndCom = 0;
            ImpCom = 0;
            UndEnt = 0;
            UndVta = 0;
            ImpVta = 0;
            UndSal = 0;
            Status = 1;
            CCambPrecio = 0;
            DctoPtg = 0;
            PrecioPub = 0;
            IdSuc = 0;
            IdPadre = 0;
            EsSub = 0;
            Operacion = 0;
            Factor = 0;
            CVentas = 0;
            CCompras = 0;
            IdImpto2 = 0;
            IdProv = 0;
            IdProvUc = 0;
            TipoPro = 0;
            PrecioSiva = 0;
            IdNota = 0;
            UndDev = 0;
            ImpDev = 0;
            CSerie = 0;
            EnConsignacion = 0;
            Consignado = 0;
            CNegativos = 0;
            Manejo = 0;
            UndEnOrden = 0;
            UndOrdenadas = 0;
            UndFabricadas = 0;
            UndConsumo = 0;
            CstoConsumo = 0;
            CstoFab = 0;
            IdMda = 0;
            CLot = 0;
            CPed = 0;
            IniLot = "";
            ConsLot = 0;
            MasLot = "";
            UndEnOc = 0;
            CEnv = 0;
            IdProLis = 0;
            Contenido = 0;
            UdmCont = "";
            Apartado = 0;
            Backorder = 0;
            Disponible = 0;
            IdImpCom = 0;
            CSrv = 0;
            UdmCom = "";
            UdmVta = "";
            FtrInv = 0;
            FtrCom = 0;
            FtrVta = 0;
            IdAlm = 0;
            MargenMin = 0;
            CstoStnd = 0;
            IdUdmInv = 0;
            IdUdmVta = 0;
            IdUdmCom = 0;
            IdUdmCnt = 0;
            CActFij = 0;
            CCga = 0;
            IdRelProPreCga = 0;
            IdSisTipCga = 0;
            IdSisTipCpt = 0;
            IdRelCar = 0;
            IdOtrSis = "";
            IdCenCto = 0;
            IdCodSrv = 0;
            IdRef = 0;
            IdCpt = 0;
            CCambioPrecioComp = 0;
            CLibre = 0;
            IdRelClas = 0;
            CEditImpto = 0;
            MargenSug = 0;
            CCalcPreCosto = 0;
            CCgoDir = 0;
            GtoAdu = 0;
            CCad = 0;
            IdAlmDev = 0;
            CSolSer = 0;
            CModDes = 0;
            CSerNum = 0;
            CMetCost = 0;
            CAfeExisVta = 1;
            CDispNc = 0;
            CBkr = 0;
            CConfig = 0;
            CCreaRequiAut = 0;
            CCreaOcAut = 0;
            IdTipOpeSrv = 0;
            CIde = 0;
            CIsrPm = 0;
            CIsrArr = 0;
            CIsrHon = 0;
            CIsrSal = 0;
            CIsrAsi = 0;
            CIva = 0;
            CRetIva = 0;
            CIetu = 0;
            UndEnPed = 0;
            UndEnProd = 0;
            CRenta = 0;
            CtaPredial = "";
            CAplCtoSrv = 0;
            IdTipArea = 0;
            IdSubCat = 0;
            CTer = 0;
            CInd = 0;
            ImpCompDes = "";
            ImpCompTasa = 0;
            ImpCompFtr = 0;
            CUsaPref = 0;
            NumCarPref = 0;
            NumDiasEntProv = 0;
            NumDiasEntProvReal = 0;
            NumDiasMaxInv = 0;
            MultCompInv = 0.00;
            UniMinComp = 0.00;
            PesoBrt = 0;
            PesoNto = 0;
            @Long = 0;
            Area = 0;
            Vol = 0;
            IdUdmPbrt = 0;
            IdUdmPnto = 0;
            IdUdmLong = 0;
            IdUdmArea = 0;
            IdUdmVol = 0;
            CSolSerOc = 0;
            Modelo = "";
            Submodelo = "";
            CeCertOrig = "";
            CeIdFrac = 0;
            IdUdmAdu = 0;
            CeUdmAdu = "";
            FtrAdu = 1;
            IdTipMatPrim = 0;
            IdCveSat = 0;
            CLoteAuto = 0;
            HeadCompe = "";
            CatKits = new System.Collections.Generic.List<CatKit>();
            InvKardexes = new System.Collections.Generic.List<InvKardex>();
            InvMovParts = new System.Collections.Generic.List<InvMovPart>();
            InvProAlmacs = new System.Collections.Generic.List<InvProAlmac>();
            InvSerLots = new System.Collections.Generic.List<InvSerLot>();
            ProEstProCtoes = new System.Collections.Generic.List<ProEstProCto>();
            ProLisMats = new System.Collections.Generic.List<ProLisMat>();
            ProRptEncs = new System.Collections.Generic.List<ProRptEnc>();
            SIR_Sir122SolCheqConcepto = new System.Collections.Generic.List<SIR_Sir122SolCheqConcepto>();
            SIR_Sir172ConsultasActividade = new System.Collections.Generic.List<SIR_Sir172ConsultasActividade>();
            SIR_Sir210Operacione = new System.Collections.Generic.List<SIR_Sir210Operacione>();
            SIR_Sir242AlmjeBodEspecifico = new System.Collections.Generic.List<SIR_Sir242AlmjeBodEspecifico>();
            SIR_Sir34ReferenciasCatPro_NIdPaquete = new System.Collections.Generic.List<SIR_Sir34ReferenciasCatPro>();
            SIR_Sir34ReferenciasCatPro_NIdProducto = new System.Collections.Generic.List<SIR_Sir34ReferenciasCatPro>();
            SIR_Sir37ActividadesUsuario = new System.Collections.Generic.List<SIR_Sir37ActividadesUsuario>();
            SIR_Sir50Revalidacion_NIdGarantia = new System.Collections.Generic.List<SIR_Sir50Revalidacion>();
            SIR_Sir50Revalidacion_NIdProducto = new System.Collections.Generic.List<SIR_Sir50Revalidacion>();
            SIR_Sir762ConfigPagoPrevalidavor = new System.Collections.Generic.List<SIR_Sir762ConfigPagoPrevalidavor>();
            SIRAdmin_Sira23ConfPagoElectronico = new System.Collections.Generic.List<SIRAdmin_Sira23ConfPagoElectronico>();
            VtaFacDets = new System.Collections.Generic.List<VtaFacDet>();
            VtaFacDetKits = new System.Collections.Generic.List<VtaFacDetKit>();
            VtaFacDetTmps = new System.Collections.Generic.List<VtaFacDetTmp>();
        }
    }

}
// </auto-generated>
