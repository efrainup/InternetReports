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

    // The table 'sis_hist_arch' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    // sis_hist_arch
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_SisHistArch
    {
        [Display(Name = "Id rel hist arch")]
        public int? IdRelHistArch { get; set; } // id_rel_hist_arch

        [Display(Name = "Id arch")]
        public int? IdArch { get; set; } // id_arch

        [Display(Name = "Xml arch")]
        public string XmlArch { get; set; } // xml_arch

        [Display(Name = "T ruta")]
        public string TRuta { get; set; } // t_ruta

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime? FecReg { get; set; } // fec_reg

        [Display(Name = "Version")]
        public int? Version { get; set; } // version

        [Display(Name = "Id usr")]
        public int? IdUsr { get; set; } // id_usr

        [Display(Name = "Tit arch")]
        public string TitArch { get; set; } // tit_arch

        [Display(Name = "Nota arch")]
        public string NotaArch { get; set; } // nota_arch

        [Display(Name = "P ID sesion")]
        public int? PIdSesion { get; set; } // p_id_sesion

        [Display(Name = "V titulo")]
        public string VTitulo { get; set; } // v_titulo

        [Display(Name = "Tam arch")]
        public long? TamArch { get; set; } // tam_arch

        [DataType(DataType.DateTime)]
        [Display(Name = "Vigencia arch")]
        public System.DateTime? VigenciaArch { get; set; } // vigencia_arch

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec arch")]
        public System.DateTime? FecArch { get; set; } // fec_arch

        [Display(Name = "Status")]
        public int? Status { get; set; } // status

        [Display(Name = "Auto arch")]
        public byte? AutoArch { get; set; } // auto_arch

        [Display(Name = "Id tip cfd")]
        public int? IdTipCfd { get; set; } // id_tip_cfd

        [Display(Name = "Xml orig")]
        public string XmlOrig { get; set; } // xml_orig
    }

}
// </auto-generated>
