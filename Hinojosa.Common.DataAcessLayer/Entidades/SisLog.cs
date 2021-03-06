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

    // sis_log
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisLog
    {
        [Required]
        [Display(Name = "Id sis log")]
        public int IdSisLog { get; set; } // id_sis_log (Primary key)

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc

        [Required]
        [Display(Name = "Id doc")]
        public int IdDoc { get; set; } // id_doc

        [Required]
        [Display(Name = "Num doc")]
        public int NumDoc { get; set; } // num_doc

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Serie")]
        public string Serie { get; set; } // serie (length: 10)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec doc")]
        public System.DateTime FecDoc { get; set; } // fec_doc

        [Required]
        [Display(Name = "Id tbl")]
        public int IdTbl { get; set; } // id_tbl

        [Required]
        [Display(Name = "Id part")]
        public int IdPart { get; set; } // id_part

        [Required]
        [Display(Name = "Id tip acc")]
        public int IdTipAcc { get; set; } // id_tip_acc

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required(AllowEmptyStrings = true)]
        [MaxLength(2147483647)]
        [StringLength(2147483647)]
        [Display(Name = "Cad sql")]
        public string CadSql { get; set; } // cad_sql (length: 2147483647)

        public SisLog()
        {
            IdUsr = 0;
            IdTipDoc = 0;
            IdDoc = 0;
            NumDoc = 0;
            Serie = "";
            IdTbl = 0;
            IdPart = 0;
            IdTipAcc = 0;
            IdNota = 0;
            CadSql = "";
        }
    }

}
// </auto-generated>
