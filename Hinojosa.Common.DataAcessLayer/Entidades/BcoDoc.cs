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

    // bco_doc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class BcoDoc
    {
        [Required]
        [Display(Name = "Id bco doc")]
        public int IdBcoDoc { get; set; } // id_bco_doc (Primary key)

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required]
        [Display(Name = "Id tip trn")]
        public int IdTipTrn { get; set; } // id_tip_trn

        [Required]
        [Display(Name = "Id cpt")]
        public int IdCpt { get; set; } // id_cpt

        [Required]
        [Display(Name = "Id cta")]
        public int IdCta { get; set; } // id_cta

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc

        [Required]
        [Display(Name = "Num doc")]
        public int NumDoc { get; set; } // num_doc

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec doc")]
        public System.DateTime FecDoc { get; set; } // fec_doc

        ///<summary>
        /// 1=cargo 2=abono
        ///</summary>
        [Required]
        [Display(Name = "Tipo")]
        public byte Tipo { get; set; } // tipo

        [Required]
        [Display(Name = "Num chq")]
        public int NumChq { get; set; } // num_chq

        [Required]
        [Display(Name = "Num doc cli")]
        public int NumDocCli { get; set; } // num_doc_cli

        [Required(AllowEmptyStrings = true)]
        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "Ref ben")]
        public string RefBen { get; set; } // ref_ben (length: 128)

        [Required]
        [Display(Name = "Monto")]
        public double Monto { get; set; } // monto

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [Display(Name = "Id mda")]
        public int IdMda { get; set; } // id_mda

        [Required]
        [Display(Name = "Tc")]
        public double Tc { get; set; } // tc

        [Required]
        [Display(Name = "Oper")]
        public byte Oper { get; set; } // oper

        [Required]
        [Display(Name = "Monto bse")]
        public double MontoBse { get; set; } // monto_bse

        [Required]
        [Display(Name = "C chq")]
        public byte CChq { get; set; } // c_chq

        ///<summary>
        /// 1=Aplicado 0=Pendiente de Aplicar
        ///</summary>
        [Required]
        [Display(Name = "C apl")]
        public byte CApl { get; set; } // c_apl

        ///<summary>
        /// 1=para abono en cuenta
        ///</summary>
        [Required]
        [Display(Name = "C abo cta")]
        public byte CAboCta { get; set; } // c_abo_cta

        [Required]
        [Display(Name = "Id pol")]
        public int IdPol { get; set; } // id_pol

        [Required]
        [Display(Name = "Id rel bco iva")]
        public int IdRelBcoIva { get; set; } // id_rel_bco_iva

        [Required]
        [Display(Name = "Id rel imp doc")]
        public int IdRelImpDoc { get; set; } // id_rel_imp_doc

        [Required]
        [Display(Name = "Id bco aux")]
        public int IdBcoAux { get; set; } // id_bco_aux

        [Required]
        [Display(Name = "Id cli prv")]
        public int IdCliPrv { get; set; } // id_cli_prv

        [Required]
        [Display(Name = "Id ori")]
        public byte IdOri { get; set; } // id_ori

        [Required]
        [Display(Name = "Id suc")]
        public int IdSuc { get; set; } // id_suc

        [Required]
        [Display(Name = "Saldo")]
        public double Saldo { get; set; } // Saldo

        [Required]
        [Display(Name = "Id sesion")]
        public int IdSesion { get; set; } // id_sesion

        [Required(AllowEmptyStrings = true)]
        [MaxLength(12)]
        [StringLength(12)]
        [Display(Name = "Ped")]
        public string Ped { get; set; } // ped (length: 12)

        [Required]
        [Display(Name = "Id reg nom")]
        public int IdRegNom { get; set; } // id_reg_nom

        [Required]
        [Display(Name = "C pln")]
        public byte CPln { get; set; } // c_pln

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Des pln")]
        public string DesPln { get; set; } // des_pln (length: 50)

        [Required]
        [Display(Name = "C pag dif")]
        public byte CPagDif { get; set; } // c_pag_dif

        [Required]
        [Display(Name = "Per apl ide")]
        public int PerAplIde { get; set; } // per_apl_ide

        [Required]
        [Display(Name = "C a cta de")]
        public byte CACtaDe { get; set; } // c_a_cta_de

        [Required]
        [Display(Name = "Id cta bco cta dest")]
        public int IdCtaBcoCtaDest { get; set; } // id_cta_bco_cta_dest

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Cta dest")]
        public string CtaDest { get; set; } // cta_dest (length: 25)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Clabe dest")]
        public string ClabeDest { get; set; } // clabe_dest (length: 25)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Bco cod dest")]
        public string BcoCodDest { get; set; } // bco_cod_dest (length: 20)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Des bco dest")]
        public string DesBcoDest { get; set; } // des_bco_dest (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Status sat")]
        public string StatusSat { get; set; } // statusSAT (length: 20)

        [Required]
        [Display(Name = "Id bco doc dni")]
        public int IdBcoDocDni { get; set; } // id_bco_doc_dni

        // Reverse navigation

        /// <summary>
        /// Child BcoDocDets where [bco_doc_det].[id_bco_doc] point to this entity (FK_bco_doc_det_bco_doc)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<BcoDocDet> BcoDocDets { get; set; } // bco_doc_det.FK_bco_doc_det_bco_doc

        // Foreign keys

        /// <summary>
        /// Parent BcoCuenta pointed by [bco_doc].([IdCta]) (FK_bco_doc_bco_cuentas)
        /// </summary>
        public virtual BcoCuenta BcoCuenta { get; set; } // FK_bco_doc_bco_cuentas

        /// <summary>
        /// Parent BcoTipTrn pointed by [bco_doc].([IdTipTrn]) (FK_bco_doc_bco_tip_trn)
        /// </summary>
        public virtual BcoTipTrn BcoTipTrn { get; set; } // FK_bco_doc_bco_tip_trn

        /// <summary>
        /// Parent MonMoneda pointed by [bco_doc].([IdMda]) (FK_bco_doc_mon_monedas)
        /// </summary>
        public virtual MonMoneda MonMoneda { get; set; } // FK_bco_doc_mon_monedas

        /// <summary>
        /// Parent SisConcepto pointed by [bco_doc].([IdCpt]) (FK_bco_doc_bco_conceptos)
        /// </summary>
        public virtual SisConcepto SisConcepto { get; set; } // FK_bco_doc_bco_conceptos

        /// <summary>
        /// Parent SisNota pointed by [bco_doc].([IdNota]) (FK_bco_doc_sis_notas)
        /// </summary>
        public virtual SisNota SisNota { get; set; } // FK_bco_doc_sis_notas

        public BcoDoc()
        {
            IdBcoDoc = 0;
            IdUsr = 0;
            IdNota = 0;
            IdTipTrn = 0;
            IdCpt = 0;
            IdCta = 0;
            NumDoc = 0;
            Tipo = 1;
            NumChq = 0;
            NumDocCli = 0;
            RefBen = "";
            Monto = 0;
            Status = 1;
            IdMda = 0;
            Tc = 0;
            Oper = 0;
            MontoBse = 0;
            CChq = 0;
            CApl = 1;
            CAboCta = 0;
            IdPol = 0;
            IdRelBcoIva = 0;
            IdRelImpDoc = 0;
            IdBcoAux = 0;
            IdCliPrv = 0;
            IdOri = 0;
            IdSuc = 0;
            Saldo = 0;
            IdSesion = 0;
            Ped = "";
            IdRegNom = 0;
            CPln = 0;
            DesPln = "";
            CPagDif = 0;
            PerAplIde = 0;
            CACtaDe = 0;
            IdCtaBcoCtaDest = 0;
            CtaDest = "";
            ClabeDest = "";
            BcoCodDest = "";
            DesBcoDest = "";
            StatusSat = "";
            IdBcoDocDni = 0;
            BcoDocDets = new System.Collections.Generic.List<BcoDocDet>();
        }
    }

}
// </auto-generated>
