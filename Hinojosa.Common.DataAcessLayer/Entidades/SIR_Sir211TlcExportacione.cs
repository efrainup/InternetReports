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

    // SIR_211_TLC_EXPORTACIONES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir211TlcExportacione
    {
        [Required]
        [Display(Name = "N ID tlce xp 211")]
        public int NIdTlcExp211 { get; set; } // nIdTLCExp211 (Primary key)

        [Required]
        [Display(Name = "N ID pedimento 149")]
        public int NIdPedimento149 { get; set; } // nIdPedimento149

        [Required]
        [Display(Name = "N articulo")]
        public int NArticulo { get; set; } // nArticulo

        [Display(Name = "D impuesto")]
        public System.DateTime? DImpuesto { get; set; } // dImpuesto

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir213PruebasSuficiente where [SIR_213_PRUEBAS_SUFICIENTES].[nIdTLCExp211] point to this entity (FK_SIR_213_PRUEBAS_SUFICIENTES_SIR_211_TLC_EXPORTACIONES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir213PruebasSuficiente> SIR_Sir213PruebasSuficiente { get; set; } // SIR_213_PRUEBAS_SUFICIENTES.FK_SIR_213_PRUEBAS_SUFICIENTES_SIR_211_TLC_EXPORTACIONES
        /// <summary>
        /// Child SIR_Sir215FraccionesTlcExpo where [SIR_215_FRACCIONES_TLC_EXPO].[nIdTLCExp211] point to this entity (FK_SIR_215_FRACCIONES_TLC_EXPO_SIR_211_TLC_EXPORTACIONES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir215FraccionesTlcExpo> SIR_Sir215FraccionesTlcExpo { get; set; } // SIR_215_FRACCIONES_TLC_EXPO.FK_SIR_215_FRACCIONES_TLC_EXPO_SIR_211_TLC_EXPORTACIONES

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_211_TLC_EXPORTACIONES].([NIdUsuarioEd]) (FK_SIR_211_TLC_EXPORTACIONES_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_211_TLC_EXPORTACIONES_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir149Pedimento pointed by [SIR_211_TLC_EXPORTACIONES].([NIdPedimento149]) (FK_SIR_211_TLC_EXPORTACIONES_SIR_149_PEDIMENTO)
        /// </summary>
        public virtual SIR_Sir149Pedimento SIR_Sir149Pedimento { get; set; } // FK_SIR_211_TLC_EXPORTACIONES_SIR_149_PEDIMENTO

        public SIR_Sir211TlcExportacione()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            SIR_Sir213PruebasSuficiente = new System.Collections.Generic.List<SIR_Sir213PruebasSuficiente>();
            SIR_Sir215FraccionesTlcExpo = new System.Collections.Generic.List<SIR_Sir215FraccionesTlcExpo>();
        }
    }

}
// </auto-generated>
