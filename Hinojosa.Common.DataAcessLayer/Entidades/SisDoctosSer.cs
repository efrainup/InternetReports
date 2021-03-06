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

    // sis_doctos_ser
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisDoctosSer
    {
        [Required]
        [Display(Name = "Id serie")]
        public int IdSerie { get; set; } // id_serie (Primary key)

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Serie")]
        public string Serie { get; set; } // serie (Primary key) (length: 10)

        [Required]
        [Display(Name = "Id caj")]
        public int IdCaj { get; set; } // id_caj (Primary key)

        [Required]
        [Display(Name = "Id cierre")]
        public int IdCierre { get; set; } // id_cierre (Primary key)

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [Display(Name = "Num doc")]
        public int NumDoc { get; set; } // num_doc

        [Required]
        [Display(Name = "Def")]
        public byte Def { get; set; } // def

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status

        [Required]
        [Display(Name = "C cfol")]
        public byte CCfol { get; set; } // c_cfol

        [Required]
        [Display(Name = "C sell")]
        public byte CSell { get; set; } // c_sell

        [Required(AllowEmptyStrings = true)]
        [MaxLength(90)]
        [StringLength(90)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (length: 90)

        [Required]
        [Display(Name = "Folio ini")]
        public int FolioIni { get; set; } // folio_ini

        [Required]
        [Display(Name = "Folio fin")]
        public int FolioFin { get; set; } // folio_fin

        [Required]
        [Display(Name = "Id fmto")]
        public int IdFmto { get; set; } // id_fmto

        [Required]
        [Display(Name = "C imp aut")]
        public byte CImpAut { get; set; } // c_imp_aut

        [Required]
        [Display(Name = "Tip val fol")]
        public byte TipValFol { get; set; } // tip_val_fol

        [Required]
        [Display(Name = "Dias")]
        public int Dias { get; set; } // dias

        [Required]
        [Display(Name = "Ptg")]
        public int Ptg { get; set; } // ptg

        [Required]
        [Display(Name = "C act")]
        public byte CAct { get; set; } // c_act

        [Required]
        [Display(Name = "Id tip cfd")]
        public int IdTipCfd { get; set; } // id_tip_cfd

        [Required]
        [Display(Name = "Fec lock")]
        public byte FecLock { get; set; } // fec_lock

        [Required]
        [Display(Name = "C tras")]
        public byte CTras { get; set; } // c_tras

        [Required]
        [Display(Name = "Id cmp")]
        public int IdCmp { get; set; } // id_cmp (Primary key)

        [Required]
        [Display(Name = "C tim msv")]
        public bool CTimMsv { get; set; } // c_tim_msv

        public SisDoctosSer()
        {
            IdTipDoc = 0;
            Serie = "";
            IdCaj = 0;
            IdCierre = 0;
            IdUsr = 0;
            NumDoc = 0;
            Def = 0;
            Status = 0;
            CCfol = 0;
            CSell = 0;
            Des = "";
            FolioIni = 1;
            FolioFin = 999999999;
            IdFmto = 0;
            CImpAut = 0;
            TipValFol = 0;
            Dias = 0;
            Ptg = 0;
            CAct = 1;
            IdTipCfd = 0;
            FecLock = 1;
            CTras = 0;
            IdCmp = 0;
            CTimMsv = false;
        }
    }

}
// </auto-generated>
