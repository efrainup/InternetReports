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

    // SIR_598_INDICES_BOVEDAS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir598IndicesBoveda
    {
        [Required]
        [Display(Name = "N ID indice boveda 598")]
        public int NIdIndiceBoveda598 { get; set; } // nIdIndiceBoveda598 (Primary key)

        [Required]
        [Display(Name = "N clave")]
        public int NClave { get; set; } // nClave

        [Required(AllowEmptyStrings = true)]
        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "S nombre")]
        public string SNombre { get; set; } // sNombre (length: 200)

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha alta")]
        public System.DateTime? DFechaAlta { get; set; } // dFechaAlta

        [Display(Name = "N ID usuario ed")]
        public int? NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime? DFechaEdicion { get; set; } // dFechaEdicion

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir599Boveda where [SIR_599_BOVEDAS].[nIdIndiceBoveda1] point to this entity (FK_SIR_599_BOVEDAS_SIR_598_INDICES_BOVEDAS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir599Boveda> SIR_Sir599Boveda_NIdIndiceBoveda1 { get; set; } // SIR_599_BOVEDAS.FK_SIR_599_BOVEDAS_SIR_598_INDICES_BOVEDAS
        /// <summary>
        /// Child SIR_Sir599Boveda where [SIR_599_BOVEDAS].[nIdIndiceBoveda2] point to this entity (FK_SIR_599__BOVEDAS_SIR_598_INDICES_BOVEDAS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir599Boveda> SIR_Sir599Boveda_NIdIndiceBoveda2 { get; set; } // SIR_599_BOVEDAS.FK_SIR_599__BOVEDAS_SIR_598_INDICES_BOVEDAS
        /// <summary>
        /// Child SIR_Sir599Boveda where [SIR_599_BOVEDAS].[nIdIndiceBoveda3] point to this entity (FK_SIR_599_BOVEDAS_SIR_598_INDICES_BOVEDAS_3)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir599Boveda> SIR_Sir599Boveda_NIdIndiceBoveda3 { get; set; } // SIR_599_BOVEDAS.FK_SIR_599_BOVEDAS_SIR_598_INDICES_BOVEDAS_3
        /// <summary>
        /// Child SIR_Sir599Boveda where [SIR_599_BOVEDAS].[nIdIndiceBoveda4] point to this entity (FK_SIR_599_BOVEDAS_SIR_598_INDICES_BOVEDAS_4)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir599Boveda> SIR_Sir599Boveda_NIdIndiceBoveda4 { get; set; } // SIR_599_BOVEDAS.FK_SIR_599_BOVEDAS_SIR_598_INDICES_BOVEDAS_4
        /// <summary>
        /// Child SIR_Sir749RelacionBovedaIndice where [SIR_749_RELACION_BOVEDA_INDICE].[nIdIndiceBoveda598] point to this entity (FK_SIR_749_RELACION_BOVEDA_SIR_598_INDICES_BOVEDAS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir749RelacionBovedaIndice> SIR_Sir749RelacionBovedaIndice { get; set; } // SIR_749_RELACION_BOVEDA_INDICE.FK_SIR_749_RELACION_BOVEDA_SIR_598_INDICES_BOVEDAS
        /// <summary>
        /// Child SIR_Sir750IndiceValor where [SIR_750_INDICE_VALOR].[nIdIndiceBoveda598] point to this entity (FK_SIR_750_INDICE_VALOR_SIR_598_INDICES_BOVEDAS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir750IndiceValor> SIR_Sir750IndiceValor { get; set; } // SIR_750_INDICE_VALOR.FK_SIR_750_INDICE_VALOR_SIR_598_INDICES_BOVEDAS

        public SIR_Sir598IndicesBoveda()
        {
            SIR_Sir599Boveda_NIdIndiceBoveda1 = new System.Collections.Generic.List<SIR_Sir599Boveda>();
            SIR_Sir599Boveda_NIdIndiceBoveda2 = new System.Collections.Generic.List<SIR_Sir599Boveda>();
            SIR_Sir599Boveda_NIdIndiceBoveda3 = new System.Collections.Generic.List<SIR_Sir599Boveda>();
            SIR_Sir599Boveda_NIdIndiceBoveda4 = new System.Collections.Generic.List<SIR_Sir599Boveda>();
            SIR_Sir749RelacionBovedaIndice = new System.Collections.Generic.List<SIR_Sir749RelacionBovedaIndice>();
            SIR_Sir750IndiceValor = new System.Collections.Generic.List<SIR_Sir750IndiceValor>();
        }
    }

}
// </auto-generated>
