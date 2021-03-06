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

    // SIR_299_ARCHIVOS_FACTURAS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir299ArchivosFactura
    {
        [Required]
        [Display(Name = "N ID arch fac 299")]
        public int NIdArchFac299 { get; set; } // nIdArchFac299 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S archivo")]
        public string SArchivo { get; set; } // sArchivo (length: 30)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S ruta archivo")]
        public string SRutaArchivo { get; set; } // sRutaArchivo (length: 500)

        [Required]
        [Display(Name = "D fecha")]
        public System.DateTime DFecha { get; set; } // dFecha

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N tipo")]
        public byte NTipo { get; set; } // nTipo

        [Display(Name = "N ID cliente")]
        public int? NIdCliente { get; set; } // nIdCliente

        [Display(Name = "S lista archivos")]
        public string SListaArchivos { get; set; } // sListaArchivos

        [Display(Name = "N ID clie 07")]
        public int? NIdClie07 { get; set; } // nIdClie07

        [Display(Name = "N ID referencia 60")]
        public int? NIdReferencia60 { get; set; } // nIdReferencia60

        [Display(Name = "B procesado")]
        public int? BProcesado { get; set; } // bProcesado

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir52Factura where [SIR_52_FACTURAS].[nIdArchFac299] point to this entity (FK_SIR_52_FACTURAS_SIR_299_ARCHIVOS_FACTURAS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir52Factura> SIR_Sir52Factura { get; set; } // SIR_52_FACTURAS.FK_SIR_52_FACTURAS_SIR_299_ARCHIVOS_FACTURAS

        // Foreign keys

        /// <summary>
        /// Parent Admin_Adminc07Cliente pointed by [SIR_299_ARCHIVOS_FACTURAS].([NIdClie07]) (FK_SIR_299_ARCHIVOS_FACTURAS_ADMINC_07_CLIENTES)
        /// </summary>
        public virtual Admin_Adminc07Cliente Admin_Adminc07Cliente { get; set; } // FK_SIR_299_ARCHIVOS_FACTURAS_ADMINC_07_CLIENTES

        /// <summary>
        /// Parent CatCliente pointed by [SIR_299_ARCHIVOS_FACTURAS].([NIdCliente]) (FK_SIR_299_ARCHIVOS_FACTURAS_cat_clientes)
        /// </summary>
        public virtual CatCliente CatCliente { get; set; } // FK_SIR_299_ARCHIVOS_FACTURAS_cat_clientes

        /// <summary>
        /// Parent SIR_Sir60Referencia pointed by [SIR_299_ARCHIVOS_FACTURAS].([NIdReferencia60]) (FK_SIR_299_ARCHIVOS_FACTURAS_SIR_60_REFERENCIAS)
        /// </summary>
        public virtual SIR_Sir60Referencia SIR_Sir60Referencia { get; set; } // FK_SIR_299_ARCHIVOS_FACTURAS_SIR_60_REFERENCIAS

        public SIR_Sir299ArchivosFactura()
        {
            DFechaEdicion = System.DateTime.Now;
            NTipo = 3;
            SIR_Sir52Factura = new System.Collections.Generic.List<SIR_Sir52Factura>();
        }
    }

}
// </auto-generated>
