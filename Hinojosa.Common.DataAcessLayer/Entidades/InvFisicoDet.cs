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

    // inv_fisico_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class InvFisicoDet
    {
        [Required]
        [Display(Name = "Id inv fis")]
        public int IdInvFis { get; set; } // id_inv_fis (Primary key)

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro (Primary key)

        [Required]
        [Display(Name = "Id alm")]
        public int IdAlm { get; set; } // id_alm (Primary key)

        [Required]
        [Display(Name = "Id ubi")]
        public int IdUbi { get; set; } // id_ubi (Primary key)

        [Required]
        [Display(Name = "Cant exist")]
        public double CantExist { get; set; } // cant_exist (Primary key)

        [Required]
        [Display(Name = "Cant fis")]
        public double CantFis { get; set; } // cant_fis (Primary key)

        [Required]
        [Display(Name = "Dif")]
        public double Dif { get; set; } // dif (Primary key)

        [Required]
        [Display(Name = "Costo prom")]
        public double CostoProm { get; set; } // costo_prom (Primary key)

        [Required]
        [Display(Name = "Id cen cto")]
        public int IdCenCto { get; set; } // id_cen_cto (Primary key)

        [Required]
        [Display(Name = "Tot alm")]
        public double TotAlm { get; set; } // tot_alm (Primary key)

        [Required]
        [Display(Name = "Tot dif")]
        public double TotDif { get; set; } // tot_dif (Primary key)

        public InvFisicoDet()
        {
            IdInvFis = 0;
            IdPro = 0;
            IdAlm = 0;
            IdUbi = 0;
            CantExist = 0;
            CantFis = 0;
            Dif = 0;
            CostoProm = 0;
            IdCenCto = 0;
            TotAlm = 0;
            TotDif = 0;
        }
    }

}
// </auto-generated>
