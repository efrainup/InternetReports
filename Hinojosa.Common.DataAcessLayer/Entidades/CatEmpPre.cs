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

    // cat_emp_pres
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatEmpPre
    {
        [Required]
        [Display(Name = "Id pres")]
        public int IdPres { get; set; } // id_pres (Primary key)

        [Required]
        [Display(Name = "Id rel pres")]
        public int IdRelPres { get; set; } // id_rel_pres

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha")]
        public System.DateTime Fecha { get; set; } // fecha

        [Required]
        [Display(Name = "Mov")]
        public byte Mov { get; set; } // mov

        [Required]
        [Display(Name = "Monto")]
        public double Monto { get; set; } // monto

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Ref")]
        public string @Ref { get; set; } // ref (length: 25)

        public CatEmpPre()
        {
            IdPres = 0;
            IdRelPres = 0;
            Mov = 0;
            Monto = 0;
            IdNota = 0;
            @Ref = " ";
        }
    }

}
// </auto-generated>