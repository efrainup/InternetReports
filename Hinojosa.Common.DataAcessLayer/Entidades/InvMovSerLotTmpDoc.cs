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

    // inv_mov_ser_lot_tmp_doc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class InvMovSerLotTmpDoc
    {
        [Required]
        [Display(Name = "Id mov ser lot")]
        public int IdMovSerLot { get; set; } // id_mov_ser_lot (Primary key)

        [Required]
        [Display(Name = "Id ser lot")]
        public int IdSerLot { get; set; } // id_ser_lot

        [Required]
        [Display(Name = "Id almac")]
        public int IdAlmac { get; set; } // id_almac

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc

        [Required]
        [Display(Name = "Id doc")]
        public int IdDoc { get; set; } // id_doc

        [Required]
        [Display(Name = "Num doc")]
        public int NumDoc { get; set; } // num_doc

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha")]
        public System.DateTime Fecha { get; set; } // fecha

        [Required]
        [Display(Name = "Cant")]
        public double Cant { get; set; } // cant

        [Required]
        [Display(Name = "Tipo")]
        public byte Tipo { get; set; } // tipo

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec elab")]
        public System.DateTime FecElab { get; set; } // fec_elab

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec cad")]
        public System.DateTime FecCad { get; set; } // fec_cad

        [Required]
        [Display(Name = "Id sis cnl")]
        public int IdSisCnl { get; set; } // id_sis_cnl

        [Required(AllowEmptyStrings = true)]
        [MaxLength(64)]
        [StringLength(64)]
        [Display(Name = "Num lot")]
        public string NumLot { get; set; } // num_lot (length: 64)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(64)]
        [StringLength(64)]
        [Display(Name = "Num ser")]
        public string NumSer { get; set; } // num_ser (length: 64)

        [Required]
        [Display(Name = "C ped")]
        public byte CPed { get; set; } // c_ped

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Num ped")]
        public string NumPed { get; set; } // num_ped (length: 30)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Aduana")]
        public string Aduana { get; set; } // aduana (length: 50)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha ped")]
        public System.DateTime FechaPed { get; set; } // fecha_ped

        [Required]
        [Display(Name = "Id udm")]
        public int IdUdm { get; set; } // id_udm

        [Required]
        [Display(Name = "Ftr")]
        public double Ftr { get; set; } // ftr

        [Required]
        [Display(Name = "Cant inv")]
        public double CantInv { get; set; } // cant_inv

        [Required]
        [Display(Name = "Id ref")]
        public int IdRef { get; set; } // id_ref

        [Required]
        [Display(Name = "Id cen cto")]
        public int IdCenCto { get; set; } // id_cen_cto

        [Required]
        [Display(Name = "Id cod srv")]
        public int IdCodSrv { get; set; } // id_cod_srv

        [Required]
        [Display(Name = "Id cli")]
        public int IdCli { get; set; } // id_cli

        [Required]
        [Display(Name = "Id prov")]
        public int IdProv { get; set; } // id_prov

        [Required]
        [Display(Name = "Id cli fa da")]
        public int IdCliFaDa { get; set; } // id_cli_fa_da

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Serie")]
        public string Serie { get; set; } // serie (length: 10)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Id ver")]
        public int IdVer { get; set; } // id_ver

        [Required(AllowEmptyStrings = true)]
        [MaxLength(64)]
        [StringLength(64)]
        [Display(Name = "Num ser fin")]
        public string NumSerFin { get; set; } // num_ser_fin (length: 64)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Patente")]
        public string Patente { get; set; } // patente (length: 10)

        [Required]
        [Display(Name = "Costo")]
        public double Costo { get; set; } // costo

        [Required]
        [Display(Name = "Costo total")]
        public double CostoTotal { get; set; } // costo_total

        [Required]
        [Display(Name = "Precio")]
        public double Precio { get; set; } // precio

        [Required]
        [Display(Name = "Importe")]
        public double Importe { get; set; } // importe

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
        [Display(Name = "Precio bse")]
        public double PrecioBse { get; set; } // precio_bse

        [Required]
        [Display(Name = "Importe bse")]
        public double ImporteBse { get; set; } // importe_bse

        [Required]
        [Display(Name = "Id mto ser lot")]
        public int IdMtoSerLot { get; set; } // id_mto_ser_lot

        [Required]
        [Display(Name = "Id ped")]
        public int IdPed { get; set; } // id_ped

        [Required]
        [Display(Name = "Costo bse")]
        public double CostoBse { get; set; } // costo_bse

        [Required]
        [Display(Name = "Costo total bse")]
        public double CostoTotalBse { get; set; } // costo_total_bse

        [Required]
        [Display(Name = "Costo ind")]
        public double CostoInd { get; set; } // costo_ind

        [Required]
        [Display(Name = "Id mda ind")]
        public int IdMdaInd { get; set; } // id_mda_ind

        [Required]
        [Display(Name = "Oper ind")]
        public byte OperInd { get; set; } // oper_ind

        [Required]
        [Display(Name = "Tc ind")]
        public double TcInd { get; set; } // tc_ind

        [Required]
        [Display(Name = "Costo ind bse")]
        public double CostoIndBse { get; set; } // costo_ind_bse

        [Required]
        [Display(Name = "Tipo trans")]
        public byte TipoTrans { get; set; } // tipo_trans

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "S marca")]
        public string SMarca { get; set; } // sMarca (length: 80)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S serie prov")]
        public string SSerieProv { get; set; } // sSerieProv (length: 100)

        [Required]
        [Display(Name = "Tipo ped")]
        public byte TipoPed { get; set; } // tipo_ped

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro

        [Required]
        [Display(Name = "Costo lote")]
        public double CostoLote { get; set; } // costo_lote

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "S etiqueta")]
        public string SEtiqueta { get; set; } // sEtiqueta (length: 250)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "S etiqueta 2")]
        public string SEtiqueta2 { get; set; } // sEtiqueta2 (length: 250)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "S etiqueta 3")]
        public string SEtiqueta3 { get; set; } // sEtiqueta3 (length: 250)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "S etiqueta 4")]
        public string SEtiqueta4 { get; set; } // sEtiqueta4 (length: 250)

        [Required]
        [Display(Name = "C imp")]
        public byte CImp { get; set; } // c_imp

        // Foreign keys

        /// <summary>
        /// Parent CatAlmac pointed by [inv_mov_ser_lot_tmp_doc].([IdAlmac]) (FK_inv_mov_ser_lot_cat_almac_tmp_doc)
        /// </summary>
        public virtual CatAlmac CatAlmac { get; set; } // FK_inv_mov_ser_lot_cat_almac_tmp_doc

        /// <summary>
        /// Parent CatDocto pointed by [inv_mov_ser_lot_tmp_doc].([IdTipDoc]) (FK_inv_mov_ser_lot_cat_doctos_tmp_doc)
        /// </summary>
        public virtual CatDocto CatDocto { get; set; } // FK_inv_mov_ser_lot_cat_doctos_tmp_doc

        /// <summary>
        /// Parent CatUsr pointed by [inv_mov_ser_lot_tmp_doc].([IdUsr]) (FK_inv_mov_ser_lot_cat_usr_tmp_doc)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_inv_mov_ser_lot_cat_usr_tmp_doc

        /// <summary>
        /// Parent InvSerLot pointed by [inv_mov_ser_lot_tmp_doc].([IdSerLot]) (FK_inv_mov_ser_lot_inv_ser_lot_tmp_doc)
        /// </summary>
        public virtual InvSerLot InvSerLot { get; set; } // FK_inv_mov_ser_lot_inv_ser_lot_tmp_doc

        public InvMovSerLotTmpDoc()
        {
            IdMovSerLot = 0;
            IdSerLot = 0;
            IdAlmac = 0;
            IdUsr = 0;
            IdTipDoc = 0;
            IdDoc = 0;
            NumDoc = 0;
            Cant = 0;
            Tipo = 1;
            IdSisCnl = 0;
            NumLot = "";
            NumSer = "";
            CPed = 0;
            NumPed = "";
            Aduana = "";
            IdUdm = 0;
            Ftr = 0;
            CantInv = 0;
            IdRef = 0;
            IdCenCto = 0;
            IdCodSrv = 0;
            IdCli = 0;
            IdProv = 0;
            IdCliFaDa = 0;
            Serie = "";
            IdVer = 0;
            NumSerFin = "";
            Patente = "";
            Costo = 0;
            CostoTotal = 0;
            Precio = 0;
            Importe = 0;
            IdMda = 0;
            Oper = 0;
            Tc = 0;
            PrecioBse = 0;
            ImporteBse = 0;
            IdMtoSerLot = 0;
            IdPed = 0;
            CostoBse = 0;
            CostoTotalBse = 0;
            CostoInd = 0;
            IdMdaInd = 0;
            OperInd = 0;
            TcInd = 0;
            CostoIndBse = 0;
            TipoTrans = 0;
            SMarca = "";
            SSerieProv = "";
            TipoPed = 0;
            IdPro = 0;
            CostoLote = 0;
            SEtiqueta = "";
            SEtiqueta2 = "";
            SEtiqueta3 = "";
            SEtiqueta4 = "";
            CImp = 0;
        }
    }

}
// </auto-generated>
