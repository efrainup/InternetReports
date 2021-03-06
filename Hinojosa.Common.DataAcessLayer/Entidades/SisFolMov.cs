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

    // sis_fol_mov
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisFolMov
    {
        [Required]
        [Display(Name = "Id fol mov")]
        public int IdFolMov { get; set; } // id_fol_mov (Primary key)

        [Required]
        [Display(Name = "Id tip mov")]
        public int IdTipMov { get; set; } // id_tip_mov

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Tipo mov des")]
        public string TipoMovDes { get; set; } // tipo_mov_des (length: 30)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fch mov")]
        public System.DateTime FchMov { get; set; } // fch_mov

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [Display(Name = "Id session")]
        public int IdSession { get; set; } // id_session

        [Required]
        [Display(Name = "Id ser a")]
        public double IdSerA { get; set; } // id_ser_a

        [Required]
        [Display(Name = "Id ser de")]
        public int IdSerDe { get; set; } // id_ser_de

        [Required]
        [Display(Name = "Id cmp a")]
        public int IdCmpA { get; set; } // id_cmp_a

        [Required]
        [Display(Name = "Id cmp de")]
        public int IdCmpDe { get; set; } // id_cmp_de

        [Required]
        [Display(Name = "Cant")]
        public int Cant { get; set; } // Cant

        public SisFolMov()
        {
            IdTipMov = 1;
            TipoMovDes = "";
            IdUsr = 0;
            IdSession = 0;
            IdSerA = 0;
            IdSerDe = 0;
            IdCmpA = 0;
            IdCmpDe = 0;
            Cant = 0;
        }
    }

}
// </auto-generated>
