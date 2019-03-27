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

    // mon_pol_rev_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class MonPolRevDet
    {
        [Required]
        [Display(Name = "Id mon pol rev det")]
        public int IdMonPolRevDet { get; set; } // id_mon_pol_rev_det (Primary key via unique index PK_mon_pol_rev_det)

        [Required]
        [Display(Name = "Id mon pol rev doc")]
        public int IdMonPolRevDoc { get; set; } // id_mon_pol_rev_doc

        [Required]
        [Display(Name = "Tip sdo")]
        public byte TipSdo { get; set; } // tip_sdo

        [Required]
        [Display(Name = "Id mda")]
        public int IdMda { get; set; } // id_mda

        [Required]
        [Display(Name = "Tc fm")]
        public double TcFm { get; set; } // tc_fm

        [Required]
        [Display(Name = "Id cta uti")]
        public int IdCtaUti { get; set; } // id_cta_uti

        [Required]
        [Display(Name = "Id cta bce")]
        public int IdCtaBce { get; set; } // id_cta_bce

        [Required]
        [Display(Name = "Utilidad")]
        public double Utilidad { get; set; } // utilidad

        [Required]
        [Display(Name = "Perdida")]
        public double Perdida { get; set; } // perdida

        [Required]
        [Display(Name = "Total")]
        public double Total { get; set; } // total

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required(AllowEmptyStrings = true)]
        [MaxLength(1024)]
        [StringLength(1024)]
        [Display(Name = "S tipo")]
        public string STipo { get; set; } // sTipo (length: 1024)

        [Required]
        [Display(Name = "Id cta bco")]
        public int IdCtaBco { get; set; } // id_cta_bco

        public MonPolRevDet()
        {
            IdMonPolRevDet = 0;
            IdMonPolRevDoc = 0;
            TipSdo = 0;
            IdMda = 0;
            TcFm = 0;
            IdCtaUti = 0;
            IdCtaBce = 0;
            Utilidad = 0;
            Perdida = 0;
            Total = 0;
            Status = 0;
            STipo = "";
            IdCtaBco = 0;
        }
    }

}
// </auto-generated>
