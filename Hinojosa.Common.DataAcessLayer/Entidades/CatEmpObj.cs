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

    // cat_emp_obj
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatEmpObj
    {
        [Required]
        [Display(Name = "Id obj")]
        public int IdObj { get; set; } // Id_Obj (Primary key)

        [Required]
        [Display(Name = "Id rel obj")]
        public int IdRelObj { get; set; } // Id_Rel_Obj

        [Required(AllowEmptyStrings = true)]
        [MaxLength(7)]
        [StringLength(7)]
        [Display(Name = "Per")]
        public string Per { get; set; } // Per (length: 7)

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Des")]
        public string Des { get; set; } // Des (length: 100)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ini")]
        public System.DateTime FecIni { get; set; } // Fec_Ini

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ter")]
        public System.DateTime FecTer { get; set; } // Fec_Ter

        [Required]
        [Display(Name = "Cal")]
        public double Cal { get; set; } // Cal

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // Id_Nota

        [Required]
        [Display(Name = "Id tip")]
        public int IdTip { get; set; } // Id_Tip

        [Required]
        [Display(Name = "Id clas")]
        public int IdClas { get; set; } // id_clas

        [Required]
        [Display(Name = "Id per rh")]
        public int IdPerRh { get; set; } // id_per_rh

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ini real")]
        public System.DateTime FecIniReal { get; set; } // fec_ini_real

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ter real")]
        public System.DateTime FecTerReal { get; set; } // fec_ter_real

        public CatEmpObj()
        {
            IdObj = 0;
            IdRelObj = 0;
            Per = " ";
            Des = "";
            Cal = 0;
            IdNota = 0;
            IdTip = 0;
            IdClas = 0;
            IdPerRh = 0;
        }
    }

}
// </auto-generated>
