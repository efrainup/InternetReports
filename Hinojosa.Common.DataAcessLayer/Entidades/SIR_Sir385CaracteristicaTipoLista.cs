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

    // SIR_385_CARACTERISTICA_TIPO_LISTA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir385CaracteristicaTipoLista
    {
        [Required]
        [Display(Name = "N ID carac tipo list 385")]
        public int NIdCaracTipoList385 { get; set; } // nIdCaracTipoList385 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "S nom elemento")]
        public string SNomElemento { get; set; } // sNomElemento (length: 250)

        [Required]
        [Display(Name = "N ID carac 130")]
        public int NIdCarac130 { get; set; } // nIdCarac130

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir130Caracteristica pointed by [SIR_385_CARACTERISTICA_TIPO_LISTA].([NIdCarac130]) (FK_SIR_385_CARACTERISTICA_TIPO_LISTA_SIR_130_CARACTERISTICAS)
        /// </summary>
        public virtual SIR_Sir130Caracteristica SIR_Sir130Caracteristica { get; set; } // FK_SIR_385_CARACTERISTICA_TIPO_LISTA_SIR_130_CARACTERISTICAS
    }

}
// </auto-generated>