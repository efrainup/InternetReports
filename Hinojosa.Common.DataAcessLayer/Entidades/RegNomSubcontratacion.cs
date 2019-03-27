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

    // reg_nom_subcontratacion
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class RegNomSubcontratacion
    {
        [Required]
        [Display(Name = "Id sub")]
        public int IdSub { get; set; } // id_sub (Primary key)

        [Required]
        [Display(Name = "Id reg nom")]
        public int IdRegNom { get; set; } // id_reg_nom

        [Required]
        [Display(Name = "Id emp")]
        public int IdEmp { get; set; } // id_emp

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Rfc lab")]
        public string RfcLab { get; set; } // rfc_lab (length: 50)

        [Required]
        [Display(Name = "Prcj tiempo")]
        public int PrcjTiempo { get; set; } // prcj_tiempo

        public RegNomSubcontratacion()
        {
            IdRegNom = 0;
            IdEmp = 0;
            RfcLab = "";
            PrcjTiempo = 0;
        }
    }

}
// </auto-generated>
