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

    // enc_resp
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_EncResp
    {
        [Required]
        [Display(Name = "Id resp")]
        public int IdResp { get; set; } // id_resp (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Texto")]
        public string Texto { get; set; } // texto (length: 100)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Valor")]
        public string Valor { get; set; } // valor

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des

        [Required]
        [Display(Name = "C dft")]
        public byte CDft { get; set; } // c_dft

        [Required]
        [Display(Name = "Id preg")]
        public int IdPreg { get; set; } // id_preg

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status

        [Required]
        [Display(Name = "Orden")]
        public int Orden { get; set; } // orden

        public crm_EncResp()
        {
            Valor = "0";
            CDft = 0;
            IdPreg = 0;
            Status = 0;
            Orden = 0;
        }
    }

}
// </auto-generated>