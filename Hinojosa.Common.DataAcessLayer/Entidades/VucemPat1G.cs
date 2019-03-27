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

    // vucem_pat1g
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VucemPat1G
    {
        [Display(Name = "Id pat")]
        public int? IdPat { get; set; } // id_pat

        [Display(Name = "Patente")]
        public string Patente { get; set; } // patente

        [Display(Name = "Nombre")]
        public string Nombre { get; set; } // nombre

        [Display(Name = "Status")]
        public int? Status { get; set; } // status

        [Display(Name = "Id prov")]
        public int? IdProv { get; set; } // id_prov

        [Required]
        [Display(Name = "Id pat cat sat")]
        public int IdPatCatSat { get; set; } // id_pat_cat_sat (Primary key)

        public VucemPat1G()
        {
            IdPatCatSat = 0;
        }
    }

}
// </auto-generated>