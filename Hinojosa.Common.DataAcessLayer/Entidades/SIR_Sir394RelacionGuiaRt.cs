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

    // SIR_394_RELACION_GUIA_RT
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir394RelacionGuiaRt
    {
        [Required]
        [Display(Name = "N ID entrada 156")]
        public int NIdEntrada156 { get; set; } // nIdEntrada156 (Primary key)

        [Required]
        [Display(Name = "N ID bl 74")]
        public int NIdBl74 { get; set; } // nIdBL74 (Primary key)

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime? DFechaEdicion { get; set; } // dFechaEdicion

        [Display(Name = "N ID usuario ed")]
        public int? NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Display(Name = "N cantidad")]
        public int? NCantidad { get; set; } // nCantidad

        [Display(Name = "N peso")]
        public decimal? NPeso { get; set; } // nPeso

        [Display(Name = "N peso lbs")]
        public decimal? NPesoLbs { get; set; } // nPesoLbs

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir156EntradasBodega pointed by [SIR_394_RELACION_GUIA_RT].([NIdEntrada156]) (FK_SIR_394_RELACION_GUIA_RT_SIR_156_ENTRADAS_BODEGAS)
        /// </summary>
        public virtual SIR_Sir156EntradasBodega SIR_Sir156EntradasBodega { get; set; } // FK_SIR_394_RELACION_GUIA_RT_SIR_156_ENTRADAS_BODEGAS

        /// <summary>
        /// Parent SIR_Sir74ConocimientosMaritimo pointed by [SIR_394_RELACION_GUIA_RT].([NIdBl74]) (FK_SIR_394_RELACION_GUIA_RT_SIR_74_CONOCIMIENTOS_MARITIMOS)
        /// </summary>
        public virtual SIR_Sir74ConocimientosMaritimo SIR_Sir74ConocimientosMaritimo { get; set; } // FK_SIR_394_RELACION_GUIA_RT_SIR_74_CONOCIMIENTOS_MARITIMOS
    }

}
// </auto-generated>