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

    // SIR_169_SOLICITUD_TRANSPORTE
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir169SolicitudTransporte
    {
        [Required]
        [Display(Name = "N ID sol trans 169")]
        public int NIdSolTrans169 { get; set; } // nIdSolTrans169 (Primary key)

        [Required]
        [Display(Name = "N ID referencia 60")]
        public int NIdReferencia60 { get; set; } // nIdReferencia60

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S mercancia")]
        public string SMercancia { get; set; } // sMercancia (length: 100)

        [Required]
        [Display(Name = "N cantidad")]
        public int NCantidad { get; set; } // nCantidad

        [Required]
        [Display(Name = "N ID transportista")]
        public int NIdTransportista { get; set; } // nIdTransportista

        [Required]
        [Display(Name = "D fecha solicitud")]
        public System.DateTime DFechaSolicitud { get; set; } // dFechaSolicitud

        [Required]
        [Display(Name = "N modo transporte")]
        public byte NModoTransporte { get; set; } // nModoTransporte

        [Required]
        [Display(Name = "B pistas")]
        public bool BPistas { get; set; } // bPistas

        [Required]
        [Display(Name = "B custodia")]
        public bool BCustodia { get; set; } // bCustodia

        [Required(AllowEmptyStrings = true)]
        [MaxLength(300)]
        [StringLength(300)]
        [Display(Name = "S custodia")]
        public string SCustodia { get; set; } // sCustodia (length: 300)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(120)]
        [StringLength(120)]
        [Display(Name = "S entrega")]
        public string SEntrega { get; set; } // sEntrega (length: 120)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(17)]
        [StringLength(17)]
        [Display(Name = "S ID fiscal")]
        public string SIdFiscal { get; set; } // sIdFiscal (length: 17)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "S calle")]
        public string SCalle { get; set; } // sCalle (length: 80)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S numero int")]
        public string SNumeroInt { get; set; } // sNumeroInt (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S numero ext")]
        public string SNumeroExt { get; set; } // sNumeroExt (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(35)]
        [StringLength(35)]
        [Display(Name = "S colonia")]
        public string SColonia { get; set; } // sColonia (length: 35)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "S ciudad")]
        public string SCiudad { get; set; } // sCiudad (length: 80)

        [Required]
        [Display(Name = "N ID entidad")]
        public int NIdEntidad { get; set; } // nIdEntidad

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "S cp")]
        public string SCp { get; set; } // sCP (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S telefono")]
        public string STelefono { get; set; } // sTelefono (length: 20)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S contactar")]
        public string SContactar { get; set; } // sContactar (length: 50)

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S solicito reporte")]
        public string SSolicitoReporte { get; set; } // sSolicitoReporte (length: 100)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S clase")]
        public string SClase { get; set; } // sClase (length: 50)

        [Display(Name = "N alto")]
        public decimal? NAlto { get; set; } // nAlto

        [Display(Name = "N ancho")]
        public decimal? NAncho { get; set; } // nAncho

        [Display(Name = "N largo")]
        public decimal? NLargo { get; set; } // nLargo

        [Display(Name = "N volumen")]
        public decimal? NVolumen { get; set; } // nVolumen

        [Display(Name = "D fecha recoleccion")]
        public System.DateTime? DFechaRecoleccion { get; set; } // dFechaRecoleccion

        [Display(Name = "D fecha entrada")]
        public System.DateTime? DFechaEntrada { get; set; } // dFechaEntrada

        [Display(Name = "N tipo")]
        public byte? NTipo { get; set; } // nTipo

        [Display(Name = "S observacion")]
        public string SObservacion { get; set; } // sObservacion

        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "S transportista")]
        public string STransportista { get; set; } // sTransportista (length: 200)

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) SIR_Sir169SolicitudTransporte pointed by [SIR_171_CONT_SOL_TRANSPORTE].[nIdSolTrans169] (FK_SIR_171_CONT_SOL_TRANSPORTE_SIR_169_SOLICITUD_TRANSPORTE)
        /// </summary>
        public virtual SIR_Sir171ContSolTransporte SIR_Sir171ContSolTransporte { get; set; } // SIR_171_CONT_SOL_TRANSPORTE.FK_SIR_171_CONT_SOL_TRANSPORTE_SIR_169_SOLICITUD_TRANSPORTE
        /// <summary>
        /// Child SIR_Sir170ObservSolTransporte where [SIR_170_OBSERV_SOL_TRANSPORTE].[nIdSolTrans169] point to this entity (FK_SIR_170 _OBSERV_SOL_TRANSPORTE_SIR_169_SOLICITUD_TRANSPORTE)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir170ObservSolTransporte> SIR_Sir170ObservSolTransporte { get; set; } // SIR_170_OBSERV_SOL_TRANSPORTE.FK_SIR_170 _OBSERV_SOL_TRANSPORTE_SIR_169_SOLICITUD_TRANSPORTE
        /// <summary>
        /// Child SIR_Sir186OrdenesRemisione where [SIR_186_ORDENES_REMISIONES].[nIdSolTrans169] point to this entity (FK_SIR_186_ORDENES_REMISIONES_SIR_169_SOLICITUD_TRANSPORTE)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir186OrdenesRemisione> SIR_Sir186OrdenesRemisione { get; set; } // SIR_186_ORDENES_REMISIONES.FK_SIR_186_ORDENES_REMISIONES_SIR_169_SOLICITUD_TRANSPORTE
        /// <summary>
        /// Child SIR_Sir729CaracSolicitudTransporte where [SIR_729_CARAC_SOLICITUD_TRANSPORTE].[nIdSolTrans169] point to this entity (FK_SIR_729_CARAC_SOLICITUD_TRANSPORTE_SIR_169_SOLICITUD_TRANSPORTE)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir729CaracSolicitudTransporte> SIR_Sir729CaracSolicitudTransporte { get; set; } // SIR_729_CARAC_SOLICITUD_TRANSPORTE.FK_SIR_729_CARAC_SOLICITUD_TRANSPORTE_SIR_169_SOLICITUD_TRANSPORTE

        // Foreign keys

        /// <summary>
        /// Parent CatEdo pointed by [SIR_169_SOLICITUD_TRANSPORTE].([NIdEntidad]) (FK_SIR_169_SOLICITUD_TRANSPORTE_cat_edos)
        /// </summary>
        public virtual CatEdo CatEdo { get; set; } // FK_SIR_169_SOLICITUD_TRANSPORTE_cat_edos

        /// <summary>
        /// Parent CatProv pointed by [SIR_169_SOLICITUD_TRANSPORTE].([NIdTransportista]) (FK_SIR_169_SOLICITUD_TRANSPORTE_cat_prov)
        /// </summary>
        public virtual CatProv CatProv { get; set; } // FK_SIR_169_SOLICITUD_TRANSPORTE_cat_prov

        /// <summary>
        /// Parent CatUsr pointed by [SIR_169_SOLICITUD_TRANSPORTE].([NIdUsuarioEd]) (FK_SIR_169_SOLICITUD_TRANSPORTE_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_169_SOLICITUD_TRANSPORTE_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir60Referencia pointed by [SIR_169_SOLICITUD_TRANSPORTE].([NIdReferencia60]) (FK_SIR_169_SOLICITUD_TRANSPORTE_SIR_60_REFERENCIAS)
        /// </summary>
        public virtual SIR_Sir60Referencia SIR_Sir60Referencia { get; set; } // FK_SIR_169_SOLICITUD_TRANSPORTE_SIR_60_REFERENCIAS

        public SIR_Sir169SolicitudTransporte()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            NTipo = 1;
            SIR_Sir170ObservSolTransporte = new System.Collections.Generic.List<SIR_Sir170ObservSolTransporte>();
            SIR_Sir186OrdenesRemisione = new System.Collections.Generic.List<SIR_Sir186OrdenesRemisione>();
            SIR_Sir729CaracSolicitudTransporte = new System.Collections.Generic.List<SIR_Sir729CaracSolicitudTransporte>();
        }
    }

}
// </auto-generated>
