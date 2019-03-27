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

    // The table 'nuevos_j' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    // nuevos_j
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class NuevosJ
    {
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Referencia")]
        public string Referencia { get; set; } // referencia (length: 255)

        [Display(Name = "Pedimentos")]
        public double? Pedimentos { get; set; } // pedimentos

        [DataType(DataType.DateTime)]
        [Display(Name = "Fechapago")]
        public System.DateTime? Fechapago { get; set; } // fechapago

        [Display(Name = "Movimiento")]
        public double? Movimiento { get; set; } // movimiento

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Claveped")]
        public string Claveped { get; set; } // claveped (length: 255)

        [Display(Name = "Idcliente")]
        public double? Idcliente { get; set; } // idcliente

        [Display(Name = "Aduana")]
        public double? Aduana { get; set; } // aduana

        [Display(Name = "Patente")]
        public double? Patente { get; set; } // patente
    }

}
// </auto-generated>