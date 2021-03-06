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

    // SIR_33_EMISORAS_CTAS_ADUANERAS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir33EmisorasCtasAduanera
    {
        [Required]
        [Display(Name = "N ID emi cta 33")]
        public int NIdEmiCta33 { get; set; } // nIdEmiCta33 (Primary key)

        [Required]
        [Display(Name = "N clave")]
        public short NClave { get; set; } // nClave

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 50)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Required]
        [Display(Name = "N registro")]
        public int NRegistro { get; set; } // nRegistro

        [Required]
        [Display(Name = "N status vig")]
        public byte NStatusVig { get; set; } // nStatusVig

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir141PartidaCtaGarantia where [SIR_141_PARTIDA_CTA_GARANTIA].[nIdEmiCta33] point to this entity (FK_SIR_141_PARTIDA_CTA_GARANTIA_SIR_33_EMISORAS_CTAS_ADUANERAS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir141PartidaCtaGarantia> SIR_Sir141PartidaCtaGarantia { get; set; } // SIR_141_PARTIDA_CTA_GARANTIA.FK_SIR_141_PARTIDA_CTA_GARANTIA_SIR_33_EMISORAS_CTAS_ADUANERAS
        /// <summary>
        /// Child SIR_Sir364CuentasAduanGarantia where [SIR_364_CUENTAS_ADUAN_GARANTIA].[nIdEmiCta33] point to this entity (FK_SIR_364_CUENTAS_ADUAN_GARANTIA_SIR_33_EMISORAS_CTAS_ADUANERAS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir364CuentasAduanGarantia> SIR_Sir364CuentasAduanGarantia { get; set; } // SIR_364_CUENTAS_ADUAN_GARANTIA.FK_SIR_364_CUENTAS_ADUAN_GARANTIA_SIR_33_EMISORAS_CTAS_ADUANERAS

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_33_EMISORAS_CTAS_ADUANERAS].([NIdUsuarioEd]) (FK_SIR_33_EMISORAS_CTAS_ADUANERAS_cat_usr)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_33_EMISORAS_CTAS_ADUANERAS_cat_usr

        public SIR_Sir33EmisorasCtasAduanera()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            NStatusVig = 1;
            SIR_Sir141PartidaCtaGarantia = new System.Collections.Generic.List<SIR_Sir141PartidaCtaGarantia>();
            SIR_Sir364CuentasAduanGarantia = new System.Collections.Generic.List<SIR_Sir364CuentasAduanGarantia>();
        }
    }

}
// </auto-generated>
