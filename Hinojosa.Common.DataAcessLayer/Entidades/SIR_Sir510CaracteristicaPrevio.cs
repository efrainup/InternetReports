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

    // SIR_510_CARACTERISTICA_PREVIO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir510CaracteristicaPrevio
    {
        [Required]
        [Display(Name = "N ID carac previo 510")]
        public int NIdCaracPrevio510 { get; set; } // nIdCaracPrevio510 (Primary key)

        [Required]
        [Display(Name = "N ID carac 130")]
        public int NIdCarac130 { get; set; } // nIdCarac130

        [Required]
        [Display(Name = "N ID prev ref 161")]
        public int NIdPrevRef161 { get; set; } // nIdPrevRef161

        [Display(Name = "S valor")]
        public string SValor { get; set; } // sValor

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir130Caracteristica pointed by [SIR_510_CARACTERISTICA_PREVIO].([NIdCarac130]) (FK_SIR_510_CARACTERISTICA_PREVIO_SIR_130_CARACTERISTICAS)
        /// </summary>
        public virtual SIR_Sir130Caracteristica SIR_Sir130Caracteristica { get; set; } // FK_SIR_510_CARACTERISTICA_PREVIO_SIR_130_CARACTERISTICAS

        /// <summary>
        /// Parent SIR_Sir161ProgPreviosRef pointed by [SIR_510_CARACTERISTICA_PREVIO].([NIdPrevRef161]) (FK_SIR_510_CARACTERISTICA_PREVIO_SIR_161_PROG_PREVIOS_REF)
        /// </summary>
        public virtual SIR_Sir161ProgPreviosRef SIR_Sir161ProgPreviosRef { get; set; } // FK_SIR_510_CARACTERISTICA_PREVIO_SIR_161_PROG_PREVIOS_REF
    }

}
// </auto-generated>