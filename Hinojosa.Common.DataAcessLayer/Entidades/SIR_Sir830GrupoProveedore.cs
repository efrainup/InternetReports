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

    // SIR_830_GRUPO_PROVEEDORES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir830GrupoProveedore
    {
        [Required]
        [Display(Name = "N ID grupo prov 830")]
        public int NIdGrupoProv830 { get; set; } // nIdGrupoProv830 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S clave")]
        public string SClave { get; set; } // sClave (length: 100)

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 500)

        [Required]
        [Display(Name = "B activo")]
        public bool BActivo { get; set; } // bActivo

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir421NotificacionCorreo where [SIR_421_NOTIFICACION_CORREO].[nIdGrupoProv830] point to this entity (FK_SIR_421_NOTIFICACION_CORREO_SIR_830_GRUPO_PROVEEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir421NotificacionCorreo> SIR_Sir421NotificacionCorreo { get; set; } // SIR_421_NOTIFICACION_CORREO.FK_SIR_421_NOTIFICACION_CORREO_SIR_830_GRUPO_PROVEEDORES
        /// <summary>
        /// Child SIR_Sir831RelGrupoProv where [SIR_831_REL_GRUPO_PROV].[nIdGrupoProv830] point to this entity (FK_SIR_831_REL_GRUPO_PROV_SIR_830_GRUPO_PROVEEDORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir831RelGrupoProv> SIR_Sir831RelGrupoProv { get; set; } // SIR_831_REL_GRUPO_PROV.FK_SIR_831_REL_GRUPO_PROV_SIR_830_GRUPO_PROVEEDORES

        public SIR_Sir830GrupoProveedore()
        {
            BActivo = true;
            SIR_Sir421NotificacionCorreo = new System.Collections.Generic.List<SIR_Sir421NotificacionCorreo>();
            SIR_Sir831RelGrupoProv = new System.Collections.Generic.List<SIR_Sir831RelGrupoProv>();
        }
    }

}
// </auto-generated>
