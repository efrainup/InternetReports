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

    // SIRA_49_LIBERACION_CONTENEDOR
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira49LiberacionContenedor
    {
        [Required]
        [Display(Name = "N ID lib cont 49")]
        public int NIdLibCont49 { get; set; } // nIdLibCont49 (Primary key)

        [Required]
        [Display(Name = "N ID contenedor 76")]
        public int NIdContenedor76 { get; set; } // nIdContenedor76

        [Required]
        [Display(Name = "N ID referencia 60")]
        public int NIdReferencia60 { get; set; } // nIdReferencia60

        [Display(Name = "N folio")]
        public int? NFolio { get; set; } // nFolio

        [Required(AllowEmptyStrings = true)]
        [MaxLength(150)]
        [StringLength(150)]
        [Display(Name = "S observaciones")]
        public string SObservaciones { get; set; } // sObservaciones (length: 150)

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha liberacion")]
        public System.DateTime? DFechaLiberacion { get; set; } // dFechaLiberacion

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha solicitud")]
        public System.DateTime? DFechaSolicitud { get; set; } // dFechaSolicitud

        [Display(Name = "N ID solicita 02")]
        public int? NIdSolicita02 { get; set; } // nIdSolicita02

        [Display(Name = "N ID solicita")]
        public int? NIdSolicita { get; set; } // nIdSolicita

        // Foreign keys

        /// <summary>
        /// Parent Admin_Admina02Personal pointed by [SIRA_49_LIBERACION_CONTENEDOR].([NIdSolicita02]) (FK_SIRA_49_LIBERACION_CONTENEDOR_ADMINA_02_PERSONAL)
        /// </summary>
        public virtual Admin_Admina02Personal Admin_Admina02Personal { get; set; } // FK_SIRA_49_LIBERACION_CONTENEDOR_ADMINA_02_PERSONAL

        /// <summary>
        /// Parent CatEmp pointed by [SIRA_49_LIBERACION_CONTENEDOR].([NIdSolicita]) (FK_SIRA_49_LIBERACION_CONTENEDOR_cat_emp)
        /// </summary>
        public virtual CatEmp CatEmp { get; set; } // FK_SIRA_49_LIBERACION_CONTENEDOR_cat_emp

        /// <summary>
        /// Parent SIR_Sir60Referencia pointed by [SIRA_49_LIBERACION_CONTENEDOR].([NIdReferencia60]) (FK_SIRA_49_LIBERACION_CONTENEDOR_SIR_60_REFERENCIAS)
        /// </summary>
        public virtual SIR_Sir60Referencia SIR_Sir60Referencia { get; set; } // FK_SIRA_49_LIBERACION_CONTENEDOR_SIR_60_REFERENCIAS

        /// <summary>
        /// Parent SIR_Sir76Contenedore pointed by [SIRA_49_LIBERACION_CONTENEDOR].([NIdContenedor76]) (FK_SIRA_49_LIBERACION_CONTENEDOR_SIR_76_CONTENEDORES)
        /// </summary>
        public virtual SIR_Sir76Contenedore SIR_Sir76Contenedore { get; set; } // FK_SIRA_49_LIBERACION_CONTENEDOR_SIR_76_CONTENEDORES
    }

}
// </auto-generated>
