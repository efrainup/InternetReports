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

    // act_temporal
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ActTemporal
    {
        [Required]
        [Display(Name = "Id act")]
        public int IdAct { get; set; } // id_act (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Codigo")]
        public string Codigo { get; set; } // codigo (Primary key) (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (Primary key) (length: 128)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(64)]
        [StringLength(64)]
        [Display(Name = "Marca")]
        public string Marca { get; set; } // marca (Primary key) (length: 64)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(64)]
        [StringLength(64)]
        [Display(Name = "Modelo")]
        public string Modelo { get; set; } // modelo (Primary key) (length: 64)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(64)]
        [StringLength(64)]
        [Display(Name = "Serie")]
        public string Serie { get; set; } // serie (Primary key) (length: 64)

        [Required]
        [Display(Name = "Id tip")]
        public int IdTip { get; set; } // id_tip (Primary key)

        [Required]
        [Display(Name = "Id clas ctb")]
        public int IdClasCtb { get; set; } // id_clas_ctb (Primary key)

        [Required]
        [Display(Name = "Id clas 1")]
        public int IdClas1 { get; set; } // id_clas1 (Primary key)

        [Required]
        [Display(Name = "Id clas 2")]
        public int IdClas2 { get; set; } // id_clas2 (Primary key)

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota (Primary key)

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc (Primary key)

        [Required]
        [Display(Name = "Id doc")]
        public int IdDoc { get; set; } // id_doc (Primary key)

        [Required]
        [Display(Name = "Id part")]
        public int IdPart { get; set; } // id_part (Primary key)

        [Required]
        [Display(Name = "Id mto ser lot")]
        public int IdMtoSerLot { get; set; } // id_mto_ser_lot (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec com")]
        public System.DateTime FecCom { get; set; } // fec_com (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Folio com")]
        public string FolioCom { get; set; } // folio_com (Primary key) (length: 20)

        [Required]
        [Display(Name = "Valor com")]
        public double ValorCom { get; set; } // valor_com (Primary key)

        [Required]
        [Display(Name = "Id prov")]
        public int IdProv { get; set; } // id_prov (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ini dep")]
        public System.DateTime FecIniDep { get; set; } // fec_ini_dep (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ult dep")]
        public System.DateTime FecUltDep { get; set; } // fec_ult_dep (Primary key)

        [Required]
        [Display(Name = "Met dep")]
        public byte MetDep { get; set; } // met_dep (Primary key)

        [Required]
        [Display(Name = "Ptg dep")]
        public double PtgDep { get; set; } // ptg_dep (Primary key)

        [Required]
        [Display(Name = "Dep acu")]
        public double DepAcu { get; set; } // dep_acu (Primary key)

        [Required]
        [Display(Name = "Dep max")]
        public double DepMax { get; set; } // dep_max (Primary key)

        [Required]
        [Display(Name = "Status dep")]
        public byte StatusDep { get; set; } // status_dep (Primary key)

        [Required]
        [Display(Name = "Id tip baj")]
        public int IdTipBaj { get; set; } // id_tip_baj (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec alta")]
        public System.DateTime FecAlta { get; set; } // fec_alta (Primary key)

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg (Primary key)

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status (Primary key)

        [Required]
        [Display(Name = "Id depto")]
        public int IdDepto { get; set; } // id_depto (Primary key)

        [Required]
        [Display(Name = "Id emp")]
        public int IdEmp { get; set; } // id_emp (Primary key)

        [Display(Name = "Vida")]
        public double? Vida { get; set; } // vida

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ini dep erp")]
        public System.DateTime FecIniDepErp { get; set; } // fec_ini_dep_ERP (Primary key)

        [Display(Name = "Vida dep")]
        public double? VidaDep { get; set; } // vida_dep

        [Required]
        [Display(Name = "Id mda")]
        public int IdMda { get; set; } // id_mda (Primary key)

        [Required]
        [Display(Name = "Oper")]
        public byte Oper { get; set; } // oper (Primary key)

        [Required]
        [Display(Name = "Tc")]
        public double Tc { get; set; } // tc (Primary key)

        [Required]
        [Display(Name = "Valor com base")]
        public double ValorComBase { get; set; } // valor_com_base (Primary key)

        [Required]
        [Display(Name = "Met dep fis")]
        public byte MetDepFis { get; set; } // met_dep_fis (Primary key)

        [Required]
        [Display(Name = "Valor ga")]
        public double ValorGa { get; set; } // valor_ga (Primary key)

        [Required]
        [Display(Name = "Id mda ga")]
        public int IdMdaGa { get; set; } // id_mda_ga (Primary key)

        [Required]
        [Display(Name = "Oper ga")]
        public byte OperGa { get; set; } // oper_ga (Primary key)

        [Required]
        [Display(Name = "Tc ga")]
        public double TcGa { get; set; } // tc_ga (Primary key)

        [Required]
        [Display(Name = "Valor ga base")]
        public double ValorGaBase { get; set; } // valor_ga_base (Primary key)

        [Required]
        [Display(Name = "Id nota ga")]
        public int IdNotaGa { get; set; } // id_nota_ga (Primary key)

        [Required]
        [Display(Name = "C afe")]
        public byte CAfe { get; set; } // c_afe (Primary key)

        [Required]
        [Display(Name = "Dep acu fis")]
        public double DepAcuFis { get; set; } // dep_acu_fis (Primary key)

        [Required]
        [Display(Name = "Status dep fis")]
        public byte StatusDepFis { get; set; } // status_dep_fis (Primary key)

        [Required]
        [Display(Name = "Ptg dep max")]
        public double PtgDepMax { get; set; } // ptg_dep_max (Primary key)

        [Display(Name = "Vida dep fis")]
        public double? VidaDepFis { get; set; } // vida_dep_fis

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ini dep fis")]
        public System.DateTime FecIniDepFis { get; set; } // fec_ini_dep_fis (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ini dep fis erp")]
        public System.DateTime FecIniDepFisErp { get; set; } // fec_ini_dep_fis_ERP (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ult dep fis")]
        public System.DateTime FecUltDepFis { get; set; } // fec_ult_dep_fis (Primary key)

        [Required]
        [Display(Name = "C afe fis")]
        public byte CAfeFis { get; set; } // c_afe_fis (Primary key)

        [Required]
        [Display(Name = "Id cen cto")]
        public int IdCenCto { get; set; } // id_cen_cto (Primary key)

        [Required]
        [Display(Name = "Id cod srv")]
        public int IdCodSrv { get; set; } // id_cod_srv (Primary key)

        [Required]
        [Display(Name = "Id ref")]
        public int IdRef { get; set; } // id_ref (Primary key)

        [Required]
        [Display(Name = "Id ult pol")]
        public int IdUltPol { get; set; } // id_ult_pol (Primary key)

        [Required]
        [Display(Name = "Intervalo")]
        public int Intervalo { get; set; } // intervalo (Primary key)

        [Required]
        [Display(Name = "Valor base")]
        public double ValorBase { get; set; } // valor_base (Primary key)

        [Required]
        [Display(Name = "Id alm")]
        public int IdAlm { get; set; } // id_alm (Primary key)

        [Required]
        [Display(Name = "Id per ult dep")]
        public int IdPerUltDep { get; set; } // id_per_ult_dep (Primary key)

        [Required]
        [Display(Name = "Id per ult dep fis")]
        public int IdPerUltDepFis { get; set; } // id_per_ult_dep_fis (Primary key)

        [Required]
        [Display(Name = "Id rel car")]
        public int IdRelCar { get; set; } // id_rel_car (Primary key)

        [Required]
        [Display(Name = "C mult asig")]
        public int CMultAsig { get; set; } // c_mult_asig (Primary key)

        [Required]
        [Display(Name = "Id rel emp")]
        public int IdRelEmp { get; set; } // id_rel_emp (Primary key)

        [Required]
        [Display(Name = "C valor asig")]
        public byte CValorAsig { get; set; } // c_valor_asig (Primary key)

        [Required]
        [Display(Name = "Valor asig")]
        public double ValorAsig { get; set; } // valor_asig (Primary key)

        [Display(Name = "Vida fis")]
        public double? VidaFis { get; set; } // vida_fis

        [Required]
        [Display(Name = "Tip act")]
        public byte TipAct { get; set; } // tip_act (Primary key)

        [Required]
        [Display(Name = "C seg pag ant")]
        public byte CSegPagAnt { get; set; } // c_seg_pag_ant (Primary key)

        [Required]
        [Display(Name = "Inpc com")]
        public double InpcCom { get; set; } // inpc_com (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec vig")]
        public System.DateTime FecVig { get; set; } // fec_vig (Primary key)

        [Required]
        [Display(Name = "Id cmp")]
        public int IdCmp { get; set; } // id_cmp (Primary key)

        [Required]
        [Display(Name = "C intangible")]
        public byte CIntangible { get; set; } // c_intangible (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec gar")]
        public System.DateTime FecGar { get; set; } // fec_gar (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec gar ext")]
        public System.DateTime FecGarExt { get; set; } // fec_gar_ext (Primary key)

        [Required]
        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; } // cantidad (Primary key)

        [Required]
        [Display(Name = "Asegurable")]
        public byte Asegurable { get; set; } // asegurable (Primary key)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Compa ia")]
        public string Compañia { get; set; } // compañia (Primary key)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Numpol")]
        public string Numpol { get; set; } // numpol (Primary key)
    }

}
// </auto-generated>
