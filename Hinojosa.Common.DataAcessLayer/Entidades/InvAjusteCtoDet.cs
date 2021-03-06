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

    // inv_ajuste_cto_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class InvAjusteCtoDet
    {
        [Required]
        [Display(Name = "Id ajt cto det")]
        public int IdAjtCtoDet { get; set; } // id_ajt_cto_det (Primary key)

        [Required]
        [Display(Name = "Id ajt cto")]
        public int IdAjtCto { get; set; } // id_ajt_cto

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro

        [Required]
        [Display(Name = "Id almac")]
        public int IdAlmac { get; set; } // id_almac

        [Required]
        [Display(Name = "Id kardex")]
        public int IdKardex { get; set; } // id_kardex

        [Required]
        [Display(Name = "Costo ajust")]
        public double CostoAjust { get; set; } // costo_ajust

        [Required]
        [Display(Name = "Costo prom ant")]
        public double CostoPromAnt { get; set; } // costo_prom_ant

        [Required]
        [Display(Name = "Ult costo ant")]
        public double UltCostoAnt { get; set; } // ult_costo_ant

        [Required]
        [Display(Name = "Existencia")]
        public double Existencia { get; set; } // existencia

        [Required]
        [Display(Name = "Id prov")]
        public int IdProv { get; set; } // id_prov

        [Required]
        [Display(Name = "Id cta")]
        public int IdCta { get; set; } // id_cta

        [Required]
        [Display(Name = "Id tip rub")]
        public int IdTipRub { get; set; } // id_tip_rub

        public InvAjusteCtoDet()
        {
            IdAjtCto = 0;
            IdPro = 0;
            IdAlmac = 0;
            IdKardex = 0;
            CostoAjust = 0;
            CostoPromAnt = 0;
            UltCostoAnt = 0;
            Existencia = 0;
            IdProv = 0;
            IdCta = 0;
            IdTipRub = 0;
        }
    }

}
// </auto-generated>
