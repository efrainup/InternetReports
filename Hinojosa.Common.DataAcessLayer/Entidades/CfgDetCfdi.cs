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

    // cfg_det_cfdi
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CfgDetCfdi
    {
        [Required]
        [Display(Name = "Id det cfdi")]
        public int IdDetCfdi { get; set; } // id_det_cfdi (Primary key)

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(12)]
        [StringLength(12)]
        [Display(Name = "Cve")]
        public string Cve { get; set; } // cve (Primary key) (length: 12)

        [Required]
        [Display(Name = "Cant")]
        public double Cant { get; set; } // cant (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Udm")]
        public string Udm { get; set; } // UDM (Primary key) (length: 5)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (Primary key) (length: 1000)

        public CfgDetCfdi()
        {
            IdDetCfdi = 0;
            IdTipDoc = 0;
            Cve = "";
            Cant = 0;
            Udm = "";
            Des = "";
        }
    }

}
// </auto-generated>
