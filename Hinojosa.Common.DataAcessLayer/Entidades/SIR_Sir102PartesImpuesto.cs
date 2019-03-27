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

    // SIR_102_PARTES_IMPUESTOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir102PartesImpuesto
    {
        [Required]
        [Display(Name = "N ID parte impuesto 102")]
        public int NIdParteImpuesto102 { get; set; } // nIdParteImpuesto102 (Primary key)

        [Required]
        [Display(Name = "N ID parte 99")]
        public int NIdParte99 { get; set; } // nIdParte99

        [Required]
        [Display(Name = "N ID tipos imp 30")]
        public int NIdTiposImp30 { get; set; } // nIdTiposImp30

        [Required]
        [Display(Name = "N valor tasa")]
        public decimal NValorTasa { get; set; } // nValorTasa

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Display(Name = "N ID forma pago 32")]
        public int? NIdFormaPago32 { get; set; } // nIdFormaPago32

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_102_PARTES_IMPUESTOS].([NIdUsuarioEd]) (FK_SIR_102_PARTES_IMPUESTOS_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_102_PARTES_IMPUESTOS_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir30TiposImpuesto pointed by [SIR_102_PARTES_IMPUESTOS].([NIdTiposImp30]) (FK_SIR_102_PARTES_IMPUESTOS_SIR_30_TIPOS_IMPUESTOS)
        /// </summary>
        public virtual SIR_Sir30TiposImpuesto SIR_Sir30TiposImpuesto { get; set; } // FK_SIR_102_PARTES_IMPUESTOS_SIR_30_TIPOS_IMPUESTOS

        /// <summary>
        /// Parent SIR_Sir32FormasPago pointed by [SIR_102_PARTES_IMPUESTOS].([NIdFormaPago32]) (FK_SIR_102_PARTES_IMPUESTOS_SIR_32_FORMAS_PAGO)
        /// </summary>
        public virtual SIR_Sir32FormasPago SIR_Sir32FormasPago { get; set; } // FK_SIR_102_PARTES_IMPUESTOS_SIR_32_FORMAS_PAGO

        /// <summary>
        /// Parent SIR_Sir99Parte pointed by [SIR_102_PARTES_IMPUESTOS].([NIdParte99]) (FK_SIR_102_PARTES_IMPUESTOS_SIR_99_PARTES)
        /// </summary>
        public virtual SIR_Sir99Parte SIR_Sir99Parte { get; set; } // FK_SIR_102_PARTES_IMPUESTOS_SIR_99_PARTES

        public SIR_Sir102PartesImpuesto()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
        }
    }

}
// </auto-generated>