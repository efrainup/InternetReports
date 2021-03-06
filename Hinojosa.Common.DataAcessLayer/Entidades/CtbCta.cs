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

    // ctb_cta
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CtbCta
    {
        [Required]
        [Display(Name = "Id cta")]
        public int IdCta { get; set; } // id_cta (Primary key)

        [Required]
        [Display(Name = "Id tip")]
        public int IdTip { get; set; } // id_tip

        [Required]
        [Display(Name = "Id cta pad")]
        public int IdCtaPad { get; set; } // id_cta_pad

        [Required]
        [Display(Name = "Id cta int")]
        public int IdCtaInt { get; set; } // id_cta_int

        [Required]
        [Display(Name = "Id clas 1")]
        public int IdClas1 { get; set; } // id_clas1

        [Required]
        [Display(Name = "Id clas 2")]
        public int IdClas2 { get; set; } // id_clas2

        [Required]
        [Display(Name = "Id rel clas")]
        public int IdRelClas { get; set; } // id_rel_clas

        [Required]
        [Display(Name = "Id cen cto")]
        public int IdCenCto { get; set; } // id_cen_cto

        [Required]
        [Display(Name = "Id ent")]
        public int IdEnt { get; set; } // id_ent

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Num cta")]
        public string NumCta { get; set; } // num_cta (length: 25)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Nom")]
        public string Nom { get; set; } // nom (length: 80)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Nom 2")]
        public string Nom2 { get; set; } // nom2 (length: 80)

        [Required]
        [Display(Name = "Nat")]
        public byte Nat { get; set; } // nat

        [Required]
        [Display(Name = "May")]
        public byte May { get; set; } // may

        [Required]
        [Display(Name = "C acu")]
        public byte CAcu { get; set; } // c_acu

        [Required]
        [Display(Name = "C efe")]
        public byte CEfe { get; set; } // c_efe

        [Required]
        [Display(Name = "C int")]
        public byte CInt { get; set; } // c_int

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec alta")]
        public System.DateTime FecAlta { get; set; } // fec_alta

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ult pol")]
        public System.DateTime FecUltPol { get; set; } // fec_ult_pol

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Saldo")]
        public decimal Saldo { get; set; } // saldo

        [Required]
        [DataType(DataType.Currency)]
        [Display(Name = "Presup")]
        public decimal Presup { get; set; } // presup

        [Required]
        [Display(Name = "Nivel")]
        public byte Nivel { get; set; } // nivel

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required]
        [Display(Name = "Id emp")]
        public int IdEmp { get; set; } // id_emp

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [Display(Name = "Id mda")]
        public int IdMda { get; set; } // id_mda

        [Required]
        [Display(Name = "C dis")]
        public int CDis { get; set; } // c_dis

        [Required]
        [Display(Name = "C est")]
        public int CEst { get; set; } // c_est

        [Required]
        [Display(Name = "C reexp")]
        public byte CReexp { get; set; } // c_reexp

        [Required]
        [Display(Name = "Id udm")]
        public int IdUdm { get; set; } // id_udm

        [Required]
        [Display(Name = "Id cta rel")]
        public int IdCtaRel { get; set; } // id_cta_rel

        [Required]
        [Display(Name = "C no ded")]
        public byte CNoDed { get; set; } // c_no_ded

        [Required]
        [Display(Name = "C acum recep")]
        public byte CAcumRecep { get; set; } // c_acum_recep

        ///<summary>
        /// Identificador único del tipo, llave foránea a sis_tip.
        ///</summary>
        [Required]
        [Display(Name = "Id tip sit fin")]
        public int IdTipSitFin { get; set; } // id_tip_sit_fin

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Id otr sis")]
        public string IdOtrSis { get; set; } // id_otr_sis (length: 25)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Indice sipiad")]
        public string IndiceSipiad { get; set; } // indice_sipiad (length: 25)

        [Required]
        [Display(Name = "Id tip sat")]
        public int IdTipSat { get; set; } // id_tip_sat

        [Required]
        [Display(Name = "C omite ce")]
        public byte COmiteCe { get; set; } // c_omite_CE

        public CtbCta()
        {
            IdCta = 0;
            IdTip = 0;
            IdCtaPad = 0;
            IdCtaInt = 0;
            IdClas1 = 0;
            IdClas2 = 0;
            IdRelClas = 0;
            IdCenCto = 0;
            IdEnt = 0;
            NumCta = "";
            Nom = "";
            Nom2 = "";
            Nat = 0;
            May = 0;
            CAcu = 0;
            CEfe = 0;
            CInt = 0;
            Saldo = 0m;
            Presup = 0m;
            Nivel = 0;
            IdNota = 0;
            IdEmp = 0;
            IdUsr = 0;
            Status = 1;
            IdMda = 0;
            CDis = 0;
            CEst = 0;
            CReexp = 0;
            IdUdm = 0;
            IdCtaRel = 0;
            CNoDed = 0;
            CAcumRecep = 0;
            IdTipSitFin = 0;
            IdOtrSis = "";
            IndiceSipiad = "";
            IdTipSat = 0;
            COmiteCe = 0;
        }
    }

}
// </auto-generated>
