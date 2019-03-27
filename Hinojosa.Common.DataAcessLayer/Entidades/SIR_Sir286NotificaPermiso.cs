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

    // SIR_286_NOTIFICA_PERMISOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir286NotificaPermiso
    {
        [Required]
        [Display(Name = "N ID evento 285")]
        public int NIdEvento285 { get; set; } // nIdEvento285 (Primary key)

        [Required]
        [Display(Name = "N ID usuario")]
        public int NIdUsuario { get; set; } // nIdUsuario (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_286_NOTIFICA_PERMISOS].([NIdUsuario]) (FK_SIR_286_NOTIFICA_PERMISOS_cat_usr)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_286_NOTIFICA_PERMISOS_cat_usr

        /// <summary>
        /// Parent SIR_Sir285NotificaEvento pointed by [SIR_286_NOTIFICA_PERMISOS].([NIdEvento285]) (FK_SIR_286_NOTIFICA_PERMISOS_SIR_285_NOTIFICA_EVENTOS)
        /// </summary>
        public virtual SIR_Sir285NotificaEvento SIR_Sir285NotificaEvento { get; set; } // FK_SIR_286_NOTIFICA_PERMISOS_SIR_285_NOTIFICA_EVENTOS

        public SIR_Sir286NotificaPermiso()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
        }
    }

}
// </auto-generated>
