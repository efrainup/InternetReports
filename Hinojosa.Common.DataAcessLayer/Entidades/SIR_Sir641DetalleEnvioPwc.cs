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

    // SIR_641_DETALLE_ENVIO_PWC
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir641DetalleEnvioPwc
    {
        [Required]
        [Display(Name = "N ID detalle envio 641")]
        public int NIdDetalleEnvio641 { get; set; } // nIdDetalleEnvio641 (Primary key)

        [Required]
        [Display(Name = "N ID bitacora envio 640")]
        public int NIdBitacoraEnvio640 { get; set; } // nIdBitacoraEnvio640

        [Required(AllowEmptyStrings = true)]
        [MaxLength(3000)]
        [StringLength(3000)]
        [Display(Name = "S documento")]
        public string SDocumento { get; set; } // sDocumento (length: 3000)

        [Required]
        [Display(Name = "N tipo")]
        public byte NTipo { get; set; } // nTipo

        [Required]
        [Display(Name = "N status")]
        public byte NStatus { get; set; } // nStatus

        [Display(Name = "S mensaje")]
        public string SMensaje { get; set; } // sMensaje

        [Required]
        [Display(Name = "N ID referencia 60")]
        public int NIdReferencia60 { get; set; } // nIdReferencia60

        [Required(AllowEmptyStrings = true)]
        [MaxLength(64)]
        [StringLength(64)]
        [Display(Name = "S numero de referencia")]
        public string SNumeroDeReferencia { get; set; } // sNumeroDeReferencia (length: 64)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(7)]
        [StringLength(7)]
        [Display(Name = "S numero de pedimento")]
        public string SNumeroDePedimento { get; set; } // sNumeroDePedimento (length: 7)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D envio")]
        public System.DateTime DEnvio { get; set; } // dEnvio

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir640BitacoraEnvioPwc pointed by [SIR_641_DETALLE_ENVIO_PWC].([NIdBitacoraEnvio640]) (FK_SIR_641_DETALLE_ENVIO_PWC_SIR_640_BITACORA_ENVIO_PWC)
        /// </summary>
        public virtual SIR_Sir640BitacoraEnvioPwc SIR_Sir640BitacoraEnvioPwc { get; set; } // FK_SIR_641_DETALLE_ENVIO_PWC_SIR_640_BITACORA_ENVIO_PWC
    }

}
// </auto-generated>
