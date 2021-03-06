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

    // cca_cert_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CcaCertDet
    {
        [Required]
        [Display(Name = "Id cert det")]
        public int IdCertDet { get; set; } // id_cert_det (Primary key)

        [Required]
        [Display(Name = "Id cert")]
        public int IdCert { get; set; } // id_cert

        [Required]
        [Display(Name = "Id esp")]
        public int IdEsp { get; set; } // id_esp

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Des esp")]
        public string DesEsp { get; set; } // des_esp (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Parametro")]
        public string Parametro { get; set; } // parametro (length: 80)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Resultado")]
        public string Resultado { get; set; } // resultado (length: 80)

        public CcaCertDet()
        {
            IdCertDet = 0;
            IdCert = 0;
            DesEsp = "";
        }
    }

}
// </auto-generated>
