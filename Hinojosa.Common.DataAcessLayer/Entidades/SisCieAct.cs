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

    // sis_cie_act
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisCieAct
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; } // ID (Primary key)

        [Required]
        [Display(Name = "Id emp")]
        public int IdEmp { get; set; } // id_emp

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ini")]
        public System.DateTime FecIni { get; set; } // fec_ini

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec fin")]
        public System.DateTime FecFin { get; set; } // fec_fin

        [Required]
        [Display(Name = "Periodicidad")]
        public int Periodicidad { get; set; } // periodicidad

        [Required]
        [Display(Name = "Diarias")]
        public double Diarias { get; set; } // Diarias

        [Required]
        [Display(Name = "Semanales")]
        public double Semanales { get; set; } // Semanales

        [Required]
        [Display(Name = "Quincenales")]
        public double Quincenales { get; set; } // Quincenales

        [Required]
        [Display(Name = "Mensuales")]
        public double Mensuales { get; set; } // Mensuales

        [Required]
        [Display(Name = "Extras")]
        public double Extras { get; set; } // Extras

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        public SisCieAct()
        {
            IdEmp = 0;
            Periodicidad = 0;
            Diarias = 0;
            Semanales = 0;
            Quincenales = 0;
            Mensuales = 0;
            Extras = 0;
        }
    }

}
// </auto-generated>
