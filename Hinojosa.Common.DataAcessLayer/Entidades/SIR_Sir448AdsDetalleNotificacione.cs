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

    // SIR_448_ADS_DETALLE_NOTIFICACIONES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir448AdsDetalleNotificacione
    {
        [Required]
        [Display(Name = "N ID detalle notificacion 448")]
        public int NIdDetalleNotificacion448 { get; set; } // nIdDetalleNotificacion448 (Primary key)

        [Required]
        [Display(Name = "N ID adsn otificacion 437")]
        public int NIdAdsNotificacion437 { get; set; } // nIdADSNotificacion437

        [Required]
        [Display(Name = "N orden")]
        public byte NOrden { get; set; } // nOrden

        [Required]
        [Display(Name = "N tipo")]
        public byte NTipo { get; set; } // nTipo

        [Required]
        [Display(Name = "N duracion")]
        public int NDuracion { get; set; } // nDuracion

        [Required]
        [Display(Name = "N nivel")]
        public byte NNivel { get; set; } // nNivel

        [Required]
        [Display(Name = "N numero de alertas")]
        public byte NNumeroDeAlertas { get; set; } // nNumeroDeAlertas

        [Required]
        [Display(Name = "N icono")]
        public byte NIcono { get; set; } // nIcono

        [Display(Name = "B notificado")]
        public bool? BNotificado { get; set; } // bNotificado

        [Display(Name = "B sin notificar")]
        public bool? BSinNotificar { get; set; } // bSinNotificar

        [Display(Name = "N intentos")]
        public byte? NIntentos { get; set; } // nIntentos

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir437AdsNotificacione pointed by [SIR_448_ADS_DETALLE_NOTIFICACIONES].([NIdAdsNotificacion437]) (FK_SIR_448_ADS_DETALLE_NOTIFICACIONES_SIR_437_ADS_NOTIFICACIONES)
        /// </summary>
        public virtual SIR_Sir437AdsNotificacione SIR_Sir437AdsNotificacione { get; set; } // FK_SIR_448_ADS_DETALLE_NOTIFICACIONES_SIR_437_ADS_NOTIFICACIONES
    }

}
// </auto-generated>