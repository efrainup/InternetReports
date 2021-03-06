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

    // sis_ped_recti
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisPedRecti
    {
        [Required]
        [Display(Name = "Id ped")]
        public int IdPed { get; set; } // id_ped (Primary key)

        [Required]
        [Display(Name = "Num pat age")]
        public int NumPatAge { get; set; } // num_pat_age (Primary key)

        [Required]
        [Display(Name = "Num doc asig")]
        public int NumDocAsig { get; set; } // num_doc_asig (Primary key)

        [Required]
        [Display(Name = "Clave adu")]
        public int ClaveAdu { get; set; } // clave_adu (Primary key)

        [Display(Name = "Clave tram adu")]
        public string ClaveTramAdu { get; set; } // clave_tram_adu

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec pag")]
        public System.DateTime FecPag { get; set; } // fec_pag (Primary key)

        [Required]
        [Display(Name = "Num ped ori")]
        public int NumPedOri { get; set; } // num_ped_ori (Primary key)

        [Required]
        [Display(Name = "Pat age ori")]
        public int PatAgeOri { get; set; } // pat_age_ori (Primary key)

        [Required]
        [Display(Name = "Adu ori")]
        public int AduOri { get; set; } // adu_ori (Primary key)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Clave doc ori")]
        public string ClaveDocOri { get; set; } // clave_doc_ori (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec oper ori")]
        public System.DateTime FecOperOri { get; set; } // fec_oper_ori (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg (Primary key)

        [Required]
        [Display(Name = "Id pedimento")]
        public int IdPedimento { get; set; } // id_pedimento (Primary key)

        public SisPedRecti()
        {
            IdPed = 0;
            NumPatAge = 0;
            NumDocAsig = 0;
            ClaveAdu = 0;
            ClaveTramAdu = "";
            NumPedOri = 0;
            PatAgeOri = 0;
            AduOri = 0;
            ClaveDocOri = "";
            FecReg = System.DateTime.Now;
            IdPedimento = 0;
        }
    }

}
// </auto-generated>
