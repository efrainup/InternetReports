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

    // cat_tra_pagpolequipo
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatTraPagpolequipo
    {
        [Required]
        [Display(Name = "Id equipo")]
        public int IdEquipo { get; set; } // id_equipo (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Seg poliza")]
        public string SegPoliza { get; set; } // seg_poliza (Primary key) (length: 10)

        [Required]
        [Display(Name = "Num pago")]
        public int NumPago { get; set; } // num_pago (Primary key)

        [Required]
        [Display(Name = "Monto")]
        public double Monto { get; set; } // monto (Primary key)

        [Required]
        [Display(Name = "Tipo")]
        public int Tipo { get; set; } // tipo (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ini")]
        public System.DateTime FecIni { get; set; } // fec_ini (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec venc")]
        public System.DateTime FecVenc { get; set; } // fec_venc (Primary key)

        [Required]
        [Display(Name = "Pagado")]
        public int Pagado { get; set; } // pagado (Primary key)

        public CatTraPagpolequipo()
        {
            IdEquipo = 0;
            SegPoliza = "";
            NumPago = 0;
            Monto = 0;
            Tipo = 0;
            Pagado = 0;
        }
    }

}
// </auto-generated>