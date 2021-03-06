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

    // cxp_pagos_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CxpPagosDet
    {
        [Required]
        [Display(Name = "Id pag det")]
        public int IdPagDet { get; set; } // id_pag_det (Primary key)

        [Required]
        [Display(Name = "Id pago")]
        public int IdPago { get; set; } // id_pago

        [Required]
        [Display(Name = "Id suc")]
        public int IdSuc { get; set; } // id_suc

        [Required]
        [Display(Name = "Id aux")]
        public int IdAux { get; set; } // id_aux

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc

        [Required]
        [Display(Name = "Id doc")]
        public int IdDoc { get; set; } // id_doc

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha")]
        public System.DateTime Fecha { get; set; } // fecha

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Vence")]
        public System.DateTime Vence { get; set; } // vence

        [Required]
        [Display(Name = "Num doc")]
        public int NumDoc { get; set; } // num_doc

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Ref")]
        public string @Ref { get; set; } // ref (length: 50)

        [Required]
        [Display(Name = "Importe")]
        public double Importe { get; set; } // importe

        [Required]
        [Display(Name = "Saldo")]
        public double Saldo { get; set; } // saldo

        [Required]
        [Display(Name = "Aplicado")]
        public double Aplicado { get; set; } // aplicado

        [Required]
        [Display(Name = "Id mda")]
        public int IdMda { get; set; } // id_mda

        [Required]
        [Display(Name = "Tc")]
        public double Tc { get; set; } // tc

        [Required]
        [Display(Name = "Oper")]
        public byte Oper { get; set; } // oper

        [Display(Name = "Aplicado bse")]
        public double? AplicadoBse { get; set; } // aplicado_bse

        [Required]
        [Display(Name = "Id mda cta")]
        public int IdMdaCta { get; set; } // id_mda_cta

        [Required]
        [Display(Name = "Tc mda cta")]
        public double TcMdaCta { get; set; } // tc_mda_cta

        [Required]
        [Display(Name = "Oper cta")]
        public byte OperCta { get; set; } // oper_cta

        [Required]
        [Display(Name = "Aplicado cta")]
        public double AplicadoCta { get; set; } // aplicado_cta

        [Required]
        [Display(Name = "Cant")]
        public double Cant { get; set; } // cant

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro

        [Required]
        [Display(Name = "Id alm")]
        public int IdAlm { get; set; } // id_alm

        [Required]
        [Display(Name = "Id ref")]
        public int IdRef { get; set; } // id_ref

        [Required]
        [Display(Name = "Id int")]
        public int IdInt { get; set; } // id_int

        [Required]
        [Display(Name = "Id cli cta de")]
        public int IdCliCtaDe { get; set; } // id_cli_cta_de

        [Required]
        [Display(Name = "Id clas pro")]
        public int IdClasPro { get; set; } // id_clas_pro

        [Required]
        [Display(Name = "Id clas prov")]
        public int IdClasProv { get; set; } // id_clas_prov

        [Required]
        [Display(Name = "Id ref det")]
        public int IdRefDet { get; set; } // id_ref_det

        [Required]
        [Display(Name = "Id cta uti per")]
        public int IdCtaUtiPer { get; set; } // id_cta_uti_per

        [Required]
        [Display(Name = "Mto uti per")]
        public double MtoUtiPer { get; set; } // mto_uti_per

        [Required(AllowEmptyStrings = true)]
        [MaxLength(64)]
        [StringLength(64)]
        [Display(Name = "Ref ext")]
        public string RefExt { get; set; } // ref_ext (length: 64)

        [Required]
        [Display(Name = "Saldo det")]
        public double SaldoDet { get; set; } // Saldo_det

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Cmt")]
        public string Cmt { get; set; } // cmt (length: 50)

        [Required]
        [Display(Name = "Id bco trn det")]
        public int IdBcoTrnDet { get; set; } // id_bco_trn_det

        public CxpPagosDet()
        {
            IdPagDet = 0;
            IdMda = 0;
            Tc = 0;
            Oper = 0;
            AplicadoBse = 0;
            IdMdaCta = 0;
            TcMdaCta = 0;
            OperCta = 0;
            AplicadoCta = 0;
            Cant = 0.00;
            IdPro = 0;
            IdAlm = 0;
            IdRef = 0;
            IdInt = 0;
            IdCliCtaDe = 0;
            IdClasPro = 0;
            IdClasProv = 0;
            IdRefDet = 0;
            IdCtaUtiPer = 0;
            MtoUtiPer = 0;
            RefExt = "";
            SaldoDet = 0;
            Cmt = "";
            IdBcoTrnDet = 0;
        }
    }

}
// </auto-generated>
