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

    // SIR_119_DET_HIST_CARGA_TERM
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir119DetHistCargaTerm
    {
        [Required]
        [Display(Name = "N ID histo carga 119")]
        public int NIdHistoCarga119 { get; set; } // nIdHistoCarga119 (Primary key)

        [Required]
        [Display(Name = "N cantidad")]
        public decimal NCantidad { get; set; } // nCantidad

        [Required]
        [Display(Name = "N tipo operacion")]
        public byte NTipoOperacion { get; set; } // nTipoOperacion

        [Required]
        [Display(Name = "N tipo carga")]
        public byte NTipoCarga { get; set; } // nTipoCarga

        [Required]
        [Display(Name = "N ID histo carga 118")]
        public int NIdHistoCarga118 { get; set; } // nIdHistoCarga118

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_119_DET_HIST_CARGA_TERM].([NIdUsuarioEd]) (FK_SIR_119_DET_HIST_CARGA_TERM_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_119_DET_HIST_CARGA_TERM_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir118HistCargaTerm pointed by [SIR_119_DET_HIST_CARGA_TERM].([NIdHistoCarga118]) (FK_SIR_119_DET_HIST_CARGA_TERM_SIR_118_HIST_CARGA_TERM)
        /// </summary>
        public virtual SIR_Sir118HistCargaTerm SIR_Sir118HistCargaTerm { get; set; } // FK_SIR_119_DET_HIST_CARGA_TERM_SIR_118_HIST_CARGA_TERM

        public SIR_Sir119DetHistCargaTerm()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
        }
    }

}
// </auto-generated>
