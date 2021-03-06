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

    // SIR_585_HISTORIAL_DESCARGAS_LINKS_EFILE
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir585HistorialDescargasLinksEfile
    {
        [Required]
        [Display(Name = "N ID historial links efile 585")]
        public int NIdHistorialLinksEfile585 { get; set; } // nIdHistorialLinksEfile585 (Primary key)

        [Required]
        [Display(Name = "N ID docto archivo 35")]
        public int NIdDoctoArchivo35 { get; set; } // nIdDoctoArchivo35

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha descarga")]
        public System.DateTime? DFechaDescarga { get; set; } // dFechaDescarga

        [Display(Name = "B descargado")]
        public bool? BDescargado { get; set; } // bDescargado

        [Display(Name = "S observaciones")]
        public string SObservaciones { get; set; } // sObservaciones

        [Display(Name = "N ID clie 07")]
        public int? NIdClie07 { get; set; } // nIdClie07

        [Display(Name = "N ID cliente")]
        public int? NIdCliente { get; set; } // nIdCliente

        // Foreign keys

        /// <summary>
        /// Parent Admin_Adminc07Cliente pointed by [SIR_585_HISTORIAL_DESCARGAS_LINKS_EFILE].([NIdClie07]) (FK_SIR_585_HISTORIAL_DESCARGAS_LINKS_EFILE_ADMINC_07_CLIENTES)
        /// </summary>
        public virtual Admin_Adminc07Cliente Admin_Adminc07Cliente { get; set; } // FK_SIR_585_HISTORIAL_DESCARGAS_LINKS_EFILE_ADMINC_07_CLIENTES

        /// <summary>
        /// Parent CatCliente pointed by [SIR_585_HISTORIAL_DESCARGAS_LINKS_EFILE].([NIdCliente]) (FK_SIR_585_HISTORIAL_DESCARGAS_LINKS_EFILE_cat_clientes)
        /// </summary>
        public virtual CatCliente CatCliente { get; set; } // FK_SIR_585_HISTORIAL_DESCARGAS_LINKS_EFILE_cat_clientes

        /// <summary>
        /// Parent SIR_Sir35DocumentosArchivo pointed by [SIR_585_HISTORIAL_DESCARGAS_LINKS_EFILE].([NIdDoctoArchivo35]) (FK_SIR_585_HISTORIAL_DESCARGAS_LINKS_EFILE_SIR_35_DOCUMENTOS_ARCHIVOS)
        /// </summary>
        public virtual SIR_Sir35DocumentosArchivo SIR_Sir35DocumentosArchivo { get; set; } // FK_SIR_585_HISTORIAL_DESCARGAS_LINKS_EFILE_SIR_35_DOCUMENTOS_ARCHIVOS
    }

}
// </auto-generated>
