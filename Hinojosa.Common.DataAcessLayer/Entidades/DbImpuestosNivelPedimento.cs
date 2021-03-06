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

    // DB_Impuestos_NivelPedimento
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class DbImpuestosNivelPedimento
    {
        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S referencia")]
        public string SReferencia { get; set; } // sReferencia (Primary key) (length: 20)

        [Display(Name = "N clave")]
        public int? NClave { get; set; } // nClave

        [Display(Name = "N forma pago")]
        public int? NFormaPago { get; set; } // nFormaPago

        [Display(Name = "N importe")]
        public decimal? NImporte { get; set; } // nImporte

        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "S nombre corto")]
        public string SNombreCorto { get; set; } // sNombreCorto (length: 15)
    }

}
// </auto-generated>
