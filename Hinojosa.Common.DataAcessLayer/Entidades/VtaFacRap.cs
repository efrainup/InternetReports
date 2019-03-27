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

    // vta_fac_rap
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaFacRap
    {
        [Required]
        [Display(Name = "Numero")]
        public int Numero { get; set; } // numero (Primary key)

        [Required]
        [Display(Name = "Orden")]
        public int Orden { get; set; } // orden

        [Required]
        [Display(Name = "Id cli")]
        public int IdCli { get; set; } // id_cli

        [Required]
        [Display(Name = "Id fac")]
        public int IdFac { get; set; } // id_fac

        [Required]
        [Display(Name = "Id fac det")]
        public int IdFacDet { get; set; } // id_fac_det

        [Display(Name = "Id cli fa")]
        public int? IdCliFa { get; set; } // id_cli_fa

        [Required]
        [Display(Name = "Cant")]
        public double Cant { get; set; } // cant

        [Required]
        [Display(Name = "Tipo")]
        public int Tipo { get; set; } // tipo

        [Required]
        [Display(Name = "Por docto")]
        public byte PorDocto { get; set; } // PorDocto

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required(AllowEmptyStrings = true)]
        [MaxLength(16)]
        [StringLength(16)]
        [Display(Name = "Ip")]
        public string Ip { get; set; } // ip (length: 16)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Equipo")]
        public string Equipo { get; set; } // equipo (length: 25)

        [Required]
        [Display(Name = "Id int")]
        public int IdInt { get; set; } // id_int

        [Required]
        [Display(Name = "Id ref det")]
        public int IdRefDet { get; set; } // id_ref_det

        [Required]
        [Display(Name = "Id fac det tmp")]
        public int IdFacDetTmp { get; set; } // id_fac_det_tmp

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc

        [Required]
        [Display(Name = "Id cpt")]
        public int IdCpt { get; set; } // id_cpt

        [Required]
        [Display(Name = "Id cnd")]
        public int IdCnd { get; set; } // id_cnd

        [Required]
        [Display(Name = "Id vend")]
        public int IdVend { get; set; } // id_vend

        [Required(AllowEmptyStrings = true)]
        [MaxLength(64)]
        [StringLength(64)]
        [Display(Name = "Ref ext")]
        public string RefExt { get; set; } // Ref_Ext (length: 64)

        [Required(AllowEmptyStrings = true)]
        [MaxLength]
        [Display(Name = "Nota")]
        public string Nota { get; set; } // Nota (length: 1073741823)

        [Required]
        [Display(Name = "Base grav")]
        public double BaseGrav { get; set; } // base_grav

        [Required]
        [Display(Name = "Tip hon")]
        public int TipHon { get; set; } // tip_hon

        [Required]
        [Display(Name = "Ptg hon")]
        public double PtgHon { get; set; } // ptg_hon

        [Required]
        [Display(Name = "Sec")]
        public int Sec { get; set; } // sec

        [Required]
        [Display(Name = "Id impto")]
        public int IdImpto { get; set; } // id_impto

        [Required]
        [Display(Name = "Costo")]
        public double Costo { get; set; } // costo

        [Required]
        [Display(Name = "Dcto ptg")]
        public double DctoPtg { get; set; } // dcto_ptg

        [Required]
        [Display(Name = "Dcto mto")]
        public double DctoMto { get; set; } // dcto_mto

        [Required]
        [Display(Name = "C ieps desg")]
        public byte CIepsDesg { get; set; } // c_ieps_desg

        [Required]
        [Display(Name = "Id mda")]
        public int IdMda { get; set; } // id_mda

        [Required]
        [Display(Name = "Tip cam")]
        public double TipCam { get; set; } // tip_cam

        [Required]
        [Display(Name = "Mto ant")]
        public double MtoAnt { get; set; } // mto_ant

        [Required]
        [Display(Name = "Sdo apl")]
        public double SdoApl { get; set; } // sdo_apl

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Idis cta")]
        public string IdisCta { get; set; } // idis_cta

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Tip pag cta")]
        public string TipPagCta { get; set; } // tip_pag_cta

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Bco cta")]
        public string BcoCta { get; set; } // bco_cta

        [Required]
        [Display(Name = "Id tip uso")]
        public int IdTipUso { get; set; } // id_tip_uso

        public VtaFacRap()
        {
            IdCli = 0;
            IdFac = 0;
            IdFacDet = 0;
            IdCliFa = 0;
            Cant = 0;
            Tipo = 0;
            PorDocto = 0;
            IdInt = 0;
            IdRefDet = 0;
            IdFacDetTmp = 0;
            IdTipDoc = 0;
            IdCpt = 0;
            IdCnd = 0;
            IdVend = 0;
            RefExt = "";
            Nota = "";
            BaseGrav = 0;
            TipHon = 0;
            PtgHon = 0;
            Sec = 0;
            IdImpto = 0;
            Costo = 0;
            DctoPtg = 0;
            DctoMto = 0;
            CIepsDesg = 0;
            IdMda = 0;
            TipCam = 1;
            MtoAnt = 0;
            SdoApl = 0;
            IdisCta = "";
            TipPagCta = "";
            BcoCta = "";
            IdTipUso = 0;
        }
    }

}
// </auto-generated>