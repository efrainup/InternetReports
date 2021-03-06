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

    // tipoVehiculo
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TipoVehiculo
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; } // id (Primary key)

        [Display(Name = "Id tipo")]
        public int? IdTipo { get; set; } // id_tipo

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; } // tipo (length: 100)

        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; } // descripcion (length: 250)

        [Display(Name = "Ejes")]
        public int? Ejes { get; set; } // ejes

        [Display(Name = "Llantas")]
        public int? Llantas { get; set; } // llantas

        [Display(Name = "Arrastre")]
        public int? Arrastre { get; set; } // arrastre

        [Display(Name = "Traccion")]
        public int? Traccion { get; set; } // traccion

        [Display(Name = "Direccion")]
        public int? Direccion { get; set; } // direccion
    }

}
// </auto-generated>
