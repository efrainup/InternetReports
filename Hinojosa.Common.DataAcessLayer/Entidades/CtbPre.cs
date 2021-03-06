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

    // ctb_pre
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CtbPre
    {
        [Required]
        [Display(Name = "Id pre")]
        public int IdPre { get; set; } // id_pre (Primary key)

        [Required]
        [Display(Name = "Rev")]
        public int Rev { get; set; } // rev

        [Required]
        [Display(Name = "Id per")]
        public int IdPer { get; set; } // id_per

        [Required]
        [Display(Name = "Id cta")]
        public int IdCta { get; set; } // id_cta

        [Required]
        [Display(Name = "Id emp")]
        public int IdEmp { get; set; } // id_emp

        [Required]
        [Display(Name = "Id cen cto")]
        public int IdCenCto { get; set; } // id_cen_cto

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Mto")]
        public decimal Mto { get; set; } // mto

        [Required]
        [Display(Name = "C act")]
        public byte CAct { get; set; } // c_act

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

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Mto eje")]
        public decimal MtoEje { get; set; } // mto_eje

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Cmt")]
        public string Cmt { get; set; } // cmt (length: 25)

        [Required]
        [Display(Name = "Id tip obj")]
        public int IdTipObj { get; set; } // id_tip_obj

        [Required]
        [Display(Name = "Id obj")]
        public int IdObj { get; set; } // id_obj

        public CtbPre()
        {
            IdPre = 0;
            Rev = 0;
            IdPer = 0;
            IdCta = 0;
            IdEmp = 0;
            IdCenCto = 0;
            Mto = 0m;
            CAct = 0;
            IdUsr = 0;
            Status = 0;
            MtoEje = 0m;
            Cmt = "";
            IdTipObj = 0;
            IdObj = 0;
        }
    }

}
// </auto-generated>
