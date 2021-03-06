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

    // inv_aju_cto_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class InvAjuCtoDet
    {
        [Required]
        [Display(Name = "Id aju cto det")]
        public int IdAjuCtoDet { get; set; } // id_aju_cto_det (Primary key)

        [Required]
        [Display(Name = "Id aju cto")]
        public int IdAjuCto { get; set; } // id_aju_cto

        [Required]
        [Display(Name = "Id tip doc apl")]
        public int IdTipDocApl { get; set; } // id_tip_doc_apl

        [Required]
        [Display(Name = "Id doc apl")]
        public int IdDocApl { get; set; } // id_doc_apl

        [Required]
        [Display(Name = "Id doc det apl")]
        public int IdDocDetApl { get; set; } // id_doc_det_apl

        [Required]
        [Display(Name = "Num doc apl")]
        public int NumDocApl { get; set; } // num_doc_apl

        [Required]
        [Display(Name = "Id suc")]
        public int IdSuc { get; set; } // id_suc

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro

        [Required]
        [Display(Name = "Id udm")]
        public int IdUdm { get; set; } // id_udm

        [Required]
        [Display(Name = "Costo rec")]
        public double CostoRec { get; set; } // costo_rec

        [Required]
        [Display(Name = "Costo cxp")]
        public double CostoCxp { get; set; } // costo_cxp

        [Required]
        [Display(Name = "Aju")]
        public double Aju { get; set; } // aju

        [Required]
        [Display(Name = "Id cl as")]
        public int IdClAs { get; set; } // id_clAS

        [Required]
        [Display(Name = "Id alm")]
        public int IdAlm { get; set; } // id_alm

        [Required]
        [Display(Name = "C inv")]
        public byte CInv { get; set; } // c_inv

        [Required]
        [Display(Name = "Id rel cto ind")]
        public int IdRelCtoInd { get; set; } // id_rel_cto_ind

        [Required]
        [Display(Name = "Id cen cto")]
        public int IdCenCto { get; set; } // id_cen_cto

        [Required]
        [Display(Name = "Id cta gto")]
        public int IdCtaGto { get; set; } // id_cta_gto

        [Required]
        [Display(Name = "Id cta apl")]
        public int IdCtaApl { get; set; } // id_cta_apl

        [Required]
        [Display(Name = "Id tip cto")]
        public int IdTipCto { get; set; } // id_tip_cto

        public InvAjuCtoDet()
        {
            IdAjuCto = 0;
            IdTipDocApl = 0;
            IdDocApl = 0;
            IdDocDetApl = 0;
            NumDocApl = 0;
            IdSuc = 0;
            IdPro = 0;
            IdUdm = 0;
            CostoRec = 0;
            CostoCxp = 0;
            Aju = 0;
            IdClAs = 0;
            IdAlm = 0;
            CInv = 0;
            IdRelCtoInd = 0;
            IdCenCto = 0;
            IdCtaGto = 0;
            IdCtaApl = 0;
            IdTipCto = 0;
        }
    }

}
// </auto-generated>
