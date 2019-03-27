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

    // SIR_76_CONTENEDORES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir76Contenedore
    {
        [Required]
        [Display(Name = "N ID contenedor 76")]
        public int NIdContenedor76 { get; set; } // nIdContenedor76 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(14)]
        [StringLength(14)]
        [Display(Name = "S numero")]
        public string SNumero { get; set; } // sNumero (length: 14)

        [Display(Name = "N ID referencia 60")]
        public int? NIdReferencia60 { get; set; } // nIdReferencia60

        [Display(Name = "N ID bl 74")]
        public int? NIdBl74 { get; set; } // nIdBL74

        [Required]
        [Display(Name = "N peso")]
        public decimal NPeso { get; set; } // nPeso

        [Required]
        [Display(Name = "N ID tipo cont 09")]
        public int NIdTipoCont09 { get; set; } // nIdTipoCont09

        [Display(Name = "N ID articulo 106")]
        public int? NIdArticulo106 { get; set; } // nIdArticulo106

        [Required]
        [Display(Name = "N estado")]
        public byte NEstado { get; set; } // nEstado

        [Required]
        [Display(Name = "N condicion arribo")]
        public byte NCondicionArribo { get; set; } // nCondicionArribo

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S numero eir")]
        public string SNumeroEir { get; set; } // sNumeroEIR (length: 20)

        [Required]
        [Display(Name = "B es mat peligroso")]
        public bool BEsMatPeligroso { get; set; } // bEsMatPeligroso

        [Display(Name = "D fecha previo")]
        public System.DateTime? DFechaPrevio { get; set; } // dFechaPrevio

        [Display(Name = "D fecha despacho")]
        public System.DateTime? DFechaDespacho { get; set; } // dFechaDespacho

        [Display(Name = "D fecha descarga")]
        public System.DateTime? DFechaDescarga { get; set; } // dFechaDescarga

        [Display(Name = "D fecha entrega cont")]
        public System.DateTime? DFechaEntregaCont { get; set; } // dFechaEntregaCont

        [Display(Name = "N ID usuario previo")]
        public int? NIdUsuarioPrevio { get; set; } // nIdUsuarioPrevio

        [Display(Name = "N ID usuario despacho")]
        public int? NIdUsuarioDespacho { get; set; } // nIdUsuarioDespacho

        [Display(Name = "N ID medio salida 05")]
        public int? NIdMedioSalida05 { get; set; } // nIdMedioSalida05

        [Display(Name = "N ID transportista salida")]
        public int? NIdTransportistaSalida { get; set; } // nIdTransportistaSalida

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S matricula trans s")]
        public string SMatriculaTransS { get; set; } // sMatriculaTransS (length: 30)

        [Display(Name = "D fecha entrega merc")]
        public System.DateTime? DFechaEntregaMerc { get; set; } // dFechaEntregaMerc

        [Display(Name = "N dias libres demoras")]
        public int? NDiasLibresDemoras { get; set; } // nDiasLibresDemoras

        [Display(Name = "D fecha eir")]
        public System.DateTime? DFechaEir { get; set; } // dFechaEIR

        [Display(Name = "N temperatura")]
        public short? NTemperatura { get; set; } // nTemperatura

        [Display(Name = "N unidad temp")]
        public byte? NUnidadTemp { get; set; } // nUnidadTemp

        [Display(Name = "N tara")]
        public decimal? NTara { get; set; } // nTara

        [Display(Name = "N ID det sel ale 89")]
        public int? NIdDetSelAle89 { get; set; } // nIdDetSelAle89

        [Display(Name = "D fecha ingreso")]
        public System.DateTime? DFechaIngreso { get; set; } // dFechaIngreso

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "N folio ingreso")]
        public string NFolioIngreso { get; set; } // nFolioIngreso (length: 30)

        [Required]
        [Display(Name = "N status vig")]
        public byte NStatusVig { get; set; } // nStatusVig

        [Display(Name = "N ID parte dos 150")]
        public int? NIdParteDos150 { get; set; } // nIdParteDos150

        [Display(Name = "N hc lave tipo cont")]
        public short? NHClaveTipoCont { get; set; } // nHClaveTipoCont

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S sello entrega")]
        public string SSelloEntrega { get; set; } // sSelloEntrega (length: 30)

        [Display(Name = "D sello entrega")]
        public System.DateTime? DSelloEntrega { get; set; } // dSelloEntrega

        [Display(Name = "D recibido calculo")]
        public System.DateTime? DRecibidoCalculo { get; set; } // dRecibidoCalculo

        [Display(Name = "D pago demoras")]
        public System.DateTime? DPagoDemoras { get; set; } // dPagoDemoras

        [Display(Name = "D factura demoras")]
        public System.DateTime? DFacturaDemoras { get; set; } // dFacturaDemoras

        [Display(Name = "N deposito garantia")]
        public decimal? NDepositoGarantia { get; set; } // nDepositoGarantia

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S sello remesa")]
        public string SSelloRemesa { get; set; } // sSelloRemesa (length: 50)

        [Display(Name = "N ID usu previo 01")]
        public int? NIdUsuPrevio01 { get; set; } // nIdUsuPrevio01

        [Display(Name = "N ID usu despacho 01")]
        public int? NIdUsuDespacho01 { get; set; } // nIdUsuDespacho01

        [Display(Name = "N ID trans salida 42")]
        public int? NIdTransSalida42 { get; set; } // nIdTransSalida42

        [Display(Name = "B articulo 3")]
        public bool? BArticulo3 { get; set; } // bArticulo3

        [Display(Name = "N peso de contenedor")]
        public decimal? NPesoDeContenedor { get; set; } // nPesoDeContenedor

        [Display(Name = "N izadas")]
        public decimal? NIzadas { get; set; } // nIzadas

        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "S imo s")]
        public string SImOs { get; set; } // sIMOs (length: 80)

        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "S un s")]
        public string SUNs { get; set; } // sUNs (length: 80)

        [Display(Name = "N ID naviera")]
        public int? NIdNaviera { get; set; } // nIdNaviera

        [Display(Name = "N importe demoras")]
        public decimal? NImporteDemoras { get; set; } // nImporteDemoras

        [Display(Name = "B desconsolidar")]
        public decimal? BDesconsolidar { get; set; } // bDesconsolidar

        [Display(Name = "B parte dos")]
        public bool? BParteDos { get; set; } // bParteDos

        [DataType(DataType.DateTime)]
        [Display(Name = "D doc ferrocarril")]
        public System.DateTime? DDocFerrocarril { get; set; } // dDocFerrocarril

        [DataType(DataType.DateTime)]
        [Display(Name = "D carga ferrocarril")]
        public System.DateTime? DCargaFerrocarril { get; set; } // dCargaFerrocarril

        [DataType(DataType.DateTime)]
        [Display(Name = "D mercancia ferrocarril")]
        public System.DateTime? DMercanciaFerrocarril { get; set; } // dMercanciaFerrocarril

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir107ContenedorSello where [SIR_107_CONTENEDOR_SELLOS].[nIdContenedor76] point to this entity (FK_SIR_107_CONTENEDOR_SELLOS_SIR_76_CONTENEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir107ContenedorSello> SIR_Sir107ContenedorSello { get; set; } // SIR_107_CONTENEDOR_SELLOS.FK_SIR_107_CONTENEDOR_SELLOS_SIR_76_CONTENEDORES
        /// <summary>
        /// Child SIR_Sir160ProgPreviosCont where [SIR_160_PROG_PREVIOS_CONT].[nIdContenedor76] point to this entity (FK_SIR_160_PROG_PREVIOS_CONT_SIR_76_CONTENEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir160ProgPreviosCont> SIR_Sir160ProgPreviosCont { get; set; } // SIR_160_PROG_PREVIOS_CONT.FK_SIR_160_PROG_PREVIOS_CONT_SIR_76_CONTENEDORES
        /// <summary>
        /// Child SIR_Sir171ContSolTransporte where [SIR_171_CONT_SOL_TRANSPORTE].[nIdContenedor76] point to this entity (FK_SIR_171_CONT_SOL_TRANSPORTE_SIR_76_CONTENEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir171ContSolTransporte> SIR_Sir171ContSolTransporte { get; set; } // SIR_171_CONT_SOL_TRANSPORTE.FK_SIR_171_CONT_SOL_TRANSPORTE_SIR_76_CONTENEDORES
        /// <summary>
        /// Child SIR_Sir173PrevioContResultado where [SIR_173_PREVIO_CONT_RESULTADO].[nIdContenedor76] point to this entity (FK_SIR_173_PREVIO_CONT_RESULTADO_SIR_76_CONTENEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir173PrevioContResultado> SIR_Sir173PrevioContResultado { get; set; } // SIR_173_PREVIO_CONT_RESULTADO.FK_SIR_173_PREVIO_CONT_RESULTADO_SIR_76_CONTENEDORES
        /// <summary>
        /// Child SIR_Sir206Remesa where [SIR_206_REMESAS].[nIdContenedor76] point to this entity (FK_SIR_206_REMESAS_SIR_76_CONTENEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir206Remesa> SIR_Sir206Remesa_NIdContenedor76 { get; set; } // SIR_206_REMESAS.FK_SIR_206_REMESAS_SIR_76_CONTENEDORES
        /// <summary>
        /// Child SIR_Sir206Remesa (Many-to-Many) mapped by table [SIR_208_REMESA_CONTENEDOR]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir206Remesa> SIR_Sir206Remesa_NIdRem206 { get; set; } // Many to many mapping
        /// <summary>
        /// Child SIR_Sir237CompraCandadosDet where [SIR_237_COMPRA_CANDADOS_DET].[nIdContenedor76] point to this entity (FK_SIR_237_COMPRA_CANDADOS_DET_SIR_76_CONTENEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir237CompraCandadosDet> SIR_Sir237CompraCandadosDet { get; set; } // SIR_237_COMPRA_CANDADOS_DET.FK_SIR_237_COMPRA_CANDADOS_DET_SIR_76_CONTENEDORES
        /// <summary>
        /// Child SIR_Sir433ContenedoresPartesDo where [SIR_433_CONTENEDORES_PARTES_DOS].[nIdContenedor76] point to this entity (FK_SIR_433_CONTENEDORES_PARTES_DOS_SIR_76_CONTENEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir433ContenedoresPartesDo> SIR_Sir433ContenedoresPartesDo { get; set; } // SIR_433_CONTENEDORES_PARTES_DOS.FK_SIR_433_CONTENEDORES_PARTES_DOS_SIR_76_CONTENEDORES
        /// <summary>
        /// Child SIR_Sir47ContenedoresTarifa where [SIR_47_CONTENEDORES_TARIFAS].[nIdContenedor76] point to this entity (FK_SIR_47_CONTEDORES_TARIFAS_SIR_76_CONTENEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir47ContenedoresTarifa> SIR_Sir47ContenedoresTarifa { get; set; } // SIR_47_CONTENEDORES_TARIFAS.FK_SIR_47_CONTEDORES_TARIFAS_SIR_76_CONTENEDORES
        /// <summary>
        /// Child SIR_Sir571CalculoAlmacenaje (Many-to-Many) mapped by table [SIR_573_CALCULO_ALMACENAJE_CONTENEDORES]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir571CalculoAlmacenaje> SIR_Sir571CalculoAlmacenaje { get; set; } // Many to many mapping
        /// <summary>
        /// Child SIR_Sir58ObservContenedore where [SIR_58_OBSERV_CONTENEDORES].[nIdContenedor76] point to this entity (FK_SIR_58_CONTENEDORES_OBSERV_SIR_76_CONTENEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir58ObservContenedore> SIR_Sir58ObservContenedore { get; set; } // SIR_58_OBSERV_CONTENEDORES.FK_SIR_58_CONTENEDORES_OBSERV_SIR_76_CONTENEDORES
        /// <summary>
        /// Child SIR_Sir66CargaSuelta where [SIR_66_CARGA_SUELTA].[nIdContenedor76] point to this entity (FK_SIR_66_CARGA_SUELTA_SIR_76_CONTENEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir66CargaSuelta> SIR_Sir66CargaSuelta { get; set; } // SIR_66_CARGA_SUELTA.FK_SIR_66_CARGA_SUELTA_SIR_76_CONTENEDORES
        /// <summary>
        /// Child SIR_Sir813DodaContPedimento where [SIR_813_DODA_CONT_PEDIMENTO].[nIdContenedor76] point to this entity (FK_SIR_813_DODA_CONT_PEDIMENTO_SIR_76_CONTENEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir813DodaContPedimento> SIR_Sir813DodaContPedimento { get; set; } // SIR_813_DODA_CONT_PEDIMENTO.FK_SIR_813_DODA_CONT_PEDIMENTO_SIR_76_CONTENEDORES
        /// <summary>
        /// Child SIR_Sir87SolicitudServicio where [SIR_87_SOLICITUD_SERVICIOS].[nIdContenedor76] point to this entity (FK_SIR_87_SOLICITUD_SERVICIOS_SIR_76_CONTENEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir87SolicitudServicio> SIR_Sir87SolicitudServicio { get; set; } // SIR_87_SOLICITUD_SERVICIOS.FK_SIR_87_SOLICITUD_SERVICIOS_SIR_76_CONTENEDORES
        /// <summary>
        /// Child SIRAdmin_Sira49LiberacionContenedor where [SIRA_49_LIBERACION_CONTENEDOR].[nIdContenedor76] point to this entity (FK_SIRA_49_LIBERACION_CONTENEDOR_SIR_76_CONTENEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira49LiberacionContenedor> SIRAdmin_Sira49LiberacionContenedor { get; set; } // SIRA_49_LIBERACION_CONTENEDOR.FK_SIRA_49_LIBERACION_CONTENEDOR_SIR_76_CONTENEDORES
        /// <summary>
        /// Child SIRAdmin_Sira51BookingContenedor where [SIRA_51_BOOKING_CONTENEDOR].[nIdContenedor76] point to this entity (FK_SIRA_51_BOOKING_CONTENEDOR_SIR_76_CONTENEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira51BookingContenedor> SIRAdmin_Sira51BookingContenedor { get; set; } // SIRA_51_BOOKING_CONTENEDOR.FK_SIRA_51_BOOKING_CONTENEDOR_SIR_76_CONTENEDORES

        // Foreign keys

        /// <summary>
        /// Parent Admin_Admina01Usuario pointed by [SIR_76_CONTENEDORES].([NIdUsuDespacho01]) (FK_SIR_76_CONTENEDORES_ADMINA_01_USUARIOS_nIdUsuDespacho01)
        /// </summary>
        public virtual Admin_Admina01Usuario Admin_Admina01Usuario_NIdUsuDespacho01 { get; set; } // FK_SIR_76_CONTENEDORES_ADMINA_01_USUARIOS_nIdUsuDespacho01

        /// <summary>
        /// Parent Admin_Admina01Usuario pointed by [SIR_76_CONTENEDORES].([NIdUsuPrevio01]) (FK_SIR_76_CONTENEDORES_ADMINA_01_USUARIOS_nIdUsuPrevio01)
        /// </summary>
        public virtual Admin_Admina01Usuario Admin_Admina01Usuario_NIdUsuPrevio01 { get; set; } // FK_SIR_76_CONTENEDORES_ADMINA_01_USUARIOS_nIdUsuPrevio01

        /// <summary>
        /// Parent Admin_Adminc42Proveedore pointed by [SIR_76_CONTENEDORES].([NIdTransSalida42]) (FK_SIR_76_CONTENEDORES_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual Admin_Adminc42Proveedore Admin_Adminc42Proveedore { get; set; } // FK_SIR_76_CONTENEDORES_ADMINC_42_PROVEEDORES

        /// <summary>
        /// Parent CatProv pointed by [SIR_76_CONTENEDORES].([NIdNaviera]) (FK_SIR_76_CONTENEDORES_cat_prov)
        /// </summary>
        public virtual CatProv CatProv { get; set; } // FK_SIR_76_CONTENEDORES_cat_prov

        /// <summary>
        /// Parent CatUsr pointed by [SIR_76_CONTENEDORES].([NIdUsuarioDespacho]) (FK_SIR_76_CONTENEDORES_cat_usr_despacho)
        /// </summary>
        public virtual CatUsr CatUsr_NIdUsuarioDespacho { get; set; } // FK_SIR_76_CONTENEDORES_cat_usr_despacho

        /// <summary>
        /// Parent CatUsr pointed by [SIR_76_CONTENEDORES].([NIdUsuarioPrevio]) (FK_SIR_76_CONTENEDORES_cat_usr_previo)
        /// </summary>
        public virtual CatUsr CatUsr_NIdUsuarioPrevio { get; set; } // FK_SIR_76_CONTENEDORES_cat_usr_previo

        /// <summary>
        /// Parent SIR_Sir05MediosTransporte pointed by [SIR_76_CONTENEDORES].([NIdMedioSalida05]) (FK_SIR_76_CONTENEDORES_SIR_05_MEDIOS_TRANSPORTE)
        /// </summary>
        public virtual SIR_Sir05MediosTransporte SIR_Sir05MediosTransporte { get; set; } // FK_SIR_76_CONTENEDORES_SIR_05_MEDIOS_TRANSPORTE

        /// <summary>
        /// Parent SIR_Sir09TiposContenedor pointed by [SIR_76_CONTENEDORES].([NIdTipoCont09]) (FK_SIR_76_CONTENEDORES_SIR_09_TIPOS_CONTENEDOR)
        /// </summary>
        public virtual SIR_Sir09TiposContenedor SIR_Sir09TiposContenedor { get; set; } // FK_SIR_76_CONTENEDORES_SIR_09_TIPOS_CONTENEDOR

        /// <summary>
        /// Parent SIR_Sir106Articulo23 pointed by [SIR_76_CONTENEDORES].([NIdArticulo106]) (FK_SIR_76_CONTENEDORES_SIR_106_ARTICULO_23)
        /// </summary>
        public virtual SIR_Sir106Articulo23 SIR_Sir106Articulo23 { get; set; } // FK_SIR_76_CONTENEDORES_SIR_106_ARTICULO_23

        /// <summary>
        /// Parent SIR_Sir150PartesDo pointed by [SIR_76_CONTENEDORES].([NIdParteDos150]) (FK_SIR_76_CONTENEDORES_SIR_150_PARTES_DOS)
        /// </summary>
        public virtual SIR_Sir150PartesDo SIR_Sir150PartesDo { get; set; } // FK_SIR_76_CONTENEDORES_SIR_150_PARTES_DOS

        /// <summary>
        /// Parent SIR_Sir60Referencia pointed by [SIR_76_CONTENEDORES].([NIdReferencia60]) (FK_SIR_76_CONTENEDORES_SIR_60_REFERENCIAS)
        /// </summary>
        public virtual SIR_Sir60Referencia SIR_Sir60Referencia { get; set; } // FK_SIR_76_CONTENEDORES_SIR_60_REFERENCIAS

        /// <summary>
        /// Parent SIR_Sir74ConocimientosMaritimo pointed by [SIR_76_CONTENEDORES].([NIdBl74]) (FK_SIR_76_CONTENEDORES_SIR_74_CONOCIMIENTOS_MARITIMOS)
        /// </summary>
        public virtual SIR_Sir74ConocimientosMaritimo SIR_Sir74ConocimientosMaritimo { get; set; } // FK_SIR_76_CONTENEDORES_SIR_74_CONOCIMIENTOS_MARITIMOS

        /// <summary>
        /// Parent SIR_Sir89DetSelecAleatoria pointed by [SIR_76_CONTENEDORES].([NIdDetSelAle89]) (FK_SIR_76_CONTENEDORES_SIR_89_DET_SELEC_ALEATORIA)
        /// </summary>
        public virtual SIR_Sir89DetSelecAleatoria SIR_Sir89DetSelecAleatoria { get; set; } // FK_SIR_76_CONTENEDORES_SIR_89_DET_SELEC_ALEATORIA

        public SIR_Sir76Contenedore()
        {
            NEstado = 3;
            NCondicionArribo = 5;
            BEsMatPeligroso = false;
            NStatusVig = 1;
            SIR_Sir107ContenedorSello = new System.Collections.Generic.List<SIR_Sir107ContenedorSello>();
            SIR_Sir160ProgPreviosCont = new System.Collections.Generic.List<SIR_Sir160ProgPreviosCont>();
            SIR_Sir171ContSolTransporte = new System.Collections.Generic.List<SIR_Sir171ContSolTransporte>();
            SIR_Sir173PrevioContResultado = new System.Collections.Generic.List<SIR_Sir173PrevioContResultado>();
            SIR_Sir206Remesa_NIdContenedor76 = new System.Collections.Generic.List<SIR_Sir206Remesa>();
            SIR_Sir237CompraCandadosDet = new System.Collections.Generic.List<SIR_Sir237CompraCandadosDet>();
            SIR_Sir433ContenedoresPartesDo = new System.Collections.Generic.List<SIR_Sir433ContenedoresPartesDo>();
            SIR_Sir47ContenedoresTarifa = new System.Collections.Generic.List<SIR_Sir47ContenedoresTarifa>();
            SIR_Sir58ObservContenedore = new System.Collections.Generic.List<SIR_Sir58ObservContenedore>();
            SIR_Sir66CargaSuelta = new System.Collections.Generic.List<SIR_Sir66CargaSuelta>();
            SIR_Sir813DodaContPedimento = new System.Collections.Generic.List<SIR_Sir813DodaContPedimento>();
            SIR_Sir87SolicitudServicio = new System.Collections.Generic.List<SIR_Sir87SolicitudServicio>();
            SIRAdmin_Sira49LiberacionContenedor = new System.Collections.Generic.List<SIRAdmin_Sira49LiberacionContenedor>();
            SIRAdmin_Sira51BookingContenedor = new System.Collections.Generic.List<SIRAdmin_Sira51BookingContenedor>();
            SIR_Sir206Remesa_NIdRem206 = new System.Collections.Generic.List<SIR_Sir206Remesa>();
            SIR_Sir571CalculoAlmacenaje = new System.Collections.Generic.List<SIR_Sir571CalculoAlmacenaje>();
        }
    }

}
// </auto-generated>