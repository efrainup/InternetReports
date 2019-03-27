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

    // ctb_xml_cfdi
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CtbXmlCfdi
    {
        [Required]
        [Display(Name = "Id ctb xml cfd")]
        public int IdCtbXmlCfd { get; set; } // Id_ctb_xml_cfd (Primary key)

        [Required]
        [Display(Name = "Id tip xml")]
        public int IdTipXml { get; set; } // id_tip_xml

        [Required]
        [Display(Name = "Folio")]
        public int Folio { get; set; } // folio

        [Display(Name = "Cad xml")]
        public string CadXml { get; set; } // cad_XML

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec gen")]
        public System.DateTime FecGen { get; set; } // fec_gen

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec env")]
        public System.DateTime FecEnv { get; set; } // fec_env

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Criterios")]
        public string Criterios { get; set; } // criterios

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec xml")]
        public System.DateTime FecXml { get; set; } // fec_xml

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Nom arch")]
        public string NomArch { get; set; } // nom_arch

        [Required]
        [Display(Name = "Fol envio")]
        public int FolEnvio { get; set; } // fol_envio

        [Required]
        [Display(Name = "Mes")]
        public int Mes { get; set; } // mes

        [Required]
        [Display(Name = "Anio")]
        public int Anio { get; set; } // anio

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Coment")]
        public string Coment { get; set; } // coment

        [Required]
        [Display(Name = "Tipo env")]
        public byte TipoEnv { get; set; } // tipo_env

        [Required]
        [Display(Name = "Id rel xml env")]
        public int IdRelXmlEnv { get; set; } // id_rel_xml_env

        public CtbXmlCfdi()
        {
            IdTipXml = 0;
            Folio = 0;
            CadXml = "";
            IdUsr = 0;
            Criterios = "";
            NomArch = "";
            FolEnvio = 0;
            Mes = 0;
            Anio = 0;
            Coment = "";
            TipoEnv = 0;
            IdRelXmlEnv = 0;
        }
    }

}
// </auto-generated>
