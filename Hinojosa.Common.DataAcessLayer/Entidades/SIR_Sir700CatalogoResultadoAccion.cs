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

    // SIR_700_CATALOGO_RESULTADO_ACCION
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir700CatalogoResultadoAccion
    {
        [Required]
        [Display(Name = "N ID cat res acc 700")]
        public int NIdCatResAcc700 { get; set; } // nIdCatResAcc700 (Primary key)

        [Required]
        [Display(Name = "N clave")]
        public int NClave { get; set; } // nClave

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S resultado observacion")]
        public string SResultadoObservacion { get; set; } // sResultadoObservacion (length: 500)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S accion solucion")]
        public string SAccionSolucion { get; set; } // sAccionSolucion (length: 500)

        [Display(Name = "B activo")]
        public bool? BActivo { get; set; } // bActivo

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir701RevisionDocumento where [SIR_701_REVISION_DOCUMENTOS].[nIdCatResAcc700] point to this entity (FK_SIR_701_REVISION_DOCUMENTOS_SIR_700_CATALOGO_RESULTADO_ACCION)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir701RevisionDocumento> SIR_Sir701RevisionDocumento { get; set; } // SIR_701_REVISION_DOCUMENTOS.FK_SIR_701_REVISION_DOCUMENTOS_SIR_700_CATALOGO_RESULTADO_ACCION

        public SIR_Sir700CatalogoResultadoAccion()
        {
            SIR_Sir701RevisionDocumento = new System.Collections.Generic.List<SIR_Sir701RevisionDocumento>();
        }
    }

}
// </auto-generated>