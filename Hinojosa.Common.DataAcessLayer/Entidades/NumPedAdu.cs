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

    // num_ped_adu
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class NumPedAdu
    {
        [Required]
        [Display(Name = "Id num ped adu")]
        public int IdNumPedAdu { get; set; } // id_num_ped_adu (Primary key)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "C aduana")]
        public string CAduana { get; set; } // c_aduana (length: 10)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Patente")]
        public string Patente { get; set; } // patente (length: 10)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Ejercicio")]
        public string Ejercicio { get; set; } // ejercicio (length: 10)

        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Cantidad")]
        public string Cantidad { get; set; } // cantidad (length: 10)

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ini vig")]
        public System.DateTime? FecIniVig { get; set; } // fec_ini_vig

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec fin vig")]
        public System.DateTime? FecFinVig { get; set; } // fec_fin_vig

        [Display(Name = "Status")]
        public byte? Status { get; set; } // status
    }

}
// </auto-generated>