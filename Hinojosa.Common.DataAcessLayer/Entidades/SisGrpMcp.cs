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

    // sis_grp_mcp
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisGrpMcp
    {
        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr (Primary key via unique index IX_sis_grp_mcp_id_usr_id_mcp)

        [Required]
        [Display(Name = "Id mcp")]
        public int IdMcp { get; set; } // id_mcp (Primary key via unique index IX_sis_grp_mcp_id_usr_id_mcp)

        [Required]
        [Display(Name = "Id grp")]
        public int IdGrp { get; set; } // id_grp

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        public SisGrpMcp()
        {
            IdUsr = 0;
            IdMcp = 0;
            IdGrp = 0;
            Status = 0;
        }
    }

}
// </auto-generated>
