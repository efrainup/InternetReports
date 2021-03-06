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

    // eve_rel_cto_eve
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_EveRelCtoEve
    {
        [Required]
        [Display(Name = "Id cto eve")]
        public int IdCtoEve { get; set; } // id_cto_eve (Primary key)

        [Required]
        [Display(Name = "Id cto")]
        public int IdCto { get; set; } // id_cto

        [Required]
        [Display(Name = "Id eve rel")]
        public int IdEveRel { get; set; } // id_eve_rel

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status

        public crm_EveRelCtoEve()
        {
            IdCto = 0;
            IdEveRel = 0;
            Status = 0;
        }
    }

}
// </auto-generated>
