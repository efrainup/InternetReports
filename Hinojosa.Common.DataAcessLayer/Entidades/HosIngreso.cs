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

    // hos_ingreso
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class HosIngreso
    {
        [Required]
        [Display(Name = "Id ref")]
        public int IdRef { get; set; } // id_ref (Primary key)

        [Required]
        [Display(Name = "Id pac")]
        public int IdPac { get; set; } // id_pac

        [Required]
        [Display(Name = "Num ingreso")]
        public int NumIngreso { get; set; } // num_ingreso

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ing")]
        public System.DateTime FecIng { get; set; } // fec_ing

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Diagnostico")]
        public string Diagnostico { get; set; } // diagnostico (length: 255)

        [Required]
        [Display(Name = "Tipo ing")]
        public int TipoIng { get; set; } // tipo_ing

        [Required]
        [Display(Name = "Id cuarto")]
        public int IdCuarto { get; set; } // id_cuarto

        [Required]
        [Display(Name = "Id medico")]
        public int IdMedico { get; set; } // id_medico

        [Required]
        [Display(Name = "Id cli emp")]
        public int IdCliEmp { get; set; } // id_cli_emp

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [Display(Name = "Cierre admin")]
        public int CierreAdmin { get; set; } // cierre_admin

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec cierre admin")]
        public System.DateTime FecCierreAdmin { get; set; } // fec_cierre_admin

        [Required]
        [Display(Name = "Ptg aut")]
        public double PtgAut { get; set; } // ptg_aut

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec alta")]
        public System.DateTime FecAlta { get; set; } // fec_alta

        [Required]
        [Display(Name = "Id cirugia")]
        public int IdCirugia { get; set; } // id_cirugia

        [Required]
        [Display(Name = "Ing med")]
        public bool IngMed { get; set; } // ing_med

        [Required]
        [Display(Name = "Id suc")]
        public int IdSuc { get; set; } // id_suc

        public HosIngreso()
        {
            IdRef = 0;
            IdPac = 0;
            NumIngreso = 0;
            Diagnostico = "";
            TipoIng = 0;
            IdCuarto = 0;
            IdMedico = 0;
            IdCliEmp = 0;
            IdUsr = 0;
            FecReg = System.DateTime.Now;
            Status = 0;
            CierreAdmin = 0;
            PtgAut = 0;
            IdCirugia = 0;
            IngMed = false;
            IdSuc = 0;
        }
    }

}
// </auto-generated>
