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

    // SIRA_34_CATALOGOS_CLIENTES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira34CatalogosCliente
    {
        [Required]
        [Display(Name = "N ID cat cli 34")]
        public int NIdCatCli34 { get; set; } // nIdCatCli34 (Primary key)

        [Display(Name = "N ID cliente")]
        public int? NIdCliente { get; set; } // nIdCliente

        [Required(AllowEmptyStrings = true)]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "S catalogo")]
        public string SCatalogo { get; set; } // sCatalogo (length: 3)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 500)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S tabla sir")]
        public string STablaSir { get; set; } // sTablaSIR (length: 50)

        [Display(Name = "N ID clie 07")]
        public int? NIdClie07 { get; set; } // nIdClie07

        // Reverse navigation

        /// <summary>
        /// Child SIRAdmin_Sira35CamposCatCliente where [SIRA_35_CAMPOS_CAT_CLIENTES].[nIdCatCli34] point to this entity (FK_SIRA_35_CAMPOS_CAT_CLIENTES_SIRA_34_CATALOGOS_CLIENTES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira35CamposCatCliente> SIRAdmin_Sira35CamposCatCliente { get; set; } // SIRA_35_CAMPOS_CAT_CLIENTES.FK_SIRA_35_CAMPOS_CAT_CLIENTES_SIRA_34_CATALOGOS_CLIENTES

        // Foreign keys

        /// <summary>
        /// Parent Admin_Adminc07Cliente pointed by [SIRA_34_CATALOGOS_CLIENTES].([NIdClie07]) (FK_SIRA_34_CATALOGOS_CLIENTES_ADMINC_07_CLIENTES)
        /// </summary>
        public virtual Admin_Adminc07Cliente Admin_Adminc07Cliente { get; set; } // FK_SIRA_34_CATALOGOS_CLIENTES_ADMINC_07_CLIENTES

        /// <summary>
        /// Parent CatCliente pointed by [SIRA_34_CATALOGOS_CLIENTES].([NIdCliente]) (FK_SIRA_34_CATALOGOS_CLIENTES_cat_clientes)
        /// </summary>
        public virtual CatCliente CatCliente { get; set; } // FK_SIRA_34_CATALOGOS_CLIENTES_cat_clientes

        public SIRAdmin_Sira34CatalogosCliente()
        {
            SIRAdmin_Sira35CamposCatCliente = new System.Collections.Generic.List<SIRAdmin_Sira35CamposCatCliente>();
        }
    }

}
// </auto-generated>