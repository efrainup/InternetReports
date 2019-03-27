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

    // sis_usr_esc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisUsrEsc
    {
        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr (Primary key)

        [Required]
        [Display(Name = "Id rec")]
        public int IdRec { get; set; } // id_rec (Primary key)

        [Required]
        [Display(Name = "Izq")]
        public int Izq { get; set; } // izq

        [Required]
        [Display(Name = "Arr")]
        public int Arr { get; set; } // arr

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; } // nombre (length: 80)

        public SisUsrEsc()
        {
            IdUsr = 0;
            IdRec = 0;
            Izq = 0;
            Arr = 0;
            Nombre = "";
        }
    }

}
// </auto-generated>
