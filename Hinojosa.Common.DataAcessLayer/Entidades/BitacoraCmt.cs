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

    // BitacoraCmt
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class BitacoraCmt
    {
        [Required]
        [Display(Name = "Id bitacora cmt")]
        public int IdBitacoraCmt { get; set; } // id_bitacoraCmt (Primary key)

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc

        [Required]
        [Display(Name = "Id doc")]
        public int IdDoc { get; set; } // id_doc

        [Required(AllowEmptyStrings = true)]
        [MaxLength(260)]
        [StringLength(260)]
        [Display(Name = "Cmt ant")]
        public string CmtAnt { get; set; } // cmtAnt (length: 260)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(260)]
        [StringLength(260)]
        [Display(Name = "Cmt act")]
        public string CmtAct { get; set; } // cmtAct (length: 260)

        [Required]
        [Display(Name = "C enc")]
        public byte CEnc { get; set; } // c_enc

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        public BitacoraCmt()
        {
            IdBitacoraCmt = 0;
            IdTipDoc = 0;
            IdDoc = 0;
            CmtAnt = "";
            CmtAct = "";
            CEnc = 0;
            IdUsr = 0;
        }
    }

}
// </auto-generated>
