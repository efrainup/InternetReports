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

    // SIR_699_GASTOSCOMP_REF
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir699GastoscompRef
    {
        [Required]
        [Display(Name = "N ID gastos comp 699")]
        public int NIdGastosComp699 { get; set; } // nIdGastosComp699 (Primary key)

        [Required]
        [Display(Name = "N ID referencia 60")]
        public int NIdReferencia60 { get; set; } // nIdReferencia60

        [Required]
        [Display(Name = "N ID catalogo servicio 642")]
        public int NIdCatalogoServicio642 { get; set; } // nIdCatalogoServicio642

        [Required]
        [Display(Name = "N importe")]
        public decimal NImporte { get; set; } // nImporte

        [Required]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Display(Name = "N ID usuario")]
        public int? NIdUsuario { get; set; } // nIdUsuario

        [Display(Name = "N ID usuario edicion")]
        public int? NIdUsuarioEdicion { get; set; } // nIdUsuarioEdicion

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir60Referencia pointed by [SIR_699_GASTOSCOMP_REF].([NIdReferencia60]) (FK_SIR_699_GASTOSCOMP_REF_SIR_60_REFERENCIAS)
        /// </summary>
        public virtual SIR_Sir60Referencia SIR_Sir60Referencia { get; set; } // FK_SIR_699_GASTOSCOMP_REF_SIR_60_REFERENCIAS

        /// <summary>
        /// Parent SIR_Sir642CatalogoServicio pointed by [SIR_699_GASTOSCOMP_REF].([NIdCatalogoServicio642]) (FK_SIR_699_GASTOSCOMP_REF_SIR_642_CATALOGO_SERVICIOS)
        /// </summary>
        public virtual SIR_Sir642CatalogoServicio SIR_Sir642CatalogoServicio { get; set; } // FK_SIR_699_GASTOSCOMP_REF_SIR_642_CATALOGO_SERVICIOS
    }

}
// </auto-generated>