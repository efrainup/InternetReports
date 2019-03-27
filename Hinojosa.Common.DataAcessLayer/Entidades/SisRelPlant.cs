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

    // sis_rel_plant
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisRelPlant
    {
        [Required]
        [Display(Name = "Id rel plant")]
        public decimal IdRelPlant { get; set; } // id_rel_plant (Primary key)

        [Required]
        [Display(Name = "Id cli")]
        public int IdCli { get; set; } // id_cli (Primary key)

        [Required]
        [Display(Name = "Id prov")]
        public int IdProv { get; set; } // id_prov (Primary key)

        [Required]
        [Display(Name = "Id cli fa da")]
        public int IdCliFaDa { get; set; } // id_cli_fa_da (Primary key)

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc (Primary key)

        [Required]
        [Display(Name = "Id plant")]
        public int IdPlant { get; set; } // id_plant (Primary key)

        public SisRelPlant()
        {
            IdCli = 0;
            IdProv = 0;
            IdCliFaDa = 0;
            IdTipDoc = 0;
            IdPlant = 0;
        }
    }

}
// </auto-generated>