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

    // SIR_444_ADS_SUCURSAL_HORARIO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir444AdsSucursalHorario
    {
        [Required]
        [Display(Name = "N ID horario 438")]
        public int NIdHorario438 { get; set; } // nIdHorario438 (Primary key)

        [Display(Name = "N ID suc pat adu 71")]
        public int? NIdSucPatAdu71 { get; set; } // nIdSucPatAdu71

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir438Horario pointed by [SIR_444_ADS_SUCURSAL_HORARIO].([NIdHorario438]) (FK_SIR_444_ADS_SUCURSAL_HORARIO_SIR_438_HORARIOS)
        /// </summary>
        public virtual SIR_Sir438Horario SIR_Sir438Horario { get; set; } // FK_SIR_444_ADS_SUCURSAL_HORARIO_SIR_438_HORARIOS

        /// <summary>
        /// Parent SIR_Sir71SucursalPatenteAduana pointed by [SIR_444_ADS_SUCURSAL_HORARIO].([NIdSucPatAdu71]) (FK_SIR_444_ADS_SUCURSAL_HORARIO_SIR_71_SUCURSAL_PATENTE_ADUANA)
        /// </summary>
        public virtual SIR_Sir71SucursalPatenteAduana SIR_Sir71SucursalPatenteAduana { get; set; } // FK_SIR_444_ADS_SUCURSAL_HORARIO_SIR_71_SUCURSAL_PATENTE_ADUANA
    }

}
// </auto-generated>