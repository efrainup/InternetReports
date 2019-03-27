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

    // SIR_574_CLIENTE_CARACTERISTICAS_GENERALES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir574ClienteCaracteristicasGenerale
    {
        [Required]
        [Display(Name = "N ID clie carac gen 574")]
        public int NIdClieCaracGen574 { get; set; } // nIdClieCaracGen574 (Primary key)

        [Required]
        [Display(Name = "N ID cliente")]
        public int NIdCliente { get; set; } // nIdCliente

        [Display(Name = "N ID clie 07")]
        public int? NIdClie07 { get; set; } // nIdClie07

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "S caracteristica")]
        public string SCaracteristica { get; set; } // sCaracteristica

        [Display(Name = "B oculta rfce xportacion")]
        public bool? BOcultaRfcExportacion { get; set; } // bOcultaRFCExportacion

        [Display(Name = "B genera archivo contigencia")]
        public bool? BGeneraArchivoContigencia { get; set; } // bGeneraArchivoContigencia

        // Foreign keys

        /// <summary>
        /// Parent CatCliente pointed by [SIR_574_CLIENTE_CARACTERISTICAS_GENERALES].([NIdCliente]) (FK_SIR_574_CLIENTE_CARACTERISTICAS_GENERALES_cat_clientes)
        /// </summary>
        public virtual CatCliente CatCliente { get; set; } // FK_SIR_574_CLIENTE_CARACTERISTICAS_GENERALES_cat_clientes
    }

}
// </auto-generated>