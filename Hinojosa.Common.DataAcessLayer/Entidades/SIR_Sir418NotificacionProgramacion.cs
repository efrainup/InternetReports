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

    // SIR_418_NOTIFICACION_PROGRAMACION
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir418NotificacionProgramacion
    {
        [Required]
        [Display(Name = "N ID notificacion prog 418")]
        public int NIdNotificacionProg418 { get; set; } // nIdNotificacionProg418 (Primary key)

        [Required]
        [Display(Name = "N ID notificacion 416")]
        public int NIdNotificacion416 { get; set; } // nIdNotificacion416

        [Required]
        [Display(Name = "N tipo prog")]
        public int NTipoProg { get; set; } // nTipoProg

        [Required]
        [Display(Name = "N hora")]
        public int NHora { get; set; } // nHora

        [Required]
        [Display(Name = "N minuto")]
        public int NMinuto { get; set; } // nMinuto

        [Display(Name = "N dia")]
        public int? NDia { get; set; } // nDia

        [Display(Name = "N dia semana")]
        public int? NDiaSemana { get; set; } // nDiaSemana

        [Display(Name = "B primero mes")]
        public bool? BPrimeroMes { get; set; } // bPrimeroMes

        [Display(Name = "B ultimo mes")]
        public bool? BUltimoMes { get; set; } // bUltimoMes

        [Display(Name = "B rango fechas")]
        public bool? BRangoFechas { get; set; } // bRangoFechas

        [Display(Name = "N inicio")]
        public int? NInicio { get; set; } // nInicio

        [Display(Name = "N fin")]
        public int? NFin { get; set; } // nFin

        [Display(Name = "N frecuencia")]
        public int? NFrecuencia { get; set; } // nFrecuencia

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir421NotificacionCorreo where [SIR_421_NOTIFICACION_CORREO].[nIdNotificacionProg418] point to this entity (FK_SIR_421_NOTIFICACION_CORREO_SIR_409_CONFIG_VUCEM)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir421NotificacionCorreo> SIR_Sir421NotificacionCorreo { get; set; } // SIR_421_NOTIFICACION_CORREO.FK_SIR_421_NOTIFICACION_CORREO_SIR_409_CONFIG_VUCEM
        /// <summary>
        /// Child SIR_Sir481NotificacionFtp where [SIR_481_NOTIFICACION_FTP].[nIdNotificacionProg418] point to this entity (FK_SIR_481_NOTIFICACION_FTP_SIR_418_NOTIFICACION_PROGRAMACION)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir481NotificacionFtp> SIR_Sir481NotificacionFtp { get; set; } // SIR_481_NOTIFICACION_FTP.FK_SIR_481_NOTIFICACION_FTP_SIR_418_NOTIFICACION_PROGRAMACION

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir416Notificacione pointed by [SIR_418_NOTIFICACION_PROGRAMACION].([NIdNotificacion416]) (FK_SIR_418_NOTIFICACION_PROGRAMACION_SIR_416_NOTIFICACIONES)
        /// </summary>
        public virtual SIR_Sir416Notificacione SIR_Sir416Notificacione { get; set; } // FK_SIR_418_NOTIFICACION_PROGRAMACION_SIR_416_NOTIFICACIONES

        public SIR_Sir418NotificacionProgramacion()
        {
            SIR_Sir421NotificacionCorreo = new System.Collections.Generic.List<SIR_Sir421NotificacionCorreo>();
            SIR_Sir481NotificacionFtp = new System.Collections.Generic.List<SIR_Sir481NotificacionFtp>();
        }
    }

}
// </auto-generated>
