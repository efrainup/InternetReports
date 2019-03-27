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

    // SIR_750_INDICE_VALOR
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir750IndiceValor
    {
        [Required]
        [Display(Name = "N ID indice valor 750")]
        public int NIdIndiceValor750 { get; set; } // nIdIndiceValor750 (Primary key)

        [Required]
        [Display(Name = "N ID rel bov val 749")]
        public int NIdRelBovVal749 { get; set; } // nIdRelBovVal749

        [Required]
        [Display(Name = "N ID indice boveda 598")]
        public int NIdIndiceBoveda598 { get; set; } // nIdIndiceBoveda598

        [Required]
        [Display(Name = "N ID cat valor ind 751")]
        public int NIdCatValorInd751 { get; set; } // nIdCatValorInd751

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir598IndicesBoveda pointed by [SIR_750_INDICE_VALOR].([NIdIndiceBoveda598]) (FK_SIR_750_INDICE_VALOR_SIR_598_INDICES_BOVEDAS)
        /// </summary>
        public virtual SIR_Sir598IndicesBoveda SIR_Sir598IndicesBoveda { get; set; } // FK_SIR_750_INDICE_VALOR_SIR_598_INDICES_BOVEDAS

        /// <summary>
        /// Parent SIR_Sir749RelacionBovedaIndice pointed by [SIR_750_INDICE_VALOR].([NIdRelBovVal749]) (FK_SIR_750_INDICE_VALOR_SIR_749_RELACION_BOVEDA_INDICE)
        /// </summary>
        public virtual SIR_Sir749RelacionBovedaIndice SIR_Sir749RelacionBovedaIndice { get; set; } // FK_SIR_750_INDICE_VALOR_SIR_749_RELACION_BOVEDA_INDICE

        /// <summary>
        /// Parent SIR_Sir751CatalogoValoresBoveda pointed by [SIR_750_INDICE_VALOR].([NIdCatValorInd751]) (FK_SIR_750_INDICE_VALOR_SIR_751_CATALOGO_VALORES_BOVEDAS)
        /// </summary>
        public virtual SIR_Sir751CatalogoValoresBoveda SIR_Sir751CatalogoValoresBoveda { get; set; } // FK_SIR_750_INDICE_VALOR_SIR_751_CATALOGO_VALORES_BOVEDAS
    }

}
// </auto-generated>
