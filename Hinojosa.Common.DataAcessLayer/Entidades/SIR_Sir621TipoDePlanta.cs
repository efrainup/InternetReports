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

    // SIR_621_TIPO_DE_PLANTA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir621TipoDePlanta
    {
        [Required]
        [Display(Name = "N tipo de planta 621")]
        public int NTipoDePlanta621 { get; set; } // nTipoDePlanta621 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "S clave")]
        public string SClave { get; set; } // sClave (length: 3)

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 100)

        [DataType(DataType.DateTime)]
        [Display(Name = "D inicio vigencia")]
        public System.DateTime? DInicioVigencia { get; set; } // dInicioVigencia

        [DataType(DataType.DateTime)]
        [Display(Name = "D termino vigencia")]
        public System.DateTime? DTerminoVigencia { get; set; } // dTerminoVigencia

        [Display(Name = "B activo")]
        public bool? BActivo { get; set; } // bActivo

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir627MercanciasSagarpa where [SIR_627_MERCANCIAS_SAGARPA].[nTipoDePlanta621] point to this entity (FK_SIR_627_MERCANCIAS_SAGARPA_SIR_621_TIPO_DE_PLANTA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir627MercanciasSagarpa> SIR_Sir627MercanciasSagarpa { get; set; } // SIR_627_MERCANCIAS_SAGARPA.FK_SIR_627_MERCANCIAS_SAGARPA_SIR_621_TIPO_DE_PLANTA

        public SIR_Sir621TipoDePlanta()
        {
            SIR_Sir627MercanciasSagarpa = new System.Collections.Generic.List<SIR_Sir627MercanciasSagarpa>();
        }
    }

}
// </auto-generated>
