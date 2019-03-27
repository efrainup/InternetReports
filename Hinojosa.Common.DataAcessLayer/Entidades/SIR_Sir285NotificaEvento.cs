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

    // SIR_285_NOTIFICA_EVENTOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir285NotificaEvento
    {
        [Required]
        [Display(Name = "N ID evento 285")]
        public int NIdEvento285 { get; set; } // nIdEvento285 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 100)

        [Required]
        [Display(Name = "N ID cat evento 282")]
        public int NIdCatEvento282 { get; set; } // nIdCatEvento282

        [Required]
        [Display(Name = "N orden")]
        public int NOrden { get; set; } // nOrden

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir286NotificaPermiso where [SIR_286_NOTIFICA_PERMISOS].[nIdEvento285] point to this entity (FK_SIR_286_NOTIFICA_PERMISOS_SIR_285_NOTIFICA_EVENTOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir286NotificaPermiso> SIR_Sir286NotificaPermiso { get; set; } // SIR_286_NOTIFICA_PERMISOS.FK_SIR_286_NOTIFICA_PERMISOS_SIR_285_NOTIFICA_EVENTOS
        /// <summary>
        /// Child SIR_Sir287NotificaProgramada where [SIR_287_NOTIFICA_PROGRAMADAS].[nIdEvento285] point to this entity (FK_SIR_287_NOTIFICA_PROGRAMADAS_SIR_285_NOTIFICA_EVENTOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir287NotificaProgramada> SIR_Sir287NotificaProgramada { get; set; } // SIR_287_NOTIFICA_PROGRAMADAS.FK_SIR_287_NOTIFICA_PROGRAMADAS_SIR_285_NOTIFICA_EVENTOS

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir282NotificaCategoria pointed by [SIR_285_NOTIFICA_EVENTOS].([NIdCatEvento282]) (FK_SIR_285_NOTIFICA_EVENTOS_SIR_282_NOTIFICA_CATEGORIAS)
        /// </summary>
        public virtual SIR_Sir282NotificaCategoria SIR_Sir282NotificaCategoria { get; set; } // FK_SIR_285_NOTIFICA_EVENTOS_SIR_282_NOTIFICA_CATEGORIAS

        public SIR_Sir285NotificaEvento()
        {
            SIR_Sir286NotificaPermiso = new System.Collections.Generic.List<SIR_Sir286NotificaPermiso>();
            SIR_Sir287NotificaProgramada = new System.Collections.Generic.List<SIR_Sir287NotificaProgramada>();
        }
    }

}
// </auto-generated>