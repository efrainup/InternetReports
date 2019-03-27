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

    // sis_emb_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisEmbDet
    {
        [Required]
        [Display(Name = "Id emb det")]
        public int IdEmbDet { get; set; } // id_emb_det (Primary key)

        [Required]
        [Display(Name = "Id emb")]
        public int IdEmb { get; set; } // id_emb (Primary key)

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
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec doc")]
        public System.DateTime FecDoc { get; set; } // fec_doc (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Serie")]
        public string Serie { get; set; } // serie (Primary key) (length: 10)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ent")]
        public System.DateTime FecEnt { get; set; } // fec_ent (Primary key)

        [Required]
        [Display(Name = "Id doc det")]
        public int IdDocDet { get; set; } // id_doc_det (Primary key)

        [Required]
        [Display(Name = "Id com ser lot")]
        public int IdComSerLot { get; set; } // id_com_ser_lot (Primary key)

        [Required]
        [Display(Name = "Cant surt")]
        public double CantSurt { get; set; } // cant_surt (Primary key)

        [Required]
        [Display(Name = "Cant surt aut")]
        public double CantSurtAut { get; set; } // cant_surt_aut (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(70)]
        [StringLength(70)]
        [Display(Name = "Recibio")]
        public string Recibio { get; set; } // Recibio (Primary key) (length: 70)

        public SisEmbDet()
        {
            IdEmb = 0;
            IdTipDoc = 0;
            IdDoc = 0;
            NumDoc = 0;
            Serie = "";
            IdDocDet = 0;
            IdComSerLot = 0;
            CantSurt = 0;
            CantSurtAut = 0;
            Recibio = "";
        }
    }

}
// </auto-generated>