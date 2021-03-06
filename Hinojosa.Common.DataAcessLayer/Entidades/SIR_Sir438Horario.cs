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

    // SIR_438_HORARIOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir438Horario
    {
        [Required]
        [Display(Name = "N ID horario 438")]
        public int NIdHorario438 { get; set; } // nIdHorario438 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(800)]
        [StringLength(800)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 800)

        [Required]
        [Display(Name = "N hora inicio")]
        public byte NHoraInicio { get; set; } // nHoraInicio

        [Required]
        [Display(Name = "N hora final")]
        public byte NHoraFinal { get; set; } // nHoraFinal

        [Required]
        [Display(Name = "N minuto inicio")]
        public byte NMinutoInicio { get; set; } // nMinutoInicio

        [Required]
        [Display(Name = "N minuto final")]
        public byte NMinutoFinal { get; set; } // nMinutoFinal

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) SIR_Sir438Horario pointed by [SIR_439_USUARIO_HORARIOS].[nIdHorario438] (FK_SIR_439_USUARIO_HORARIOS_SIR_438_HORARIOS)
        /// </summary>
        public virtual SIR_Sir439UsuarioHorario SIR_Sir439UsuarioHorario { get; set; } // SIR_439_USUARIO_HORARIOS.FK_SIR_439_USUARIO_HORARIOS_SIR_438_HORARIOS
        /// <summary>
        /// Parent (One-to-One) SIR_Sir438Horario pointed by [SIR_444_ADS_SUCURSAL_HORARIO].[nIdHorario438] (FK_SIR_444_ADS_SUCURSAL_HORARIO_SIR_438_HORARIOS)
        /// </summary>
        public virtual SIR_Sir444AdsSucursalHorario SIR_Sir444AdsSucursalHorario { get; set; } // SIR_444_ADS_SUCURSAL_HORARIO.FK_SIR_444_ADS_SUCURSAL_HORARIO_SIR_438_HORARIOS
    }

}
// </auto-generated>
