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

    // MT_GastoExpo_Mabe_Hinojosa
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class MtGastoExpoMabeHinojosa
    {
        [Required]
        [Display(Name = "N ID gasto mh")]
        public int NIdGastoMh { get; set; } // nIdGastoMH (Primary key)

        [Required]
        [Display(Name = "N ID gh inojosa")]
        public int NIdGHinojosa { get; set; } // nIdGHinojosa

        [Display(Name = "N ID gm abe")]
        public int? NIdGMabe { get; set; } // nIdGMabe

        [Required]
        [Display(Name = "N activo")]
        public int NActivo { get; set; } // nActivo

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha alta")]
        public System.DateTime DFechaAlta { get; set; } // dFechaAlta

        public MtGastoExpoMabeHinojosa()
        {
            NActivo = 1;
            DFechaAlta = System.DateTime.Now;
        }
    }

}
// </auto-generated>
