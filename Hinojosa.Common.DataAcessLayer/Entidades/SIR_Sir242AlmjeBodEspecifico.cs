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

    // SIR_242_ALMJE_BOD_ESPECIFICO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir242AlmjeBodEspecifico
    {
        [Required]
        [Display(Name = "N ID almje esp 242")]
        public int NIdAlmjeEsp242 { get; set; } // nIdAlmjeEsp242 (Primary key)

        [Required]
        [Display(Name = "N dias libres")]
        public int NDiasLibres { get; set; } // nDiasLibres

        [Display(Name = "N tarifa")]
        public decimal? NTarifa { get; set; } // nTarifa

        [Required]
        [Display(Name = "N ID concepto")]
        public int NIdConcepto { get; set; } // nIdConcepto

        [Display(Name = "N ID cliente")]
        public int? NIdCliente { get; set; } // nIdCliente

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Required]
        [Display(Name = "N ID moneda")]
        public int NIdMoneda { get; set; } // nIdMoneda

        [Required]
        [Display(Name = "N ID almje gral 241")]
        public int NIdAlmjeGral241 { get; set; } // nIdAlmjeGral241

        [Required]
        [Display(Name = "B inicia al arribo")]
        public bool BIniciaAlArribo { get; set; } // bIniciaAlArribo

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir26ClasesEmpaque (Many-to-Many) mapped by table [SIR_243_ALMJE_ESP_BULTOS]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir26ClasesEmpaque> SIR_Sir26ClasesEmpaque { get; set; } // Many to many mapping

        // Foreign keys

        /// <summary>
        /// Parent CatCliente pointed by [SIR_242_ALMJE_BOD_ESPECIFICO].([NIdCliente]) (FK_SIR_242_ALMJE_BOD_ESPECIFICO_cat_clientes)
        /// </summary>
        public virtual CatCliente CatCliente { get; set; } // FK_SIR_242_ALMJE_BOD_ESPECIFICO_cat_clientes

        /// <summary>
        /// Parent CatPro pointed by [SIR_242_ALMJE_BOD_ESPECIFICO].([NIdConcepto]) (FK_SIR_242_ALMJE_BOD_ESPECIFICO_cat_pro)
        /// </summary>
        public virtual CatPro CatPro { get; set; } // FK_SIR_242_ALMJE_BOD_ESPECIFICO_cat_pro

        /// <summary>
        /// Parent CatUsr pointed by [SIR_242_ALMJE_BOD_ESPECIFICO].([NIdUsuarioEd]) (FK_SIR_242_ALMJE_BOD_ESPECIFICO_cat_usr)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_242_ALMJE_BOD_ESPECIFICO_cat_usr

        /// <summary>
        /// Parent MonMoneda pointed by [SIR_242_ALMJE_BOD_ESPECIFICO].([NIdMoneda]) (FK_SIR_242_ALMJE_BOD_ESPECIFICO_mon_monedas)
        /// </summary>
        public virtual MonMoneda MonMoneda { get; set; } // FK_SIR_242_ALMJE_BOD_ESPECIFICO_mon_monedas

        /// <summary>
        /// Parent SIR_Sir241AlmjeBodGeneral pointed by [SIR_242_ALMJE_BOD_ESPECIFICO].([NIdAlmjeGral241]) (FK_SIR_242_ALMJE_BOD_ESPECIFICO_SIR_241_ALMJE_BOD_GENERAL)
        /// </summary>
        public virtual SIR_Sir241AlmjeBodGeneral SIR_Sir241AlmjeBodGeneral { get; set; } // FK_SIR_242_ALMJE_BOD_ESPECIFICO_SIR_241_ALMJE_BOD_GENERAL

        public SIR_Sir242AlmjeBodEspecifico()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            SIR_Sir26ClasesEmpaque = new System.Collections.Generic.List<SIR_Sir26ClasesEmpaque>();
        }
    }

}
// </auto-generated>
