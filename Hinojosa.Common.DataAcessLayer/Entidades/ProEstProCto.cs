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

    // pro_est_pro_cto
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ProEstProCto
    {
        [Required]
        [Display(Name = "Id est pro cto")]
        public int IdEstProCto { get; set; } // id_est_pro_cto (Primary key)

        [Required]
        [Display(Name = "Id pro pad")]
        public int IdProPad { get; set; } // id_pro_pad

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Sec")]
        public int Sec { get; set; } // sec

        [Required]
        [Display(Name = "Id tip cto")]
        public int IdTipCto { get; set; } // id_tip_cto

        [Required]
        [Display(Name = "Tasa cto")]
        public double TasaCto { get; set; } // tasa_cto

        [Required]
        [Display(Name = "Factor cto")]
        public double FactorCto { get; set; } // factor_cto

        [Required]
        [Display(Name = "Cto estr")]
        public double CtoEstr { get; set; } // cto_estr

        [Required]
        [Display(Name = "Id cen cto")]
        public int IdCenCto { get; set; } // id_cen_cto

        [Required]
        [Display(Name = "Id per")]
        public int IdPer { get; set; } // id_per

        [Required]
        [Display(Name = "Cant")]
        public double Cant { get; set; } // cant

        [Required]
        [Display(Name = "Id mtz cto")]
        public int IdMtzCto { get; set; } // id_mtz_cto

        // Foreign keys

        /// <summary>
        /// Parent CatPro pointed by [pro_est_pro_cto].([IdProPad]) (FK_pro_est_pro_cto_cat_pro)
        /// </summary>
        public virtual CatPro CatPro { get; set; } // FK_pro_est_pro_cto_cat_pro

        /// <summary>
        /// Parent ProCtoValAgr pointed by [pro_est_pro_cto].([IdTipCto]) (FK_pro_est_pro_cto_pro_cto_val_agr)
        /// </summary>
        public virtual ProCtoValAgr ProCtoValAgr { get; set; } // FK_pro_est_pro_cto_pro_cto_val_agr

        public ProEstProCto()
        {
            IdEstProCto = 0;
            IdProPad = 0;
            IdNota = 0;
            IdUsr = 0;
            Sec = 0;
            IdTipCto = 0;
            TasaCto = 0;
            FactorCto = 0;
            CtoEstr = 0;
            IdCenCto = 0;
            IdPer = 0;
            Cant = 0;
            IdMtzCto = 0;
        }
    }

}
// </auto-generated>