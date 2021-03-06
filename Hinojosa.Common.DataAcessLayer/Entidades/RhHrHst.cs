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

    // rh_hr_hst
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class RhHrHst
    {
        [Required]
        [Display(Name = "Id hr hst")]
        public int IdHrHst { get; set; } // id_hr_hst (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Hr ent lab")]
        public System.DateTime HrEntLab { get; set; } // hr_ent_lab

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Hr fin lab")]
        public System.DateTime HrFinLab { get; set; } // hr_fin_lab

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Hr ini com")]
        public System.DateTime HrIniCom { get; set; } // hr_ini_com

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Hr fin com")]
        public System.DateTime HrFinCom { get; set; } // hr_fin_com

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Hel")]
        public System.DateTime Hel { get; set; } // hel

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Hfl")]
        public System.DateTime Hfl { get; set; } // hfl

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Hic")]
        public System.DateTime Hic { get; set; } // hic

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Hfc")]
        public System.DateTime Hfc { get; set; } // hfc

        [Required]
        [Display(Name = "C run")]
        public byte CRun { get; set; } // c_run

        [Required]
        [Display(Name = "C des")]
        public byte CDes { get; set; } // c_des

        [Required]
        [Display(Name = "C dos")]
        public byte CDos { get; set; } // c_dos

        [Required]
        [Display(Name = "Id hor")]
        public int IdHor { get; set; } // id_hor

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Device i")]
        public string DeviceI { get; set; } // device_i (length: 5)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Code t i")]
        public string CodeTI { get; set; } // codeT_i (length: 1)

        [Required]
        [Display(Name = "Code v i")]
        public int CodeVI { get; set; } // codeV_i

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Device o")]
        public string DeviceO { get; set; } // device_o (length: 5)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Code t o")]
        public string CodeTO { get; set; } // codeT_o (length: 1)

        [Required]
        [Display(Name = "Code v o")]
        public int CodeVO { get; set; } // codeV_o

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Device bl")]
        public string DeviceBl { get; set; } // device_bl (length: 5)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Code t bl")]
        public string CodeTBl { get; set; } // codeT_bl (length: 1)

        [Required]
        [Display(Name = "Code v bl")]
        public int CodeVBl { get; set; } // codeV_bl

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Device el")]
        public string DeviceEl { get; set; } // device_el (length: 5)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Code t el")]
        public string CodeTEl { get; set; } // codeT_el (length: 1)

        [Required]
        [Display(Name = "Code v el")]
        public int CodeVEl { get; set; } // codeV_el

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ent")]
        public System.DateTime FecEnt { get; set; } // fec_ent

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec sal")]
        public System.DateTime FecSal { get; set; } // fec_sal

        [Required]
        [Display(Name = "Id emp")]
        public int IdEmp { get; set; } // id_emp

        [Required]
        [Display(Name = "Id depto")]
        public int IdDepto { get; set; } // id_depto

        [Required]
        [Display(Name = "Id aux")]
        public int IdAux { get; set; } // id_aux

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
        [DataType(DataType.DateTime)]
        [Display(Name = "Hrs prog")]
        public System.DateTime HrsProg { get; set; } // hrs_prog

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Hrs real")]
        public System.DateTime HrsReal { get; set; } // hrs_real

        [Required]
        [Display(Name = "Seg prog")]
        public int SegProg { get; set; } // seg_prog

        [Required]
        [Display(Name = "Seg real")]
        public int SegReal { get; set; } // seg_real

        [Required]
        [Display(Name = "Seg ent lab h")]
        public int SegEntLabH { get; set; } // seg_ent_lab_h

        [Required]
        [Display(Name = "Seg fin lab h")]
        public int SegFinLabH { get; set; } // seg_fin_lab_h

        [Required]
        [Display(Name = "Seg ini com h")]
        public int SegIniComH { get; set; } // seg_ini_com_h

        [Required]
        [Display(Name = "Seg fin com h")]
        public int SegFinComH { get; set; } // seg_fin_com_h

        [Required]
        [Display(Name = "Seg ent lab r")]
        public int SegEntLabR { get; set; } // seg_ent_lab_r

        [Required]
        [Display(Name = "Seg fin lab r")]
        public int SegFinLabR { get; set; } // seg_fin_lab_r

        [Required]
        [Display(Name = "Seg ini com r")]
        public int SegIniComR { get; set; } // seg_ini_com_r

        [Required]
        [Display(Name = "Seg fin com r")]
        public int SegFinComR { get; set; } // seg_fin_com_r

        [Required]
        [Display(Name = "Mre")]
        public int Mre { get; set; } // mre

        [Required]
        [Display(Name = "Mrc")]
        public int Mrc { get; set; } // mrc

        [Required]
        [Display(Name = "Mae")]
        public int Mae { get; set; } // mae

        [Required]
        [Display(Name = "Mac")]
        public int Mac { get; set; } // mac

        [Required]
        [Display(Name = "Mds")]
        public int Mds { get; set; } // mds

        [Required]
        [Display(Name = "Fi")]
        public byte Fi { get; set; } // fi

        [Required]
        [Display(Name = "Fj")]
        public byte Fj { get; set; } // fj

        [Required]
        [Display(Name = "Rsg")]
        public byte Rsg { get; set; } // rsg

        [Required]
        [Display(Name = "Rcg")]
        public byte Rcg { get; set; } // rcg

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required]
        [Display(Name = "Id turno")]
        public int IdTurno { get; set; } // id_turno

        [Required]
        [Display(Name = "Vac")]
        public byte Vac { get; set; } // vac

        [Required]
        [Display(Name = "Fes")]
        public byte Fes { get; set; } // fes

        [Required]
        [Display(Name = "Mfi")]
        public int Mfi { get; set; } // mfi

        [Required]
        [Display(Name = "Mfj")]
        public int Mfj { get; set; } // mfj

        [Required]
        [Display(Name = "Mrsg")]
        public int Mrsg { get; set; } // mrsg

        [Required]
        [Display(Name = "Mrcg")]
        public int Mrcg { get; set; } // mrcg

        [Required]
        [Display(Name = "Tel")]
        public int Tel { get; set; } // tel

        [Required]
        [Display(Name = "Tec")]
        public int Tec { get; set; } // tec

        [Required]
        [Display(Name = "Rets")]
        public byte Rets { get; set; } // rets

        [Required]
        [Display(Name = "Retc")]
        public byte Retc { get; set; } // retc

        [Required]
        [Display(Name = "C tur")]
        public byte CTur { get; set; } // c_tur

        [Required]
        [Display(Name = "Na")]
        public byte Na { get; set; } // na

        [Required]
        [Display(Name = "Id cli")]
        public int IdCli { get; set; } // id_cli

        [Required]
        [Display(Name = "Id srv")]
        public int IdSrv { get; set; } // id_srv

        [Required]
        [Display(Name = "Id cen cto")]
        public int IdCenCto { get; set; } // id_cen_cto

        [Required]
        [Display(Name = "Id cod srv")]
        public int IdCodSrv { get; set; } // id_cod_srv

        [Required]
        [Display(Name = "Id ref")]
        public int IdRef { get; set; } // id_ref

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Certificado")]
        public string Certificado { get; set; } // Certificado (length: 10)

        public RhHrHst()
        {
            IdHrHst = 0;
            CRun = 0;
            CDes = 0;
            CDos = 0;
            IdHor = 0;
            DeviceI = "";
            CodeTI = "";
            CodeVI = 0;
            DeviceO = "";
            CodeTO = "";
            CodeVO = 0;
            DeviceBl = "";
            CodeTBl = "";
            CodeVBl = 0;
            DeviceEl = "";
            CodeTEl = "";
            CodeVEl = 0;
            IdEmp = 0;
            IdDepto = 0;
            IdAux = 0;
            IdUsr = 0;
            Status = 1;
            SegProg = 0;
            SegReal = 0;
            SegEntLabH = 0;
            SegFinLabH = 0;
            SegIniComH = 0;
            SegFinComH = 0;
            SegEntLabR = 0;
            SegFinLabR = 0;
            SegIniComR = 0;
            SegFinComR = 0;
            Mre = 0;
            Mrc = 0;
            Mae = 0;
            Mac = 0;
            Mds = 0;
            Fi = 0;
            Fj = 0;
            Rsg = 0;
            Rcg = 0;
            IdNota = 0;
            IdTurno = 0;
            Vac = 0;
            Fes = 0;
            Mfi = 0;
            Mfj = 0;
            Mrsg = 0;
            Mrcg = 0;
            Tel = 0;
            Tec = 0;
            Rets = 0;
            Retc = 0;
            CTur = 0;
            Na = 0;
            IdCli = 0;
            IdSrv = 0;
            IdCenCto = 0;
            IdCodSrv = 0;
            IdRef = 0;
            Certificado = "";
        }
    }

}
// </auto-generated>
