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

    // sis_emb_enc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisEmbEnc
    {
        [Required]
        [Display(Name = "Id emb")]
        public int IdEmb { get; set; } // id_emb (Primary key)

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc

        [Required]
        [Display(Name = "Num doc")]
        public int NumDoc { get; set; } // num_doc

        [Required]
        [Display(Name = "Id med env")]
        public int IdMedEnv { get; set; } // id_med_env

        [Required]
        [Display(Name = "Id cli da ori")]
        public int IdCliDaOri { get; set; } // id_cli_da_ori

        [Required]
        [Display(Name = "Id cli da des")]
        public int IdCliDaDes { get; set; } // id_cli_da_des

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Dir")]
        public string Dir { get; set; } // dir (length: 255)

        [Required]
        [Display(Name = "Id cto")]
        public int IdCto { get; set; } // id_cto

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Guia")]
        public string Guia { get; set; } // guia (length: 25)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha")]
        public System.DateTime Fecha { get; set; } // fecha

        [Required]
        [Display(Name = "Id emp")]
        public int IdEmp { get; set; } // id_emp

        [Required]
        [Display(Name = "Dias")]
        public int Dias { get; set; } // dias

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec est ent")]
        public System.DateTime FecEstEnt { get; set; } // fec_est_ent

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Cmt")]
        public string Cmt { get; set; } // cmt (length: 25)

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Ciu")]
        public string Ciu { get; set; } // ciu (length: 80)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Cp")]
        public string Cp { get; set; } // cp (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Tel 1")]
        public string Tel1 { get; set; } // tel1 (length: 30)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Tel 2")]
        public string Tel2 { get; set; } // tel2 (length: 30)

        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Calle")]
        public string Calle { get; set; } // calle (length: 80)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Num int")]
        public string NumInt { get; set; } // num_int (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Num ext")]
        public string NumExt { get; set; } // num_ext (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Col")]
        public string Col { get; set; } // col (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Deleg")]
        public string Deleg { get; set; } // deleg (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Calles")]
        public string Calles { get; set; } // calles (length: 40)

        [Required]
        [Display(Name = "Id pais")]
        public int IdPais { get; set; } // id_pais

        [Required]
        [Display(Name = "Id edo")]
        public int IdEdo { get; set; } // id_edo

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        public SisEmbEnc()
        {
            IdTipDoc = 0;
            NumDoc = 0;
            IdMedEnv = 0;
            IdCliDaOri = 0;
            IdCliDaDes = 0;
            Dir = "";
            IdCto = 0;
            Guia = "";
            IdEmp = 0;
            Dias = 0;
            Cmt = "";
            IdNota = 0;
            Ciu = "";
            Cp = "";
            Tel1 = "";
            Tel2 = "";
            Calle = "";
            NumInt = "";
            NumExt = "";
            Col = "";
            Deleg = "";
            Calles = "";
            IdPais = 0;
            IdEdo = 0;
            Status = 0;
            IdUsr = 0;
        }
    }

}
// </auto-generated>
