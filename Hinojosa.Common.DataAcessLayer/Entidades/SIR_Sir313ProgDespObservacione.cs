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

    // SIR_313_PROG_DESP_OBSERVACIONES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir313ProgDespObservacione
    {
        [Required]
        [Display(Name = "N ID desp obs 313")]
        public int NIdDespObs313 { get; set; } // nIdDespObs313 (Primary key)

        [Required]
        [Display(Name = "N ID prog desp 134")]
        public int NIdProgDesp134 { get; set; } // nIdProgDesp134

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S observacion")]
        public string SObservacion { get; set; } // sObservacion (length: 500)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_313_PROG_DESP_OBSERVACIONES].([NIdUsuarioEd]) (FK_SIR_313_PROG_DESP_OBSERVACIONES_cat_usr)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_313_PROG_DESP_OBSERVACIONES_cat_usr

        /// <summary>
        /// Parent SIR_Sir134ProgramacionDespacho pointed by [SIR_313_PROG_DESP_OBSERVACIONES].([NIdProgDesp134]) (FK_SIR_313_PROG_DESP_OBSERVACIONES_SIR_134_PROGRAMACION_DESPACHOS)
        /// </summary>
        public virtual SIR_Sir134ProgramacionDespacho SIR_Sir134ProgramacionDespacho { get; set; } // FK_SIR_313_PROG_DESP_OBSERVACIONES_SIR_134_PROGRAMACION_DESPACHOS

        public SIR_Sir313ProgDespObservacione()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
        }
    }

}
// </auto-generated>
