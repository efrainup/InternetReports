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

    // bco_aux_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class BcoAuxDet
    {
        [Required]
        [Display(Name = "Id bco aux det")]
        public int IdBcoAuxDet { get; set; } // id_bco_aux_det (Primary key)

        [Required]
        [Display(Name = "Id bco aux")]
        public int IdBcoAux { get; set; } // id_bco_aux

        [Required]
        [Display(Name = "No part")]
        public int NoPart { get; set; } // no_part

        [Required]
        [Display(Name = "Id tip trn")]
        public int IdTipTrn { get; set; } // id_tip_trn

        [Required]
        [Display(Name = "Id tip tar")]
        public int IdTipTar { get; set; } // id_tip_tar

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "No tar")]
        public string NoTar { get; set; } // no_tar (length: 20)

        [Required]
        [Display(Name = "Id bco cta ter")]
        public int IdBcoCtaTer { get; set; } // id_bco_cta_ter

        [Required]
        [Display(Name = "Ref num")]
        public int RefNum { get; set; } // ref_num

        [Required]
        [Display(Name = "Monto")]
        public double Monto { get; set; } // monto

        public BcoAuxDet()
        {
            IdBcoAuxDet = 0;
            NoPart = 0;
            IdTipTrn = 0;
            NoTar = "";
            IdBcoCtaTer = 0;
            RefNum = 0;
            Monto = 0;
        }
    }

}
// </auto-generated>
