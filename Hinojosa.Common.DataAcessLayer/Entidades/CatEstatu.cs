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

    // cat_estatus
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatEstatu
    {
        [Required]
        [Display(Name = "Id status")]
        public int IdStatus { get; set; } // id_status (Primary key)

        [Required]
        [Display(Name = "Tipo")]
        public byte Tipo { get; set; } // tipo (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (length: 60)

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        public CatEstatu()
        {
            IdStatus = 0;
            Tipo = 0;
            Des = "";
            Status = 0;
        }
    }

}
// </auto-generated>
