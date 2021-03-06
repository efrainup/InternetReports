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

    // The table 'SIR_450_SUCURSAL_DIAS_NO_LABORABLES' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    // SIR_450_SUCURSAL_DIAS_NO_LABORABLES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir450SucursalDiasNoLaborable
    {
        [Display(Name = "N ID dias no laborables 449")]
        public int? NIdDiasNoLaborables449 { get; set; } // nIdDiasNoLaborables449

        [Display(Name = "N ID suc pat adu 71")]
        public int? NIdSucPatAdu71 { get; set; } // nIdSucPatAdu71

        [Display(Name = "B no labora sabado")]
        public bool? BNoLaboraSabado { get; set; } // bNoLaboraSabado

        [Display(Name = "B no labora domingo")]
        public bool? BNoLaboraDomingo { get; set; } // bNoLaboraDomingo

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir449DiasNoLaborable pointed by [SIR_450_SUCURSAL_DIAS_NO_LABORABLES].([NIdDiasNoLaborables449]) (FK_SIR_450_SUCURSAL_DIAS_NO_LABORABLES_SIR_449_DIAS_NO_LABORABLES)
        /// </summary>
        public virtual SIR_Sir449DiasNoLaborable SIR_Sir449DiasNoLaborable { get; set; } // FK_SIR_450_SUCURSAL_DIAS_NO_LABORABLES_SIR_449_DIAS_NO_LABORABLES

        /// <summary>
        /// Parent SIR_Sir71SucursalPatenteAduana pointed by [SIR_450_SUCURSAL_DIAS_NO_LABORABLES].([NIdSucPatAdu71]) (FK_SIR_450_SUCURSAL_DIAS_NO_LABORABLES_SIR_71_SUCURSAL_PATENTE_ADUANA)
        /// </summary>
        public virtual SIR_Sir71SucursalPatenteAduana SIR_Sir71SucursalPatenteAduana { get; set; } // FK_SIR_450_SUCURSAL_DIAS_NO_LABORABLES_SIR_71_SUCURSAL_PATENTE_ADUANA
    }

}
// </auto-generated>
