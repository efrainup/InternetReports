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

    // act_fac
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ActFac
    {
        [Required]
        [Display(Name = "Id act fac")]
        public int IdActFac { get; set; } // id_act_fac (Primary key)

        [Required]
        [Display(Name = "Part")]
        public int Part { get; set; } // part

        [Required]
        [Display(Name = "Id act")]
        public int IdAct { get; set; } // id_act

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec com")]
        public System.DateTime FecCom { get; set; } // fec_com

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Folio com")]
        public string FolioCom { get; set; } // folio_com (length: 40)

        [Required]
        [Display(Name = "Id prov")]
        public int IdProv { get; set; } // id_prov

        [Required]
        [Display(Name = "Id mda")]
        public int IdMda { get; set; } // id_mda

        [Required]
        [Display(Name = "Oper")]
        public byte Oper { get; set; } // oper

        [Required]
        [Display(Name = "Tc")]
        public double Tc { get; set; } // tc

        [Required]
        [Display(Name = "Mto")]
        public double Mto { get; set; } // mto

        [Required]
        [Display(Name = "Mto bse")]
        public double MtoBse { get; set; } // mto_bse

        [Required]
        [Display(Name = "C ga")]
        public byte CGa { get; set; } // c_ga

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Cmt")]
        public string Cmt { get; set; } // cmt (length: 250)

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc

        [Required]
        [Display(Name = "Id doc")]
        public int IdDoc { get; set; } // id_doc

        [Required]
        [Display(Name = "Id doc det")]
        public int IdDocDet { get; set; } // id_doc_det

        ///<summary>
        /// Número de Documento de su respectiva tabla.
        ///</summary>
        [Required]
        [Display(Name = "Num doc")]
        public int NumDoc { get; set; } // num_doc

        public ActFac()
        {
            IdActFac = 0;
            Part = 0;
            IdAct = 0;
            FolioCom = "";
            IdProv = 0;
            IdMda = 0;
            Oper = 0;
            Tc = 0;
            Mto = 0;
            MtoBse = 0;
            CGa = 0;
            Cmt = "";
            IdNota = 0;
            Status = 1;
            IdTipDoc = 0;
            IdDoc = 0;
            IdDocDet = 0;
            NumDoc = 0;
        }
    }

}
// </auto-generated>
