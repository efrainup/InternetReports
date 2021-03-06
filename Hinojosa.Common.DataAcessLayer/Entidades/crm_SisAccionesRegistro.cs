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

    // sis_acciones_registros
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_SisAccionesRegistro
    {
        [Required]
        [Display(Name = "Id acciones registros")]
        public int IdAccionesRegistros { get; set; } // id_acciones_registros (Primary key)

        [Required]
        [Display(Name = "Id tipo registro")]
        public int IdTipoRegistro { get; set; } // id_tipo_registro

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Accion")]
        public string Accion { get; set; } // accion (length: 25)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Orden")]
        public string Orden { get; set; } // orden (length: 5)

        public crm_SisAccionesRegistro()
        {
            IdTipoRegistro = 0;
            Accion = "";
            Orden = "0";
        }
    }

}
// </auto-generated>
