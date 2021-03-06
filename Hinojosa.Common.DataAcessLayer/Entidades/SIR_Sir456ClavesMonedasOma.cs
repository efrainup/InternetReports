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

    // SIR_456_CLAVES_MONEDAS_OMA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir456ClavesMonedasOma
    {
        [Required]
        [Display(Name = "N ID clave moneda oma 456")]
        public int NIdClaveMonedaOma456 { get; set; } // nIdClaveMonedaOMA456 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "S clave anexo 22")]
        public string SClaveAnexo22 { get; set; } // sClaveAnexo22 (length: 3)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "S clave oma")]
        public string SClaveOma { get; set; } // sClaveOMA (length: 3)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 40)

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S descripcion cove")]
        public string SDescripcionCove { get; set; } // sDescripcionCOVE (length: 500)
    }

}
// </auto-generated>
