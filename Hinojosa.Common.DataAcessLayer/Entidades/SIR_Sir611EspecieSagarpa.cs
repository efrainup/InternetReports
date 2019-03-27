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

    // SIR_611_ESPECIE_SAGARPA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir611EspecieSagarpa
    {
        [Required]
        [Display(Name = "N ID especie 611")]
        public int NIdEspecie611 { get; set; } // nIdEspecie611 (Primary key)

        [MaxLength(300)]
        [StringLength(300)]
        [Display(Name = "S decripcion")]
        public string SDecripcion { get; set; } // sDecripcion (length: 300)

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
        /// Child SIR_Sir627MercanciasSagarpa where [SIR_627_MERCANCIAS_SAGARPA].[nIdEspecie611] point to this entity (FK_SIR_627_MERCANCIAS_SAGARPA_SIR_611_ESPECIE_SAGARPA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir627MercanciasSagarpa> SIR_Sir627MercanciasSagarpa { get; set; } // SIR_627_MERCANCIAS_SAGARPA.FK_SIR_627_MERCANCIAS_SAGARPA_SIR_611_ESPECIE_SAGARPA

        public SIR_Sir611EspecieSagarpa()
        {
            SIR_Sir627MercanciasSagarpa = new System.Collections.Generic.List<SIR_Sir627MercanciasSagarpa>();
        }
    }

}
// </auto-generated>