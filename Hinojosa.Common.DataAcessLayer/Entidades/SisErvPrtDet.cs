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

    // sis_erv_prt_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisErvPrtDet
    {
        [Required]
        [Display(Name = "Id enc")]
        public short IdEnc { get; set; } // id_enc (Primary key)

        [Required]
        [Display(Name = "Id det")]
        public short IdDet { get; set; } // id_det (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Prt nom")]
        public string PrtNom { get; set; } // prt_nom (length: 20)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "Prt txt")]
        public string PrtTxt { get; set; } // prt_txt (length: 500)

        [Required]
        [Display(Name = "Prt tip")]
        public byte PrtTip { get; set; } // prt_tip

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "Prt def")]
        public string PrtDef { get; set; } // prt_def (length: 500)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Prt val")]
        public string PrtVal { get; set; } // prt_val (length: 10)

        // Foreign keys

        /// <summary>
        /// Parent SisErvPrtEnc pointed by [sis_erv_prt_det].([IdEnc]) (FK__sis_erv_p__id_en__0E4998EE)
        /// </summary>
        public virtual SisErvPrtEnc SisErvPrtEnc { get; set; } // FK__sis_erv_p__id_en__0E4998EE
    }

}
// </auto-generated>