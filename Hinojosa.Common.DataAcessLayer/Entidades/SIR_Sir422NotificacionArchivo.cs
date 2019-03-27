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

    // SIR_422_NOTIFICACION_ARCHIVOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir422NotificacionArchivo
    {
        [Required]
        [Display(Name = "N ID notificacion archivo 422")]
        public int NIdNotificacionArchivo422 { get; set; } // nIdNotificacionArchivo422 (Primary key)

        [Display(Name = "N ID notificacion correo 421")]
        public int? NIdNotificacionCorreo421 { get; set; } // nIdNotificacionCorreo421

        [MaxLength(8000)]
        [StringLength(8000)]
        [Display(Name = "S ruta archivo")]
        public string SRutaArchivo { get; set; } // sRutaArchivo (length: 8000)

        [Display(Name = "N tipo archivo")]
        public int? NTipoArchivo { get; set; } // nTipoArchivo

        [Display(Name = "N tipo reporte")]
        public int? NTipoReporte { get; set; } // nTipoReporte

        [Display(Name = "N ID notificacion reporte 453")]
        public int? NIdNotificacionReporte453 { get; set; } // nIdNotificacionReporte453

        [Display(Name = "N ID vista xml 191")]
        public int? NIdVistaXml191 { get; set; } // nIdVistaXML191

        [Display(Name = "N ID notificacion ftp 481")]
        public int? NIdNotificacionFtp481 { get; set; } // nIdNotificacionFTP481

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir191VistasXml pointed by [SIR_422_NOTIFICACION_ARCHIVOS].([NIdVistaXml191]) (FK_SIR_422_NOTIFICACION_ARCHIVOS_SIR_191_VISTAS_XML)
        /// </summary>
        public virtual SIR_Sir191VistasXml SIR_Sir191VistasXml { get; set; } // FK_SIR_422_NOTIFICACION_ARCHIVOS_SIR_191_VISTAS_XML

        /// <summary>
        /// Parent SIR_Sir421NotificacionCorreo pointed by [SIR_422_NOTIFICACION_ARCHIVOS].([NIdNotificacionCorreo421]) (FK_SIR_422_NOTIFICACION_ARCHIVOS_SIR_421_NOTIFICACION_CORREO)
        /// </summary>
        public virtual SIR_Sir421NotificacionCorreo SIR_Sir421NotificacionCorreo { get; set; } // FK_SIR_422_NOTIFICACION_ARCHIVOS_SIR_421_NOTIFICACION_CORREO

        /// <summary>
        /// Parent SIR_Sir453NotificacionReporte pointed by [SIR_422_NOTIFICACION_ARCHIVOS].([NIdNotificacionReporte453]) (FK_SIR_422_NOTIFICACION_ARCHIVOS_SIR_453_NOTIFICACION_REPORTES)
        /// </summary>
        public virtual SIR_Sir453NotificacionReporte SIR_Sir453NotificacionReporte { get; set; } // FK_SIR_422_NOTIFICACION_ARCHIVOS_SIR_453_NOTIFICACION_REPORTES

        /// <summary>
        /// Parent SIR_Sir481NotificacionFtp pointed by [SIR_422_NOTIFICACION_ARCHIVOS].([NIdNotificacionFtp481]) (FK_SIR_422_NOTIFICACION_ARCHIVOS_SIR_481_NOTIFICACION_FTP)
        /// </summary>
        public virtual SIR_Sir481NotificacionFtp SIR_Sir481NotificacionFtp { get; set; } // FK_SIR_422_NOTIFICACION_ARCHIVOS_SIR_481_NOTIFICACION_FTP
    }

}
// </auto-generated>
