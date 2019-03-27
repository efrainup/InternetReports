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

    // SIR_741_MANIFIESTO_DE_VIAJE_DMS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir741ManifiestoDeViajeDm
    {
        [Required]
        [Display(Name = "N ID man via 741")]
        public int NIdManVia741 { get; set; } // nIdManVia741 (Primary key)

        [Display(Name = "N ID entidad responsable 07")]
        public int? NIdEntidadResponsable07 { get; set; } // nIdEntidadResponsable07

        [Display(Name = "N ID entidad factura 07")]
        public int? NIdEntidadFactura07 { get; set; } // nIdEntidadFactura07

        ///<summary>
        /// 1) Consolidado, 
        /// 2) Directo
        ///</summary>
        [Display(Name = "N ID tipo distribucion")]
        public int? NIdTipoDistribucion { get; set; } // nIdTipoDistribucion

        [Display(Name = "N ID cedis 705")]
        public int? NIdCedis705 { get; set; } // nIdCedis705

        [Display(Name = "N ID proveedor 42")]
        public int? NIdProveedor42 { get; set; } // nIdProveedor42

        [Display(Name = "N ID vehiculo tipo 705")]
        public int? NIdVehiculoTipo705 { get; set; } // nIdVehiculoTipo705

        [Display(Name = "N ID usuario elaboro 02")]
        public int? NIdUsuarioElaboro02 { get; set; } // nIdUsuarioElaboro02

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S manifiesto referencia")]
        public string SManifiestoReferencia { get; set; } // sManifiestoReferencia (length: 30)

        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "S guia")]
        public string SGuia { get; set; } // sGuia (length: 200)

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha embarque")]
        public System.DateTime? DFechaEmbarque { get; set; } // dFechaEmbarque

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha ejecucion")]
        public System.DateTime? DFechaEjecucion { get; set; } // dFechaEjecucion

        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "S numero caja transporte")]
        public string SNumeroCajaTransporte { get; set; } // sNumeroCajaTransporte (length: 60)

        [Display(Name = "N ID moneda")]
        public int? NIdMoneda { get; set; } // nIdMoneda

        [Display(Name = "B iniciado")]
        public bool? BIniciado { get; set; } // bIniciado

        // Foreign keys

        /// <summary>
        /// Parent Admin_Admina02Personal pointed by [SIR_741_MANIFIESTO_DE_VIAJE_DMS].([NIdUsuarioElaboro02]) (FK_SIR_741_MANIFIESTO_DE_VIAJE_DMS_ADMINA_02_PERSONAL)
        /// </summary>
        public virtual Admin_Admina02Personal Admin_Admina02Personal { get; set; } // FK_SIR_741_MANIFIESTO_DE_VIAJE_DMS_ADMINA_02_PERSONAL

        /// <summary>
        /// Parent Admin_Adminc07Cliente pointed by [SIR_741_MANIFIESTO_DE_VIAJE_DMS].([NIdEntidadFactura07]) (FK_SIR_741_MANIFIESTO_DE_VIAJE_DMS_ADMINC_07_CLIENTES1)
        /// </summary>
        public virtual Admin_Adminc07Cliente Admin_Adminc07Cliente_NIdEntidadFactura07 { get; set; } // FK_SIR_741_MANIFIESTO_DE_VIAJE_DMS_ADMINC_07_CLIENTES1

        /// <summary>
        /// Parent Admin_Adminc07Cliente pointed by [SIR_741_MANIFIESTO_DE_VIAJE_DMS].([NIdEntidadResponsable07]) (FK_SIR_741_MANIFIESTO_DE_VIAJE_DMS_ADMINC_07_CLIENTES)
        /// </summary>
        public virtual Admin_Adminc07Cliente Admin_Adminc07Cliente_NIdEntidadResponsable07 { get; set; } // FK_SIR_741_MANIFIESTO_DE_VIAJE_DMS_ADMINC_07_CLIENTES

        /// <summary>
        /// Parent Admin_Adminc42Proveedore pointed by [SIR_741_MANIFIESTO_DE_VIAJE_DMS].([NIdProveedor42]) (FK_SIR_741_MANIFIESTO_DE_VIAJE_DMS_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual Admin_Adminc42Proveedore Admin_Adminc42Proveedore { get; set; } // FK_SIR_741_MANIFIESTO_DE_VIAJE_DMS_ADMINC_42_PROVEEDORES
    }

}
// </auto-generated>