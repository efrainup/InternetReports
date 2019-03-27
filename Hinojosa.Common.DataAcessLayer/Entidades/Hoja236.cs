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

    // The table 'Hoja2$' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    // Hoja2$
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Hoja236
    {
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Centros")]
        public string Centros { get; set; } // CENTROS (length: 255)

        [Display(Name = "Numptemabe")]
        public double? Numptemabe { get; set; } // NUMPTEMABE

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; } // DESCRIPCION (length: 255)

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Fa mabe")]
        public string FaMabe { get; set; } // FA MABE (length: 255)

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec aplicacion fa")]
        public System.DateTime? FecAplicacionFa { get; set; } // FEC_APLICACION_FA

        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "F 6")]
        public string F6 { get; set; } // F6 (length: 255)
    }

}
// </auto-generated>
