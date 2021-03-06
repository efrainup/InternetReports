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

    // SIR_660_PUNTOS_DE_VERIFICACION_SAGARPA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir660PuntosDeVerificacionSagarpa
    {
        [Required]
        [Display(Name = "N ID punto verificacion 660")]
        public int NIdPuntoVerificacion660 { get; set; } // nIdPuntoVerificacion660 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "S nombre")]
        public string SNombre { get; set; } // sNombre (length: 1000)

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
        /// Child SIR_Sir626RevisionDocumental where [SIR_626_REVISION_DOCUMENTAL].[nIdPuntoVerificacion660] point to this entity (FK_SIR_626_REVISION_DOCUMENTAL_SIR_660_PUNTOS_DE_VERIFICACION_SAGARPA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir626RevisionDocumental> SIR_Sir626RevisionDocumental { get; set; } // SIR_626_REVISION_DOCUMENTAL.FK_SIR_626_REVISION_DOCUMENTAL_SIR_660_PUNTOS_DE_VERIFICACION_SAGARPA

        public SIR_Sir660PuntosDeVerificacionSagarpa()
        {
            SIR_Sir626RevisionDocumental = new System.Collections.Generic.List<SIR_Sir626RevisionDocumental>();
        }
    }

}
// </auto-generated>
