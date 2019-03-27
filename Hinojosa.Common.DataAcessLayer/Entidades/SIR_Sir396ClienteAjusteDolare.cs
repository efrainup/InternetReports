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

    // The table 'SIR_396_CLIENTE_AJUSTE_DOLARES' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    // SIR_396_CLIENTE_AJUSTE_DOLARES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir396ClienteAjusteDolare
    {
        [Display(Name = "N ID cliente")]
        public int? NIdCliente { get; set; } // nIdCliente

        [Display(Name = "N ID clie 07")]
        public int? NIdClie07 { get; set; } // nIdClie07

        // Foreign keys

        /// <summary>
        /// Parent Admin_Adminc07Cliente pointed by [SIR_396_CLIENTE_AJUSTE_DOLARES].([NIdClie07]) (FK_SIR_396_CLIENTE_AJUSTE_DOLARES_ADMINC_07_CLIENTES)
        /// </summary>
        public virtual Admin_Adminc07Cliente Admin_Adminc07Cliente { get; set; } // FK_SIR_396_CLIENTE_AJUSTE_DOLARES_ADMINC_07_CLIENTES

        /// <summary>
        /// Parent CatCliente pointed by [SIR_396_CLIENTE_AJUSTE_DOLARES].([NIdCliente]) (FK_SIR_396_CLIENTE_AJUSTE_DOLARES_CAT_CLIENTES)
        /// </summary>
        public virtual CatCliente CatCliente { get; set; } // FK_SIR_396_CLIENTE_AJUSTE_DOLARES_CAT_CLIENTES
    }

}
// </auto-generated>
