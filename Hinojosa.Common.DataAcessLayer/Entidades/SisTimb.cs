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

    // sis_timb
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisTimb
    {
        [Required]
        [Display(Name = "Id sis timb")]
        public int IdSisTimb { get; set; } // id_sis_timb (Primary key via unique index PK_id_sis_timb)

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc

        [Required]
        [Display(Name = "Id fac")]
        public int IdFac { get; set; } // id_fac

        [Required]
        [Display(Name = "Id serie")]
        public int IdSerie { get; set; } // id_serie

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Serie")]
        public string Serie { get; set; } // serie (length: 10)

        [Required]
        [Display(Name = "Numero")]
        public int Numero { get; set; } // numero

        [Required(AllowEmptyStrings = true)]
        [MaxLength(2147483647)]
        [StringLength(2147483647)]
        [Display(Name = "Timbre")]
        public string Timbre { get; set; } // timbre (length: 2147483647)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(36)]
        [StringLength(36)]
        [Display(Name = "Uuid")]
        public string Uuid { get; set; } // uuid (length: 36)

        [Required]
        [Display(Name = "Id sesion")]
        public int IdSesion { get; set; } // id_sesion

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Estatus")]
        public int Estatus { get; set; } // estatus

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Xml canc")]
        public string XmlCanc { get; set; } // xml_canc

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Xml cfdi")]
        public string XmlCfdi { get; set; } // xml_cfdi

        [Required]
        [Display(Name = "Id reg cob")]
        public int IdRegCob { get; set; } // id_reg_cob

        [Required]
        [Display(Name = "Id pac")]
        public int IdPac { get; set; } // id_pac

        [Required]
        [Display(Name = "C ctl ext")]
        public bool CCtlExt { get; set; } // c_ctl_ext

        public SisTimb()
        {
            IdTipDoc = 0;
            IdFac = 0;
            IdSerie = 0;
            Serie = "";
            Numero = 0;
            Timbre = "";
            Uuid = "";
            IdSesion = 0;
            Estatus = 0;
            XmlCanc = "";
            XmlCfdi = "";
            IdRegCob = 0;
            CCtlExt = false;
        }
    }

}
// </auto-generated>
