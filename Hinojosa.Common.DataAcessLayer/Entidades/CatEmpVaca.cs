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

    // cat_emp_vaca
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatEmpVaca
    {
        [Required]
        [Display(Name = "Id vaca")]
        public int IdVaca { get; set; } // id_vaca (Primary key)

        [Required]
        [Display(Name = "Id rel vaca")]
        public int IdRelVaca { get; set; } // id_rel_vaca

        [Required(AllowEmptyStrings = true)]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Anio")]
        public string Anio { get; set; } // anio (length: 15)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ini")]
        public System.DateTime FecIni { get; set; } // fec_ini

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ter")]
        public System.DateTime FecTer { get; set; } // fec_ter

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Salida")]
        public System.DateTime Salida { get; set; } // salida

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Entrada")]
        public System.DateTime Entrada { get; set; } // entrada

        [Required]
        [Display(Name = "Dias vaca")]
        public int DiasVaca { get; set; } // dias_vaca

        [Required]
        [Display(Name = "Dias dis")]
        public int DiasDis { get; set; } // dias_dis

        [Required]
        [Display(Name = "Dias pen")]
        public int DiasPen { get; set; } // dias_pen

        [Required]
        [Display(Name = "Total pen")]
        public int TotalPen { get; set; } // total_pen

        [Required]
        [Display(Name = "C renglones")]
        public int CRenglones { get; set; } // c_renglones

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec sol")]
        public System.DateTime FecSol { get; set; } // fec_sol

        [Required]
        [Display(Name = "Status vac")]
        public byte StatusVac { get; set; } // status_vac

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec sal vac")]
        public System.DateTime FecSalVac { get; set; } // fec_sal_vac

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ent vac")]
        public System.DateTime FecEntVac { get; set; } // fec_ent_vac

        [Required]
        [Display(Name = "Dias sol")]
        public int DiasSol { get; set; } // dias_sol

        [Required]
        [Display(Name = "C cer")]
        public int CCer { get; set; } // c_cer

        public CatEmpVaca()
        {
            IdVaca = 0;
            IdRelVaca = 0;
            Anio = "";
            DiasVaca = 0;
            DiasDis = 0;
            DiasPen = 0;
            TotalPen = 0;
            CRenglones = 1;
            StatusVac = 0;
            DiasSol = 0;
            CCer = 0;
        }
    }

}
// </auto-generated>
