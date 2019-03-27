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

    // SIR_191_VISTAS_XML
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir191VistasXml
    {
        [Required]
        [Display(Name = "N ID vista xml 191")]
        public int NIdVistaXml191 { get; set; } // nIdVistaXML191 (Primary key)

        [Required]
        [Display(Name = "N ID form 116")]
        public int NIdForm116 { get; set; } // nIdForm116

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S achivo xml")]
        public string SAchivoXml { get; set; } // sAchivoXml (length: 30)

        [Display(Name = "N ID reporte 93")]
        public int? NIdReporte93 { get; set; } // nIdReporte93

        [Required]
        [Display(Name = "N tipo plantilla")]
        public byte NTipoPlantilla { get; set; } // nTipoPlantilla

        [Display(Name = "S archivo xml web")]
        public string SArchivoXmlWeb { get; set; } // sArchivoXmlWeb

        [Display(Name = "N ID clie 07")]
        public int? NIdClie07 { get; set; } // nIdClie07

        [Display(Name = "N ID cliente")]
        public int? NIdCliente { get; set; } // nIdCliente

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S ruta plantilla excel")]
        public string SRutaPlantillaExcel { get; set; } // sRutaPlantillaExcel (length: 500)

        [Display(Name = "N fila inicio")]
        public int? NFilaInicio { get; set; } // nFilaInicio

        [Display(Name = "B incluir encabezado")]
        public bool? BIncluirEncabezado { get; set; } // bIncluirEncabezado

        [MaxLength(4)]
        [StringLength(4)]
        [Display(Name = "S separador")]
        public string SSeparador { get; set; } // sSeparador (length: 4)

        [Display(Name = "B exportar excel")]
        public bool? BExportarExcel { get; set; } // bExportarExcel

        [Display(Name = "B exportar txt")]
        public bool? BExportarTxt { get; set; } // bExportarTxt

        [Display(Name = "B exportar pdf")]
        public bool? BExportarPdf { get; set; } // bExportarPDF

        [Display(Name = "B exportar word")]
        public bool? BExportarWord { get; set; } // bExportarWord

        [MaxLength(300)]
        [StringLength(300)]
        [Display(Name = "S campo fecha notificacion")]
        public string SCampoFechaNotificacion { get; set; } // sCampoFechaNotificacion (length: 300)

        [Display(Name = "N ID usuario wa 06")]
        public int? NIdUsuarioWa06 { get; set; } // nIdUsuarioWA06

        [Display(Name = "B incluir rango fechas")]
        public bool? BIncluirRangoFechas { get; set; } // bIncluirRangoFechas

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir422NotificacionArchivo where [SIR_422_NOTIFICACION_ARCHIVOS].[nIdVistaXML191] point to this entity (FK_SIR_422_NOTIFICACION_ARCHIVOS_SIR_191_VISTAS_XML)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir422NotificacionArchivo> SIR_Sir422NotificacionArchivo { get; set; } // SIR_422_NOTIFICACION_ARCHIVOS.FK_SIR_422_NOTIFICACION_ARCHIVOS_SIR_191_VISTAS_XML

        // Foreign keys

        /// <summary>
        /// Parent Admin_Adminc07Cliente pointed by [SIR_191_VISTAS_XML].([NIdClie07]) (FK_SIR_191_VISTAS_XML_ADMINC_07_CLIENTES)
        /// </summary>
        public virtual Admin_Adminc07Cliente Admin_Adminc07Cliente { get; set; } // FK_SIR_191_VISTAS_XML_ADMINC_07_CLIENTES

        /// <summary>
        /// Parent SIR_Sir116FormatosSucursal pointed by [SIR_191_VISTAS_XML].([NIdForm116]) (FK_SIR_191_VISTAS_XML_SIR_116_FORMATOS_SUCURSAL)
        /// </summary>
        public virtual SIR_Sir116FormatosSucursal SIR_Sir116FormatosSucursal { get; set; } // FK_SIR_191_VISTAS_XML_SIR_116_FORMATOS_SUCURSAL

        /// <summary>
        /// Parent SIR_Sir93Reporte pointed by [SIR_191_VISTAS_XML].([NIdReporte93]) (FK_SIR_191_VISTAS_XML_SIR_93_REPORTES)
        /// </summary>
        public virtual SIR_Sir93Reporte SIR_Sir93Reporte { get; set; } // FK_SIR_191_VISTAS_XML_SIR_93_REPORTES

        public SIR_Sir191VistasXml()
        {
            NTipoPlantilla = 1;
            BIncluirEncabezado = true;
            SIR_Sir422NotificacionArchivo = new System.Collections.Generic.List<SIR_Sir422NotificacionArchivo>();
        }
    }

}
// </auto-generated>