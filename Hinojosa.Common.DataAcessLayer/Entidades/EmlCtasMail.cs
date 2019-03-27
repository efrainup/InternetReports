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

    // eml_ctas_mail
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class EmlCtasMail
    {
        [Required]
        [Display(Name = "Id cta")]
        public int IdCta { get; set; } // id_cta (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Nom cta")]
        public string NomCta { get; set; } // nom_cta (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Desc cta")]
        public string DescCta { get; set; } // desc_cta (length: 250)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Cta mail")]
        public string CtaMail { get; set; } // cta_mail (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Psw cta")]
        public string PswCta { get; set; } // psw_cta (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Cta alt")]
        public string CtaAlt { get; set; } // cta_alt (length: 100)

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status

        [Required]
        [Display(Name = "Id srv")]
        public int IdSrv { get; set; } // id_srv

        [Required]
        [Display(Name = "Id usr 1 g")]
        public int IdUsr1G { get; set; } // id_usr_1g

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Display(Name = "Is def")]
        public bool? IsDef { get; set; } // is_def

        [Display(Name = "Id cmp")]
        public int? IdCmp { get; set; } // id_cmp

        [Display(Name = "Ruta desc")]
        public string RutaDesc { get; set; } // ruta_desc

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Ruta desc crp")]
        public string RutaDescCrp { get; set; } // ruta_desc_crp (length: 255)

        public EmlCtasMail()
        {
            RutaDesc = "";
        }
    }

}
// </auto-generated>
