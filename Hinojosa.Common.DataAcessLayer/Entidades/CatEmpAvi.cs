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

    // cat_emp_avi
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatEmpAvi
    {
        [Required]
        [Display(Name = "Id avi")]
        public int IdAvi { get; set; } // id_avi (Primary key)

        [Required]
        [Display(Name = "Id tip")]
        public int IdTip { get; set; } // id_tip

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec avi")]
        public System.DateTime FecAvi { get; set; } // fec_avi

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Fol avi")]
        public string FolAvi { get; set; } // fol_avi (length: 30)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ini")]
        public System.DateTime FecIni { get; set; } // fec_ini

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ter")]
        public System.DateTime FecTer { get; set; } // fec_ter

        [Required]
        [Display(Name = "Dias")]
        public int Dias { get; set; } // dias

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Umf")]
        public string Umf { get; set; } // umf (length: 30)

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [Display(Name = "Id emp")]
        public int IdEmp { get; set; } // id_emp

        public CatEmpAvi()
        {
            IdAvi = 0;
            IdTip = 0;
            FolAvi = "";
            Dias = 0;
            Umf = "";
            IdNota = 0;
            IdUsr = 0;
            Status = 1;
            IdEmp = 0;
        }
    }

}
// </auto-generated>
