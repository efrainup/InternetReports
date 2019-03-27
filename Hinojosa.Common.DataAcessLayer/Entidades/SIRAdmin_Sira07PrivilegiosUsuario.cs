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

    // SIRA_07_PRIVILEGIOS_USUARIOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira07PrivilegiosUsuario
    {
        [Required]
        [Display(Name = "N ID pus is 07")]
        public int NIdPuSis07 { get; set; } // nIdPUSis07 (Primary key)

        [Required]
        [Display(Name = "N ID usuario")]
        public int NIdUsuario { get; set; } // nIdUsuario

        [Required]
        [Display(Name = "N ID nodo")]
        public int NIdNodo { get; set; } // nIdNodo

        [Required]
        [Display(Name = "B leer")]
        public bool BLeer { get; set; } // bLeer

        [Required]
        [Display(Name = "B editar")]
        public bool BEditar { get; set; } // bEditar

        [Required]
        [Display(Name = "B borrar")]
        public bool BBorrar { get; set; } // bBorrar

        [Required]
        [Display(Name = "B agregar")]
        public bool BAgregar { get; set; } // bAgregar

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIRA_07_PRIVILEGIOS_USUARIOS].([NIdUsuario]) (FK_SIRA_07_PRIVILEGIOS_USUARIOS_cat_usr)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIRA_07_PRIVILEGIOS_USUARIOS_cat_usr

        /// <summary>
        /// Parent SisRecurso pointed by [SIRA_07_PRIVILEGIOS_USUARIOS].([NIdNodo]) (FK_SIRA_07_PRIVILEGIOS_USUARIOS_sis_recursos)
        /// </summary>
        public virtual SisRecurso SisRecurso { get; set; } // FK_SIRA_07_PRIVILEGIOS_USUARIOS_sis_recursos
    }

}
// </auto-generated>
