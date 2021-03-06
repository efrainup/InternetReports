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

    // sis_series_atio
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisSeriesAtio
    {
        [Required]
        [Display(Name = "Id ser")]
        public int IdSer { get; set; } // id_ser (Primary key)

        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Serie")]
        public string Serie { get; set; } // serie (length: 25)

        [Display(Name = "Lmax")]
        public long? Lmax { get; set; } // lmax

        [Display(Name = "Lmin")]
        public long? Lmin { get; set; } // lmin

        [Display(Name = "Id suc atio")]
        public int? IdSucAtio { get; set; } // id_suc_atio

        [Display(Name = "Id usr")]
        public int? IdUsr { get; set; } // id_usr

        [Display(Name = "Status")]
        public int? Status { get; set; } // status

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecrec")]
        public System.DateTime? Fecrec { get; set; } // fecrec

        [DataType(DataType.DateTime)]
        [Display(Name = "Feclog")]
        public System.DateTime? Feclog { get; set; } // feclog
    }

}
// </auto-generated>
