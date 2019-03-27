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

    // sis_grp
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisGrp
    {
        [Required]
        [Display(Name = "Id grp")]
        public int IdGrp { get; set; } // id_grp (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Nom grp")]
        public string NomGrp { get; set; } // nom_grp (length: 50)

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha")]
        public System.DateTime Fecha { get; set; } // fecha

        // Reverse navigation

        /// <summary>
        /// Child CatUsrs where [cat_usr].[id_grp] point to this entity (FK_cat_usr_sis_grp)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<CatUsr> CatUsrs { get; set; } // cat_usr.FK_cat_usr_sis_grp

        public SisGrp()
        {
            CatUsrs = new System.Collections.Generic.List<CatUsr>();
        }
    }

}
// </auto-generated>