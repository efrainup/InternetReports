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

    // enc_grp_preg
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_EncGrpPreg
    {
        [Required]
        [Display(Name = "Id grp preg")]
        public int IdGrpPreg { get; set; } // id_grp_preg (Primary key)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Instr grp")]
        public string InstrGrp { get; set; } // instr_grp

        [Required]
        [Display(Name = "Id tip grp")]
        public int IdTipGrp { get; set; } // id_tip_grp

        [Required]
        [Display(Name = "Orden")]
        public int Orden { get; set; } // orden

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status

        public crm_EncGrpPreg()
        {
            IdTipGrp = 0;
            Orden = 0;
            Status = 0;
        }
    }

}
// </auto-generated>
