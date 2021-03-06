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

    // pro_cto_val_agr
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ProCtoValAgr
    {
        [Required]
        [Display(Name = "Id tip cto")]
        public int IdTipCto { get; set; } // id_tip_cto (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Numero")]
        public string Numero { get; set; } // numero (length: 25)

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

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (length: 100)

        [Required]
        [Display(Name = "Tasa")]
        public float Tasa { get; set; } // tasa

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [Display(Name = "Id cta")]
        public int IdCta { get; set; } // id_cta

        [Required]
        [Display(Name = "Id cta apl")]
        public int IdCtaApl { get; set; } // id_cta_apl

        [Required]
        [Display(Name = "Mto costo")]
        public double MtoCosto { get; set; } // mto_costo

        [Required]
        [Display(Name = "Mto apl")]
        public double MtoApl { get; set; } // mto_apl

        [Required]
        [Display(Name = "Id per")]
        public int IdPer { get; set; } // id_per

        [Required]
        [Display(Name = "Mto ori")]
        public double MtoOri { get; set; } // mto_ori

        [Required]
        [Display(Name = "Id mtz cto")]
        public int IdMtzCto { get; set; } // id_mtz_cto

        [Required]
        [Display(Name = "Id cta aju")]
        public int IdCtaAju { get; set; } // id_cta_aju

        // Reverse navigation

        /// <summary>
        /// Child ProEstProCtoes where [pro_est_pro_cto].[id_tip_cto] point to this entity (FK_pro_est_pro_cto_pro_cto_val_agr)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<ProEstProCto> ProEstProCtoes { get; set; } // pro_est_pro_cto.FK_pro_est_pro_cto_pro_cto_val_agr

        public ProCtoValAgr()
        {
            IdTipCto = 0;
            Numero = "";
            IdNota = 0;
            IdUsr = 0;
            Des = "";
            Tasa = 0f;
            Status = 1;
            IdCta = 0;
            IdCtaApl = 0;
            MtoCosto = 0;
            MtoApl = 0;
            IdPer = 0;
            MtoOri = 0;
            IdMtzCto = 0;
            IdCtaAju = 0;
            ProEstProCtoes = new System.Collections.Generic.List<ProEstProCto>();
        }
    }

}
// </auto-generated>
