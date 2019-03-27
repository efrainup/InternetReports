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

    // vta_cor_caj_det_val
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaCorCajDetVal
    {
        [Required]
        [Display(Name = "Id cor det")]
        public int IdCorDet { get; set; } // id_cor_det (Primary key)

        [Required]
        [Display(Name = "Id cor caj")]
        public int IdCorCaj { get; set; } // id_cor_caj (Primary key)

        [Required]
        [Display(Name = "Id valor")]
        public int IdValor { get; set; } // id_valor (Primary key)

        [Required]
        [Display(Name = "Cant")]
        public double Cant { get; set; } // cant (Primary key)

        [Display(Name = "Status")]
        public int? Status { get; set; } // status

        [Display(Name = "Cant 2")]
        public double? Cant2 { get; set; } // cant2

        public VtaCorCajDetVal()
        {
            IdCorDet = 0;
            IdCorCaj = 0;
            IdValor = 0;
            Cant = 0;
            Status = 0;
            Cant2 = 0;
        }
    }

}
// </auto-generated>