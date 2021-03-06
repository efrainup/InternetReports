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

    // SIR_449_DIAS_NO_LABORABLES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir449DiasNoLaborable
    {
        [Required]
        [Display(Name = "N ID dias no laborables 449")]
        public int NIdDiasNoLaborables449 { get; set; } // nIdDiasNoLaborables449 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(800)]
        [StringLength(800)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 800)

        [Required]
        [Display(Name = "D fecha")]
        public System.DateTime DFecha { get; set; } // dFecha

        [Required]
        [Display(Name = "N anio")]
        public int NAnio { get; set; } // nAnio

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir450SucursalDiasNoLaborable where [SIR_450_SUCURSAL_DIAS_NO_LABORABLES].[nIdDiasNoLaborables449] point to this entity (FK_SIR_450_SUCURSAL_DIAS_NO_LABORABLES_SIR_449_DIAS_NO_LABORABLES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir450SucursalDiasNoLaborable> SIR_Sir450SucursalDiasNoLaborable { get; set; } // SIR_450_SUCURSAL_DIAS_NO_LABORABLES.FK_SIR_450_SUCURSAL_DIAS_NO_LABORABLES_SIR_449_DIAS_NO_LABORABLES

        public SIR_Sir449DiasNoLaborable()
        {
            SIR_Sir450SucursalDiasNoLaborable = new System.Collections.Generic.List<SIR_Sir450SucursalDiasNoLaborable>();
        }
    }

}
// </auto-generated>
