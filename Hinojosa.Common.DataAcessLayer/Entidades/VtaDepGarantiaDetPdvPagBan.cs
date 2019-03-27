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

    // vta_dep_garantia_det_pdv_pag_ban
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaDepGarantiaDetPdvPagBan
    {
        [Required]
        [Display(Name = "Id folio")]
        public int IdFolio { get; set; } // id_folio (Primary key)

        [Required]
        [Display(Name = "Id pag ban")]
        public int IdPagBan { get; set; } // id_pag_ban (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Num cta")]
        public string NumCta { get; set; } // num_cta (Primary key) (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Nom bco")]
        public string NomBco { get; set; } // nom_bco (Primary key) (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Nom")]
        public string Nom { get; set; } // nom (Primary key) (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Num aut tran")]
        public string NumAutTran { get; set; } // num_aut_tran (Primary key) (length: 20)

        [Required]
        [Display(Name = "Monto")]
        public double Monto { get; set; } // monto (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Venc tar")]
        public string VencTar { get; set; } // venc_tar (Primary key) (length: 10)

        [Required]
        [Display(Name = "Id tem")]
        public int IdTem { get; set; } // id_tem (Primary key)

        public VtaDepGarantiaDetPdvPagBan()
        {
            IdFolio = 0;
            IdPagBan = 0;
            NumCta = "";
            NomBco = "";
            Nom = "";
            NumAutTran = "";
            Monto = 0;
            VencTar = "";
            IdTem = 0;
        }
    }

}
// </auto-generated>