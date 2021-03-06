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

    // SIR_94_PRE_BLS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir94PreBl
    {
        [Required]
        [Display(Name = "N ID pre bls 94")]
        public int NIdPreBls94 { get; set; } // nIdPreBls94 (Primary key)

        [Display(Name = "N ID referencia 60")]
        public int? NIdReferencia60 { get; set; } // nIdReferencia60

        [Display(Name = "N ID reporte 93")]
        public int? NIdReporte93 { get; set; } // nIdReporte93

        [Required(AllowEmptyStrings = true)]
        [MaxLength(12)]
        [StringLength(12)]
        [Display(Name = "S num referencia")]
        public string SNumReferencia { get; set; } // sNumReferencia (length: 12)

        [MaxLength(800)]
        [StringLength(800)]
        [Display(Name = "S dir impo expo")]
        public string SDirImpoExpo { get; set; } // sDirImpoExpo (length: 800)

        [MaxLength(800)]
        [StringLength(800)]
        [Display(Name = "S dir consignataria")]
        public string SDirConsignataria { get; set; } // sDirConsignataria (length: 800)

        [MaxLength(800)]
        [StringLength(800)]
        [Display(Name = "S dir notificante")]
        public string SDirNotificante { get; set; } // sDirNotificante (length: 800)

        [Display(Name = "S lista contenedores")]
        public string SListaContenedores { get; set; } // sListaContenedores

        [Display(Name = "S peso paquetes")]
        public string SPesoPaquetes { get; set; } // sPesoPaquetes

        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion

        [Display(Name = "S medidas")]
        public string SMedidas { get; set; } // sMedidas

        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "S apartado")]
        public string SApartado { get; set; } // sApartado (length: 60)

        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "S lugar entrega")]
        public string SLugarEntrega { get; set; } // sLugarEntrega (length: 60)

        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "S barco")]
        public string SBarco { get; set; } // sBarco (length: 60)

        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "S puerto carga")]
        public string SPuertoCarga { get; set; } // sPuertoCarga (length: 60)

        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "S puerto descarga")]
        public string SPuertoDescarga { get; set; } // sPuertoDescarga (length: 60)

        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "S desc transbordo")]
        public string SDescTransbordo { get; set; } // sDescTransbordo (length: 60)

        [Required]
        [Display(Name = "N tipo operacion")]
        public byte NTipoOperacion { get; set; } // nTipoOperacion

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Display(Name = "N ID imo 16")]
        public int? NIdImo16 { get; set; } // nIdIMO16

        [MaxLength(4)]
        [StringLength(4)]
        [Display(Name = "S un")]
        public string SUn { get; set; } // sUN (length: 4)

        [Required]
        [Display(Name = "B carga refrigerada")]
        public bool BCargaRefrigerada { get; set; } // bCargaRefrigerada

        [Required]
        [Display(Name = "B carga sobre dim")]
        public bool BCargaSobreDim { get; set; } // bCargaSobreDim

        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "S fracciones")]
        public string SFracciones { get; set; } // sFracciones (length: 200)

        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "S comentarios")]
        public string SComentarios { get; set; } // sComentarios (length: 200)

        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "S imo")]
        public string SImo { get; set; } // sIMO (length: 200)

        [Display(Name = "N ID suc pat adu 71")]
        public int? NIdSucPatAdu71 { get; set; } // nIdSucPatAdu71

        [Required]
        [Display(Name = "D fecha elaboracion")]
        public System.DateTime DFechaElaboracion { get; set; } // dFechaElaboracion

        [Required]
        [Display(Name = "N peso neto")]
        public decimal NPesoNeto { get; set; } // nPesoNeto

        [Required]
        [Display(Name = "N volumen")]
        public decimal NVolumen { get; set; } // nVolumen

        [Required]
        [Display(Name = "B prod peligroso")]
        public bool BProdPeligroso { get; set; } // bProdPeligroso

        [Required]
        [Display(Name = "B flete pre pagado")]
        public bool BFletePrePagado { get; set; } // bFletePrePagado

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_94_PRE_BLS].([NIdUsuarioEd]) (FK_SIR_94_PRE_BLS_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_94_PRE_BLS_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir16Imo pointed by [SIR_94_PRE_BLS].([NIdImo16]) (FK_SIR_94_PRE_BLS_SIR_16_IMO)
        /// </summary>
        public virtual SIR_Sir16Imo SIR_Sir16Imo { get; set; } // FK_SIR_94_PRE_BLS_SIR_16_IMO

        /// <summary>
        /// Parent SIR_Sir60Referencia pointed by [SIR_94_PRE_BLS].([NIdReferencia60]) (FK_SIR_94_PRE_BLS_SIR_60_REFERENCIAS)
        /// </summary>
        public virtual SIR_Sir60Referencia SIR_Sir60Referencia { get; set; } // FK_SIR_94_PRE_BLS_SIR_60_REFERENCIAS

        /// <summary>
        /// Parent SIR_Sir71SucursalPatenteAduana pointed by [SIR_94_PRE_BLS].([NIdSucPatAdu71]) (FK_SIR_94_PRE_BLS_SIR_71_SUCURSAL_PATENTE_ADUANA)
        /// </summary>
        public virtual SIR_Sir71SucursalPatenteAduana SIR_Sir71SucursalPatenteAduana { get; set; } // FK_SIR_94_PRE_BLS_SIR_71_SUCURSAL_PATENTE_ADUANA

        /// <summary>
        /// Parent SIR_Sir93Reporte pointed by [SIR_94_PRE_BLS].([NIdReporte93]) (FK_SIR_94_PRE-BLS_SIR_93_REPORTES)
        /// </summary>
        public virtual SIR_Sir93Reporte SIR_Sir93Reporte { get; set; } // FK_SIR_94_PRE-BLS_SIR_93_REPORTES

        public SIR_Sir94PreBl()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            BCargaRefrigerada = false;
            DFechaElaboracion = System.DateTime.Now;
        }
    }

}
// </auto-generated>
