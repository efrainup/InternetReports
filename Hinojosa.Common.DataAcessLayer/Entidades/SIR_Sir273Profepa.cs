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

    // SIR_273_PROFEPA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir273Profepa
    {
        [Required]
        [Display(Name = "N ID profepa 273")]
        public int NIdProfepa273 { get; set; } // nIdProfepa273 (Primary key)

        [Required]
        [Display(Name = "N ID referencia 60")]
        public int NIdReferencia60 { get; set; } // nIdReferencia60

        [Display(Name = "N ID inspec 271")]
        public int? NIdInspec271 { get; set; } // nIdInspec271

        [Display(Name = "N ID del 266")]
        public int? NIdDel266 { get; set; } // nIdDel266

        [Display(Name = "N ID medio trans 05")]
        public int? NIdMedioTrans05 { get; set; } // nIdMedioTrans05

        [Display(Name = "N ID fracc pago 268")]
        public int? NIdFraccPago268 { get; set; } // nIdFraccPago268

        [Display(Name = "N ID pi nspec 272")]
        public int? NIdPInspec272 { get; set; } // nIdPInspec272

        [Display(Name = "N ID proveedor 42")]
        public int? NIdProveedor42 { get; set; } // nIdProveedor42

        [Display(Name = "N secuencia")]
        public int? NSecuencia { get; set; } // nSecuencia

        [Required]
        [Display(Name = "N tipo operacion")]
        public byte NTipoOperacion { get; set; } // nTipoOperacion

        [Required]
        [Display(Name = "N obj im ex")]
        public byte NObjImEx { get; set; } // nObjImEx

        [Required]
        [Display(Name = "N comprobante trat")]
        public byte NComprobanteTrat { get; set; } // nComprobanteTrat

        [Required]
        [Display(Name = "N tipo rv")]
        public byte NTipoRv { get; set; } // nTipoRV

        [Display(Name = "N importe")]
        public decimal? NImporte { get; set; } // nImporte

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "S placas")]
        public string SPlacas { get; set; } // sPlacas (length: 10)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S firma")]
        public string SFirma { get; set; } // sFirma (length: 30)

        [MaxLength(6)]
        [StringLength(6)]
        [Display(Name = "S clave derecho")]
        public string SClaveDerecho { get; set; } // sClaveDerecho (length: 6)

        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "S dictamen tecnico")]
        public string SDictamenTecnico { get; set; } // sDictamenTecnico (length: 200)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S numero acta")]
        public string SNumeroActa { get; set; } // sNumeroActa (length: 50)

        [Display(Name = "D feha acta")]
        public System.DateTime? DFehaActa { get; set; } // dFehaActa

        [Display(Name = "D fecha pago")]
        public System.DateTime? DFechaPago { get; set; } // dFechaPago

        [Display(Name = "D fecha reg val")]
        public System.DateTime? DFechaRegVal { get; set; } // dFechaRegVal

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Required]
        [Display(Name = "N clave")]
        public int NClave { get; set; } // nClave

        [Display(Name = "N ID suc pat adu 71")]
        public int? NIdSucPatAdu71 { get; set; } // nIdSucPatAdu71

        [Display(Name = "N ID pre prof 269")]
        public int? NIdPreProf269 { get; set; } // nIdPrePROF269

        [MaxLength(8)]
        [StringLength(8)]
        [Display(Name = "S folio")]
        public string SFolio { get; set; } // sFolio (length: 8)

        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "S observacion")]
        public string SObservacion { get; set; } // sObservacion (length: 250)

        [Required]
        [Display(Name = "N status")]
        public byte NStatus { get; set; } // nStatus

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir274FacturasProfepa where [SIR_274_FACTURAS_PROFEPA].[nIdProfepa273] point to this entity (FK_SIR_274_FACTURAS_PROFEPA_SIR_273_PROFEPA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir274FacturasProfepa> SIR_Sir274FacturasProfepa { get; set; } // SIR_274_FACTURAS_PROFEPA.FK_SIR_274_FACTURAS_PROFEPA_SIR_273_PROFEPA
        /// <summary>
        /// Child SIR_Sir275TransportistasProfepa where [SIR_275_TRANSPORTISTAS_PROFEPA].[nIdProfepa273] point to this entity (FK_SIR_275_TRANSPORTISTAS_PROFEPA_SIR_273_PROFEPA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir275TransportistasProfepa> SIR_Sir275TransportistasProfepa { get; set; } // SIR_275_TRANSPORTISTAS_PROFEPA.FK_SIR_275_TRANSPORTISTAS_PROFEPA_SIR_273_PROFEPA
        /// <summary>
        /// Child SIR_Sir276ObservacionesProfepa where [SIR_276_OBSERVACIONES_PROFEPA].[nIdProfepa273] point to this entity (FK_SIR_276_OBSERVACIONES_PROFEPA_SIR_273_PROFEPA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir276ObservacionesProfepa> SIR_Sir276ObservacionesProfepa { get; set; } // SIR_276_OBSERVACIONES_PROFEPA.FK_SIR_276_OBSERVACIONES_PROFEPA_SIR_273_PROFEPA
        /// <summary>
        /// Child SIR_Sir277FraccionesProfepa where [SIR_277_FRACCIONES_PROFEPA].[nIdProfepa273] point to this entity (FK_SIR_277_FRACCIONES_PROFEPA_SIR_273_PROFEPA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir277FraccionesProfepa> SIR_Sir277FraccionesProfepa { get; set; } // SIR_277_FRACCIONES_PROFEPA.FK_SIR_277_FRACCIONES_PROFEPA_SIR_273_PROFEPA
        /// <summary>
        /// Child SIR_Sir283ArchivosProfepa where [SIR_283_ARCHIVOS_PROFEPA].[nIdProfepa273] point to this entity (FK_SIR_283_ARCHIVOS_PROFEPA_SIR_273_PROFEPA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir283ArchivosProfepa> SIR_Sir283ArchivosProfepa { get; set; } // SIR_283_ARCHIVOS_PROFEPA.FK_SIR_283_ARCHIVOS_PROFEPA_SIR_273_PROFEPA

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_273_PROFEPA].([NIdUsuarioEd]) (FK_SIR_273_PROFEPA_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_273_PROFEPA_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir05MediosTransporte pointed by [SIR_273_PROFEPA].([NIdMedioTrans05]) (FK_SIR_273_PROFEPA_SIR_05_MEDIOS_TRANSPORTE)
        /// </summary>
        public virtual SIR_Sir05MediosTransporte SIR_Sir05MediosTransporte { get; set; } // FK_SIR_273_PROFEPA_SIR_05_MEDIOS_TRANSPORTE

        /// <summary>
        /// Parent SIR_Sir266DelegacionesProfepa pointed by [SIR_273_PROFEPA].([NIdDel266]) (FK_SIR_273_PROFEPA_SIR_266_DELEGACIONES_PROFEPA)
        /// </summary>
        public virtual SIR_Sir266DelegacionesProfepa SIR_Sir266DelegacionesProfepa { get; set; } // FK_SIR_273_PROFEPA_SIR_266_DELEGACIONES_PROFEPA

        /// <summary>
        /// Parent SIR_Sir268FraccPagosDerecho pointed by [SIR_273_PROFEPA].([NIdFraccPago268]) (FK_SIR_273_PROFEPA_SIR_268_FRACC_PAGOS_DERECHOS)
        /// </summary>
        public virtual SIR_Sir268FraccPagosDerecho SIR_Sir268FraccPagosDerecho { get; set; } // FK_SIR_273_PROFEPA_SIR_268_FRACC_PAGOS_DERECHOS

        /// <summary>
        /// Parent SIR_Sir269ClavesPrevProfepa pointed by [SIR_273_PROFEPA].([NIdPreProf269]) (FK_SIR_273_PROFEPA_SIR_269_CLAVES_PREV_PROFEPA)
        /// </summary>
        public virtual SIR_Sir269ClavesPrevProfepa SIR_Sir269ClavesPrevProfepa { get; set; } // FK_SIR_273_PROFEPA_SIR_269_CLAVES_PREV_PROFEPA

        /// <summary>
        /// Parent SIR_Sir271Inspectoria pointed by [SIR_273_PROFEPA].([NIdInspec271]) (FK_SIR_273_PROFEPA_SIR_271_INSPECTORIAS)
        /// </summary>
        public virtual SIR_Sir271Inspectoria SIR_Sir271Inspectoria { get; set; } // FK_SIR_273_PROFEPA_SIR_271_INSPECTORIAS

        /// <summary>
        /// Parent SIR_Sir272PuntosInspeccion pointed by [SIR_273_PROFEPA].([NIdPInspec272]) (FK_SIR_273_PROFEPA_SIR_272_PUNTOS_INSPECCION)
        /// </summary>
        public virtual SIR_Sir272PuntosInspeccion SIR_Sir272PuntosInspeccion { get; set; } // FK_SIR_273_PROFEPA_SIR_272_PUNTOS_INSPECCION

        /// <summary>
        /// Parent SIR_Sir42Proveedore pointed by [SIR_273_PROFEPA].([NIdProveedor42]) (FK_SIR_273_PROFEPA_SIR_42_PROVEEDORES)
        /// </summary>
        public virtual SIR_Sir42Proveedore SIR_Sir42Proveedore { get; set; } // FK_SIR_273_PROFEPA_SIR_42_PROVEEDORES

        /// <summary>
        /// Parent SIR_Sir60Referencia pointed by [SIR_273_PROFEPA].([NIdReferencia60]) (FK_SIR_273_PROFEPA_SIR_60_REFERENCIAS)
        /// </summary>
        public virtual SIR_Sir60Referencia SIR_Sir60Referencia { get; set; } // FK_SIR_273_PROFEPA_SIR_60_REFERENCIAS

        /// <summary>
        /// Parent SIR_Sir71SucursalPatenteAduana pointed by [SIR_273_PROFEPA].([NIdSucPatAdu71]) (FK_SIR_273_PROFEPA_SIR_71_SUCURSAL_PATENTE_ADUANA)
        /// </summary>
        public virtual SIR_Sir71SucursalPatenteAduana SIR_Sir71SucursalPatenteAduana { get; set; } // FK_SIR_273_PROFEPA_SIR_71_SUCURSAL_PATENTE_ADUANA

        public SIR_Sir273Profepa()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            SIR_Sir274FacturasProfepa = new System.Collections.Generic.List<SIR_Sir274FacturasProfepa>();
            SIR_Sir275TransportistasProfepa = new System.Collections.Generic.List<SIR_Sir275TransportistasProfepa>();
            SIR_Sir276ObservacionesProfepa = new System.Collections.Generic.List<SIR_Sir276ObservacionesProfepa>();
            SIR_Sir277FraccionesProfepa = new System.Collections.Generic.List<SIR_Sir277FraccionesProfepa>();
            SIR_Sir283ArchivosProfepa = new System.Collections.Generic.List<SIR_Sir283ArchivosProfepa>();
        }
    }

}
// </auto-generated>
