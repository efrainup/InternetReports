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

    // SIR_220_REMESAS_HISTORICO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir220RemesasHistorico
    {
        [Required]
        [Display(Name = "N ID rem hist 220")]
        public int NIdRemHist220 { get; set; } // nIdRemHist220 (Primary key)

        [Required]
        [Display(Name = "N ID rem 206")]
        public int NIdRem206 { get; set; } // nIdRem206

        [Required]
        [Display(Name = "N num remesa")]
        public int NNumRemesa { get; set; } // nNumRemesa

        [Required(AllowEmptyStrings = true)]
        [MaxLength(7)]
        [StringLength(7)]
        [Display(Name = "S pedimento")]
        public string SPedimento { get; set; } // sPedimento (length: 7)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "S clave docto")]
        public string SClaveDocto { get; set; } // sClaveDocto (length: 2)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(8)]
        [StringLength(8)]
        [Display(Name = "S firma pedimento")]
        public string SFirmaPedimento { get; set; } // sFirmaPedimento (length: 8)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(4)]
        [StringLength(4)]
        [Display(Name = "N patente")]
        public string NPatente { get; set; } // nPatente (length: 4)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S nombre agente")]
        public string SNombreAgente { get; set; } // sNombreAgente (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "S rfca gente")]
        public string SRfcAgente { get; set; } // sRFCAgente (length: 15)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S curpa gente")]
        public string SCurpAgente { get; set; } // sCURPAgente (length: 20)

        [Required]
        [Display(Name = "N cantidad mcia")]
        public decimal NCantidadMcia { get; set; } // nCantidadMcia

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "N num factura")]
        public string NNumFactura { get; set; } // nNumFactura (length: 30)

        [Required]
        [Display(Name = "N valor factura us")]
        public decimal NValorFacturaUs { get; set; } // nValorFacturaUS

        [Required]
        [Display(Name = "N valor factura pesos")]
        public decimal NValorFacturaPesos { get; set; } // nValorFacturaPesos

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S placas")]
        public string SPlacas { get; set; } // sPlacas (length: 20)

        [Required]
        [Display(Name = "N relacion con")]
        public byte NRelacionCon { get; set; } // nRelacionCon

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S nombre mandatario")]
        public string SNombreMandatario { get; set; } // sNombreMandatario (length: 100)

        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "S rfcm andatario")]
        public string SRfcMandatario { get; set; } // sRFCMandatario (length: 15)

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S curpm andatario")]
        public string SCurpMandatario { get; set; } // sCURPMandatario (length: 20)

        [Required]
        [Display(Name = "D fecha impresion")]
        public System.DateTime DFechaImpresion { get; set; } // dFechaImpresion

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S nombre cliente")]
        public string SNombreCliente { get; set; } // sNombreCliente (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "S rfcc liente")]
        public string SRfcCliente { get; set; } // sRFCCliente (length: 15)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "S clave aduana")]
        public string SClaveAduana { get; set; } // sClaveAduana (length: 2)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "S clave seccion")]
        public string SClaveSeccion { get; set; } // sClaveSeccion (length: 1)

        [Required]
        [Display(Name = "N num bultos")]
        public decimal NNumBultos { get; set; } // nNumBultos

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S nombre empleado")]
        public string SNombreEmpleado { get; set; } // sNombreEmpleado (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "S clave recinto")]
        public string SClaveRecinto { get; set; } // sClaveRecinto (length: 40)

        [MaxLength(13)]
        [StringLength(13)]
        [Display(Name = "S num contenedor")]
        public string SNumContenedor { get; set; } // sNumContenedor (length: 13)

        [Display(Name = "N total guias")]
        public int? NTotalGuias { get; set; } // nTotalGuias

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S num guia")]
        public string SNumGuia { get; set; } // sNumGuia (length: 20)

        [Display(Name = "N peso mcia granel")]
        public decimal? NPesoMciaGranel { get; set; } // nPesoMciaGranel

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Required]
        [Display(Name = "B activo")]
        public bool BActivo { get; set; } // bActivo

        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "S transporte")]
        public string STransporte { get; set; } // sTransporte (length: 60)

        [Display(Name = "S observacion")]
        public string SObservacion { get; set; } // sObservacion

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S info carga suelta")]
        public string SInfoCargaSuelta { get; set; } // sInfoCargaSuelta (length: 500)

        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "S num economico")]
        public string SNumEconomico { get; set; } // sNumEconomico (length: 25)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S puerto")]
        public string SPuerto { get; set; } // sPuerto (length: 30)

        [MaxLength(8)]
        [StringLength(8)]
        [Display(Name = "S firma aduana")]
        public string SFirmaAduana { get; set; } // sFirmaAduana (length: 8)

        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "S modelo")]
        public string SModelo { get; set; } // sModelo (length: 25)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S marca")]
        public string SMarca { get; set; } // sMarca (length: 30)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S buque")]
        public string SBuque { get; set; } // sBuque (length: 30)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S viaje")]
        public string SViaje { get; set; } // sViaje (length: 30)

        [Display(Name = "N peso")]
        public decimal? NPeso { get; set; } // nPeso

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S nombre representante")]
        public string SNombreRepresentante { get; set; } // sNombreRepresentante (length: 100)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S rfcr epresentante")]
        public string SRfcRepresentante { get; set; } // sRFCRepresentante (length: 30)

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S origen destino")]
        public string SOrigenDestino { get; set; } // sOrigenDestino (length: 100)

        [Display(Name = "N tipo operacion")]
        public byte? NTipoOperacion { get; set; } // nTipoOperacion

        [Display(Name = "N cantidad umc")]
        public decimal? NCantidadUmc { get; set; } // nCantidadUMC

        [Display(Name = "N total valor factura usd")]
        public decimal? NTotalValorFacturaUsd { get; set; } // nTotalValorFacturaUSD

        [Required]
        [Display(Name = "B con facturas")]
        public bool BConFacturas { get; set; } // bConFacturas

        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "S dimension cont")]
        public string SDimensionCont { get; set; } // sDimensionCont (length: 5)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "S iniciales cont")]
        public string SInicialesCont { get; set; } // sInicialesCont (length: 10)

        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "S categoria cont")]
        public string SCategoriaCont { get; set; } // sCategoriaCont (length: 40)

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S contenedores")]
        public string SContenedores { get; set; } // sContenedores (length: 100)

        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "S clave aduana salida")]
        public string SClaveAduanaSalida { get; set; } // sClaveAduanaSalida (length: 2)

        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "S clave seccion salida")]
        public string SClaveSeccionSalida { get; set; } // sClaveSeccionSalida (length: 1)

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S candados")]
        public string SCandados { get; set; } // sCandados (length: 100)

        [Display(Name = "N semana")]
        public int? NSemana { get; set; } // nSemana

        [Display(Name = "S direccion cliente")]
        public string SDireccionCliente { get; set; } // sDireccionCliente

        [Display(Name = "N tipo cambio")]
        public decimal? NTipoCambio { get; set; } // nTipoCambio

        [Display(Name = "D fecha pago ped")]
        public System.DateTime? DFechaPagoPed { get; set; } // dFechaPagoPed

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S medio transporte")]
        public string SMedioTransporte { get; set; } // sMedioTransporte (length: 50)

        [Display(Name = "N clave es")]
        public int? NClaveEs { get; set; } // nClaveES

        [Display(Name = "N clave arribo")]
        public int? NClaveArribo { get; set; } // nClaveArribo

        [Display(Name = "N clave salida")]
        public int? NClaveSalida { get; set; } // nClaveSalida

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S guia master")]
        public string SGuiaMaster { get; set; } // sGuiaMaster (length: 50)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S guia house")]
        public string SGuiaHouse { get; set; } // sGuiaHouse (length: 50)

        [Display(Name = "D cruce")]
        public System.DateTime? DCruce { get; set; } // dCruce

        [Display(Name = "D llegada")]
        public System.DateTime? DLlegada { get; set; } // dLlegada

        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "S factura desglose")]
        public string SFacturaDesglose { get; set; } // sFacturaDesglose (length: 25)

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S linea cruce")]
        public string SLineaCruce { get; set; } // sLineaCruce (length: 100)

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S aaa mericano")]
        public string SAaAmericano { get; set; } // sAAAmericano (length: 100)

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S pre file")]
        public string SPreFile { get; set; } // sPreFile (length: 100)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S guia usa")]
        public string SGuiaUsa { get; set; } // sGuiaUSA (length: 50)

        [Display(Name = "S transportista")]
        public int? STransportista { get; set; } // sTransportista

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S curp cliente")]
        public string SCurpCliente { get; set; } // sCurpCliente (length: 30)

        [MaxLength(13)]
        [StringLength(13)]
        [Display(Name = "S ed ocument")]
        public string SEDocument { get; set; } // sEDocument (length: 13)

        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "S nombre recinto")]
        public string SNombreRecinto { get; set; } // sNombreRecinto (length: 200)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S oper cove")]
        public string SOperCove { get; set; } // sOperCOVE (length: 50)

        [Display(Name = "S marcas num tot bultos")]
        public string SMarcasNumTotBultos { get; set; } // sMarcasNumTotBultos

        [Display(Name = "N peso bruto")]
        public decimal? NPesoBruto { get; set; } // nPesoBruto

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_220_REMESAS_HISTORICO].([NIdUsuarioEd]) (FK_SIR_220_REMESAS_HISTORICO_cat_usr)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_220_REMESAS_HISTORICO_cat_usr

        /// <summary>
        /// Parent SIR_Sir206Remesa pointed by [SIR_220_REMESAS_HISTORICO].([NIdRem206]) (FK_SIR_220_REMESAS_HISTORICO_SIR_206_REMESAS)
        /// </summary>
        public virtual SIR_Sir206Remesa SIR_Sir206Remesa { get; set; } // FK_SIR_220_REMESAS_HISTORICO_SIR_206_REMESAS

        public SIR_Sir220RemesasHistorico()
        {
            BConFacturas = false;
        }
    }

}
// </auto-generated>