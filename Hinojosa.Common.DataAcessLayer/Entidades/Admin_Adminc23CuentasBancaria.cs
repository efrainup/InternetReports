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

    // ADMINC_23_CUENTAS_BANCARIAS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Admin_Adminc23CuentasBancaria
    {
        [Required]
        [Display(Name = "N ID cat cheques 23")]
        public int NIdCatCheques23 { get; set; } // nIdCatCheques23 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S cuenta")]
        public string SCuenta { get; set; } // sCuenta (length: 20)

        [Required]
        [Display(Name = "N ID bancos 22")]
        public int NIdBancos22 { get; set; } // nIdBancos22

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S formato")]
        public string SFormato { get; set; } // sFormato (length: 500)

        [Required]
        [Display(Name = "N consecutivo")]
        public int NConsecutivo { get; set; } // nConsecutivo

        [MaxLength(18)]
        [StringLength(18)]
        [Display(Name = "S clabe")]
        public string SClabe { get; set; } // sCLABE (length: 18)

        [Display(Name = "N clave")]
        public int? NClave { get; set; } // nClave

        [Display(Name = "N ID cuenta 27")]
        public int? NIdCuenta27 { get; set; } // nIdCuenta27

        // Reverse navigation

        /// <summary>
        /// Child Admin_Admino10PagosCliente where [ADMINO_10_PAGOS_CLIENTES].[nIdCatCheques23] point to this entity (FK_ADMINO_10_PAGOS_CLIENTES_ADMINC_23_CUENTAS_BANCARIAS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Admin_Admino10PagosCliente> Admin_Admino10PagosCliente { get; set; } // ADMINO_10_PAGOS_CLIENTES.FK_ADMINO_10_PAGOS_CLIENTES_ADMINC_23_CUENTAS_BANCARIAS
        /// <summary>
        /// Child Admin_Admino13AnticiposCliente where [ADMINO_13_ANTICIPOS_CLIENTES].[nIdCatCheques23] point to this entity (FK_ADMINO_13_ANTICIPOS_CLIENTES_ADMINC_23_CUENTAS_BANCARIAS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Admin_Admino13AnticiposCliente> Admin_Admino13AnticiposCliente { get; set; } // ADMINO_13_ANTICIPOS_CLIENTES.FK_ADMINO_13_ANTICIPOS_CLIENTES_ADMINC_23_CUENTAS_BANCARIAS
        /// <summary>
        /// Child Admin_Admino22Liquidacione where [ADMINO_22_LIQUIDACIONES].[nIdCuentaDeposito23] point to this entity (FK_ADMINO_22_LIQUIDACIONES_ADMINC_23_CUENTAS_BANCARIAS_nIdCuentaDeposito23)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Admin_Admino22Liquidacione> Admin_Admino22Liquidacione_NIdCuentaDeposito23 { get; set; } // ADMINO_22_LIQUIDACIONES.FK_ADMINO_22_LIQUIDACIONES_ADMINC_23_CUENTAS_BANCARIAS_nIdCuentaDeposito23
        /// <summary>
        /// Child Admin_Admino22Liquidacione where [ADMINO_22_LIQUIDACIONES].[nIdCuentaTransf23] point to this entity (FK_ADMINO_22_LIQUIDACIONES_ADMINC_23_CUENTAS_BANCARIAS_nIdCuentaTransf23)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Admin_Admino22Liquidacione> Admin_Admino22Liquidacione_NIdCuentaTransf23 { get; set; } // ADMINO_22_LIQUIDACIONES.FK_ADMINO_22_LIQUIDACIONES_ADMINC_23_CUENTAS_BANCARIAS_nIdCuentaTransf23
        /// <summary>
        /// Child SIR_Sir239CuentasBanco where [SIR_239_CUENTAS_BANCOS].[nIdCuentaBanco23] point to this entity (FK_SIR_239_CUENTAS_BANCOS_ADMINC_23_CUENTAS_BANCARIAS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir239CuentasBanco> SIR_Sir239CuentasBanco { get; set; } // SIR_239_CUENTAS_BANCOS.FK_SIR_239_CUENTAS_BANCOS_ADMINC_23_CUENTAS_BANCARIAS

        // Foreign keys

        /// <summary>
        /// Parent Admin_Adminc22Banco pointed by [ADMINC_23_CUENTAS_BANCARIAS].([NIdBancos22]) (FK_ADMINC_23_CUENTAS_BANCARIAS_ADMINC_22_BANCOS)
        /// </summary>
        public virtual Admin_Adminc22Banco Admin_Adminc22Banco { get; set; } // FK_ADMINC_23_CUENTAS_BANCARIAS_ADMINC_22_BANCOS

        public Admin_Adminc23CuentasBancaria()
        {
            Admin_Admino10PagosCliente = new System.Collections.Generic.List<Admin_Admino10PagosCliente>();
            Admin_Admino13AnticiposCliente = new System.Collections.Generic.List<Admin_Admino13AnticiposCliente>();
            Admin_Admino22Liquidacione_NIdCuentaDeposito23 = new System.Collections.Generic.List<Admin_Admino22Liquidacione>();
            Admin_Admino22Liquidacione_NIdCuentaTransf23 = new System.Collections.Generic.List<Admin_Admino22Liquidacione>();
            SIR_Sir239CuentasBanco = new System.Collections.Generic.List<SIR_Sir239CuentasBanco>();
        }
    }

}
// </auto-generated>