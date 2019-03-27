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

    // cat_pac
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatPac
    {
        [Required]
        [Display(Name = "Id pac")]
        public int IdPac { get; set; } // id_pac (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Nom 1")]
        public string Nom1 { get; set; } // nom1 (length: 255)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Nom 2")]
        public string Nom2 { get; set; } // nom2 (length: 255)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Usr")]
        public string Usr { get; set; } // usr (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Pwd")]
        public string Pwd { get; set; } // pwd (length: 255)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Url]
        [Display(Name = "Url")]
        public string Url { get; set; } // url (length: 255)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Url canc")]
        public string UrlCanc { get; set; } // url_canc (length: 255)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Url soap")]
        public string UrlSoap { get; set; } // url_soap (length: 255)

        public CatPac()
        {
            IdPac = 0;
            Nom1 = "";
            Nom2 = "";
            Usr = "";
            Pwd = "";
            Url = "";
            IdUsr = 0;
            Status = 1;
            UrlCanc = "";
            UrlSoap = "";
        }
    }

}
// </auto-generated>
