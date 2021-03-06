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

    // cat_impto_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatImptoDet
    {
        [Required]
        [Display(Name = "Id impto det")]
        public int IdImptoDet { get; set; } // id_impto_det (Primary key)

        [Required]
        [Display(Name = "Id impto")]
        public int IdImpto { get; set; } // id_impto

        [Required]
        [Display(Name = "Id cod imp")]
        public int IdCodImp { get; set; } // id_cod_imp

        [Required]
        [Display(Name = "Id cta")]
        public int IdCta { get; set; } // id_cta

        [Required]
        [Display(Name = "Id impto det rel iva")]
        public int IdImptoDetRelIva { get; set; } // id_impto_det_rel_iva

        [Required]
        [Display(Name = "C base iva")]
        public byte CBaseIva { get; set; } // c_base_iva

        [Required]
        [Display(Name = "Id tip ret")]
        public int IdTipRet { get; set; } // id_tip_ret

        [Required]
        [Display(Name = "C excluir cfdi")]
        public bool CExcluirCfdi { get; set; } // c_excluir_cfdi

        public CatImptoDet()
        {
            IdImptoDet = 0;
            IdImpto = 0;
            IdCodImp = 0;
            IdCta = 0;
            IdImptoDetRelIva = 0;
            CBaseIva = 0;
            IdTipRet = 0;
            CExcluirCfdi = false;
        }
    }

}
// </auto-generated>
