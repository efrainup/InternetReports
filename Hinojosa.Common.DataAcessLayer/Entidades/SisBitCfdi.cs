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

    // sis_bit_cfdi
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisBitCfdi
    {
        [Required]
        [Display(Name = "Id bitacora")]
        public int IdBitacora { get; set; } // id_bitacora (Primary key)

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc (Primary key)

        [Required]
        [Display(Name = "Id doc")]
        public int IdDoc { get; set; } // id_doc (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Serie")]
        public string Serie { get; set; } // serie (Primary key) (length: 10)

        [Required]
        [Display(Name = "Num doc")]
        public int NumDoc { get; set; } // num_doc (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec doc")]
        public System.DateTime FecDoc { get; set; } // fec_doc (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(2000)]
        [StringLength(2000)]
        [Display(Name = "Res header")]
        public string ResHeader { get; set; } // res_header (Primary key) (length: 2000)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(2147483647)]
        [StringLength(2147483647)]
        [Display(Name = "Err descripcion")]
        public string ErrDescripcion { get; set; } // err_descripcion (Primary key) (length: 2147483647)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg (Primary key)

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Ip")]
        public string Ip { get; set; } // IP (Primary key) (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(150)]
        [StringLength(150)]
        [Display(Name = "Equipo")]
        public string Equipo { get; set; } // equipo (Primary key) (length: 150)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(150)]
        [StringLength(150)]
        [Display(Name = "Aplicacion origen")]
        public string AplicacionOrigen { get; set; } // aplicacion_origen (Primary key) (length: 150)

        [Required]
        [Display(Name = "Modo")]
        public byte Modo { get; set; } // modo (Primary key)
    }

}
// </auto-generated>
