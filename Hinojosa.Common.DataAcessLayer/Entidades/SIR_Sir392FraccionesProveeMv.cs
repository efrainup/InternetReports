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

    // SIR_392_FRACCIONES_PROVEE_MV
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir392FraccionesProveeMv
    {
        [Required]
        [Display(Name = "N ID fracc provee mv 392")]
        public int NIdFraccProveeMv392 { get; set; } // nIdFraccProveeMV392 (Primary key)

        [Required]
        [Display(Name = "N ID fac part agrupada 100")]
        public int NIdFacPartAgrupada100 { get; set; } // nIdFacPartAgrupada100

        [Required]
        [Display(Name = "N ID proveedor 42")]
        public int NIdProveedor42 { get; set; } // nIdProveedor42

        [Required]
        [Display(Name = "N ID man valor 251")]
        public int NIdManValor251 { get; set; } // nIdManValor251

        [Required]
        [Display(Name = "N ID factura 52")]
        public int NIdFactura52 { get; set; } // nIdFactura52

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir100FacPartAgrupada pointed by [SIR_392_FRACCIONES_PROVEE_MV].([NIdFacPartAgrupada100]) (FK_SIR_392_FRACCIONES_PROVEE_MV_SIR_100_FAC_PART_AGRUPADAS)
        /// </summary>
        public virtual SIR_Sir100FacPartAgrupada SIR_Sir100FacPartAgrupada { get; set; } // FK_SIR_392_FRACCIONES_PROVEE_MV_SIR_100_FAC_PART_AGRUPADAS

        /// <summary>
        /// Parent SIR_Sir251ManifestacionesValor pointed by [SIR_392_FRACCIONES_PROVEE_MV].([NIdManValor251]) (FK_SIR_392_FRACCIONES_PROVEE_MV_SIR_251_MANIFESTACIONES_VALOR)
        /// </summary>
        public virtual SIR_Sir251ManifestacionesValor SIR_Sir251ManifestacionesValor { get; set; } // FK_SIR_392_FRACCIONES_PROVEE_MV_SIR_251_MANIFESTACIONES_VALOR

        /// <summary>
        /// Parent SIR_Sir42Proveedore pointed by [SIR_392_FRACCIONES_PROVEE_MV].([NIdProveedor42]) (FK_SIR_392_FRACCIONES_PROVEE_MV_SIR_42_PROVEEDORES)
        /// </summary>
        public virtual SIR_Sir42Proveedore SIR_Sir42Proveedore { get; set; } // FK_SIR_392_FRACCIONES_PROVEE_MV_SIR_42_PROVEEDORES

        /// <summary>
        /// Parent SIR_Sir52Factura pointed by [SIR_392_FRACCIONES_PROVEE_MV].([NIdFactura52]) (FK_SIR_392_FRACCIONES_PROVEE_MV_SIR_52_FACTURAS)
        /// </summary>
        public virtual SIR_Sir52Factura SIR_Sir52Factura { get; set; } // FK_SIR_392_FRACCIONES_PROVEE_MV_SIR_52_FACTURAS
    }

}
// </auto-generated>
