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

    // DB_Partidas_Pedimento
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class DbPartidasPedimento
    {
        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S referencia")]
        public string SReferencia { get; set; } // sReferencia (Primary key) (length: 20)

        [Required]
        [Display(Name = "N numero")]
        public int NNumero { get; set; } // nNumero (Primary key)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "S descripcion aa")]
        public string SDescripcionAa { get; set; } // sDescripcionAA (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S fraccion")]
        public string SFraccion { get; set; } // sFraccion (Primary key) (length: 20)

        [Required]
        [Display(Name = "N cant comercial")]
        public decimal NCantComercial { get; set; } // nCantComercial (Primary key)

        [Required]
        [Display(Name = "N umc")]
        public int NUmc { get; set; } // nUMC (Primary key)

        [Required]
        [Display(Name = "N cant tarifa")]
        public decimal NCantTarifa { get; set; } // nCantTarifa (Primary key)

        [Required]
        [Display(Name = "N umt")]
        public int NUmt { get; set; } // nUMT (Primary key)

        [Display(Name = "N metodo valoracion")]
        public int? NMetodoValoracion { get; set; } // nMetodoValoracion

        [Display(Name = "N vinculacion")]
        public int? NVinculacion { get; set; } // nVinculacion

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S num factura")]
        public string SNumFactura { get; set; } // sNumFactura (length: 50)

        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "S pais od")]
        public string SPaisOd { get; set; } // sPaisOD (length: 3)

        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "S pais vc")]
        public string SPaisVc { get; set; } // sPaisVC (length: 3)

        [Display(Name = "N precio unitario")]
        public decimal? NPrecioUnitario { get; set; } // nPrecioUnitario

        [Display(Name = "S observaciones")]
        public string SObservaciones { get; set; } // sObservaciones

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S parte")]
        public string SParte { get; set; } // sParte (length: 100)

        [Display(Name = "N precio pagado")]
        public decimal? NPrecioPagado { get; set; } // nPrecioPagado

        [Display(Name = "N valor dolares")]
        public decimal? NValorDolares { get; set; } // nValorDolares

        [Display(Name = "N agrupado")]
        public int? NAgrupado { get; set; } // nAgrupado

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S num serie")]
        public string SNumSerie { get; set; } // sNumSerie (length: 100)

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S codigo producto")]
        public string SCodigoProducto { get; set; } // sCodigoProducto (length: 100)

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S marca producto")]
        public string SMarcaProducto { get; set; } // sMarcaProducto (length: 100)

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S modelo producto")]
        public string SModeloProducto { get; set; } // sModeloProducto (length: 100)

        [Display(Name = "N valor aduana")]
        public decimal? NValorAduana { get; set; } // nValorAduana

        [Display(Name = "N valor mercancia")]
        public decimal? NValorMercancia { get; set; } // nValorMercancia

        [Display(Name = "N valor agregado")]
        public decimal? NValorAgregado { get; set; } // nValorAgregado
    }

}
// </auto-generated>