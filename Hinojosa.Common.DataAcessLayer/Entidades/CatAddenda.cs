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

    // cat_addendas
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatAddenda
    {
        [Required]
        [Display(Name = "Id add")]
        public int IdAdd { get; set; } // id_add (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Num prov")]
        public string NumProv { get; set; } // num_prov (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Cen cost")]
        public string CenCost { get; set; } // cen_cost (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Mail")]
        public string Mail { get; set; } // mail (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Suc")]
        public string Suc { get; set; } // Suc (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Area")]
        public string Area { get; set; } // Area (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Id cli 1")]
        public string IdCli1 { get; set; } // id_cli1 (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Id cli 2")]
        public string IdCli2 { get; set; } // id_cli2 (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Glin")]
        public string Glin { get; set; } // glin (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Gtin")]
        public string Gtin { get; set; } // gtin (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Lang")]
        public string Lang { get; set; } // lang (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Usr fld 1")]
        public string UsrFld1 { get; set; } // usr_fld1 (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Usr fld 2")]
        public string UsrFld2 { get; set; } // usr_fld2 (length: 50)

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status

        [Required(AllowEmptyStrings = true)]
        [MaxLength(2147483647)]
        [StringLength(2147483647)]
        [Display(Name = "Texto")]
        public string Texto { get; set; } // texto (length: 2147483647)

        public CatAddenda()
        {
            Des = "";
            NumProv = "";
            CenCost = "";
            Mail = "";
            Suc = "";
            Area = "";
            IdCli1 = "";
            IdCli2 = "";
            Glin = "";
            Gtin = "";
            Lang = "";
            UsrFld1 = "";
            UsrFld2 = "";
            Status = 0;
            Texto = "";
        }
    }

}
// </auto-generated>