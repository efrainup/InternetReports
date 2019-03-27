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

    // SIR_295_PAGOS_CONTRIBUCIONES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir295PagosContribucione
    {
        [Required]
        [Display(Name = "N ID pago cont 295")]
        public int NIdPagoCont295 { get; set; } // nIdPagoCont295 (Primary key)

        [Required]
        [Display(Name = "N ID fracc comp 215")]
        public int NIdFraccComp215 { get; set; } // nIdFraccComp215

        [Display(Name = "N ID tipos imp 30")]
        public int? NIdTiposImp30 { get; set; } // nIdTiposImp30

        [Display(Name = "N ID forma pago 32")]
        public int? NIdFormaPago32 { get; set; } // nIdFormaPago32

        [Display(Name = "N importe")]
        public int? NImporte { get; set; } // nImporte

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Display(Name = "N importe sin operar")]
        public int? NImporteSinOperar { get; set; } // nImporteSinOperar

        [Display(Name = "N inpc")]
        public decimal? NInpc { get; set; } // nINPC

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_295_PAGOS_CONTRIBUCIONES].([NIdUsuarioEd]) (FK_SIR_295_PAGOS_CONTRIBUCIONES_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_295_PAGOS_CONTRIBUCIONES_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir215FraccionesTlcExpo pointed by [SIR_295_PAGOS_CONTRIBUCIONES].([NIdFraccComp215]) (FK_SIR_295_PAGOS_CONTRIBUCIONES_SIR_215_FRACCIONES_TLC_EXPO)
        /// </summary>
        public virtual SIR_Sir215FraccionesTlcExpo SIR_Sir215FraccionesTlcExpo { get; set; } // FK_SIR_295_PAGOS_CONTRIBUCIONES_SIR_215_FRACCIONES_TLC_EXPO

        /// <summary>
        /// Parent SIR_Sir30TiposImpuesto pointed by [SIR_295_PAGOS_CONTRIBUCIONES].([NIdTiposImp30]) (FK_SIR_295_PAGOS_CONTRIBUCIONES_SIR_30_TIPOS_IMPUESTOS)
        /// </summary>
        public virtual SIR_Sir30TiposImpuesto SIR_Sir30TiposImpuesto { get; set; } // FK_SIR_295_PAGOS_CONTRIBUCIONES_SIR_30_TIPOS_IMPUESTOS

        /// <summary>
        /// Parent SIR_Sir32FormasPago pointed by [SIR_295_PAGOS_CONTRIBUCIONES].([NIdFormaPago32]) (FK_SIR_295_PAGOS_CONTRIBUCIONES_SIR_32_FORMAS_PAGO)
        /// </summary>
        public virtual SIR_Sir32FormasPago SIR_Sir32FormasPago { get; set; } // FK_SIR_295_PAGOS_CONTRIBUCIONES_SIR_32_FORMAS_PAGO

        public SIR_Sir295PagosContribucione()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
        }
    }

}
// </auto-generated>