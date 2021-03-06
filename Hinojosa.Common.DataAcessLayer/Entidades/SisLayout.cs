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

    // sis_layout
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisLayout
    {
        [Required]
        [Display(Name = "Id layout")]
        public int IdLayout { get; set; } // id_layout (Primary key)

        [Required]
        [Display(Name = "Id rec")]
        public int IdRec { get; set; } // id_rec

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (length: 30)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Layout")]
        public string Layout { get; set; } // layout

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [MaxLength(1)]
        [StringLength(1)]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; } // Tipo (length: 1)

        public SisLayout()
        {
            IdLayout = 0;
            IdRec = 0;
            Des = "";
            Layout = "";
            FecReg = System.DateTime.Now;
            Status = 0;
            Tipo = "S";
        }
    }

}
// </auto-generated>
