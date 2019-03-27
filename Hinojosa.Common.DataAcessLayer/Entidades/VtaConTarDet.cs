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

    // vta_con_tar_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaConTarDet
    {
        [Required]
        [Display(Name = "Id vta con tar det")]
        public int IdVtaConTarDet { get; set; } // id_vta_con_tar_det (Primary key)

        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Tip pag tar")]
        public string TipPagTar { get; set; } // tip_pag_tar (length: 5)

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Nro tar")]
        public string NroTar { get; set; } // nro_tar (length: 20)

        [Display(Name = "Mto")]
        public double? Mto { get; set; } // mto

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Aut")]
        public string Aut { get; set; } // aut (length: 20)

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Nom cli")]
        public string NomCli { get; set; } // nom_cli (length: 100)

        [DataType(DataType.DateTime)]
        [Display(Name = "Fch")]
        public System.DateTime? Fch { get; set; } // fch

        [DataType(DataType.DateTime)]
        [Display(Name = "Hr")]
        public System.DateTime? Hr { get; set; } // hr

        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Fchdif")]
        public string Fchdif { get; set; } // fchdif (length: 15)

        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Tip trj")]
        public string TipTrj { get; set; } // tip_trj (length: 25)

        [Display(Name = "Id trn")]
        public int? IdTrn { get; set; } // id_trn

        [Display(Name = "Num trn")]
        public int? NumTrn { get; set; } // num_trn

        [Display(Name = "Id suc")]
        public int? IdSuc { get; set; } // id_suc

        [Display(Name = "Id dep")]
        public int? IdDep { get; set; } // id_dep

        [Display(Name = "Status")]
        public int? Status { get; set; } // status

        [Display(Name = "Id session")]
        public int? IdSession { get; set; } // id_session

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Cve cli")]
        public string CveCli { get; set; } // cve_cli (length: 20)

        [Required]
        [Display(Name = "Id con dep rep")]
        public int IdConDepRep { get; set; } // id_con_dep_rep (Primary key)

        public VtaConTarDet()
        {
            IdConDepRep = 0;
        }
    }

}
// </auto-generated>