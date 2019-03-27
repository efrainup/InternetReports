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

    // tblFinder
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TblFinder
    {
        [Required]
        [Display(Name = "Iid query")]
        public int IidQuery { get; set; } // iidQuery (Primary key)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "V palabra")]
        public string VPalabra { get; set; } // vPalabra

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fec ini")]
        public System.DateTime DFecIni { get; set; } // dFecIni

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fec fin")]
        public System.DateTime DFecFin { get; set; } // dFecFin

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "V opcion")]
        public string VOpcion { get; set; } // vOpcion (length: 50)

        [Required]
        [Display(Name = "Iid user")]
        public int IidUser { get; set; } // iidUser

        public TblFinder()
        {
            VPalabra = "";
            VOpcion = "";
            IidUser = 0;
        }
    }

}
// </auto-generated>