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

    // bit_hos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class BitHo
    {
        [Required]
        [Display(Name = "Id bit")]
        public int IdBit { get; set; } // id_bit (Primary key)

        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; } // ID

        [Required(AllowEmptyStrings = true)]
        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "Tabla")]
        public string Tabla { get; set; } // tabla (length: 128)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required(AllowEmptyStrings = true)]
        [MaxLength(4000)]
        [StringLength(4000)]
        [Display(Name = "Error message")]
        public string ErrorMessage { get; set; } // ErrorMessage (length: 4000)

        [Required]
        [Display(Name = "Error number")]
        public int ErrorNumber { get; set; } // ErrorNumber

        [Required]
        [Display(Name = "Error severity")]
        public int ErrorSeverity { get; set; } // ErrorSeverity

        [Required(AllowEmptyStrings = true)]
        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "Error procedure")]
        public string ErrorProcedure { get; set; } // ErrorProcedure (length: 128)

        [Required]
        [Display(Name = "Error line")]
        public int ErrorLine { get; set; } // ErrorLine

        [Required]
        [Display(Name = "Error state")]
        public int ErrorState { get; set; } // ErrorState

        public BitHo()
        {
            Id = 0;
            Tabla = "";
            ErrorMessage = "";
            ErrorNumber = 0;
            ErrorSeverity = 0;
            ErrorProcedure = "";
            ErrorLine = 0;
            ErrorState = 0;
        }
    }

}
// </auto-generated>