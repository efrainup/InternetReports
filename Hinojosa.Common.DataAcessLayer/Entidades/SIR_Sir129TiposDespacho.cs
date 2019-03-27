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

    // SIR_129_TIPOS_DESPACHO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir129TiposDespacho
    {
        [Required]
        [Display(Name = "N ID tipo desp 129")]
        public int NIdTipoDesp129 { get; set; } // nIdTipoDesp129 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 50)

        [MaxLength(12)]
        [StringLength(12)]
        [Display(Name = "S color rgb")]
        public string SColorRgb { get; set; } // sColorRGB (length: 12)

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir133CamposValidaDespacho (Many-to-Many) mapped by table [SIR_357_VALIDACIONES_DESPACHOS]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir133CamposValidaDespacho> SIR_Sir133CamposValidaDespacho { get; set; } // Many to many mapping
        /// <summary>
        /// Child SIR_Sir134ProgramacionDespacho where [SIR_134_PROGRAMACION_DESPACHOS].[nIdTipoDesp129] point to this entity (FK_SIR_134_PROGRAMACION_DESPACHOS_SIR_129_TIPOS_DESPACHO)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir134ProgramacionDespacho> SIR_Sir134ProgramacionDespacho { get; set; } // SIR_134_PROGRAMACION_DESPACHOS.FK_SIR_134_PROGRAMACION_DESPACHOS_SIR_129_TIPOS_DESPACHO
        /// <summary>
        /// Child SIR_Sir45ActividadesDespacho (Many-to-Many) mapped by table [SIR_131_TIPO_DESP_ACTIVIDADES]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir45ActividadesDespacho> SIR_Sir45ActividadesDespacho { get; set; } // Many to many mapping

        public SIR_Sir129TiposDespacho()
        {
            SIR_Sir134ProgramacionDespacho = new System.Collections.Generic.List<SIR_Sir134ProgramacionDespacho>();
            SIR_Sir45ActividadesDespacho = new System.Collections.Generic.List<SIR_Sir45ActividadesDespacho>();
            SIR_Sir133CamposValidaDespacho = new System.Collections.Generic.List<SIR_Sir133CamposValidaDespacho>();
        }
    }

}
// </auto-generated>