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

    // Correos_NotificaError_Gral
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CorreosNotificaErrorGral
    {
        [Required]
        [Display(Name = "N ID correo notifica")]
        public int NIdCorreoNotifica { get; set; } // nIdCorreoNotifica (Primary key)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "S correo")]
        public string SCorreo { get; set; } // sCorreo

        [Required]
        [Display(Name = "N ID documento")]
        public int NIdDocumento { get; set; } // nIdDocumento

        [Required]
        [Display(Name = "N ID adu sec")]
        public int NIdAduSec { get; set; } // nIdAduSec

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha alta")]
        public System.DateTime DFechaAlta { get; set; } // dFechaAlta

        [Display(Name = "N activo")]
        public int? NActivo { get; set; } // nActivo

        public CorreosNotificaErrorGral()
        {
            DFechaAlta = System.DateTime.Now;
            NActivo = 1;
        }
    }

}
// </auto-generated>
