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

    // tra_liq_his
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TraLiqHis
    {
        [Required]
        [Display(Name = "Id liq his")]
        public int IdLiqHis { get; set; } // id_liq_his (Primary key)

        [Display(Name = "Id ori")]
        public int? IdOri { get; set; } // id_ori

        [Display(Name = "Id liq ori")]
        public int? IdLiqOri { get; set; } // id_liq_ori

        [Display(Name = "Id liq pag")]
        public int? IdLiqPag { get; set; } // id_liq_pag

        [Display(Name = "Id operador")]
        public int? IdOperador { get; set; } // id_operador

        [Display(Name = "Anticipo")]
        public double? Anticipo { get; set; } // anticipo

        [Display(Name = "Sdo pen")]
        public double? SdoPen { get; set; } // sdo_pen

        [Display(Name = "Pago")]
        public double? Pago { get; set; } // pago

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime? FecReg { get; set; } // fec_reg

        [Display(Name = "C principal")]
        public byte? CPrincipal { get; set; } // c_principal

        [Display(Name = "Status")]
        public byte? Status { get; set; } // status

        public TraLiqHis()
        {
            IdLiqHis = 0;
            IdOri = 0;
            IdLiqOri = 0;
            IdLiqPag = 0;
            IdOperador = 0;
            Anticipo = 0;
            SdoPen = 0;
            Pago = 0;
            CPrincipal = 0;
            Status = 0;
        }
    }

}
// </auto-generated>
