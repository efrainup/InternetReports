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

    // SIRA_22_CLIENTES_SUCURSALES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira22ClientesSucursale
    {
        [Required]
        [Display(Name = "N ID cliente")]
        public int NIdCliente { get; set; } // nIdCliente (Primary key)

        [Required]
        [Display(Name = "N ID sucursal")]
        public int NIdSucursal { get; set; } // nIdSucursal (Primary key)

        [Required]
        [Display(Name = "B fact agencia")]
        public bool BFactAgencia { get; set; } // bFactAgencia (Primary key)

        [Display(Name = "B utilizar croquis")]
        public bool? BUtilizarCroquis { get; set; } // bUtilizarCroquis

        // Foreign keys

        /// <summary>
        /// Parent McpSuc pointed by [SIRA_22_CLIENTES_SUCURSALES].([NIdSucursal]) (FK_SIRA_22_CLIENTE_SUCURSAL_mcp_suc)
        /// </summary>
        public virtual McpSuc McpSuc { get; set; } // FK_SIRA_22_CLIENTE_SUCURSAL_mcp_suc
    }

}
// </auto-generated>