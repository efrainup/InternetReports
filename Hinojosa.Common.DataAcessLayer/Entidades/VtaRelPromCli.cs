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

    // vta_rel_prom_cli
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaRelPromCli
    {
        [Required]
        [Display(Name = "Id prom")]
        public int IdProm { get; set; } // id_prom (Primary key)

        [Required]
        [Display(Name = "Id cliente")]
        public int IdCliente { get; set; } // id_cliente (Primary key)

        public VtaRelPromCli()
        {
            IdProm = 0;
            IdCliente = 0;
        }
    }

}
// </auto-generated>
