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

    // The table 'Cat_rutasDetalle' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    // Cat_rutasDetalle
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatRutasDetalle
    {
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Segmento")]
        public string Segmento { get; set; } // segmento (length: 100)

        [Display(Name = "Id ruta")]
        public decimal? IdRuta { get; set; } // id_ruta

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Origen")]
        public string Origen { get; set; } // Origen (length: 100)

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Destino")]
        public string Destino { get; set; } // Destino (length: 100)

        [Display(Name = "Id usuario")]
        public int? IdUsuario { get; set; } // IdUsuario

        [Display(Name = "Puntos")]
        public int? Puntos { get; set; } // Puntos

        [Display(Name = "Kilometraje")]
        public double? Kilometraje { get; set; } // Kilometraje

        [Display(Name = "Tiempo")]
        public double? Tiempo { get; set; } // Tiempo

        [Display(Name = "Tiempo muerto")]
        public double? TiempoMuerto { get; set; } // TiempoMuerto

        [Display(Name = "Jsonr uta")]
        public string JsonRuta { get; set; } // JSONRuta

        [Display(Name = "Nocasetas")]
        public int? Nocasetas { get; set; } // Nocasetas

        [Display(Name = "Costo casetas")]
        public double? CostoCasetas { get; set; } // CostoCasetas

        [Display(Name = "Costo combustible")]
        public double? CostoCombustible { get; set; } // CostoCombustible

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime? FecReg { get; set; } // FecReg
    }

}
// </auto-generated>