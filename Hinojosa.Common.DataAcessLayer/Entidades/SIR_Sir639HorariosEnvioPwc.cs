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

    // SIR_639_HORARIOS_ENVIO_PWC
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir639HorariosEnvioPwc
    {
        [Required]
        [Display(Name = "N ID config pwc 638")]
        public int NIdConfigPwc638 { get; set; } // nIdConfigPWC638 (Primary key)

        [Display(Name = "N hora")]
        public short? NHora { get; set; } // nHora

        [Display(Name = "N minuto")]
        public short? NMinuto { get; set; } // nMinuto

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir638ConfiguracionPwc pointed by [SIR_639_HORARIOS_ENVIO_PWC].([NIdConfigPwc638]) (FK_SIR_639_HORARIOS_ENVIO_PWC_SIR_638_CONFIGURACION_PWC)
        /// </summary>
        public virtual SIR_Sir638ConfiguracionPwc SIR_Sir638ConfiguracionPwc { get; set; } // FK_SIR_639_HORARIOS_ENVIO_PWC_SIR_638_CONFIGURACION_PWC
    }

}
// </auto-generated>
