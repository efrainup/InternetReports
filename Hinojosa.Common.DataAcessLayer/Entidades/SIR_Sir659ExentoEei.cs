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

    // SIR_659_EXENTO_EEI
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir659ExentoEei
    {
        [Required]
        [Display(Name = "N ID exento eei 659")]
        public int NIdExentoEei659 { get; set; } // nIdExentoEEI659 (Primary key)

        [Required]
        [Display(Name = "N clave")]
        public int NClave { get; set; } // nClave

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S categoria")]
        public string SCategoria { get; set; } // sCategoria (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 100)

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir156EntradasBodega where [SIR_156_ENTRADAS_BODEGAS].[nIdExentoEEI659] point to this entity (FK_SIR_156_ENTRADAS_BODEGA_SIR_659_EXENTO_EEI)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir156EntradasBodega> SIR_Sir156EntradasBodega { get; set; } // SIR_156_ENTRADAS_BODEGAS.FK_SIR_156_ENTRADAS_BODEGA_SIR_659_EXENTO_EEI

        public SIR_Sir659ExentoEei()
        {
            SIR_Sir156EntradasBodega = new System.Collections.Generic.List<SIR_Sir156EntradasBodega>();
        }
    }

}
// </auto-generated>