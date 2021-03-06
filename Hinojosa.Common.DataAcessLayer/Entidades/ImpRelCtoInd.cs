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

    // imp_rel_cto_ind
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ImpRelCtoInd
    {
        [Required]
        [Display(Name = "Imp ID rel")]
        public int ImpIdRel { get; set; } // imp_id_rel (Primary key)

        [Display(Name = "Imp ID tip doc")]
        public int? ImpIdTipDoc { get; set; } // imp_id_tip_doc

        [Display(Name = "Imp ID doc")]
        public int? ImpIdDoc { get; set; } // imp_id_doc

        [Display(Name = "Imp ID doc det ind")]
        public int? ImpIdDocDetInd { get; set; } // imp_id_doc_det_ind

        [Display(Name = "Imp ID doc det apl")]
        public int? ImpIdDocDetApl { get; set; } // imp_id_doc_det_apl

        [Display(Name = "Imp ID pro srv ind")]
        public int? ImpIdProSrvInd { get; set; } // imp_id_pro_srv_ind

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Imp ID ext pro srv ind")]
        public string ImpIdExtProSrvInd { get; set; } // imp_id_ext_pro_srv_ind (length: 10)

        [Display(Name = "Imp ID pro apl")]
        public int? ImpIdProApl { get; set; } // imp_id_pro_apl

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Imp ID ext pro apl")]
        public string ImpIdExtProApl { get; set; } // imp_id_ext_pro_apl (length: 10)

        [Display(Name = "Imp costo ind apl")]
        public double? ImpCostoIndApl { get; set; } // imp_costo_ind_apl

        [Display(Name = "Imp costo ind apl bse")]
        public double? ImpCostoIndAplBse { get; set; } // imp_costo_ind_apl_bse

        [DataType(DataType.DateTime)]
        [Display(Name = "Imp fec reg")]
        public System.DateTime? ImpFecReg { get; set; } // imp_fec_reg

        [Display(Name = "Imp status")]
        public int? ImpStatus { get; set; } // imp_status

        [Display(Name = "Imp status imp")]
        public int? ImpStatusImp { get; set; } // imp_status_imp
    }

}
// </auto-generated>
