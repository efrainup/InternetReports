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

    // eve_rel_eve
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_EveRelEve
    {
        [Required]
        [Display(Name = "Id rel eve")]
        public int IdRelEve { get; set; } // id_rel_eve (Primary key)

        [Required]
        [Display(Name = "Id eve even")]
        public int IdEveEven { get; set; } // id_eve_even

        [Required]
        [Display(Name = "Id obj")]
        public int IdObj { get; set; } // id_obj

        [Required]
        [Display(Name = "Id tip rel")]
        public int IdTipRel { get; set; } // id_tip_rel

        [Required]
        [Display(Name = "Id tip obj")]
        public int IdTipObj { get; set; } // id_tip_obj

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fec reg")]
        public System.DateTime DFecReg { get; set; } // d_fec_reg

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status

        public crm_EveRelEve()
        {
            IdEveEven = 0;
            IdObj = 0;
            IdTipRel = 0;
            IdTipObj = 0;
            IdUsr = 0;
            Status = 0;
        }
    }

}
// </auto-generated>
