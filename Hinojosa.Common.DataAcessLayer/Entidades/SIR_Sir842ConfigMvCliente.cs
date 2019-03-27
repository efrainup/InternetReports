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

    // SIR_842_CONFIG_MV_CLIENTE
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir842ConfigMvCliente
    {
        [Required]
        [Display(Name = "N ID config mv 842")]
        public int NIdConfigMv842 { get; set; } // nIdConfigMV842 (Primary key)

        [Required]
        [Display(Name = "N ID cliente")]
        public int NIdCliente { get; set; } // nIdCliente

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S clv incoterm")]
        public string SClvIncoterm { get; set; } // sClvIncoterm (length: 20)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "S campo 1")]
        public string SCampo1 { get; set; } // sCampo1 (length: 10)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "S campo 2")]
        public string SCampo2 { get; set; } // sCampo2 (length: 10)
    }

}
// </auto-generated>
