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

    // cat_config_tic_pdv
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatConfigTicPdv
    {
        [Required]
        [Display(Name = "Id tipo")]
        public int IdTipo { get; set; } // id_tipo (Primary key)

        [Required]
        [Display(Name = "Numero")]
        public int Numero { get; set; } // numero (Primary key)

        [Required]
        [Display(Name = "Tipo")]
        public int Tipo { get; set; } // tipo (Primary key)

        [Required]
        [Display(Name = "Linea")]
        public int Linea { get; set; } // linea (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(120)]
        [StringLength(120)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (Primary key) (length: 120)

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status (Primary key)

        [Required]
        [Display(Name = "Formato")]
        public int Formato { get; set; } // formato (Primary key)

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Desformato")]
        public string Desformato { get; set; } // desformato (Primary key) (length: 25)

        [Required]
        [Display(Name = "Aplicado")]
        public byte Aplicado { get; set; } // aplicado (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fch reg")]
        public System.DateTime FchReg { get; set; } // fch_reg (Primary key)

        [Display(Name = "Id suc")]
        public int? IdSuc { get; set; } // id_suc

        public CatConfigTicPdv()
        {
            Numero = 0;
            Tipo = 0;
            Linea = 0;
            Des = "";
            Status = 0;
            Formato = 0;
            IdUsr = 0;
            Desformato = "";
            Aplicado = 0;
        }
    }

}
// </auto-generated>
