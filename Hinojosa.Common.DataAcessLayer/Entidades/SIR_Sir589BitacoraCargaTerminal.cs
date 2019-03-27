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

    // SIR_589_BITACORA_CARGA_TERMINAL
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir589BitacoraCargaTerminal
    {
        [Required]
        [Display(Name = "N ID bitacora 589")]
        public int NIdBitacora589 { get; set; } // nIdBitacora589 (Primary key)

        [Required]
        [Display(Name = "N ID periodo 588")]
        public int NIdPeriodo588 { get; set; } // nIdPeriodo588

        [Display(Name = "N ID terminal")]
        public int? NIdTerminal { get; set; } // nIdTerminal

        [Display(Name = "N ID terminal 42")]
        public int? NIdTerminal42 { get; set; } // nIdTerminal42

        [Display(Name = "N ton impo cs")]
        public decimal? NTonImpoCs { get; set; } // nTonImpoCS

        [Display(Name = "N ton expo cs")]
        public decimal? NTonExpoCs { get; set; } // nTonExpoCS

        [Display(Name = "N ton impo c 20")]
        public decimal? NTonImpoC20 { get; set; } // nTonImpoC20

        [Display(Name = "N ton expo c 20")]
        public decimal? NTonExpoC20 { get; set; } // nTonExpoC20

        [Display(Name = "N ton impo c 40")]
        public decimal? NTonImpoC40 { get; set; } // nTonImpoC40

        [Display(Name = "N ton expo c 40")]
        public decimal? NTonExpoC40 { get; set; } // nTonExpoC40

        // Foreign keys

        /// <summary>
        /// Parent Admin_Adminc42Proveedore pointed by [SIR_589_BITACORA_CARGA_TERMINAL].([NIdTerminal42]) (FK_SIR_589_BITACORA_CARGA_TERMINAL_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual Admin_Adminc42Proveedore Admin_Adminc42Proveedore { get; set; } // FK_SIR_589_BITACORA_CARGA_TERMINAL_ADMINC_42_PROVEEDORES

        /// <summary>
        /// Parent SIR_Sir588PeriodoCargaTerminal pointed by [SIR_589_BITACORA_CARGA_TERMINAL].([NIdPeriodo588]) (FK_SIR_589_BITACORA_CARGA_TERMINAL_SIR_588_PERIODO_CARGA_TERMINAL)
        /// </summary>
        public virtual SIR_Sir588PeriodoCargaTerminal SIR_Sir588PeriodoCargaTerminal { get; set; } // FK_SIR_589_BITACORA_CARGA_TERMINAL_SIR_588_PERIODO_CARGA_TERMINAL
    }

}
// </auto-generated>