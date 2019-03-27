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

    // bit_pag_crp
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class BitPagCrp
    {
        [Required]
        [Display(Name = "Id bit pag crp")]
        public int IdBitPagCrp { get; set; } // id_bit_pag_crp (Primary key)

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha")]
        public System.DateTime? Fecha { get; set; } // Fecha

        [Display(Name = "Usr")]
        public int? Usr { get; set; } // usr

        [Display(Name = "Docto")]
        public int? Docto { get; set; } // docto

        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (length: 200)

        [Display(Name = "Status")]
        public byte? Status { get; set; } // status
    }

}
// </auto-generated>
