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

    // sis_tsk
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisTsk
    {
        [Required]
        [Display(Name = "Id tsk")]
        public int IdTsk { get; set; } // id_tsk (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Codigo")]
        public string Codigo { get; set; } // codigo (length: 15)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (length: 50)

        [Required]
        [Display(Name = "Tipo tsk")]
        public byte TipoTsk { get; set; } // tipo_tsk

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ini")]
        public System.DateTime FecIni { get; set; } // fec_ini

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec fin")]
        public System.DateTime FecFin { get; set; } // fec_fin

        [Required]
        [Display(Name = "Tsk tot")]
        public byte TskTot { get; set; } // tsk_tot

        [Required]
        [Display(Name = "C sol prg")]
        public byte CSolPrg { get; set; } // c_sol_prg

        [Required]
        [Display(Name = "C eje aut")]
        public byte CEjeAut { get; set; } // c_eje_aut

        [Required]
        [Display(Name = "Per task")]
        public int PerTask { get; set; } // per_task

        [Required]
        [Display(Name = "Tip prg")]
        public byte TipPrg { get; set; } // tip_prg

        [Required]
        [Display(Name = "Tipo dia")]
        public byte TipoDia { get; set; } // tipo_dia

        [Required]
        [Display(Name = "Dia mes")]
        public byte DiaMes { get; set; } // dia_mes

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Dia sem")]
        public string DiaSem { get; set; } // dia_sem (length: 10)

        [Required]
        [Display(Name = "Apl hr")]
        public byte AplHr { get; set; } // apl_hr

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Hr")]
        public System.DateTime Hr { get; set; } // hr

        [Required]
        [Display(Name = "C ult dia")]
        public byte CUltDia { get; set; } // c_ult_dia

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec sig apl")]
        public System.DateTime FecSigApl { get; set; } // fec_sig_apl

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ult apl")]
        public System.DateTime FecUltApl { get; set; } // fec_ult_apl

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec alta")]
        public System.DateTime FecAlta { get; set; } // fec_alta

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Cuerpo mail")]
        public string CuerpoMail { get; set; } // cuerpo_mail

        [Required]
        [Display(Name = "Id usr eje")]
        public int IdUsrEje { get; set; } // id_usr_eje

        [Required]
        [Display(Name = "C act")]
        public byte CAct { get; set; } // c_act

        public SisTsk()
        {
            IdTsk = 0;
            TipoTsk = 0;
            FecIni = System.DateTime.Now;
            FecFin = System.DateTime.Now;
            TskTot = 0;
            CSolPrg = 0;
            CEjeAut = 0;
            PerTask = 0;
            TipPrg = 0;
            TipoDia = 0;
            DiaMes = 0;
            AplHr = 0;
            Hr = System.DateTime.Now;
            CUltDia = 0;
            FecSigApl = System.DateTime.Now;
            FecUltApl = System.DateTime.Now;
            FecAlta = System.DateTime.Now;
            FecReg = System.DateTime.Now;
            IdUsr = 0;
            Status = 0;
            CuerpoMail = "";
            IdUsrEje = 0;
            CAct = 1;
        }
    }

}
// </auto-generated>
