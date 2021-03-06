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

    // sis_ped_cont
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisPedCont
    {
        [Required]
        [Display(Name = "Id cont")]
        public int IdCont { get; set; } // id_cont (Primary key)

        [Display(Name = "Id ped")]
        public int? IdPed { get; set; } // id_ped

        [Display(Name = "Numero")]
        public string Numero { get; set; } // numero

        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; } // descripcion

        [Display(Name = "Id usr")]
        public int? IdUsr { get; set; } // id_usr

        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime? FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Id pedimento")]
        public int IdPedimento { get; set; } // id_pedimento (Primary key)

        [Required]
        [Display(Name = "Tip cont")]
        public int TipCont { get; set; } // tip_cont (Primary key)

        public SisPedCont()
        {
            IdPedimento = 0;
            TipCont = 0;
        }
    }

}
// </auto-generated>
