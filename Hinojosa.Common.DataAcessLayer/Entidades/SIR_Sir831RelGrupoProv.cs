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

    // SIR_831_REL_GRUPO_PROV
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir831RelGrupoProv
    {
        [Required]
        [Display(Name = "N ID grupo prov 830")]
        public int NIdGrupoProv830 { get; set; } // nIdGrupoProv830 (Primary key)

        [Required]
        [Display(Name = "N ID proveedor 42")]
        public int NIdProveedor42 { get; set; } // nIdProveedor42 (Primary key)

        [Required]
        [Display(Name = "B incluir")]
        public bool BIncluir { get; set; } // bIncluir

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir42Proveedore pointed by [SIR_831_REL_GRUPO_PROV].([NIdProveedor42]) (FK_SIR_831_REL_GRUPO_PROV_SIR_42_PROVEEDORES)
        /// </summary>
        public virtual SIR_Sir42Proveedore SIR_Sir42Proveedore { get; set; } // FK_SIR_831_REL_GRUPO_PROV_SIR_42_PROVEEDORES

        /// <summary>
        /// Parent SIR_Sir830GrupoProveedore pointed by [SIR_831_REL_GRUPO_PROV].([NIdGrupoProv830]) (FK_SIR_831_REL_GRUPO_PROV_SIR_830_GRUPO_PROVEEDORES)
        /// </summary>
        public virtual SIR_Sir830GrupoProveedore SIR_Sir830GrupoProveedore { get; set; } // FK_SIR_831_REL_GRUPO_PROV_SIR_830_GRUPO_PROVEEDORES

        public SIR_Sir831RelGrupoProv()
        {
            BIncluir = true;
        }
    }

}
// </auto-generated>