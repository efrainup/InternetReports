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

    // SIR_172_CONSULTAS_ACTIVIDADES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir172ConsultasActividade
    {
        [Required]
        [Display(Name = "N ID cons act 172")]
        public int NIdConsAct172 { get; set; } // nIdConsAct172 (Primary key)

        [Required]
        [Display(Name = "N ID actividad")]
        public int NIdActividad { get; set; } // nIdActividad

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "S consulta")]
        public string SConsulta { get; set; } // sConsulta

        // Foreign keys

        /// <summary>
        /// Parent CatPro pointed by [SIR_172_CONSULTAS_ACTIVIDADES].([NIdActividad]) (FK_SIR_172_CONSULTAS_ACTIVIDADES_cat_pro)
        /// </summary>
        public virtual CatPro CatPro { get; set; } // FK_SIR_172_CONSULTAS_ACTIVIDADES_cat_pro
    }

}
// </auto-generated>