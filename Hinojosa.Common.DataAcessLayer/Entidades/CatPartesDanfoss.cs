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

    // The table 'cat_partes_danfoss' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    // cat_partes_danfoss
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatPartesDanfoss
    {
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Material")]
        public string Material { get; set; } // Material (length: 25)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Planta")]
        public string Planta { get; set; } // Planta (length: 10)

        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Clase")]
        public string Clase { get; set; } // Clase (length: 25)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Country origin")]
        public string CountryOrigin { get; set; } // CountryOrigin (length: 10)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Prosec vii")]
        public string ProsecVii { get; set; } // ProsecVII (length: 10)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Nafta")]
        public string Nafta { get; set; } // NAFTA (length: 10)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Tasa gral")]
        public string TasaGral { get; set; } // TasaGral (length: 10)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Regla 8 a")]
        public string Regla8A { get; set; } // Regla8a (length: 10)

        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; } // Descripcion (length: 200)

        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Vendor")]
        public string Vendor { get; set; } // Vendor (length: 200)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Num vendor")]
        public string NumVendor { get; set; } // NumVendor (length: 10)

        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Fraccion arancelaria")]
        public string FraccionArancelaria { get; set; } // FraccionArancelaria (length: 25)

        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Regimen")]
        public string Regimen { get; set; } // Regimen (length: 5)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Week")]
        public string Week { get; set; } // Week (length: 10)

        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Regulacion no arancelaria")]
        public string RegulacionNoArancelaria { get; set; } // RegulacionNoArancelaria (length: 200)
    }

}
// </auto-generated>
