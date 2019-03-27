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

    // SIR_734_BITACORA_NOTIFICACION_PAGO_PEDIMENTO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir734BitacoraNotificacionPagoPedimento
    {
        [Required]
        [Display(Name = "N ID bitacora notifica pago 734")]
        public int NIdBitacoraNotificaPago734 { get; set; } // nIdBitacoraNotificaPago734 (Primary key)

        [Display(Name = "N ID referencia")]
        public int? NIdReferencia { get; set; } // nIdReferencia

        ///<summary>
        /// Valores permitidos: 
        /// 1) Enviado, 
        /// 2) No enviado
        ///</summary>
        [Display(Name = "N status")]
        public byte? NStatus { get; set; } // nStatus

        [Display(Name = "D fecha envio")]
        public System.DateTime? DFechaEnvio { get; set; } // dFechaEnvio

        [Display(Name = "N ID usuario envio")]
        public int? NIdUsuarioEnvio { get; set; } // nIdUsuarioEnvio

        [Display(Name = "S log")]
        public string SLog { get; set; } // sLog

        [Display(Name = "D fecha alta")]
        public System.DateTime? DFechaAlta { get; set; } // dFechaAlta

        [Display(Name = "N ID usuario alta")]
        public int? NIdUsuarioAlta { get; set; } // nIdUsuarioAlta

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir60Referencia pointed by [SIR_734_BITACORA_NOTIFICACION_PAGO_PEDIMENTO].([NIdReferencia]) (FK_SIR_734_BITACORA_NOTIFICACION_PAGO_PEDIMENTO_SIR_60_REFERENCIAS)
        /// </summary>
        public virtual SIR_Sir60Referencia SIR_Sir60Referencia { get; set; } // FK_SIR_734_BITACORA_NOTIFICACION_PAGO_PEDIMENTO_SIR_60_REFERENCIAS
    }

}
// </auto-generated>
