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

    // SIR_54_TIPO_INCREMENTABLES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir54TipoIncrementable
    {
        [Required]
        [Display(Name = "N ID tipo incrementable 54")]
        public int NIdTipoIncrementable54 { get; set; } // nIdTipoIncrementable54 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 100)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Required]
        [Display(Name = "N status vig")]
        public byte NStatusVig { get; set; } // nStatusVig

        [Required]
        [Display(Name = "N registro")]
        public int NRegistro { get; set; } // nRegistro

        [Required]
        [Display(Name = "N clave")]
        public byte NClave { get; set; } // nClave

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir55FacturasIncrementable where [SIR_55_FACTURAS_INCREMENTABLES].[nIdTipoIncrementable54] point to this entity (FK_SIR_55_FACTURAS_INCREMENTABLES_SIR_54_TIPO_INCREMENTABLES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir55FacturasIncrementable> SIR_Sir55FacturasIncrementable { get; set; } // SIR_55_FACTURAS_INCREMENTABLES.FK_SIR_55_FACTURAS_INCREMENTABLES_SIR_54_TIPO_INCREMENTABLES

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_54_TIPO_INCREMENTABLES].([NIdUsuarioEd]) (FK_SIR_54_TIPO_INCREMENTABLES_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_54_TIPO_INCREMENTABLES_cat_usr_ed

        public SIR_Sir54TipoIncrementable()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            NStatusVig = 1;
            SIR_Sir55FacturasIncrementable = new System.Collections.Generic.List<SIR_Sir55FacturasIncrementable>();
        }
    }

}
// </auto-generated>
