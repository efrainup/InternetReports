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

    // The table 'Movs_Sistema' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    // Movs_Sistema
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class MovsSistema
    {
        [Display(Name = "Id usuario")]
        public decimal? IdUsuario { get; set; } // IdUsuario

        [Display(Name = "Id modulo")]
        public decimal? IdModulo { get; set; } // IdModulo

        [Display(Name = "Id recurso")]
        public decimal? IdRecurso { get; set; } // IdRecurso

        [Display(Name = "Accion")]
        public string Accion { get; set; } // Accion

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha")]
        public System.DateTime? Fecha { get; set; } // Fecha
    }

}
// </auto-generated>
