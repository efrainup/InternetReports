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

    // cat_tra_equ_galeria
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatTraEquGaleria
    {
        [Required]
        [Display(Name = "Id galeria")]
        public int IdGaleria { get; set; } // id_galeria (Primary key)

        [Required]
        [Display(Name = "Id equipo")]
        public int IdEquipo { get; set; } // id_equipo

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Archivo")]
        public string Archivo { get; set; } // archivo (length: 250)

        [Required]
        [Display(Name = "Imagen")]
        public byte[] Imagen { get; set; } // imagen

        public CatTraEquGaleria()
        {
            IdEquipo = 0;
            Archivo = "";
        }
    }

}
// </auto-generated>
