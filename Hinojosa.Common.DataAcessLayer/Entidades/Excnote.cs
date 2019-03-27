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

    // The table 'EXCNOTES' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    // EXCNOTES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Excnote
    {
        [Display(Name = "Userid")]
        public int? Userid { get; set; } // USERID

        [DataType(DataType.DateTime)]
        [Display(Name = "Attdate")]
        public System.DateTime? Attdate { get; set; } // ATTDATE

        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Notes")]
        public string Notes { get; set; } // NOTES (length: 200)
    }

}
// </auto-generated>
