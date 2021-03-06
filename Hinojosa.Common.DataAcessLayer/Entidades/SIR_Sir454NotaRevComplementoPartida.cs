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

    // SIR_454_NOTA_REV_COMPLEMENTO_PARTIDAS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir454NotaRevComplementoPartida
    {
        [Required]
        [Display(Name = "N ID factura partida 11")]
        public int NIdFacturaPartida11 { get; set; } // nIdFacturaPartida11 (Primary key via unique index UK_nIdFacturaPartida11_SIR_454_NOTA_REV_COMPLEMENTO_PARTIDAS)

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S registro")]
        public string SRegistro { get; set; } // sRegistro (length: 100)

        [Display(Name = "N sobrantes")]
        public decimal? NSobrantes { get; set; } // nSobrantes

        [Display(Name = "N faltantes")]
        public decimal? NFaltantes { get; set; } // nFaltantes

        [Display(Name = "N ID moneda ext 03")]
        public int? NIdMonedaExt03 { get; set; } // nIdMonedaExt03

        [Display(Name = "N factor conversion")]
        public decimal? NFactorConversion { get; set; } // nFactorConversion

        [Display(Name = "S descripcion certificado")]
        public string SDescripcionCertificado { get; set; } // sDescripcionCertificado

        [Display(Name = "S composicion")]
        public string SComposicion { get; set; } // sComposicion

        [Display(Name = "N ID detalles 458")]
        public int? NIdDetalles458 { get; set; } // nIdDetalles458

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S forro")]
        public string SForro { get; set; } // sForro (length: 500)

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S color")]
        public string SColor { get; set; } // sColor (length: 500)

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S talla")]
        public string STalla { get; set; } // sTalla (length: 500)

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S serie")]
        public string SSerie { get; set; } // sSerie (length: 500)

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S lote")]
        public string SLote { get; set; } // sLote (length: 500)

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S marca")]
        public string SMarca { get; set; } // sMarca (length: 500)

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S modelo")]
        public string SModelo { get; set; } // sModelo (length: 500)

        [Display(Name = "S observaciones notas")]
        public string SObservacionesNotas { get; set; } // sObservacionesNotas

        [Display(Name = "S tejido")]
        public string STejido { get; set; } // sTejido

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S codigo ean")]
        public string SCodigoEan { get; set; } // sCodigoEan (length: 500)

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S orden compra")]
        public string SOrdenCompra { get; set; } // sOrdenCompra (length: 500)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "S planta")]
        public string SPlanta { get; set; } // sPlanta (length: 10)

        [MaxLength(35)]
        [StringLength(35)]
        [Display(Name = "S trailer")]
        public string STrailer { get; set; } // sTrailer (length: 35)

        [Display(Name = "N peso bruto")]
        public decimal? NPesoBruto { get; set; } // nPesoBruto

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S lista embarque")]
        public string SListaEmbarque { get; set; } // sListaEmbarque (length: 50)

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S tienda")]
        public string STienda { get; set; } // sTienda (length: 100)

        [Display(Name = "S genero")]
        public string SGenero { get; set; } // sGenero

        [Display(Name = "N valor mpd olares")]
        public decimal? NValorMpDolares { get; set; } // nValorMPDolares

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir03Moneda pointed by [SIR_454_NOTA_REV_COMPLEMENTO_PARTIDAS].([NIdMonedaExt03]) (FK_SIR_454_NOTA_REV_COMPLEMENTO_PARTIDAS_SIR_03_MONEDAS)
        /// </summary>
        public virtual SIR_Sir03Moneda SIR_Sir03Moneda { get; set; } // FK_SIR_454_NOTA_REV_COMPLEMENTO_PARTIDAS_SIR_03_MONEDAS

        /// <summary>
        /// Parent SIR_Sir11FacturasPartida pointed by [SIR_454_NOTA_REV_COMPLEMENTO_PARTIDAS].([NIdFacturaPartida11]) (FK_SIR_454_NOTA_REV_COMPLEMENTO_PARTIDAS_SIR_11_FACTURAS_PARTIDAS)
        /// </summary>
        public virtual SIR_Sir11FacturasPartida SIR_Sir11FacturasPartida { get; set; } // FK_SIR_454_NOTA_REV_COMPLEMENTO_PARTIDAS_SIR_11_FACTURAS_PARTIDAS
    }

}
// </auto-generated>
