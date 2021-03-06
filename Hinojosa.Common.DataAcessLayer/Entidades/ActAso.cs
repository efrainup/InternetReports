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

    // act_aso
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ActAso
    {
        [Required]
        [Display(Name = "Id aso")]
        public int IdAso { get; set; } // id_aso (Primary key)

        [Required]
        [Display(Name = "Id act")]
        public int IdAct { get; set; } // id_act

        [Required]
        [Display(Name = "Id act aso")]
        public int IdActAso { get; set; } // id_act_aso

        public ActAso()
        {
            IdAct = 0;
            IdActAso = 0;
        }
    }

}
// </auto-generated>
