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

    // info_fact_clie
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class InfoFactClie
    {
        [Required]
        [Display(Name = "Id info fact clie")]
        public int IdInfoFactClie { get; set; } // id_info_fact_clie (Primary key)

        [Required]
        [Display(Name = "Id cli tab ar")]
        public int IdCliTabAr { get; set; } // id_cli_tab_ar

        [Required(AllowEmptyStrings = true)]
        [MaxLength(150)]
        [StringLength(150)]
        [Display(Name = "Server")]
        public string Server { get; set; } // server (length: 150)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(150)]
        [StringLength(150)]
        [Display(Name = "Db")]
        public string Db { get; set; } // db (length: 150)

        [Required]
        [Display(Name = "Id tip info fact")]
        public int IdTipInfoFact { get; set; } // id_tip_info_fact

        [Required(AllowEmptyStrings = true)]
        [MaxLength(150)]
        [StringLength(150)]
        [Display(Name = "Raz soc")]
        public string RazSoc { get; set; } // raz_soc (length: 150)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Dir")]
        public string Dir { get; set; } // dir (length: 250)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Rfc")]
        public string Rfc { get; set; } // rfc (length: 20)

        [Display(Name = "Ctto")]
        public byte[] Ctto { get; set; } // ctto

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec mod")]
        public System.DateTime FecMod { get; set; } // fec_mod

        public InfoFactClie()
        {
            IdCliTabAr = 0;
            Server = "";
            Db = "";
            IdTipInfoFact = 0;
            RazSoc = "";
            Dir = "";
            Rfc = "";
            Status = 0;
            IdUsr = 0;
            FecReg = System.DateTime.Now;
            FecMod = System.DateTime.Now;
        }
    }

}
// </auto-generated>
