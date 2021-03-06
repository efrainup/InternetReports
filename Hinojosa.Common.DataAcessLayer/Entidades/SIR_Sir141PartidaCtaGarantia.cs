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

    // SIR_141_PARTIDA_CTA_GARANTIA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir141PartidaCtaGarantia
    {
        [Required]
        [Display(Name = "N ID cta garantia 141")]
        public int NIdCtaGarantia141 { get; set; } // nIdCtaGarantia141 (Primary key)

        [Required]
        [Display(Name = "N ID emi cta 33")]
        public int NIdEmiCta33 { get; set; } // nIdEmiCta33

        [Required]
        [Display(Name = "N numero cuenta")]
        public decimal NNumeroCuenta { get; set; } // nNumeroCuenta

        [Required]
        [Display(Name = "N cantidad titulos")]
        public decimal NCantidadTitulos { get; set; } // nCantidadTitulos

        [Required]
        [Display(Name = "N folio constancia")]
        public decimal NFolioConstancia { get; set; } // nFolioConstancia

        [Required]
        [Display(Name = "D fecha constancia")]
        public System.DateTime DFechaConstancia { get; set; } // dFechaConstancia

        [Required]
        [Display(Name = "N ID tipo garantia 77")]
        public int NIdTipoGarantia77 { get; set; } // nIdTipoGarantia77

        [Required]
        [Display(Name = "N valor unit titulo")]
        public decimal NValorUnitTitulo { get; set; } // nValorUnitTitulo

        [Required]
        [Display(Name = "N cantidad um")]
        public decimal NCantidadUm { get; set; } // nCantidadUM

        [Required]
        [Display(Name = "N total garantia")]
        public decimal NTotalGarantia { get; set; } // nTotalGarantia

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir11FacturasPartida where [SIR_11_FACTURAS_PARTIDAS].[nIdCtaGarantia141] point to this entity (FK_SIR_11_FACTURAS_PARTIDAS_SIR_141_PARTIDA_CTA_GARANTIA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir11FacturasPartida> SIR_Sir11FacturasPartida { get; set; } // SIR_11_FACTURAS_PARTIDAS.FK_SIR_11_FACTURAS_PARTIDAS_SIR_141_PARTIDA_CTA_GARANTIA

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_141_PARTIDA_CTA_GARANTIA].([NIdUsuarioEd]) (FK_SIR_141_PARTIDA_CTA_GARANTIA_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_141_PARTIDA_CTA_GARANTIA_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir33EmisorasCtasAduanera pointed by [SIR_141_PARTIDA_CTA_GARANTIA].([NIdEmiCta33]) (FK_SIR_141_PARTIDA_CTA_GARANTIA_SIR_33_EMISORAS_CTAS_ADUANERAS)
        /// </summary>
        public virtual SIR_Sir33EmisorasCtasAduanera SIR_Sir33EmisorasCtasAduanera { get; set; } // FK_SIR_141_PARTIDA_CTA_GARANTIA_SIR_33_EMISORAS_CTAS_ADUANERAS

        /// <summary>
        /// Parent SIR_Sir77TiposGarantia pointed by [SIR_141_PARTIDA_CTA_GARANTIA].([NIdTipoGarantia77]) (FK_SIR_141_PARTIDA_CTA_GARANTIA_SIR_77_TIPOS_GARANTIA)
        /// </summary>
        public virtual SIR_Sir77TiposGarantia SIR_Sir77TiposGarantia { get; set; } // FK_SIR_141_PARTIDA_CTA_GARANTIA_SIR_77_TIPOS_GARANTIA

        public SIR_Sir141PartidaCtaGarantia()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            SIR_Sir11FacturasPartida = new System.Collections.Generic.List<SIR_Sir11FacturasPartida>();
        }
    }

}
// </auto-generated>
