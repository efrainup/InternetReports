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

    // SIR_645_DETALLE_ENVIO_COVE_FACTURAS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir645DetalleEnvioCoveFactura
    {
        [Required]
        [Display(Name = "N ID detalle envio facturas cove 645")]
        public int NIdDetalleEnvioFacturasCove645 { get; set; } // nIdDetalleEnvioFacturasCOVE645 (Primary key)

        [Required]
        [Display(Name = "N ID factura 52")]
        public int NIdFactura52 { get; set; } // nIdFactura52

        [Required]
        [Display(Name = "N ID detalle envio 644")]
        public int NIdDetalleEnvio644 { get; set; } // nIdDetalleEnvio644

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir52Factura pointed by [SIR_645_DETALLE_ENVIO_COVE_FACTURAS].([NIdFactura52]) (FK_SIR_645_DETALLE_ENVIO_COVE_FACTURAS_SIR_52_FACTURAS)
        /// </summary>
        public virtual SIR_Sir52Factura SIR_Sir52Factura { get; set; } // FK_SIR_645_DETALLE_ENVIO_COVE_FACTURAS_SIR_52_FACTURAS

        /// <summary>
        /// Parent SIR_Sir644DetalleEnvioCove pointed by [SIR_645_DETALLE_ENVIO_COVE_FACTURAS].([NIdDetalleEnvio644]) (FK_SIR_645_DETALLE_ENVIO_COVE_FACTURAS_SIR_644_DETALLE_ENVIO_COVE)
        /// </summary>
        public virtual SIR_Sir644DetalleEnvioCove SIR_Sir644DetalleEnvioCove { get; set; } // FK_SIR_645_DETALLE_ENVIO_COVE_FACTURAS_SIR_644_DETALLE_ENVIO_COVE
    }

}
// </auto-generated>