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

    // SIR_656_ORDEN_TRABAJO_SERVICIO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir656OrdenTrabajoServicio
    {
        [Required]
        [Display(Name = "N ID orden de trabajo servicio 656")]
        public int NIdOrdenDeTrabajoServicio656 { get; set; } // nIdOrdenDeTrabajoServicio656 (Primary key)

        [Required]
        [Display(Name = "N ID orden de trabajo 646")]
        public int NIdOrdenDeTrabajo646 { get; set; } // nIdOrdenDeTrabajo646

        [Required]
        [Display(Name = "N ID catalogo servicio 642")]
        public int NIdCatalogoServicio642 { get; set; } // nIdCatalogoServicio642

        [Display(Name = "N ID proveedor 42")]
        public int? NIdProveedor42 { get; set; } // nIdProveedor42

        [Display(Name = "N ID proveedor admin 42")]
        public int? NIdProveedorAdmin42 { get; set; } // nIdProveedorAdmin42

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir647DatosServicio where [SIR_647_DATOS_SERVICIOS].[nIdOrdenDeTrabajoServicio656] point to this entity ([FK_SIR_647_DATOS_SERVICIOS_SIR_656_ORDEN_TRABAJO_SERVICIO)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir647DatosServicio> SIR_Sir647DatosServicio { get; set; } // SIR_647_DATOS_SERVICIOS.[FK_SIR_647_DATOS_SERVICIOS_SIR_656_ORDEN_TRABAJO_SERVICIO

        // Foreign keys

        /// <summary>
        /// Parent Admin_Adminc42Proveedore pointed by [SIR_656_ORDEN_TRABAJO_SERVICIO].([NIdProveedorAdmin42]) (FK_SIR_656_ORDEN_TRABAJO_SERVICIO_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual Admin_Adminc42Proveedore Admin_Adminc42Proveedore { get; set; } // FK_SIR_656_ORDEN_TRABAJO_SERVICIO_ADMINC_42_PROVEEDORES

        /// <summary>
        /// Parent SIR_Sir42Proveedore pointed by [SIR_656_ORDEN_TRABAJO_SERVICIO].([NIdProveedor42]) (FK_SIR_656_ORDEN_TRABAJO_SERVICIO_SIR_42_PROVEEDORES)
        /// </summary>
        public virtual SIR_Sir42Proveedore SIR_Sir42Proveedore { get; set; } // FK_SIR_656_ORDEN_TRABAJO_SERVICIO_SIR_42_PROVEEDORES

        /// <summary>
        /// Parent SIR_Sir642CatalogoServicio pointed by [SIR_656_ORDEN_TRABAJO_SERVICIO].([NIdCatalogoServicio642]) (FK_SIR_656_ORDEN_TRABAJO_SERVICIO_SIR_642_CATALOGO_SERVICIOS)
        /// </summary>
        public virtual SIR_Sir642CatalogoServicio SIR_Sir642CatalogoServicio { get; set; } // FK_SIR_656_ORDEN_TRABAJO_SERVICIO_SIR_642_CATALOGO_SERVICIOS

        /// <summary>
        /// Parent SIR_Sir646OrdenesDeTrabajo pointed by [SIR_656_ORDEN_TRABAJO_SERVICIO].([NIdOrdenDeTrabajo646]) (FK_SIR_656_ORDEN_TRABAJO_SERVICIO_SIR_646_ORDENES_DE_TRABAJO)
        /// </summary>
        public virtual SIR_Sir646OrdenesDeTrabajo SIR_Sir646OrdenesDeTrabajo { get; set; } // FK_SIR_656_ORDEN_TRABAJO_SERVICIO_SIR_646_ORDENES_DE_TRABAJO

        public SIR_Sir656OrdenTrabajoServicio()
        {
            SIR_Sir647DatosServicio = new System.Collections.Generic.List<SIR_Sir647DatosServicio>();
        }
    }

}
// </auto-generated>