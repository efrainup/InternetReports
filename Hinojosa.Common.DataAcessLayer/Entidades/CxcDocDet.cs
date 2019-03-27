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

    // cxc_doc_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CxcDocDet
    {
        [Required]
        [Display(Name = "Id cxc doc det")]
        public int IdCxcDocDet { get; set; } // id_cxc_doc_det (Primary key)

        [Required]
        [Display(Name = "Id cxc doc")]
        public int IdCxcDoc { get; set; } // id_cxc_doc

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required]
        [Display(Name = "Id ent")]
        public int IdEnt { get; set; } // id_ent

        [Required]
        [Display(Name = "Id fact")]
        public int IdFact { get; set; } // id_fact

        [Required]
        [Display(Name = "Id cod svr")]
        public int IdCodSvr { get; set; } // id_cod_svr

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Ref")]
        public string @Ref { get; set; } // ref (length: 25)

        [Required]
        [Display(Name = "Ptg descto")]
        public double PtgDescto { get; set; } // ptg_descto

        [Required]
        [Display(Name = "Importe")]
        public double Importe { get; set; } // importe

        [Required]
        [Display(Name = "Descto")]
        public double Descto { get; set; } // descto

        [Required]
        [Display(Name = "Monto simpto")]
        public double MontoSimpto { get; set; } // monto_simpto

        [Required]
        [Display(Name = "Imptos")]
        public double Imptos { get; set; } // imptos

        [Required]
        [Display(Name = "Total")]
        public double Total { get; set; } // total

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
        [Display(Name = "Importe bse")]
        public double ImporteBse { get; set; } // importe_bse

        [Required]
        [Display(Name = "Descto bse")]
        public double DesctoBse { get; set; } // descto_bse

        [Required]
        [Display(Name = "Monto simpto bse")]
        public double MontoSimptoBse { get; set; } // monto_simpto_bse

        [Required]
        [Display(Name = "Imptos bse")]
        public double ImptosBse { get; set; } // imptos_bse

        [Required]
        [Display(Name = "Total bse")]
        public double TotalBse { get; set; } // total_bse

        ///<summary>
        /// 1=Entidad 2=Recepcion 3=Orden de Compra
        ///</summary>
        [Required]
        [Display(Name = "Tipo")]
        public byte Tipo { get; set; } // tipo

        ///<summary>
        /// numero de documento origen (orden de compra, Recepcion)
        ///</summary>
        [Required]
        [Display(Name = "Num doc orig")]
        public int NumDocOrig { get; set; } // num_doc_orig

        ///<summary>
        /// Id de la partida origen (Orden de Compra / Recepción)
        ///</summary>
        [Required]
        [Display(Name = "Id part orig")]
        public int IdPartOrig { get; set; } // id_part_orig

        [Required]
        [Display(Name = "Id cen cto")]
        public int IdCenCto { get; set; } // id_cen_cto

        [Required]
        [Display(Name = "Id ref")]
        public int IdRef { get; set; } // id_ref

        [Required]
        [Display(Name = "Id impto")]
        public int IdImpto { get; set; } // id_impto

        [Required]
        [Display(Name = "Id rel imp")]
        public int IdRelImp { get; set; } // id_rel_imp

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro

        [Required]
        [Display(Name = "Id clas pro")]
        public int IdClasPro { get; set; } // id_clas_pro

        [Required]
        [Display(Name = "Cant")]
        public double Cant { get; set; } // cant

        [Required]
        [Display(Name = "Costo")]
        public double Costo { get; set; } // costo

        [Required]
        [Display(Name = "Costo cdcto")]
        public double CostoCdcto { get; set; } // costo_cdcto

        [Required]
        [Display(Name = "Id alm")]
        public int IdAlm { get; set; } // id_alm

        [Required]
        [Display(Name = "Costo total")]
        public double CostoTotal { get; set; } // costo_total

        ///<summary>
        /// 0=No Se modifico el Impuesto 1=Impuesto Manual
        ///</summary>
        [Required]
        [Display(Name = "Mod impto")]
        public byte ModImpto { get; set; } // mod_impto

        [Required]
        [Display(Name = "Id fis rel")]
        public int IdFisRel { get; set; } // id_fis_rel

        [Required(AllowEmptyStrings = true)]
        [MaxLength(64)]
        [StringLength(64)]
        [Display(Name = "Ref ext")]
        public string RefExt { get; set; } // ref_ext (length: 64)

        [Required]
        [Display(Name = "Id int")]
        public int IdInt { get; set; } // id_int

        public CxcDocDet()
        {
            IdCxcDocDet = 0;
            IdCxcDoc = 0;
            IdNota = 0;
            IdEnt = 0;
            IdFact = 0;
            IdCodSvr = 0;
            @Ref = "";
            PtgDescto = 0;
            Importe = 0;
            Descto = 0;
            MontoSimpto = 0;
            Imptos = 0;
            Total = 0;
            IdMda = 0;
            Tc = 0;
            Oper = 0;
            ImporteBse = 0;
            DesctoBse = 0;
            MontoSimptoBse = 0;
            ImptosBse = 0;
            TotalBse = 0;
            Tipo = 1;
            NumDocOrig = 0;
            IdPartOrig = 0;
            IdCenCto = 0;
            IdRef = 0;
            IdImpto = 0;
            IdRelImp = 0;
            IdPro = 0;
            IdClasPro = 0;
            Cant = 0;
            Costo = 0;
            CostoCdcto = 0;
            IdAlm = 0;
            CostoTotal = 0;
            ModImpto = 0;
            IdFisRel = 0;
            RefExt = "";
            IdInt = 0;
        }
    }

}
// </auto-generated>