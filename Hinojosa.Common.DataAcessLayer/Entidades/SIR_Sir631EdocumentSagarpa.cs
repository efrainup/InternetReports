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

    // SIR_631_EDOCUMENT_SAGARPA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir631EdocumentSagarpa
    {
        [Required]
        [Display(Name = "N ID ed ocument 631")]
        public int NIdEDocument631 { get; set; } // nIdEDocument631 (Primary key)

        [Required]
        [Display(Name = "N ID revision documental 626")]
        public int NIdRevisionDocumental626 { get; set; } // nIdRevisionDocumental626

        [Required(AllowEmptyStrings = true)]
        [MaxLength(13)]
        [StringLength(13)]
        [Display(Name = "S ed ocument")]
        public string SEDocument { get; set; } // sEDocument (length: 13)

        [Required]
        [Display(Name = "N tipo")]
        public byte NTipo { get; set; } // nTipo

        [Display(Name = "N ID usuario ed")]
        public int? NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [DataType(DataType.DateTime)]
        [Display(Name = "D edicion")]
        public System.DateTime? DEdicion { get; set; } // dEdicion

        [Display(Name = "N ID documento 63")]
        public int? NIdDocumento63 { get; set; } // nIdDocumento63

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir626RevisionDocumental pointed by [SIR_631_EDOCUMENT_SAGARPA].([NIdRevisionDocumental626]) (FK_SIR_631_EDOCUMENT_SAGARPA_SIR_626_REVISION_DOCUMENTAL)
        /// </summary>
        public virtual SIR_Sir626RevisionDocumental SIR_Sir626RevisionDocumental { get; set; } // FK_SIR_631_EDOCUMENT_SAGARPA_SIR_626_REVISION_DOCUMENTAL
    }

}
// </auto-generated>
