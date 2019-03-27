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

    // SIR_229_PARTIDAS_AGRUP_SAGARPA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir229PartidasAgrupSagarpa
    {
        [Required]
        [Display(Name = "N ID par agr sag 229")]
        public int NIdParAgrSag229 { get; set; } // nIdParAgrSag229 (Primary key)

        [Display(Name = "N ID reg sag 228")]
        public int? NIdRegSag228 { get; set; } // nIdRegSag228

        [Display(Name = "N ID planta sagar 104")]
        public int? NIdPlantaSagar104 { get; set; } // nIdPlantaSAGAR104

        [Required]
        [Display(Name = "N tipo requisito")]
        public byte NTipoRequisito { get; set; } // nTipoRequisito

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S requisito sanitario")]
        public string SRequisitoSanitario { get; set; } // sRequisitoSanitario (length: 100)

        [Display(Name = "N numero carros")]
        public int? NNumeroCarros { get; set; } // nNumeroCarros

        [Required]
        [Display(Name = "B may contain")]
        public bool BMayContain { get; set; } // bMayContain

        [Required]
        [Display(Name = "B aplicable rtv")]
        public bool BAplicableRtv { get; set; } // bAplicableRTV

        [Required]
        [Display(Name = "B aplica muestra")]
        public bool BAplicaMuestra { get; set; } // bAplicaMuestra

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S folio cert int")]
        public string SFolioCertInt { get; set; } // sFolioCertInt (length: 50)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "S descripcion aa")]
        public string SDescripcionAa { get; set; } // sDescripcionAA (length: 250)

        [Required]
        [Display(Name = "N ID umc 10")]
        public int NIdUmc10 { get; set; } // nIdUMC10

        [Required]
        [Display(Name = "N ID umt 10")]
        public int NIdUmt10 { get; set; } // nIdUMT10

        [Required]
        [Display(Name = "N cantidad tarifa")]
        public decimal NCantidadTarifa { get; set; } // nCantidadTarifa

        [Required]
        [Display(Name = "N cantidad factura")]
        public decimal NCantidadFactura { get; set; } // nCantidadFactura

        [Display(Name = "N ID muestra 232")]
        public int? NIdMuestra232 { get; set; } // nIdMuestra232

        [Display(Name = "N ID fac part agrupada 100")]
        public int? NIdFacPartAgrupada100 { get; set; } // nIdFacPartAgrupada100

        [Display(Name = "N ID pais proced")]
        public int? NIdPaisProced { get; set; } // nIdPaisProced

        [Display(Name = "N ID pais origen")]
        public int? NIdPaisOrigen { get; set; } // nIdPaisOrigen

        [MaxLength(12)]
        [StringLength(12)]
        [Display(Name = "S fraccion")]
        public string SFraccion { get; set; } // sFraccion (length: 12)

        [Display(Name = "N num orden")]
        public int? NNumOrden { get; set; } // nNumOrden

        [Display(Name = "N num orden muestra")]
        public int? NNumOrdenMuestra { get; set; } // nNumOrdenMuestra

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir230LotesSagarpa where [SIR_230_LOTES_SAGARPA].[nIdParAgrSag229] point to this entity (FK_SIR_230_LOTES_SAGARPA_SIR_229_PARTIDAS_AGRUP_SAGARPA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir230LotesSagarpa> SIR_Sir230LotesSagarpa { get; set; } // SIR_230_LOTES_SAGARPA.FK_SIR_230_LOTES_SAGARPA_SIR_229_PARTIDAS_AGRUP_SAGARPA

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_229_PARTIDAS_AGRUP_SAGARPA].([NIdUsuarioEd]) (FK_SIR_229_PARTIDAS_AGRUP_SAGARPA_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_229_PARTIDAS_AGRUP_SAGARPA_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir01Pais pointed by [SIR_229_PARTIDAS_AGRUP_SAGARPA].([NIdPaisOrigen]) (FK_SIR_229_PARTIDAS_AGRUP_SAGARPA_SIR_01_PAISES_Origen)
        /// </summary>
        public virtual SIR_Sir01Pais SIR_Sir01Pais_NIdPaisOrigen { get; set; } // FK_SIR_229_PARTIDAS_AGRUP_SAGARPA_SIR_01_PAISES_Origen

        /// <summary>
        /// Parent SIR_Sir01Pais pointed by [SIR_229_PARTIDAS_AGRUP_SAGARPA].([NIdPaisProced]) (FK_SIR_229_PARTIDAS_AGRUP_SAGARPA_SIR_01_PAISES_procedencia)
        /// </summary>
        public virtual SIR_Sir01Pais SIR_Sir01Pais_NIdPaisProced { get; set; } // FK_SIR_229_PARTIDAS_AGRUP_SAGARPA_SIR_01_PAISES_procedencia

        /// <summary>
        /// Parent SIR_Sir104PlantasSagar pointed by [SIR_229_PARTIDAS_AGRUP_SAGARPA].([NIdPlantaSagar104]) (FK_SIR_229_PARTIDAS_AGRUP_SAGARPA_SIR_104_PLANTAS_SAGAR)
        /// </summary>
        public virtual SIR_Sir104PlantasSagar SIR_Sir104PlantasSagar { get; set; } // FK_SIR_229_PARTIDAS_AGRUP_SAGARPA_SIR_104_PLANTAS_SAGAR

        /// <summary>
        /// Parent SIR_Sir10UnidadesMedida pointed by [SIR_229_PARTIDAS_AGRUP_SAGARPA].([NIdUmc10]) (FK_SIR_229_PARTIDAS_AGRUP_SAGARPA_SIR_10_UNIDADES_MEDIDA_comercial)
        /// </summary>
        public virtual SIR_Sir10UnidadesMedida SIR_Sir10UnidadesMedida_NIdUmc10 { get; set; } // FK_SIR_229_PARTIDAS_AGRUP_SAGARPA_SIR_10_UNIDADES_MEDIDA_comercial

        /// <summary>
        /// Parent SIR_Sir10UnidadesMedida pointed by [SIR_229_PARTIDAS_AGRUP_SAGARPA].([NIdUmt10]) (FK_SIR_229_PARTIDAS_AGRUP_SAGARPA_SIR_10_UNIDADES_MEDIDA_tarifa)
        /// </summary>
        public virtual SIR_Sir10UnidadesMedida SIR_Sir10UnidadesMedida_NIdUmt10 { get; set; } // FK_SIR_229_PARTIDAS_AGRUP_SAGARPA_SIR_10_UNIDADES_MEDIDA_tarifa

        /// <summary>
        /// Parent SIR_Sir228RegistrosSagarpa pointed by [SIR_229_PARTIDAS_AGRUP_SAGARPA].([NIdRegSag228]) (FK_SIR_229_PARTIDAS_AGRUP_SAGARPA_SIR_228_REGISTROS_SAGARPA)
        /// </summary>
        public virtual SIR_Sir228RegistrosSagarpa SIR_Sir228RegistrosSagarpa { get; set; } // FK_SIR_229_PARTIDAS_AGRUP_SAGARPA_SIR_228_REGISTROS_SAGARPA

        /// <summary>
        /// Parent SIR_Sir232MuestrasSagarpa pointed by [SIR_229_PARTIDAS_AGRUP_SAGARPA].([NIdMuestra232]) (FK_SIR_229_PARTIDAS_AGRUP_SAGARPA_SIR_232_MUESTRAS_SAGARPA)
        /// </summary>
        public virtual SIR_Sir232MuestrasSagarpa SIR_Sir232MuestrasSagarpa { get; set; } // FK_SIR_229_PARTIDAS_AGRUP_SAGARPA_SIR_232_MUESTRAS_SAGARPA

        public SIR_Sir229PartidasAgrupSagarpa()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            SIR_Sir230LotesSagarpa = new System.Collections.Generic.List<SIR_Sir230LotesSagarpa>();
        }
    }

}
// </auto-generated>
