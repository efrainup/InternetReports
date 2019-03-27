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

    // log_layout
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class LogLayout
    {
        [Required]
        [Display(Name = "Id layout")]
        public int IdLayout { get; set; } // id_layout (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Clave layout")]
        public string ClaveLayout { get; set; } // clave_layout (Primary key) (length: 255)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Des layout")]
        public string DesLayout { get; set; } // des_layout (Primary key) (length: 255)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Xml layout")]
        public string XmlLayout { get; set; } // xml_layout (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ult mod")]
        public System.DateTime FecUltMod { get; set; } // fec_ult_mod (Primary key)

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr (Primary key)

        [Required]
        [Display(Name = "Id usr mod")]
        public int IdUsrMod { get; set; } // id_usr_mod (Primary key)

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc (Primary key)

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status (Primary key)

        [Required]
        [Display(Name = "Agrupacion")]
        public bool Agrupacion { get; set; } // agrupacion (Primary key)

        [Required]
        [Display(Name = "Colapsada")]
        public bool Colapsada { get; set; } // colapsada (Primary key)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Col visibles")]
        public string ColVisibles { get; set; } // col_visibles (Primary key)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Col totales")]
        public string ColTotales { get; set; } // col_totales (Primary key)

        public LogLayout()
        {
            IdLayout = 0;
            ClaveLayout = "";
            DesLayout = "";
            XmlLayout = "";
            FecReg = System.DateTime.Now;
            FecUltMod = System.DateTime.Now;
            IdUsr = 0;
            IdUsrMod = 0;
            IdTipDoc = 0;
            Status = 0;
            Agrupacion = false;
            Colapsada = false;
            ColVisibles = "";
            ColTotales = "";
        }
    }

}
// </auto-generated>
