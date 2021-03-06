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

    // CDP_CFDIRecibidosEncabezado_SATComprobante
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CdpCfdiRecibidosEncabezadoSatComprobante
    {

        ///<summary>
        /// Tabla de encabezados de los CFDI recibidos por parte de proveedores
        ///</summary>
        [Required]
        [Display(Name = "Id comprobante")]
        public int IdComprobante { get; set; } // IdComprobante (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(13)]
        [StringLength(13)]
        [Display(Name = "Rfce misor")]
        public string RfcEmisor { get; set; } // RFCEmisor (length: 13)

        [MaxLength(254)]
        [StringLength(254)]
        [Display(Name = "Nombre emisor")]
        public string NombreEmisor { get; set; } // NombreEmisor (length: 254)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(13)]
        [StringLength(13)]
        [Display(Name = "Rfcr eceptor")]
        public string RfcReceptor { get; set; } // RFCReceptor (length: 13)

        [MaxLength(254)]
        [StringLength(254)]
        [Display(Name = "Nombre receptor")]
        public string NombreReceptor { get; set; } // NombreReceptor (length: 254)

        [MaxLength(512)]
        [StringLength(512)]
        [Display(Name = "Ruta descarga xml")]
        public string RutaDescargaXml { get; set; } // RutaDescargaXml (length: 512)

        [MaxLength(512)]
        [StringLength(512)]
        [Display(Name = "Ruta descarga pdf")]
        public string RutaDescargaPdf { get; set; } // RutaDescargaPdf (length: 512)

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha descarga")]
        public System.DateTime? FechaDescarga { get; set; } // FechaDescarga

        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Tipo de comprobante")]
        public string TipoDeComprobante { get; set; } // TipoDeComprobante (length: 1)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(36)]
        [StringLength(36)]
        [Display(Name = "Uuid")]
        public string Uuid { get; set; } // UUID (length: 36)
    }

}
// </auto-generated>
