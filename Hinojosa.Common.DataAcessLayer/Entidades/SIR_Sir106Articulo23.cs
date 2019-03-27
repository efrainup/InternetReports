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

    // SIR_106_ARTICULO_23
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir106Articulo23
    {
        [Required]
        [Display(Name = "N ID articulo 106")]
        public int NIdArticulo106 { get; set; } // nIdArticulo106 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S folio solicitud")]
        public string SFolioSolicitud { get; set; } // sFolioSolicitud (length: 20)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Required]
        [Display(Name = "N status vig")]
        public byte NStatusVig { get; set; } // nStatusVig

        [Required]
        [Display(Name = "N registro")]
        public int NRegistro { get; set; } // nRegistro

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir76Contenedore where [SIR_76_CONTENEDORES].[nIdArticulo106] point to this entity (FK_SIR_76_CONTENEDORES_SIR_106_ARTICULO_23)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir76Contenedore> SIR_Sir76Contenedore { get; set; } // SIR_76_CONTENEDORES.FK_SIR_76_CONTENEDORES_SIR_106_ARTICULO_23

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_106_ARTICULO_23].([NIdUsuarioEd]) (FK_SIR_106_ARTICULO_23_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_106_ARTICULO_23_cat_usr_ed

        public SIR_Sir106Articulo23()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            NStatusVig = 1;
            SIR_Sir76Contenedore = new System.Collections.Generic.List<SIR_Sir76Contenedore>();
        }
    }

}
// </auto-generated>
