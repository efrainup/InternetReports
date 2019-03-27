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

    // cat_bonos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatBono
    {
        [Required]
        [Display(Name = "Id bono")]
        public int IdBono { get; set; } // id_bono (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Clave")]
        public string Clave { get; set; } // clave (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (length: 30)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Id otr sis")]
        public string IdOtrSis { get; set; } // id_otr_sis (length: 25)

        [Required]
        [Display(Name = "Monto")]
        public double Monto { get; set; } // monto

        [Required]
        [Display(Name = "Descto")]
        public double Descto { get; set; } // descto

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Feg reg")]
        public System.DateTime FegReg { get; set; } // feg_reg

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [Display(Name = "C prov")]
        public byte CProv { get; set; } // c_prov

        [Required]
        [Display(Name = "C imss")]
        public byte CImss { get; set; } // c_imss

        [Required]
        [Display(Name = "C tipo")]
        public byte CTipo { get; set; } // c_tipo

        [Required]
        [Display(Name = "C apl sdi")]
        public byte CAplSdi { get; set; } // c_apl_sdi

        [Required]
        [Display(Name = "C per")]
        public byte CPer { get; set; } // c_per

        [Required]
        [Display(Name = "C ded")]
        public byte CDed { get; set; } // c_ded

        [Required]
        [Display(Name = "C sdo bto")]
        public byte CSdoBto { get; set; } // c_sdo_bto

        [Required]
        [Display(Name = "Id tip dd")]
        public int IdTipDd { get; set; } // id_tip_dd

        [Required]
        [Display(Name = "Id prov")]
        public int IdProv { get; set; } // id_prov

        [Required]
        [Display(Name = "Id tip nom")]
        public int IdTipNom { get; set; } // id_tip_nom

        [Required]
        [Display(Name = "C apl dd")]
        public int CAplDd { get; set; } // c_apl_dd

        [Required]
        [Display(Name = "Id ent")]
        public int IdEnt { get; set; } // id_ent

        [Required]
        [Display(Name = "C def")]
        public byte CDef { get; set; } // c_def

        [Required]
        [Display(Name = "Id tip esq")]
        public int IdTipEsq { get; set; } // id_tip_esq

        [Required]
        [Display(Name = "C no afe per net")]
        public byte CNoAfePerNet { get; set; } // c_no_afe_per_net

        [Required]
        [Display(Name = "C prov emp")]
        public int CProvEmp { get; set; } // c_prov_emp

        [Required]
        [Display(Name = "C info")]
        public int CInfo { get; set; } // c_info

        [Required]
        [Display(Name = "C neg")]
        public int CNeg { get; set; } // c_neg

        [Required]
        [Display(Name = "C pft er")]
        public byte CPfTer { get; set; } // c_PFTer

        [Required]
        [Display(Name = "Id cta")]
        public int IdCta { get; set; } // id_cta

        [Required]
        [Display(Name = "Id tip sat")]
        public int IdTipSat { get; set; } // id_tip_sat

        [Required]
        [Display(Name = "C exen")]
        public byte CExen { get; set; } // c_exen

        [Required]
        [Display(Name = "C grav")]
        public byte CGrav { get; set; } // c_grav

        [Required]
        [Display(Name = "C pag esp")]
        public bool CPagEsp { get; set; } // c_pag_esp

        public CatBono()
        {
            IdBono = 0;
            Clave = "";
            Des = "";
            IdOtrSis = "";
            Monto = 0;
            Descto = 0;
            IdUsr = 0;
            Status = 1;
            CProv = 0;
            CImss = 0;
            CTipo = 0;
            CAplSdi = 0;
            CPer = 0;
            CDed = 0;
            CSdoBto = 0;
            IdTipDd = 0;
            IdProv = 0;
            IdTipNom = 0;
            CAplDd = 0;
            IdEnt = 0;
            CDef = 0;
            IdTipEsq = 0;
            CNoAfePerNet = 0;
            CProvEmp = 0;
            CInfo = 0;
            CNeg = 0;
            CPfTer = 0;
            IdCta = 0;
            IdTipSat = 0;
            CExen = 0;
            CGrav = 0;
            CPagEsp = false;
        }
    }

}
// </auto-generated>
