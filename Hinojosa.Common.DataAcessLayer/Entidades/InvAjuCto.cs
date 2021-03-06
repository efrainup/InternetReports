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

    // inv_aju_cto
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class InvAjuCto
    {
        [Required]
        [Display(Name = "Id aju cto")]
        public int IdAjuCto { get; set; } // id_aju_cto (Primary key)

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc

        [Required]
        [Display(Name = "Num doc")]
        public int NumDoc { get; set; } // num_doc

        [Required]
        [Display(Name = "Id suc")]
        public int IdSuc { get; set; } // id_suc

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha")]
        public System.DateTime Fecha { get; set; } // fecha

        [Required]
        [Display(Name = "Id cpt")]
        public int IdCpt { get; set; } // id_cpt

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Cmt")]
        public string Cmt { get; set; } // cmt (length: 25)

        [Required]
        [Display(Name = "Aju tot")]
        public double AjuTot { get; set; } // aju_tot

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required]
        [Display(Name = "Id pol")]
        public int IdPol { get; set; } // id_pol

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
        [Display(Name = "Id cta var")]
        public int IdCtaVar { get; set; } // id_cta_var

        [Required]
        [Display(Name = "Id per ini")]
        public int IdPerIni { get; set; } // id_per_ini

        [Required]
        [Display(Name = "Id per fin")]
        public int IdPerFin { get; set; } // id_per_fin

        public InvAjuCto()
        {
            IdTipDoc = 0;
            NumDoc = 0;
            IdSuc = 0;
            IdCpt = 0;
            Cmt = "";
            AjuTot = 0;
            IdNota = 0;
            IdPol = 0;
            IdUsr = 0;
            Status = 0;
            IdCtaVar = 0;
            IdPerIni = 0;
            IdPerFin = 0;
        }
    }

}
// </auto-generated>
