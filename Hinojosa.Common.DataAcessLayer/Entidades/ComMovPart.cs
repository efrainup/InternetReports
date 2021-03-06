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

    // com_mov_part
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ComMovPart
    {
        [Required]
        [Display(Name = "Id part")]
        public int IdPart { get; set; } // id_part (Primary key)

        [Required]
        [Display(Name = "Id compra")]
        public int IdCompra { get; set; } // id_compra

        [Required]
        [Display(Name = "Id suc")]
        public int IdSuc { get; set; } // id_suc

        [Required]
        [Display(Name = "Id impto")]
        public int IdImpto { get; set; } // id_impto

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Udm")]
        public string Udm { get; set; } // udm (length: 10)

        [Required]
        [Display(Name = "Cant")]
        public double Cant { get; set; } // cant

        [Required]
        [Display(Name = "Ult cto")]
        public double UltCto { get; set; } // ult_cto

        [Required]
        [Display(Name = "Descto")]
        public double Descto { get; set; } // descto

        [Required]
        [Display(Name = "Mto descto")]
        public double MtoDescto { get; set; } // mto_descto

        [Required]
        [Display(Name = "Cto c descto")]
        public double CtoCDescto { get; set; } // cto_c_descto

        [Required]
        [Display(Name = "Importe")]
        public double Importe { get; set; } // importe

        [Required]
        [Display(Name = "Imptos")]
        public double Imptos { get; set; } // imptos

        [Required]
        [Display(Name = "Total")]
        public double Total { get; set; } // total

        [Required]
        [Display(Name = "C inv")]
        public byte CInv { get; set; } // c_inv

        ///<summary>
        /// Cantidad Pendiente de comprar (cuando es consignacion)
        ///</summary>
        [Required]
        [Display(Name = "Por comprar")]
        public double PorComprar { get; set; } // por_comprar

        ///<summary>
        /// Cantidad Devuelta al Proveedor
        ///</summary>
        [Required]
        [Display(Name = "Cant dev")]
        public double CantDev { get; set; } // cant_dev

        ///<summary>
        /// Referencia a las Partida con que se hizo la recepcion a csgn
        ///</summary>
        [Required]
        [Display(Name = "Id part csgn")]
        public int IdPartCsgn { get; set; } // id_part_csgn

        ///<summary>
        /// Monto de Gastos (Cargos Misc y Fletes)
        ///</summary>
        [Required]
        [Display(Name = "Gastos")]
        public double Gastos { get; set; } // gastos

        [Required]
        [Display(Name = "Id mda")]
        public int IdMda { get; set; } // id_mda

        [Required]
        [Display(Name = "Oper")]
        public byte Oper { get; set; } // oper

        [Required]
        [Display(Name = "Tc")]
        public double Tc { get; set; } // tc

        [Required]
        [Display(Name = "Ult cto bse")]
        public double UltCtoBse { get; set; } // ult_cto_bse

        [Required]
        [Display(Name = "Descto bse")]
        public double DesctoBse { get; set; } // descto_bse

        [Required]
        [Display(Name = "Mto descto bse")]
        public double MtoDesctoBse { get; set; } // mto_descto_bse

        [Required]
        [Display(Name = "Cto c descto bse")]
        public double CtoCDesctoBse { get; set; } // cto_c_descto_bse

        [Required]
        [Display(Name = "Importe bse")]
        public double ImporteBse { get; set; } // importe_bse

        [Required]
        [Display(Name = "Imptos bse")]
        public double ImptosBse { get; set; } // imptos_bse

        [Required]
        [Display(Name = "Total bse")]
        public double TotalBse { get; set; } // total_bse

        ///<summary>
        /// Monto de Gastos en moneda base (Cargos Misc y Fletes)
        ///</summary>
        [Required]
        [Display(Name = "Gastos bse")]
        public double GastosBse { get; set; } // gastos_bse

        [Required]
        [Display(Name = "Por recibir")]
        public double PorRecibir { get; set; } // por_recibir

        [Required]
        [Display(Name = "Id com ser lot")]
        public int IdComSerLot { get; set; } // id_com_ser_lot

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        ///<summary>
        /// Fecha Requerida
        ///</summary>
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec req")]
        public System.DateTime FecReq { get; set; } // fec_req

        [Required]
        [Display(Name = "Id part req")]
        public int IdPartReq { get; set; } // id_part_req

        [Required]
        [Display(Name = "Id kardex")]
        public int IdKardex { get; set; } // id_kardex

        ///<summary>
        /// nota de la descripcion larga
        ///</summary>
        [Required]
        [Display(Name = "Id nota desc 2")]
        public int IdNotaDesc2 { get; set; } // id_nota_desc_2

        ///<summary>
        /// id de la unidad de medida de compra
        ///</summary>
        [Required]
        [Display(Name = "Id udm")]
        public int IdUdm { get; set; } // id_udm

        ///<summary>
        /// Factor respecto a la unidad de inventario
        ///</summary>
        [Required]
        [Display(Name = "Ftr")]
        public double Ftr { get; set; } // ftr

        ///<summary>
        /// id del almacén
        ///</summary>
        [Required]
        [Display(Name = "Id alm")]
        public int IdAlm { get; set; } // id_alm

        ///<summary>
        /// id del codigo de trabajo
        ///</summary>
        [Required]
        [Display(Name = "Id cod srv")]
        public int IdCodSrv { get; set; } // id_cod_srv

        [Required]
        [Display(Name = "Id cen cto")]
        public int IdCenCto { get; set; } // id_cen_cto

        [Required]
        [Display(Name = "Id ref")]
        public int IdRef { get; set; } // id_ref

        ///<summary>
        /// id de la clasificacion del producto/servicio
        ///</summary>
        [Required]
        [Display(Name = "Id clas pro")]
        public int IdClasPro { get; set; } // id_clas_pro

        ///<summary>
        /// id de la partida del la Orden de Compra
        ///</summary>
        [Required]
        [Display(Name = "Id part oc")]
        public int IdPartOc { get; set; } // id_part_oc

        ///<summary>
        /// id del documento padre
        ///</summary>
        [Required]
        [Display(Name = "Id doc pad")]
        public int IdDocPad { get; set; } // id_doc_pad

        ///<summary>
        /// Numero de requisicion
        ///</summary>
        [Required]
        [Display(Name = "Num req")]
        public int NumReq { get; set; } // num_req

        ///<summary>
        /// Numero de Orden de Compra
        ///</summary>
        [Required]
        [Display(Name = "Num oc")]
        public int NumOc { get; set; } // num_oc

        ///<summary>
        /// Numero de cotizacion del proveedor
        ///</summary>
        [Required]
        [Display(Name = "Num cot prov")]
        public int NumCotProv { get; set; } // num_cot_prov

        ///<summary>
        /// id de la requi
        ///</summary>
        [Required]
        [Display(Name = "Id req")]
        public int IdReq { get; set; } // id_req

        ///<summary>
        /// Join con sis_rel_imptos
        ///</summary>
        [Required]
        [Display(Name = "Id rel imp")]
        public int IdRelImp { get; set; } // id_rel_imp

        [Required]
        [Display(Name = "Id prov det")]
        public int IdProvDet { get; set; } // id_prov_det

        [Required]
        [Display(Name = "C mis doc")]
        public byte CMisDoc { get; set; } // c_mis_doc

        [Required]
        [Display(Name = "C ind")]
        public byte CInd { get; set; } // c_ind

        [Required]
        [Display(Name = "Acu rec")]
        public double AcuRec { get; set; } // acu_rec

        [Required]
        [Display(Name = "Acu rec cxp")]
        public double AcuRecCxp { get; set; } // acu_rec_cxp

        [Required]
        [Display(Name = "C mod impto")]
        public int CModImpto { get; set; } // c_mod_impto

        [Required]
        [Display(Name = "Num part")]
        public int NumPart { get; set; } // num_part

        [Required]
        [Display(Name = "Acu rec cxp inv")]
        public double AcuRecCxpInv { get; set; } // acu_rec_cxp_inv

        [Required]
        [Display(Name = "Acu rec cxp ind")]
        public double AcuRecCxpInd { get; set; } // acu_rec_cxp_ind

        [Required]
        [Display(Name = "Aju inv")]
        public double AjuInv { get; set; } // aju_inv

        [Required]
        [Display(Name = "Aju ind")]
        public double AjuInd { get; set; } // aju_ind

        [Required]
        [Display(Name = "Por cxp")]
        public double PorCxp { get; set; } // por_cxp

        [Required]
        [Display(Name = "Status cxp")]
        public byte StatusCxp { get; set; } // status_cxp

        [Required]
        [Display(Name = "Id rel fac det")]
        public int IdRelFacDet { get; set; } // id_rel_fac_det

        [Required]
        [Display(Name = "Id fis rel")]
        public int IdFisRel { get; set; } // id_fis_rel

        [Required]
        [Display(Name = "Id usr cie")]
        public int IdUsrCie { get; set; } // id_usr_cie

        [Required]
        [Display(Name = "Id nota cie")]
        public int IdNotaCie { get; set; } // id_nota_cie

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg cie")]
        public System.DateTime FecRegCie { get; set; } // fec_reg_cie

        [Required]
        [Display(Name = "Cant canc")]
        public double CantCanc { get; set; } // cant_canc

        [Required]
        [Display(Name = "Importe sdcto")]
        public double ImporteSdcto { get; set; } // importe_sdcto

        [Required]
        [Display(Name = "Importe sdcto bse")]
        public double ImporteSdctoBse { get; set; } // importe_sdcto_bse

        [Required]
        [Display(Name = "Importe alm")]
        public double ImporteAlm { get; set; } // importe_alm

        [Required]
        [Display(Name = "Id bkr")]
        public int IdBkr { get; set; } // id_bkr

        [Required]
        [Display(Name = "Nlargo")]
        public double Nlargo { get; set; } // nlargo

        [Required]
        [Display(Name = "Nancho")]
        public double Nancho { get; set; } // nancho

        [Required]
        [Display(Name = "Nespesor")]
        public double Nespesor { get; set; } // nespesor

        [Required]
        [Display(Name = "Nvolumen")]
        public double Nvolumen { get; set; } // nvolumen

        [Required]
        [Display(Name = "Narea")]
        public double Narea { get; set; } // narea

        [Required]
        [Display(Name = "Npeso")]
        public double Npeso { get; set; } // npeso

        [Required]
        [Display(Name = "Cant vta")]
        public double CantVta { get; set; } // cant_vta

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Cmt")]
        public string Cmt { get; set; } // cmt (length: 50)

        [Required]
        [Display(Name = "C aju cto")]
        public double CAjuCto { get; set; } // c_aju_cto

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Num doc rec")]
        public string NumDocRec { get; set; } // num_doc_rec (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(64)]
        [StringLength(64)]
        [Display(Name = "S num lot")]
        public string SNumLot { get; set; } // sNum_Lot (length: 64)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(64)]
        [StringLength(64)]
        [Display(Name = "S num ser")]
        public string SNumSer { get; set; } // sNum_Ser (length: 64)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(64)]
        [StringLength(64)]
        [Display(Name = "S num ser fin")]
        public string SNumSerFin { get; set; } // sNum_Ser_Fin (length: 64)

        [Required]
        [Display(Name = "Id tip mt")]
        public int IdTipMt { get; set; } // id_tip_mt

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha mt")]
        public System.DateTime FechaMt { get; set; } // fecha_mt

        [Required]
        [Display(Name = "Valor mt")]
        public double ValorMt { get; set; } // valor_mt

        [Required]
        [Display(Name = "Cant real mt")]
        public double CantRealMt { get; set; } // cant_real_mt

        public ComMovPart()
        {
            PorComprar = 0;
            CantDev = 0;
            IdPartCsgn = 0;
            Gastos = 0;
            IdMda = 0;
            Oper = 0;
            Tc = 0;
            UltCtoBse = 0;
            DesctoBse = 0;
            MtoDesctoBse = 0;
            CtoCDesctoBse = 0;
            ImporteBse = 0;
            ImptosBse = 0;
            TotalBse = 0;
            GastosBse = 0;
            PorRecibir = 0;
            IdComSerLot = 0;
            IdNota = 0;
            IdPartReq = 0;
            IdKardex = 0;
            IdNotaDesc2 = 0;
            IdUdm = 0;
            Ftr = 0;
            IdAlm = 0;
            IdCodSrv = 0;
            IdCenCto = 0;
            IdRef = 0;
            IdClasPro = 0;
            IdPartOc = 0;
            IdDocPad = 0;
            NumReq = 0;
            NumOc = 0;
            NumCotProv = 0;
            IdReq = 0;
            IdRelImp = 0;
            IdProvDet = 0;
            CMisDoc = 0;
            CInd = 0;
            AcuRec = 0;
            AcuRecCxp = 0;
            CModImpto = 0;
            NumPart = 0;
            AcuRecCxpInv = 0;
            AcuRecCxpInd = 0;
            AjuInv = 0;
            AjuInd = 0;
            PorCxp = 0;
            StatusCxp = 0;
            IdRelFacDet = 0;
            IdFisRel = 0;
            IdUsrCie = 0;
            IdNotaCie = 0;
            CantCanc = 0;
            ImporteSdcto = 0;
            ImporteSdctoBse = 0;
            ImporteAlm = 0;
            IdBkr = 0;
            Nlargo = 0;
            Nancho = 0;
            Nespesor = 0;
            Nvolumen = 0;
            Narea = 0;
            Npeso = 0;
            CantVta = 0;
            Cmt = "";
            CAjuCto = 0;
            NumDocRec = "";
            SNumLot = "";
            SNumSer = "";
            SNumSerFin = "";
            IdTipMt = 0;
            ValorMt = 0;
            CantRealMt = 0;
        }
    }

}
// </auto-generated>
