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

    // MT_Catalogo_GastosExpo_Mabe
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class MtCatalogoGastosExpoMabe
    {
        [Required]
        [Display(Name = "N ID gasto")]
        public int NIdGasto { get; set; } // nIdGasto (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S codigo")]
        public string SCodigo { get; set; } // sCodigo (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(150)]
        [StringLength(150)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 150)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S aplicacion")]
        public string SAplicacion { get; set; } // sAplicacion (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S cliente expo")]
        public string SClienteExpo { get; set; } // sClienteExpo (length: 50)

        [Required]
        [Display(Name = "N activo")]
        public int NActivo { get; set; } // nActivo

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha alta")]
        public System.DateTime DFechaAlta { get; set; } // dFechaAlta

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S moneda")]
        public string SMoneda { get; set; } // sMoneda (length: 50)

        public MtCatalogoGastosExpoMabe()
        {
            NActivo = 1;
            DFechaAlta = System.DateTime.Now;
        }
    }

}
// </auto-generated>