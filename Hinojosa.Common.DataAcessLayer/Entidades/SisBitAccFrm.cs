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

    // sis_bit_acc_frm
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisBitAccFrm
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; } // ID (Primary key)

        [Required]
        [Display(Name = "Id sesion")]
        public int IdSesion { get; set; } // id_sesion

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Ip")]
        public string Ip { get; set; } // ip (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Nom equ")]
        public string NomEqu { get; set; } // nom_equ (length: 250)

        [Required]
        [Display(Name = "Id rec")]
        public int IdRec { get; set; } // id_rec

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Frm")]
        public string Frm { get; set; } // frm (length: 250)

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        public SisBitAccFrm()
        {
            IdSesion = 0;
            Ip = "";
            NomEqu = "";
            IdRec = 0;
            Frm = "";
            IdUsr = 0;
        }
    }

}
// </auto-generated>
