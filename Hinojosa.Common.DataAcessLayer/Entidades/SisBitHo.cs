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

    // sis_bit_hos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisBitHo
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; } // ID (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(4000)]
        [StringLength(4000)]
        [Display(Name = "Comando")]
        public string Comando { get; set; } // Comando (Primary key) (length: 4000)

        [Required]
        [Display(Name = "Tipo cat")]
        public int TipoCat { get; set; } // tipo_cat (Primary key)

        [Required]
        [Display(Name = "Id cat")]
        public int IdCat { get; set; } // id_cat (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(4000)]
        [StringLength(4000)]
        [Display(Name = "Res")]
        public string Res { get; set; } // res (Primary key) (length: 4000)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg (Primary key)

        [Required]
        [Display(Name = "Sis origen")]
        public byte SisOrigen { get; set; } // sis_origen (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(150)]
        [StringLength(150)]
        [Display(Name = "Usr")]
        public string Usr { get; set; } // usr (Primary key) (length: 150)

        [Required]
        [Display(Name = "Id evento")]
        public int IdEvento { get; set; } // id_evento (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Evento")]
        public string Evento { get; set; } // evento (Primary key) (length: 30)

        [Required]
        [Display(Name = "Id suc")]
        public int IdSuc { get; set; } // id_suc (Primary key)

        public SisBitHo()
        {
            Comando = "";
            TipoCat = 0;
            IdCat = 0;
            Res = "";
            SisOrigen = 0;
            Usr = "";
            IdEvento = 0;
            Evento = "";
            IdSuc = 0;
        }
    }

}
// </auto-generated>