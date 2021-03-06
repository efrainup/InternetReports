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

    // SIRA_48_DETALLE_PROG_SERVICIOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira48DetalleProgServicio
    {
        [Required]
        [Display(Name = "N ID det prog serv 48")]
        public int NIdDetProgServ48 { get; set; } // nIdDetProgServ48 (Primary key)

        [Display(Name = "N ID referencia 60")]
        public int? NIdReferencia60 { get; set; } // nIdReferencia60

        [Display(Name = "N ID rec origen 42")]
        public int? NIdRecOrigen42 { get; set; } // nIdRecOrigen42

        [Display(Name = "N ID rec origen")]
        public int? NIdRecOrigen { get; set; } // nIdRecOrigen

        [Display(Name = "N ID rec destino 42")]
        public int? NIdRecDestino42 { get; set; } // nIdRecDestino42

        [Display(Name = "N ID rec destino")]
        public int? NIdRecDestino { get; set; } // nIdRecDestino

        [Display(Name = "N peso bruto")]
        public decimal? NPesoBruto { get; set; } // nPesoBruto

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha entrada")]
        public System.DateTime? DFechaEntrada { get; set; } // dFechaEntrada

        [Display(Name = "N ID transporte 175")]
        public int? NIdTransporte175 { get; set; } // nIdTransporte175

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir87SolicitudServicio where [SIR_87_SOLICITUD_SERVICIOS].[nIdDetProgServ48] point to this entity (FK_SIR_87_SOLICITUD_SERVICIOS_SIRA_48_DETALLE_PROG_SERVICIOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir87SolicitudServicio> SIR_Sir87SolicitudServicio { get; set; } // SIR_87_SOLICITUD_SERVICIOS.FK_SIR_87_SOLICITUD_SERVICIOS_SIRA_48_DETALLE_PROG_SERVICIOS

        // Foreign keys

        /// <summary>
        /// Parent Admin_Adminc42Proveedore pointed by [SIRA_48_DETALLE_PROG_SERVICIOS].([NIdRecDestino42]) (FK_SIRA_48_DETALLE_PROG_SERVICIOS_ADMINC_42_PROVEEDORES_DESTINO)
        /// </summary>
        public virtual Admin_Adminc42Proveedore Admin_Adminc42Proveedore_NIdRecDestino42 { get; set; } // FK_SIRA_48_DETALLE_PROG_SERVICIOS_ADMINC_42_PROVEEDORES_DESTINO

        /// <summary>
        /// Parent Admin_Adminc42Proveedore pointed by [SIRA_48_DETALLE_PROG_SERVICIOS].([NIdRecOrigen42]) (FK_SIRA_48_DETALLE_PROG_SERVICIOS_ADMINC_42_PROVEEDORES_ORIGEN)
        /// </summary>
        public virtual Admin_Adminc42Proveedore Admin_Adminc42Proveedore_NIdRecOrigen42 { get; set; } // FK_SIRA_48_DETALLE_PROG_SERVICIOS_ADMINC_42_PROVEEDORES_ORIGEN

        /// <summary>
        /// Parent CatProv pointed by [SIRA_48_DETALLE_PROG_SERVICIOS].([NIdRecDestino]) (FK_SIRA_48_DETALLE_PROG_SERVICIOS_cat_prov_DESTINO)
        /// </summary>
        public virtual CatProv CatProv_NIdRecDestino { get; set; } // FK_SIRA_48_DETALLE_PROG_SERVICIOS_cat_prov_DESTINO

        /// <summary>
        /// Parent CatProv pointed by [SIRA_48_DETALLE_PROG_SERVICIOS].([NIdRecOrigen]) (FK_SIRA_48_DETALLE_PROG_SERVICIOS_cat_prov_ORIGEN)
        /// </summary>
        public virtual CatProv CatProv_NIdRecOrigen { get; set; } // FK_SIRA_48_DETALLE_PROG_SERVICIOS_cat_prov_ORIGEN

        /// <summary>
        /// Parent SIR_Sir175Transporte pointed by [SIRA_48_DETALLE_PROG_SERVICIOS].([NIdTransporte175]) (FK_SIRA_48_DETALLE_PROG_SERVICIOS_SIR_175_TRANSPORTES)
        /// </summary>
        public virtual SIR_Sir175Transporte SIR_Sir175Transporte { get; set; } // FK_SIRA_48_DETALLE_PROG_SERVICIOS_SIR_175_TRANSPORTES

        /// <summary>
        /// Parent SIR_Sir60Referencia pointed by [SIRA_48_DETALLE_PROG_SERVICIOS].([NIdReferencia60]) (FK_SIRA_48_DETALLE_PROG_SERVICIOS_SIR_60_REFERENCIAS)
        /// </summary>
        public virtual SIR_Sir60Referencia SIR_Sir60Referencia { get; set; } // FK_SIRA_48_DETALLE_PROG_SERVICIOS_SIR_60_REFERENCIAS

        public SIRAdmin_Sira48DetalleProgServicio()
        {
            SIR_Sir87SolicitudServicio = new System.Collections.Generic.List<SIR_Sir87SolicitudServicio>();
        }
    }

}
// </auto-generated>
