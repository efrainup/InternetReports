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

    // TEMPLATE
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Template
    {
        [Required]
        [Display(Name = "Templateid")]
        public int Templateid { get; set; } // TEMPLATEID (Primary key)

        [Required]
        [Display(Name = "Userid")]
        public int Userid { get; set; } // USERID

        [Required]
        [Display(Name = "Fingerid")]
        public int Fingerid { get; set; } // FINGERID

        [Required]
        [MaxLength(2147483647)]
        [Display(Name = "Template")]
        public byte[] Template_ { get; set; } // TEMPLATE (length: 2147483647)

        [MaxLength(2147483647)]
        [Display(Name = "Template 2")]
        public byte[] Template2 { get; set; } // TEMPLATE2 (length: 2147483647)

        [MaxLength(2147483647)]
        [Display(Name = "Template 3")]
        public byte[] Template3 { get; set; } // TEMPLATE3 (length: 2147483647)

        [MaxLength(2147483647)]
        [Display(Name = "Bitmappicture")]
        public byte[] Bitmappicture { get; set; } // BITMAPPICTURE (length: 2147483647)

        [MaxLength(2147483647)]
        [Display(Name = "Bitmappicture 2")]
        public byte[] Bitmappicture2 { get; set; } // BITMAPPICTURE2 (length: 2147483647)

        [MaxLength(2147483647)]
        [Display(Name = "Bitmappicture 3")]
        public byte[] Bitmappicture3 { get; set; } // BITMAPPICTURE3 (length: 2147483647)

        [MaxLength(2147483647)]
        [Display(Name = "Bitmappicture 4")]
        public byte[] Bitmappicture4 { get; set; } // BITMAPPICTURE4 (length: 2147483647)

        [Display(Name = "Usetype")]
        public short? Usetype { get; set; } // USETYPE
    }

}
// </auto-generated>
