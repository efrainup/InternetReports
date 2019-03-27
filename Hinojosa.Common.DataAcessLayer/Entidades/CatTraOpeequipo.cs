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

    // cat_tra_opeequipo
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatTraOpeequipo
    {
        [Required]
        [Display(Name = "Id equipo")]
        public int IdEquipo { get; set; } // id_equipo (Primary key)

        [Required]
        [Display(Name = "Id operador")]
        public int IdOperador { get; set; } // id_operador (Primary key)

        [Required]
        [Display(Name = "Defaul")]
        public int Defaul { get; set; } // defaul (Primary key)

        public CatTraOpeequipo()
        {
            IdEquipo = 0;
            IdOperador = 0;
            Defaul = 0;
        }
    }

}
// </auto-generated>
