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

    // SIR_255_DETALLE_MANIFESTACION
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir255DetalleManifestacion
    {
        [Required]
        [Display(Name = "N ID man valor 251")]
        public int NIdManValor251 { get; set; } // nIdManValor251 (Primary key)

        [Required]
        [Display(Name = "N ID proveedor 42")]
        public int NIdProveedor42 { get; set; } // nIdProveedor42 (Primary key)

        [Required]
        [Display(Name = "B vinculacion vendedor")]
        public bool BVinculacionVendedor { get; set; } // bVinculacionVendedor (Primary key)

        [Required]
        [Display(Name = "B vinculacion precio")]
        public bool BVinculacionPrecio { get; set; } // bVinculacionPrecio (Primary key)

        [Display(Name = "B es precio previsto fac")]
        public bool? BEsPrecioPrevistoFac { get; set; } // bEsPrecioPrevistoFac

        [Display(Name = "B es precio otros doctos")]
        public bool? BEsPrecioOtrosDoctos { get; set; } // bEsPrecioOtrosDoctos

        [Display(Name = "B existen con no valor trans")]
        public bool? BExistenConNoValorTrans { get; set; } // bExistenConNoValorTrans

        [Display(Name = "B conceptos desglosados")]
        public bool? BConceptosDesglosados { get; set; } // bConceptosDesglosados

        [Display(Name = "B anexa documentacion mv")]
        public bool? BAnexaDocumentacionMv { get; set; } // bAnexaDocumentacionMV

        [Display(Name = "B no anexa documentacion mv")]
        public bool? BNoAnexaDocumentacionMv { get; set; } // bNoAnexaDocumentacionMV

        [Display(Name = "N importe prec pagado")]
        public byte? NImportePrecPagado { get; set; } // nImportePrecPagado

        [Display(Name = "N opta facturas")]
        public byte? NOptaFacturas { get; set; } // nOptaFacturas

        [Display(Name = "N opta doctos valor aduana")]
        public byte? NOptaDoctosValorAduana { get; set; } // nOptaDoctosValorAduana

        [Display(Name = "N merc regimen impo temporal")]
        public byte? NMercRegimenImpoTemporal { get; set; } // nMercRegimenImpoTemporal

        [Display(Name = "N valor mcias provicional")]
        public byte? NValorMciasProvicional { get; set; } // nValorMciasProvicional

        [Display(Name = "N doc consta valor mcia")]
        public byte? NDocConstaValorMcia { get; set; } // nDocConstaValorMcia

        [Display(Name = "N compra venta")]
        public byte? NCompraVenta { get; set; } // nCompraVenta

        [Display(Name = "N total anexos")]
        public int? NTotalAnexos { get; set; } // nTotalAnexos

        [Display(Name = "B anexa documentacion art 65 mv")]
        public bool? BAnexaDocumentacionArt65Mv { get; set; } // bAnexaDocumentacionArt65MV

        [Display(Name = "B no anexa documentacion art 65 mv")]
        public bool? BNoAnexaDocumentacionArt65Mv { get; set; } // bNoAnexaDocumentacionArt65MV

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir251ManifestacionesValor pointed by [SIR_255_DETALLE_MANIFESTACION].([NIdManValor251]) (FK_SIR_255_DETALLE_MANIFESTACION_SIR_251_MANIFESTACIONES_VALOR)
        /// </summary>
        public virtual SIR_Sir251ManifestacionesValor SIR_Sir251ManifestacionesValor { get; set; } // FK_SIR_255_DETALLE_MANIFESTACION_SIR_251_MANIFESTACIONES_VALOR

        /// <summary>
        /// Parent SIR_Sir42Proveedore pointed by [SIR_255_DETALLE_MANIFESTACION].([NIdProveedor42]) (FK_SIR_255_DETALLE_MANIFESTACION_SIR_42_PROVEEDORES)
        /// </summary>
        public virtual SIR_Sir42Proveedore SIR_Sir42Proveedore { get; set; } // FK_SIR_255_DETALLE_MANIFESTACION_SIR_42_PROVEEDORES
    }

}
// </auto-generated>
