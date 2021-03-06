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

    // sis_sql
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisSql
    {
        [Required]
        [Display(Name = "Id sql")]
        public int IdSql { get; set; } // id_sql (Primary key)

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required]
        [Display(Name = "Fec reg")]
        public int FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [Display(Name = "Num doc")]
        public int NumDoc { get; set; } // num_doc

        [Required]
        [Display(Name = "Fec doc")]
        public int FecDoc { get; set; } // fec_doc

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Nom")]
        public string Nom { get; set; } // nom (length: 25)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Cadsql")]
        public string Cadsql { get; set; } // cadsql (length: 255)

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        public SisSql()
        {
            IdSql = 0;
            IdNota = 0;
            FecReg = 0;
            IdUsr = 0;
            NumDoc = 0;
            FecDoc = 0;
            Nom = "";
            Cadsql = "";
            Status = 1;
        }
    }

}
// </auto-generated>
