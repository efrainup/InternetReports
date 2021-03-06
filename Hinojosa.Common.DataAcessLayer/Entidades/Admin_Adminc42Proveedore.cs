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

    // ADMINC_42_PROVEEDORES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Admin_Adminc42Proveedore
    {
        [Required]
        [Display(Name = "N ID proveedor 42")]
        public int NIdProveedor42 { get; set; } // nIdProveedor42 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(12)]
        [StringLength(12)]
        [Display(Name = "S clave")]
        public string SClave { get; set; } // sClave (length: 12)

        [MaxLength(120)]
        [StringLength(120)]
        [Display(Name = "S razon social")]
        public string SRazonSocial { get; set; } // sRazonSocial (length: 120)

        [MaxLength(17)]
        [StringLength(17)]
        [Display(Name = "S ID fiscal")]
        public string SIdFiscal { get; set; } // sIdFiscal (length: 17)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S contacto")]
        public string SContacto { get; set; } // sContacto (length: 50)

        [Required]
        [Display(Name = "B activo")]
        public bool BActivo { get; set; } // bActivo

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S nombre")]
        public string SNombre { get; set; } // sNombre (length: 50)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S apellido paterno")]
        public string SApellidoPaterno { get; set; } // sApellidoPaterno (length: 50)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S apellido materno")]
        public string SApellidoMaterno { get; set; } // sApellidoMaterno (length: 50)

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S curp")]
        public string SCurp { get; set; } // sCURP (length: 20)

        [Display(Name = "N ID adu sec 06")]
        public int? NIdAduSec06 { get; set; } // nIdAduSec06

        [Display(Name = "N dias cred")]
        public int? NDiasCred { get; set; } // nDiasCred

        [Display(Name = "N ID cuenta 27")]
        public int? NIdCuenta27 { get; set; } // nIdCuenta27

        [MaxLength(120)]
        [StringLength(120)]
        [Display(Name = "S nombre comercial")]
        public string SNombreComercial { get; set; } // sNombreComercial (length: 120)

        // Reverse navigation

        /// <summary>
        /// Child Admin_Admina11Empresa (Many-to-Many) mapped by table [ADMINC_34_PROVEEDORES_EMPRESAS]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Admin_Admina11Empresa> Admin_Admina11Empresa { get; set; } // Many to many mapping
        /// <summary>
        /// Child Admin_Adminc07Cliente where [ADMINC_07_CLIENTES].[nIdProv42] point to this entity (FK_ADMINC_07_CLIENTES_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Admin_Adminc07Cliente> Admin_Adminc07Cliente { get; set; } // ADMINC_07_CLIENTES.FK_ADMINC_07_CLIENTES_ADMINC_42_PROVEEDORES
        /// <summary>
        /// Child Admin_Adminc10TiposProveedore (Many-to-Many) mapped by table [ADMINC_26_PROV_TIPOS_PROV]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Admin_Adminc10TiposProveedore> Admin_Adminc10TiposProveedore { get; set; } // Many to many mapping
        /// <summary>
        /// Child Admin_Adminc24ProvCaracteristica where [ADMINC_24_PROV_CARACTERISTICAS].[nIdProv42] point to this entity (FK_ADMINC_24_PROV_CARACTERISTICAS_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Admin_Adminc24ProvCaracteristica> Admin_Adminc24ProvCaracteristica { get; set; } // ADMINC_24_PROV_CARACTERISTICAS.FK_ADMINC_24_PROV_CARACTERISTICAS_ADMINC_42_PROVEEDORES
        /// <summary>
        /// Child Admin_Adminc43ProveedoresDir where [ADMINC_43_PROVEEDORES_DIR].[nIdProveedor42] point to this entity (FK_ADMINC_43_PROVEEDORES_DIR_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Admin_Adminc43ProveedoresDir> Admin_Adminc43ProveedoresDir { get; set; } // ADMINC_43_PROVEEDORES_DIR.FK_ADMINC_43_PROVEEDORES_DIR_ADMINC_42_PROVEEDORES
        /// <summary>
        /// Child Admin_Adminc44ProveedoresMedio where [ADMINC_44_PROVEEDORES_MEDIOS].[nIdProveedor42] point to this entity (FK_ADMINC_44_PROVEEDORES_MEDIOS_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Admin_Adminc44ProveedoresMedio> Admin_Adminc44ProveedoresMedio { get; set; } // ADMINC_44_PROVEEDORES_MEDIOS.FK_ADMINC_44_PROVEEDORES_MEDIOS_ADMINC_42_PROVEEDORES
        /// <summary>
        /// Child Admin_Admino10PagosCliente where [ADMINO_10_PAGOS_CLIENTES].[nIdProv42] point to this entity (FK_ADMINO_10_PAGOS_CLIENTES_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Admin_Admino10PagosCliente> Admin_Admino10PagosCliente { get; set; } // ADMINO_10_PAGOS_CLIENTES.FK_ADMINO_10_PAGOS_CLIENTES_ADMINC_42_PROVEEDORES
        /// <summary>
        /// Child Admin_Admino15CuentasGasto where [ADMINO_15_CUENTAS_GASTOS].[nIdProv42] point to this entity (FK_ADMINO_15_CUENTAS_GASTOS_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Admin_Admino15CuentasGasto> Admin_Admino15CuentasGasto_NIdProv42 { get; set; } // ADMINO_15_CUENTAS_GASTOS.FK_ADMINO_15_CUENTAS_GASTOS_ADMINC_42_PROVEEDORES
        /// <summary>
        /// Child Admin_Admino15CuentasGasto where [ADMINO_15_CUENTAS_GASTOS].[nIdTransportista42] point to this entity (FK_ADMINO_15_CUENTAS_GASTOS_ADMINC_42_PROVEEDORES1)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Admin_Admino15CuentasGasto> Admin_Admino15CuentasGasto_NIdTransportista42 { get; set; } // ADMINO_15_CUENTAS_GASTOS.FK_ADMINO_15_CUENTAS_GASTOS_ADMINC_42_PROVEEDORES1
        /// <summary>
        /// Child SIR_Sir120SolicitudCheque where [SIR_120_SOLICITUD_CHEQUES].[nIdProveedorAdm] point to this entity (FK_SIR_120_SOLICITUD_CHEQUES_ADMINC_42_PROVEEDORES_Prov)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir120SolicitudCheque> SIR_Sir120SolicitudCheque_NIdProveedorAdm { get; set; } // SIR_120_SOLICITUD_CHEQUES.FK_SIR_120_SOLICITUD_CHEQUES_ADMINC_42_PROVEEDORES_Prov
        /// <summary>
        /// Child SIR_Sir120SolicitudCheque where [SIR_120_SOLICITUD_CHEQUES].[nIdProvGiroAdm] point to this entity (FK_SIR_120_SOLICITUD_CHEQUES_ADMINC_42_PROVEEDORES_ProvGiro)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir120SolicitudCheque> SIR_Sir120SolicitudCheque_NIdProvGiroAdm { get; set; } // SIR_120_SOLICITUD_CHEQUES.FK_SIR_120_SOLICITUD_CHEQUES_ADMINC_42_PROVEEDORES_ProvGiro
        /// <summary>
        /// Child SIR_Sir128PedidosCliente where [SIR_128_PEDIDOS_CLIENTES].[nIdTransportista42] point to this entity (FK_SIR_128_PEDIDOS_CLIENTES_ADMINC_42_PROVEEDORES1)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir128PedidosCliente> SIR_Sir128PedidosCliente { get; set; } // SIR_128_PEDIDOS_CLIENTES.FK_SIR_128_PEDIDOS_CLIENTES_ADMINC_42_PROVEEDORES1
        /// <summary>
        /// Child SIR_Sir161ProgPreviosRef where [SIR_161_PROG_PREVIOS_REF].[nIdTerminal42] point to this entity (FK_SIR_161_PROG_PREVIOS_REF_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir161ProgPreviosRef> SIR_Sir161ProgPreviosRef { get; set; } // SIR_161_PROG_PREVIOS_REF.FK_SIR_161_PROG_PREVIOS_REF_ADMINC_42_PROVEEDORES
        /// <summary>
        /// Child SIR_Sir175Transporte where [SIR_175_TRANSPORTES].[nIdTransportista42] point to this entity (FK_SIR_175_TRANSPORTES_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir175Transporte> SIR_Sir175Transporte { get; set; } // SIR_175_TRANSPORTES.FK_SIR_175_TRANSPORTES_ADMINC_42_PROVEEDORES
        /// <summary>
        /// Child SIR_Sir179PedimentoTransporte where [SIR_179_PEDIMENTO_TRANSPORTE].[nIdTransportista42] point to this entity (FK_SIR_179_PEDIMENTO_TRANSPORTE_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir179PedimentoTransporte> SIR_Sir179PedimentoTransporte { get; set; } // SIR_179_PEDIMENTO_TRANSPORTE.FK_SIR_179_PEDIMENTO_TRANSPORTE_ADMINC_42_PROVEEDORES
        /// <summary>
        /// Child SIR_Sir228RegistrosSagarpa where [SIR_228_REGISTROS_SAGARPA].[nIdTransportista42] point to this entity (FK_SIR_228_REGISTROS_SAGARPA_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir228RegistrosSagarpa> SIR_Sir228RegistrosSagarpa { get; set; } // SIR_228_REGISTROS_SAGARPA.FK_SIR_228_REGISTROS_SAGARPA_ADMINC_42_PROVEEDORES
        /// <summary>
        /// Child SIR_Sir236CompraCandado where [SIR_236_COMPRA_CANDADOS].[nIdProveedor42] point to this entity (FK_SIR_236_COMPRA_CANDADOS_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir236CompraCandado> SIR_Sir236CompraCandado { get; set; } // SIR_236_COMPRA_CANDADOS.FK_SIR_236_COMPRA_CANDADOS_ADMINC_42_PROVEEDORES
        /// <summary>
        /// Child SIR_Sir305Corresponsale where [SIR_305_CORRESPONSALES].[nIdProveedor42] point to this entity (FK_SIR_305_CORRESPONSALES_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir305Corresponsale> SIR_Sir305Corresponsale { get; set; } // SIR_305_CORRESPONSALES.FK_SIR_305_CORRESPONSALES_ADMINC_42_PROVEEDORES
        /// <summary>
        /// Child SIR_Sir41RegTransporte where [SIR_41_REG_TRANSPORTES].[nIdAlmacenSalida42] point to this entity (FK_SIR_41_REG_TRANSPORTES_ADMINC_42_PROVEEDORES_nIdAlmacenSalida42)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir41RegTransporte> SIR_Sir41RegTransporte_NIdAlmacenSalida42 { get; set; } // SIR_41_REG_TRANSPORTES.FK_SIR_41_REG_TRANSPORTES_ADMINC_42_PROVEEDORES_nIdAlmacenSalida42
        /// <summary>
        /// Child SIR_Sir41RegTransporte where [SIR_41_REG_TRANSPORTES].[nIdConsignataria42] point to this entity (FK_SIR_41_REG_TRANSPORTES_ADMINC_42_PROVEEDORES_nIdConsignataria42)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir41RegTransporte> SIR_Sir41RegTransporte_NIdConsignataria42 { get; set; } // SIR_41_REG_TRANSPORTES.FK_SIR_41_REG_TRANSPORTES_ADMINC_42_PROVEEDORES_nIdConsignataria42
        /// <summary>
        /// Child SIR_Sir41RegTransporte where [SIR_41_REG_TRANSPORTES].[nIdTerminal42] point to this entity (FK_SIR_41_REG_TRANSPORTES_ADMINC_42_PROVEEDORES_nIdTerminal42)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir41RegTransporte> SIR_Sir41RegTransporte_NIdTerminal42 { get; set; } // SIR_41_REG_TRANSPORTES.FK_SIR_41_REG_TRANSPORTES_ADMINC_42_PROVEEDORES_nIdTerminal42
        /// <summary>
        /// Child SIR_Sir589BitacoraCargaTerminal where [SIR_589_BITACORA_CARGA_TERMINAL].[nIdTerminal42] point to this entity (FK_SIR_589_BITACORA_CARGA_TERMINAL_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir589BitacoraCargaTerminal> SIR_Sir589BitacoraCargaTerminal { get; set; } // SIR_589_BITACORA_CARGA_TERMINAL.FK_SIR_589_BITACORA_CARGA_TERMINAL_ADMINC_42_PROVEEDORES
        /// <summary>
        /// Child SIR_Sir60Referencia where [SIR_60_REFERENCIAS].[nIdNaviera42] point to this entity (FK_SIR_60_REFERENCIAS_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir60Referencia> SIR_Sir60Referencia_NIdNaviera42 { get; set; } // SIR_60_REFERENCIAS.FK_SIR_60_REFERENCIAS_ADMINC_42_PROVEEDORES
        /// <summary>
        /// Child SIR_Sir60Referencia where [SIR_60_REFERENCIAS].[nIdTransportista42] point to this entity (FK_SIR_60_REFERENCIAS_ADMINC_42_PROVEEDORES_Transportista)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir60Referencia> SIR_Sir60Referencia_NIdTransportista42 { get; set; } // SIR_60_REFERENCIAS.FK_SIR_60_REFERENCIAS_ADMINC_42_PROVEEDORES_Transportista
        /// <summary>
        /// Child SIR_Sir656OrdenTrabajoServicio where [SIR_656_ORDEN_TRABAJO_SERVICIO].[nIdProveedorAdmin42] point to this entity (FK_SIR_656_ORDEN_TRABAJO_SERVICIO_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir656OrdenTrabajoServicio> SIR_Sir656OrdenTrabajoServicio { get; set; } // SIR_656_ORDEN_TRABAJO_SERVICIO.FK_SIR_656_ORDEN_TRABAJO_SERVICIO_ADMINC_42_PROVEEDORES
        /// <summary>
        /// Child SIR_Sir741ManifiestoDeViajeDm where [SIR_741_MANIFIESTO_DE_VIAJE_DMS].[nIdProveedor42] point to this entity (FK_SIR_741_MANIFIESTO_DE_VIAJE_DMS_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir741ManifiestoDeViajeDm> SIR_Sir741ManifiestoDeViajeDm { get; set; } // SIR_741_MANIFIESTO_DE_VIAJE_DMS.FK_SIR_741_MANIFIESTO_DE_VIAJE_DMS_ADMINC_42_PROVEEDORES
        /// <summary>
        /// Child SIR_Sir74ConocimientosMaritimo where [SIR_74_CONOCIMIENTOS_MARITIMOS].[nIdRecinto42] point to this entity (FK_SIR_74_CONOCIMIENTOS_MARITIMOS_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir74ConocimientosMaritimo> SIR_Sir74ConocimientosMaritimo { get; set; } // SIR_74_CONOCIMIENTOS_MARITIMOS.FK_SIR_74_CONOCIMIENTOS_MARITIMOS_ADMINC_42_PROVEEDORES
        /// <summary>
        /// Child SIR_Sir76Contenedore where [SIR_76_CONTENEDORES].[nIdTransSalida42] point to this entity (FK_SIR_76_CONTENEDORES_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir76Contenedore> SIR_Sir76Contenedore { get; set; } // SIR_76_CONTENEDORES.FK_SIR_76_CONTENEDORES_ADMINC_42_PROVEEDORES
        /// <summary>
        /// Child SIRAdmin_Sira42ConfProgServNaviera where [SIRA_42_CONF_PROG_SERV_NAVIERAS].[nIdProveedor42] point to this entity (FK_SIRA_42_CONF_PROG_SERV_NAVIERAS_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira42ConfProgServNaviera> SIRAdmin_Sira42ConfProgServNaviera { get; set; } // SIRA_42_CONF_PROG_SERV_NAVIERAS.FK_SIRA_42_CONF_PROG_SERV_NAVIERAS_ADMINC_42_PROVEEDORES
        /// <summary>
        /// Child SIRAdmin_Sira45ConfProgServRecinto where [SIRA_45_CONF_PROG_SERV_RECINTO].[nIdRecinto42] point to this entity (FK_SIRA_45_CONF_PROG_SERV_RECINTO_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira45ConfProgServRecinto> SIRAdmin_Sira45ConfProgServRecinto { get; set; } // SIRA_45_CONF_PROG_SERV_RECINTO.FK_SIRA_45_CONF_PROG_SERV_RECINTO_ADMINC_42_PROVEEDORES
        /// <summary>
        /// Child SIRAdmin_Sira48DetalleProgServicio where [SIRA_48_DETALLE_PROG_SERVICIOS].[nIdRecDestino42] point to this entity (FK_SIRA_48_DETALLE_PROG_SERVICIOS_ADMINC_42_PROVEEDORES_DESTINO)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira48DetalleProgServicio> SIRAdmin_Sira48DetalleProgServicio_NIdRecDestino42 { get; set; } // SIRA_48_DETALLE_PROG_SERVICIOS.FK_SIRA_48_DETALLE_PROG_SERVICIOS_ADMINC_42_PROVEEDORES_DESTINO
        /// <summary>
        /// Child SIRAdmin_Sira48DetalleProgServicio where [SIRA_48_DETALLE_PROG_SERVICIOS].[nIdRecOrigen42] point to this entity (FK_SIRA_48_DETALLE_PROG_SERVICIOS_ADMINC_42_PROVEEDORES_ORIGEN)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira48DetalleProgServicio> SIRAdmin_Sira48DetalleProgServicio_NIdRecOrigen42 { get; set; } // SIRA_48_DETALLE_PROG_SERVICIOS.FK_SIRA_48_DETALLE_PROG_SERVICIOS_ADMINC_42_PROVEEDORES_ORIGEN
        /// <summary>
        /// Child SIRAdmin_Sira50Booking where [SIRA_50_BOOKING].[nIdAgenteAdu42] point to this entity (FK_SIRA_50_BOOKING_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira50Booking> SIRAdmin_Sira50Booking { get; set; } // SIRA_50_BOOKING.FK_SIRA_50_BOOKING_ADMINC_42_PROVEEDORES
        /// <summary>
        /// Child SIRAdmin_Sira51BookingContenedor where [SIRA_51_BOOKING_CONTENEDOR].[nIdProveedor42] point to this entity (FK_SIRA_51_BOOKING_CONTENEDOR_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira51BookingContenedor> SIRAdmin_Sira51BookingContenedor_NIdProveedor42 { get; set; } // SIRA_51_BOOKING_CONTENEDOR.FK_SIRA_51_BOOKING_CONTENEDOR_ADMINC_42_PROVEEDORES
        /// <summary>
        /// Child SIRAdmin_Sira51BookingContenedor where [SIRA_51_BOOKING_CONTENEDOR].[nIdTerminalSalida42] point to this entity (FK_SIRA_51_BOOKING_CONTENEDOR_ADMINC_42_PROVEEDORES_TerminalSalida)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira51BookingContenedor> SIRAdmin_Sira51BookingContenedor_NIdTerminalSalida42 { get; set; } // SIRA_51_BOOKING_CONTENEDOR.FK_SIRA_51_BOOKING_CONTENEDOR_ADMINC_42_PROVEEDORES_TerminalSalida

        // Foreign keys

        /// <summary>
        /// Parent Admin_Adminc06AduanaSec pointed by [ADMINC_42_PROVEEDORES].([NIdAduSec06]) (FK_ADMINC_42_PROVEEDORES_ADMINC_06_ADUANA_SEC)
        /// </summary>
        public virtual Admin_Adminc06AduanaSec Admin_Adminc06AduanaSec { get; set; } // FK_ADMINC_42_PROVEEDORES_ADMINC_06_ADUANA_SEC

        /// <summary>
        /// Parent Admin_Adminc27Cuenta pointed by [ADMINC_42_PROVEEDORES].([NIdCuenta27]) (FK_ADMINC_42_PROVEEDORES_ADMINC_27_CUENTAS)
        /// </summary>
        public virtual Admin_Adminc27Cuenta Admin_Adminc27Cuenta { get; set; } // FK_ADMINC_42_PROVEEDORES_ADMINC_27_CUENTAS

        public Admin_Adminc42Proveedore()
        {
            Admin_Adminc07Cliente = new System.Collections.Generic.List<Admin_Adminc07Cliente>();
            Admin_Adminc24ProvCaracteristica = new System.Collections.Generic.List<Admin_Adminc24ProvCaracteristica>();
            Admin_Adminc43ProveedoresDir = new System.Collections.Generic.List<Admin_Adminc43ProveedoresDir>();
            Admin_Adminc44ProveedoresMedio = new System.Collections.Generic.List<Admin_Adminc44ProveedoresMedio>();
            Admin_Admino10PagosCliente = new System.Collections.Generic.List<Admin_Admino10PagosCliente>();
            Admin_Admino15CuentasGasto_NIdProv42 = new System.Collections.Generic.List<Admin_Admino15CuentasGasto>();
            Admin_Admino15CuentasGasto_NIdTransportista42 = new System.Collections.Generic.List<Admin_Admino15CuentasGasto>();
            SIR_Sir120SolicitudCheque_NIdProveedorAdm = new System.Collections.Generic.List<SIR_Sir120SolicitudCheque>();
            SIR_Sir120SolicitudCheque_NIdProvGiroAdm = new System.Collections.Generic.List<SIR_Sir120SolicitudCheque>();
            SIR_Sir128PedidosCliente = new System.Collections.Generic.List<SIR_Sir128PedidosCliente>();
            SIR_Sir161ProgPreviosRef = new System.Collections.Generic.List<SIR_Sir161ProgPreviosRef>();
            SIR_Sir175Transporte = new System.Collections.Generic.List<SIR_Sir175Transporte>();
            SIR_Sir179PedimentoTransporte = new System.Collections.Generic.List<SIR_Sir179PedimentoTransporte>();
            SIR_Sir228RegistrosSagarpa = new System.Collections.Generic.List<SIR_Sir228RegistrosSagarpa>();
            SIR_Sir236CompraCandado = new System.Collections.Generic.List<SIR_Sir236CompraCandado>();
            SIR_Sir305Corresponsale = new System.Collections.Generic.List<SIR_Sir305Corresponsale>();
            SIR_Sir41RegTransporte_NIdAlmacenSalida42 = new System.Collections.Generic.List<SIR_Sir41RegTransporte>();
            SIR_Sir41RegTransporte_NIdConsignataria42 = new System.Collections.Generic.List<SIR_Sir41RegTransporte>();
            SIR_Sir41RegTransporte_NIdTerminal42 = new System.Collections.Generic.List<SIR_Sir41RegTransporte>();
            SIR_Sir589BitacoraCargaTerminal = new System.Collections.Generic.List<SIR_Sir589BitacoraCargaTerminal>();
            SIR_Sir60Referencia_NIdNaviera42 = new System.Collections.Generic.List<SIR_Sir60Referencia>();
            SIR_Sir60Referencia_NIdTransportista42 = new System.Collections.Generic.List<SIR_Sir60Referencia>();
            SIR_Sir656OrdenTrabajoServicio = new System.Collections.Generic.List<SIR_Sir656OrdenTrabajoServicio>();
            SIR_Sir74ConocimientosMaritimo = new System.Collections.Generic.List<SIR_Sir74ConocimientosMaritimo>();
            SIR_Sir741ManifiestoDeViajeDm = new System.Collections.Generic.List<SIR_Sir741ManifiestoDeViajeDm>();
            SIR_Sir76Contenedore = new System.Collections.Generic.List<SIR_Sir76Contenedore>();
            SIRAdmin_Sira42ConfProgServNaviera = new System.Collections.Generic.List<SIRAdmin_Sira42ConfProgServNaviera>();
            SIRAdmin_Sira45ConfProgServRecinto = new System.Collections.Generic.List<SIRAdmin_Sira45ConfProgServRecinto>();
            SIRAdmin_Sira48DetalleProgServicio_NIdRecDestino42 = new System.Collections.Generic.List<SIRAdmin_Sira48DetalleProgServicio>();
            SIRAdmin_Sira48DetalleProgServicio_NIdRecOrigen42 = new System.Collections.Generic.List<SIRAdmin_Sira48DetalleProgServicio>();
            SIRAdmin_Sira50Booking = new System.Collections.Generic.List<SIRAdmin_Sira50Booking>();
            SIRAdmin_Sira51BookingContenedor_NIdProveedor42 = new System.Collections.Generic.List<SIRAdmin_Sira51BookingContenedor>();
            SIRAdmin_Sira51BookingContenedor_NIdTerminalSalida42 = new System.Collections.Generic.List<SIRAdmin_Sira51BookingContenedor>();
            Admin_Adminc10TiposProveedore = new System.Collections.Generic.List<Admin_Adminc10TiposProveedore>();
            Admin_Admina11Empresa = new System.Collections.Generic.List<Admin_Admina11Empresa>();
        }
    }

}
// </auto-generated>
