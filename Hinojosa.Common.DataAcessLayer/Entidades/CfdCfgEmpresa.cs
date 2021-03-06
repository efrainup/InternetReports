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

    // cfd_cfg_empresa
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CfdCfgEmpresa
    {
        [Required]
        [Display(Name = "Id cer")]
        public int IdCer { get; set; } // id_cer (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Desde")]
        public string Desde { get; set; } // Desde (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Hasta")]
        public string Hasta { get; set; } // Hasta (length: 50)

        [DataType(DataType.DateTime)]
        [Display(Name = "De")]
        public System.DateTime? De { get; set; } // De

        [DataType(DataType.DateTime)]
        [Display(Name = "A")]
        public System.DateTime? A { get; set; } // A

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Serial")]
        public string Serial { get; set; } // Serial (length: 250)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Certifi")]
        public string Certifi { get; set; } // Certifi (length: 250)

        [Required]
        [Display(Name = "Id cmp")]
        public int IdCmp { get; set; } // id_cmp

        [Required]
        [Display(Name = "Act")]
        public int Act { get; set; } // act

        [Required(AllowEmptyStrings = true)]
        [MaxLength(2147483647)]
        [StringLength(2147483647)]
        [Display(Name = "Sha")]
        public string Sha { get; set; } // sha (length: 2147483647)

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Clave pfx")]
        public string ClavePfx { get; set; } // clave_pfx

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Nombre archivo")]
        public string NombreArchivo { get; set; } // nombreArchivo

        public CfdCfgEmpresa()
        {
            Desde = "";
            Hasta = "";
            Serial = "";
            Certifi = "";
            IdCmp = 0;
            Act = 0;
            Sha = "";
            IdUsr = 1;
            FecReg = System.DateTime.Now;
            ClavePfx = "";
            NombreArchivo = "";
        }
    }

}
// </auto-generated>
