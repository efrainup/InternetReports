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

    // vta_cat_prom
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaCatProm
    {
        [Required]
        [Display(Name = "Id prom")]
        public int IdProm { get; set; } // id_prom (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Cve prom")]
        public string CveProm { get; set; } // cve_prom (length: 25)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "Cod prom")]
        public string CodProm { get; set; } // cod_prom (length: 60)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Des prom")]
        public string DesProm { get; set; } // des_prom (length: 80)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha ini vig")]
        public System.DateTime FechaIniVig { get; set; } // fecha_ini_vig

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha fin vig")]
        public System.DateTime FechaFinVig { get; set; } // fecha_fin_vig

        [Required]
        [Display(Name = "Acumulable")]
        public bool Acumulable { get; set; } // acumulable

        [Required]
        [Display(Name = "Id tip retrib")]
        public byte IdTipRetrib { get; set; } // id_tip_retrib

        [Required(AllowEmptyStrings = true)]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Des tip retrib")]
        public string DesTipRetrib { get; set; } // des_tip_retrib (length: 15)

        [Display(Name = "Param 1 ret")]
        public double? Param1Ret { get; set; } // param1_ret

        [Display(Name = "Param 2 ret")]
        public double? Param2Ret { get; set; } // param2_ret

        [Display(Name = "Porc")]
        public double? Porc { get; set; } // porc

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Status 2")]
        public byte Status2 { get; set; } // status2

        [Required]
        [Display(Name = "C prom uni")]
        public bool CPromUni { get; set; } // c_prom_uni

        [Required]
        [Display(Name = "C todos")]
        public bool CTodos { get; set; } // c_todos

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [vta_cat_prom].([IdUsr]) (FK_vta_cat_prom_cat_usr)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_vta_cat_prom_cat_usr

        public VtaCatProm()
        {
            IdProm = 0;
            CveProm = "";
            CodProm = "";
            DesProm = "";
            Acumulable = false;
            IdTipRetrib = 0;
            DesTipRetrib = "";
            Param1Ret = 0.00;
            Param2Ret = 0.00;
            Porc = 0.00;
            Status = 3;
            IdUsr = 0;
            Status2 = 3;
            CPromUni = false;
            CTodos = false;
        }
    }

}
// </auto-generated>
