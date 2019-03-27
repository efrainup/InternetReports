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

    // cat_cajas_pdv
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatCajasPdv
    {
        [Required]
        [Display(Name = "Id caja")]
        public int IdCaja { get; set; } // id_caja (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (length: 20)

        [Required]
        [Display(Name = "Id corte")]
        public int IdCorte { get; set; } // id_corte

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fch cor")]
        public System.DateTime FchCor { get; set; } // fch_cor

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [Display(Name = "Saldo inicial")]
        public double SaldoInicial { get; set; } // saldo_inicial

        [Required]
        [Display(Name = "En uso")]
        public byte EnUso { get; set; } // en_uso

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Dir ip")]
        public string DirIp { get; set; } // dir_ip (length: 20)

        [Required]
        [Display(Name = "Id tur")]
        public int IdTur { get; set; } // id_tur

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Nom pc")]
        public string NomPc { get; set; } // nom_pc (length: 20)

        [Required]
        [Display(Name = "Id suc")]
        public int IdSuc { get; set; } // id_suc

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Limefe")]
        public decimal Limefe { get; set; } // limefe

        [Required]
        [Display(Name = "Uso tpv")]
        public int UsoTpv { get; set; } // uso_tpv

        [Required]
        [Display(Name = "Chklim")]
        public int Chklim { get; set; } // chklim

        [Required]
        [Display(Name = "Chkuso")]
        public int Chkuso { get; set; } // chkuso

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fch ini oper")]
        public System.DateTime FchIniOper { get; set; } // fch_ini_oper

        [Required]
        [Display(Name = "Time sus tick")]
        public int TimeSusTick { get; set; } // time_sus_tick

        [Required]
        [Display(Name = "Id alm")]
        public int IdAlm { get; set; } // id_alm

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fch reg")]
        public System.DateTime FchReg { get; set; } // fch_reg

        [Display(Name = "Cterminal")]
        public int? Cterminal { get; set; } // cterminal

        [Display(Name = "Id emp")]
        public int? IdEmp { get; set; } // id_emp

        [Required]
        [Display(Name = "C permite")]
        public int CPermite { get; set; } // c_permite

        [Required]
        [Display(Name = "Id caja remota")]
        public int IdCajaRemota { get; set; } // id_caja_remota

        [Required]
        [Display(Name = "Id alm serv")]
        public int IdAlmServ { get; set; } // id_alm_serv

        [Required]
        [Display(Name = "C term")]
        public byte CTerm { get; set; } // c_term

        [Required]
        [Display(Name = "Id ser rem")]
        public int IdSerRem { get; set; } // id_ser_rem

        [Required]
        [Display(Name = "Id ser fac")]
        public int IdSerFac { get; set; } // id_ser_fac

        [Required]
        [Display(Name = "Id ser nc")]
        public int IdSerNc { get; set; } // id_ser_nc

        public CatCajasPdv()
        {
            IdCaja = 0;
            Des = "";
            IdCorte = 0;
            Status = 0;
            SaldoInicial = 0;
            EnUso = 0;
            IdUsr = 0;
            DirIp = "0";
            IdTur = 0;
            NomPc = "";
            IdSuc = 0;
            Limefe = 0m;
            UsoTpv = 0;
            Chklim = 0;
            Chkuso = 0;
            TimeSusTick = 0;
            IdAlm = 0;
            FchReg = System.DateTime.Now;
            Cterminal = 0;
            CPermite = 0;
            IdCajaRemota = 0;
            IdAlmServ = 0;
            CTerm = 0;
            IdSerRem = 0;
            IdSerFac = 0;
            IdSerNc = 0;
        }
    }

}
// </auto-generated>
