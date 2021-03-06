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

    // SIR_291_SELLOS_RECIBIDOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir291SellosRecibido
    {
        [Required]
        [Display(Name = "N ID sello 291")]
        public int NIdSello291 { get; set; } // nIdSello291 (Primary key)

        [Required]
        [Display(Name = "N ID referencia 60")]
        public int NIdReferencia60 { get; set; } // nIdReferencia60

        [Required]
        [Display(Name = "N ID naviera")]
        public int NIdNaviera { get; set; } // nIdNaviera

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S atencion")]
        public string SAtencion { get; set; } // sAtencion (length: 100)

        [Required]
        [Display(Name = "D deposito")]
        public System.DateTime DDeposito { get; set; } // dDeposito

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        // Foreign keys

        /// <summary>
        /// Parent CatProv pointed by [SIR_291_SELLOS_RECIBIDOS].([NIdNaviera]) (FK_SIR_291_SELLOS_RECIBIDOS_cat_prov)
        /// </summary>
        public virtual CatProv CatProv { get; set; } // FK_SIR_291_SELLOS_RECIBIDOS_cat_prov

        /// <summary>
        /// Parent CatUsr pointed by [SIR_291_SELLOS_RECIBIDOS].([NIdUsuarioEd]) (FK_SIR_291_SELLOS_RECIBIDOS_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_291_SELLOS_RECIBIDOS_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir60Referencia pointed by [SIR_291_SELLOS_RECIBIDOS].([NIdReferencia60]) (FK_SIR_291_SELLOS_RECIBIDOS_SIR_60_REFERENCIAS)
        /// </summary>
        public virtual SIR_Sir60Referencia SIR_Sir60Referencia { get; set; } // FK_SIR_291_SELLOS_RECIBIDOS_SIR_60_REFERENCIAS

        public SIR_Sir291SellosRecibido()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
        }
    }

}
// </auto-generated>
