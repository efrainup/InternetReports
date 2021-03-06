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

    // Pedimentos_Johnson
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class PedimentosJohnson
    {
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Referencia")]
        public string Referencia { get; set; } // referencia (length: 255)

        [Display(Name = "Pedimento")]
        public int? Pedimento { get; set; } // pedimento

        [DataType(DataType.DateTime)]
        [Display(Name = "Fechapago")]
        public System.DateTime? Fechapago { get; set; } // fechapago

        [Display(Name = "Movimiento")]
        public int? Movimiento { get; set; } // movimiento

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Claveped")]
        public string Claveped { get; set; } // claveped (length: 255)

        [Display(Name = "Idcliente")]
        public int? Idcliente { get; set; } // idcliente

        [Display(Name = "Aduana")]
        public int? Aduana { get; set; } // aduana

        [Display(Name = "Patente")]
        public int? Patente { get; set; } // patente

        [Display(Name = "Enviado")]
        public int? Enviado { get; set; } // enviado

        [Display(Name = "Envfactura")]
        public int? Envfactura { get; set; } // envfactura

        [Required]
        [Display(Name = "Solicitado")]
        public int Solicitado { get; set; } // solicitado (Primary key)

        public PedimentosJohnson()
        {
            Enviado = 0;
            Envfactura = 0;
            Solicitado = 0;
        }
    }

}
// </auto-generated>
