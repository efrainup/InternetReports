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

    // The table 'Cat_EmpFoto' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    // Cat_EmpFoto
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatEmpFoto
    {
        [Display(Name = "Id")]
        public decimal? Id { get; set; } // id

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Id entidad")]
        public string IdEntidad { get; set; } // IdEntidad (length: 50)

        [MaxLength(2147483647)]
        [Display(Name = "Foto")]
        public byte[] Foto { get; set; } // Foto (length: 2147483647)

        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha")]
        public System.DateTime? Fecha { get; set; } // Fecha
    }

}
// </auto-generated>
