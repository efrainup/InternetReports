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

    // enc_rep_ope
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_EncRepOpe
    {
        [Required]
        [Display(Name = "Id resp enc")]
        public int IdRespEnc { get; set; } // id_resp_enc (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec rep")]
        public System.DateTime FecRep { get; set; } // fec_rep

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Turno")]
        public string Turno { get; set; } // turno (length: 100)

        public crm_EncRepOpe()
        {
            Turno = "";
        }
    }

}
// </auto-generated>
