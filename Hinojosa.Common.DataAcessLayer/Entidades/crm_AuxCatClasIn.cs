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

    // aux_cat_clas_ins
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class crm_AuxCatClasIn
    {
        [Required]
        [Display(Name = "Id clas")]
        public int IdClas { get; set; } // id_clas (Primary key)

        [Required]
        [Display(Name = "Id clas gral")]
        public int IdClasGral { get; set; } // id_clas_gral (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Clave")]
        public string Clave { get; set; } // clave (Primary key) (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (Primary key) (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Cuenta")]
        public string Cuenta { get; set; } // cuenta (Primary key) (length: 20)

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status (Primary key)

        [Required]
        [Display(Name = "Sistema")]
        public byte Sistema { get; set; } // sistema (Primary key)

        [Required]
        [Display(Name = "Id mda")]
        public int IdMda { get; set; } // id_mda (Primary key)

        [Required]
        [Display(Name = "C cga")]
        public byte CCga { get; set; } // c_cga (Primary key)

        [Required]
        [Display(Name = "B repetido")]
        public byte BRepetido { get; set; } // b_repetido (Primary key)

        public crm_AuxCatClasIn()
        {
            IdClasGral = 0;
            Cuenta = "";
            Status = 1;
            Sistema = 0;
            IdMda = 0;
            CCga = 0;
            BRepetido = 0;
        }
    }

}
// </auto-generated>
