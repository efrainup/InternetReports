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

    // log_int_nac
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class LogIntNac
    {
        [Display(Name = "Id obj")]
        public int? IdObj { get; set; } // id_obj

        [Display(Name = "Id tip doc")]
        public int? IdTipDoc { get; set; } // id_tip_doc

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec cot")]
        public System.DateTime? FecCot { get; set; } // fec_cot

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ped")]
        public System.DateTime? FecPed { get; set; } // fec_ped

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec req cli")]
        public System.DateTime? FecReqCli { get; set; } // fec_req_cli

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec prom")]
        public System.DateTime? FecProm { get; set; } // fec_prom

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec hora rem")]
        public System.DateTime? FecHoraRem { get; set; } // fec_hora_rem

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec hora fac")]
        public System.DateTime? FecHoraFac { get; set; } // fec_hora_fac

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec hora sal bod")]
        public System.DateTime? FecHoraSalBod { get; set; } // fec_hora_sal_bod

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec hora lleg cli")]
        public System.DateTime? FecHoraLlegCli { get; set; } // fec_hora_lleg_cli

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec hora desc cli")]
        public System.DateTime? FecHoraDescCli { get; set; } // fec_hora_desc_cli

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec aut cot")]
        public System.DateTime? FecAutCot { get; set; } // fec_aut_cot

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec req")]
        public System.DateTime? FecReq { get; set; } // fec_req

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec prom pro")]
        public System.DateTime? FecPromPro { get; set; } // fec_prom_pro

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec hora lleg bod")]
        public System.DateTime? FecHoraLlegBod { get; set; } // fec_hora_lleg_bod

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec hora desc bod")]
        public System.DateTime? FecHoraDescBod { get; set; } // fec_hora_desc_bod

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec hora rec")]
        public System.DateTime? FecHoraRec { get; set; } // fec_hora_rec

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Pais org")]
        public string PaisOrg { get; set; } // pais_org (length: 255)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Pais dest")]
        public string PaisDest { get; set; } // pais_dest (length: 255)

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec hora lleg puert org")]
        public System.DateTime? FecHoraLlegPuertOrg { get; set; } // fec_hora_lleg_puert_org

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec hora sal puert org")]
        public System.DateTime? FecHoraSalPuertOrg { get; set; } // fec_hora_sal_puert_org

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec hora lleg puert dest")]
        public System.DateTime? FecHoraLlegPuertDest { get; set; } // fec_hora_lleg_puert_dest

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec hora sal puert dest")]
        public System.DateTime? FecHoraSalPuertDest { get; set; } // fec_hora_sal_puert_dest

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec fac")]
        public System.DateTime? FecFac { get; set; } // fec_fac

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec hora sal bod prov")]
        public System.DateTime? FecHoraSalBodProv { get; set; } // fec_hora_sal_bod_prov

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec hora pag ped")]
        public System.DateTime? FecHoraPagPed { get; set; } // fec_hora_pag_ped

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec hora rec alm")]
        public System.DateTime? FecHoraRecAlm { get; set; } // fec_hora_rec_alm

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr (Primary key)

        [Required]
        [Display(Name = "Id usr mod")]
        public int IdUsrMod { get; set; } // id_usr_mod (Primary key)

        [Display(Name = "Id obj aux")]
        public int? IdObjAux { get; set; } // id_obj_aux

        [MaxLength(300)]
        [StringLength(300)]
        [Display(Name = "Campo 1 texto")]
        public string Campo1Texto { get; set; } // CAMPO1_TEXTO (length: 300)

        [MaxLength(300)]
        [StringLength(300)]
        [Display(Name = "Campo 2 texto")]
        public string Campo2Texto { get; set; } // CAMPO2_TEXTO (length: 300)

        [MaxLength(300)]
        [StringLength(300)]
        [Display(Name = "Campo 3 texto")]
        public string Campo3Texto { get; set; } // CAMPO3_TEXTO (length: 300)

        [MaxLength(300)]
        [StringLength(300)]
        [Display(Name = "Campo 4 texto")]
        public string Campo4Texto { get; set; } // CAMPO4_TEXTO (length: 300)

        [MaxLength(300)]
        [StringLength(300)]
        [Display(Name = "Campo 5 texto")]
        public string Campo5Texto { get; set; } // CAMPO5_TEXTO (length: 300)

        [MaxLength(300)]
        [StringLength(300)]
        [Display(Name = "Campo 6 texto")]
        public string Campo6Texto { get; set; } // CAMPO6_TEXTO (length: 300)

        [MaxLength(300)]
        [StringLength(300)]
        [Display(Name = "Campo 7 texto")]
        public string Campo7Texto { get; set; } // CAMPO7_TEXTO (length: 300)

        [MaxLength(300)]
        [StringLength(300)]
        [Display(Name = "Campo 8 texto")]
        public string Campo8Texto { get; set; } // CAMPO8_TEXTO (length: 300)

        [MaxLength(300)]
        [StringLength(300)]
        [Display(Name = "Campo 9 texto")]
        public string Campo9Texto { get; set; } // CAMPO9_TEXTO (length: 300)

        [MaxLength(300)]
        [StringLength(300)]
        [Display(Name = "Campo 10 texto")]
        public string Campo10Texto { get; set; } // CAMPO10_TEXTO (length: 300)

        [DataType(DataType.DateTime)]
        [Display(Name = "Campo 1 fecha")]
        public System.DateTime? Campo1Fecha { get; set; } // CAMPO1_FECHA

        [DataType(DataType.DateTime)]
        [Display(Name = "Campo 2 fecha")]
        public System.DateTime? Campo2Fecha { get; set; } // CAMPO2_FECHA

        [DataType(DataType.DateTime)]
        [Display(Name = "Campo 3 fecha")]
        public System.DateTime? Campo3Fecha { get; set; } // CAMPO3_FECHA

        [DataType(DataType.DateTime)]
        [Display(Name = "Campo 4 fecha")]
        public System.DateTime? Campo4Fecha { get; set; } // CAMPO4_FECHA

        [DataType(DataType.DateTime)]
        [Display(Name = "Campo 5 fecha")]
        public System.DateTime? Campo5Fecha { get; set; } // CAMPO5_FECHA

        [DataType(DataType.DateTime)]
        [Display(Name = "Campo 6 fecha")]
        public System.DateTime? Campo6Fecha { get; set; } // CAMPO6_FECHA

        [DataType(DataType.DateTime)]
        [Display(Name = "Campo 7 fecha")]
        public System.DateTime? Campo7Fecha { get; set; } // CAMPO7_FECHA

        [DataType(DataType.DateTime)]
        [Display(Name = "Campo 8 fecha")]
        public System.DateTime? Campo8Fecha { get; set; } // CAMPO8_FECHA

        [DataType(DataType.DateTime)]
        [Display(Name = "Campo 9 fecha")]
        public System.DateTime? Campo9Fecha { get; set; } // CAMPO9_FECHA

        [DataType(DataType.DateTime)]
        [Display(Name = "Campo 10 fecha")]
        public System.DateTime? Campo10Fecha { get; set; } // CAMPO10_FECHA

        [Display(Name = "Campo 1 booleano")]
        public bool? Campo1Booleano { get; set; } // CAMPO1_BOOLEANO

        [Display(Name = "Campo 2 booleano")]
        public bool? Campo2Booleano { get; set; } // CAMPO2_BOOLEANO

        [Display(Name = "Campo 3 booleano")]
        public bool? Campo3Booleano { get; set; } // CAMPO3_BOOLEANO

        [Display(Name = "Campo 4 booleano")]
        public bool? Campo4Booleano { get; set; } // CAMPO4_BOOLEANO

        [Display(Name = "Campo 5 booleano")]
        public bool? Campo5Booleano { get; set; } // CAMPO5_BOOLEANO

        [Display(Name = "Campo 1 lista")]
        public string Campo1Lista { get; set; } // CAMPO1_LISTA

        [Display(Name = "Campo 2 lista")]
        public string Campo2Lista { get; set; } // CAMPO2_LISTA

        [Display(Name = "Campo 3 lista")]
        public string Campo3Lista { get; set; } // CAMPO3_LISTA

        [Display(Name = "Campo 4 lista")]
        public string Campo4Lista { get; set; } // CAMPO4_LISTA

        [Display(Name = "Campo 5 lista")]
        public string Campo5Lista { get; set; } // CAMPO5_LISTA

        [Display(Name = "Campo 1 numero")]
        public double? Campo1Numero { get; set; } // CAMPO1_NUMERO

        [Display(Name = "Campo 2 numero")]
        public double? Campo2Numero { get; set; } // CAMPO2_NUMERO

        [Display(Name = "Campo 3 numero")]
        public double? Campo3Numero { get; set; } // CAMPO3_NUMERO

        [Display(Name = "Campo 4 numero")]
        public double? Campo4Numero { get; set; } // CAMPO4_NUMERO

        [Display(Name = "Campo 5 numero")]
        public double? Campo5Numero { get; set; } // CAMPO5_NUMERO

        public LogIntNac()
        {
            IdObj = 0;
            IdTipDoc = 0;
            IdUsr = 0;
            IdUsrMod = 0;
            IdObjAux = 0;
            Campo1Texto = "";
            Campo2Texto = "";
            Campo3Texto = "";
            Campo4Texto = "";
            Campo5Texto = "";
            Campo6Texto = "";
            Campo7Texto = "";
            Campo8Texto = "";
            Campo9Texto = "";
            Campo10Texto = "";
            Campo1Booleano = false;
            Campo2Booleano = false;
            Campo3Booleano = false;
            Campo4Booleano = false;
            Campo5Booleano = false;
            Campo1Lista = "";
            Campo2Lista = "";
            Campo3Lista = "";
            Campo4Lista = "";
            Campo5Lista = "";
        }
    }

}
// </auto-generated>
