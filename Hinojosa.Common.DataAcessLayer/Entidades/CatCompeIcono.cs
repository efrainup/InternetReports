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

    // cat_compe_iconos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatCompeIcono
    {
        [Required]
        [Display(Name = "Id icono")]
        public int IdIcono { get; set; } // id_icono (Primary key)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; } // nombre (length: 50)

        [MaxLength(2147483647)]
        [Display(Name = "Icono")]
        public byte[] Icono { get; set; } // icono (length: 2147483647)

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg (Primary key)

        [Display(Name = "Status")]
        public byte? Status { get; set; } // status
    }

}
// </auto-generated>