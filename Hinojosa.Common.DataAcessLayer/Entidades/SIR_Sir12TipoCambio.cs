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

    // SIR_12_TIPO_CAMBIO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir12TipoCambio
    {
        [Required]
        [Display(Name = "N ID tipo cambio 12")]
        public int NIdTipoCambio12 { get; set; } // nIdTipoCambio12 (Primary key)

        [Required]
        [Display(Name = "D fecha")]
        public System.DateTime DFecha { get; set; } // dFecha

        [Required]
        [Display(Name = "N valor")]
        public decimal NValor { get; set; } // nValor

        [Display(Name = "N ID ver 09")]
        public int? NIdVer09 { get; set; } // nIdVer09

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir149Pedimento where [SIR_149_PEDIMENTO].[nIdTipoCambio12] point to this entity (FK_SIR_149_PEDIMENTO_SIR_12_TIPO_CAMBIO)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir149Pedimento> SIR_Sir149Pedimento { get; set; } // SIR_149_PEDIMENTO.FK_SIR_149_PEDIMENTO_SIR_12_TIPO_CAMBIO

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_12_TIPO_CAMBIO].([NIdUsuarioEd]) (FK_SIR_12_TIPO_CAMBIO_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_12_TIPO_CAMBIO_cat_usr_ed

        public SIR_Sir12TipoCambio()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            SIR_Sir149Pedimento = new System.Collections.Generic.List<SIR_Sir149Pedimento>();
        }
    }

}
// </auto-generated>