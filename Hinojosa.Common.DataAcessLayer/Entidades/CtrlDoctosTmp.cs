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

    // ctrl_doctos_tmp
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CtrlDoctosTmp
    {
        [Display(Name = "P idsesion")]
        public int? PIdsesion { get; set; } // p_idsesion

        [Required]
        [Display(Name = "Id doc")]
        public int IdDoc { get; set; } // id_doc (Primary key)

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc (Primary key)

        [Required]
        [Display(Name = "Numero")]
        public int Numero { get; set; } // numero (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Serie")]
        public string Serie { get; set; } // serie (Primary key) (length: 20)

        [Required]
        [Display(Name = "Id arch")]
        public int IdArch { get; set; } // id_arch (Primary key)

        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "T ruta")]
        public string TRuta { get; set; } // t_ruta (length: 1000)

        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "V titulo")]
        public string VTitulo { get; set; } // v_titulo (length: 1000)

        [Display(Name = "Id usr")]
        public int? IdUsr { get; set; } // id_usr

        [Required]
        [Display(Name = "Id obj")]
        public int IdObj { get; set; } // id_obj (Primary key)

        [Required]
        [Display(Name = "Id tip obj")]
        public int IdTipObj { get; set; } // id_tip_obj (Primary key)

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status (Primary key)

        [Required]
        [Display(Name = "Id tbl")]
        public int IdTbl { get; set; } // id_tbl (Primary key)

        [Required]
        [Display(Name = "Id sesion")]
        public int IdSesion { get; set; } // id_sesion (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg (Primary key)

        [Required]
        [Display(Name = "Order")]
        public int Order { get; set; } // order (Primary key)

        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Tit arch")]
        public string TitArch { get; set; } // tit_arch (length: 200)

        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "Nota arch")]
        public string NotaArch { get; set; } // nota_arch (length: 1000)

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec arch")]
        public System.DateTime? FecArch { get; set; } // fec_arch

        [Required]
        [Display(Name = "Id prov")]
        public long IdProv { get; set; } // id_prov (Primary key)

        [Required]
        [Display(Name = "Id cli fa da")]
        public long IdCliFaDa { get; set; } // id_cli_fa_da (Primary key)

        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "No fact")]
        public string NoFact { get; set; } // no_fact (length: 40)

        [Display(Name = "Id tip arch")]
        public long? IdTipArch { get; set; } // id_tip_arch

        [Display(Name = "Xml arch")]
        public string XmlArch { get; set; } // xml_arch

        [Display(Name = "Auto arch")]
        public byte? AutoArch { get; set; } // auto_arch

        [Required]
        [Display(Name = "Tam arch")]
        public long TamArch { get; set; } // tam_arch (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Vigencia arch")]
        public System.DateTime VigenciaArch { get; set; } // vigencia_arch (Primary key)

        [Required]
        [Display(Name = "Id rel cot")]
        public int IdRelCot { get; set; } // id_rel_cot (Primary key)

        [Required]
        [Display(Name = "Id part")]
        public int IdPart { get; set; } // id_part (Primary key)

        [Required]
        [Display(Name = "Id obj det")]
        public int IdObjDet { get; set; } // id_obj_det (Primary key)

        public CtrlDoctosTmp()
        {
            PIdsesion = 0;
            IdDoc = 0;
            IdTipDoc = 0;
            Numero = 0;
            Serie = "";
            IdArch = 0;
            TRuta = "";
            VTitulo = "";
            IdUsr = 0;
            IdObj = 0;
            IdTipObj = 0;
            Status = 0;
            IdTbl = 0;
            IdSesion = 0;
            FecReg = System.DateTime.Now;
            Order = 0;
            TitArch = "";
            NotaArch = "";
            FecArch = System.DateTime.Now;
            IdProv = 0;
            IdCliFaDa = 0;
            NoFact = "";
            IdTipArch = 0;
            XmlArch = "<ArchivoXml><Registro1>Archivo Vacio</Registro1></ArchivoXml>";
            AutoArch = 0;
            TamArch = 0;
            VigenciaArch = System.DateTime.Now;
            IdRelCot = 0;
            IdPart = 0;
            IdObjDet = 0;
        }
    }

}
// </auto-generated>