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

    // SIR_752_CAT_SERVICIO_NOCONFORME
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir752CatServicioNoconforme
    {
        [Required]
        [Display(Name = "N ID cat servicio no conforme 752")]
        public int NIdCatServicioNoConforme752 { get; set; } // nIdCatServicioNoConforme752 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S clave")]
        public string SClave { get; set; } // sClave (length: 30)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 1000)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha")]
        public System.DateTime DFecha { get; set; } // dFecha

        [Required]
        [Display(Name = "N status vig")]
        public byte NStatusVig { get; set; } // nStatusVig

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir753ServiciosNoconforme where [SIR_753_SERVICIOS_NOCONFORME].[nIdCatServicioNoConforme752] point to this entity (FK_SIR_753_SERVICIOS_NOCONFORME_SIR_752_CAT_SERVICIO_NOCONFORME)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir753ServiciosNoconforme> SIR_Sir753ServiciosNoconforme { get; set; } // SIR_753_SERVICIOS_NOCONFORME.FK_SIR_753_SERVICIOS_NOCONFORME_SIR_752_CAT_SERVICIO_NOCONFORME

        public SIR_Sir752CatServicioNoconforme()
        {
            SIR_Sir753ServiciosNoconforme = new System.Collections.Generic.List<SIR_Sir753ServiciosNoconforme>();
        }
    }

}
// </auto-generated>