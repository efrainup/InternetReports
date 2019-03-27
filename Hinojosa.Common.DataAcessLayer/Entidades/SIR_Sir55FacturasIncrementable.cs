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

    // SIR_55_FACTURAS_INCREMENTABLES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir55FacturasIncrementable
    {
        [Required]
        [Display(Name = "N ID factura inc 55")]
        public int NIdFacturaInc55 { get; set; } // nIdFacturaInc55 (Primary key)

        [Required]
        [Display(Name = "N ID factura 52")]
        public int NIdFactura52 { get; set; } // nIdFactura52

        [Required]
        [Display(Name = "N ID tipo incrementable 54")]
        public int NIdTipoIncrementable54 { get; set; } // nIdTipoIncrementable54

        [Display(Name = "N ID moneda 03")]
        public int? NIdMoneda03 { get; set; } // nIdMoneda03

        [Required]
        [Display(Name = "N monto")]
        public decimal NMonto { get; set; } // nMonto

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_55_FACTURAS_INCREMENTABLES].([NIdUsuarioEd]) (FK_SIR_55_FACTURAS_INCREMENTABLES_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_55_FACTURAS_INCREMENTABLES_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir03Moneda pointed by [SIR_55_FACTURAS_INCREMENTABLES].([NIdMoneda03]) (FK_SIR_55_FACTURAS_INCREMENTABLES_SIR_03_MONEDAS)
        /// </summary>
        public virtual SIR_Sir03Moneda SIR_Sir03Moneda { get; set; } // FK_SIR_55_FACTURAS_INCREMENTABLES_SIR_03_MONEDAS

        /// <summary>
        /// Parent SIR_Sir52Factura pointed by [SIR_55_FACTURAS_INCREMENTABLES].([NIdFactura52]) (FK_SIR_55_FACTURAS_INCREMENTABLES_SIR_52_FACTURAS)
        /// </summary>
        public virtual SIR_Sir52Factura SIR_Sir52Factura { get; set; } // FK_SIR_55_FACTURAS_INCREMENTABLES_SIR_52_FACTURAS

        /// <summary>
        /// Parent SIR_Sir54TipoIncrementable pointed by [SIR_55_FACTURAS_INCREMENTABLES].([NIdTipoIncrementable54]) (FK_SIR_55_FACTURAS_INCREMENTABLES_SIR_54_TIPO_INCREMENTABLES)
        /// </summary>
        public virtual SIR_Sir54TipoIncrementable SIR_Sir54TipoIncrementable { get; set; } // FK_SIR_55_FACTURAS_INCREMENTABLES_SIR_54_TIPO_INCREMENTABLES

        public SIR_Sir55FacturasIncrementable()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
        }
    }

}
// </auto-generated>
