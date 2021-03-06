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

    // SIR_65_VALORES_INDICES_DOCTOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir65ValoresIndicesDocto
    {
        [Required]
        [Display(Name = "N ID valor indice 65")]
        public int NIdValorIndice65 { get; set; } // nIdValorIndice65 (Primary key)

        [Required]
        [Display(Name = "N ID indice docto 64")]
        public int NIdIndiceDocto64 { get; set; } // nIdIndiceDocto64

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "S valor")]
        public string SValor { get; set; } // sValor (length: 40)

        [Required]
        [Display(Name = "N ID documento 63")]
        public int NIdDocumento63 { get; set; } // nIdDocumento63

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir63Documento pointed by [SIR_65_VALORES_INDICES_DOCTOS].([NIdDocumento63]) (FK_SIR_65_VALORES_INDICES_DOCTOS_SIR_63_DOCUMENTOS)
        /// </summary>
        public virtual SIR_Sir63Documento SIR_Sir63Documento { get; set; } // FK_SIR_65_VALORES_INDICES_DOCTOS_SIR_63_DOCUMENTOS

        /// <summary>
        /// Parent SIR_Sir64IndicesDocumento pointed by [SIR_65_VALORES_INDICES_DOCTOS].([NIdIndiceDocto64]) (FK_SIR_65_VALORES_INDICES_DOCTOS_SIR_64_INDICES_DOCUMENTOS)
        /// </summary>
        public virtual SIR_Sir64IndicesDocumento SIR_Sir64IndicesDocumento { get; set; } // FK_SIR_65_VALORES_INDICES_DOCTOS_SIR_64_INDICES_DOCUMENTOS
    }

}
// </auto-generated>
