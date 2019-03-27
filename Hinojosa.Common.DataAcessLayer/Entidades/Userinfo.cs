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

    // USERINFO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Userinfo
    {
        [Required]
        [Display(Name = "Userid")]
        public int Userid { get; set; } // USERID (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(12)]
        [StringLength(12)]
        [Display(Name = "Badgenumber")]
        public string Badgenumber { get; set; } // BADGENUMBER (length: 12)

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Ssn")]
        public string Ssn { get; set; } // SSN (length: 20)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Name")]
        public string Name { get; set; } // NAME (length: 50)

        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "Gender")]
        public string Gender { get; set; } // GENDER (length: 2)

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Title")]
        public string Title { get; set; } // TITLE (length: 20)

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Pager")]
        public string Pager { get; set; } // PAGER (length: 20)

        [DataType(DataType.DateTime)]
        [Display(Name = "Birthday")]
        public System.DateTime? Birthday { get; set; } // BIRTHDAY

        [DataType(DataType.DateTime)]
        [Display(Name = "Hiredday")]
        public System.DateTime? Hiredday { get; set; } // HIREDDAY

        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Street")]
        public string Street { get; set; } // STREET (length: 40)

        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "City")]
        public string City { get; set; } // CITY (length: 2)

        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "State")]
        public string State { get; set; } // STATE (length: 2)

        [MaxLength(12)]
        [StringLength(12)]
        [DataType(DataType.PostalCode)]
        [Display(Name = "Zip")]
        public string Zip { get; set; } // ZIP (length: 12)

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Ophone")]
        public string Ophone { get; set; } // OPHONE (length: 20)

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Fphone")]
        public string Fphone { get; set; } // FPHONE (length: 20)

        [Display(Name = "Verificationmethod")]
        public short? Verificationmethod { get; set; } // VERIFICATIONMETHOD

        [Display(Name = "Defaultdeptid")]
        public short? Defaultdeptid { get; set; } // DEFAULTDEPTID

        [Display(Name = "Securityflags")]
        public short? Securityflags { get; set; } // SECURITYFLAGS

        [Required]
        [Display(Name = "Att")]
        public short Att { get; set; } // ATT

        [Required]
        [Display(Name = "Inlate")]
        public short Inlate { get; set; } // INLATE

        [Required]
        [Display(Name = "Outearly")]
        public short Outearly { get; set; } // OUTEARLY

        [Required]
        [Display(Name = "Overtime")]
        public short Overtime { get; set; } // OVERTIME

        [Required]
        [Display(Name = "Sep")]
        public short Sep { get; set; } // SEP

        [Required]
        [Display(Name = "Holiday")]
        public short Holiday { get; set; } // HOLIDAY

        [MaxLength(8)]
        [StringLength(8)]
        [Display(Name = "Minzu")]
        public string Minzu { get; set; } // MINZU (length: 8)

        [MaxLength(20)]
        [StringLength(20)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } // PASSWORD (length: 20)

        [Required]
        [Display(Name = "Lunchduration")]
        public short Lunchduration { get; set; } // LUNCHDURATION

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Mv erify pass")]
        public string MVerifyPass { get; set; } // MVerifyPass (length: 10)

        [MaxLength(2147483647)]
        [Display(Name = "Photo")]
        public byte[] Photo { get; set; } // PHOTO (length: 2147483647)

        public Userinfo()
        {
            Defaultdeptid = 1;
            Att = 1;
            Inlate = 1;
            Outearly = 1;
            Overtime = 1;
            Sep = 1;
            Holiday = 1;
            Lunchduration = 1;
        }
    }

}
// </auto-generated>
