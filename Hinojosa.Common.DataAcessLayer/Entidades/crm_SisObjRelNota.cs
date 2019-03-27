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

    // sis_obj_rel_notas
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_SisObjRelNota
    {
        [Required]
        [Display(Name = "Id obj nota")]
        public int IdObjNota { get; set; } // id_obj_nota (Primary key)

        [Required]
        [Display(Name = "Id obj")]
        public int IdObj { get; set; } // id_obj

        [Required]
        [Display(Name = "Id tbl")]
        public int IdTbl { get; set; } // id_tbl

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fec eve")]
        public System.DateTime DFecEve { get; set; } // d_fec_eve

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status

        public crm_SisObjRelNota()
        {
            IdObjNota = 0;
            IdObj = 0;
            IdTbl = 0;
            IdNota = 0;
            Status = 0;
        }
    }

}
// </auto-generated>