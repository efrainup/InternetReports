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

    // sis_bda_grp
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisBdaGrp
    {
        [Required]
        [Display(Name = "Id bda grp")]
        public int IdBdaGrp { get; set; } // id_bda_grp (Primary key)

        [Required]
        [Display(Name = "Id grp")]
        public int IdGrp { get; set; } // id_grp

        public SisBdaGrp()
        {
            IdBdaGrp = 0;
            IdGrp = 0;
        }
    }

}
// </auto-generated>
