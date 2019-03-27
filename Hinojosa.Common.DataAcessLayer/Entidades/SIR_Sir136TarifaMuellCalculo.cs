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

    // SIR_136_TARIFA_MUELL_CALCULO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir136TarifaMuellCalculo
    {
        [Required]
        [Display(Name = "N ID tar mue cal 136")]
        public int NIdTarMueCal136 { get; set; } // nIdTarMueCal136 (Primary key)

        [Required]
        [Display(Name = "D fecha entrada")]
        public System.DateTime DFechaEntrada { get; set; } // dFechaEntrada

        [Display(Name = "D fecha pago")]
        public System.DateTime? DFechaPago { get; set; } // dFechaPago

        [Display(Name = "N peso")]
        public decimal? NPeso { get; set; } // nPeso

        [Required]
        [Display(Name = "N ID referencia 60")]
        public int NIdReferencia60 { get; set; } // nIdReferencia60

        [Required]
        [Display(Name = "N ID terminal")]
        public int NIdTerminal { get; set; } // nIdTerminal

        [Display(Name = "N recargos")]
        public decimal? NRecargos { get; set; } // nRecargos

        [Display(Name = "N iva")]
        public decimal? NIva { get; set; } // nIVA

        [Required]
        [Display(Name = "N subtotal")]
        public decimal NSubtotal { get; set; } // nSubtotal

        [Required]
        [Display(Name = "N total")]
        public decimal NTotal { get; set; } // nTotal

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Display(Name = "N dias libres")]
        public short? NDiasLibres { get; set; } // nDiasLibres

        [Display(Name = "N dias libres recargo")]
        public short? NDiasLibresRecargo { get; set; } // nDiasLibresRecargo

        [Display(Name = "N dias transcurridos")]
        public short? NDiasTranscurridos { get; set; } // nDiasTranscurridos

        [Display(Name = "N dias recargos")]
        public short? NDiasRecargos { get; set; } // nDiasRecargos

        [Required]
        [Display(Name = "B aplica muellaje")]
        public bool BAplicaMuellaje { get; set; } // bAplicaMuellaje

        [Display(Name = "N unidad cobro")]
        public int? NUnidadCobro { get; set; } // nUnidadCobro

        [Required]
        [Display(Name = "N tipo tarifa")]
        public byte NTipoTarifa { get; set; } // nTipoTarifa

        [Required]
        [Display(Name = "B aplica carga suelta")]
        public bool BAplicaCargaSuelta { get; set; } // bAplicaCargaSuelta

        [Display(Name = "N tarifa total recargos")]
        public decimal? NTarifaTotalRecargos { get; set; } // nTarifaTotalRecargos

        [Display(Name = "N recargo diario")]
        public decimal? NRecargoDiario { get; set; } // nRecargoDiario

        [Display(Name = "N ID tipo merc 80")]
        public int? NIdTipoMerc80 { get; set; } // nIdTipoMerc80

        [Display(Name = "N ID solicitud 120")]
        public int? NIdSolicitud120 { get; set; } // nIdSolicitud120

        [Display(Name = "N descuento")]
        public decimal? NDescuento { get; set; } // nDescuento

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir137TarifaMuellCalcDet where [SIR_137_TARIFA_MUELL_CALC_DET].[nIdTarMueCal136] point to this entity (FK_SIR_137_TARIFA_MUELL_CALC_DET_SIR_136_TARIFA_MUELL_CALCULO)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir137TarifaMuellCalcDet> SIR_Sir137TarifaMuellCalcDet { get; set; } // SIR_137_TARIFA_MUELL_CALC_DET.FK_SIR_137_TARIFA_MUELL_CALC_DET_SIR_136_TARIFA_MUELL_CALCULO

        // Foreign keys

        /// <summary>
        /// Parent CatProv pointed by [SIR_136_TARIFA_MUELL_CALCULO].([NIdTerminal]) (FK_SIR_136_TARIFA_MUELL_CALCULO_cat_prov)
        /// </summary>
        public virtual CatProv CatProv { get; set; } // FK_SIR_136_TARIFA_MUELL_CALCULO_cat_prov

        /// <summary>
        /// Parent CatUsr pointed by [SIR_136_TARIFA_MUELL_CALCULO].([NIdUsuarioEd]) (FK_SIR_136_TARIFA_MUELL_CALCULO_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_136_TARIFA_MUELL_CALCULO_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir120SolicitudCheque pointed by [SIR_136_TARIFA_MUELL_CALCULO].([NIdSolicitud120]) (FK_SIR_136_TARIFA_MUELL_CALCULO_SIR_120_SOLICITUD_CHEQUES)
        /// </summary>
        public virtual SIR_Sir120SolicitudCheque SIR_Sir120SolicitudCheque { get; set; } // FK_SIR_136_TARIFA_MUELL_CALCULO_SIR_120_SOLICITUD_CHEQUES

        /// <summary>
        /// Parent SIR_Sir60Referencia pointed by [SIR_136_TARIFA_MUELL_CALCULO].([NIdReferencia60]) (FK_SIR_136_TARIFA_MUELL_CALCULO_SIR_60_REFERENCIAS)
        /// </summary>
        public virtual SIR_Sir60Referencia SIR_Sir60Referencia { get; set; } // FK_SIR_136_TARIFA_MUELL_CALCULO_SIR_60_REFERENCIAS

        /// <summary>
        /// Parent SIR_Sir80TiposMercancia pointed by [SIR_136_TARIFA_MUELL_CALCULO].([NIdTipoMerc80]) (FK_SIR_136_TARIFA_MUELL_CALCULO_SIR_80_TIPOS_MERCANCIA)
        /// </summary>
        public virtual SIR_Sir80TiposMercancia SIR_Sir80TiposMercancia { get; set; } // FK_SIR_136_TARIFA_MUELL_CALCULO_SIR_80_TIPOS_MERCANCIA

        public SIR_Sir136TarifaMuellCalculo()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            BAplicaMuellaje = false;
            NTipoTarifa = 1;
            BAplicaCargaSuelta = false;
            SIR_Sir137TarifaMuellCalcDet = new System.Collections.Generic.List<SIR_Sir137TarifaMuellCalcDet>();
        }
    }

}
// </auto-generated>
