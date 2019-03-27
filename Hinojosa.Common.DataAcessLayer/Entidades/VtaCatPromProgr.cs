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

    // vta_cat_prom_progr
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaCatPromProgr
    {
        [Required]
        [Display(Name = "Id prom progr")]
        public int IdPromProgr { get; set; } // id_prom_progr (Primary key)

        [Required]
        [Display(Name = "Id prom")]
        public int IdProm { get; set; } // id_prom

        [Required]
        [Display(Name = "Id tip vig")]
        public int IdTipVig { get; set; } // id_tip_vig

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Valor")]
        public string Valor { get; set; } // valor (length: 20)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Hr ini")]
        public System.DateTime HrIni { get; set; } // hr_ini

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Hr fin")]
        public System.DateTime HrFin { get; set; } // hr_fin

        [Required]
        [Display(Name = "Full dia")]
        public bool FullDia { get; set; } // full_dia

        public VtaCatPromProgr()
        {
            IdPromProgr = 0;
            IdProm = 0;
            IdTipVig = 0;
            Valor = "";
            FullDia = false;
        }
    }

}
// </auto-generated>