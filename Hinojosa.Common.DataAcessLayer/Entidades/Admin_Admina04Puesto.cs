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

    // ADMINA_04_PUESTOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Admin_Admina04Puesto
    {
        [Required]
        [Display(Name = "N ID puesto 04")]
        public int NIdPuesto04 { get; set; } // nIdPuesto04 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S nombre")]
        public string SNombre { get; set; } // sNombre (length: 100)

        // Reverse navigation

        /// <summary>
        /// Child Admin_Admina01Usuario (Many-to-Many) mapped by table [ADMINA_13_CATEGORIAS_PERSONAL]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Admin_Admina01Usuario> Admin_Admina01Usuario { get; set; } // Many to many mapping
        /// <summary>
        /// Child Admin_Admina02Personal where [ADMINA_02_PERSONAL].[nIdPuesto04] point to this entity (FK_ADMINA_02_PERSONAL_ADMINA_04_PUESTOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Admin_Admina02Personal> Admin_Admina02Personal { get; set; } // ADMINA_02_PERSONAL.FK_ADMINA_02_PERSONAL_ADMINA_04_PUESTOS

        public Admin_Admina04Puesto()
        {
            Admin_Admina02Personal = new System.Collections.Generic.List<Admin_Admina02Personal>();
            Admin_Admina01Usuario = new System.Collections.Generic.List<Admin_Admina01Usuario>();
        }
    }

}
// </auto-generated>
