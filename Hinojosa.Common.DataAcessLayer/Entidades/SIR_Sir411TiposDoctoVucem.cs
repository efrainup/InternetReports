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

    // SIR_411_TIPOS_DOCTO_VUCEM
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir411TiposDoctoVucem
    {
        [Required]
        [Display(Name = "N ID tipos 411")]
        public int NIdTipos411 { get; set; } // nIdTipos411 (Primary key)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "S clave")]
        public string SClave { get; set; } // sClave (length: 10)

        [MaxLength(300)]
        [StringLength(300)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 300)
    }

}
// </auto-generated>
