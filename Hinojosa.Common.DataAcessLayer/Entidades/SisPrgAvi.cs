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

    // Sis_prg_avi
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisPrgAvi
    {
        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // Status

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // Fec_reg

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ult mod")]
        public System.DateTime FecUltMod { get; set; } // Fec_ult_mod

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // Id_usr

        [Required]
        [Display(Name = "Id usr mod")]
        public int IdUsrMod { get; set; } // Id_usr_mod

        [Required]
        [Display(Name = "Id avi")]
        public int IdAvi { get; set; } // Id_avi (Primary key)

        [Required]
        [Display(Name = "Tip avi")]
        public int TipAvi { get; set; } // Tip_avi

        [Required]
        [Display(Name = "Hbl")]
        public bool Hbl { get; set; } // hbl

        [Required]
        [Display(Name = "Prg bas cmp")]
        public bool PrgBasCmp { get; set; } // Prg_bas_cmp

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Cod avi")]
        public string CodAvi { get; set; } // Cod_avi (length: 30)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Des avi")]
        public string DesAvi { get; set; } // Des_avi (length: 255)

        [Required]
        [Display(Name = "Tip int")]
        public int TipInt { get; set; } // Tip_int

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "C env")]
        public string CEnv { get; set; } // C_env (length: 255)

        [Required]
        [Display(Name = "C expira")]
        public bool CExpira { get; set; } // C_expira

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ini")]
        public System.DateTime FecIni { get; set; } // Fec_ini

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec fin")]
        public System.DateTime FecFin { get; set; } // Fec_fin

        [Required]
        [Display(Name = "No eje")]
        public int NoEje { get; set; } // No_eje

        [Required(AllowEmptyStrings = true)]
        [MaxLength(7)]
        [StringLength(7)]
        [Display(Name = "Dia sem")]
        public string DiaSem { get; set; } // Dia_sem (length: 7)

        [Required]
        [Display(Name = "Dia mes")]
        public int DiaMes { get; set; } // Dia_mes

        [Required]
        [Display(Name = "Mes")]
        public int Mes { get; set; } // Mes

        [Required]
        [Display(Name = "El")]
        public int El { get; set; } // El

        [Required]
        [Display(Name = "Dia smn")]
        public int DiaSmn { get; set; } // Dia_smn

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Prx eje")]
        public System.DateTime PrxEje { get; set; } // Prx_eje

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Str query")]
        public string StrQuery { get; set; } // Str_query

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Id cmp")]
        public string IdCmp { get; set; } // Id_cmp (length: 255)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Cmp fec")]
        public string CmpFec { get; set; } // Cmp_fec (length: 100)

        [Required]
        [Display(Name = "Id pln")]
        public int IdPln { get; set; } // Id_pln

        [Required]
        [Display(Name = "Id sis avisos")]
        public int IdSisAvisos { get; set; } // Id_sis_avisos

        public SisPrgAvi()
        {
            Status = 0;
            FecReg = System.DateTime.Now;
            FecUltMod = System.DateTime.Now;
            IdUsr = 0;
            IdUsrMod = 0;
            TipAvi = 0;
            Hbl = false;
            PrgBasCmp = false;
            CodAvi = "";
            DesAvi = "";
            TipInt = 0;
            CEnv = "";
            CExpira = false;
            FecIni = System.DateTime.Now;
            FecFin = System.DateTime.Now;
            NoEje = 0;
            DiaSem = "0000000";
            DiaMes = 0;
            Mes = 0;
            El = 0;
            DiaSmn = 0;
            PrxEje = System.DateTime.Now;
            StrQuery = "";
            IdCmp = "";
            CmpFec = "";
            IdPln = 0;
            IdSisAvisos = 0;
        }
    }

}
// </auto-generated>
