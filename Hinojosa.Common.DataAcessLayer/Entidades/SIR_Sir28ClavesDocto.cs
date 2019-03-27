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

    // SIR_28_CLAVES_DOCTOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir28ClavesDocto
    {
        [Required]
        [Display(Name = "N ID clave docto 28")]
        public int NIdClaveDocto28 { get; set; } // nIdClaveDocto28 (Primary key)

        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "S clave")]
        public string SClave { get; set; } // sClave (length: 2)

        [Required]
        [Display(Name = "N tipo operacion")]
        public byte NTipoOperacion { get; set; } // nTipoOperacion

        [Required(AllowEmptyStrings = true)]
        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 1000)

        [Display(Name = "S supuesto app")]
        public string SSupuestoApp { get; set; } // sSupuestoApp

        [Display(Name = "B retorno impo")]
        public bool? BRetornoImpo { get; set; } // bRetornoImpo

        [Display(Name = "B retorno expo")]
        public bool? BRetornoExpo { get; set; } // bRetornoExpo

        [Display(Name = "S plazo maximo")]
        public string SPlazoMaximo { get; set; } // sPlazoMaximo

        [Display(Name = "S base legal")]
        public string SBaseLegal { get; set; } // sBaseLegal

        [Required]
        [Display(Name = "B almacen deposito")]
        public bool BAlmacenDeposito { get; set; } // bAlmacenDeposito

        [Display(Name = "N tasa dtai mpo")]
        public byte? NTasaDtaImpo { get; set; } // nTasaDTAImpo

        [Display(Name = "N tasa dtae xpo")]
        public byte? NTasaDtaExpo { get; set; } // nTasaDTAExpo

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Display(Name = "S particularidad")]
        public string SParticularidad { get; set; } // sParticularidad

        [Required]
        [Display(Name = "N status vig")]
        public byte NStatusVig { get; set; } // nStatusVig

        [Required]
        [Display(Name = "B derogado")]
        public bool BDerogado { get; set; } // bDerogado

        [Display(Name = "D fecha derogacion")]
        public System.DateTime? DFechaDerogacion { get; set; } // dFechaDerogacion

        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "S clave anterior")]
        public string SClaveAnterior { get; set; } // sClaveAnterior (length: 2)

        [Required]
        [Display(Name = "B extraccion impo")]
        public bool BExtraccionImpo { get; set; } // bExtraccionImpo

        [Required]
        [Display(Name = "B extraccion expo")]
        public bool BExtraccionExpo { get; set; } // bExtraccionExpo

        [Required]
        [Display(Name = "B reexp impo")]
        public bool BReexpImpo { get; set; } // bReexpImpo

        [Required]
        [Display(Name = "B reexp expo")]
        public bool BReexpExpo { get; set; } // bReexpExpo

        [Required]
        [Display(Name = "B cambio regimen impo")]
        public bool BCambioRegimenImpo { get; set; } // bCambioRegimenImpo

        [Required]
        [Display(Name = "B cambio regimen expo")]
        public bool BCambioRegimenExpo { get; set; } // bCambioRegimenExpo

        [Required]
        [Display(Name = "B transito")]
        public bool BTransito { get; set; } // bTransito

        [Required]
        [Display(Name = "B pago prev impo")]
        public bool BPagoPrevImpo { get; set; } // bPagoPrevImpo

        [Required]
        [Display(Name = "B pago prev expo")]
        public bool BPagoPrevExpo { get; set; } // bPagoPrevExpo

        [Required]
        [Display(Name = "B sin iva expo")]
        public bool BSinIvaExpo { get; set; } // bSinIvaExpo

        [Required]
        [Display(Name = "B sin iva impo")]
        public bool BSinIvaImpo { get; set; } // bSinIvaImpo

        [Required]
        [Display(Name = "B sin nom impo")]
        public bool BSinNomImpo { get; set; } // bSinNomImpo

        [Required]
        [Display(Name = "B sin nom expo")]
        public bool BSinNomExpo { get; set; } // bSinNomExpo

        [Display(Name = "N ID config 318")]
        public int? NIdConfig318 { get; set; } // nIdConfig318

        [Display(Name = "B cer ivaieps")]
        public bool? BCerIvaieps { get; set; } // bCerIVAIEPS

        [Display(Name = "B aplica precios est")]
        public bool? BAplicaPreciosEst { get; set; } // bAplicaPreciosEst

        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "S met val impo")]
        public string SMetValImpo { get; set; } // sMetValImpo (length: 2)

        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "S met val expo")]
        public string SMetValExpo { get; set; } // sMetValExpo (length: 2)

        [Display(Name = "B no aplica recargo")]
        public int? BNoAplicaRecargo { get; set; } // bNoAplicaRecargo

        [Display(Name = "B aplica fecha entrada a 4 exp")]
        public bool? BAplicaFechaEntradaA4Exp { get; set; } // bAplicaFechaEntradaA4Exp

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) SIR_Sir28ClavesDocto pointed by [SIR_468_ENUM_CLAVE_DOCTOS].[nIdClaveDocto28] (FK_SIR_468_ENUM_CLAVE_DOCTOS_SIR_28_CLAVES_DOCTOS)
        /// </summary>
        public virtual SIR_Sir468EnumClaveDocto SIR_Sir468EnumClaveDocto { get; set; } // SIR_468_ENUM_CLAVE_DOCTOS.FK_SIR_468_ENUM_CLAVE_DOCTOS_SIR_28_CLAVES_DOCTOS
        /// <summary>
        /// Child SIR_Sir123Cotizacione where [SIR_123_COTIZACIONES].[nIdClaveDocto28] point to this entity (FK_SIR_123_COTIZACIONES_SIR_28_CLAVES_DOCTOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir123Cotizacione> SIR_Sir123Cotizacione { get; set; } // SIR_123_COTIZACIONES.FK_SIR_123_COTIZACIONES_SIR_28_CLAVES_DOCTOS
        /// <summary>
        /// Child SIR_Sir127CvesDoctosRegimene where [SIR_127_CVES_DOCTOS_REGIMENES].[nIdClaveDocto28] point to this entity (FK_SIR_127_CVES_DOCTOS_REGIMENES_SIR_28_CLAVES_DOCTOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir127CvesDoctosRegimene> SIR_Sir127CvesDoctosRegimene { get; set; } // SIR_127_CVES_DOCTOS_REGIMENES.FK_SIR_127_CVES_DOCTOS_REGIMENES_SIR_28_CLAVES_DOCTOS
        /// <summary>
        /// Child SIR_Sir252Descargo where [SIR_252_DESCARGOS].[nIdClaveDocto28] point to this entity (FK_SIR_252_DESCARGOS_SIR_28_CLAVES_DOCTOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir252Descargo> SIR_Sir252Descargo { get; set; } // SIR_252_DESCARGOS.FK_SIR_252_DESCARGOS_SIR_28_CLAVES_DOCTOS
        /// <summary>
        /// Child SIR_Sir289MtraClientesIdent where [SIR_289_MTRA_CLIENTES_IDENT].[nIdClaveDocto28] point to this entity (FK_SIR_289_MTRA_CLIENTES_IDENT_SIR_28_CLAVES_DOCTOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir289MtraClientesIdent> SIR_Sir289MtraClientesIdent { get; set; } // SIR_289_MTRA_CLIENTES_IDENT.FK_SIR_289_MTRA_CLIENTES_IDENT_SIR_28_CLAVES_DOCTOS
        /// <summary>
        /// Child SIR_Sir290RectificPedimento where [SIR_290_RECTIFIC_PEDIMENTO].[nIdClaveDocto28] point to this entity (FK_SIR_290_RECTIFIC_PEDIMENTO_SIR_28_CLAVES_DOCTOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir290RectificPedimento> SIR_Sir290RectificPedimento { get; set; } // SIR_290_RECTIFIC_PEDIMENTO.FK_SIR_290_RECTIFIC_PEDIMENTO_SIR_28_CLAVES_DOCTOS
        /// <summary>
        /// Child SIR_Sir297ClavedoctosOrigdest where [SIR_297_CLAVEDOCTOS_ORIGDEST].[nIdClaveDocto28] point to this entity (FK_SIR_297_CLAVEDOCTOS_ORIGDEST_SIR_28_CLAVES_DOCTOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir297ClavedoctosOrigdest> SIR_Sir297ClavedoctosOrigdest { get; set; } // SIR_297_CLAVEDOCTOS_ORIGDEST.FK_SIR_297_CLAVEDOCTOS_ORIGDEST_SIR_28_CLAVES_DOCTOS
        /// <summary>
        /// Child SIR_Sir29FormapagosImpuesto where [SIR_29_FORMAPAGOS_IMPUESTOS].[nIdClaveDocto28] point to this entity (FK_SIR_29_FORMAPAGOS_IMPUESTOS_SIR_28_CLAVES_DOCTOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir29FormapagosImpuesto> SIR_Sir29FormapagosImpuesto { get; set; } // SIR_29_FORMAPAGOS_IMPUESTOS.FK_SIR_29_FORMAPAGOS_IMPUESTOS_SIR_28_CLAVES_DOCTOS
        /// <summary>
        /// Child SIR_Sir400ConfiguracionDeEtapa where [SIR_400_CONFIGURACION_DE_ETAPA].[nIdClaveDocto28] point to this entity (FK_SIR_400_CONFIGURACION_DE_ETAPA_SIR_28_CLAVES_DOCTOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir400ConfiguracionDeEtapa> SIR_Sir400ConfiguracionDeEtapa { get; set; } // SIR_400_CONFIGURACION_DE_ETAPA.FK_SIR_400_CONFIGURACION_DE_ETAPA_SIR_28_CLAVES_DOCTOS
        /// <summary>
        /// Child SIR_Sir60Referencia where [SIR_60_REFERENCIAS].[nIdClaveDocto28] point to this entity (FK_SIR_60_REFERENCIAS_SIR_28_CLAVES_DOCTOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir60Referencia> SIR_Sir60Referencia_NIdClaveDocto28 { get; set; } // SIR_60_REFERENCIAS.FK_SIR_60_REFERENCIAS_SIR_28_CLAVES_DOCTOS
        /// <summary>
        /// Child SIR_Sir60Referencia where [SIR_60_REFERENCIAS].[nIdRecti28] point to this entity (FK_SIR_60_REFERENCIAS_SIR_28_CLAVES_DOCTOS_RECTI)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir60Referencia> SIR_Sir60Referencia_NIdRecti28 { get; set; } // SIR_60_REFERENCIAS.FK_SIR_60_REFERENCIAS_SIR_28_CLAVES_DOCTOS_RECTI
        /// <summary>
        /// Child SIR_Sir61TiposDocsClaveDoc where [SIR_61_TIPOS_DOCS_CLAVE_DOCS].[nIdClaveDocto28] point to this entity (FK_SIR_61_TIPOS_DOCS_CLAVE_DOCS_SIR_28_CLAVES_DOCTOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir61TiposDocsClaveDoc> SIR_Sir61TiposDocsClaveDoc { get; set; } // SIR_61_TIPOS_DOCS_CLAVE_DOCS.FK_SIR_61_TIPOS_DOCS_CLAVE_DOCS_SIR_28_CLAVES_DOCTOS
        /// <summary>
        /// Child SIR_Sir836ClienteDocto where [SIR_836_CLIENTE_DOCTO].[nIdClaveDocto28] point to this entity (FK_SIR_836_CLIENTE_DOCTO_SIR_62_TIPOS_DOCUMENTOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir836ClienteDocto> SIR_Sir836ClienteDocto { get; set; } // SIR_836_CLIENTE_DOCTO.FK_SIR_836_CLIENTE_DOCTO_SIR_62_TIPOS_DOCUMENTOS
        /// <summary>
        /// Child SIRAdmin_Sira51BookingContenedor where [SIRA_51_BOOKING_CONTENEDOR].[nIdClaveDocto28] point to this entity (FK_SIRA_51_BOOKING_CONTENEDOR_SIR_28_CLAVES_DOCTOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira51BookingContenedor> SIRAdmin_Sira51BookingContenedor { get; set; } // SIRA_51_BOOKING_CONTENEDOR.FK_SIRA_51_BOOKING_CONTENEDOR_SIR_28_CLAVES_DOCTOS

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_28_CLAVES_DOCTOS].([NIdUsuarioEd]) (FK_SIR_28_CLAVES_DOCTOS_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_28_CLAVES_DOCTOS_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir318ConfigCvedoctoFracc pointed by [SIR_28_CLAVES_DOCTOS].([NIdConfig318]) (FK_SIR_28_CLAVES_DOCTOS_SIR_318_CONFIG_CVEDOCTO_FRACC)
        /// </summary>
        public virtual SIR_Sir318ConfigCvedoctoFracc SIR_Sir318ConfigCvedoctoFracc { get; set; } // FK_SIR_28_CLAVES_DOCTOS_SIR_318_CONFIG_CVEDOCTO_FRACC

        public SIR_Sir28ClavesDocto()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            NStatusVig = 1;
            BDerogado = false;
            BReexpImpo = false;
            BReexpExpo = false;
            BCambioRegimenImpo = false;
            BCambioRegimenExpo = false;
            BTransito = false;
            BPagoPrevImpo = false;
            BPagoPrevExpo = false;
            BSinNomImpo = false;
            BSinNomExpo = false;
            SIR_Sir123Cotizacione = new System.Collections.Generic.List<SIR_Sir123Cotizacione>();
            SIR_Sir127CvesDoctosRegimene = new System.Collections.Generic.List<SIR_Sir127CvesDoctosRegimene>();
            SIR_Sir252Descargo = new System.Collections.Generic.List<SIR_Sir252Descargo>();
            SIR_Sir289MtraClientesIdent = new System.Collections.Generic.List<SIR_Sir289MtraClientesIdent>();
            SIR_Sir29FormapagosImpuesto = new System.Collections.Generic.List<SIR_Sir29FormapagosImpuesto>();
            SIR_Sir290RectificPedimento = new System.Collections.Generic.List<SIR_Sir290RectificPedimento>();
            SIR_Sir297ClavedoctosOrigdest = new System.Collections.Generic.List<SIR_Sir297ClavedoctosOrigdest>();
            SIR_Sir400ConfiguracionDeEtapa = new System.Collections.Generic.List<SIR_Sir400ConfiguracionDeEtapa>();
            SIR_Sir60Referencia_NIdClaveDocto28 = new System.Collections.Generic.List<SIR_Sir60Referencia>();
            SIR_Sir60Referencia_NIdRecti28 = new System.Collections.Generic.List<SIR_Sir60Referencia>();
            SIR_Sir61TiposDocsClaveDoc = new System.Collections.Generic.List<SIR_Sir61TiposDocsClaveDoc>();
            SIR_Sir836ClienteDocto = new System.Collections.Generic.List<SIR_Sir836ClienteDocto>();
            SIRAdmin_Sira51BookingContenedor = new System.Collections.Generic.List<SIRAdmin_Sira51BookingContenedor>();
        }
    }

}
// </auto-generated>
