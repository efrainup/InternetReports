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

    // Correos_Clientes_LF
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CorreosClientesLf
    {
        [Required]
        [Display(Name = "N ID correo")]
        public int NIdCorreo { get; set; } // nIdCorreo (Primary key)

        [Required]
        [Display(Name = "N ID cliente")]
        public int NIdCliente { get; set; } // nIdCliente

        [Required(AllowEmptyStrings = true)]
        [MaxLength(150)]
        [StringLength(150)]
        [Display(Name = "S contacto")]
        public string SContacto { get; set; } // sContacto (length: 150)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(150)]
        [StringLength(150)]
        [Display(Name = "S correo")]
        public string SCorreo { get; set; } // sCorreo (length: 150)

        [Required]
        [Display(Name = "N tipo operacion")]
        public int NTipoOperacion { get; set; } // nTipoOperacion

        [Required]
        [Display(Name = "N activo")]
        public int NActivo { get; set; } // nActivo

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha alta")]
        public System.DateTime DFechaAlta { get; set; } // dFechaAlta

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime? DFechaEdicion { get; set; } // dFechaEdicion

        [Display(Name = "N env altamira")]
        public int? NEnvAltamira { get; set; } // nEnvAltamira

        [Display(Name = "N env reynosa")]
        public int? NEnvReynosa { get; set; } // nEnvReynosa

        [Display(Name = "N env manzanillo")]
        public int? NEnvManzanillo { get; set; } // nEnvManzanillo

        [Display(Name = "N env matamoros")]
        public int? NEnvMatamoros { get; set; } // nEnvMatamoros

        [Display(Name = "N env laredo")]
        public int? NEnvLaredo { get; set; } // nEnvLaredo

        [Display(Name = "N env veracruz")]
        public int? NEnvVeracruz { get; set; } // nEnvVeracruz

        [Display(Name = "N env lazaro")]
        public int? NEnvLazaro { get; set; } // nEnvLazaro

        public CorreosClientesLf()
        {
            NTipoOperacion = 0;
            NActivo = 1;
            DFechaAlta = System.DateTime.Now;
            NEnvAltamira = 0;
            NEnvReynosa = 0;
            NEnvManzanillo = 0;
            NEnvMatamoros = 0;
            NEnvLaredo = 0;
        }
    }

}
// </auto-generated>
