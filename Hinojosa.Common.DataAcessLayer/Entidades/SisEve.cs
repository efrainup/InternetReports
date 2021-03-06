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

    // sis_eve
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisEve
    {
        [Required]
        [Display(Name = "Id sis eve")]
        public int IdSisEve { get; set; } // id_sis_eve (Primary key)

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required]
        [Display(Name = "Id fac")]
        public int IdFac { get; set; } // id_fac

        [Required]
        [Display(Name = "Id emp")]
        public int IdEmp { get; set; } // id_emp

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec eve")]
        public System.DateTime FecEve { get; set; } // fec_eve

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (length: 255)

        [Required]
        [Display(Name = "C imp")]
        public byte CImp { get; set; } // c_imp

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc

        [Required]
        [Display(Name = "Num doc")]
        public int NumDoc { get; set; } // num_doc

        [Required]
        [Display(Name = "Id sis edo act")]
        public int IdSisEdoAct { get; set; } // id_sis_edo_act

        public SisEve()
        {
            IdSisEve = 0;
            IdUsr = 0;
            IdNota = 0;
            IdFac = 0;
            IdEmp = 0;
            Des = "";
            CImp = 1;
            Status = 1;
            IdTipDoc = 0;
            NumDoc = 0;
            IdSisEdoAct = 0;
        }
    }

}
// </auto-generated>
