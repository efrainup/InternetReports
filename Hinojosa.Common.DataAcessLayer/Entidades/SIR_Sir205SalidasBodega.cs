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

    // SIR_205_SALIDAS_BODEGA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir205SalidasBodega
    {
        [Required]
        [Display(Name = "N ID sal bod 205")]
        public int NIdSalBod205 { get; set; } // nIdSalBod205 (Primary key)

        [Display(Name = "N ID transportista")]
        public int? NIdTransportista { get; set; } // nIdTransportista

        [Required]
        [Display(Name = "N ID empleado")]
        public int NIdEmpleado { get; set; } // nIdEmpleado

        [Required]
        [Display(Name = "N ID suc pat adu 71")]
        public int NIdSucPatAdu71 { get; set; } // nIdSucPatAdu71

        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "S chofer")]
        public string SChofer { get; set; } // sChofer (length: 60)

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S num economico")]
        public string SNumEconomico { get; set; } // sNumEconomico (length: 20)

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S placas")]
        public string SPlacas { get; set; } // sPlacas (length: 20)

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S observacion")]
        public string SObservacion { get; set; } // sObservacion (length: 500)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S orden salida")]
        public string SOrdenSalida { get; set; } // sOrdenSalida (length: 50)

        [Required]
        [Display(Name = "N tipo salida")]
        public byte NTipoSalida { get; set; } // nTipoSalida

        [Required]
        [Display(Name = "N status salida")]
        public byte NStatusSalida { get; set; } // nStatusSalida

        [Display(Name = "D fecha salida")]
        public System.DateTime? DFechaSalida { get; set; } // dFechaSalida

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Display(Name = "D fecha registro")]
        public System.DateTime? DFechaRegistro { get; set; } // dFechaRegistro

        [Display(Name = "D fecha programacion")]
        public System.DateTime? DFechaProgramacion { get; set; } // dFechaProgramacion

        [Required]
        [Display(Name = "B flete pagado")]
        public bool BFletePagado { get; set; } // bFletePagado

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S caja")]
        public string SCaja { get; set; } // sCaja (length: 500)

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S sellos")]
        public string SSellos { get; set; } // sSellos (length: 500)

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S talon")]
        public string STalon { get; set; } // sTalon (length: 500)

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S observaciones nota")]
        public string SObservacionesNota { get; set; } // sObservacionesNota (length: 500)

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S observaciones hoja")]
        public string SObservacionesHoja { get; set; } // sObservacionesHoja (length: 500)

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S observaciones relacion")]
        public string SObservacionesRelacion { get; set; } // sObservacionesRelacion (length: 500)

        [MaxLength(120)]
        [StringLength(120)]
        [Display(Name = "S atencion")]
        public string SAtencion { get; set; } // sAtencion (length: 120)

        [Display(Name = "N otros cargos")]
        public decimal? NOtrosCargos { get; set; } // nOtrosCargos

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S transportista")]
        public string STransportista { get; set; } // sTransportista (length: 500)

        [Display(Name = "N ID spab odega 71")]
        public int? NIdSpaBodega71 { get; set; } // nIdSPABodega71

        [Display(Name = "N ID sucursal")]
        public int? NIdSucursal { get; set; } // nIdSucursal

        [Display(Name = "N ID tipo programacion 648")]
        public int? NIdTipoProgramacion648 { get; set; } // nIdTipoProgramacion648

        [Display(Name = "N tipo embarque")]
        public int? NTipoEmbarque { get; set; } // nTipoEmbarque

        [Display(Name = "N total pesos lbs")]
        public decimal? NTotalPesosLbs { get; set; } // nTotalPesosLbs

        [MaxLength(150)]
        [StringLength(150)]
        [Display(Name = "S puerta")]
        public string SPuerta { get; set; } // sPuerta (length: 150)

        [Display(Name = "N cargo")]
        public decimal? NCargo { get; set; } // nCargo

        [MaxLength(150)]
        [StringLength(150)]
        [Display(Name = "S entrega")]
        public string SEntrega { get; set; } // sEntrega (length: 150)

        [Display(Name = "B listo para cargar")]
        public bool? BListoParaCargar { get; set; } // bListoParaCargar

        [Display(Name = "B mercancia cargada")]
        public bool? BMercanciaCargada { get; set; } // bMercanciaCargada

        [Display(Name = "B listo para cruce")]
        public bool? BListoParaCruce { get; set; } // bListoParaCruce

        [Display(Name = "B carril fast")]
        public bool? BCarrilFast { get; set; } // bCarrilFast

        [Display(Name = "B amarres")]
        public bool? BAmarres { get; set; } // bAmarres

        [Display(Name = "N orden cruce")]
        public int? NOrdenCruce { get; set; } // nOrdenCruce

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha orden cruce")]
        public System.DateTime? DFechaOrdenCruce { get; set; } // dFechaOrdenCruce

        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "S licencia")]
        public string SLicencia { get; set; } // sLicencia (length: 15)

        [Display(Name = "N ID ent fed licencia chofer 284")]
        public int? NIdEntFedLicenciaChofer284 { get; set; } // nIdEntFedLicenciaChofer284

        [DataType(DataType.DateTime)]
        [Display(Name = "D listo para cargar")]
        public System.DateTime? DListoParaCargar { get; set; } // dListoParaCargar

        [DataType(DataType.DateTime)]
        [Display(Name = "D mercancia cargada")]
        public System.DateTime? DMercanciaCargada { get; set; } // dMercanciaCargada

        [DataType(DataType.DateTime)]
        [Display(Name = "D listo para cruce")]
        public System.DateTime? DListoParaCruce { get; set; } // dListoParaCruce

        [Display(Name = "N ID usuario listo para cargar")]
        public int? NIdUsuarioListoParaCargar { get; set; } // nIdUsuarioListoParaCargar

        [Display(Name = "N ID usuario mercancia cargada")]
        public int? NIdUsuarioMercanciaCargada { get; set; } // nIdUsuarioMercanciaCargada

        [Display(Name = "N ID usuario listo para cruce")]
        public int? NIdUsuarioListoParaCruce { get; set; } // nIdUsuarioListoParaCruce

        [Display(Name = "B multiple usuario control carga")]
        public bool? BMultipleUsuarioControlCarga { get; set; } // bMultipleUsuarioControlCarga

        [Display(Name = "B control de carga confirmada")]
        public bool? BControlDeCargaConfirmada { get; set; } // bControlDeCargaConfirmada

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S servicio especial")]
        public string SServicioEspecial { get; set; } // sServicioEspecial (length: 100)

        [Display(Name = "B aplica dir general")]
        public bool? BAplicaDirGeneral { get; set; } // bAplicaDirGeneral

        [Display(Name = "N ID chofer transfer 754")]
        public int? NIdChoferTransfer754 { get; set; } // nIdChoferTransfer754

        [Display(Name = "B embarque urgente")]
        public bool? BEmbarqueUrgente { get; set; } // bEmbarqueUrgente

        [Display(Name = "N ID transportista mex")]
        public int? NIdTransportistaMex { get; set; } // nIdTransportistaMex

        [Display(Name = "N ID tipo cont 09")]
        public int? NIdTipoCont09 { get; set; } // nIdTipoCont09

        [Display(Name = "N estatus notificacion")]
        public int? NEstatusNotificacion { get; set; } // nEstatusNotificacion

        [Display(Name = "N ID usuario envio notificacion")]
        public int? NIdUsuarioEnvioNotificacion { get; set; } // nIdUsuarioEnvioNotificacion

        [DataType(DataType.DateTime)]
        [Display(Name = "D envio notificacion")]
        public System.DateTime? DEnvioNotificacion { get; set; } // dEnvioNotificacion

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir135CargaSueltaDetalle where [SIR_135_CARGA_SUELTA_DETALLE].[nIdSalBod205] point to this entity (FK_SIR_135_CARGA_SUELTA_DETALLE_SIR_205_SALIDAS_BODEGA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir135CargaSueltaDetalle> SIR_Sir135CargaSueltaDetalle { get; set; } // SIR_135_CARGA_SUELTA_DETALLE.FK_SIR_135_CARGA_SUELTA_DETALLE_SIR_205_SALIDAS_BODEGA
        /// <summary>
        /// Child SIR_Sir300ControlesVehiculare where [SIR_300_CONTROLES_VEHICULARES].[nIdSalBod205] point to this entity (FK_SIR_300_CONTROLES_VEHICULARES_SIR_205_SALIDAS_BODEGA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir300ControlesVehiculare> SIR_Sir300ControlesVehiculare { get; set; } // SIR_300_CONTROLES_VEHICULARES.FK_SIR_300_CONTROLES_VEHICULARES_SIR_205_SALIDAS_BODEGA
        /// <summary>
        /// Child SIR_Sir366CaracSalidasBodega where [SIR_366_CARAC_SALIDAS_BODEGA].[nIdSalBod205] point to this entity (FK_SIR_366_CARAC_SALIDAS_BODEGA_SIR_205_SALIDAS_BODEGA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir366CaracSalidasBodega> SIR_Sir366CaracSalidasBodega { get; set; } // SIR_366_CARAC_SALIDAS_BODEGA.FK_SIR_366_CARAC_SALIDAS_BODEGA_SIR_205_SALIDAS_BODEGA
        /// <summary>
        /// Child SIR_Sir602EntradaSalidaPatio where [SIR_602_ENTRADA_SALIDA_PATIO].[nIdSalBod205] point to this entity (FK_SIR_602_ENTRADA_SALIDA_PATIO_SIR_205_SALIDAS_BODEGA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir602EntradaSalidaPatio> SIR_Sir602EntradaSalidaPatio { get; set; } // SIR_602_ENTRADA_SALIDA_PATIO.FK_SIR_602_ENTRADA_SALIDA_PATIO_SIR_205_SALIDAS_BODEGA
        /// <summary>
        /// Child SIR_Sir661ControlCargaSalida where [SIR_661_CONTROL_CARGA_SALIDA].[nIdSalBod205] point to this entity (FK_SIR_661_CONTROL_CARGA_SALIDA_SIR_205_SALIDAS_BODEGA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir661ControlCargaSalida> SIR_Sir661ControlCargaSalida { get; set; } // SIR_661_CONTROL_CARGA_SALIDA.FK_SIR_661_CONTROL_CARGA_SALIDA_SIR_205_SALIDAS_BODEGA
        /// <summary>
        /// Child SIR_Sir742IngresosEgresosDm where [SIR_742_INGRESOS_EGRESOS_DMS].[nIdSalBod205] point to this entity (FK_SIR_742_INGRESOS_EGRESOS_DMS_SIR_205_SALIDAS_BODEGA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir742IngresosEgresosDm> SIR_Sir742IngresosEgresosDm { get; set; } // SIR_742_INGRESOS_EGRESOS_DMS.FK_SIR_742_INGRESOS_EGRESOS_DMS_SIR_205_SALIDAS_BODEGA
        /// <summary>
        /// Child SIR_Sir743OrdenSalidaManifiestoDm where [SIR_743_ORDEN_SALIDA_MANIFIESTO_DMS].[nIdSalBod205] point to this entity (FK_SIR_743_ORDEN_SALIDA_MANIFIESTO_DMS_SIR_205_SALIDAS_BODEGA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir743OrdenSalidaManifiestoDm> SIR_Sir743OrdenSalidaManifiestoDm { get; set; } // SIR_743_ORDEN_SALIDA_MANIFIESTO_DMS.FK_SIR_743_ORDEN_SALIDA_MANIFIESTO_DMS_SIR_205_SALIDAS_BODEGA
        /// <summary>
        /// Child SIR_Sir755NotificacionesAppTransportista where [SIR_755_NOTIFICACIONES_APP_TRANSPORTISTAS].[nIdSalBod205] point to this entity (FK_SIR_755_NOTIFICACIONES_APP_TRANSPORTISTAS_SIR_205_SALIDAS_BODEGA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir755NotificacionesAppTransportista> SIR_Sir755NotificacionesAppTransportista { get; set; } // SIR_755_NOTIFICACIONES_APP_TRANSPORTISTAS.FK_SIR_755_NOTIFICACIONES_APP_TRANSPORTISTAS_SIR_205_SALIDAS_BODEGA
        /// <summary>
        /// Child SIR_Sir846FotosSalidaBodega where [SIR_846_FOTOS_SALIDA_BODEGA].[nIdSalBod205] point to this entity (FK_SIR_846_FOTOS_SALIDA_BODEGA_SIR_205_SALIDAS_BODEGA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir846FotosSalidaBodega> SIR_Sir846FotosSalidaBodega { get; set; } // SIR_846_FOTOS_SALIDA_BODEGA.FK_SIR_846_FOTOS_SALIDA_BODEGA_SIR_205_SALIDAS_BODEGA

        // Foreign keys

        /// <summary>
        /// Parent CatEmp pointed by [SIR_205_SALIDAS_BODEGA].([NIdEmpleado]) (FK_SIR_205_SALIDAS_BODEGA_cat_emp)
        /// </summary>
        public virtual CatEmp CatEmp { get; set; } // FK_SIR_205_SALIDAS_BODEGA_cat_emp

        /// <summary>
        /// Parent CatProv pointed by [SIR_205_SALIDAS_BODEGA].([NIdTransportista]) (FK_SIR_205_SALIDAS_BODEGA_cat_prov)
        /// </summary>
        public virtual CatProv CatProv_NIdTransportista { get; set; } // FK_SIR_205_SALIDAS_BODEGA_cat_prov

        /// <summary>
        /// Parent CatProv pointed by [SIR_205_SALIDAS_BODEGA].([NIdTransportistaMex]) (FK_SIR_205_SALIDAS_BODEGA_TRANSPORTISTA_MEXICANO)
        /// </summary>
        public virtual CatProv CatProv_NIdTransportistaMex { get; set; } // FK_SIR_205_SALIDAS_BODEGA_TRANSPORTISTA_MEXICANO

        /// <summary>
        /// Parent CatUsr pointed by [SIR_205_SALIDAS_BODEGA].([NIdUsuarioEd]) (FK_SIR_205_SALIDAS_BODEGA_cat_usr)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_205_SALIDAS_BODEGA_cat_usr

        /// <summary>
        /// Parent SIR_Sir09TiposContenedor pointed by [SIR_205_SALIDAS_BODEGA].([NIdTipoCont09]) (FK_SIR_205_SALIDAS_BODEGA_SIR_09_TIPOS_CONTENEDOR)
        /// </summary>
        public virtual SIR_Sir09TiposContenedor SIR_Sir09TiposContenedor { get; set; } // FK_SIR_205_SALIDAS_BODEGA_SIR_09_TIPOS_CONTENEDOR

        /// <summary>
        /// Parent SIR_Sir284EntidadesFederativa pointed by [SIR_205_SALIDAS_BODEGA].([NIdEntFedLicenciaChofer284]) (FK_SIR_205_SALIDAS_BODEGA_SIR_284_ENTIDADES_FEDERATIVAS)
        /// </summary>
        public virtual SIR_Sir284EntidadesFederativa SIR_Sir284EntidadesFederativa { get; set; } // FK_SIR_205_SALIDAS_BODEGA_SIR_284_ENTIDADES_FEDERATIVAS

        /// <summary>
        /// Parent SIR_Sir648TiposProgramacionSalidasRt pointed by [SIR_205_SALIDAS_BODEGA].([NIdTipoProgramacion648]) ([FK_SIR_205_SALIDAS_BODEGA_SIR_648_TIPOS_PROGRAMACION_SALIDAS_RT)
        /// </summary>
        public virtual SIR_Sir648TiposProgramacionSalidasRt SIR_Sir648TiposProgramacionSalidasRt { get; set; } // [FK_SIR_205_SALIDAS_BODEGA_SIR_648_TIPOS_PROGRAMACION_SALIDAS_RT

        /// <summary>
        /// Parent SIR_Sir71SucursalPatenteAduana pointed by [SIR_205_SALIDAS_BODEGA].([NIdSucPatAdu71]) (FK_SIR_205_SALIDAS_BODEGA_SIR_71_SUCURSAL_PATENTE_ADUANA)
        /// </summary>
        public virtual SIR_Sir71SucursalPatenteAduana SIR_Sir71SucursalPatenteAduana { get; set; } // FK_SIR_205_SALIDAS_BODEGA_SIR_71_SUCURSAL_PATENTE_ADUANA

        public SIR_Sir205SalidasBodega()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            BFletePagado = false;
            SIR_Sir135CargaSueltaDetalle = new System.Collections.Generic.List<SIR_Sir135CargaSueltaDetalle>();
            SIR_Sir300ControlesVehiculare = new System.Collections.Generic.List<SIR_Sir300ControlesVehiculare>();
            SIR_Sir366CaracSalidasBodega = new System.Collections.Generic.List<SIR_Sir366CaracSalidasBodega>();
            SIR_Sir602EntradaSalidaPatio = new System.Collections.Generic.List<SIR_Sir602EntradaSalidaPatio>();
            SIR_Sir661ControlCargaSalida = new System.Collections.Generic.List<SIR_Sir661ControlCargaSalida>();
            SIR_Sir742IngresosEgresosDm = new System.Collections.Generic.List<SIR_Sir742IngresosEgresosDm>();
            SIR_Sir743OrdenSalidaManifiestoDm = new System.Collections.Generic.List<SIR_Sir743OrdenSalidaManifiestoDm>();
            SIR_Sir755NotificacionesAppTransportista = new System.Collections.Generic.List<SIR_Sir755NotificacionesAppTransportista>();
            SIR_Sir846FotosSalidaBodega = new System.Collections.Generic.List<SIR_Sir846FotosSalidaBodega>();
        }
    }

}
// </auto-generated>