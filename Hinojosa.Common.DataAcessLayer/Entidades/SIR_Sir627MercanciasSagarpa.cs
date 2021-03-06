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

    // SIR_627_MERCANCIAS_SAGARPA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir627MercanciasSagarpa
    {
        [Required]
        [Display(Name = "N ID mercancia 627")]
        public int NIdMercancia627 { get; set; } // nIdMercancia627 (Primary key)

        [Display(Name = "N ID fac part agrupada 100")]
        public int? NIdFacPartAgrupada100 { get; set; } // nIdFacPartAgrupada100

        [MaxLength(12)]
        [StringLength(12)]
        [Display(Name = "S fraccion")]
        public string SFraccion { get; set; } // sFraccion (length: 12)

        [Display(Name = "N numero de partida")]
        public int? NNumeroDePartida { get; set; } // nNumeroDePartida

        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 1000)

        [Display(Name = "N ID tipo de requisito 624")]
        public int? NIdTipoDeRequisito624 { get; set; } // nIdTipoDeRequisito624

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S requisito")]
        public string SRequisito { get; set; } // sRequisito (length: 50)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S certificado internacional")]
        public string SCertificadoInternacional { get; set; } // sCertificadoInternacional (length: 50)

        [Display(Name = "N ID uso de mcia 625")]
        public int? NIdUsoDeMcia625 { get; set; } // nIdUsoDeMcia625

        [Display(Name = "N ID tipo de producto 623")]
        public int? NIdTipoDeProducto623 { get; set; } // nIdTipoDeProducto623

        [Display(Name = "N ID pais origen 01")]
        public int? NIdPaisOrigen01 { get; set; } // nIdPaisOrigen01

        [Display(Name = "N ID um ed 10")]
        public int? NIdUMed10 { get; set; } // nIdUMed10

        [Display(Name = "N cantidad umt")]
        public decimal? NCantidadUmt { get; set; } // nCantidadUMT

        [Display(Name = "N cantidad umc")]
        public decimal? NCantidadUmc { get; set; } // nCantidadUMC

        [Display(Name = "N ID especie 611")]
        public int? NIdEspecie611 { get; set; } // nIdEspecie611

        [Display(Name = "N ID pais procedencia 01")]
        public int? NIdPaisProcedencia01 { get; set; } // nIdPaisProcedencia01

        [MaxLength(16)]
        [StringLength(16)]
        [Display(Name = "S lote")]
        public string SLote { get; set; } // sLote (length: 16)

        [Display(Name = "N cantidad solicitada umt")]
        public decimal? NCantidadSolicitadaUmt { get; set; } // nCantidadSolicitadaUMT

        [Display(Name = "N ID presentacion 617")]
        public int? NIdPresentacion617 { get; set; } // nIdPresentacion617

        [Display(Name = "N ID tipo de presentacion 622")]
        public int? NIdTipoDePresentacion622 { get; set; } // nIdTipoDePresentacion622

        [Display(Name = "N cantidad presentacion")]
        public decimal? NCantidadPresentacion { get; set; } // nCantidadPresentacion

        [Display(Name = "N tipo de planta 621")]
        public int? NTipoDePlanta621 { get; set; } // nTipoDePlanta621

        [MaxLength(150)]
        [StringLength(150)]
        [Display(Name = "S planta autorizada origen")]
        public string SPlantaAutorizadaOrigen { get; set; } // sPlantaAutorizadaOrigen (length: 150)

        [Display(Name = "N clave unica de planta")]
        public int? NClaveUnicaDePlanta { get; set; } // nClaveUnicaDePlanta

        [Display(Name = "N ID revision documental 626")]
        public int? NIdRevisionDocumental626 { get; set; } // nIdRevisionDocumental626

        [Display(Name = "N ID usuario ed")]
        public int? NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [DataType(DataType.DateTime)]
        [Display(Name = "D edicion")]
        public System.DateTime? DEdicion { get; set; } // dEdicion

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir628DetalleAnimalesVivo where [SIR_628_DETALLE_ANIMALES_VIVOS].[nIdMercancia627] point to this entity (FK_SIR_628_DETALLE_ANIMALES_VIVOS_SIR_627_MERCANCIAS_SAGARPA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir628DetalleAnimalesVivo> SIR_Sir628DetalleAnimalesVivo { get; set; } // SIR_628_DETALLE_ANIMALES_VIVOS.FK_SIR_628_DETALLE_ANIMALES_VIVOS_SIR_627_MERCANCIAS_SAGARPA
        /// <summary>
        /// Child SIR_Sir629DetalleProductosSubProducto where [SIR_629_DETALLE_PRODUCTOS_SUB_PRODUCTOS].[nIdMercancia627] point to this entity (FK_SIR_629_DETALLE_PRODUCTOS_SUB_PRODUCTOS_SIR_627_MERCANCIAS_SAGARPA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir629DetalleProductosSubProducto> SIR_Sir629DetalleProductosSubProducto { get; set; } // SIR_629_DETALLE_PRODUCTOS_SUB_PRODUCTOS.FK_SIR_629_DETALLE_PRODUCTOS_SUB_PRODUCTOS_SIR_627_MERCANCIAS_SAGARPA
        /// <summary>
        /// Child SIR_Sir672DetalleMercanciaSagarpaVucem where [SIR_672_DETALLE_MERCANCIA_SAGARPA_VUCEM].[nIdMercancia627] point to this entity (FK_SIR_672_DETALLE_MERCANCIA_SAGARPA_VUCEM_SIR_627_MERCANCIAS_SAGARPA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir672DetalleMercanciaSagarpaVucem> SIR_Sir672DetalleMercanciaSagarpaVucem { get; set; } // SIR_672_DETALLE_MERCANCIA_SAGARPA_VUCEM.FK_SIR_672_DETALLE_MERCANCIA_SAGARPA_VUCEM_SIR_627_MERCANCIAS_SAGARPA

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir01Pais pointed by [SIR_627_MERCANCIAS_SAGARPA].([NIdPaisOrigen01]) (FK_SIR_627_MERCANCIAS_SAGARPA_SIR_01_PAISES_ORIGEN)
        /// </summary>
        public virtual SIR_Sir01Pais SIR_Sir01Pais_NIdPaisOrigen01 { get; set; } // FK_SIR_627_MERCANCIAS_SAGARPA_SIR_01_PAISES_ORIGEN

        /// <summary>
        /// Parent SIR_Sir01Pais pointed by [SIR_627_MERCANCIAS_SAGARPA].([NIdPaisProcedencia01]) (FK_SIR_627_MERCANCIAS_SAGARPA_SIR_01_PAISES_PROCEDENCIA)
        /// </summary>
        public virtual SIR_Sir01Pais SIR_Sir01Pais_NIdPaisProcedencia01 { get; set; } // FK_SIR_627_MERCANCIAS_SAGARPA_SIR_01_PAISES_PROCEDENCIA

        /// <summary>
        /// Parent SIR_Sir10UnidadesMedida pointed by [SIR_627_MERCANCIAS_SAGARPA].([NIdUMed10]) (FK_SIR_627_MERCANCIAS_SAGARPA_SIR_10_UNIDADES_MEDIDA)
        /// </summary>
        public virtual SIR_Sir10UnidadesMedida SIR_Sir10UnidadesMedida { get; set; } // FK_SIR_627_MERCANCIAS_SAGARPA_SIR_10_UNIDADES_MEDIDA

        /// <summary>
        /// Parent SIR_Sir611EspecieSagarpa pointed by [SIR_627_MERCANCIAS_SAGARPA].([NIdEspecie611]) (FK_SIR_627_MERCANCIAS_SAGARPA_SIR_611_ESPECIE_SAGARPA)
        /// </summary>
        public virtual SIR_Sir611EspecieSagarpa SIR_Sir611EspecieSagarpa { get; set; } // FK_SIR_627_MERCANCIAS_SAGARPA_SIR_611_ESPECIE_SAGARPA

        /// <summary>
        /// Parent SIR_Sir617PresentacionSagarpa pointed by [SIR_627_MERCANCIAS_SAGARPA].([NIdPresentacion617]) (FK_SIR_627_MERCANCIAS_SAGARPA_SIR_617_PRESENTACION_SAGARPA)
        /// </summary>
        public virtual SIR_Sir617PresentacionSagarpa SIR_Sir617PresentacionSagarpa { get; set; } // FK_SIR_627_MERCANCIAS_SAGARPA_SIR_617_PRESENTACION_SAGARPA

        /// <summary>
        /// Parent SIR_Sir621TipoDePlanta pointed by [SIR_627_MERCANCIAS_SAGARPA].([NTipoDePlanta621]) (FK_SIR_627_MERCANCIAS_SAGARPA_SIR_621_TIPO_DE_PLANTA)
        /// </summary>
        public virtual SIR_Sir621TipoDePlanta SIR_Sir621TipoDePlanta { get; set; } // FK_SIR_627_MERCANCIAS_SAGARPA_SIR_621_TIPO_DE_PLANTA

        /// <summary>
        /// Parent SIR_Sir622TipoDePresentacion pointed by [SIR_627_MERCANCIAS_SAGARPA].([NIdTipoDePresentacion622]) (FK_SIR_627_MERCANCIAS_SAGARPA_SIR_622_TIPO_DE_PRESENTACION)
        /// </summary>
        public virtual SIR_Sir622TipoDePresentacion SIR_Sir622TipoDePresentacion { get; set; } // FK_SIR_627_MERCANCIAS_SAGARPA_SIR_622_TIPO_DE_PRESENTACION

        /// <summary>
        /// Parent SIR_Sir623TipoDeProductoSagarpa pointed by [SIR_627_MERCANCIAS_SAGARPA].([NIdTipoDeProducto623]) (FK_SIR_627_MERCANCIAS_SAGARPA_SIR_623_TIPO_DE_PRODUCTO_SAGARPA)
        /// </summary>
        public virtual SIR_Sir623TipoDeProductoSagarpa SIR_Sir623TipoDeProductoSagarpa { get; set; } // FK_SIR_627_MERCANCIAS_SAGARPA_SIR_623_TIPO_DE_PRODUCTO_SAGARPA

        /// <summary>
        /// Parent SIR_Sir624TipoDeRequisitoSagarpa pointed by [SIR_627_MERCANCIAS_SAGARPA].([NIdTipoDeRequisito624]) (FK_SIR_627_MERCANCIAS_SAGARPA_SIR_624_TIPO_DE_REQUISITO_SAGARPA)
        /// </summary>
        public virtual SIR_Sir624TipoDeRequisitoSagarpa SIR_Sir624TipoDeRequisitoSagarpa { get; set; } // FK_SIR_627_MERCANCIAS_SAGARPA_SIR_624_TIPO_DE_REQUISITO_SAGARPA

        /// <summary>
        /// Parent SIR_Sir625UsoDeMercanciaSagarpa pointed by [SIR_627_MERCANCIAS_SAGARPA].([NIdUsoDeMcia625]) (FK_SIR_627_MERCANCIAS_SAGARPA_SIR_625_USO_DE_MERCANCIA_SAGARPA)
        /// </summary>
        public virtual SIR_Sir625UsoDeMercanciaSagarpa SIR_Sir625UsoDeMercanciaSagarpa { get; set; } // FK_SIR_627_MERCANCIAS_SAGARPA_SIR_625_USO_DE_MERCANCIA_SAGARPA

        /// <summary>
        /// Parent SIR_Sir626RevisionDocumental pointed by [SIR_627_MERCANCIAS_SAGARPA].([NIdRevisionDocumental626]) (FK_SIR_627_MERCANCIAS_SAGARPA_SIR_626_REVISION_DOCUMENTAL)
        /// </summary>
        public virtual SIR_Sir626RevisionDocumental SIR_Sir626RevisionDocumental { get; set; } // FK_SIR_627_MERCANCIAS_SAGARPA_SIR_626_REVISION_DOCUMENTAL

        public SIR_Sir627MercanciasSagarpa()
        {
            SIR_Sir628DetalleAnimalesVivo = new System.Collections.Generic.List<SIR_Sir628DetalleAnimalesVivo>();
            SIR_Sir629DetalleProductosSubProducto = new System.Collections.Generic.List<SIR_Sir629DetalleProductosSubProducto>();
            SIR_Sir672DetalleMercanciaSagarpaVucem = new System.Collections.Generic.List<SIR_Sir672DetalleMercanciaSagarpaVucem>();
        }
    }

}
// </auto-generated>
