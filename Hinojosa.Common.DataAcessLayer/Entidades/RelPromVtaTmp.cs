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

    // rel_prom_vta_tmp
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class RelPromVtaTmp
    {
        [Required]
        [Display(Name = "Id rel prom vta tmp")]
        public int IdRelPromVtaTmp { get; set; } // id_rel_prom_vta_tmp (Primary key)

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc

        [Required]
        [Display(Name = "Id serie")]
        public int IdSerie { get; set; } // id_serie

        [Required]
        [Display(Name = "Num doc")]
        public int NumDoc { get; set; } // num_doc

        [Required]
        [Display(Name = "Id sesion")]
        public int IdSesion { get; set; } // id_sesion

        [Required]
        [Display(Name = "No part")]
        public int NoPart { get; set; } // no_part

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro

        public RelPromVtaTmp()
        {
            IdTipDoc = 0;
            IdSerie = 0;
            NumDoc = 0;
            IdSesion = 0;
            NoPart = 0;
            IdPro = 0;
        }
    }

}
// </auto-generated>
