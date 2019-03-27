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

    // hos_autorizacion
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class HosAutorizacion
    {
        [Required]
        [Display(Name = "Id aut")]
        public int IdAut { get; set; } // id_aut (Primary key)

        [Required]
        [Display(Name = "Id ref")]
        public int IdRef { get; set; } // id_ref

        [Required]
        [Display(Name = "C pac")]
        public byte CPac { get; set; } // c_pac

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Autorizacion")]
        public string Autorizacion { get; set; } // autorizacion (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Diagnostico")]
        public string Diagnostico { get; set; } // diagnostico (length: 250)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; } // tipo (length: 250)

        [Required]
        [Display(Name = "Cobertura")]
        public double Cobertura { get; set; } // cobertura

        [Required]
        [Display(Name = "Deducible")]
        public double Deducible { get; set; } // deducible

        [Required]
        [Display(Name = "Coaseguro")]
        public double Coaseguro { get; set; } // coaseguro

        [Required]
        [Display(Name = "Id cli fa da")]
        public int IdCliFaDa { get; set; } // id_cli_fa_da

        [Required]
        [Display(Name = "Saldo")]
        public double Saldo { get; set; } // saldo

        [Required]
        [Display(Name = "Cobrado")]
        public double Cobrado { get; set; } // cobrado

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Num siniestro")]
        public string NumSiniestro { get; set; } // num_siniestro (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Num reporte")]
        public string NumReporte { get; set; } // num_reporte (length: 50)

        [Required]
        [Display(Name = "Monto cpt")]
        public double MontoCpt { get; set; } // monto_cpt

        [Required]
        [Display(Name = "Facturado")]
        public double Facturado { get; set; } // facturado

        [Required]
        [Display(Name = "Monto coaseguro")]
        public double MontoCoaseguro { get; set; } // monto_coaseguro

        [Required]
        [Display(Name = "Monto no cub")]
        public double MontoNoCub { get; set; } // monto_no_cub

        [Required]
        [Display(Name = "Monto cargos simptos")]
        public double MontoCargosSimptos { get; set; } // monto_cargos_simptos

        [Required]
        [Display(Name = "Monto cargos imptos")]
        public double MontoCargosImptos { get; set; } // monto_cargos_imptos

        [Required]
        [Display(Name = "Monto cargos")]
        public double MontoCargos { get; set; } // monto_cargos

        [Required]
        [Display(Name = "Total no cub")]
        public double TotalNoCub { get; set; } // total_no_cub

        [Required]
        [Display(Name = "Total deducible")]
        public double TotalDeducible { get; set; } // total_deducible

        [Required]
        [Display(Name = "Total coaseguro")]
        public double TotalCoaseguro { get; set; } // total_coaseguro

        [Required]
        [Display(Name = "C fac deducible")]
        public byte CFacDeducible { get; set; } // c_fac_deducible

        [Required]
        [Display(Name = "C fac coaseguro")]
        public byte CFacCoaseguro { get; set; } // c_fac_coaseguro

        [Required]
        [Display(Name = "C fac no cub")]
        public byte CFacNoCub { get; set; } // c_fac_no_cub

        [Required]
        [Display(Name = "C fac cargos")]
        public byte CFacCargos { get; set; } // c_fac_cargos

        [Required]
        [Display(Name = "Monto descuento 1")]
        public double MontoDescuento1 { get; set; } // monto_descuento1

        [Required]
        [Display(Name = "Monto descuento 2")]
        public double MontoDescuento2 { get; set; } // monto_descuento2

        [Required]
        [Display(Name = "Honorarios medicos")]
        public double HonorariosMedicos { get; set; } // honorarios_medicos

        [Required]
        [Display(Name = "C fac honorarios medicos")]
        public byte CFacHonorariosMedicos { get; set; } // c_fac_honorarios_medicos

        [Required]
        [Display(Name = "Total honorarios medicos")]
        public double TotalHonorariosMedicos { get; set; } // total_honorarios_medicos

        [Required]
        [Display(Name = "Op coa")]
        public byte OpCoa { get; set; } // op_coa

        [Required]
        [Display(Name = "Id tip uso")]
        public int IdTipUso { get; set; } // id_tip_uso

        [Required]
        [Display(Name = "Num grp")]
        public int NumGrp { get; set; } // num_grp

        [Required]
        [Display(Name = "Monto subtotal resumen")]
        public double MontoSubtotalResumen { get; set; } // monto_subtotal_resumen

        [Required]
        [Display(Name = "Monto imptos resumen")]
        public double MontoImptosResumen { get; set; } // monto_imptos_resumen

        public HosAutorizacion()
        {
            IdRef = 0;
            CPac = 0;
            Autorizacion = "";
            Diagnostico = "";
            Tipo = "";
            Cobertura = 0;
            Deducible = 0;
            Coaseguro = 0;
            IdCliFaDa = 0;
            Saldo = 0;
            Cobrado = 0;
            NumSiniestro = "";
            NumReporte = "";
            MontoCpt = 0;
            Facturado = 0;
            MontoCoaseguro = 0;
            MontoNoCub = 0;
            MontoCargosSimptos = 0;
            MontoCargosImptos = 0;
            MontoCargos = 0;
            TotalNoCub = 0;
            TotalDeducible = 0;
            TotalCoaseguro = 0;
            CFacDeducible = 0;
            CFacCoaseguro = 0;
            CFacNoCub = 0;
            CFacCargos = 0;
            MontoDescuento1 = 0;
            MontoDescuento2 = 0;
            HonorariosMedicos = 0;
            CFacHonorariosMedicos = 0;
            TotalHonorariosMedicos = 0;
            OpCoa = 0;
            IdTipUso = 0;
            NumGrp = 0;
            MontoSubtotalResumen = 0;
            MontoImptosResumen = 0;
        }
    }

}
// </auto-generated>