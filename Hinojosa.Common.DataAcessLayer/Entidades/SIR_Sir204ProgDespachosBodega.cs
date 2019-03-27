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

    // SIR_204_PROG_DESPACHOS_BODEGA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir204ProgDespachosBodega
    {
        [Required]
        [Display(Name = "N ID pr des bod 204")]
        public int NIdPrDesBod204 { get; set; } // nIdPrDesBod204 (Primary key)

        [Required]
        [Display(Name = "N ID empleado")]
        public int NIdEmpleado { get; set; } // nIdEmpleado

        [Required]
        [Display(Name = "D fecha prog")]
        public System.DateTime DFechaProg { get; set; } // dFechaProg

        [Required]
        [Display(Name = "N ID almacen")]
        public int NIdAlmacen { get; set; } // nIdAlmacen

        [Required]
        [Display(Name = "N ID transportista")]
        public int NIdTransportista { get; set; } // nIdTransportista

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S num economico")]
        public string SNumEconomico { get; set; } // sNumEconomico (length: 20)

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S placas")]
        public string SPlacas { get; set; } // sPlacas (length: 20)

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S observacion")]
        public string SObservacion { get; set; } // sObservacion (length: 500)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S orden salida")]
        public string SOrdenSalida { get; set; } // sOrdenSalida (length: 50)

        [Required]
        [Display(Name = "N status")]
        public byte NStatus { get; set; } // nStatus

        [Display(Name = "D fecha salida")]
        public System.DateTime? DFechaSalida { get; set; } // dFechaSalida

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir60Referencia where [SIR_60_REFERENCIAS].[nIdPrDesBod204] point to this entity (FK_SIR_60_REFERENCIAS_SIR_204_PROG_DESPACHOS_BODEGA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir60Referencia> SIR_Sir60Referencia { get; set; } // SIR_60_REFERENCIAS.FK_SIR_60_REFERENCIAS_SIR_204_PROG_DESPACHOS_BODEGA

        // Foreign keys

        /// <summary>
        /// Parent CatAlmac pointed by [SIR_204_PROG_DESPACHOS_BODEGA].([NIdAlmacen]) (FK_SIR_204_PROG_DESPACHOS_BODEGA_cat_almac)
        /// </summary>
        public virtual CatAlmac CatAlmac { get; set; } // FK_SIR_204_PROG_DESPACHOS_BODEGA_cat_almac

        /// <summary>
        /// Parent CatEmp pointed by [SIR_204_PROG_DESPACHOS_BODEGA].([NIdEmpleado]) (FK_SIR_204_PROG_DESPACHOS_BODEGA_cat_emp)
        /// </summary>
        public virtual CatEmp CatEmp { get; set; } // FK_SIR_204_PROG_DESPACHOS_BODEGA_cat_emp

        /// <summary>
        /// Parent CatProv pointed by [SIR_204_PROG_DESPACHOS_BODEGA].([NIdTransportista]) (FK_SIR_204_PROG_DESPACHOS_BODEGA_cat_prov)
        /// </summary>
        public virtual CatProv CatProv { get; set; } // FK_SIR_204_PROG_DESPACHOS_BODEGA_cat_prov

        /// <summary>
        /// Parent CatUsr pointed by [SIR_204_PROG_DESPACHOS_BODEGA].([NIdUsuarioEd]) (FK_SIR_204_PROG_DESPACHOS_BODEGA_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_204_PROG_DESPACHOS_BODEGA_cat_usr_ed

        public SIR_Sir204ProgDespachosBodega()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            SIR_Sir60Referencia = new System.Collections.Generic.List<SIR_Sir60Referencia>();
        }
    }

}
// </auto-generated>