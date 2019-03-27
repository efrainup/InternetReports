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

    // SIR_369_ENTIDAD_TRASMISORA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir369EntidadTrasmisora
    {
        [Required]
        [Display(Name = "N ID trasmisora 369")]
        public int NIdTrasmisora369 { get; set; } // nIdTrasmisora369 (Primary key)

        [Required]
        [Display(Name = "N clave")]
        public int NClave { get; set; } // nClave

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 500)

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir370LiberacionElectronicaGuia where [SIR_370_LIBERACION_ELECTRONICA_GUIAS].[nIdTrasmisora369] point to this entity (FK_SIR_370_LIB_ELECTRONICA_GUIAS_SIR_369_ENTIDAD_TRASMISORA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir370LiberacionElectronicaGuia> SIR_Sir370LiberacionElectronicaGuia { get; set; } // SIR_370_LIBERACION_ELECTRONICA_GUIAS.FK_SIR_370_LIB_ELECTRONICA_GUIAS_SIR_369_ENTIDAD_TRASMISORA

        public SIR_Sir369EntidadTrasmisora()
        {
            SIR_Sir370LiberacionElectronicaGuia = new System.Collections.Generic.List<SIR_Sir370LiberacionElectronicaGuia>();
        }
    }

}
// </auto-generated>
