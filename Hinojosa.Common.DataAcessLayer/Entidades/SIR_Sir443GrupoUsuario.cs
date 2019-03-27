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

    // SIR_443_GRUPO_USUARIOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir443GrupoUsuario
    {
        [Required]
        [Display(Name = "N ID grupo 442")]
        public int NIdGrupo442 { get; set; } // nIdGrupo442 (Primary key)

        [Display(Name = "N ID usuario 01")]
        public int? NIdUsuario01 { get; set; } // nIdUsuario01

        [Display(Name = "N ID usuario")]
        public int? NIdUsuario { get; set; } // nIdUsuario

        // Foreign keys

        /// <summary>
        /// Parent Admin_Admina01Usuario pointed by [SIR_443_GRUPO_USUARIOS].([NIdUsuario01]) (FK_SIR_443_GRUPO_USUARIOS_ADMINA_01_USUARIOS)
        /// </summary>
        public virtual Admin_Admina01Usuario Admin_Admina01Usuario { get; set; } // FK_SIR_443_GRUPO_USUARIOS_ADMINA_01_USUARIOS

        /// <summary>
        /// Parent SIR_Sir442Grupos pointed by [SIR_443_GRUPO_USUARIOS].([NIdGrupo442]) (FK_SIR_443_GRUPO_USUARIOS_SIR_442_GRUPOS)
        /// </summary>
        public virtual SIR_Sir442Grupos SIR_Sir442Grupos { get; set; } // FK_SIR_443_GRUPO_USUARIOS_SIR_442_GRUPOS
    }

}
// </auto-generated>
