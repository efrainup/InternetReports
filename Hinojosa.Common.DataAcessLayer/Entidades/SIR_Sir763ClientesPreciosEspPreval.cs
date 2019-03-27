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

    // SIR_763_CLIENTES_PRECIOS_ESP_PREVAL
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir763ClientesPreciosEspPreval
    {
        [Required]
        [Display(Name = "N ID cli precios esp 763")]
        public int NIdCliPreciosEsp763 { get; set; } // nIdCliPreciosEsp763 (Primary key)

        [Display(Name = "N ID cliente")]
        public int? NIdCliente { get; set; } // nIdCliente

        [Display(Name = "N monto")]
        public decimal? NMonto { get; set; } // nMonto

        [Display(Name = "N ID prevalidador 155")]
        public int? NIdPrevalidador155 { get; set; } // nIdPrevalidador155

        [Display(Name = "N monto reval")]
        public decimal? NMontoReval { get; set; } // nMontoReval

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir155Prevalidadore pointed by [SIR_763_CLIENTES_PRECIOS_ESP_PREVAL].([NIdPrevalidador155]) (FK_SIR_763_CLIENTES_PRECIOS_ESP_PREVAL_SIR_155_PREVALIDADORES)
        /// </summary>
        public virtual SIR_Sir155Prevalidadore SIR_Sir155Prevalidadore { get; set; } // FK_SIR_763_CLIENTES_PRECIOS_ESP_PREVAL_SIR_155_PREVALIDADORES
    }

}
// </auto-generated>