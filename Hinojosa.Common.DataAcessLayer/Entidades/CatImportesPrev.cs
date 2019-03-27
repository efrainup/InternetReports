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

    // Cat_Importes_Prev
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatImportesPrev
    {
        [Required]
        [Display(Name = "N ID importe")]
        public int NIdImporte { get; set; } // nIdImporte (Primary key)

        [Required]
        [Display(Name = "N ID prevalidador 155")]
        public int NIdPrevalidador155 { get; set; } // nIdPrevalidador155

        [Required]
        [Display(Name = "D importe")]
        public decimal DImporte { get; set; } // dImporte

        [Required]
        [Display(Name = "N activo")]
        public int NActivo { get; set; } // nActivo

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha alta")]
        public System.DateTime DFechaAlta { get; set; } // dFechaAlta

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime? DFechaEdicion { get; set; } // dFechaEdicion

        public CatImportesPrev()
        {
            NActivo = 1;
            DFechaAlta = System.DateTime.Now;
        }
    }

}
// </auto-generated>
