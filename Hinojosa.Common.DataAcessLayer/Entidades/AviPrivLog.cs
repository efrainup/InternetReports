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

    // avi_priv_log
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class AviPrivLog
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; } // id (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(16)]
        [StringLength(16)]
        [Display(Name = "Usuario")]
        public string Usuario { get; set; } // usuario (Primary key) (length: 16)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Accion")]
        public string Accion { get; set; } // accion (Primary key) (length: 10)

        [Required]
        [Display(Name = "Id cmp")]
        public int IdCmp { get; set; } // id_cmp (Primary key)

        public AviPrivLog()
        {
            FecReg = System.DateTime.Now;
            Usuario = "";
            Accion = "";
            IdCmp = 0;
        }
    }

}
// </auto-generated>
