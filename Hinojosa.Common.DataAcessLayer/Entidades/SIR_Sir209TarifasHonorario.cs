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

    // SIR_209_TARIFAS_HONORARIOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir209TarifasHonorario
    {
        [Required]
        [Display(Name = "N ID tar hon 209")]
        public int NIdTarHon209 { get; set; } // nIdTarHon209 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 30)

        [Display(Name = "N valor")]
        public decimal? NValor { get; set; } // nValor

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S pregunta")]
        public string SPregunta { get; set; } // sPregunta (length: 100)

        [Required]
        [Display(Name = "N tipo valor")]
        public byte NTipoValor { get; set; } // nTipoValor

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_209_TARIFAS_HONORARIOS].([NIdUsuarioEd]) (FK_SIR_209_TARIFAS_HONORARIOS_cat_usr)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_209_TARIFAS_HONORARIOS_cat_usr

        public SIR_Sir209TarifasHonorario()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            NTipoValor = 0;
        }
    }

}
// </auto-generated>
