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

    // SIR_320_REGLAS_CRITERIOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir320ReglasCriterio
    {
        [Required]
        [Display(Name = "N ID reg cri 320")]
        public int NIdRegCri320 { get; set; } // nIdRegCri320 (Primary key)

        [Required]
        [Display(Name = "N ID criterio 319")]
        public byte NIdCriterio319 { get; set; } // nIdCriterio319

        [Required]
        [Display(Name = "N ID regula 253")]
        public int NIdRegula253 { get; set; } // nIdRegula253

        [Required]
        [Display(Name = "N tipo")]
        public byte NTipo { get; set; } // nTipo

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir321ImpuestosCriterio where [SIR_321_IMPUESTOS_CRITERIOS].[nIdRegCri320] point to this entity (FK_SIR_321_IMPUESTOS_CRITERIOS_SIR_320_REGLAS_CRITERIOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir321ImpuestosCriterio> SIR_Sir321ImpuestosCriterio { get; set; } // SIR_321_IMPUESTOS_CRITERIOS.FK_SIR_321_IMPUESTOS_CRITERIOS_SIR_320_REGLAS_CRITERIOS

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir253Regularizacione pointed by [SIR_320_REGLAS_CRITERIOS].([NIdRegula253]) (FK_SIR_320_REGLAS_CRITERIOS_SIR_253_REGULARIZACIONES)
        /// </summary>
        public virtual SIR_Sir253Regularizacione SIR_Sir253Regularizacione { get; set; } // FK_SIR_320_REGLAS_CRITERIOS_SIR_253_REGULARIZACIONES

        /// <summary>
        /// Parent SIR_Sir319CriteriosA3 pointed by [SIR_320_REGLAS_CRITERIOS].([NIdCriterio319]) (FK_SIR_320_REGLAS_CRITERIOS_SIR_319_CRITERIOS_A3)
        /// </summary>
        public virtual SIR_Sir319CriteriosA3 SIR_Sir319CriteriosA3 { get; set; } // FK_SIR_320_REGLAS_CRITERIOS_SIR_319_CRITERIOS_A3

        public SIR_Sir320ReglasCriterio()
        {
            SIR_Sir321ImpuestosCriterio = new System.Collections.Generic.List<SIR_Sir321ImpuestosCriterio>();
        }
    }

}
// </auto-generated>
