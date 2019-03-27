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

    // SIR_640_BITACORA_ENVIO_PWC
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir640BitacoraEnvioPwc
    {
        [Required]
        [Display(Name = "N ID bitacora envio 640")]
        public int NIdBitacoraEnvio640 { get; set; } // nIdBitacoraEnvio640 (Primary key)

        [Required]
        [Display(Name = "N ID config pwc 638")]
        public int NIdConfigPwc638 { get; set; } // nIdConfigPWC638

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D progamada de envio")]
        public System.DateTime DProgamadaDeEnvio { get; set; } // dProgamadaDeEnvio

        [Required]
        [Display(Name = "N status")]
        public byte NStatus { get; set; } // nStatus

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir641DetalleEnvioPwc where [SIR_641_DETALLE_ENVIO_PWC].[nIdBitacoraEnvio640] point to this entity (FK_SIR_641_DETALLE_ENVIO_PWC_SIR_640_BITACORA_ENVIO_PWC)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir641DetalleEnvioPwc> SIR_Sir641DetalleEnvioPwc { get; set; } // SIR_641_DETALLE_ENVIO_PWC.FK_SIR_641_DETALLE_ENVIO_PWC_SIR_640_BITACORA_ENVIO_PWC

        public SIR_Sir640BitacoraEnvioPwc()
        {
            SIR_Sir641DetalleEnvioPwc = new System.Collections.Generic.List<SIR_Sir641DetalleEnvioPwc>();
        }
    }

}
// </auto-generated>