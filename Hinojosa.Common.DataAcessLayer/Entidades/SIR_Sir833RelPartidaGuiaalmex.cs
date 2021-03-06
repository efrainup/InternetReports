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

    // SIR_833_REL_PARTIDA_GUIAALMEX
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir833RelPartidaGuiaalmex
    {
        [Required]
        [Display(Name = "N ID guia 832")]
        public int NIdGuia832 { get; set; } // nIdGuia832 (Primary key)

        [Required]
        [Display(Name = "N ID factura partida 11")]
        public int NIdFacturaPartida11 { get; set; } // nIdFacturaPartida11 (Primary key)

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha")]
        public System.DateTime? DFecha { get; set; } // dFecha

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir11FacturasPartida pointed by [SIR_833_REL_PARTIDA_GUIAALMEX].([NIdFacturaPartida11]) (FK_SIR_833_REL_PARTIDA_GUIAALMEX_SIR_11_FACTURAS_PARTIDAS)
        /// </summary>
        public virtual SIR_Sir11FacturasPartida SIR_Sir11FacturasPartida { get; set; } // FK_SIR_833_REL_PARTIDA_GUIAALMEX_SIR_11_FACTURAS_PARTIDAS

        /// <summary>
        /// Parent SIR_Sir832GuiasAlmex pointed by [SIR_833_REL_PARTIDA_GUIAALMEX].([NIdGuia832]) (FK_SIR_833_REL_PARTIDA_GUIAALMEX_SIR_832_GUIAS_ALMEX)
        /// </summary>
        public virtual SIR_Sir832GuiasAlmex SIR_Sir832GuiasAlmex { get; set; } // FK_SIR_833_REL_PARTIDA_GUIAALMEX_SIR_832_GUIAS_ALMEX
    }

}
// </auto-generated>
