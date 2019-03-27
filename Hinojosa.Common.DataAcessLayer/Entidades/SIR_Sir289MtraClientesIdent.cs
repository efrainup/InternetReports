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

    // SIR_289_MTRA_CLIENTES_IDENT
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir289MtraClientesIdent
    {
        [Required]
        [Display(Name = "N ID cli iden 289")]
        public int NIdCliIden289 { get; set; } // nIdCliIden289 (Primary key)

        [Display(Name = "N ID cliente")]
        public int? NIdCliente { get; set; } // nIdCliente

        [Display(Name = "N ID clave docto 28")]
        public int? NIdClaveDocto28 { get; set; } // nIdClaveDocto28

        [Display(Name = "N tipo operacion")]
        public byte? NTipoOperacion { get; set; } // nTipoOperacion

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Display(Name = "N folio")]
        public int? NFolio { get; set; } // nFolio

        [Display(Name = "N ID clie 07")]
        public int? NIdClie07 { get; set; } // nIdClie07

        [Display(Name = "B aplica solo rt")]
        public bool? BAplicaSoloRt { get; set; } // bAplicaSoloRT

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir256ClientesIdentificadore where [SIR_256_CLIENTES_IDENTIFICADORES].[nIdCliIden289] point to this entity (FK_SIR_256_CLIENTES_IDENTIFICADORES_SIR_289_MTRA_CLIENTES_IDENT)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir256ClientesIdentificadore> SIR_Sir256ClientesIdentificadore { get; set; } // SIR_256_CLIENTES_IDENTIFICADORES.FK_SIR_256_CLIENTES_IDENTIFICADORES_SIR_289_MTRA_CLIENTES_IDENT

        // Foreign keys

        /// <summary>
        /// Parent Admin_Adminc07Cliente pointed by [SIR_289_MTRA_CLIENTES_IDENT].([NIdClie07]) (FK_SIR_289_MTRA_CLIENTES_IDENT_ADMINC_07_CLIENTES)
        /// </summary>
        public virtual Admin_Adminc07Cliente Admin_Adminc07Cliente { get; set; } // FK_SIR_289_MTRA_CLIENTES_IDENT_ADMINC_07_CLIENTES

        /// <summary>
        /// Parent CatCliente pointed by [SIR_289_MTRA_CLIENTES_IDENT].([NIdCliente]) (FK_SIR_289_MTRA_CLIENTES_IDENT_cat_clientes)
        /// </summary>
        public virtual CatCliente CatCliente { get; set; } // FK_SIR_289_MTRA_CLIENTES_IDENT_cat_clientes

        /// <summary>
        /// Parent CatUsr pointed by [SIR_289_MTRA_CLIENTES_IDENT].([NIdUsuarioEd]) (FK_SIR_289_MTRA_CLIENTES_IDENT_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_289_MTRA_CLIENTES_IDENT_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir28ClavesDocto pointed by [SIR_289_MTRA_CLIENTES_IDENT].([NIdClaveDocto28]) (FK_SIR_289_MTRA_CLIENTES_IDENT_SIR_28_CLAVES_DOCTOS)
        /// </summary>
        public virtual SIR_Sir28ClavesDocto SIR_Sir28ClavesDocto { get; set; } // FK_SIR_289_MTRA_CLIENTES_IDENT_SIR_28_CLAVES_DOCTOS

        public SIR_Sir289MtraClientesIdent()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            SIR_Sir256ClientesIdentificadore = new System.Collections.Generic.List<SIR_Sir256ClientesIdentificadore>();
        }
    }

}
// </auto-generated>
