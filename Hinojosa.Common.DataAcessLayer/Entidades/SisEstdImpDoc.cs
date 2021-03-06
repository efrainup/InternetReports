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

    // sis_estd_imp_docs
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisEstdImpDoc
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; } // id (Primary key)

        [Display(Name = "Id cmp")]
        public int? IdCmp { get; set; } // id_cmp

        [Display(Name = "Id suc")]
        public int? IdSuc { get; set; } // id_suc

        [Display(Name = "Id tip doc")]
        public int? IdTipDoc { get; set; } // id_tip_doc

        [Display(Name = "Lote")]
        public double? Lote { get; set; } // lote

        [Display(Name = "Cant estimada")]
        public double? CantEstimada { get; set; } // cant_estimada

        [Display(Name = "Cant real")]
        public double? CantReal { get; set; } // cant_real

        [Display(Name = "Ptj asig")]
        public double? PtjAsig { get; set; } // ptj_asig

        [Display(Name = "Ptj rel")]
        public double? PtjRel { get; set; } // ptj_rel

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Tiempo")]
        public string Tiempo { get; set; } // tiempo (length: 20)

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Prom fac estimado")]
        public string PromFacEstimado { get; set; } // prom_fac_estimado (length: 20)

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Prom fac real")]
        public string PromFacReal { get; set; } // prom_fac_real (length: 20)

        [Display(Name = "Tipo")]
        public int? Tipo { get; set; } // tipo

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime? FecReg { get; set; } // fec_reg
    }

}
// </auto-generated>
