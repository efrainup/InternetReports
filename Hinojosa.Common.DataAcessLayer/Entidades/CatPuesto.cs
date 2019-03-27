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

    // cat_puestos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatPuesto
    {
        [Required]
        [Display(Name = "Id puesto")]
        public int IdPuesto { get; set; } // id_puesto (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (length: 50)

        [Required]
        [Display(Name = "Sal min")]
        public double SalMin { get; set; } // sal_min

        [Required]
        [Display(Name = "Sal max")]
        public double SalMax { get; set; } // sal_max

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        ///<summary>
        /// 1=Interno 2=Contactos
        ///</summary>
        [Required]
        [Display(Name = "Tipo")]
        public byte Tipo { get; set; } // tipo

        [Required]
        [Display(Name = "C dir")]
        public byte CDir { get; set; } // c_dir

        [Required]
        [Display(Name = "C ger")]
        public byte CGer { get; set; } // c_ger

        [Required]
        [Display(Name = "C emp")]
        public byte CEmp { get; set; } // c_emp

        [Required]
        [Display(Name = "C eve")]
        public byte CEve { get; set; } // c_eve

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Id otr sis")]
        public string IdOtrSis { get; set; } // id_otr_sis (length: 25)

        [Required]
        [Display(Name = "C oper")]
        public byte COper { get; set; } // c_oper

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Des 2")]
        public string Des2 { get; set; } // des2 (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Clave")]
        public string Clave { get; set; } // clave (length: 15)

        public CatPuesto()
        {
            IdPuesto = 0;
            Des = "";
            SalMin = 0;
            SalMax = 0;
            Status = 1;
            Tipo = 1;
            CDir = 0;
            CGer = 0;
            CEmp = 0;
            CEve = 0;
            IdOtrSis = "";
            COper = 0;
            Des2 = "";
            Clave = "";
        }
    }

}
// </auto-generated>
