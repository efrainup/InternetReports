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

    // cat_col
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class dno_CatCol
    {
        [Required]
        [Display(Name = "Id col")]
        public int IdCol { get; set; } // id_col (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Nom")]
        public string Nom { get; set; } // nom (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Ap pat")]
        public string ApPat { get; set; } // ap_pat (length: 30)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Ap mat")]
        public string ApMat { get; set; } // ap_mat (length: 30)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec nac")]
        public System.DateTime FecNac { get; set; } // fec_nac

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required(AllowEmptyStrings = true)]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Rfc")]
        public string Rfc { get; set; } // rfc (length: 15)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Curp")]
        public string Curp { get; set; } // curp (length: 20)

        [Required]
        [Display(Name = "Sexo")]
        public byte Sexo { get; set; } // sexo

        [Required]
        [Display(Name = "Edocivil")]
        public byte Edocivil { get; set; } // edocivil

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Col")]
        public string Col { get; set; } // col (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; } // ciudad (length: 50)

        [Required]
        [Display(Name = "Id edo")]
        public byte IdEdo { get; set; } // id_edo

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Cp")]
        public string Cp { get; set; } // cp (length: 5)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Calle")]
        public string Calle { get; set; } // calle (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "No int")]
        public string NoInt { get; set; } // no_int (length: 5)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "No ext")]
        public string NoExt { get; set; } // no_ext (length: 5)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Entre calles")]
        public string EntreCalles { get; set; } // entre_calles (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Del")]
        public string Del { get; set; } // del (length: 50)

        [Required]
        [Display(Name = "Id edo nac")]
        public byte IdEdoNac { get; set; } // id_edo_nac

        [Required]
        [Display(Name = "Id cmp")]
        public int IdCmp { get; set; } // id_cmp

        [Required]
        [Display(Name = "Id pais nac")]
        public int IdPaisNac { get; set; } // id_pais_nac

        [Required]
        [Display(Name = "Id pais")]
        public int IdPais { get; set; } // id_pais

        [Required]
        [Display(Name = "Id cli")]
        public int IdCli { get; set; } // id_cli
    }

}
// </auto-generated>
