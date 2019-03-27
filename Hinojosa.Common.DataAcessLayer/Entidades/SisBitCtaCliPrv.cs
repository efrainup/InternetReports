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

    // sis_bit_cta_cli_prv
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisBitCtaCliPrv
    {
        [Required]
        [Display(Name = "Id bit")]
        public int IdBit { get; set; } // id_bit (Primary key)

        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; } // id

        [Required]
        [Display(Name = "Tip tbl")]
        public byte TipTbl { get; set; } // tip_tbl

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required(AllowEmptyStrings = true)]
        [MaxLength(11)]
        [StringLength(11)]
        [Display(Name = "Evento")]
        public string Evento { get; set; } // evento (length: 11)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Valor ant")]
        public string ValorAnt { get; set; } // valor_ant

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Valor nvo")]
        public string ValorNvo { get; set; } // valor_nvo

        public SisBitCtaCliPrv()
        {
            Id = 0;
            TipTbl = 0;
            IdUsr = 0;
            Evento = "";
            ValorAnt = "";
            ValorNvo = "";
        }
    }

}
// </auto-generated>