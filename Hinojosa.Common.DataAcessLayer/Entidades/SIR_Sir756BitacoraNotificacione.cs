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

    // SIR_756_BITACORA_NOTIFICACIONES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir756BitacoraNotificacione
    {
        [Required]
        [Display(Name = "N ID bitacora notificaciones 756")]
        public int NIdBitacoraNotificaciones756 { get; set; } // nIdBitacoraNotificaciones756 (Primary key)

        [Display(Name = "N ID notificacion 416")]
        public int? NIdNotificacion416 { get; set; } // nIdNotificacion416

        [Display(Name = "N ID usuario")]
        public int? NIdUsuario { get; set; } // nIdUsuario

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha")]
        public System.DateTime DFecha { get; set; } // dFecha

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "S mensaje log")]
        public string SMensajeLog { get; set; } // sMensajeLog

        [Required(AllowEmptyStrings = true)]
        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "S clase")]
        public string SClase { get; set; } // sClase (length: 200)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "S metodo")]
        public string SMetodo { get; set; } // sMetodo (length: 250)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S ipe quipo envia")]
        public string SIpEquipoEnvia { get; set; } // sIPEquipoEnvia (length: 50)

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S nombre notificacion")]
        public string SNombreNotificacion { get; set; } // sNombreNotificacion (length: 100)

        [Required]
        [Display(Name = "N tipo notificacion")]
        public int NTipoNotificacion { get; set; } // nTipoNotificacion

        [Required]
        [Display(Name = "N tipo modulo")]
        public int NTipoModulo { get; set; } // nTipoModulo

        [Required]
        [Display(Name = "N ID base entity")]
        public int NIdBaseEntity { get; set; } // nIdBaseEntity

        [Display(Name = "X xml")]
        public string XXml { get; set; } // xXml

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir416Notificacione pointed by [SIR_756_BITACORA_NOTIFICACIONES].([NIdNotificacion416]) (FK_SIR_756_BITACORA_NOTIFICACIONES_SIR_416_NOTIFICACIONES)
        /// </summary>
        public virtual SIR_Sir416Notificacione SIR_Sir416Notificacione { get; set; } // FK_SIR_756_BITACORA_NOTIFICACIONES_SIR_416_NOTIFICACIONES
    }

}
// </auto-generated>
