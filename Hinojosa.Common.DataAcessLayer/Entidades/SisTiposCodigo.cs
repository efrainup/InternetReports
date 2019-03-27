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

    // sis_tipos_codigos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisTiposCodigo
    {
        [Required]
        [Display(Name = "Id tipo codigo")]
        public int IdTipoCodigo { get; set; } // id_tipo_codigo (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; } // descripcion (Primary key) (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Str tipo caracter")]
        public string StrTipoCaracter { get; set; } // str_tipo_caracter (Primary key) (length: 50)

        [Required]
        [Display(Name = "Int longitud")]
        public int IntLongitud { get; set; } // int_longitud (Primary key)

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Clave")]
        public string Clave { get; set; } // clave (Primary key) (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Encode mode")]
        public string EncodeMode { get; set; } // encode_mode (Primary key) (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Error correct")]
        public string ErrorCorrect { get; set; } // error_correct (Primary key) (length: 50)

        [Required]
        [Display(Name = "Code scale")]
        public int CodeScale { get; set; } // code_scale (Primary key)

        [Required]
        [Display(Name = "Code version")]
        public int CodeVersion { get; set; } // code_version (Primary key)

        public SisTiposCodigo()
        {
            Descripcion = "";
            StrTipoCaracter = "0";
            IntLongitud = 0;
            Status = 0;
            FecReg = System.DateTime.Now;
            Clave = "";
            EncodeMode = "";
            ErrorCorrect = "";
            CodeScale = 0;
            CodeVersion = 0;
        }
    }

}
// </auto-generated>