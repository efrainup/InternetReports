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

    // T_CodigosPostales_SAT
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TCodigosPostalesSat
    {
        [Required]
        [Display(Name = "Id cp")]
        public int IdCp { get; set; } // id_cp (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "C codigo postal")]
        public string CCodigoPostal { get; set; } // c_CodigoPostal (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "C estado")]
        public string CEstado { get; set; } // c_Estado (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "C municipio")]
        public string CMunicipio { get; set; } // c_Municipio (length: 5)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "C localidad")]
        public string CLocalidad { get; set; } // c_Localidad (length: 5)
    }

}
// </auto-generated>
