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

    // layout_bco_edo_cta
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class LayoutBcoEdoCta
    {
        [Required]
        [Display(Name = "Id layout")]
        public int IdLayout { get; set; } // id_layout (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (length: 50)

        [Required]
        [Display(Name = "Id tip bco")]
        public int IdTipBco { get; set; } // id_tip_bco

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        public LayoutBcoEdoCta()
        {
            IdLayout = 0;
            Des = "";
            IdTipBco = 0;
            Status = 0;
        }
    }

}
// </auto-generated>
