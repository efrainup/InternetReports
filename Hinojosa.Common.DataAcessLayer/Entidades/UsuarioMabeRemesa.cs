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

    // usuario_mabe_remesas
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class UsuarioMabeRemesa
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; } // id (Primary key)

        [MaxLength(45)]
        [StringLength(45)]
        [Display(Name = "Trafico")]
        public string Trafico { get; set; } // trafico (length: 45)

        [MaxLength(45)]
        [StringLength(45)]
        [Display(Name = "Proveedor")]
        public string Proveedor { get; set; } // proveedor (length: 45)

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha llegada")]
        public System.DateTime? FechaLlegada { get; set; } // fecha_llegada

        [MaxLength(45)]
        [StringLength(45)]
        [Display(Name = "Talon")]
        public string Talon { get; set; } // talon (length: 45)

        [MaxLength(45)]
        [StringLength(45)]
        [Display(Name = "Linea")]
        public string Linea { get; set; } // linea (length: 45)

        [Display(Name = "Bultos")]
        public int? Bultos { get; set; } // Bultos

        [MaxLength(45)]
        [StringLength(45)]
        [Display(Name = "Id clase")]
        public string IdClase { get; set; } // id_Clase (length: 45)

        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Estatus")]
        public string Estatus { get; set; } // ESTATUS (length: 15)

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha")]
        public System.DateTime? Fecha { get; set; } // fecha

        [MaxLength(45)]
        [StringLength(45)]
        [Display(Name = "Atencion")]
        public string Atencion { get; set; } // atencion (length: 45)
    }

}
// </auto-generated>
