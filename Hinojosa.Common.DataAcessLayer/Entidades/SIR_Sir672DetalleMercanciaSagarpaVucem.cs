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

    // The table 'SIR_672_DETALLE_MERCANCIA_SAGARPA_VUCEM' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    // SIR_672_DETALLE_MERCANCIA_SAGARPA_VUCEM
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir672DetalleMercanciaSagarpaVucem
    {
        [Display(Name = "N ID vida silvestre 671")]
        public int? NIdVidaSilvestre671 { get; set; } // nIdVidaSilvestre671

        [Display(Name = "N ID mercancia 627")]
        public int? NIdMercancia627 { get; set; } // nIdMercancia627

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir627MercanciasSagarpa pointed by [SIR_672_DETALLE_MERCANCIA_SAGARPA_VUCEM].([NIdMercancia627]) (FK_SIR_672_DETALLE_MERCANCIA_SAGARPA_VUCEM_SIR_627_MERCANCIAS_SAGARPA)
        /// </summary>
        public virtual SIR_Sir627MercanciasSagarpa SIR_Sir627MercanciasSagarpa { get; set; } // FK_SIR_672_DETALLE_MERCANCIA_SAGARPA_VUCEM_SIR_627_MERCANCIAS_SAGARPA

        /// <summary>
        /// Parent SIR_Sir671VidaSilvestreSagarpaVucem pointed by [SIR_672_DETALLE_MERCANCIA_SAGARPA_VUCEM].([NIdVidaSilvestre671]) (FK_SIR_672_DETALLE_MERCANCIA_SAGARPA_VUCEM_SIR_671_VIDA_SILVESTRE_SAGARPA_VUCEM)
        /// </summary>
        public virtual SIR_Sir671VidaSilvestreSagarpaVucem SIR_Sir671VidaSilvestreSagarpaVucem { get; set; } // FK_SIR_672_DETALLE_MERCANCIA_SAGARPA_VUCEM_SIR_671_VIDA_SILVESTRE_SAGARPA_VUCEM
    }

}
// </auto-generated>
