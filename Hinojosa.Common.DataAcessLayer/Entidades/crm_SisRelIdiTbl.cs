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

    // sis_rel_idi_tbl
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_SisRelIdiTbl
    {
        [Required]
        [Display(Name = "Id sis rel idi tbl")]
        public int IdSisRelIdiTbl { get; set; } // id_sis_rel_idi_tbl (Primary key)

        [Required]
        [Display(Name = "Id tbl")]
        public int IdTbl { get; set; } // id_tbl

        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; } // id

        [Required]
        [Display(Name = "Id tip idi")]
        public int IdTipIdi { get; set; } // id_tip_idi

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Txt")]
        public string Txt { get; set; } // txt

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Id cmp")]
        public int IdCmp { get; set; } // id_cmp

        public crm_SisRelIdiTbl()
        {
            IdTbl = 0;
            Id = 0;
            IdTipIdi = 0;
            Txt = "0";
            Status = 0;
            IdUsr = 0;
            IdCmp = 0;
        }
    }

}
// </auto-generated>
