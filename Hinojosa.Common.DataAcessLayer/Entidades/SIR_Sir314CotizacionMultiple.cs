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

    // SIR_314_COTIZACION_MULTIPLE
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir314CotizacionMultiple
    {
        [Required]
        [Display(Name = "N ID comp mul 314")]
        public int NIdCompMul314 { get; set; } // nIdCompMul314 (Primary key)

        [Required]
        [Display(Name = "N folio")]
        public int NFolio { get; set; } // nFolio

        [Display(Name = "N ID cliente")]
        public int? NIdCliente { get; set; } // nIdCliente

        [Display(Name = "N ID solicitado por")]
        public int? NIdSolicitadoPor { get; set; } // nIdSolicitadoPor

        [Required]
        [Display(Name = "D solicitud")]
        public System.DateTime DSolicitud { get; set; } // dSolicitud

        [Required]
        [Display(Name = "N importe total")]
        public decimal NImporteTotal { get; set; } // nImporteTotal

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S observaciones")]
        public string SObservaciones { get; set; } // sObservaciones (length: 500)

        [Display(Name = "N ID iva")]
        public int? NIdIva { get; set; } // nIdIva

        [Required]
        [Display(Name = "N status")]
        public byte NStatus { get; set; } // nStatus

        [Display(Name = "N ID clie 07")]
        public int? NIdClie07 { get; set; } // nIdClie07

        [Display(Name = "N ID pers 02")]
        public int? NIdPers02 { get; set; } // nIdPers02

        [Display(Name = "N ID iva 25")]
        public int? NIdIva25 { get; set; } // nIdIva25

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir124Anticipos where [SIR_124_ANTICIPOS].[nIdCompMul314] point to this entity (FK_SIR_124_ANTICIPOS_SIR_314_COTIZACION_MULTIPLE)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir124Anticipos> SIR_Sir124Anticipos { get; set; } // SIR_124_ANTICIPOS.FK_SIR_124_ANTICIPOS_SIR_314_COTIZACION_MULTIPLE

        // Foreign keys

        /// <summary>
        /// Parent Admin_Admina02Personal pointed by [SIR_314_COTIZACION_MULTIPLE].([NIdPers02]) (FK_SIR_314_COTIZACION_MULTIPLE_ADMINA_02_PERSONAL)
        /// </summary>
        public virtual Admin_Admina02Personal Admin_Admina02Personal { get; set; } // FK_SIR_314_COTIZACION_MULTIPLE_ADMINA_02_PERSONAL

        /// <summary>
        /// Parent Admin_Adminc07Cliente pointed by [SIR_314_COTIZACION_MULTIPLE].([NIdClie07]) (FK_SIR_314_COTIZACION_MULTIPLE_ADMINC_07_CLIENTES)
        /// </summary>
        public virtual Admin_Adminc07Cliente Admin_Adminc07Cliente { get; set; } // FK_SIR_314_COTIZACION_MULTIPLE_ADMINC_07_CLIENTES

        /// <summary>
        /// Parent Admin_Adminc25Iva pointed by [SIR_314_COTIZACION_MULTIPLE].([NIdIva25]) (FK_SIR_314_COTIZACION_MULTIPLE_ADMINC_25_IVA)
        /// </summary>
        public virtual Admin_Adminc25Iva Admin_Adminc25Iva { get; set; } // FK_SIR_314_COTIZACION_MULTIPLE_ADMINC_25_IVA

        /// <summary>
        /// Parent CatCliente pointed by [SIR_314_COTIZACION_MULTIPLE].([NIdCliente]) (FK_SIR_314_COTIZACION_MULTIPLE_cat_clientes)
        /// </summary>
        public virtual CatCliente CatCliente { get; set; } // FK_SIR_314_COTIZACION_MULTIPLE_cat_clientes

        /// <summary>
        /// Parent CatCodImp pointed by [SIR_314_COTIZACION_MULTIPLE].([NIdIva]) (FK_SIR_314_COTIZACION_MULTIPLE_cat_cod_imp)
        /// </summary>
        public virtual CatCodImp CatCodImp { get; set; } // FK_SIR_314_COTIZACION_MULTIPLE_cat_cod_imp

        /// <summary>
        /// Parent CatEmp pointed by [SIR_314_COTIZACION_MULTIPLE].([NIdSolicitadoPor]) (FK_SIR_314_COTIZACION_MULTIPLE_cat_emp)
        /// </summary>
        public virtual CatEmp CatEmp { get; set; } // FK_SIR_314_COTIZACION_MULTIPLE_cat_emp

        public SIR_Sir314CotizacionMultiple()
        {
            NIdIva = 1;
            NStatus = 1;
            SIR_Sir124Anticipos = new System.Collections.Generic.List<SIR_Sir124Anticipos>();
        }
    }

}
// </auto-generated>