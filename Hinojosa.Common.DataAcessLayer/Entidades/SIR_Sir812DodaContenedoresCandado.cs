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

    // SIR_812_DODA_CONTENEDORES_CANDADO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir812DodaContenedoresCandado
    {
        [Required]
        [Display(Name = "N ID dodac ont 811")]
        public int NIdDodaCont811 { get; set; } // nIdDODACont811 (Primary key)

        [Display(Name = "N ID sello 107")]
        public int? NIdSello107 { get; set; } // nIdSello107

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S candado")]
        public string SCandado { get; set; } // sCandado (Primary key) (length: 50)

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir107ContenedorSello pointed by [SIR_812_DODA_CONTENEDORES_CANDADO].([NIdSello107]) (FK_SIR_812_DODA_CONTENEDORES_CANDADO_SIR_107_CONTENEDOR_SELLOS)
        /// </summary>
        public virtual SIR_Sir107ContenedorSello SIR_Sir107ContenedorSello { get; set; } // FK_SIR_812_DODA_CONTENEDORES_CANDADO_SIR_107_CONTENEDOR_SELLOS

        /// <summary>
        /// Parent SIR_Sir811DodaContenedore pointed by [SIR_812_DODA_CONTENEDORES_CANDADO].([NIdDodaCont811]) (FK_SIR_812_DODA_CONTENEDORES_CANDADO_SIR_811_DODA_CONTENEDORES)
        /// </summary>
        public virtual SIR_Sir811DodaContenedore SIR_Sir811DodaContenedore { get; set; } // FK_SIR_812_DODA_CONTENEDORES_CANDADO_SIR_811_DODA_CONTENEDORES
    }

}
// </auto-generated>
