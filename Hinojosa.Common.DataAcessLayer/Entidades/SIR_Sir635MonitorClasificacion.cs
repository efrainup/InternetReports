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

    // SIR_635_MONITOR_CLASIFICACION
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir635MonitorClasificacion
    {
        [Required]
        [Display(Name = "N ID monitor clasif 635")]
        public int NIdMonitorClasif635 { get; set; } // nIdMonitorClasif635 (Primary key)

        [Required]
        [Display(Name = "N ID referencia 60")]
        public int NIdReferencia60 { get; set; } // nIdReferencia60

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D orden clasifica")]
        public System.DateTime DOrdenClasifica { get; set; } // dOrdenClasifica

        [Required]
        [Display(Name = "N ID usuario envia clasificacion")]
        public int NIdUsuarioEnviaClasificacion { get; set; } // nIdUsuarioEnviaClasificacion

        [DataType(DataType.DateTime)]
        [Display(Name = "D asigna clasificacion")]
        public System.DateTime? DAsignaClasificacion { get; set; } // dAsignaClasificacion

        [Display(Name = "N ID usuario clasificacion")]
        public int? NIdUsuarioClasificacion { get; set; } // nIdUsuarioClasificacion

        [Display(Name = "N status")]
        public byte? NStatus { get; set; } // nStatus

        [Display(Name = "N cant partidas")]
        public int? NCantPartidas { get; set; } // nCantPartidas

        [DataType(DataType.DateTime)]
        [Display(Name = "D fin clasificacion")]
        public System.DateTime? DFinClasificacion { get; set; } // dFinClasificacion

        [Display(Name = "N cant facturas")]
        public int? NCantFacturas { get; set; } // nCantFacturas

        [Display(Name = "N ID usuario ed")]
        public int? NIdUsuarioEd { get; set; } // nIdUsuarioEd

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir636CausasDeRetrasoClasificacion where [SIR_636_CAUSAS_DE_RETRASO_CLASIFICACION].[nIdMonitorClasif635] point to this entity (FK_SIR_636_CAUSAS_DE_RETRASO_CLASIFICACION_SIR_635_MONITOR_CLASIFICACION)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir636CausasDeRetrasoClasificacion> SIR_Sir636CausasDeRetrasoClasificacion { get; set; } // SIR_636_CAUSAS_DE_RETRASO_CLASIFICACION.FK_SIR_636_CAUSAS_DE_RETRASO_CLASIFICACION_SIR_635_MONITOR_CLASIFICACION

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir60Referencia pointed by [SIR_635_MONITOR_CLASIFICACION].([NIdReferencia60]) (FK_SIR_635_MONITOR_CLASIFICACION_SIR_60_REFERENCIAS)
        /// </summary>
        public virtual SIR_Sir60Referencia SIR_Sir60Referencia { get; set; } // FK_SIR_635_MONITOR_CLASIFICACION_SIR_60_REFERENCIAS

        public SIR_Sir635MonitorClasificacion()
        {
            SIR_Sir636CausasDeRetrasoClasificacion = new System.Collections.Generic.List<SIR_Sir636CausasDeRetrasoClasificacion>();
        }
    }

}
// </auto-generated>
