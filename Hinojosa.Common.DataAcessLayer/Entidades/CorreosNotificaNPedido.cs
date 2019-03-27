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

    // Correos_Notifica_NPedido
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CorreosNotificaNPedido
    {
        [Required]
        [Display(Name = "N ID notifica np")]
        public int NIdNotificaNp { get; set; } // nIdNotificaNP (Primary key)

        [Required]
        [Display(Name = "N ID cliente")]
        public int NIdCliente { get; set; } // nIdCliente

        [Required]
        [Display(Name = "N ID adu sec")]
        public int NIdAduSec { get; set; } // nIdAduSec

        [Display(Name = "S correos")]
        public string SCorreos { get; set; } // sCorreos

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha alta")]
        public System.DateTime DFechaAlta { get; set; } // dFechaAlta

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime? DFechaEdicion { get; set; } // dFechaEdicion

        public CorreosNotificaNPedido()
        {
            DFechaAlta = System.DateTime.Now;
        }
    }

}
// </auto-generated>