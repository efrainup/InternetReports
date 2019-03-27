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

    // bco_lim_crd
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class BcoLimCrd
    {
        [Required]
        [Display(Name = "Id bco lim crd")]
        public int IdBcoLimCrd { get; set; } // id_bco_lim_crd (Primary key)

        [Required]
        [Display(Name = "Id cta aso")]
        public int IdCtaAso { get; set; } // id_cta_aso (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "No contrato")]
        public string NoContrato { get; set; } // no_contrato (Primary key) (length: 30)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ini")]
        public System.DateTime FecIni { get; set; } // fec_ini (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec fin")]
        public System.DateTime FecFin { get; set; } // fec_fin (Primary key)

        [Required]
        [Display(Name = "Tasa")]
        public double Tasa { get; set; } // tasa (Primary key)

        [Required]
        [Display(Name = "Lim credito")]
        public double LimCredito { get; set; } // lim_credito (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg (Primary key)

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr (Primary key)

        public BcoLimCrd()
        {
            IdCtaAso = 0;
            NoContrato = "";
            Tasa = 0;
            LimCredito = 0;
            IdUsr = 0;
        }
    }

}
// </auto-generated>