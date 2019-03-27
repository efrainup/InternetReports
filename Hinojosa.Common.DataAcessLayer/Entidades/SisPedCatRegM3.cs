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

    // The table 'sis_ped_cat_reg_m3' is not usable by entity framework because it
    // does not have a primary key. It is listed here for completeness.
    // sis_ped_cat_reg_m3
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisPedCatRegM3
    {
        [Display(Name = "Id regimen")]
        public int? IdRegimen { get; set; } // id_regimen

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Clave regimen")]
        public string ClaveRegimen { get; set; } // clave_regimen (length: 50)

        [Display(Name = "Descripcion regimen")]
        public string DescripcionRegimen { get; set; } // descripcion_regimen
    }

}
// </auto-generated>
