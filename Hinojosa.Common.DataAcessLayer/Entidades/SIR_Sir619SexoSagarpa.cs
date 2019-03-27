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

    // SIR_619_SEXO_SAGARPA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir619SexoSagarpa
    {
        [Required]
        [Display(Name = "N ID sexo sagarpa 619")]
        public int NIdSexoSagarpa619 { get; set; } // nIdSexoSAGARPA619 (Primary key)

        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "S clave")]
        public string SClave { get; set; } // sClave (length: 3)

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
        /// Child SIR_Sir628DetalleAnimalesVivo where [SIR_628_DETALLE_ANIMALES_VIVOS].[nIdSexoSAGARPA619] point to this entity (FK_SIR_628_DETALLE_ANIMALES_VIVOS_SIR_619_SEXO_SAGARPA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir628DetalleAnimalesVivo> SIR_Sir628DetalleAnimalesVivo { get; set; } // SIR_628_DETALLE_ANIMALES_VIVOS.FK_SIR_628_DETALLE_ANIMALES_VIVOS_SIR_619_SEXO_SAGARPA

        public SIR_Sir619SexoSagarpa()
        {
            SIR_Sir628DetalleAnimalesVivo = new System.Collections.Generic.List<SIR_Sir628DetalleAnimalesVivo>();
        }
    }

}
// </auto-generated>