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

    // SIR_196_TIPOS_FURGON
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir196TiposFurgon
    {
        [Required]
        [Display(Name = "N ID tipo furgon 196")]
        public int NIdTipoFurgon196 { get; set; } // nIdTipoFurgon196 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S clave")]
        public string SClave { get; set; } // sClave (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 100)

        [Required]
        [Display(Name = "N tipo")]
        public byte NTipo { get; set; } // nTipo

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir197Furgone where [SIR_197_FURGONES].[nIdTipoFurgon196] point to this entity (FK_SIR_197_FURGONES_SIR_196_TIPOS_FURGON)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir197Furgone> SIR_Sir197Furgone { get; set; } // SIR_197_FURGONES.FK_SIR_197_FURGONES_SIR_196_TIPOS_FURGON

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_196_TIPOS_FURGON].([NIdUsuarioEd]) (FK_SIR_196_TIPOS_FURGON_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_196_TIPOS_FURGON_cat_usr_ed

        public SIR_Sir196TiposFurgon()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            SIR_Sir197Furgone = new System.Collections.Generic.List<SIR_Sir197Furgone>();
        }
    }

}
// </auto-generated>
