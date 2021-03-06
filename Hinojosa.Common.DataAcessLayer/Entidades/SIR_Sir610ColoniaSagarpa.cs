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

    // SIR_610_COLONIA_SAGARPA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir610ColoniaSagarpa
    {
        [Required]
        [Display(Name = "N ID col sagarpa 610")]
        public int NIdColSagarpa610 { get; set; } // nIdColSAGARPA610 (Primary key)

        [Required]
        [Display(Name = "N ID del mun 609")]
        public int NIdDelMun609 { get; set; } // nIdDelMun609

        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "S nombre")]
        public string SNombre { get; set; } // sNombre (length: 200)

        [MaxLength(12)]
        [StringLength(12)]
        [Display(Name = "S clave")]
        public string SClave { get; set; } // sClave (length: 12)

        [DataType(DataType.DateTime)]
        [Display(Name = "D captura")]
        public System.DateTime? DCaptura { get; set; } // dCaptura

        [MaxLength(12)]
        [StringLength(12)]
        [Display(Name = "S clave localidad")]
        public string SClaveLocalidad { get; set; } // sClaveLocalidad (length: 12)

        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "S cp")]
        public string SCp { get; set; } // sCP (length: 5)

        [MaxLength(9)]
        [StringLength(9)]
        [Display(Name = "S satc olony cd")]
        public string SSatColonyCd { get; set; } // sSATColony_CD (length: 9)

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
        /// Child SIR_Sir626RevisionDocumental where [SIR_626_REVISION_DOCUMENTAL].[nIdColSAGARPA610] point to this entity (FK_SIR_626_REVISION_DOCUMENTAL_SIR_610_COLONIA_SAGARPA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir626RevisionDocumental> SIR_Sir626RevisionDocumental { get; set; } // SIR_626_REVISION_DOCUMENTAL.FK_SIR_626_REVISION_DOCUMENTAL_SIR_610_COLONIA_SAGARPA

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir609DelegacionMunicipioSagarpa pointed by [SIR_610_COLONIA_SAGARPA].([NIdDelMun609]) (FK_SIR_610_COLONIA_SAGARPA_SIR_609_DELEGACION_MUNICIPIO_SAGARPA)
        /// </summary>
        public virtual SIR_Sir609DelegacionMunicipioSagarpa SIR_Sir609DelegacionMunicipioSagarpa { get; set; } // FK_SIR_610_COLONIA_SAGARPA_SIR_609_DELEGACION_MUNICIPIO_SAGARPA

        public SIR_Sir610ColoniaSagarpa()
        {
            SIR_Sir626RevisionDocumental = new System.Collections.Generic.List<SIR_Sir626RevisionDocumental>();
        }
    }

}
// </auto-generated>
