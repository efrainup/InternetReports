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

    // log_ImpDesGas
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class LogImpDesGa
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; } // id (Primary key)

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr (Primary key)

        [Required]
        [Display(Name = "Id conf")]
        public int IdConf { get; set; } // id_conf (Primary key)

        [Required]
        [Display(Name = "Id suc atio")]
        public int IdSucAtio { get; set; } // id_suc_atio (Primary key)

        [Required]
        [Display(Name = "Tipo")]
        public int Tipo { get; set; } // tipo (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Feg reg")]
        public System.DateTime FegReg { get; set; } // feg_reg (Primary key)
    }

}
// </auto-generated>