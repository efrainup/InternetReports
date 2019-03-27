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

    // SIR_680_ETAPAS_MONITOR_EJECUTIVO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir680EtapasMonitorEjecutivo
    {
        [Required]
        [Display(Name = "N ID etapa monitor ejecutivo 680")]
        public int NIdEtapaMonitorEjecutivo680 { get; set; } // nIdEtapaMonitorEjecutivo680 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S nombre")]
        public string SNombre { get; set; } // sNombre (length: 50)

        [Required]
        [Display(Name = "N clave etapa")]
        public int NClaveEtapa { get; set; } // nClaveEtapa

        [Required]
        [Display(Name = "N orden")]
        public int NOrden { get; set; } // nOrden

        [Required]
        [Display(Name = "N tipo operacion")]
        public int NTipoOperacion { get; set; } // nTipoOperacion

        [Required]
        [Display(Name = "N ID tipo trafico 25")]
        public int NIdTipoTrafico25 { get; set; } // nIdTipoTrafico25

        [Display(Name = "N dias completar")]
        public int? NDiasCompletar { get; set; } // nDiasCompletar

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S urli magen activo")]
        public string SUrlImagenActivo { get; set; } // sURLImagenActivo (length: 500)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S urli magen stop")]
        public string SUrlImagenStop { get; set; } // sURLImagenStop (length: 500)

        [Display(Name = "N ID etapa monitor ejecutivo depende 680")]
        public int? NIdEtapaMonitorEjecutivoDepende680 { get; set; } // nIdEtapaMonitorEjecutivoDepende680

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir680EtapasMonitorEjecutivo where [SIR_680_ETAPAS_MONITOR_EJECUTIVO].[nIdEtapaMonitorEjecutivoDepende680] point to this entity (FK_SIR_680_ETAPAS_MONITOR_EJECUTIVO_SIR_680_ETAPAS_MONITOR_EJECUTIVO_Depende)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir680EtapasMonitorEjecutivo> SIR_Sir680EtapasMonitorEjecutivo2 { get; set; } // SIR_680_ETAPAS_MONITOR_EJECUTIVO.FK_SIR_680_ETAPAS_MONITOR_EJECUTIVO_SIR_680_ETAPAS_MONITOR_EJECUTIVO_Depende
        /// <summary>
        /// Child SIR_Sir681EtapasMonitorEjecutivoReferencia where [SIR_681_ETAPAS_MONITOR_EJECUTIVO_REFERENCIA].[nIdEtapaMonitorEjecutivo680] point to this entity (FK_SIR_681_ETAPAS_MONITOR_EJECUTIVO_REFERENCIA_SIR_680_ETAPAS_MONITOR_EJECUTIVO)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir681EtapasMonitorEjecutivoReferencia> SIR_Sir681EtapasMonitorEjecutivoReferencia { get; set; } // SIR_681_ETAPAS_MONITOR_EJECUTIVO_REFERENCIA.FK_SIR_681_ETAPAS_MONITOR_EJECUTIVO_REFERENCIA_SIR_680_ETAPAS_MONITOR_EJECUTIVO

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir25TiposTrafico pointed by [SIR_680_ETAPAS_MONITOR_EJECUTIVO].([NIdTipoTrafico25]) (FK_SIR_680_ETAPAS_MONITOR_EJECUTIVO_SIR_25_TIPOS_TRAFICO)
        /// </summary>
        public virtual SIR_Sir25TiposTrafico SIR_Sir25TiposTrafico { get; set; } // FK_SIR_680_ETAPAS_MONITOR_EJECUTIVO_SIR_25_TIPOS_TRAFICO

        /// <summary>
        /// Parent SIR_Sir680EtapasMonitorEjecutivo pointed by [SIR_680_ETAPAS_MONITOR_EJECUTIVO].([NIdEtapaMonitorEjecutivoDepende680]) (FK_SIR_680_ETAPAS_MONITOR_EJECUTIVO_SIR_680_ETAPAS_MONITOR_EJECUTIVO_Depende)
        /// </summary>
        public virtual SIR_Sir680EtapasMonitorEjecutivo SIR_Sir680EtapasMonitorEjecutivo1 { get; set; } // FK_SIR_680_ETAPAS_MONITOR_EJECUTIVO_SIR_680_ETAPAS_MONITOR_EJECUTIVO_Depende

        public SIR_Sir680EtapasMonitorEjecutivo()
        {
            SIR_Sir680EtapasMonitorEjecutivo2 = new System.Collections.Generic.List<SIR_Sir680EtapasMonitorEjecutivo>();
            SIR_Sir681EtapasMonitorEjecutivoReferencia = new System.Collections.Generic.List<SIR_Sir681EtapasMonitorEjecutivoReferencia>();
        }
    }

}
// </auto-generated>
