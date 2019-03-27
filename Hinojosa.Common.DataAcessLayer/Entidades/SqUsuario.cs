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

    // SQ_Usuarios
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SqUsuario
    {
        [Required]
        [Display(Name = "N ID usuario")]
        public int NIdUsuario { get; set; } // nIdUsuario (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S usuario")]
        public string SUsuario { get; set; } // sUsuario (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "S password")]
        public string SPassword { get; set; } // sPassword (length: 15)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "S nombre")]
        public string SNombre { get; set; } // sNombre (length: 25)

        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "S apellido p")]
        public string SApellidoP { get; set; } // sApellidoP (length: 25)

        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "S apellido m")]
        public string SApellidoM { get; set; } // sApellidoM (length: 25)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S correo")]
        public string SCorreo { get; set; } // sCorreo (length: 30)

        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "S telefono")]
        public string STelefono { get; set; } // sTelefono (length: 25)

        [Display(Name = "B activo")]
        public bool? BActivo { get; set; } // bActivo

        [Display(Name = "N ID usuario alta")]
        public int? NIdUsuarioAlta { get; set; } // nIdUsuarioAlta

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha alta")]
        public System.DateTime DFechaAlta { get; set; } // dFechaAlta

        [Display(Name = "N ID usuario edicion")]
        public int? NIdUsuarioEdicion { get; set; } // nIdUsuarioEdicion

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime? DFechaEdicion { get; set; } // dFechaEdicion

        [Display(Name = "N ID usuario baja")]
        public int? NIdUsuarioBaja { get; set; } // nIdUsuarioBaja

        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "S motivo baja")]
        public string SMotivoBaja { get; set; } // sMotivoBaja (length: 250)

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha baja")]
        public System.DateTime? DFechaBaja { get; set; } // dFechaBaja

        [Required]
        [Display(Name = "N ID tipo usuario")]
        public int NIdTipoUsuario { get; set; } // nIdTipoUsuario

        [Display(Name = "N ID cliente")]
        public int? NIdCliente { get; set; } // nIdCliente

        [Display(Name = "N cambiar password")]
        public int? NCambiarPassword { get; set; } // nCambiarPassword

        public SqUsuario()
        {
            DFechaAlta = System.DateTime.Now;
            NIdTipoUsuario = 1;
            NCambiarPassword = 0;
        }
    }

}
// </auto-generated>
