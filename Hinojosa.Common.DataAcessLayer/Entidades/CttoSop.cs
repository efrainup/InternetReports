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

    // ctto_sop
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CttoSop
    {
        [Required]
        [Display(Name = "Id ctto")]
        public int IdCtto { get; set; } // id_ctto (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; } // email (length: 250)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Tel")]
        public string Tel { get; set; } // tel (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Cel")]
        public string Cel { get; set; } // cel (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Radio ID")]
        public string RadioId { get; set; } // radio_id (length: 50)

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        public CttoSop()
        {
            Email = "";
            Tel = "";
            Cel = "";
            RadioId = "";
            Status = 1;
            FecReg = System.DateTime.Now;
        }
    }

}
// </auto-generated>
