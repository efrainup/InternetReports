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

    // SIR_673_SOLICITUD_SED
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir673SolicitudSed
    {
        [Required]
        [Display(Name = "N ID solicitud sed 673")]
        public int NIdSolicitudSed673 { get; set; } // nIdSolicitudSED673 (Primary key)

        [Display(Name = "N tipo sed")]
        public byte? NTipoSed { get; set; } // nTipoSED

        [Display(Name = "B requiere licencia")]
        public bool? BRequiereLicencia { get; set; } // bRequiereLicencia

        [Display(Name = "N tipo documento")]
        public byte? NTipoDocumento { get; set; } // nTipoDocumento

        [Display(Name = "N ID usuario orden solicitud")]
        public int? NIdUsuarioOrdenSolicitud { get; set; } // nIdUsuarioOrdenSolicitud

        [DataType(DataType.DateTime)]
        [Display(Name = "D orden solicitud")]
        public System.DateTime? DOrdenSolicitud { get; set; } // dOrdenSolicitud

        [Display(Name = "N ID usuario asigna solicitud")]
        public int? NIdUsuarioAsignaSolicitud { get; set; } // nIdUsuarioAsignaSolicitud

        [DataType(DataType.DateTime)]
        [Display(Name = "D asigna solicitud")]
        public System.DateTime? DAsignaSolicitud { get; set; } // dAsignaSolicitud

        [Display(Name = "N ID usuario finaliza")]
        public int? NIdUsuarioFinaliza { get; set; } // nIdUsuarioFinaliza

        [DataType(DataType.DateTime)]
        [Display(Name = "D finalizacion sed")]
        public System.DateTime? DFinalizacionSed { get; set; } // dFinalizacionSED

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir60Referencia where [SIR_60_REFERENCIAS].[nIdSolicitudSED673] point to this entity (FK_SIR_60_REFERENCIAS_SIR_673_SOLICITUD_SED)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir60Referencia> SIR_Sir60Referencia { get; set; } // SIR_60_REFERENCIAS.FK_SIR_60_REFERENCIAS_SIR_673_SOLICITUD_SED
        /// <summary>
        /// Child SIR_Sir674SolicitudSedCausaDeRetraso where [SIR_674_SOLICITUD_SED_CAUSA_DE_RETRASO].[nIdSolicitudSED673] point to this entity (FK_SIR_674_SOLICITUD_SED_CAUSA_DE_RETRASO_SIR_673_SOLICITUD_SED)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir674SolicitudSedCausaDeRetraso> SIR_Sir674SolicitudSedCausaDeRetraso { get; set; } // SIR_674_SOLICITUD_SED_CAUSA_DE_RETRASO.FK_SIR_674_SOLICITUD_SED_CAUSA_DE_RETRASO_SIR_673_SOLICITUD_SED

        public SIR_Sir673SolicitudSed()
        {
            SIR_Sir60Referencia = new System.Collections.Generic.List<SIR_Sir60Referencia>();
            SIR_Sir674SolicitudSedCausaDeRetraso = new System.Collections.Generic.List<SIR_Sir674SolicitudSedCausaDeRetraso>();
        }
    }

}
// </auto-generated>
