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

    // SIR_675_PREVIO_MOVIL
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir675PrevioMovil
    {
        [Required]
        [Display(Name = "N ID previo movil 675")]
        public int NIdPrevioMovil675 { get; set; } // nIdPrevioMovil675 (Primary key)

        [Required]
        [Display(Name = "N ID prev ref 161")]
        public int NIdPrevRef161 { get; set; } // nIdPrevRef161

        [Required]
        [Display(Name = "N ID usuario")]
        public int NIdUsuario { get; set; } // nIdUsuario

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D seleccion")]
        public System.DateTime DSeleccion { get; set; } // dSeleccion

        [DataType(DataType.DateTime)]
        [Display(Name = "D inicio sincronizacion")]
        public System.DateTime? DInicioSincronizacion { get; set; } // dInicioSincronizacion

        [DataType(DataType.DateTime)]
        [Display(Name = "D inicio envio")]
        public System.DateTime? DInicioEnvio { get; set; } // dInicioEnvio

        [DataType(DataType.DateTime)]
        [Display(Name = "D fin envio")]
        public System.DateTime? DFinEnvio { get; set; } // dFinEnvio

        [Required]
        [Display(Name = "B enviar notificacion")]
        public bool BEnviarNotificacion { get; set; } // bEnviarNotificacion

        [Display(Name = "S bitacora")]
        public string SBitacora { get; set; } // sBitacora

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir161ProgPreviosRef pointed by [SIR_675_PREVIO_MOVIL].([NIdPrevRef161]) (FK_SIR_675_PREVIO_MOVIL_SIR_161_PROG_PREVIOS_REF)
        /// </summary>
        public virtual SIR_Sir161ProgPreviosRef SIR_Sir161ProgPreviosRef { get; set; } // FK_SIR_675_PREVIO_MOVIL_SIR_161_PROG_PREVIOS_REF
    }

}
// </auto-generated>