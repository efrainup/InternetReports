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

    // SIR_198_COTIZACION_OBSERV
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir198CotizacionObserv
    {
        [Required]
        [Display(Name = "N ID cot obs 198")]
        public int NIdCotObs198 { get; set; } // nIdCotObs198 (Primary key)

        [Required]
        [Display(Name = "N ID cotizacion 123")]
        public int NIdCotizacion123 { get; set; } // nIdCotizacion123

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "S observacion")]
        public string SObservacion { get; set; } // sObservacion

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_198_COTIZACION_OBSERV].([NIdUsuarioEd]) (FK_SIR_198_COTIZACION_OBSERV_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_198_COTIZACION_OBSERV_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir123Cotizacione pointed by [SIR_198_COTIZACION_OBSERV].([NIdCotizacion123]) (FK_SIR_198_COTIZACION_OBSERV_SIR_123_COTIZACIONES)
        /// </summary>
        public virtual SIR_Sir123Cotizacione SIR_Sir123Cotizacione { get; set; } // FK_SIR_198_COTIZACION_OBSERV_SIR_123_COTIZACIONES

        public SIR_Sir198CotizacionObserv()
        {
            DFechaEdicion = System.DateTime.Now;
        }
    }

}
// </auto-generated>