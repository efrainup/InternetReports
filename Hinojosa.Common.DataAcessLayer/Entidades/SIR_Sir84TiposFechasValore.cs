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

    // SIR_84_TIPOS_FECHAS_VALORES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir84TiposFechasValore
    {
        [Required]
        [Display(Name = "N ID tipo fec val 84")]
        public int NIdTipoFecVal84 { get; set; } // nIdTipoFecVal84 (Primary key)

        [Required]
        [Display(Name = "N ID llave asociada")]
        public int NIdLlaveAsociada { get; set; } // nIdLlaveAsociada

        [Required]
        [Display(Name = "N ID tipo fecha 83")]
        public int NIdTipoFecha83 { get; set; } // nIdTipoFecha83

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D valor fecha")]
        public System.DateTime DValorFecha { get; set; } // dValorFecha

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_84_TIPOS_FECHAS_VALORES].([NIdUsuarioEd]) (FK_SIR_84_TIPOS_FECHAS_VALORES_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_84_TIPOS_FECHAS_VALORES_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir83TiposFecha pointed by [SIR_84_TIPOS_FECHAS_VALORES].([NIdTipoFecha83]) (FK_SIR_84_TIPOS_FECHAS_VALORES_SIR_83_TIPOS_FECHAS)
        /// </summary>
        public virtual SIR_Sir83TiposFecha SIR_Sir83TiposFecha { get; set; } // FK_SIR_84_TIPOS_FECHAS_VALORES_SIR_83_TIPOS_FECHAS

        public SIR_Sir84TiposFechasValore()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
        }
    }

}
// </auto-generated>
