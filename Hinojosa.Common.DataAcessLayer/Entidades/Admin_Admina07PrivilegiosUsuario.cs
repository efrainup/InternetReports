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

    // ADMINA_07_PRIVILEGIOS_USUARIOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Admin_Admina07PrivilegiosUsuario
    {
        [Required]
        [Display(Name = "N ID priv usu 07")]
        public int NIdPrivUsu07 { get; set; } // nIdPrivUsu07 (Primary key)

        [Required]
        [Display(Name = "N ID usu 01")]
        public int NIdUsu01 { get; set; } // nIdUsu01

        [Required]
        [Display(Name = "N ID nodo 05")]
        public int NIdNodo05 { get; set; } // nIdNodo05

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
        /// Parent Admin_Admina01Usuario pointed by [ADMINA_07_PRIVILEGIOS_USUARIOS].([NIdUsu01]) (FK_ADMINA_07_PRIVILEGIOS_USUARIOS_ADMINA_01_USUARIOS)
        /// </summary>
        public virtual Admin_Admina01Usuario Admin_Admina01Usuario { get; set; } // FK_ADMINA_07_PRIVILEGIOS_USUARIOS_ADMINA_01_USUARIOS

        /// <summary>
        /// Parent Admin_Admina05Nodo pointed by [ADMINA_07_PRIVILEGIOS_USUARIOS].([NIdNodo05]) (FK_ADMINA_07_PRIVILEGIOS_USUARIOS_ADMINA_05_NODOS)
        /// </summary>
        public virtual Admin_Admina05Nodo Admin_Admina05Nodo { get; set; } // FK_ADMINA_07_PRIVILEGIOS_USUARIOS_ADMINA_05_NODOS
    }

}
// </auto-generated>
