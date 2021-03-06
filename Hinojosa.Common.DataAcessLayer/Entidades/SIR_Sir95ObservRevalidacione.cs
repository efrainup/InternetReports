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

    // SIR_95_OBSERV_REVALIDACIONES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir95ObservRevalidacione
    {
        [Required]
        [Display(Name = "N ID rev observ 95")]
        public int NIdRevObserv95 { get; set; } // nIdRevObserv95 (Primary key)

        [Required]
        [Display(Name = "N ID revalidacion 50")]
        public int NIdRevalidacion50 { get; set; } // nIdRevalidacion50

        [Required]
        [Display(Name = "N ID usuario")]
        public int NIdUsuario { get; set; } // nIdUsuario

        [Display(Name = "S observacion")]
        public string SObservacion { get; set; } // sObservacion

        [Required]
        [Display(Name = "D fecha")]
        public System.DateTime DFecha { get; set; } // dFecha

        [Required]
        [Display(Name = "N tipo")]
        public byte NTipo { get; set; } // nTipo

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_95_OBSERV_REVALIDACIONES].([NIdUsuario]) (FK_SIR_95_OBSERV_REVALIDACIONES_cat_usr)
        /// </summary>
        public virtual CatUsr CatUsr_NIdUsuario { get; set; } // FK_SIR_95_OBSERV_REVALIDACIONES_cat_usr

        /// <summary>
        /// Parent CatUsr pointed by [SIR_95_OBSERV_REVALIDACIONES].([NIdUsuarioEd]) (FK_SIR_95_OBSERV_REVALIDACIONES_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr_NIdUsuarioEd { get; set; } // FK_SIR_95_OBSERV_REVALIDACIONES_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir50Revalidacion pointed by [SIR_95_OBSERV_REVALIDACIONES].([NIdRevalidacion50]) (FK_SIR_95_OBSERV_REVALIDACIONES_SIR_50_REVALIDACION)
        /// </summary>
        public virtual SIR_Sir50Revalidacion SIR_Sir50Revalidacion { get; set; } // FK_SIR_95_OBSERV_REVALIDACIONES_SIR_50_REVALIDACION

        public SIR_Sir95ObservRevalidacione()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
        }
    }

}
// </auto-generated>
