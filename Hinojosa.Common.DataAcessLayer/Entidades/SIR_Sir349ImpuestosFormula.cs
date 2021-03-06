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

    // SIR_349_IMPUESTOS_FORMULAS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir349ImpuestosFormula
    {
        [Required]
        [Display(Name = "N ID imp formula 349")]
        public int NIdImpFormula349 { get; set; } // nIdImpFormula349 (Primary key)

        [Required]
        [Display(Name = "N ID tipos imp 30")]
        public int NIdTiposImp30 { get; set; } // nIdTiposImp30

        [Display(Name = "N ID regula 253")]
        public int? NIdRegula253 { get; set; } // nIdRegula253

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir350BaseGravable where [SIR_350_BASE_GRAVABLE].[nIdImpForm349] point to this entity (FK_SIR_350_BASE_GRAVABLE_SIR_349_IMPUESTOS_FORMULAS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir350BaseGravable> SIR_Sir350BaseGravable { get; set; } // SIR_350_BASE_GRAVABLE.FK_SIR_350_BASE_GRAVABLE_SIR_349_IMPUESTOS_FORMULAS

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir253Regularizacione pointed by [SIR_349_IMPUESTOS_FORMULAS].([NIdRegula253]) (FK_SIR_349_IMPUESTOS_FORMULAS_SIR_253_REGULARIZACIONES)
        /// </summary>
        public virtual SIR_Sir253Regularizacione SIR_Sir253Regularizacione { get; set; } // FK_SIR_349_IMPUESTOS_FORMULAS_SIR_253_REGULARIZACIONES

        /// <summary>
        /// Parent SIR_Sir30TiposImpuesto pointed by [SIR_349_IMPUESTOS_FORMULAS].([NIdTiposImp30]) (FK_SIR_349_IMPUESTOS_FORMULAS_SIR_30_TIPOS_IMPUESTOS)
        /// </summary>
        public virtual SIR_Sir30TiposImpuesto SIR_Sir30TiposImpuesto { get; set; } // FK_SIR_349_IMPUESTOS_FORMULAS_SIR_30_TIPOS_IMPUESTOS

        public SIR_Sir349ImpuestosFormula()
        {
            SIR_Sir350BaseGravable = new System.Collections.Generic.List<SIR_Sir350BaseGravable>();
        }
    }

}
// </auto-generated>
