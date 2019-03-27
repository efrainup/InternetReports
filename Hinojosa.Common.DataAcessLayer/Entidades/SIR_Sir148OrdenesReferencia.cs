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

    // SIR_148_ORDENES_REFERENCIAS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir148OrdenesReferencia
    {
        [Required]
        [Display(Name = "N ID orden cli 146")]
        public int NIdOrdenCli146 { get; set; } // nIdOrdenCli146 (Primary key)

        [Required]
        [Display(Name = "N ID referencia 60")]
        public int NIdReferencia60 { get; set; } // nIdReferencia60 (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_148_ORDENES_REFERENCIAS].([NIdUsuarioEd]) (FK_SIR_148_ORDENES_REFERENCIAS_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_148_ORDENES_REFERENCIAS_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir146OrdenesCliente pointed by [SIR_148_ORDENES_REFERENCIAS].([NIdOrdenCli146]) (FK_SIR_148_ORDENES_REFERENCIAS_SIR_146_ORDENES_CLIENTES)
        /// </summary>
        public virtual SIR_Sir146OrdenesCliente SIR_Sir146OrdenesCliente { get; set; } // FK_SIR_148_ORDENES_REFERENCIAS_SIR_146_ORDENES_CLIENTES

        /// <summary>
        /// Parent SIR_Sir60Referencia pointed by [SIR_148_ORDENES_REFERENCIAS].([NIdReferencia60]) (FK_SIR_148_ORDENES_REFERENCIAS_SIR_60_REFERENCIAS)
        /// </summary>
        public virtual SIR_Sir60Referencia SIR_Sir60Referencia { get; set; } // FK_SIR_148_ORDENES_REFERENCIAS_SIR_60_REFERENCIAS

        public SIR_Sir148OrdenesReferencia()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
        }
    }

}
// </auto-generated>
