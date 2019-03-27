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

    // SIR_245_ARCHIVOS_PAGOS_PED
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir245ArchivosPagosPed
    {
        [Required]
        [Display(Name = "N ID pap 245")]
        public int NIdPap245 { get; set; } // nIdPAP245 (Primary key)

        [Required]
        [Display(Name = "N ID ap 244")]
        public int NIdAp244 { get; set; } // nIdAP244

        [Required]
        [Display(Name = "N ID pedimento 149")]
        public int NIdPedimento149 { get; set; } // nIdPedimento149

        [Display(Name = "N tipo cuenta")]
        public byte? NTipoCuenta { get; set; } // nTipoCuenta

        [Display(Name = "N ID cta bco 239")]
        public int? NIdCtaBco239 { get; set; } // nIdCtaBco239

        [Display(Name = "N ID cta clie 240")]
        public int? NIdCtaClie240 { get; set; } // nIdCtaClie240

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Display(Name = "N recibe pago")]
        public byte? NRecibePago { get; set; } // nRecibePago

        [Display(Name = "B cve anterior")]
        public bool? BCveAnterior { get; set; } // bCveAnterior

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_245_ARCHIVOS_PAGOS_PED].([NIdUsuarioEd]) (FK_SIR_245_ARCHIVOS_PAGOS_PED_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_245_ARCHIVOS_PAGOS_PED_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir149Pedimento pointed by [SIR_245_ARCHIVOS_PAGOS_PED].([NIdPedimento149]) (FK_SIR_245_ARCHIVOS_PAGOS_PED_SIR_149_PEDIMENTO)
        /// </summary>
        public virtual SIR_Sir149Pedimento SIR_Sir149Pedimento { get; set; } // FK_SIR_245_ARCHIVOS_PAGOS_PED_SIR_149_PEDIMENTO

        /// <summary>
        /// Parent SIR_Sir239CuentasBanco pointed by [SIR_245_ARCHIVOS_PAGOS_PED].([NIdCtaBco239]) (FK_SIR_245_ARCHIVOS_PAGOS_PED_SIR_239_CUENTAS_BANCOS)
        /// </summary>
        public virtual SIR_Sir239CuentasBanco SIR_Sir239CuentasBanco { get; set; } // FK_SIR_245_ARCHIVOS_PAGOS_PED_SIR_239_CUENTAS_BANCOS

        /// <summary>
        /// Parent SIR_Sir240CuentasCliente pointed by [SIR_245_ARCHIVOS_PAGOS_PED].([NIdCtaClie240]) (FK_SIR_245_ARCHIVOS_PAGOS_PED_SIR_240_CUENTAS_CLIENTES)
        /// </summary>
        public virtual SIR_Sir240CuentasCliente SIR_Sir240CuentasCliente { get; set; } // FK_SIR_245_ARCHIVOS_PAGOS_PED_SIR_240_CUENTAS_CLIENTES

        /// <summary>
        /// Parent SIR_Sir244ArchivosPago pointed by [SIR_245_ARCHIVOS_PAGOS_PED].([NIdAp244]) (FK_SIR_245_ARCHIVOS_PAGOS_PED_SIR_244_ARCHIVOS_PAGOS)
        /// </summary>
        public virtual SIR_Sir244ArchivosPago SIR_Sir244ArchivosPago { get; set; } // FK_SIR_245_ARCHIVOS_PAGOS_PED_SIR_244_ARCHIVOS_PAGOS

        public SIR_Sir245ArchivosPagosPed()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
        }
    }

}
// </auto-generated>