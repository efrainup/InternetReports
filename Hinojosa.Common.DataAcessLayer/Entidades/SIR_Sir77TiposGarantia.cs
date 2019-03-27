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

    // SIR_77_TIPOS_GARANTIA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir77TiposGarantia
    {
        [Required]
        [Display(Name = "N ID tipo garantia 77")]
        public int NIdTipoGarantia77 { get; set; } // nIdTipoGarantia77 (Primary key)

        [Required]
        [Display(Name = "N clave")]
        public short NClave { get; set; } // nClave

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 100)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Required]
        [Display(Name = "N status vig")]
        public byte NStatusVig { get; set; } // nStatusVig

        [Required]
        [Display(Name = "N registro")]
        public int NRegistro { get; set; } // nRegistro

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir141PartidaCtaGarantia where [SIR_141_PARTIDA_CTA_GARANTIA].[nIdTipoGarantia77] point to this entity (FK_SIR_141_PARTIDA_CTA_GARANTIA_SIR_77_TIPOS_GARANTIA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir141PartidaCtaGarantia> SIR_Sir141PartidaCtaGarantia { get; set; } // SIR_141_PARTIDA_CTA_GARANTIA.FK_SIR_141_PARTIDA_CTA_GARANTIA_SIR_77_TIPOS_GARANTIA
        /// <summary>
        /// Child SIR_Sir364CuentasAduanGarantia where [SIR_364_CUENTAS_ADUAN_GARANTIA].[nIdTipoGarantia77] point to this entity (FK_SIR_364_CUENTAS_ADUAN_GARANTIA_SIR_77_TIPOS_GARANTIA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir364CuentasAduanGarantia> SIR_Sir364CuentasAduanGarantia { get; set; } // SIR_364_CUENTAS_ADUAN_GARANTIA.FK_SIR_364_CUENTAS_ADUAN_GARANTIA_SIR_77_TIPOS_GARANTIA

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_77_TIPOS_GARANTIA].([NIdUsuarioEd]) (FK_SIR_79_TIPOS_GARANTIA_cat_usr)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_79_TIPOS_GARANTIA_cat_usr

        public SIR_Sir77TiposGarantia()
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
