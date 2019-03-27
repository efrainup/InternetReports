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

    // cxp_pag_det_aux_prov
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CxpPagDetAuxProv
    {
        [Display(Name = "Id pag det aux")]
        public int? IdPagDetAux { get; set; } // id_pag_det_aux

        [Required(AllowEmptyStrings = true)]
        [MaxLength(36)]
        [StringLength(36)]
        [Display(Name = "Uuid")]
        public string Uuid { get; set; } // uuid (Primary key) (length: 36)

        [Required]
        [Display(Name = "Id pago")]
        public int IdPago { get; set; } // id_pago (Primary key)

        [Required]
        [Display(Name = "Id pag det")]
        public int IdPagDet { get; set; } // id_pag_det (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(36)]
        [StringLength(36)]
        [Display(Name = "Uuid dr")]
        public string UuidDr { get; set; } // uuid_dr (Primary key) (length: 36)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Folio dr")]
        public string FolioDr { get; set; } // folio_dr (Primary key) (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Mda dr")]
        public string MdaDr { get; set; } // mda_dr (Primary key) (length: 5)

        [Required]
        [Display(Name = "Tc dr")]
        public double TcDr { get; set; } // tc_dr (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Met pag dr")]
        public string MetPagDr { get; set; } // met_pag_dr (Primary key) (length: 5)

        [Required]
        [Display(Name = "Num parc dr")]
        public int NumParcDr { get; set; } // num_parc_dr (Primary key)

        [Required]
        [Display(Name = "Imp sado ant dr")]
        public double ImpSadoAntDr { get; set; } // ImpSadoAnt_dr (Primary key)

        [Required]
        [Display(Name = "Imp pag dr")]
        public double ImpPagDr { get; set; } // ImpPag_dr (Primary key)

        [Required]
        [Display(Name = "Imp sdo ins dr")]
        public double ImpSdoInsDr { get; set; } // ImpSdoIns_dr (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(12)]
        [StringLength(12)]
        [Display(Name = "Cve")]
        public string Cve { get; set; } // cve (Primary key) (length: 12)

        [Required]
        [Display(Name = "Cant")]
        public double Cant { get; set; } // cant (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Udm")]
        public string Udm { get; set; } // UDM (Primary key) (length: 5)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (Primary key) (length: 1000)

        [Required]
        [Display(Name = "Base")]
        public double @Base { get; set; } // base (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Impto")]
        public string Impto { get; set; } // impto (Primary key) (length: 3)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Tip factor")]
        public string TipFactor { get; set; } // tip_factor (Primary key) (length: 20)

        [Required]
        [Display(Name = "Tasaocuota")]
        public double Tasaocuota { get; set; } // tasaocuota (Primary key)

        [Required]
        [Display(Name = "Total impto")]
        public double TotalImpto { get; set; } // total_impto (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha tim")]
        public System.DateTime FechaTim { get; set; } // fecha_tim (Primary key)

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status (Primary key)

        [Required]
        [Display(Name = "Id rel pag crp")]
        public int IdRelPagCrp { get; set; } // id_rel_pag_crp (Primary key)

        [Required]
        [Display(Name = "Saldo pendiente")]
        public double SaldoPendiente { get; set; } // saldoPendiente (Primary key)

        public CxpPagDetAuxProv()
        {
            Uuid = "";
            IdPago = 0;
            IdPagDet = 0;
            UuidDr = "";
            FolioDr = "";
            MdaDr = "";
            TcDr = 0;
            MetPagDr = "";
            NumParcDr = 0;
            ImpSadoAntDr = 0;
            ImpPagDr = 0;
            ImpSdoInsDr = 0;
            Cve = "";
            Cant = 0;
            Udm = "";
            Des = "";
            @Base = 0;
            Impto = "";
            TipFactor = "";
            Tasaocuota = 0;
            TotalImpto = 0;
            Status = 0;
            IdRelPagCrp = 0;
            SaldoPendiente = 0;
        }
    }

}
// </auto-generated>
