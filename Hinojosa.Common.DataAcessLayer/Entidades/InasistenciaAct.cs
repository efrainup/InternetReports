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

    // inasistencia_act
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class InasistenciaAct
    {
        [Required]
        [Display(Name = "Id ina")]
        public int IdIna { get; set; } // id_ina (Primary key)

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha")]
        public System.DateTime? Fecha { get; set; } // fecha

        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "Causa")]
        public string Causa { get; set; } // causa (length: 1000)

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
