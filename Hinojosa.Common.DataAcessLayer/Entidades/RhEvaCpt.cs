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

    // rh_eva_cpt
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class RhEvaCpt
    {
        [Required]
        [Display(Name = "Id cat eva")]
        public int IdCatEva { get; set; } // id_cat_eva (Primary key)

        [Required]
        [Display(Name = "Id tip tit")]
        public int IdTipTit { get; set; } // id_tip_tit

        [Required]
        [Display(Name = "Calif")]
        public double Calif { get; set; } // calif

        [Required]
        [Display(Name = "Id tip cpt")]
        public int IdTipCpt { get; set; } // id_tip_cpt

        [Required]
        [Display(Name = "Pond")]
        public double Pond { get; set; } // pond

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Cmt tit")]
        public string CmtTit { get; set; } // cmt_tit (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Cmt cpt")]
        public string CmtCpt { get; set; } // cmt_cpt (length: 50)

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

        public RhEvaCpt()
        {
            IdCatEva = 0;
            IdTipTit = 0;
            Calif = 0;
            IdTipCpt = 0;
            Pond = 0;
            CmtTit = "";
            CmtCpt = "";
            IdUsr = 0;
            Status = 1;
        }
    }

}
// </auto-generated>