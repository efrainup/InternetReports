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

    // SIRA_44_CONF_PROG_SERV_SUCURSAL
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira44ConfProgServSucursal
    {
        [Required]
        [Display(Name = "N ID serv suc 44")]
        public int NIdServSuc44 { get; set; } // nIdServSuc44 (Primary key)

        [Display(Name = "N ID suc 12")]
        public int? NIdSuc12 { get; set; } // nIdSuc12

        [Display(Name = "N ID sucursal")]
        public int? NIdSucursal { get; set; } // nIdSucursal

        [Required]
        [Display(Name = "B aplica prog servicios")]
        public bool BAplicaProgServicios { get; set; } // bAplicaProgServicios

        // Reverse navigation

        /// <summary>
        /// Child SIRAdmin_Sira41ConfProgServCliente where [SIRA_41_CONF_PROG_SERV_CLIENTES].[nIdServSuc44] point to this entity (FK_SIRA_41_CONF_PROG_SERV_CLIENTES_SIRA_44_CONF_PROG_SERV_SUCURSAL)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira41ConfProgServCliente> SIRAdmin_Sira41ConfProgServCliente { get; set; } // SIRA_41_CONF_PROG_SERV_CLIENTES.FK_SIRA_41_CONF_PROG_SERV_CLIENTES_SIRA_44_CONF_PROG_SERV_SUCURSAL
        /// <summary>
        /// Child SIRAdmin_Sira42ConfProgServNaviera where [SIRA_42_CONF_PROG_SERV_NAVIERAS].[nIdServSuc44] point to this entity (FK_SIRA_42_CONF_PROG_SERV_NAVIERAS_SIRA_44_CONF_PROG_SERV_SUCURSAL)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira42ConfProgServNaviera> SIRAdmin_Sira42ConfProgServNaviera { get; set; } // SIRA_42_CONF_PROG_SERV_NAVIERAS.FK_SIRA_42_CONF_PROG_SERV_NAVIERAS_SIRA_44_CONF_PROG_SERV_SUCURSAL
        /// <summary>
        /// Child SIRAdmin_Sira43ConfProgServContenedor where [SIRA_43_CONF_PROG_SERV_CONTENEDOR].[nIdServSuc44] point to this entity (FK_SIRA_43_CONF_PROG_SERV_CONTENEDOR_SIRA_44_CONF_PROG_SERV_SUCURSAL)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira43ConfProgServContenedor> SIRAdmin_Sira43ConfProgServContenedor { get; set; } // SIRA_43_CONF_PROG_SERV_CONTENEDOR.FK_SIRA_43_CONF_PROG_SERV_CONTENEDOR_SIRA_44_CONF_PROG_SERV_SUCURSAL

        // Foreign keys

        /// <summary>
        /// Parent Admin_Admina12Sucursale pointed by [SIRA_44_CONF_PROG_SERV_SUCURSAL].([NIdSuc12]) (FK_SIRA_44_CONF_PROG_SERV_SUCURSAL_ADMINA_12_SUCURSALES)
        /// </summary>
        public virtual Admin_Admina12Sucursale Admin_Admina12Sucursale { get; set; } // FK_SIRA_44_CONF_PROG_SERV_SUCURSAL_ADMINA_12_SUCURSALES

        /// <summary>
        /// Parent McpSuc pointed by [SIRA_44_CONF_PROG_SERV_SUCURSAL].([NIdSucursal]) (FK_SIRA_44_CONF_PROG_SERV_SUCURSAL_mcp_suc)
        /// </summary>
        public virtual McpSuc McpSuc { get; set; } // FK_SIRA_44_CONF_PROG_SERV_SUCURSAL_mcp_suc

        public SIRAdmin_Sira44ConfProgServSucursal()
        {
            SIRAdmin_Sira41ConfProgServCliente = new System.Collections.Generic.List<SIRAdmin_Sira41ConfProgServCliente>();
            SIRAdmin_Sira42ConfProgServNaviera = new System.Collections.Generic.List<SIRAdmin_Sira42ConfProgServNaviera>();
            SIRAdmin_Sira43ConfProgServContenedor = new System.Collections.Generic.List<SIRAdmin_Sira43ConfProgServContenedor>();
        }
    }

}
// </auto-generated>
