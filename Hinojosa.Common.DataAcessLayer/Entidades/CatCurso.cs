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

    // cat_cursos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatCurso
    {
        [Required]
        [Display(Name = "Id cur")]
        public int IdCur { get; set; } // id_cur (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Cve cur")]
        public string CveCur { get; set; } // cve_cur (length: 15)

        [Required]
        [Display(Name = "Tip cur")]
        public byte TipCur { get; set; } // tip_cur

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (length: 250)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Sede")]
        public string Sede { get; set; } // sede (length: 100)

        [Required]
        [Display(Name = "Id emp")]
        public int IdEmp { get; set; } // id_emp

        [Required]
        [Display(Name = "Id prov")]
        public int IdProv { get; set; } // id_prov

        [Required]
        [Display(Name = "Nivel")]
        public byte Nivel { get; set; } // nivel

        [Required]
        [Display(Name = "Val cur")]
        public byte ValCur { get; set; } // val_cur

        [Required]
        [Display(Name = "Costo")]
        public double Costo { get; set; } // costo

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required]
        [Display(Name = "Dura")]
        public int Dura { get; set; } // dura

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [Display(Name = "Id rel cur tem")]
        public int IdRelCurTem { get; set; } // id_rel_cur_tem

        ///<summary>
        /// Si el curso aplica para la STPS
        ///</summary>
        [Required]
        [Display(Name = "C stps")]
        public byte CStps { get; set; } // c_stps

        public CatCurso()
        {
            IdCur = 0;
            CveCur = "";
            TipCur = 0;
            Des = "";
            Sede = "";
            IdEmp = 0;
            IdProv = 0;
            Nivel = 0;
            ValCur = 0;
            Costo = 0;
            IdNota = 0;
            Dura = 0;
            Status = 1;
            IdRelCurTem = 0;
            CStps = 0;
        }
    }

}
// </auto-generated>
