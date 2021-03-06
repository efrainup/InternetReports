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

    // SIR_197_FURGONES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir197Furgone
    {
        [Required]
        [Display(Name = "N ID furgon 197")]
        public int NIdFurgon197 { get; set; } // nIdFurgon197 (Primary key)

        [Required]
        [Display(Name = "N ID tipo furgon 196")]
        public int NIdTipoFurgon196 { get; set; } // nIdTipoFurgon196

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S furgon")]
        public string SFurgon { get; set; } // sFurgon (length: 30)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 100)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S sellos")]
        public string SSellos { get; set; } // sSellos (length: 50)

        [Required]
        [Display(Name = "N peso")]
        public decimal NPeso { get; set; } // nPeso

        [Required]
        [Display(Name = "N ID referencia 60")]
        public int NIdReferencia60 { get; set; } // nIdReferencia60

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_197_FURGONES].([NIdUsuarioEd]) (FK_SIR_197_FURGONES_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_197_FURGONES_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir196TiposFurgon pointed by [SIR_197_FURGONES].([NIdTipoFurgon196]) (FK_SIR_197_FURGONES_SIR_196_TIPOS_FURGON)
        /// </summary>
        public virtual SIR_Sir196TiposFurgon SIR_Sir196TiposFurgon { get; set; } // FK_SIR_197_FURGONES_SIR_196_TIPOS_FURGON

        /// <summary>
        /// Parent SIR_Sir60Referencia pointed by [SIR_197_FURGONES].([NIdReferencia60]) (FK_SIR_197_FURGONES_SIR_60_REFERENCIAS)
        /// </summary>
        public virtual SIR_Sir60Referencia SIR_Sir60Referencia { get; set; } // FK_SIR_197_FURGONES_SIR_60_REFERENCIAS

        public SIR_Sir197Furgone()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
        }
    }

}
// </auto-generated>
