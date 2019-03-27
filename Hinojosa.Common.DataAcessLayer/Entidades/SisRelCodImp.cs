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

    // sis_rel_cod_imp
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisRelCodImp
    {
        [Required]
        [Display(Name = "Id tip")]
        public int IdTip { get; set; } // id_tip (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "C impuesto")]
        public string CImpuesto { get; set; } // c_impuesto (length: 10)

        [Required]
        [Display(Name = "C ret")]
        public byte CRet { get; set; } // c_ret

        [Required]
        [Display(Name = "C tras")]
        public byte CTras { get; set; } // c_tras

        [Required]
        [Display(Name = "Tipo")]
        public byte Tipo { get; set; } // tipo

        [Required]
        [Display(Name = "Id edo apl")]
        public int IdEdoApl { get; set; } // id_edo_apl

        public SisRelCodImp()
        {
            CImpuesto = "";
            CRet = 0;
            CTras = 0;
            Tipo = 0;
            IdEdoApl = 0;
        }
    }

}
// </auto-generated>