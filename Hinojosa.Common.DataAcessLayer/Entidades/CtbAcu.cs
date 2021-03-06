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

    // ctb_acu
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CtbAcu
    {
        [Required]
        [Display(Name = "Id per")]
        public int IdPer { get; set; } // id_per (Primary key)

        [Required]
        [Display(Name = "Id cta")]
        public int IdCta { get; set; } // id_cta (Primary key)

        [Required]
        [Display(Name = "Id emp")]
        public int IdEmp { get; set; } // id_emp (Primary key)

        [Required]
        [Display(Name = "Id cen cto")]
        public int IdCenCto { get; set; } // id_cen_cto (Primary key)

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Sal ini")]
        public decimal SalIni { get; set; } // sal_ini

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Cargos")]
        public decimal Cargos { get; set; } // cargos

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Abonos")]
        public decimal Abonos { get; set; } // abonos

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Cam net")]
        public decimal CamNet { get; set; } // cam_net

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Sal fin")]
        public decimal SalFin { get; set; } // sal_fin

        public CtbAcu()
        {
            IdPer = 0;
            IdCta = 0;
            IdEmp = 0;
            IdCenCto = 0;
            SalIni = 0m;
            Cargos = 0m;
            Abonos = 0m;
            CamNet = 0m;
            SalFin = 0m;
        }
    }

}
// </auto-generated>
