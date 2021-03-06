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

    // ADMINA_16_DEPARTAMENTOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Admin_Admina16Departamento
    {
        [Required]
        [Display(Name = "N ID depto 16")]
        public int NIdDepto16 { get; set; } // nIdDepto16 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S nombre")]
        public string SNombre { get; set; } // sNombre (length: 100)

        // Reverse navigation

        /// <summary>
        /// Child Admin_Admina02Personal where [ADMINA_02_PERSONAL].[nIdDepto16] point to this entity (FK_ADMINA_02_PERSONAL_ADMINA_16_DEPARTAMENTOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Admin_Admina02Personal> Admin_Admina02Personal { get; set; } // ADMINA_02_PERSONAL.FK_ADMINA_02_PERSONAL_ADMINA_16_DEPARTAMENTOS

        public Admin_Admina16Departamento()
        {
            Admin_Admina02Personal = new System.Collections.Generic.List<Admin_Admina02Personal>();
        }
    }

}
// </auto-generated>
