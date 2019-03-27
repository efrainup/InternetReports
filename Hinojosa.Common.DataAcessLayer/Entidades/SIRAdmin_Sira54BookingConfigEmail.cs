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

    // SIRA_54_BOOKING_CONFIG_EMAIL
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira54BookingConfigEmail
    {
        [Required]
        [Display(Name = "N ID bk config email 54")]
        public int NIdBkConfigEmail54 { get; set; } // nIdBkConfigEmail54 (Primary key)

        [Display(Name = "N dias")]
        public int? NDias { get; set; } // nDias

        [Display(Name = "D fecha reporte")]
        public System.DateTime? DFechaReporte { get; set; } // dFechaReporte

        [Display(Name = "D fecha alta")]
        public System.DateTime? DFechaAlta { get; set; } // dFechaAlta

        [Display(Name = "N ID email contactos 55")]
        public int? NIdEmailContactos55 { get; set; } // nIdEmailContactos55

        // Foreign keys

        /// <summary>
        /// Parent SIRAdmin_Sira55EmailContacto pointed by [SIRA_54_BOOKING_CONFIG_EMAIL].([NIdEmailContactos55]) (FK_SIRA_54_BOOKING_CONFIG_EMAIL_SIRA_55_EMAIL_CONTACTOS)
        /// </summary>
        public virtual SIRAdmin_Sira55EmailContacto SIRAdmin_Sira55EmailContacto { get; set; } // FK_SIRA_54_BOOKING_CONFIG_EMAIL_SIRA_55_EMAIL_CONTACTOS

        public SIRAdmin_Sira54BookingConfigEmail()
        {
            DFechaAlta = System.DateTime.Now;
        }
    }

}
// </auto-generated>