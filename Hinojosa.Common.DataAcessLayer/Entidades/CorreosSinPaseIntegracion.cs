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

    // Correos_SinPaseIntegracion
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CorreosSinPaseIntegracion
    {
        [Required]
        [Display(Name = "N ID")]
        public int NId { get; set; } // nId (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S referencia")]
        public string SReferencia { get; set; } // sReferencia (length: 20)

        [Required]
        [Display(Name = "N activo")]
        public int NActivo { get; set; } // nActivo

        [Required]
        [Display(Name = "N ID factura")]
        public int NIdFactura { get; set; } // nIdFactura

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha alta")]
        public System.DateTime? DFechaAlta { get; set; } // dFechaAlta

        public CorreosSinPaseIntegracion()
        {
            NActivo = 1;
            DFechaAlta = System.DateTime.Now;
        }
    }

}
// </auto-generated>
