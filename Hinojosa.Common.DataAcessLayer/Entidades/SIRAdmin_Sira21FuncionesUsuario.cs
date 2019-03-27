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

    // SIRA_21_FUNCIONES_USUARIOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira21FuncionesUsuario
    {
        [Required]
        [Display(Name = "N ID funcion 20")]
        public int NIdFuncion20 { get; set; } // nIdFuncion20 (Primary key via unique index UK_SIRA_21_FUNCIONES_USUARIOS)

        [Display(Name = "N ID usuario")]
        public int? NIdUsuario { get; set; } // nIdUsuario

        [Display(Name = "N ID usu 01")]
        public int? NIdUsu01 { get; set; } // nIdUsu01

        // Foreign keys

        /// <summary>
        /// Parent Admin_Admina01Usuario pointed by [SIRA_21_FUNCIONES_USUARIOS].([NIdUsu01]) (FK_SIRA_21_FUNCIONES_USUARIOS_ADMINA_01_USUARIOS)
        /// </summary>
        public virtual Admin_Admina01Usuario Admin_Admina01Usuario { get; set; } // FK_SIRA_21_FUNCIONES_USUARIOS_ADMINA_01_USUARIOS

        /// <summary>
        /// Parent CatUsr pointed by [SIRA_21_FUNCIONES_USUARIOS].([NIdUsuario]) (FK_SIRA_21_FUNCIONES_USUARIOS_cat_usr)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIRA_21_FUNCIONES_USUARIOS_cat_usr

        /// <summary>
        /// Parent SIRAdmin_Sira20Funcione pointed by [SIRA_21_FUNCIONES_USUARIOS].([NIdFuncion20]) (FK_SIRA_21_FUNCIONES_USUARIOS_SIRA_20_FUNCIONES)
        /// </summary>
        public virtual SIRAdmin_Sira20Funcione SIRAdmin_Sira20Funcione { get; set; } // FK_SIRA_21_FUNCIONES_USUARIOS_SIRA_20_FUNCIONES
    }

}
// </auto-generated>
