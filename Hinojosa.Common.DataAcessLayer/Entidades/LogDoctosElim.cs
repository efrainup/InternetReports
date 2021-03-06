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

    // log_doctos_elim
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class LogDoctosElim
    {
        [Required]
        [Display(Name = "Id log")]
        public long IdLog { get; set; } // id_log (Primary key)

        [Display(Name = "Id doc")]
        public long? IdDoc { get; set; } // id_doc

        [Display(Name = "Id tip doc")]
        public long? IdTipDoc { get; set; } // id_tip_doc

        [Display(Name = "Id tbl")]
        public long? IdTbl { get; set; } // id_tbl

        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Serie")]
        public string Serie { get; set; } // serie (length: 25)

        [Display(Name = "Id tip obj")]
        public long? IdTipObj { get; set; } // id_tip_obj

        [Display(Name = "Id usr")]
        public long? IdUsr { get; set; } // id_usr

        [Display(Name = "Id prov")]
        public long? IdProv { get; set; } // id_prov

        [Display(Name = "Id cli fa da")]
        public long? IdCliFaDa { get; set; } // id_cli_fa_da

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "No fact")]
        public string NoFact { get; set; } // no_fact (length: 20)

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime? FecReg { get; set; } // fec_reg

        public LogDoctosElim()
        {
            IdDoc = 0;
            IdTipDoc = 0;
            IdTbl = 0;
            Serie = "";
            IdTipObj = 0;
            IdUsr = 0;
            IdProv = 0;
            IdCliFaDa = 0;
            NoFact = "";
            FecReg = System.DateTime.Now;
        }
    }

}
// </auto-generated>
