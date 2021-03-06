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

    // SIR_202_COMPLEM_FRACC_AGRUP
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir202ComplemFraccAgrup
    {
        [Required]
        [Display(Name = "N ID comp agrup 202")]
        public int NIdCompAgrup202 { get; set; } // nIdCompAgrup202 (Primary key)

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S marca producto")]
        public string SMarcaProducto { get; set; } // sMarcaProducto (length: 100)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S modelo producto")]
        public string SModeloProducto { get; set; } // sModeloProducto (length: 50)

        [Display(Name = "N ID factura 52")]
        public int? NIdFactura52 { get; set; } // nIdFactura52

        [Display(Name = "N imp tenencia")]
        public int? NImpTenencia { get; set; } // nImpTenencia

        [Display(Name = "N ID pais 01")]
        public int? NIdPais01 { get; set; } // nIdPais01

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S num parte")]
        public string SNumParte { get; set; } // sNumParte (length: 100)

        [Required]
        [Display(Name = "B camion peso max")]
        public bool BCamionPesoMax { get; set; } // bCamionPesoMax

        [Display(Name = "N val agregado")]
        public decimal? NValAgregado { get; set; } // nValAgregado

        [Display(Name = "N val retornos")]
        public decimal? NValRetornos { get; set; } // nValRetornos

        [Display(Name = "N insumos")]
        public decimal? NInsumos { get; set; } // nInsumos

        [Required]
        [Display(Name = "B propietaria")]
        public bool BPropietaria { get; set; } // bPropietaria

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "S hn um factura")]
        public string SHNumFactura { get; set; } // sHNumFactura (length: 15)

        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "S hc ve pais factura")]
        public string SHCvePaisFactura { get; set; } // sHCvePaisFactura (length: 3)

        [MaxLength(72)]
        [StringLength(72)]
        [Display(Name = "S hd esc pais fact")]
        public string SHDescPaisFact { get; set; } // sHDescPaisFact (length: 72)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S codigo producto")]
        public string SCodigoProducto { get; set; } // sCodigoProducto (length: 50)

        [Display(Name = "N val agregado me")]
        public decimal? NValAgregadoMe { get; set; } // nValAgregadoME

        [Display(Name = "N ID fac part agrupada 100")]
        public int? NIdFacPartAgrupada100 { get; set; } // nIdFacPartAgrupada100

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir100FacPartAgrupada where [SIR_100_FAC_PART_AGRUPADAS].[nIdCompAgrup202] point to this entity (FK_SIR_100_FAC_PART_AGRUPADAS_SIR_202_COMPLEM_FRACC_AGRUP)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir100FacPartAgrupada> SIR_Sir100FacPartAgrupada { get; set; } // SIR_100_FAC_PART_AGRUPADAS.FK_SIR_100_FAC_PART_AGRUPADAS_SIR_202_COMPLEM_FRACC_AGRUP

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_202_COMPLEM_FRACC_AGRUP].([NIdUsuarioEd]) (FK_SIR_202_COMPLEM_FRACC_AGRUP_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_202_COMPLEM_FRACC_AGRUP_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir01Pais pointed by [SIR_202_COMPLEM_FRACC_AGRUP].([NIdPais01]) (FK_SIR_202_COMPLEM_FRACC_AGRUP_SIR_01_PAISES)
        /// </summary>
        public virtual SIR_Sir01Pais SIR_Sir01Pais { get; set; } // FK_SIR_202_COMPLEM_FRACC_AGRUP_SIR_01_PAISES

        /// <summary>
        /// Parent SIR_Sir52Factura pointed by [SIR_202_COMPLEM_FRACC_AGRUP].([NIdFactura52]) (FK_SIR_202_COMPLEM_FRACC_AGRUP_SIR_52_FACTURAS)
        /// </summary>
        public virtual SIR_Sir52Factura SIR_Sir52Factura { get; set; } // FK_SIR_202_COMPLEM_FRACC_AGRUP_SIR_52_FACTURAS

        public SIR_Sir202ComplemFraccAgrup()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            SIR_Sir100FacPartAgrupada = new System.Collections.Generic.List<SIR_Sir100FacPartAgrupada>();
        }
    }

}
// </auto-generated>
