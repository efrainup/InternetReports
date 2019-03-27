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

    // vta_doc_rel_det_gas
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaDocRelDetGas
    {
        [Required]
        [Display(Name = "Nrotrn")]
        public int Nrotrn { get; set; } // nrotrn (Primary key via unique index despgas)

        [Required]
        [Display(Name = "Codgas")]
        public int Codgas { get; set; } // codgas (Primary key via unique index despgas)

        [Required]
        [Display(Name = "Nrofac")]
        public int Nrofac { get; set; } // nrofac

        [Required]
        [Display(Name = "Nrobom")]
        public int Nrobom { get; set; } // nrobom

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fchtrn")]
        public System.DateTime Fchtrn { get; set; } // fchtrn

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Hratrn")]
        public System.DateTime Hratrn { get; set; } // hratrn

        [Required(AllowEmptyStrings = true)]
        [MaxLength(2000)]
        [StringLength(2000)]
        [Display(Name = "Nomarch")]
        public string Nomarch { get; set; } // nomarch (length: 2000)

        [Required]
        [Display(Name = "Precio")]
        public double Precio { get; set; } // Precio

        [Required]
        [Display(Name = "Id cli ext")]
        public int IdCliExt { get; set; } // id_cli_ext

        [Required]
        [Display(Name = "Id cli 1 g")]
        public int IdCli1G { get; set; } // id_cli_1g

        [Required]
        [Display(Name = "Id veh ext")]
        public int IdVehExt { get; set; } // id_veh_ext

        [Required]
        [Display(Name = "Id tip pag")]
        public int IdTipPag { get; set; } // id_tip_pag

        [Required]
        [Display(Name = "Monto")]
        public double Monto { get; set; } // Monto

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Nroaut")]
        public string Nroaut { get; set; } // nroaut (length: 20)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Nrotar")]
        public string Nrotar { get; set; } // nrotar (length: 20)

        [Required]
        [Display(Name = "Id fac")]
        public int IdFac { get; set; } // id_fac

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Tip pag des")]
        public string TipPagDes { get; set; } // tip_pag_des (length: 20)

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fchcor")]
        public System.DateTime Fchcor { get; set; } // fchcor

        [Required]
        [Display(Name = "Mtogto")]
        public double Mtogto { get; set; } // mtogto

        [Required]
        [Display(Name = "Tiptrn")]
        public byte Tiptrn { get; set; } // tiptrn

        [Required]
        [Display(Name = "Id bco atio")]
        public int IdBcoAtio { get; set; } // id_bco_atio

        [Required(AllowEmptyStrings = true)]
        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Rut")]
        public string Rut { get; set; } // rut (length: 200)

        [Required]
        [Display(Name = "Nrotur")]
        public int Nrotur { get; set; } // nrotur

        [Required]
        [Display(Name = "Codprd")]
        public int Codprd { get; set; } // codprd

        [Required]
        [Display(Name = "Can")]
        public double Can { get; set; } // can

        [Required]
        [Display(Name = "Nrocte")]
        public int Nrocte { get; set; } // nrocte

        [Required]
        [Display(Name = "Nrovhe")]
        public int Nrovhe { get; set; } // nrovhe

        [Required]
        [Display(Name = "Nrocho")]
        public int Nrocho { get; set; } // nrocho

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Cho")]
        public string Cho { get; set; } // cho (length: 30)

        [Required]
        [Display(Name = "Odm")]
        public int Odm { get; set; } // odm

        [Required]
        [Display(Name = "Codisl")]
        public int Codisl { get; set; } // codisl

        [Required]
        [Display(Name = "Pto")]
        public double Pto { get; set; } // pto

        [Required]
        [Display(Name = "Codres")]
        public int Codres { get; set; } // codres

        [Required]
        [Display(Name = "Graprd")]
        public int Graprd { get; set; } // graprd

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Logfch")]
        public System.DateTime Logfch { get; set; } // logfch

        [Required]
        [Display(Name = "Nrotrnpad")]
        public int Nrotrnpad { get; set; } // nrotrnpad

        [Required]
        [Display(Name = "Id fac det")]
        public int IdFacDet { get; set; } // id_fac_det

        [Required]
        [Display(Name = "Base")]
        public double @Base { get; set; } // base

        [Required]
        [Display(Name = "Id impto")]
        public int IdImpto { get; set; } // id_impto

        [Required]
        [Display(Name = "Tasa")]
        public double Tasa { get; set; } // tasa

        [Required]
        [Display(Name = "Mto impto")]
        public double MtoImpto { get; set; } // mto_impto

        [Required]
        [Display(Name = "Tasa ieps")]
        public double TasaIeps { get; set; } // tasa_ieps

        [Required]
        [Display(Name = "Mto ieps")]
        public double MtoIeps { get; set; } // mto_ieps

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Cod bco gas")]
        public string CodBcoGas { get; set; } // cod_bco_gas (length: 25)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Log new")]
        public System.DateTime LogNew { get; set; } // log_new

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "Datos ref")]
        public string DatosRef { get; set; } // datos_ref (length: 500)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "Datos cli")]
        public string DatosCli { get; set; } // datos_cli (length: 500)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "Datos vehi")]
        public string DatosVehi { get; set; } // datos_vehi (length: 500)

        [Required]
        [Display(Name = "Id sis ext")]
        public int IdSisExt { get; set; } // id_sis_ext

        [Required]
        [Display(Name = "Gas")]
        public int Gas { get; set; } // gas

        public VtaDocRelDetGas()
        {
            Nrobom = 0;
            Nomarch = "";
            Precio = 0;
            IdCliExt = 0;
            IdCli1G = 0;
            IdVehExt = 0;
            IdTipPag = 0;
            Monto = 0;
            Nroaut = "0";
            Nrotar = "0";
            IdFac = 0;
            TipPagDes = "0";
            Mtogto = 0;
            Tiptrn = 0;
            IdBcoAtio = 0;
            Rut = "0";
            Nrotur = 0;
            Codprd = 0;
            Can = 0;
            Nrocte = 0;
            Nrovhe = 0;
            Nrocho = 0;
            Cho = "0";
            Odm = 0;
            Codisl = 0;
            Pto = 0;
            Codres = 0;
            Graprd = 0;
            Nrotrnpad = 0;
            IdFacDet = 0;
            @Base = 0;
            IdImpto = 0;
            Tasa = 0;
            MtoImpto = 0;
            TasaIeps = 0;
            MtoIeps = 0;
            IdPro = 0;
            CodBcoGas = "";
            DatosRef = "";
            DatosCli = "";
            DatosVehi = "";
            IdSisExt = 0;
            Gas = 0;
        }
    }

}
// </auto-generated>