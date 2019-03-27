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

    // SIR_342_RFC_PEDIMENTOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir342RfcPedimento
    {
        [Required]
        [Display(Name = "N ID rfc ped 342")]
        public int NIdRfcPed342 { get; set; } // nIdRfcPed342 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(120)]
        [StringLength(120)]
        [Display(Name = "S razon social")]
        public string SRazonSocial { get; set; } // sRazonSocial (length: 120)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(13)]
        [StringLength(13)]
        [Display(Name = "S rfc")]
        public string SRfc { get; set; } // sRFC (length: 13)

        [Required]
        [Display(Name = "B default")]
        public bool BDefault { get; set; } // bDefault

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir153FirmasElectronica where [SIR_153_FIRMAS_ELECTRONICAS].[nIdRfcPed342] point to this entity (FK_SIR_153_FIRMAS_ELECTRONICAS_SIR_342_RFC_PEDIMENTOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir153FirmasElectronica> SIR_Sir153FirmasElectronica { get; set; } // SIR_153_FIRMAS_ELECTRONICAS.FK_SIR_153_FIRMAS_ELECTRONICAS_SIR_342_RFC_PEDIMENTOS
        /// <summary>
        /// Child SIR_Sir789FacturaraCliente where [SIR_789_FACTURARA_CLIENTES].[nIdRfcPed342] point to this entity (FK_SIR_789_FACTURARA_CLIENTES_SIR_342_RFC_PEDIMENTOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir789FacturaraCliente> SIR_Sir789FacturaraCliente { get; set; } // SIR_789_FACTURARA_CLIENTES.FK_SIR_789_FACTURARA_CLIENTES_SIR_342_RFC_PEDIMENTOS

        public SIR_Sir342RfcPedimento()
        {
            BDefault = false;
            SIR_Sir153FirmasElectronica = new System.Collections.Generic.List<SIR_Sir153FirmasElectronica>();
            SIR_Sir789FacturaraCliente = new System.Collections.Generic.List<SIR_Sir789FacturaraCliente>();
        }
    }

}
// </auto-generated>