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

    // vta_cor_caj_det_ant
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaCorCajDetAnt
    {
        [Required]
        [Display(Name = "Id ant cor")]
        public int IdAntCor { get; set; } // id_ant_cor (Primary key)

        [Required]
        [Display(Name = "Id cor caj")]
        public int IdCorCaj { get; set; } // id_cor_caj (Primary key)

        [Required]
        [Display(Name = "Id anticipo")]
        public int IdAnticipo { get; set; } // id_anticipo (Primary key)

        [Required]
        [Display(Name = "Id cliente")]
        public int IdCliente { get; set; } // id_cliente (Primary key)

        [Required]
        [Display(Name = "Monto")]
        public double Monto { get; set; } // monto (Primary key)

        [Required]
        [Display(Name = "Id doc")]
        public int IdDoc { get; set; } // id_doc (Primary key)

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status (Primary key)

        [Required]
        [Display(Name = "Fol apl")]
        public int FolApl { get; set; } // fol_apl (Primary key)

        public VtaCorCajDetAnt()
        {
            IdAntCor = 0;
            IdCorCaj = 0;
            IdAnticipo = 0;
            IdCliente = 0;
            Monto = 0.00;
            IdDoc = 0;
            Status = 0;
            FolApl = 0;
        }
    }

}
// </auto-generated>
