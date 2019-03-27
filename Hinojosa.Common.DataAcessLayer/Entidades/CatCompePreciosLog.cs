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

    // cat_compe_precios_Log
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatCompePreciosLog
    {
        [Required]
        [Display(Name = "Id log")]
        public int IdLog { get; set; } // id_log (Primary key)

        [Required]
        [Display(Name = "Total")]
        public int Total { get; set; } // total (Primary key)

        [Required]
        [Display(Name = "Id usr 1 g")]
        public int IdUsr1G { get; set; } // idUsr1G (Primary key)

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Comentario")]
        public string Comentario { get; set; } // Comentario (length: 100)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // Fec_reg (Primary key)

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status (Primary key)

        [Display(Name = "Id suc")]
        public int? IdSuc { get; set; } // id_suc
    }

}
// </auto-generated>
