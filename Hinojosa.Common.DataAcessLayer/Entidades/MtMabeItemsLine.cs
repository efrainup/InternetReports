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

    // MT_Mabe_ItemsLine
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class MtMabeItemsLine
    {
        [Required]
        [Display(Name = "N ID item")]
        public int NIdItem { get; set; } // nIdItem (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(16)]
        [StringLength(16)]
        [Display(Name = "S referencia")]
        public string SReferencia { get; set; } // sReferencia (length: 16)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(36)]
        [StringLength(36)]
        [Display(Name = "S num factura")]
        public string SNumFactura { get; set; } // sNumFactura (length: 36)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S num parte")]
        public string SNumParte { get; set; } // sNumParte (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S fraccion")]
        public string SFraccion { get; set; } // sFraccion (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(4)]
        [StringLength(4)]
        [Display(Name = "S item line")]
        public string SItemLine { get; set; } // sItemLine (length: 4)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(36)]
        [StringLength(36)]
        [Display(Name = "S folio fiscal")]
        public string SFolioFiscal { get; set; } // sFolioFiscal (length: 36)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S num factura real")]
        public string SNumFacturaReal { get; set; } // sNumFacturaReal (length: 50)

        ///<summary>
        /// 0)Normal; 1)Consignacion
        ///</summary>
        [Display(Name = "S tipo factura")]
        public int? STipoFactura { get; set; } // sTipoFactura

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S num proceso")]
        public string SNumProceso { get; set; } // sNumProceso (length: 50)

        [Display(Name = "N cantidad")]
        public decimal? NCantidad { get; set; } // nCantidad

        [MaxLength(350)]
        [StringLength(350)]
        [Display(Name = "S descripcion aa")]
        public string SDescripcionAa { get; set; } // sDescripcionAA (length: 350)

        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "S pais origen destino")]
        public string SPaisOrigenDestino { get; set; } // sPaisOrigenDestino (length: 3)

        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "S pais vendedor comprador")]
        public string SPaisVendedorComprador { get; set; } // sPaisVendedorComprador (length: 3)

        [Display(Name = "N aplica tl")]
        public int? NAplicaTl { get; set; } // nAplicaTL

        [Display(Name = "N peso")]
        public decimal? NPeso { get; set; } // nPeso

        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "S umc omercial")]
        public string SUmComercial { get; set; } // sUMComercial (length: 5)

        [Display(Name = "N precio unitario")]
        public decimal? NPrecioUnitario { get; set; } // nPrecioUnitario

        [Display(Name = "N valor factura partida")]
        public decimal? NValorFacturaPartida { get; set; } // nValorFacturaPartida

        [Display(Name = "N vinculacion partida")]
        public int? NVinculacionPartida { get; set; } // nVinculacionPartida

        public MtMabeItemsLine()
        {
            NAplicaTl = 0;
            NVinculacionPartida = 0;
        }
    }

}
// </auto-generated>
