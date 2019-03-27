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

    // SIR_201_FRACCION_VINS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir201FraccionVin
    {
        [Required]
        [Display(Name = "N ID vin 201")]
        public int NIdVin201 { get; set; } // nIdVIN201 (Primary key)

        [Display(Name = "N ID fac part agrupada 100")]
        public int? NIdFacPartAgrupada100 { get; set; } // nIdFacPartAgrupada100

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S num serie")]
        public string SNumSerie { get; set; } // sNumSerie (length: 100)

        [Required]
        [Display(Name = "N kilometraje")]
        public decimal NKilometraje { get; set; } // nKilometraje

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Display(Name = "N ID factura partida 11")]
        public int? NIdFacturaPartida11 { get; set; } // nIdFacturaPartida11

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_201_FRACCION_VINS].([NIdUsuarioEd]) (FK_SIR_201_FRACCION_VINS_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_201_FRACCION_VINS_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir100FacPartAgrupada pointed by [SIR_201_FRACCION_VINS].([NIdFacPartAgrupada100]) (FK_SIR_201_FRACCION_VINS_SIR_100_FAC_PART_AGRUPADAS)
        /// </summary>
        public virtual SIR_Sir100FacPartAgrupada SIR_Sir100FacPartAgrupada { get; set; } // FK_SIR_201_FRACCION_VINS_SIR_100_FAC_PART_AGRUPADAS

        /// <summary>
        /// Parent SIR_Sir11FacturasPartida pointed by [SIR_201_FRACCION_VINS].([NIdFacturaPartida11]) (FK_SIR_201_FRACCION_VINS_SIR_11_FACTURAS_PARTIDAS)
        /// </summary>
        public virtual SIR_Sir11FacturasPartida SIR_Sir11FacturasPartida { get; set; } // FK_SIR_201_FRACCION_VINS_SIR_11_FACTURAS_PARTIDAS

        public SIR_Sir201FraccionVin()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
        }
    }

}
// </auto-generated>