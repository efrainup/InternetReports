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

    // tblAnalytics_rel_usr
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TblAnalyticsRelUsr
    {
        [Required]
        [Display(Name = "Iid usr rel chart")]
        public int IidUsrRelChart { get; set; } // iid_usr_rel_chart (Primary key)

        [Required]
        [Display(Name = "Iid chart")]
        public int IidChart { get; set; } // iid_chart (Primary key)

        [Required]
        [Display(Name = "Iid usr")]
        public int IidUsr { get; set; } // iid_usr (Primary key)

        [Required]
        [Display(Name = "Iid rec")]
        public int IidRec { get; set; } // iid_rec (Primary key)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Vnom chart")]
        public string VnomChart { get; set; } // vnom_chart (Primary key)

        [Required]
        [Display(Name = "Itipo refresh")]
        public int ItipoRefresh { get; set; } // itipo_refresh (Primary key)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Vtitulo")]
        public string Vtitulo { get; set; } // vtitulo (Primary key)

        [Required]
        [Display(Name = "Iposicion")]
        public int Iposicion { get; set; } // iposicion (Primary key)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Vlayout chart")]
        public string VlayoutChart { get; set; } // vlayout_chart (Primary key)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Vcadena")]
        public string Vcadena { get; set; } // vcadena (Primary key)

        [Required]
        [Display(Name = "Iid panel")]
        public int IidPanel { get; set; } // iid_Panel (Primary key)

        [Required]
        [Display(Name = "V default")]
        public int VDefault { get; set; } // vDefault (Primary key)

        public TblAnalyticsRelUsr()
        {
            IidChart = 0;
            IidUsr = 0;
            IidRec = 0;
            ItipoRefresh = 0;
            Iposicion = 0;
            IidPanel = 0;
            VDefault = 1;
        }
    }

}
// </auto-generated>
