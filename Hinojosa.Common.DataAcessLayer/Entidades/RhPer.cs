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

    // rh_per
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class RhPer
    {
        [Required]
        [Display(Name = "Id per rh")]
        public int IdPerRh { get; set; } // id_per_rh (Primary key)

        [Required]
        [Display(Name = "Eje")]
        public int Eje { get; set; } // eje (Primary key)

        [Required]
        [Display(Name = "Id tip per")]
        public int IdTipPer { get; set; } // id_tip_per (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ini")]
        public System.DateTime FecIni { get; set; } // fec_ini (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec fin")]
        public System.DateTime FecFin { get; set; } // fec_fin (Primary key)

        [Required]
        [Display(Name = "Num per")]
        public int NumPer { get; set; } // num_per (Primary key)

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status (Primary key)

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg (Primary key)

        [Required]
        [Display(Name = "C cer")]
        public byte CCer { get; set; } // c_cer (Primary key)

        [Required]
        [Display(Name = "Dias")]
        public byte Dias { get; set; } // dias (Primary key)

        public RhPer()
        {
            IdPerRh = 0;
            Eje = 0;
            IdTipPer = 0;
            NumPer = 0;
            Status = 1;
            IdUsr = 0;
            CCer = 0;
            Dias = 0;
        }
    }

}
// </auto-generated>
