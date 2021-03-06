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

    // gas_tar
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class GasTar
    {
        [Required]
        [Display(Name = "Id gas tar")]
        public int IdGasTar { get; set; } // id_gas_tar (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Cve tar")]
        public string CveTar { get; set; } // cve_tar (length: 10)

        [Required]
        [Display(Name = "Id eje")]
        public int IdEje { get; set; } // id_eje

        [Required]
        [Display(Name = "Id per")]
        public int IdPer { get; set; } // id_per

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro

        [Required]
        [Display(Name = "Mpu")]
        public double Mpu { get; set; } // mpu

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Des tar")]
        public string DesTar { get; set; } // des_tar (length: 50)

        public GasTar()
        {
            CveTar = "";
            IdEje = 0;
            IdPer = 0;
            IdPro = 0;
            Mpu = 0;
            Status = 0;
        }
    }

}
// </auto-generated>
