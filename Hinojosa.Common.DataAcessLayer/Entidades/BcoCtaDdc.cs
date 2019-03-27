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

    // bco_cta_ddc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class BcoCtaDdc
    {
        [Required]
        [Display(Name = "Id bco ddc")]
        public int IdBcoDdc { get; set; } // id_bco_ddc (Primary key)

        [Required]
        [Display(Name = "Id rel ddc")]
        public int IdRelDdc { get; set; } // id_rel_ddc

        [Required]
        [Display(Name = "Id bco")]
        public int IdBco { get; set; } // id_bco

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "No cta")]
        public string NoCta { get; set; } // no_cta (length: 20)

        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Clabe")]
        public string Clabe { get; set; } // clabe (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "No tar")]
        public string NoTar { get; set; } // no_tar (length: 20)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Nom tar")]
        public string NomTar { get; set; } // nom_tar (length: 40)

        [Required]
        [Display(Name = "C def")]
        public byte CDef { get; set; } // c_def

        public BcoCtaDdc()
        {
            IdBcoDdc = 0;
            IdRelDdc = 0;
            IdBco = 0;
            NoCta = "";
            Clabe = "";
            NoTar = "";
            IdUsr = 0;
            Status = 1;
            NomTar = "";
            CDef = 0;
        }
    }

}
// </auto-generated>