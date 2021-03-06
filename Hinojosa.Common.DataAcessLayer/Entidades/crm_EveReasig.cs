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

    // eve_reasig
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_EveReasig
    {
        [Required]
        [Display(Name = "Id reasig")]
        public int IdReasig { get; set; } // id_reasig (Primary key)

        [Required]
        [Display(Name = "Id eve")]
        public int IdEve { get; set; } // id_eve

        [Required]
        [Display(Name = "Id tip obj solic")]
        public int IdTipObjSolic { get; set; } // id_tip_obj_solic

        [Required]
        [Display(Name = "Id solic")]
        public int IdSolic { get; set; } // id_solic

        [Required]
        [Display(Name = "Id tip obj asig")]
        public int IdTipObjAsig { get; set; } // id_tip_obj_asig

        [Required]
        [Display(Name = "Id asig")]
        public int IdAsig { get; set; } // id_asig

        [Required]
        [Display(Name = "Id tip obj asig ant")]
        public int IdTipObjAsigAnt { get; set; } // id_tip_obj_asig_ant

        [Required]
        [Display(Name = "Id asig ant")]
        public int IdAsigAnt { get; set; } // id_asig_ant

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fec reasig")]
        public System.DateTime DFecReasig { get; set; } // d_fec_reasig

        public crm_EveReasig()
        {
            IdReasig = 0;
            IdEve = 0;
            IdTipObjSolic = 0;
            IdSolic = 0;
            IdTipObjAsig = 0;
            IdAsig = 0;
            IdTipObjAsigAnt = 0;
            IdAsigAnt = 0;
            DFecReasig = System.DateTime.Now;
        }
    }

}
// </auto-generated>
