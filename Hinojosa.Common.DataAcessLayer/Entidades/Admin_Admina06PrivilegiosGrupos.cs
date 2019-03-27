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

    // ADMINA_06_PRIVILEGIOS_GRUPOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Admin_Admina06PrivilegiosGrupos
    {
        [Required]
        [Display(Name = "N ID priv gr 06")]
        public int NIdPrivGr06 { get; set; } // nIdPrivGr06 (Primary key)

        [Required]
        [Display(Name = "N ID grupo 03")]
        public int NIdGrupo03 { get; set; } // nIdGrupo03

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
        /// Parent Admin_Admina03Grupos pointed by [ADMINA_06_PRIVILEGIOS_GRUPOS].([NIdGrupo03]) (FK_ADMINA_06_PRIVILEGIOS_GRUPOS_ADMINA_03_GRUPOS)
        /// </summary>
        public virtual Admin_Admina03Grupos Admin_Admina03Grupos { get; set; } // FK_ADMINA_06_PRIVILEGIOS_GRUPOS_ADMINA_03_GRUPOS

        /// <summary>
        /// Parent Admin_Admina05Nodo pointed by [ADMINA_06_PRIVILEGIOS_GRUPOS].([NIdNodo05]) (FK_ADMINA_06_PRIVILEGIOS_GRUPOS_ADMINA_05_NODOS)
        /// </summary>
        public virtual Admin_Admina05Nodo Admin_Admina05Nodo { get; set; } // FK_ADMINA_06_PRIVILEGIOS_GRUPOS_ADMINA_05_NODOS
    }

}
// </auto-generated>