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

    // sis_hst_edo
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisHstEdo
    {
        [Required]
        [Display(Name = "Id hst edo")]
        public int IdHstEdo { get; set; } // id_hst_edo (Primary key)

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [Display(Name = "Id fac")]
        public int IdFac { get; set; } // id_fac

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Id sis edo")]
        public int IdSisEdo { get; set; } // id_sis_edo

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fechahr")]
        public System.DateTime Fechahr { get; set; } // fechahr

        public SisHstEdo()
        {
            IdHstEdo = 0;
            IdUsr = 0;
            IdFac = 0;
            IdSisEdo = 0;
        }
    }

}
// </auto-generated>
