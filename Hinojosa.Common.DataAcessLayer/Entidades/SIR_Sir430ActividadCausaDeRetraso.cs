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

    // SIR_430_ACTIVIDAD_CAUSA_DE_RETRASO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir430ActividadCausaDeRetraso
    {
        [Required]
        [Display(Name = "N ID causa retraso 429")]
        public int NIdCausaRetraso429 { get; set; } // nIdCausaRetraso429 (Primary key)

        [Required]
        [Display(Name = "N ID actividad etapa 405")]
        public int NIdActividadEtapa405 { get; set; } // nIdActividadEtapa405 (Primary key)

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha")]
        public System.DateTime? DFecha { get; set; } // dFecha

        [Display(Name = "N ID usuario")]
        public int? NIdUsuario { get; set; } // nIdUsuario

        [Display(Name = "N ID usuario 01")]
        public int? NIdUsuario01 { get; set; } // nIdUsuario01

        // Foreign keys

        /// <summary>
        /// Parent Admin_Admina01Usuario pointed by [SIR_430_ACTIVIDAD_CAUSA_DE_RETRASO].([NIdUsuario01]) (FK_SIR_430_ACTIVIDAD_CAUSA_DE_RETRASO_ADMINA_01_USUARIOS)
        /// </summary>
        public virtual Admin_Admina01Usuario Admin_Admina01Usuario { get; set; } // FK_SIR_430_ACTIVIDAD_CAUSA_DE_RETRASO_ADMINA_01_USUARIOS

        /// <summary>
        /// Parent SIR_Sir405ActividadesDeEtapa pointed by [SIR_430_ACTIVIDAD_CAUSA_DE_RETRASO].([NIdActividadEtapa405]) (FK_SIR_430_ACTIVIDAD_CAUSA_DE_RETRASO_SIR_405_ACTIVIDADES_DE_ETAPA)
        /// </summary>
        public virtual SIR_Sir405ActividadesDeEtapa SIR_Sir405ActividadesDeEtapa { get; set; } // FK_SIR_430_ACTIVIDAD_CAUSA_DE_RETRASO_SIR_405_ACTIVIDADES_DE_ETAPA

        /// <summary>
        /// Parent SIR_Sir429CausasDeRetraso pointed by [SIR_430_ACTIVIDAD_CAUSA_DE_RETRASO].([NIdCausaRetraso429]) (FK_SIR_430_ACTIVIDAD_CAUSA_DE_RETRASO_SIR_429_CAUSAS_DE_RETRASO)
        /// </summary>
        public virtual SIR_Sir429CausasDeRetraso SIR_Sir429CausasDeRetraso { get; set; } // FK_SIR_430_ACTIVIDAD_CAUSA_DE_RETRASO_SIR_429_CAUSAS_DE_RETRASO
    }

}
// </auto-generated>