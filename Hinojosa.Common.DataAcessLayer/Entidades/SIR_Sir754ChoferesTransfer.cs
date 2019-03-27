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

    // SIR_754_CHOFERES_TRANSFER
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir754ChoferesTransfer
    {
        [Required]
        [Display(Name = "N ID chofer transfer 754")]
        public int NIdChoferTransfer754 { get; set; } // nIdChoferTransfer754 (Primary key)

        [Required]
        [Display(Name = "N ID transportista")]
        public int NIdTransportista { get; set; } // nIdTransportista

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S nombre")]
        public string SNombre { get; set; } // sNombre (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S imei")]
        public string SImei { get; set; } // sIMEI (length: 50)

        [Display(Name = "S key gcm")]
        public string SKeyGcm { get; set; } // sKeyGCM

        // Foreign keys

        /// <summary>
        /// Parent CatProv pointed by [SIR_754_CHOFERES_TRANSFER].([NIdTransportista]) (FK_SIR_754_CHOFERES_TRANSFER_cat_prov)
        /// </summary>
        public virtual CatProv CatProv { get; set; } // FK_SIR_754_CHOFERES_TRANSFER_cat_prov
    }

}
// </auto-generated>