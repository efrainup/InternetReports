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

    // SIR_265_TIPOS_PRODUCTOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir265TiposProducto
    {
        [Required]
        [Display(Name = "N ID tipo prod 265")]
        public int NIdTipoProd265 { get; set; } // nIdTipoProd265 (Primary key)

        [Required]
        [Display(Name = "N clave")]
        public byte NClave { get; set; } // nClave

        [Required(AllowEmptyStrings = true)]
        [MaxLength(75)]
        [StringLength(75)]
        [Display(Name = "S tipo producto")]
        public string STipoProducto { get; set; } // sTipoProducto (length: 75)

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir277FraccionesProfepa where [SIR_277_FRACCIONES_PROFEPA].[nTipoProd265] point to this entity (FK_SIR_277_FRACCIONES_PROFEPA_SIR_265_TIPOS_PRODUCTOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir277FraccionesProfepa> SIR_Sir277FraccionesProfepa { get; set; } // SIR_277_FRACCIONES_PROFEPA.FK_SIR_277_FRACCIONES_PROFEPA_SIR_265_TIPOS_PRODUCTOS

        public SIR_Sir265TiposProducto()
        {
            SIR_Sir277FraccionesProfepa = new System.Collections.Generic.List<SIR_Sir277FraccionesProfepa>();
        }
    }

}
// </auto-generated>
