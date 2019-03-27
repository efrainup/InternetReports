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

    // bco_conc_trns
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class BcoConcTrn
    {
        [Required]
        [Display(Name = "Id conc trns")]
        public int IdConcTrns { get; set; } // id_conc_trns (Primary key)

        [Required]
        [Display(Name = "Id conc")]
        public int IdConc { get; set; } // id_conc

        [Required]
        [Display(Name = "Id bco aux")]
        public int IdBcoAux { get; set; } // id_bco_aux

        public BcoConcTrn()
        {
            IdConcTrns = 0;
            IdConc = 0;
            IdBcoAux = 0;
        }
    }

}
// </auto-generated>
