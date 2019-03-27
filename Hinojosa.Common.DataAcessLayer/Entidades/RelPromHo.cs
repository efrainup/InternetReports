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

    // rel_prom_hos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class RelPromHo
    {
        [Required]
        [Display(Name = "Id rel prom")]
        public int IdRelProm { get; set; } // id_rel_prom (Primary key)

        [Required]
        [Display(Name = "Id ref")]
        public int IdRef { get; set; } // id_ref

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro

        [Required]
        [Display(Name = "Id int")]
        public int IdInt { get; set; } // id_int

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        public RelPromHo()
        {
            IdRef = 0;
            IdPro = 0;
            IdInt = 0;
            Status = 0;
        }
    }

}
// </auto-generated>