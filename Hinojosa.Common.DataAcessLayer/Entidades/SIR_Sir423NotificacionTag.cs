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

    // SIR_423_NOTIFICACION_TAGS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir423NotificacionTag
    {
        [Required]
        [Display(Name = "N ID notificacion tag 423")]
        public int NIdNotificacionTag423 { get; set; } // nIdNotificacionTag423 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S nombre")]
        public string SNombre { get; set; } // sNombre (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S tag")]
        public string STag { get; set; } // sTag (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(8000)]
        [StringLength(8000)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 8000)

        [Display(Name = "N clave")]
        public int? NClave { get; set; } // nClave

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir419CatalogoEvento (Many-to-Many) mapped by table [SIR_424_EVENTOS_TAGS]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir419CatalogoEvento> SIR_Sir419CatalogoEvento { get; set; } // Many to many mapping

        public SIR_Sir423NotificacionTag()
        {
            SIR_Sir419CatalogoEvento = new System.Collections.Generic.List<SIR_Sir419CatalogoEvento>();
        }
    }

}
// </auto-generated>
