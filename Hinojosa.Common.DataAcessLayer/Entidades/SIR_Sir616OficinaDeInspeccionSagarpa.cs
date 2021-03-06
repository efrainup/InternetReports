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

    // SIR_616_OFICINA_DE_INSPECCION_SAGARPA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir616OficinaDeInspeccionSagarpa
    {
        [Required]
        [Display(Name = "N ID oficina inspeccion 616")]
        public int NIdOficinaInspeccion616 { get; set; } // nIdOficinaInspeccion616 (Primary key)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S acronimo")]
        public string SAcronimo { get; set; } // sAcronimo (length: 30)

        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "S nombre")]
        public string SNombre { get; set; } // sNombre (length: 1000)

        [MaxLength(1000)]
        [StringLength(1000)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 1000)

        [Display(Name = "N ID entidad fed 608")]
        public int? NIdEntidadFed608 { get; set; } // nIdEntidadFed608

        [Display(Name = "N dependencia")]
        public int? NDependencia { get; set; } // nDependencia

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
        /// Child SIR_Sir626RevisionDocumental where [SIR_626_REVISION_DOCUMENTAL].[nIdOficinaInspeccion616] point to this entity (FK_SIR_626_REVISION_DOCUMENTAL_SIR_616_OFICINA_DE_INSPECCION_SAGARPA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir626RevisionDocumental> SIR_Sir626RevisionDocumental { get; set; } // SIR_626_REVISION_DOCUMENTAL.FK_SIR_626_REVISION_DOCUMENTAL_SIR_616_OFICINA_DE_INSPECCION_SAGARPA

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir608EntidadFederativaSagarpa pointed by [SIR_616_OFICINA_DE_INSPECCION_SAGARPA].([NIdEntidadFed608]) (FK_SIR_616_OFICINA_DE_INSPECCION_SAGARPA_SIR_608_ENTIDAD_FEDERATIVA_SAGARPA)
        /// </summary>
        public virtual SIR_Sir608EntidadFederativaSagarpa SIR_Sir608EntidadFederativaSagarpa { get; set; } // FK_SIR_616_OFICINA_DE_INSPECCION_SAGARPA_SIR_608_ENTIDAD_FEDERATIVA_SAGARPA

        public SIR_Sir616OficinaDeInspeccionSagarpa()
        {
            SIR_Sir626RevisionDocumental = new System.Collections.Generic.List<SIR_Sir626RevisionDocumental>();
        }
    }

}
// </auto-generated>
