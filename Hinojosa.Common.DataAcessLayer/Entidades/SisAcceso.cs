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

    // sis_accesos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisAcceso
    {
        [Required]
        [Display(Name = "Id acceso")]
        public int IdAcceso { get; set; } // id_acceso (Primary key)

        [Required]
        [Display(Name = "Id grp")]
        public int IdGrp { get; set; } // id_grp

        [Required]
        [Display(Name = "Id rec")]
        public int IdRec { get; set; } // id_rec

        [Required]
        [Display(Name = "Permiso")]
        public int Permiso { get; set; } // permiso

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [Display(Name = "Id grp pad")]
        public int IdGrpPad { get; set; } // id_grp_pad

        [Required]
        [Display(Name = "Id grp acc")]
        public int IdGrpAcc { get; set; } // id_grp_acc

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Cond")]
        public string Cond { get; set; } // cond

        // Foreign keys

        /// <summary>
        /// Parent SisRecurso pointed by [sis_accesos].([IdRec]) (FK_sis_accesos_sis_recursos)
        /// </summary>
        public virtual SisRecurso SisRecurso { get; set; } // FK_sis_accesos_sis_recursos

        public SisAcceso()
        {
            IdAcceso = 0;
            IdGrp = 0;
            IdRec = 0;
            Permiso = 1;
            IdUsr = 0;
            IdGrpPad = 0;
            IdGrpAcc = 0;
            Cond = "";
        }
    }

}
// </auto-generated>
