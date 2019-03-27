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

    // SIR_15_DEPENDENCIAS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir15Dependencia
    {
        [Required]
        [Display(Name = "N ID dep sec 15")]
        public int NIdDepSec15 { get; set; } // nIdDepSec15 (Primary key)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "S clave")]
        public string SClave { get; set; } // sClave (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "S nombre")]
        public string SNombre { get; set; } // sNombre (length: 200)

        [Required]
        [Display(Name = "B es vigente")]
        public bool BEsVigente { get; set; } // bEsVigente

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir69IdentificadorPermiso where [SIR_69_IDENTIFICADOR_PERMISOS].[nIdDepSec15] point to this entity (FK_SIR_69_IDENTIFICADOR_PERMISOS_SIR_15_DEPENDENCIAS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir69IdentificadorPermiso> SIR_Sir69IdentificadorPermiso { get; set; } // SIR_69_IDENTIFICADOR_PERMISOS.FK_SIR_69_IDENTIFICADOR_PERMISOS_SIR_15_DEPENDENCIAS

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_15_DEPENDENCIAS].([NIdUsuarioEd]) (FK_SIR_15_DEPENDENCIAS_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_15_DEPENDENCIAS_cat_usr_ed

        public SIR_Sir15Dependencia()
        {
            BEsVigente = true;
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            SIR_Sir69IdentificadorPermiso = new System.Collections.Generic.List<SIR_Sir69IdentificadorPermiso>();
        }
    }

}
// </auto-generated>
