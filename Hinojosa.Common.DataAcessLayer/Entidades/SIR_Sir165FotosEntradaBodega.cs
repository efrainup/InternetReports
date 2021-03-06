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

    // SIR_165_FOTOS_ENTRADA_BODEGA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir165FotosEntradaBodega
    {
        [Required]
        [Display(Name = "N ID foto ent 165")]
        public int NIdFotoEnt165 { get; set; } // nIdFotoEnt165 (Primary key)

        [Required]
        [Display(Name = "N ID entrada 156")]
        public int NIdEntrada156 { get; set; } // nIdEntrada156

        [Display(Name = "S archivo")]
        public string SArchivo { get; set; } // sArchivo

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S ruta")]
        public string SRuta { get; set; } // sRuta (length: 500)

        ///<summary>
        /// getdate()
        ///</summary>
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        ///<summary>
        /// 0
        ///</summary>
        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Display(Name = "N ID docto archivo 35")]
        public int? NIdDoctoArchivo35 { get; set; } // nIdDoctoArchivo35

        [Display(Name = "N ID tipo docto 62")]
        public int? NIdTipoDocto62 { get; set; } // nIdTipoDocto62

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_165_FOTOS_ENTRADA_BODEGA].([NIdUsuarioEd]) (FK_SIR_165_FOTOS_ENTRADA_BODEGA_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_165_FOTOS_ENTRADA_BODEGA_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir156EntradasBodega pointed by [SIR_165_FOTOS_ENTRADA_BODEGA].([NIdEntrada156]) (FK_SIR_165_FOTOS_ENTRADA_BODEGA_SIR_156_ENTRADAS_BODEGAS)
        /// </summary>
        public virtual SIR_Sir156EntradasBodega SIR_Sir156EntradasBodega { get; set; } // FK_SIR_165_FOTOS_ENTRADA_BODEGA_SIR_156_ENTRADAS_BODEGAS

        /// <summary>
        /// Parent SIR_Sir35DocumentosArchivo pointed by [SIR_165_FOTOS_ENTRADA_BODEGA].([NIdDoctoArchivo35]) (FK_SIR_165_FOTOS_ENTRADA_BODEGA_SIR_35_DOCUMENTOS_ARCHIVOS)
        /// </summary>
        public virtual SIR_Sir35DocumentosArchivo SIR_Sir35DocumentosArchivo { get; set; } // FK_SIR_165_FOTOS_ENTRADA_BODEGA_SIR_35_DOCUMENTOS_ARCHIVOS
    }

}
// </auto-generated>
