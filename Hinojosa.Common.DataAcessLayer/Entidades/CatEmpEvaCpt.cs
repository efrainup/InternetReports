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

    // cat_emp_eva_cpts
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatEmpEvaCpt
    {
        [Required]
        [Display(Name = "Id eva cpts")]
        public int IdEvaCpts { get; set; } // id_eva_cpts (Primary key)

        [Required]
        [Display(Name = "Id eva")]
        public int IdEva { get; set; } // id_eva

        [Required]
        [Display(Name = "Id tip cpt")]
        public int IdTipCpt { get; set; } // id_tip_cpt

        [Required]
        [Display(Name = "Calif")]
        public double Calif { get; set; } // calif

        [Required]
        [Display(Name = "Id emp")]
        public int IdEmp { get; set; } // id_emp

        [Required]
        [Display(Name = "Id cat eva")]
        public int IdCatEva { get; set; } // id_cat_eva

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        public CatEmpEvaCpt()
        {
            IdEvaCpts = 0;
            IdEva = 0;
            IdTipCpt = 0;
            Calif = 0;
            IdEmp = 0;
            IdCatEva = 0;
            Status = 1;
            IdNota = 0;
        }
    }

}
// </auto-generated>
