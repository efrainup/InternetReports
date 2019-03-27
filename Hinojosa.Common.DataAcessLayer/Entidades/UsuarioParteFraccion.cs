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

    // usuario_parte_fraccion
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class UsuarioParteFraccion
    {
        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Num pte")]
        public string NumPte { get; set; } // num_pte (Primary key) (length: 50)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Fraccion")]
        public string Fraccion { get; set; } // fraccion (length: 50)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Estatus")]
        public string Estatus { get; set; } // Estatus (length: 10)
    }

}
// </auto-generated>