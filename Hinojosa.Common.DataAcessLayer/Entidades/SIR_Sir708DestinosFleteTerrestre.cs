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

    // SIR_708_DESTINOS_FLETE_TERRESTRE
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir708DestinosFleteTerrestre
    {
        [Required]
        [Display(Name = "N ID destino flete terrestre 708")]
        public int NIdDestinoFleteTerrestre708 { get; set; } // nIdDestinoFleteTerrestre708 (Primary key)

        [Required]
        [Display(Name = "N clave")]
        public int NClave { get; set; } // nClave

        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "S destino")]
        public string SDestino { get; set; } // sDestino (length: 250)

        [Display(Name = "N tarifa cam")]
        public decimal? NTarifaCam { get; set; } // nTarifaCam

        [Display(Name = "N tarifa rabon")]
        public decimal? NTarifaRabon { get; set; } // nTarifaRabon

        [Display(Name = "B activo")]
        public bool? BActivo { get; set; } // bActivo
    }

}
// </auto-generated>