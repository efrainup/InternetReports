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

    // ADMINO_16_DETALLES_CUENTAS_GASTOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Admin_Admino16DetallesCuentasGasto
    {
        [Required]
        [Display(Name = "N ID det cta gastos 16")]
        public int NIdDetCtaGastos16 { get; set; } // nIdDetCtaGastos16 (Primary key)

        [Required]
        [Display(Name = "N ID cta gastos 15")]
        public int NIdCtaGastos15 { get; set; } // nIdCtaGastos15

        [Display(Name = "N ID pago cli 13")]
        public int? NIdPagoCli13 { get; set; } // nIdPagoCli13

        [Display(Name = "N ID pago cli 10")]
        public int? NIdPagoCli10 { get; set; } // nIdPagoCli10

        [Required]
        [Display(Name = "N ID concep 28")]
        public int NIdConcep28 { get; set; } // nIdConcep28

        [Required]
        [Display(Name = "D detalle")]
        public System.DateTime DDetalle { get; set; } // dDetalle

        [DataType(DataType.Currency)]
        [Display(Name = "N importe")]
        public decimal? NImporte { get; set; } // nImporte

        [DataType(DataType.Currency)]
        [Display(Name = "N iva")]
        public decimal? NIva { get; set; } // nIVA

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 100)

        [Display(Name = "N ID referencia 60")]
        public int? NIdReferencia60 { get; set; } // nIdReferencia60

        [Required]
        [Display(Name = "N tipo registro")]
        public byte NTipoRegistro { get; set; } // nTipoRegistro

        [Required]
        [Display(Name = "N ID suc pat adu 71")]
        public int NIdSucPatAdu71 { get; set; } // nIdSucPatAdu71

        [Display(Name = "N tipo pago")]
        public byte? NTipoPago { get; set; } // nTipoPago

        [Display(Name = "N ID det pago 09")]
        public int? NIdDetPago09 { get; set; } // nIdDetPago09

        [Display(Name = "N ID det anticipo 12")]
        public int? NIdDetAnticipo12 { get; set; } // nIdDetAnticipo12

        [Display(Name = "N ID det liquid 23")]
        public int? NIdDetLiquid23 { get; set; } // nIdDetLiquid23

        // Foreign keys

        /// <summary>
        /// Parent Admin_Adminc28ConceptosCuenta pointed by [ADMINO_16_DETALLES_CUENTAS_GASTOS].([NIdConcep28]) (FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_ADMINC_28_CONCEPTOS_CUENTAS)
        /// </summary>
        public virtual Admin_Adminc28ConceptosCuenta Admin_Adminc28ConceptosCuenta { get; set; } // FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_ADMINC_28_CONCEPTOS_CUENTAS

        /// <summary>
        /// Parent Admin_Admino09DetallesPagoCliente pointed by [ADMINO_16_DETALLES_CUENTAS_GASTOS].([NIdDetPago09]) (FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_ADMINO_09_DETALLES_PAGO_CLIENTE)
        /// </summary>
        public virtual Admin_Admino09DetallesPagoCliente Admin_Admino09DetallesPagoCliente { get; set; } // FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_ADMINO_09_DETALLES_PAGO_CLIENTE

        /// <summary>
        /// Parent Admin_Admino10PagosCliente pointed by [ADMINO_16_DETALLES_CUENTAS_GASTOS].([NIdPagoCli10]) (FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_ADMINO_10_PAGOS_CLIENTES)
        /// </summary>
        public virtual Admin_Admino10PagosCliente Admin_Admino10PagosCliente { get; set; } // FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_ADMINO_10_PAGOS_CLIENTES

        /// <summary>
        /// Parent Admin_Admino12DetallesAnticiposCliente pointed by [ADMINO_16_DETALLES_CUENTAS_GASTOS].([NIdDetAnticipo12]) (FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_ADMINO_12_DETALLES_ANTICIPOS_CLIENTE)
        /// </summary>
        public virtual Admin_Admino12DetallesAnticiposCliente Admin_Admino12DetallesAnticiposCliente { get; set; } // FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_ADMINO_12_DETALLES_ANTICIPOS_CLIENTE

        /// <summary>
        /// Parent Admin_Admino13AnticiposCliente pointed by [ADMINO_16_DETALLES_CUENTAS_GASTOS].([NIdPagoCli13]) (FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_ADMINO_13_ANTICIPOS_CLIENTES)
        /// </summary>
        public virtual Admin_Admino13AnticiposCliente Admin_Admino13AnticiposCliente { get; set; } // FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_ADMINO_13_ANTICIPOS_CLIENTES

        /// <summary>
        /// Parent Admin_Admino15CuentasGasto pointed by [ADMINO_16_DETALLES_CUENTAS_GASTOS].([NIdCtaGastos15]) (FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_ADMINO_15_CUENTAS_GASTOS)
        /// </summary>
        public virtual Admin_Admino15CuentasGasto Admin_Admino15CuentasGasto { get; set; } // FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_ADMINO_15_CUENTAS_GASTOS

        /// <summary>
        /// Parent Admin_Admino23DetallesLiquidacione pointed by [ADMINO_16_DETALLES_CUENTAS_GASTOS].([NIdDetLiquid23]) (FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_ADMINO_23_DETALLES_LIQUIDACIONES)
        /// </summary>
        public virtual Admin_Admino23DetallesLiquidacione Admin_Admino23DetallesLiquidacione { get; set; } // FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_ADMINO_23_DETALLES_LIQUIDACIONES

        /// <summary>
        /// Parent SIR_Sir60Referencia pointed by [ADMINO_16_DETALLES_CUENTAS_GASTOS].([NIdReferencia60]) (FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_SIR_60_REFERENCIAS)
        /// </summary>
        public virtual SIR_Sir60Referencia SIR_Sir60Referencia { get; set; } // FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_SIR_60_REFERENCIAS

        /// <summary>
        /// Parent SIR_Sir71SucursalPatenteAduana pointed by [ADMINO_16_DETALLES_CUENTAS_GASTOS].([NIdSucPatAdu71]) (FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_SIR_71_SUCURSAL_PATENTE_ADUANA)
        /// </summary>
        public virtual SIR_Sir71SucursalPatenteAduana SIR_Sir71SucursalPatenteAduana { get; set; } // FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_SIR_71_SUCURSAL_PATENTE_ADUANA
    }

}
// </auto-generated>