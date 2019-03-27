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

    // SIR_667_ENVIO_DE_LIGA_UNICA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir667EnvioDeLigaUnica
    {
        [Required]
        [Display(Name = "N ID liga unica 667")]
        public int NIdLigaUnica667 { get; set; } // nIdLigaUnica667 (Primary key)

        [Display(Name = "N ID referencia 60")]
        public int? NIdReferencia60 { get; set; } // nIdReferencia60

        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 200)

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha envio")]
        public System.DateTime? DFechaEnvio { get; set; } // dFechaEnvio

        [Display(Name = "D fecha ini caducidad")]
        public System.DateTime? DFechaIniCaducidad { get; set; } // dFechaIniCaducidad

        [Display(Name = "N caducidad")]
        public int? NCaducidad { get; set; } // nCaducidad

        [Display(Name = "D envio notificacion")]
        public System.DateTime? DEnvioNotificacion { get; set; } // dEnvioNotificacion

        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "S ruta archivos")]
        public string SRutaArchivos { get; set; } // sRutaArchivos (length: 200)

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha descarga")]
        public System.DateTime? DFechaDescarga { get; set; } // dFechaDescarga
    }

}
// </auto-generated>
