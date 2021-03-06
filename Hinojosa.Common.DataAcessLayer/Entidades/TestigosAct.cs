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

    // testigos_act
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TestigosAct
    {
        [Required]
        [Display(Name = "Id act tes")]
        public int IdActTes { get; set; } // id_act_tes (Primary key)

        [Display(Name = "Id act")]
        public int? IdAct { get; set; } // id_act

        [Display(Name = "Id emp")]
        public int? IdEmp { get; set; } // id_emp

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; } // tipo (length: 100)

        [Display(Name = "Status")]
        public int? Status { get; set; } // status

        [Display(Name = "Id usr")]
        public int? IdUsr { get; set; } // id_usr

        [DataType(DataType.DateTime)]
        [Display(Name = "Modfech")]
        public System.DateTime? Modfech { get; set; } // modfech

        [DataType(DataType.DateTime)]
        [Display(Name = "Regfech")]
        public System.DateTime? Regfech { get; set; } // regfech
    }

}
// </auto-generated>
