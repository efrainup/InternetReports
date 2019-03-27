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

    // sis_xml_pasivos_log
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisXmlPasivosLog
    {
        [Required]
        [Display(Name = "Id sis xml log")]
        public int IdSisXmlLog { get; set; } // id_sis_xml_log (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(36)]
        [StringLength(36)]
        [Display(Name = "Uuid")]
        public string Uuid { get; set; } // UUID (length: 36)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Arch")]
        public string Arch { get; set; } // arch (length: 50)

        [Required]
        [Display(Name = "Status sat")]
        public int StatusSat { get; set; } // status_sat

        [Required]
        [Display(Name = "Status xml")]
        public int StatusXml { get; set; } // status_xml

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec xml")]
        public System.DateTime FecXml { get; set; } // fec_xml

        [MaxLength(400)]
        [StringLength(400)]
        [Display(Name = "Detalle")]
        public string Detalle { get; set; } // detalle (length: 400)
    }

}
// </auto-generated>