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

    // Cat_UbicaLatLng
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatUbicaLatLng
    {
        [Required]
        [Display(Name = "Id gelocaliza")]
        public decimal IdGelocaliza { get; set; } // id_gelocaliza (Primary key)

        [Display(Name = "Id obj")]
        public decimal? IdObj { get; set; } // id_obj

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Tip cto")]
        public string TipCto { get; set; } // TipCto (length: 50)

        [Display(Name = "Id tbl")]
        public decimal? IdTbl { get; set; } // id_tbl

        [Display(Name = "Id tip doc")]
        public decimal? IdTipDoc { get; set; } // id_tip_doc

        [Display(Name = "Id usuario")]
        public decimal? IdUsuario { get; set; } // Id_usuario

        [Display(Name = "Latitud")]
        public double? Latitud { get; set; } // latitud

        [Display(Name = "Longitud")]
        public double? Longitud { get; set; } // longitud

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha")]
        public System.DateTime? Fecha { get; set; } // Fecha

        [Display(Name = "Estado")]
        public bool? Estado { get; set; } // Estado
    }

}
// </auto-generated>
