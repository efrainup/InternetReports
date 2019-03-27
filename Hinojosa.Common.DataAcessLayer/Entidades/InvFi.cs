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

    // inv_fis
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class InvFi
    {
        [Required]
        [Display(Name = "Id mov inv")]
        public int IdMovInv { get; set; } // id_mov_inv (Primary key)

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro (Primary key)

        [Required]
        [Display(Name = "Id alm")]
        public int IdAlm { get; set; } // id_alm (Primary key)

        [Required]
        [Display(Name = "Existencia")]
        public double Existencia { get; set; } // existencia

        [Required]
        [Display(Name = "Costo")]
        public double Costo { get; set; } // costo

        [Required]
        [Display(Name = "Costo tot")]
        public double CostoTot { get; set; } // costo_tot

        public InvFi()
        {
            IdMovInv = 0;
            IdPro = 0;
            IdAlm = 0;
            Existencia = 0;
            Costo = 0;
            CostoTot = 0;
        }
    }

}
// </auto-generated>