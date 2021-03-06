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

    // SIR_407_CAMPOS_ACTIVIDADES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir407CamposActividade
    {
        [Required]
        [Display(Name = "N ID campo 407")]
        public int NIdCampo407 { get; set; } // nIdCampo407 (Primary key)

        [Required]
        [Display(Name = "N ID actividad 404")]
        public int NIdActividad404 { get; set; } // nIdActividad404

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S nombre")]
        public string SNombre { get; set; } // sNombre (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 100)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "S tamanio")]
        public string STamanio { get; set; } // sTamanio (length: 10)

        [Display(Name = "N tipo control")]
        public byte? NTipoControl { get; set; } // nTipoControl

        [Display(Name = "B requerido")]
        public bool? BRequerido { get; set; } // bRequerido

        [Display(Name = "B bitacora")]
        public bool? BBitacora { get; set; } // bBitacora

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) SIR_Sir407CamposActividade pointed by [SIR_408_VALORES_CAMPOS].[nIdCampo407] (FK_SIR_408_VALORES_CAMPOS_SIR_407_CAMPOS_ACTIVIDADES)
        /// </summary>
        public virtual SIR_Sir408ValoresCampos SIR_Sir408ValoresCampos { get; set; } // SIR_408_VALORES_CAMPOS.FK_SIR_408_VALORES_CAMPOS_SIR_407_CAMPOS_ACTIVIDADES

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir404Actividade pointed by [SIR_407_CAMPOS_ACTIVIDADES].([NIdActividad404]) (FK_SIR_407_CAMPOS_ACTIVIDADES_SIR_404_ACTIVIDADES)
        /// </summary>
        public virtual SIR_Sir404Actividade SIR_Sir404Actividade { get; set; } // FK_SIR_407_CAMPOS_ACTIVIDADES_SIR_404_ACTIVIDADES
    }

}
// </auto-generated>
