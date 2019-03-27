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

    // inv_desconsolida_serie
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class InvDesconsolidaSerie
    {
        [Required]
        [Display(Name = "Id desc ser")]
        public int IdDescSer { get; set; } // id_desc_ser (Primary key)

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc

        [Required]
        [Display(Name = "Num doc")]
        public int NumDoc { get; set; } // num_doc

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec doc")]
        public System.DateTime FecDoc { get; set; } // fec_doc

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro

        [Required]
        [Display(Name = "Id mto ser lot")]
        public int IdMtoSerLot { get; set; } // id_mto_ser_lot

        [Required]
        [Display(Name = "Id com ser lot")]
        public int IdComSerLot { get; set; } // id_com_ser_lot

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [Display(Name = "Id tip doc ori")]
        public int IdTipDocOri { get; set; } // id_tip_doc_ori

        [Required]
        [Display(Name = "Id doc ori")]
        public int IdDocOri { get; set; } // id_doc_ori

        [Required]
        [Display(Name = "Id doc det ori")]
        public int IdDocDetOri { get; set; } // id_doc_det_ori

        public InvDesconsolidaSerie()
        {
            IdDescSer = 0;
            IdTipDoc = 0;
            NumDoc = 0;
            IdPro = 0;
            IdMtoSerLot = 0;
            IdComSerLot = 0;
            IdUsr = 0;
            Status = 0;
            IdTipDocOri = 0;
            IdDocOri = 0;
            IdDocDetOri = 0;
        }
    }

}
// </auto-generated>
