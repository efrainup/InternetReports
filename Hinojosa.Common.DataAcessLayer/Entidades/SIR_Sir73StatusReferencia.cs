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

    // SIR_73_STATUS_REFERENCIAS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir73StatusReferencia
    {
        [Required]
        [Display(Name = "N ID status 73")]
        public int NIdStatus73 { get; set; } // nIdStatus73 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(180)]
        [StringLength(180)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 180)

        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "S clave")]
        public string SClave { get; set; } // sClave (length: 3)

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir60Referencia where [SIR_60_REFERENCIAS].[nIdStatus73] point to this entity (FK_SIR_60_REFERENCIAS_SIR_73_STATUS_REFERENCIAS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir60Referencia> SIR_Sir60Referencia { get; set; } // SIR_60_REFERENCIAS.FK_SIR_60_REFERENCIAS_SIR_73_STATUS_REFERENCIAS

        public SIR_Sir73StatusReferencia()
        {
            SIR_Sir60Referencia = new System.Collections.Generic.List<SIR_Sir60Referencia>();
        }
    }

}
// </auto-generated>
