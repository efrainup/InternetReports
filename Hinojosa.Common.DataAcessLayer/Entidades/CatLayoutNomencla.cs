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

    // cat_layoutNomencla
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatLayoutNomencla
    {
        [Required]
        [Display(Name = "Id cfd")]
        public long IdCfd { get; set; } // id_cfd (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(256)]
        [StringLength(256)]
        [Display(Name = "Campo")]
        public string Campo { get; set; } // campo (Primary key) (length: 256)

        [Required]
        [Display(Name = "Orden")]
        public long Orden { get; set; } // orden (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Tipo dato")]
        public string TipoDato { get; set; } // tipo_dato (Primary key) (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Longitud dato")]
        public string LongitudDato { get; set; } // longitud_dato (Primary key) (length: 100)

        public CatLayoutNomencla()
        {
            IdCfd = 0;
            Campo = "";
            Orden = 0;
            TipoDato = "";
            LongitudDato = "";
        }
    }

}
// </auto-generated>
