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

    // sis_rel_fmto
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisRelFmto
    {
        [Required]
        [Display(Name = "Id rel fmto")]
        public int IdRelFmto { get; set; } // id_rel_fmto (Primary key via unique index IX_sis_rel_fmto)

        [Required]
        [Display(Name = "Id fmto")]
        public int IdFmto { get; set; } // id_fmto (Primary key via unique index IX_sis_rel_fmto)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (length: 50)

        [Required]
        [Display(Name = "C def")]
        public bool CDef { get; set; } // c_def

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Cfd")]
        public byte Cfd { get; set; } // cfd

        [Required]
        [Display(Name = "C exp xls")]
        public byte CExpXls { get; set; } // c_exp_xls

        [Required]
        [Display(Name = "C exp html")]
        public byte CExpHtml { get; set; } // c_exp_html

        [Required]
        [Display(Name = "C exp pdf")]
        public byte CExpPdf { get; set; } // c_exp_pdf

        [Required]
        [Display(Name = "Cfdi")]
        public byte Cfdi { get; set; } // cfdi

        public SisRelFmto()
        {
            IdRelFmto = 0;
            IdFmto = 0;
            Des = "";
            CDef = false;
            IdUsr = 0;
            FecReg = System.DateTime.Now;
            Cfd = 0;
            CExpXls = 0;
            CExpHtml = 0;
            CExpPdf = 0;
            Cfdi = 0;
        }
    }

}
// </auto-generated>
