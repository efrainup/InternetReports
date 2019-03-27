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

    // SIR_637_CLIENTES_PREVIOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir637ClientesPrevio
    {
        [Required]
        [Display(Name = "N ID cliente previo 637")]
        public int NIdClientePrevio637 { get; set; } // nIdClientePrevio637 (Primary key)

        [Display(Name = "N ID cliente")]
        public int? NIdCliente { get; set; } // nIdCliente

        [Display(Name = "N ID clie 07")]
        public int? NIdClie07 { get; set; } // nIdClie07

        [Display(Name = "N ID tipo docto 62")]
        public int? NIdTipoDocto62 { get; set; } // nIdTipoDocto62

        [Display(Name = "N ID tipo previo 132")]
        public int? NIdTipoPrevio132 { get; set; } // nIdTipoPrevio132

        [Display(Name = "N prioridad")]
        public int? NPrioridad { get; set; } // nPrioridad

        // Foreign keys

        /// <summary>
        /// Parent Admin_Adminc07Cliente pointed by [SIR_637_CLIENTES_PREVIOS].([NIdClie07]) (FK_SIR_637_CLIENTES_PREVIOS_REF_ADMINC_07_CLIENTES)
        /// </summary>
        public virtual Admin_Adminc07Cliente Admin_Adminc07Cliente { get; set; } // FK_SIR_637_CLIENTES_PREVIOS_REF_ADMINC_07_CLIENTES

        /// <summary>
        /// Parent SIR_Sir132TipoPrevio pointed by [SIR_637_CLIENTES_PREVIOS].([NIdTipoPrevio132]) (FK_SIR_637_CLIENTES_PREVIOS_SIR_132_TIPO_PREVIO)
        /// </summary>
        public virtual SIR_Sir132TipoPrevio SIR_Sir132TipoPrevio { get; set; } // FK_SIR_637_CLIENTES_PREVIOS_SIR_132_TIPO_PREVIO

        /// <summary>
        /// Parent SIR_Sir62TiposDocumento pointed by [SIR_637_CLIENTES_PREVIOS].([NIdTipoDocto62]) (FK_SIR_637_CLIENTES_PREVIOS_SIR_62_TIPOS_DOCUMENTOS)
        /// </summary>
        public virtual SIR_Sir62TiposDocumento SIR_Sir62TiposDocumento { get; set; } // FK_SIR_637_CLIENTES_PREVIOS_SIR_62_TIPOS_DOCUMENTOS
    }

}
// </auto-generated>
