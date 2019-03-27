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

    // SQ_Reportes
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SqReporte
    {
        [Required]
        [Display(Name = "N ID reporte")]
        public int NIdReporte { get; set; } // nIdReporte (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S reporte")]
        public string SReporte { get; set; } // sReporte (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S sp sir")]
        public string SSpSir { get; set; } // sSpSir (length: 50)

        [Required]
        [Display(Name = "N status")]
        public int NStatus { get; set; } // nStatus

        [Required]
        [Display(Name = "N permite desglosar")]
        public int NPermiteDesglosar { get; set; } // nPermiteDesglosar

        [Display(Name = "N disponible web")]
        public int? NDisponibleWeb { get; set; } // nDisponibleWeb

        public SqReporte()
        {
            NStatus = 1;
            NPermiteDesglosar = 0;
            NDisponibleWeb = 0;
        }
    }

}
// </auto-generated>