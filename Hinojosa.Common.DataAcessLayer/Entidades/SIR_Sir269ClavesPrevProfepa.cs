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

    // SIR_269_CLAVES_PREV_PROFEPA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir269ClavesPrevProfepa
    {
        [Required]
        [Display(Name = "N ID pre prof 269")]
        public int NIdPreProf269 { get; set; } // nIdPrePROF269 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "S clave prevalidador")]
        public string SClavePrevalidador { get; set; } // sClavePrevalidador (length: 5)

        [Required]
        [Display(Name = "N clave asociacion")]
        public byte NClaveAsociacion { get; set; } // nClaveAsociacion

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 100)

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir273Profepa where [SIR_273_PROFEPA].[nIdPrePROF269] point to this entity (FK_SIR_273_PROFEPA_SIR_269_CLAVES_PREV_PROFEPA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir273Profepa> SIR_Sir273Profepa { get; set; } // SIR_273_PROFEPA.FK_SIR_273_PROFEPA_SIR_269_CLAVES_PREV_PROFEPA

        public SIR_Sir269ClavesPrevProfepa()
        {
            SIR_Sir273Profepa = new System.Collections.Generic.List<SIR_Sir273Profepa>();
        }
    }

}
// </auto-generated>