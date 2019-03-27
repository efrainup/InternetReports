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

    // SIR_412_MOTIVOS_MODIFICACION_PARTES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir412MotivosModificacionParte
    {
        [Required]
        [Display(Name = "N ID motivos partes 412")]
        public int NIdMotivosPartes412 { get; set; } // nIdMotivosPartes412 (Primary key)

        [Required]
        [Display(Name = "N clave")]
        public int NClave { get; set; } // nClave

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 500)

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir413HistoricoParte where [SIR_413_HISTORICO_PARTE].[nIdMotivosPartes412] point to this entity (FK_SIR_413_HISTORICO_PARTE_SIR_412_MOTIVOS_MODIFICACION_PARTES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir413HistoricoParte> SIR_Sir413HistoricoParte { get; set; } // SIR_413_HISTORICO_PARTE.FK_SIR_413_HISTORICO_PARTE_SIR_412_MOTIVOS_MODIFICACION_PARTES
        /// <summary>
        /// Child SIR_Sir99Parte where [SIR_99_PARTES].[nIdMotivosPartes412] point to this entity (FK_SIR_99_PARTES_SIR_412_MOTIVOS_MODIFICACION_PARTES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir99Parte> SIR_Sir99Parte { get; set; } // SIR_99_PARTES.FK_SIR_99_PARTES_SIR_412_MOTIVOS_MODIFICACION_PARTES

        public SIR_Sir412MotivosModificacionParte()
        {
            SIR_Sir413HistoricoParte = new System.Collections.Generic.List<SIR_Sir413HistoricoParte>();
            SIR_Sir99Parte = new System.Collections.Generic.List<SIR_Sir99Parte>();
        }
    }

}
// </auto-generated>
