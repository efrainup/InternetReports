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

    // cat_emp_tbl_sdo
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatEmpTblSdo
    {
        [Required]
        [Display(Name = "Id tbl sdo")]
        public int IdTblSdo { get; set; } // id_tbl_sdo (Primary key)

        [Required]
        [Display(Name = "Nivel")]
        public int Nivel { get; set; } // nivel

        [Required]
        [Display(Name = "Id pto")]
        public int IdPto { get; set; } // id_pto

        [Required]
        [Display(Name = "R 1 min")]
        public double R1Min { get; set; } // r1_min

        [Required]
        [Display(Name = "R 2 min")]
        public double R2Min { get; set; } // r2_min

        [Required]
        [Display(Name = "R 1 med")]
        public double R1Med { get; set; } // r1_med

        [Required]
        [Display(Name = "R 2 med")]
        public double R2Med { get; set; } // r2_med

        [Required]
        [Display(Name = "R 1 max")]
        public double R1Max { get; set; } // r1_max

        [Required]
        [Display(Name = "R 2 max")]
        public double R2Max { get; set; } // r2_max

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        public CatEmpTblSdo()
        {
            IdTblSdo = 0;
            Nivel = 0;
            IdPto = 0;
            R1Min = 0;
            R2Min = 0;
            R1Med = 0;
            R2Med = 0;
            R1Max = 0;
            R2Max = 0;
            IdUsr = 0;
            Status = 0;
        }
    }

}
// </auto-generated>
