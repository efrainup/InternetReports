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

    // SIR_171_CONT_SOL_TRANSPORTE
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir171ContSolTransporte
    {
        [Required]
        [Display(Name = "N ID sol trans 169")]
        public int NIdSolTrans169 { get; set; } // nIdSolTrans169 (Primary key via unique index UK_SIR_171_CONT_SOL_TRANSPORTE)

        [Display(Name = "N ID contenedor 76")]
        public int? NIdContenedor76 { get; set; } // nIdContenedor76

        [Display(Name = "N ID carga suelta 66")]
        public int? NIdCargaSuelta66 { get; set; } // nIdCargaSuelta66

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir169SolicitudTransporte pointed by [SIR_171_CONT_SOL_TRANSPORTE].([NIdSolTrans169]) (FK_SIR_171_CONT_SOL_TRANSPORTE_SIR_169_SOLICITUD_TRANSPORTE)
        /// </summary>
        public virtual SIR_Sir169SolicitudTransporte SIR_Sir169SolicitudTransporte { get; set; } // FK_SIR_171_CONT_SOL_TRANSPORTE_SIR_169_SOLICITUD_TRANSPORTE

        /// <summary>
        /// Parent SIR_Sir66CargaSuelta pointed by [SIR_171_CONT_SOL_TRANSPORTE].([NIdCargaSuelta66]) (FK_SIR_171_CONT_SOL_TRANSPORTE_SIR_66_CARGA_SUELTA)
        /// </summary>
        public virtual SIR_Sir66CargaSuelta SIR_Sir66CargaSuelta { get; set; } // FK_SIR_171_CONT_SOL_TRANSPORTE_SIR_66_CARGA_SUELTA

        /// <summary>
        /// Parent SIR_Sir76Contenedore pointed by [SIR_171_CONT_SOL_TRANSPORTE].([NIdContenedor76]) (FK_SIR_171_CONT_SOL_TRANSPORTE_SIR_76_CONTENEDORES)
        /// </summary>
        public virtual SIR_Sir76Contenedore SIR_Sir76Contenedore { get; set; } // FK_SIR_171_CONT_SOL_TRANSPORTE_SIR_76_CONTENEDORES
    }

}
// </auto-generated>
