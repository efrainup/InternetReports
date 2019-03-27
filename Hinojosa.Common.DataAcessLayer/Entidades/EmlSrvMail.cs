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

    // eml_srv_mail
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class EmlSrvMail
    {
        [Required]
        [Display(Name = "Id srv")]
        public int IdSrv { get; set; } // id_srv (Primary key)

        [Required]
        [Display(Name = "Tip srv")]
        public byte TipSrv { get; set; } // tip_srv

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Nom srv")]
        public string NomSrv { get; set; } // nom_srv (length: 100)

        [Required]
        [Display(Name = "Pto srv")]
        public int PtoSrv { get; set; } // pto_srv

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Usr srv")]
        public string UsrSrv { get; set; } // usr_srv (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Psw srv")]
        public string PswSrv { get; set; } // psw_srv (length: 100)

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Display(Name = "Ssl")]
        public bool? Ssl { get; set; } // SSL

        [Display(Name = "Startls")]
        public int? Startls { get; set; } // startls

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Prtcl")]
        public string Prtcl { get; set; } // prtcl (length: 20)

        public EmlSrvMail()
        {
            Prtcl = "";
        }
    }

}
// </auto-generated>
