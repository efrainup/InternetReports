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

    // cat_clientes_dir
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatClientesDir
    {
        [Required]
        [Display(Name = "Id cli")]
        public int IdCli { get; set; } // id_cli (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Dir 1")]
        public string Dir1 { get; set; } // dir1 (Primary key) (length: 255)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Dir 2")]
        public string Dir2 { get; set; } // dir2 (Primary key) (length: 255)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; } // ciudad (Primary key) (length: 30)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Estado")]
        public string Estado { get; set; } // estado (Primary key) (length: 30)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(8)]
        [StringLength(8)]
        [Display(Name = "Cp")]
        public string Cp { get; set; } // cp (Primary key) (length: 8)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Tel 1")]
        public string Tel1 { get; set; } // tel1 (length: 30)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Tel 2")]
        public string Tel2 { get; set; } // tel2 (length: 30)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Calle")]
        public string Calle { get; set; } // calle (Primary key) (length: 40)

        ///<summary>
        /// Numero Interior
        ///</summary>
        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Num int")]
        public string NumInt { get; set; } // num_int (Primary key) (length: 10)

        ///<summary>
        /// numero exterior
        ///</summary>
        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Num ext")]
        public string NumExt { get; set; } // num_ext (Primary key) (length: 10)

        ///<summary>
        /// Colonia
        ///</summary>
        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Col")]
        public string Col { get; set; } // col (Primary key) (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Deleg")]
        public string Deleg { get; set; } // deleg (Primary key) (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Calles")]
        public string Calles { get; set; } // calles (Primary key) (length: 40)

        // Foreign keys

        /// <summary>
        /// Parent CatCliente pointed by [cat_clientes_dir].([IdCli]) (FK_cat_clientes_dir_cat_clientes)
        /// </summary>
        public virtual CatCliente CatCliente { get; set; } // FK_cat_clientes_dir_cat_clientes

        public CatClientesDir()
        {
            Calle = "";
            NumInt = "";
            NumExt = "";
            Col = "";
            Deleg = "";
            Calles = "";
        }
    }

}
// </auto-generated>
