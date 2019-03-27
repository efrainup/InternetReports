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

    // SIR_124_ANTICIPOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir124Anticipos
    {
        [Required]
        [Display(Name = "N ID anticipo 124")]
        public int NIdAnticipo124 { get; set; } // nIdAnticipo124 (Primary key)

        [Required]
        [Display(Name = "N folio")]
        public int NFolio { get; set; } // nFolio

        [Display(Name = "N ID cotizacion 123")]
        public int? NIdCotizacion123 { get; set; } // nIdCotizacion123

        [Required]
        [Display(Name = "N ID referencia 60")]
        public int NIdReferencia60 { get; set; } // nIdReferencia60

        [Display(Name = "N solicitado por")]
        public int? NSolicitadoPor { get; set; } // nSolicitadoPor

        [Required]
        [Display(Name = "D fecha solicitud")]
        public System.DateTime DFechaSolicitud { get; set; } // dFechaSolicitud

        [Display(Name = "N ID moneda")]
        public int? NIdMoneda { get; set; } // nIdMoneda

        [Required]
        [Display(Name = "N importe")]
        public decimal NImporte { get; set; } // nImporte

        [Required]
        [Display(Name = "N status")]
        public byte NStatus { get; set; } // nStatus

        [Display(Name = "D fecha autorizacion")]
        public System.DateTime? DFechaAutorizacion { get; set; } // dFechaAutorizacion

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Display(Name = "N ID suc pat adu 71")]
        public int? NIdSucPatAdu71 { get; set; } // nIdSucPatAdu71

        [Display(Name = "N ID comp mul 314")]
        public int? NIdCompMul314 { get; set; } // nIdCompMul314

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S pedido")]
        public string SPedido { get; set; } // sPedido (length: 50)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S modelo")]
        public string SModelo { get; set; } // sModelo (length: 50)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S serie")]
        public string SSerie { get; set; } // sSerie (length: 50)

        [Display(Name = "N impuestos")]
        public decimal? NImpuestos { get; set; } // nImpuestos

        [Display(Name = "N gastos")]
        public decimal? NGastos { get; set; } // nGastos

        [Display(Name = "N ingresos")]
        public decimal? NIngresos { get; set; } // nIngresos

        [Required]
        [Display(Name = "N total")]
        public decimal NTotal { get; set; } // nTotal

        [Display(Name = "N complementarios")]
        public decimal? NComplementarios { get; set; } // nComplementarios

        [Display(Name = "N solicitado por 01")]
        public int? NSolicitadoPor01 { get; set; } // nSolicitadoPor01

        [Display(Name = "N ID moneda 03")]
        public int? NIdMoneda03 { get; set; } // nIdMoneda03

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S ID foraneo")]
        public string SIdForaneo { get; set; } // sIdForaneo (length: 50)

        // Foreign keys

        /// <summary>
        /// Parent Admin_Admina01Usuario pointed by [SIR_124_ANTICIPOS].([NSolicitadoPor01]) (FK_SIR_124_ANTICIPOS_ADMINA_01_USUARIOS)
        /// </summary>
        public virtual Admin_Admina01Usuario Admin_Admina01Usuario { get; set; } // FK_SIR_124_ANTICIPOS_ADMINA_01_USUARIOS

        /// <summary>
        /// Parent Admin_Adminc03Moneda pointed by [SIR_124_ANTICIPOS].([NIdMoneda03]) (FK_SIR_124_ANTICIPOS_ADMINC_03_MONEDAS)
        /// </summary>
        public virtual Admin_Adminc03Moneda Admin_Adminc03Moneda { get; set; } // FK_SIR_124_ANTICIPOS_ADMINC_03_MONEDAS

        /// <summary>
        /// Parent CatUsr pointed by [SIR_124_ANTICIPOS].([NIdUsuarioEd]) (FK_SIR_124_ANTICIPOS_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_124_ANTICIPOS_cat_usr_ed

        /// <summary>
        /// Parent MonMoneda pointed by [SIR_124_ANTICIPOS].([NIdMoneda]) (FK_SIR_124_ANTICIPOS_mon_monedas)
        /// </summary>
        public virtual MonMoneda MonMoneda { get; set; } // FK_SIR_124_ANTICIPOS_mon_monedas

        /// <summary>
        /// Parent SIR_Sir123Cotizacione pointed by [SIR_124_ANTICIPOS].([NIdCotizacion123]) (FK_SIR_124_ANTICIPOS_SIR_123_COTIZACIONES)
        /// </summary>
        public virtual SIR_Sir123Cotizacione SIR_Sir123Cotizacione { get; set; } // FK_SIR_124_ANTICIPOS_SIR_123_COTIZACIONES

        /// <summary>
        /// Parent SIR_Sir314CotizacionMultiple pointed by [SIR_124_ANTICIPOS].([NIdCompMul314]) (FK_SIR_124_ANTICIPOS_SIR_314_COTIZACION_MULTIPLE)
        /// </summary>
        public virtual SIR_Sir314CotizacionMultiple SIR_Sir314CotizacionMultiple { get; set; } // FK_SIR_124_ANTICIPOS_SIR_314_COTIZACION_MULTIPLE

        /// <summary>
        /// Parent SIR_Sir60Referencia pointed by [SIR_124_ANTICIPOS].([NIdReferencia60]) (FK_SIR_124_ANTICIPOS_SIR_60_REFERENCIAS)
        /// </summary>
        public virtual SIR_Sir60Referencia SIR_Sir60Referencia { get; set; } // FK_SIR_124_ANTICIPOS_SIR_60_REFERENCIAS

        /// <summary>
        /// Parent SIR_Sir71SucursalPatenteAduana pointed by [SIR_124_ANTICIPOS].([NIdSucPatAdu71]) (FK_SIR_124_ANTICIPOS_SIR_71_SUCURSAL_PATENTE_ADUANA)
        /// </summary>
        public virtual SIR_Sir71SucursalPatenteAduana SIR_Sir71SucursalPatenteAduana { get; set; } // FK_SIR_124_ANTICIPOS_SIR_71_SUCURSAL_PATENTE_ADUANA

        public SIR_Sir124Anticipos()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            NTotal = 0.0m;
        }
    }

}
// </auto-generated>
