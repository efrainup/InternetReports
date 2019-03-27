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

    // SIR_731_ACTAS_MUESTREO_ALEATORIO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir731ActasMuestreoAleatorio
    {
        [Required]
        [Display(Name = "N ID acta muestreo 731")]
        public int NIdActaMuestreo731 { get; set; } // nIdActaMuestreo731 (Primary key)

        [Required]
        [Display(Name = "N ID mtra sel ale 67")]
        public int NIdMtraSelAle67 { get; set; } // nIdMtraSelAle67

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S numero acta")]
        public string SNumeroActa { get; set; } // sNumeroActa (length: 50)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha acta")]
        public System.DateTime DFechaActa { get; set; } // dFechaActa

        [Required]
        [Display(Name = "N ID fac part agrupada 100")]
        public int NIdFacPartAgrupada100 { get; set; } // nIdFacPartAgrupada100

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "D fad eterminada")]
        public string DFaDeterminada { get; set; } // dFADeterminada (length: 10)

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha escaneo")]
        public System.DateTime? DFechaEscaneo { get; set; } // dFechaEscaneo

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha captura")]
        public System.DateTime? DFechaCaptura { get; set; } // dFechaCaptura

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha recepcion")]
        public System.DateTime? DFechaRecepcion { get; set; } // dFechaRecepcion

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir100FacPartAgrupada pointed by [SIR_731_ACTAS_MUESTREO_ALEATORIO].([NIdFacPartAgrupada100]) (FK_SIR_731_ACTAS_MUESTREO_ALEATORIO_SIR_100_FAC_PART_AGRUPADAS)
        /// </summary>
        public virtual SIR_Sir100FacPartAgrupada SIR_Sir100FacPartAgrupada { get; set; } // FK_SIR_731_ACTAS_MUESTREO_ALEATORIO_SIR_100_FAC_PART_AGRUPADAS

        /// <summary>
        /// Parent SIR_Sir67MtraSelecAleatoria pointed by [SIR_731_ACTAS_MUESTREO_ALEATORIO].([NIdMtraSelAle67]) (FK_SIR_731_ACTAS_MUESTREO_ALEATORIO_SIR_67_MTRA_SELEC_ALEATORIA)
        /// </summary>
        public virtual SIR_Sir67MtraSelecAleatoria SIR_Sir67MtraSelecAleatoria { get; set; } // FK_SIR_731_ACTAS_MUESTREO_ALEATORIO_SIR_67_MTRA_SELEC_ALEATORIA
    }

}
// </auto-generated>