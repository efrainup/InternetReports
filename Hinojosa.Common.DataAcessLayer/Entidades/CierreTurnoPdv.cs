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

    // cierre_turno_pdv
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CierreTurnoPdv
    {
        [Required]
        [Display(Name = "Id cierre turno pdv")]
        public int IdCierreTurnoPdv { get; set; } // id_cierre_turno_pdv (Primary key)

        [Required]
        [Display(Name = "Id caja")]
        public int IdCaja { get; set; } // id_caja (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (Primary key) (length: 20)

        [Required]
        [Display(Name = "Id corte")]
        public int IdCorte { get; set; } // id_corte (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fch cor")]
        public System.DateTime FchCor { get; set; } // fch_cor (Primary key)

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status (Primary key)

        [Required]
        [Display(Name = "Saldo inicial")]
        public double SaldoInicial { get; set; } // saldo_inicial (Primary key)

        [Required]
        [Display(Name = "En uso")]
        public byte EnUso { get; set; } // en_uso (Primary key)

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Dir ip")]
        public string DirIp { get; set; } // dir_ip (Primary key) (length: 20)

        [Required]
        [Display(Name = "Id tur")]
        public int IdTur { get; set; } // id_tur (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Nom pc")]
        public string NomPc { get; set; } // nom_pc (Primary key) (length: 20)

        [Required]
        [Display(Name = "Id suc")]
        public int IdSuc { get; set; } // id_suc (Primary key)

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Limefe")]
        public decimal Limefe { get; set; } // limefe (Primary key)

        [Required]
        [Display(Name = "Uso tpv")]
        public int UsoTpv { get; set; } // uso_tpv (Primary key)

        [Required]
        [Display(Name = "Chklim")]
        public int Chklim { get; set; } // chklim (Primary key)

        [Required]
        [Display(Name = "Chkuso")]
        public int Chkuso { get; set; } // chkuso (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fch ini oper")]
        public System.DateTime FchIniOper { get; set; } // fch_ini_oper (Primary key)

        [Required]
        [Display(Name = "Time sus tick")]
        public int TimeSusTick { get; set; } // time_sus_tick (Primary key)

        [Required]
        [Display(Name = "Id alm")]
        public int IdAlm { get; set; } // id_alm (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fch reg")]
        public System.DateTime FchReg { get; set; } // fch_reg (Primary key)

        [Display(Name = "Cterminal")]
        public int? Cterminal { get; set; } // cterminal

        [Display(Name = "Id emp")]
        public int? IdEmp { get; set; } // id_emp

        [Display(Name = "Id cor caj")]
        public int? IdCorCaj { get; set; } // id_cor_caj
    }

}
// </auto-generated>
