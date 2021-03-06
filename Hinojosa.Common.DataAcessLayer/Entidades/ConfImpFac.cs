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

    // conf_imp_fac
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ConfImpFac
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; } // id (Primary key)

        [MaxLength(600)]
        [StringLength(600)]
        [Display(Name = "Id cmps")]
        public string IdCmps { get; set; } // id_cmps (length: 600)

        [Required]
        [Display(Name = "Recurrencia")]
        public int Recurrencia { get; set; } // recurrencia (Primary key)

        [Required]
        [Display(Name = "Activa")]
        public bool Activa { get; set; } // activa (Primary key)

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fchreg")]
        public System.DateTime Fchreg { get; set; } // fchreg (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fchmod")]
        public System.DateTime Fchmod { get; set; } // fchmod (Primary key)

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Ult eje")]
        public System.DateTime UltEje { get; set; } // ult_eje (Primary key)
    }

}
// </auto-generated>
