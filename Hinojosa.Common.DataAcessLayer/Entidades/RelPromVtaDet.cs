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

    // rel_prom_vta_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class RelPromVtaDet
    {
        [Required]
        [Display(Name = "Id rel prom vta det")]
        public int IdRelPromVtaDet { get; set; } // id_rel_prom_vta_det (Primary key)

        [Required]
        [Display(Name = "Id rel prom vta")]
        public int IdRelPromVta { get; set; } // id_rel_prom_vta

        [Required]
        [Display(Name = "Id prom")]
        public int IdProm { get; set; } // id_prom

        [Required]
        [Display(Name = "C prom")]
        public bool CProm { get; set; } // c_prom

        [Required]
        [Display(Name = "Tip")]
        public bool Tip { get; set; } // tip

        public RelPromVtaDet()
        {
            IdRelPromVta = 0;
            IdProm = 0;
            CProm = false;
            Tip = false;
        }
    }

}
// </auto-generated>
