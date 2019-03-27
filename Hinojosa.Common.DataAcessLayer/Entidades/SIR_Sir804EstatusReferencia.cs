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

    // SIR_804_ESTATUS_REFERENCIA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir804EstatusReferencia
    {
        [Required]
        [Display(Name = "N ID estatus ref 804")]
        public int NIdEstatusRef804 { get; set; } // nIdEstatusRef804 (Primary key)

        [Display(Name = "N clave")]
        public int? NClave { get; set; } // nClave

        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 250)

        [Display(Name = "B activo")]
        public bool? BActivo { get; set; } // bActivo

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir60Referencia where [SIR_60_REFERENCIAS].[nIdEstatusRef804] point to this entity (FK_SIR_60_REFERENCIAS_ESTATUS_MERCANCIA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir60Referencia> SIR_Sir60Referencia { get; set; } // SIR_60_REFERENCIAS.FK_SIR_60_REFERENCIAS_ESTATUS_MERCANCIA

        public SIR_Sir804EstatusReferencia()
        {
            SIR_Sir60Referencia = new System.Collections.Generic.List<SIR_Sir60Referencia>();
        }
    }

}
// </auto-generated>