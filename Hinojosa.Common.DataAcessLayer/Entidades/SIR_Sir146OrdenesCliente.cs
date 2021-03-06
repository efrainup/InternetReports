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

    // SIR_146_ORDENES_CLIENTES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir146OrdenesCliente
    {
        [Required]
        [Display(Name = "N ID orden cli 146")]
        public int NIdOrdenCli146 { get; set; } // nIdOrdenCli146 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S numero orden")]
        public string SNumeroOrden { get; set; } // sNumeroOrden (length: 50)

        [Required]
        [Display(Name = "N ID cliente")]
        public int NIdCliente { get; set; } // nIdCliente

        [Required]
        [Display(Name = "D fecha orden")]
        public System.DateTime DFechaOrden { get; set; } // dFechaOrden

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S occ liente")]
        public string SOcCliente { get; set; } // sOCCliente (length: 50)

        [Required]
        [Display(Name = "N status")]
        public byte NStatus { get; set; } // nStatus

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S consignado a")]
        public string SConsignadoA { get; set; } // sConsignadoA (length: 50)

        [Required]
        [Display(Name = "D fecha estimada")]
        public System.DateTime DFechaEstimada { get; set; } // dFechaEstimada

        [Display(Name = "D fecha recibida")]
        public System.DateTime? DFechaRecibida { get; set; } // dFechaRecibida

        [Display(Name = "D fecha cancelada")]
        public System.DateTime? DFechaCancelada { get; set; } // dFechaCancelada

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Display(Name = "N ID entrada 156")]
        public int? NIdEntrada156 { get; set; } // nIdEntrada156

        [Display(Name = "N ID suc pat adu 71")]
        public int? NIdSucPatAdu71 { get; set; } // nIdSucPatAdu71

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir147OrdenesObserv where [SIR_147_ORDENES_OBSERV].[nIdOrdenCli146] point to this entity (FK_SIR_147_ORDENES_OBSERVACIONES_SIR_146_ORDENES_CLIENTES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir147OrdenesObserv> SIR_Sir147OrdenesObserv { get; set; } // SIR_147_ORDENES_OBSERV.FK_SIR_147_ORDENES_OBSERVACIONES_SIR_146_ORDENES_CLIENTES
        /// <summary>
        /// Child SIR_Sir148OrdenesReferencia where [SIR_148_ORDENES_REFERENCIAS].[nIdOrdenCli146] point to this entity (FK_SIR_148_ORDENES_REFERENCIAS_SIR_146_ORDENES_CLIENTES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir148OrdenesReferencia> SIR_Sir148OrdenesReferencia { get; set; } // SIR_148_ORDENES_REFERENCIAS.FK_SIR_148_ORDENES_REFERENCIAS_SIR_146_ORDENES_CLIENTES
        /// <summary>
        /// Child SIR_Sir52Factura where [SIR_52_FACTURAS].[nIdOrdenCli146] point to this entity (FK_SIR_52_FACTURAS_SIR_146_ORDENES_CLIENTES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir52Factura> SIR_Sir52Factura { get; set; } // SIR_52_FACTURAS.FK_SIR_52_FACTURAS_SIR_146_ORDENES_CLIENTES
        /// <summary>
        /// Child SIR_Sir66CargaSuelta where [SIR_66_CARGA_SUELTA].[nIdOrdenCli146] point to this entity (FK_SIR_66_CARGA_SUELTA_SIR_146_ORDENES_CLIENTES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir66CargaSuelta> SIR_Sir66CargaSuelta { get; set; } // SIR_66_CARGA_SUELTA.FK_SIR_66_CARGA_SUELTA_SIR_146_ORDENES_CLIENTES

        // Foreign keys

        /// <summary>
        /// Parent CatCliente pointed by [SIR_146_ORDENES_CLIENTES].([NIdCliente]) (FK_SIR_146_ORDENES_CLIENTES_cat_clientes)
        /// </summary>
        public virtual CatCliente CatCliente { get; set; } // FK_SIR_146_ORDENES_CLIENTES_cat_clientes

        /// <summary>
        /// Parent CatUsr pointed by [SIR_146_ORDENES_CLIENTES].([NIdUsuarioEd]) (FK_SIR_146_ORDENES_CLIENTES_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_146_ORDENES_CLIENTES_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir156EntradasBodega pointed by [SIR_146_ORDENES_CLIENTES].([NIdEntrada156]) (FK_SIR_146_ORDENES_CLIENTES_SIR_156_ENTRADAS_BODEGAS)
        /// </summary>
        public virtual SIR_Sir156EntradasBodega SIR_Sir156EntradasBodega { get; set; } // FK_SIR_146_ORDENES_CLIENTES_SIR_156_ENTRADAS_BODEGAS

        /// <summary>
        /// Parent SIR_Sir71SucursalPatenteAduana pointed by [SIR_146_ORDENES_CLIENTES].([NIdSucPatAdu71]) (FK_SIR_146_ORDENES_CLIENTES_SIR_71_SUCURSAL_PATENTE_ADUANA)
        /// </summary>
        public virtual SIR_Sir71SucursalPatenteAduana SIR_Sir71SucursalPatenteAduana { get; set; } // FK_SIR_146_ORDENES_CLIENTES_SIR_71_SUCURSAL_PATENTE_ADUANA

        public SIR_Sir146OrdenesCliente()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            SIR_Sir147OrdenesObserv = new System.Collections.Generic.List<SIR_Sir147OrdenesObserv>();
            SIR_Sir148OrdenesReferencia = new System.Collections.Generic.List<SIR_Sir148OrdenesReferencia>();
            SIR_Sir52Factura = new System.Collections.Generic.List<SIR_Sir52Factura>();
            SIR_Sir66CargaSuelta = new System.Collections.Generic.List<SIR_Sir66CargaSuelta>();
        }
    }

}
// </auto-generated>
