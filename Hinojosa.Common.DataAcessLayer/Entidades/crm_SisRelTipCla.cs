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

    // sis_rel_tip_clas
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_SisRelTipCla
    {
        [Required]
        [Display(Name = "Id rel tip clas")]
        public int IdRelTipClas { get; set; } // id_rel_tip_clas (Primary key)

        [Required]
        [Display(Name = "Id tip")]
        public int IdTip { get; set; } // id_tip

        [Required]
        [Display(Name = "Id clas")]
        public int IdClas { get; set; } // id_clas

        [Required]
        [Display(Name = "Id tip clas pad")]
        public int IdTipClasPad { get; set; } // id_tip_clas_pad

        [Required]
        [Display(Name = "N orden")]
        public int NOrden { get; set; } // n_orden

        [Required]
        [Display(Name = "N nivel")]
        public int NNivel { get; set; } // n_nivel

        public crm_SisRelTipCla()
        {
            IdTip = 0;
            IdClas = 0;
            IdTipClasPad = 0;
            NOrden = 0;
            NNivel = 0;
        }
    }

}
// </auto-generated>
