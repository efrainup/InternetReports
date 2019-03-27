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

    // cat_udm_conv
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatUdmConv
    {
        [Required]
        [Display(Name = "Id conv")]
        public int IdConv { get; set; } // id_conv (Primary key)

        [Required]
        [Display(Name = "Id ori")]
        public int IdOri { get; set; } // id_ori

        [Required]
        [Display(Name = "Id dest")]
        public int IdDest { get; set; } // id_dest

        [Required]
        [Display(Name = "Ftr")]
        public decimal Ftr { get; set; } // ftr

        public CatUdmConv()
        {
            IdConv = 0;
            IdOri = 0;
            IdDest = 0;
            Ftr = 0m;
        }
    }

}
// </auto-generated>
