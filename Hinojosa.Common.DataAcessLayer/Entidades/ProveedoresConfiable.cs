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

    // Proveedores_Confiables
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ProveedoresConfiable
    {
        [Required]
        [Display(Name = "N ID proveedor conf")]
        public int NIdProveedorConf { get; set; } // nIdProveedorConf (Primary key)

        [Required]
        [Display(Name = "N ID grupo")]
        public int NIdGrupo { get; set; } // nIdGrupo

        [Required]
        [Display(Name = "N ID proveedor")]
        public int NIdProveedor { get; set; } // nIdProveedor

        [Required]
        [Display(Name = "B activo")]
        public bool BActivo { get; set; } // bActivo

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha alta")]
        public System.DateTime DFechaAlta { get; set; } // dFechaAlta

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime? DFechaEdicion { get; set; } // dFechaEdicion

        public ProveedoresConfiable()
        {
            BActivo = true;
            DFechaAlta = System.DateTime.Now;
        }
    }

}
// </auto-generated>
