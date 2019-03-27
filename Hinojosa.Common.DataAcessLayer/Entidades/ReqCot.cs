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

    // req_cot
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ReqCot
    {
        [Required]
        [Display(Name = "Id req cot")]
        public int IdReqCot { get; set; } // id_req_cot (Primary key)

        [Required]
        [Display(Name = "Id rel cot")]
        public int IdRelCot { get; set; } // id_rel_cot

        [Required]
        [Display(Name = "Part")]
        public int Part { get; set; } // part

        [Required]
        [Display(Name = "Id prov")]
        public int IdProv { get; set; } // id_prov

        [Required]
        [Display(Name = "Id mda")]
        public int IdMda { get; set; } // id_mda

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec cot")]
        public System.DateTime FecCot { get; set; } // fec_cot

        [Required]
        [Display(Name = "Id cnd")]
        public int IdCnd { get; set; } // id_cnd

        [Required]
        [Display(Name = "Dias")]
        public int Dias { get; set; } // dias

        [Required]
        [Display(Name = "Costo")]
        public double Costo { get; set; } // costo

        [Required]
        [Display(Name = "Costo total")]
        public double CostoTotal { get; set; } // costo_total

        [Required]
        [Display(Name = "Id nota cot")]
        public int IdNotaCot { get; set; } // id_nota_cot

        [Required]
        [Display(Name = "Oper")]
        public byte Oper { get; set; } // oper

        [Required]
        [Display(Name = "Tc")]
        public double Tc { get; set; } // tc

        [Required]
        [Display(Name = "C recom")]
        public byte CRecom { get; set; } // c_recom

        [Required]
        [Display(Name = "No cot")]
        public int NoCot { get; set; } // no_cot

        [Required]
        [Display(Name = "Id prov pad")]
        public int IdProvPad { get; set; } // id_prov_pad

        [Required]
        [Display(Name = "Id suc")]
        public int IdSuc { get; set; } // id_suc

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        public ReqCot()
        {
            IdReqCot = 0;
            IdRelCot = 0;
            Part = 0;
            IdProv = 0;
            IdMda = 0;
            IdCnd = 0;
            Dias = 0;
            Costo = 0;
            CostoTotal = 0;
            IdNotaCot = 0;
            Oper = 0;
            Tc = 0;
            CRecom = 0;
            NoCot = 0;
            IdProvPad = 0;
            IdSuc = 0;
            IdUsr = 0;
        }
    }

}
// </auto-generated>