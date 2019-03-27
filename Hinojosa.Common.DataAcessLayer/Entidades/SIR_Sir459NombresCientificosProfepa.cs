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

    // SIR_459_NOMBRES_CIENTIFICOS_PROFEPA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir459NombresCientificosProfepa
    {
        [Required]
        [Display(Name = "N ID nom cientifico prof 459")]
        public int NIdNomCientificoProf459 { get; set; } // nIdNomCientificoProf459 (Primary key)

        [Required]
        [Display(Name = "N clave")]
        public int NClave { get; set; } // nClave

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S nombre cientifico")]
        public string SNombreCientifico { get; set; } // sNombreCientifico (length: 500)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S nombre comun")]
        public string SNombreComun { get; set; } // sNombreComun (length: 500)

        [Display(Name = "N tipo formato")]
        public byte? NTipoFormato { get; set; } // nTipoFormato

        [MaxLength(8)]
        [StringLength(8)]
        [Display(Name = "S fraccion piel pelo")]
        public string SFraccionPielPelo { get; set; } // sFraccionPielPelo (length: 8)

        [MaxLength(8)]
        [StringLength(8)]
        [Display(Name = "S fraccion cuero")]
        public string SFraccionCuero { get; set; } // sFraccionCuero (length: 8)

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir460PartesDescripcionExotico where [SIR_460_PARTES_DESCRIPCION_EXOTICOS].[nIdNomCientificoProf459] point to this entity (FK_SIR_460_PARTES_DESCRIPCION_EXOTICOS_SIR_459_NOMBRES_CIENTIFICOS_PROFEPA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir460PartesDescripcionExotico> SIR_Sir460PartesDescripcionExotico { get; set; } // SIR_460_PARTES_DESCRIPCION_EXOTICOS.FK_SIR_460_PARTES_DESCRIPCION_EXOTICOS_SIR_459_NOMBRES_CIENTIFICOS_PROFEPA

        public SIR_Sir459NombresCientificosProfepa()
        {
            SIR_Sir460PartesDescripcionExotico = new System.Collections.Generic.List<SIR_Sir460PartesDescripcionExotico>();
        }
    }

}
// </auto-generated>