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

    // CHECKEXACT
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Checkexact
    {
        [Required]
        [Display(Name = "Exactid")]
        public int Exactid { get; set; } // EXACTID (Primary key)

        [Display(Name = "Userid")]
        public int? Userid { get; set; } // USERID

        [DataType(DataType.DateTime)]
        [Display(Name = "Checktime")]
        public System.DateTime? Checktime { get; set; } // CHECKTIME

        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "Checktype")]
        public string Checktype { get; set; } // CHECKTYPE (length: 2)

        [Display(Name = "Isadd")]
        public short? Isadd { get; set; } // ISADD

        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Yuyin")]
        public string Yuyin { get; set; } // YUYIN (length: 25)

        [Display(Name = "Ismodify")]
        public short? Ismodify { get; set; } // ISMODIFY

        [Display(Name = "Isdelete")]
        public short? Isdelete { get; set; } // ISDELETE

        [Display(Name = "Incount")]
        public short? Incount { get; set; } // INCOUNT

        [Display(Name = "Iscount")]
        public short? Iscount { get; set; } // ISCOUNT

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Modifyby")]
        public string Modifyby { get; set; } // MODIFYBY (length: 20)

        [DataType(DataType.DateTime)]
        [Display(Name = "Date")]
        public System.DateTime? Date { get; set; } // DATE

        public Checkexact()
        {
            Userid = 0;
            Checktype = "0";
            Isadd = 0;
            Ismodify = 0;
            Isdelete = 0;
            Incount = 0;
            Iscount = 0;
        }
    }

}
// </auto-generated>
