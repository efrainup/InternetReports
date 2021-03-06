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

    // SIR_605_STATUS_ENTRADA_SALIDA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir605StatusEntradaSalida
    {
        [Required]
        [Display(Name = "N ID status 605")]
        public int NIdStatus605 { get; set; } // nIdStatus605 (Primary key)

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha status")]
        public System.DateTime? DFechaStatus { get; set; } // dFechaStatus

        [Display(Name = "N ID entrada salida 602")]
        public int? NIdEntradaSalida602 { get; set; } // nIdEntradaSalida602

        [Required]
        [Display(Name = "N estatus patio")]
        public byte NEstatusPatio { get; set; } // nEstatusPatio

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir602EntradaSalidaPatio pointed by [SIR_605_STATUS_ENTRADA_SALIDA].([NIdEntradaSalida602]) (FK_SIR_605_STATUS_ENTRADA_SALIDA_SIR_602_ENTRADA_SALIDA_PATIO)
        /// </summary>
        public virtual SIR_Sir602EntradaSalidaPatio SIR_Sir602EntradaSalidaPatio { get; set; } // FK_SIR_605_STATUS_ENTRADA_SALIDA_SIR_602_ENTRADA_SALIDA_PATIO
    }

}
// </auto-generated>
