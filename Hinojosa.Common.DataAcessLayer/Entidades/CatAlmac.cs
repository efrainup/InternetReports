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

    // cat_almac
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatAlmac
    {
        [Required]
        [Display(Name = "Id almac")]
        public int IdAlmac { get; set; } // id_almac (Primary key)

        [Required]
        [Display(Name = "Id suc")]
        public int IdSuc { get; set; } // id_suc

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; } // descripcion (length: 50)

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        ///<summary>
        /// 1=Si es Almacen a consignacion 0=No lo es
        ///</summary>
        [Required]
        [Display(Name = "C consignacion")]
        public byte CConsignacion { get; set; } // c_consignacion

        ///<summary>
        /// 1=Productos 2=Servicios 3=Activos
        ///</summary>
        [Required]
        [Display(Name = "Tip")]
        public byte Tip { get; set; } // tip

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Codigo")]
        public string Codigo { get; set; } // codigo (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Id otr sis")]
        public string IdOtrSis { get; set; } // id_otr_sis (length: 25)

        [Required]
        [Display(Name = "C ctb inv")]
        public int CCtbInv { get; set; } // c_ctb_inv

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Resp")]
        public string Resp { get; set; } // resp (length: 50)

        [Required]
        [Display(Name = "Id zon")]
        public int IdZon { get; set; } // id_zon

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Tel 1")]
        public string Tel1 { get; set; } // tel1 (length: 20)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Calle")]
        public string Calle { get; set; } // calle (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Noext")]
        public string Noext { get; set; } // noext (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Noint")]
        public string Noint { get; set; } // noint (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Entre calles")]
        public string EntreCalles { get; set; } // entre_calles (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Col")]
        public string Col { get; set; } // col (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Del")]
        public string Del { get; set; } // del (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; } // ciudad (length: 30)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Cp")]
        public string Cp { get; set; } // cp (length: 5)

        [Required]
        [Display(Name = "Id pais")]
        public int IdPais { get; set; } // id_pais

        [Required]
        [Display(Name = "Id edo")]
        public int IdEdo { get; set; } // id_edo

        [Required]
        [Display(Name = "C tran")]
        public byte CTran { get; set; } // c_tran

        [Required]
        [Display(Name = "C vta")]
        public byte CVta { get; set; } // c_vta

        [Required]
        [Display(Name = "Id alm env")]
        public int IdAlmEnv { get; set; } // id_alm_env

        [Required]
        [Display(Name = "C consig prov")]
        public byte CConsigProv { get; set; } // c_consig_prov

        [Required]
        [Display(Name = "Id mda")]
        public int IdMda { get; set; } // id_mda

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Contacto")]
        public string Contacto { get; set; } // contacto (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(200)]
        [StringLength(200)]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; } // email (length: 200)

        [Required]
        [Display(Name = "C mrp")]
        public byte CMrp { get; set; } // c_mrp

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fch alta")]
        public System.DateTime FchAlta { get; set; } // fch_alta

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fch ult mod")]
        public System.DateTime FchUltMod { get; set; } // fch_ult_mod

        // Reverse navigation

        /// <summary>
        /// Child InvKardexes where [inv_kardex].[id_almac] point to this entity (FK_inv_kardex_cat_almac)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<InvKardex> InvKardexes { get; set; } // inv_kardex.FK_inv_kardex_cat_almac
        /// <summary>
        /// Child InvMovSerLots where [inv_mov_ser_lot].[id_almac] point to this entity (FK_inv_mov_ser_lot_cat_almac)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<InvMovSerLot> InvMovSerLots { get; set; } // inv_mov_ser_lot.FK_inv_mov_ser_lot_cat_almac
        /// <summary>
        /// Child InvMovSerLotTmpDocs where [inv_mov_ser_lot_tmp_doc].[id_almac] point to this entity (FK_inv_mov_ser_lot_cat_almac_tmp_doc)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<InvMovSerLotTmpDoc> InvMovSerLotTmpDocs { get; set; } // inv_mov_ser_lot_tmp_doc.FK_inv_mov_ser_lot_cat_almac_tmp_doc
        /// <summary>
        /// Child InvProAlmacs where [inv_pro_almac].[id_alm] point to this entity (FK_inv_pro_almac_cat_almac)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<InvProAlmac> InvProAlmacs { get; set; } // inv_pro_almac.FK_inv_pro_almac_cat_almac
        /// <summary>
        /// Child InvSerLots where [inv_ser_lot].[id_almac] point to this entity (FK_inv_ser_lot_cat_almac)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<InvSerLot> InvSerLots { get; set; } // inv_ser_lot.FK_inv_ser_lot_cat_almac
        /// <summary>
        /// Child ProRptDets where [pro_rpt_det].[id_almac] point to this entity (FK_pro_rpt_det_cat_almac)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<ProRptDet> ProRptDets { get; set; } // pro_rpt_det.FK_pro_rpt_det_cat_almac
        /// <summary>
        /// Child SIR_Sir156EntradasBodega where [SIR_156_ENTRADAS_BODEGAS].[nIdAlmacen] point to this entity (FK_SIR_156_ENTRADAS_BODEGAS_cat_almac)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir156EntradasBodega> SIR_Sir156EntradasBodega { get; set; } // SIR_156_ENTRADAS_BODEGAS.FK_SIR_156_ENTRADAS_BODEGAS_cat_almac
        /// <summary>
        /// Child SIR_Sir157NavesBodega where [SIR_157_NAVES_BODEGA].[nIdAlmacen] point to this entity (FK_SIR_157_NAVES_BODEGA_cat_almac)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir157NavesBodega> SIR_Sir157NavesBodega { get; set; } // SIR_157_NAVES_BODEGA.FK_SIR_157_NAVES_BODEGA_cat_almac
        /// <summary>
        /// Child SIR_Sir204ProgDespachosBodega where [SIR_204_PROG_DESPACHOS_BODEGA].[nIdAlmacen] point to this entity (FK_SIR_204_PROG_DESPACHOS_BODEGA_cat_almac)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir204ProgDespachosBodega> SIR_Sir204ProgDespachosBodega { get; set; } // SIR_204_PROG_DESPACHOS_BODEGA.FK_SIR_204_PROG_DESPACHOS_BODEGA_cat_almac
        /// <summary>
        /// Child SIR_Sir241AlmjeBodGeneral where [SIR_241_ALMJE_BOD_GENERAL].[nIdBodega] point to this entity (FK_SIR_241_ALMJE_BOD_GENERAL_cat_almac)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir241AlmjeBodGeneral> SIR_Sir241AlmjeBodGeneral { get; set; } // SIR_241_ALMJE_BOD_GENERAL.FK_SIR_241_ALMJE_BOD_GENERAL_cat_almac
        /// <summary>
        /// Child SIR_Sir300ControlesVehiculare where [SIR_300_CONTROLES_VEHICULARES].[nIdAlmacen] point to this entity (FK_SIR_300_CONTROLES_VEHICULARES_cat_almac)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir300ControlesVehiculare> SIR_Sir300ControlesVehiculare { get; set; } // SIR_300_CONTROLES_VEHICULARES.FK_SIR_300_CONTROLES_VEHICULARES_cat_almac
        /// <summary>
        /// Child SIR_Sir38ModulosActividade where [SIR_38_MODULOS_ACTIVIDADES].[nIdAlmacen] point to this entity (FK_SIR_38_MODULOS_ACTIVIDADES_cat_almac)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir38ModulosActividade> SIR_Sir38ModulosActividade { get; set; } // SIR_38_MODULOS_ACTIVIDADES.FK_SIR_38_MODULOS_ACTIVIDADES_cat_almac
        /// <summary>
        /// Child SIR_Sir41RegTransporte where [SIR_41_REG_TRANSPORTES].[nIdAlmacen] point to this entity (FK_SIR_41_REG_TRANSPORTES_cat_almac)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir41RegTransporte> SIR_Sir41RegTransporte { get; set; } // SIR_41_REG_TRANSPORTES.FK_SIR_41_REG_TRANSPORTES_cat_almac
        /// <summary>
        /// Child SIR_Sir71SucursalPatenteAduana (Many-to-Many) mapped by table [SIR_117_ALMACENES_SUCPATADU]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir71SucursalPatenteAduana> SIR_Sir71SucursalPatenteAduana { get; set; } // Many to many mapping
        /// <summary>
        /// Child SIR_Sir74ConocimientosMaritimo where [SIR_74_CONOCIMIENTOS_MARITIMOS].[nIdAlmacen] point to this entity (FK_SIR_74_CONOCIMIENTOS_MARITIMOS_cat_almac)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir74ConocimientosMaritimo> SIR_Sir74ConocimientosMaritimo { get; set; } // SIR_74_CONOCIMIENTOS_MARITIMOS.FK_SIR_74_CONOCIMIENTOS_MARITIMOS_cat_almac
        /// <summary>
        /// Child SIRAdmin_Sira18Consecutivo where [SIRA_18_CONSECUTIVOS].[nIdAlmacen] point to this entity (FK_SIRA_18_CONSECUTIVOS_cat_almac)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira18Consecutivo> SIRAdmin_Sira18Consecutivo { get; set; } // SIRA_18_CONSECUTIVOS.FK_SIRA_18_CONSECUTIVOS_cat_almac
        /// <summary>
        /// Child SIRAdmin_Sira33ConfiguracionesRt where [SIRA_33_CONFIGURACIONES_RT].[nIdAlmacen] point to this entity (FK_SIRA_33_CONFIGURACIONES_RT_cat_almac)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira33ConfiguracionesRt> SIRAdmin_Sira33ConfiguracionesRt { get; set; } // SIRA_33_CONFIGURACIONES_RT.FK_SIRA_33_CONFIGURACIONES_RT_cat_almac
        /// <summary>
        /// Child VtaFacDets where [vta_fac_det].[id_almac] point to this entity (FK_vta_fac_det_cat_almac)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<VtaFacDet> VtaFacDets { get; set; } // vta_fac_det.FK_vta_fac_det_cat_almac
        /// <summary>
        /// Child VtaFacDetTmps where [vta_fac_det_tmp].[id_almac] point to this entity (FK_vta_fac_det_tmp_cat_almac)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<VtaFacDetTmp> VtaFacDetTmps { get; set; } // vta_fac_det_tmp.FK_vta_fac_det_tmp_cat_almac

        public CatAlmac()
        {
            IdAlmac = 0;
            IdSuc = 0;
            Descripcion = "";
            Status = 1;
            CConsignacion = 0;
            Tip = 1;
            Codigo = "";
            IdOtrSis = "";
            CCtbInv = 0;
            Resp = "";
            IdZon = 0;
            Tel1 = "";
            Calle = "";
            Noext = "";
            Noint = "";
            EntreCalles = "";
            Col = "";
            Del = "";
            Ciudad = "";
            Cp = "";
            IdPais = 0;
            IdEdo = 0;
            CTran = 0;
            CVta = 0;
            IdAlmEnv = 0;
            CConsigProv = 0;
            IdMda = 0;
            Contacto = "";
            Email = "";
            CMrp = 0;
            InvKardexes = new System.Collections.Generic.List<InvKardex>();
            InvMovSerLots = new System.Collections.Generic.List<InvMovSerLot>();
            InvMovSerLotTmpDocs = new System.Collections.Generic.List<InvMovSerLotTmpDoc>();
            InvProAlmacs = new System.Collections.Generic.List<InvProAlmac>();
            InvSerLots = new System.Collections.Generic.List<InvSerLot>();
            ProRptDets = new System.Collections.Generic.List<ProRptDet>();
            SIR_Sir156EntradasBodega = new System.Collections.Generic.List<SIR_Sir156EntradasBodega>();
            SIR_Sir157NavesBodega = new System.Collections.Generic.List<SIR_Sir157NavesBodega>();
            SIR_Sir204ProgDespachosBodega = new System.Collections.Generic.List<SIR_Sir204ProgDespachosBodega>();
            SIR_Sir241AlmjeBodGeneral = new System.Collections.Generic.List<SIR_Sir241AlmjeBodGeneral>();
            SIR_Sir300ControlesVehiculare = new System.Collections.Generic.List<SIR_Sir300ControlesVehiculare>();
            SIR_Sir38ModulosActividade = new System.Collections.Generic.List<SIR_Sir38ModulosActividade>();
            SIR_Sir41RegTransporte = new System.Collections.Generic.List<SIR_Sir41RegTransporte>();
            SIR_Sir74ConocimientosMaritimo = new System.Collections.Generic.List<SIR_Sir74ConocimientosMaritimo>();
            SIRAdmin_Sira18Consecutivo = new System.Collections.Generic.List<SIRAdmin_Sira18Consecutivo>();
            SIRAdmin_Sira33ConfiguracionesRt = new System.Collections.Generic.List<SIRAdmin_Sira33ConfiguracionesRt>();
            VtaFacDets = new System.Collections.Generic.List<VtaFacDet>();
            VtaFacDetTmps = new System.Collections.Generic.List<VtaFacDetTmp>();
            SIR_Sir71SucursalPatenteAduana = new System.Collections.Generic.List<SIR_Sir71SucursalPatenteAduana>();
        }
    }

}
// </auto-generated>