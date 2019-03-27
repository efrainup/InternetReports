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

    // sis_bit_cfdi_cmd
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisBitCfdiCmd
    {
        [Required]
        [Display(Name = "Id bit")]
        public int IdBit { get; set; } // id_bit (Primary key)

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc (Primary key)

        [Required]
        [Display(Name = "Id doc")]
        public int IdDoc { get; set; } // id_doc (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "Parametros")]
        public string Parametros { get; set; } // parametros (Primary key) (length: 1000)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Respuesta")]
        public string Respuesta { get; set; } // respuesta (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg (Primary key)

        public SisBitCfdiCmd()
        {
            IdTipDoc = 0;
            IdDoc = 0;
            Parametros = "";
            Respuesta = "";
        }
    }

}
// </auto-generated>