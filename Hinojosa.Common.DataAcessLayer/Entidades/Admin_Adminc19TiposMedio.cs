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

    // ADMINC_19_TIPOS_MEDIOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Admin_Adminc19TiposMedio
    {
        [Required]
        [Display(Name = "N ID tipo medio 19")]
        public int NIdTipoMedio19 { get; set; } // nIdTipoMedio19 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 25)

        [Required]
        [Display(Name = "B status")]
        public bool BStatus { get; set; } // bStatus

        // Reverse navigation

        /// <summary>
        /// Child Admin_Adminc39AgentesAduanalesMed where [ADMINC_39_AGENTES_ADUANALES_MED].[nIdTipoMedio19] point to this entity (FK_ADMINC_39_AGENTES_ADUANALES_MED_ADMINC_19_TIPOS_MEDIOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Admin_Adminc39AgentesAduanalesMed> Admin_Adminc39AgentesAduanalesMed { get; set; } // ADMINC_39_AGENTES_ADUANALES_MED.FK_ADMINC_39_AGENTES_ADUANALES_MED_ADMINC_19_TIPOS_MEDIOS
        /// <summary>
        /// Child Admin_Adminc44ProveedoresMedio where [ADMINC_44_PROVEEDORES_MEDIOS].[nIdTipoMedio19] point to this entity (FK_ADMINC_44_PROVEEDORES_MEDIOS_ADMINC_19_TIPOS_MEDIOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Admin_Adminc44ProveedoresMedio> Admin_Adminc44ProveedoresMedio { get; set; } // ADMINC_44_PROVEEDORES_MEDIOS.FK_ADMINC_44_PROVEEDORES_MEDIOS_ADMINC_19_TIPOS_MEDIOS
        /// <summary>
        /// Child Admin_Adminc51ClientesMedio where [ADMINC_51_CLIENTES_MEDIOS].[nIdTipoMedio19] point to this entity (FK_ADMINC_51_CLIENTES_MEDIOS_ADMINC_19_TIPOS_MEDIOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Admin_Adminc51ClientesMedio> Admin_Adminc51ClientesMedio { get; set; } // ADMINC_51_CLIENTES_MEDIOS.FK_ADMINC_51_CLIENTES_MEDIOS_ADMINC_19_TIPOS_MEDIOS

        public Admin_Adminc19TiposMedio()
        {
            Admin_Adminc39AgentesAduanalesMed = new System.Collections.Generic.List<Admin_Adminc39AgentesAduanalesMed>();
            Admin_Adminc44ProveedoresMedio = new System.Collections.Generic.List<Admin_Adminc44ProveedoresMedio>();
            Admin_Adminc51ClientesMedio = new System.Collections.Generic.List<Admin_Adminc51ClientesMedio>();
        }
    }

}
// </auto-generated>