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

    // hos_sis_int
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class HosSisInt
    {
        [Required]
        [Display(Name = "Id int")]
        public int IdInt { get; set; } // id_int (Primary key)

        [Required]
        [Display(Name = "Id ref")]
        public int IdRef { get; set; } // id_ref

        [Required]
        [Display(Name = "Id aut")]
        public int IdAut { get; set; } // id_aut

        [Required]
        [Display(Name = "Id fac pac")]
        public int IdFacPac { get; set; } // id_fac_pac

        [Required]
        [Display(Name = "Id fac emp")]
        public int IdFacEmp { get; set; } // id_fac_emp

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro

        [Required]
        [Display(Name = "Precio")]
        public double Precio { get; set; } // precio

        [Required]
        [Display(Name = "Cant")]
        public double Cant { get; set; } // cant

        [Required]
        [Display(Name = "Importe")]
        public double Importe { get; set; } // importe

        [Required]
        [Display(Name = "Imptos")]
        public double Imptos { get; set; } // imptos

        [Required]
        [Display(Name = "Total")]
        public double Total { get; set; } // total

        [Required]
        [Display(Name = "Monto max")]
        public double MontoMax { get; set; } // monto_max

        [Required]
        [Display(Name = "Deducible")]
        public double Deducible { get; set; } // deducible

        [Required]
        [Display(Name = "Coaseguro")]
        public double Coaseguro { get; set; } // coaseguro

        [Required]
        [Display(Name = "Monto cgm")]
        public double MontoCgm { get; set; } // monto_cgm

        [Required]
        [Display(Name = "Imptos cgm")]
        public double ImptosCgm { get; set; } // imptos_cgm

        [Required]
        [Display(Name = "Total cgm")]
        public double TotalCgm { get; set; } // total_cgm

        [Required]
        [Display(Name = "Tope aut")]
        public double TopeAut { get; set; } // tope_aut

        [Required]
        [Display(Name = "Tope cpt")]
        public double TopeCpt { get; set; } // tope_cpt

        [Required]
        [Display(Name = "Ded monto")]
        public double DedMonto { get; set; } // ded_monto

        [Required]
        [Display(Name = "Ded impto")]
        public double DedImpto { get; set; } // ded_impto

        [Required]
        [Display(Name = "Ded total")]
        public double DedTotal { get; set; } // ded_total

        [Required]
        [Display(Name = "Coa monto")]
        public double CoaMonto { get; set; } // coa_monto

        [Required]
        [Display(Name = "Coa impto")]
        public double CoaImpto { get; set; } // coa_impto

        [Required]
        [Display(Name = "Coa total")]
        public double CoaTotal { get; set; } // coa_total

        [Required]
        [Display(Name = "Pac cpt monto")]
        public double PacCptMonto { get; set; } // pac_cpt_monto

        [Required]
        [Display(Name = "Pac cpt impto")]
        public double PacCptImpto { get; set; } // pac_cpt_impto

        [Required]
        [Display(Name = "Pac cpt total")]
        public double PacCptTotal { get; set; } // pac_cpt_total

        [Required]
        [Display(Name = "Emp cpt monto")]
        public double EmpCptMonto { get; set; } // emp_cpt_monto

        [Required]
        [Display(Name = "Emp cpt impto")]
        public double EmpCptImpto { get; set; } // emp_cpt_impto

        [Required]
        [Display(Name = "Emp cpt total")]
        public double EmpCptTotal { get; set; } // emp_cpt_total

        [Required]
        [Display(Name = "Pac monto")]
        public double PacMonto { get; set; } // pac_monto

        [Required]
        [Display(Name = "Pac impto")]
        public double PacImpto { get; set; } // pac_impto

        [Required]
        [Display(Name = "Pac total")]
        public double PacTotal { get; set; } // pac_total

        [Required]
        [Display(Name = "Emp monto")]
        public double EmpMonto { get; set; } // emp_monto

        [Required]
        [Display(Name = "Emp impto")]
        public double EmpImpto { get; set; } // emp_impto

        [Required]
        [Display(Name = "Emp total")]
        public double EmpTotal { get; set; } // emp_total

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec mod")]
        public System.DateTime FecMod { get; set; } // fec_mod

        [Required]
        [Display(Name = "Id suc sol")]
        public int IdSucSol { get; set; } // id_suc_sol

        [Required]
        [Display(Name = "Id suc")]
        public int IdSuc { get; set; } // id_suc

        public HosSisInt()
        {
            IdRef = 0;
            IdAut = 0;
            IdFacPac = 0;
            IdFacEmp = 0;
            IdPro = 0;
            Precio = 0;
            Cant = 0;
            Importe = 0;
            Imptos = 0;
            Total = 0;
            MontoMax = 0;
            Deducible = 0;
            Coaseguro = 0;
            MontoCgm = 0;
            ImptosCgm = 0;
            TotalCgm = 0;
            TopeAut = 0;
            TopeCpt = 0;
            DedMonto = 0;
            DedImpto = 0;
            DedTotal = 0;
            CoaMonto = 0;
            CoaImpto = 0;
            CoaTotal = 0;
            PacCptMonto = 0;
            PacCptImpto = 0;
            PacCptTotal = 0;
            EmpCptMonto = 0;
            EmpCptImpto = 0;
            EmpCptTotal = 0;
            PacMonto = 0;
            PacImpto = 0;
            PacTotal = 0;
            EmpMonto = 0;
            EmpImpto = 0;
            EmpTotal = 0;
            IdSucSol = 0;
            IdSuc = 0;
        }
    }

}
// </auto-generated>
