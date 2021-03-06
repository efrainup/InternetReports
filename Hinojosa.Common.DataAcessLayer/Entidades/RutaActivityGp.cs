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

    // ruta_activity_gps
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class RutaActivityGp
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; } // id (Primary key)

        [Display(Name = "Id provee")]
        public int? IdProvee { get; set; } // Id_provee

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Inicio")]
        public System.DateTime Inicio { get; set; } // inicio (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fin")]
        public System.DateTime Fin { get; set; } // fin (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; } // Descripcion (Primary key) (length: 200)

        [Display(Name = "No registros")]
        public int? NoRegistros { get; set; } // no_registros

        [Display(Name = "Id prov")]
        public int? IdProv { get; set; } // id_prov

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg (Primary key)

        [Required]
        [Display(Name = "Status")]
        public bool Status { get; set; } // Status (Primary key)
    }

}
// </auto-generated>
