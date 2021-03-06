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

    // The table 'SW_05_USUARIOS_CLIENTES' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    // SW_05_USUARIOS_CLIENTES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRWEB_Sw05UsuariosCliente
    {
        [Display(Name = "N ID usuario")]
        public int? NIdUsuario { get; set; } // nIdUsuario

        [Display(Name = "N ID usu 01")]
        public int? NIdUsu01 { get; set; } // nIdUsu01

        [Display(Name = "N ID cliente")]
        public int? NIdCliente { get; set; } // nIdCliente

        [Display(Name = "N ID clie 07")]
        public int? NIdClie07 { get; set; } // nIdClie07

        // Foreign keys

        /// <summary>
        /// Parent Admin_Admina01Usuario pointed by [SW_05_USUARIOS_CLIENTES].([NIdUsu01]) (FK_SW_05_USUARIOS_CLIENTES_ADMINA_01_USUARIOS)
        /// </summary>
        public virtual Admin_Admina01Usuario Admin_Admina01Usuario { get; set; } // FK_SW_05_USUARIOS_CLIENTES_ADMINA_01_USUARIOS

        /// <summary>
        /// Parent Admin_Adminc07Cliente pointed by [SW_05_USUARIOS_CLIENTES].([NIdClie07]) (FK_SW_05_USUARIOS_CLIENTES_ADMINC_07_CLIENTES)
        /// </summary>
        public virtual Admin_Adminc07Cliente Admin_Adminc07Cliente { get; set; } // FK_SW_05_USUARIOS_CLIENTES_ADMINC_07_CLIENTES

        /// <summary>
        /// Parent CatCliente pointed by [SW_05_USUARIOS_CLIENTES].([NIdCliente]) (FK_SW_05_USUARIOS_CLIENTES_cat_clientes)
        /// </summary>
        public virtual CatCliente CatCliente { get; set; } // FK_SW_05_USUARIOS_CLIENTES_cat_clientes

        /// <summary>
        /// Parent CatUsr pointed by [SW_05_USUARIOS_CLIENTES].([NIdUsuario]) (FK_SW_05_USUARIOS_CLIENTES_cat_usr)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SW_05_USUARIOS_CLIENTES_cat_usr
    }

}
// </auto-generated>
