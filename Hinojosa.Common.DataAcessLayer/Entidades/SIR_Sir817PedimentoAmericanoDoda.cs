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

    // SIR_817_PEDIMENTO_AMERICANO_DODA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir817PedimentoAmericanoDoda
    {
        [Required]
        [Display(Name = "N ID doda 809")]
        public int NIdDoda809 { get; set; } // nIdDODA809 (Primary key)

        [Display(Name = "N tipo pedimento")]
        public int? NTipoPedimento { get; set; } // nTipoPedimento

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S itn")]
        public string SItn { get; set; } // sITN (Primary key) (length: 100)

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir809Doda pointed by [SIR_817_PEDIMENTO_AMERICANO_DODA].([NIdDoda809]) (FK_SIR_812_DODA_CONTENEDORES_CANDADO_SIR_809_DODA)
        /// </summary>
        public virtual SIR_Sir809Doda SIR_Sir809Doda { get; set; } // FK_SIR_812_DODA_CONTENEDORES_CANDADO_SIR_809_DODA
    }

}
// </auto-generated>