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

    // sis_rel_act_emp
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisRelActEmp
    {
        [Required]
        [Display(Name = "Id rel act emp")]
        public int IdRelActEmp { get; set; } // id_rel_act_emp (Primary key)

        [Required]
        [Display(Name = "Id rel act")]
        public int IdRelAct { get; set; } // id_rel_act

        [Required]
        [Display(Name = "Id rel emp")]
        public int IdRelEmp { get; set; } // id_rel_emp

        [Required]
        [Display(Name = "Cant")]
        public int Cant { get; set; } // cant

        [Required]
        [Display(Name = "Costo")]
        public double Costo { get; set; } // costo

        [Required]
        [Display(Name = "Costo tot")]
        public double CostoTot { get; set; } // costo_tot

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec asig")]
        public System.DateTime FecAsig { get; set; } // fec_asig

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec dev")]
        public System.DateTime FecDev { get; set; } // fec_dev

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status

        [Required]
        [Display(Name = "Id depto")]
        public int IdDepto { get; set; } // id_depto

        [Required]
        [Display(Name = "C val asig")]
        public byte CValAsig { get; set; } // c_val_asig

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required]
        [Display(Name = "Id ubic")]
        public int IdUbic { get; set; } // id_ubic

        public SisRelActEmp()
        {
            IdRelActEmp = 0;
            IdRelAct = 0;
            IdRelEmp = 0;
            Cant = 0;
            Costo = 0;
            CostoTot = 0;
            Status = 1;
            IdDepto = 0;
            CValAsig = 0;
            IdNota = 0;
            IdUbic = 0;
        }
    }

}
// </auto-generated>
