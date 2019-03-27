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

    // SIR_620_TIPO_DE_MERCANCIA_SAGARPA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir620TipoDeMercanciaSagarpa
    {
        [Required]
        [Display(Name = "N ID tipo mcia sagarpa 620")]
        public int NIdTipoMciaSagarpa620 { get; set; } // nIdTipoMciaSAGARPA620 (Primary key)

        [MaxLength(4)]
        [StringLength(4)]
        [Display(Name = "S clave")]
        public string SClave { get; set; } // sClave (length: 4)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 200)

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
        /// Child SIR_Sir626RevisionDocumental where [SIR_626_REVISION_DOCUMENTAL].[nIdTipoMciaSAGARPA620] point to this entity (FK_SIR_626_REVISION_DOCUMENTAL_SIR_620_TIPO_DE_MERCANCIA_SAGARPA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir626RevisionDocumental> SIR_Sir626RevisionDocumental { get; set; } // SIR_626_REVISION_DOCUMENTAL.FK_SIR_626_REVISION_DOCUMENTAL_SIR_620_TIPO_DE_MERCANCIA_SAGARPA

        public SIR_Sir620TipoDeMercanciaSagarpa()
        {
            SIR_Sir626RevisionDocumental = new System.Collections.Generic.List<SIR_Sir626RevisionDocumental>();
        }
    }

}
// </auto-generated>
