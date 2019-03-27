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

    // hos_almac_permisos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class HosAlmacPermiso
    {
        [Required]
        [Display(Name = "Id permiso almac")]
        public int IdPermisoAlmac { get; set; } // id_permiso_almac (Primary key)

        [Required]
        [Display(Name = "Id almac")]
        public int IdAlmac { get; set; } // id_almac (Primary key)

        [Required]
        [Display(Name = "Id grp")]
        public int IdGrp { get; set; } // id_grp (Primary key)

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg (Primary key)

        [Required]
        [Display(Name = "Permiso")]
        public int Permiso { get; set; } // permiso (Primary key)

        public HosAlmacPermiso()
        {
            IdAlmac = 0;
            IdGrp = 0;
            IdUsr = 0;
            FecReg = System.DateTime.Now;
            Permiso = 0;
        }
    }

}
// </auto-generated>