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

    // ctrol_doc_sesion
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CtrolDocSesion
    {
        [Required]
        [Display(Name = "Id ctrol doc sesion")]
        public int IdCtrolDocSesion { get; set; } // id_ctrol_doc_sesion (Primary key)

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc (Primary key)

        [Required]
        [Display(Name = "Id doc")]
        public int IdDoc { get; set; } // id_doc (Primary key)

        [Required]
        [Display(Name = "Num doc")]
        public int NumDoc { get; set; } // num_doc (Primary key)

        [Required]
        [Display(Name = "Id tbl")]
        public int IdTbl { get; set; } // id_tbl (Primary key)

        [Required]
        [Display(Name = "Id sesion")]
        public int IdSesion { get; set; } // id_sesion (Primary key)

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg (Primary key)

        public CtrolDocSesion()
        {
            IdCtrolDocSesion = 0;
            IdTipDoc = 0;
            IdDoc = 0;
            NumDoc = 0;
            IdTbl = 0;
            IdSesion = 0;
            Status = 0;
        }
    }

}
// </auto-generated>
