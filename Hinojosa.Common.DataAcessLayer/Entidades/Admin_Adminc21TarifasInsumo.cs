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

    // ADMINC_21_TARIFAS_INSUMOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Admin_Adminc21TarifasInsumo
    {
        [Required]
        [Display(Name = "N ID tarifa ins 21")]
        public int NIdTarifaIns21 { get; set; } // nIdTarifaIns21 (Primary key)

        [Required]
        [Display(Name = "N ID insumo 20")]
        public int NIdInsumo20 { get; set; } // nIdInsumo20

        [Required]
        [Display(Name = "N precio")]
        public decimal NPrecio { get; set; } // nPrecio

        [Required]
        [Display(Name = "D inicio")]
        public System.DateTime DInicio { get; set; } // dInicio

        [Required]
        [Display(Name = "D fin")]
        public System.DateTime DFin { get; set; } // dFin

        // Foreign keys

        /// <summary>
        /// Parent Admin_Adminc20Insumo pointed by [ADMINC_21_TARIFAS_INSUMOS].([NIdInsumo20]) (FK_ADMINC_21_TARIFAS_INSUMOS_ADMINC_20_INSUMOS)
        /// </summary>
        public virtual Admin_Adminc20Insumo Admin_Adminc20Insumo { get; set; } // FK_ADMINC_21_TARIFAS_INSUMOS_ADMINC_20_INSUMOS
    }

}
// </auto-generated>
