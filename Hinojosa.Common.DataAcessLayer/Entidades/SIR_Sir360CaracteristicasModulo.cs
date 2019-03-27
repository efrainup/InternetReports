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

    // SIR_360_CARACTERISTICAS_MODULOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir360CaracteristicasModulo
    {
        [Required]
        [Display(Name = "N ID carac 130")]
        public int NIdCarac130 { get; set; } // nIdCarac130 (Primary key via unique index UK_SIR_360_CARACTERISTICAS_MODULOS)

        [Display(Name = "N ID nodo")]
        public int? NIdNodo { get; set; } // nIdNodo

        [Display(Name = "N ID nodo 05")]
        public int? NIdNodo05 { get; set; } // nIdNodo05

        // Foreign keys

        /// <summary>
        /// Parent Admin_Admina05Nodo pointed by [SIR_360_CARACTERISTICAS_MODULOS].([NIdNodo05]) (FK_SIR_360_CARACTERISTICAS_MODULOS_ADMINA_05_NODOS)
        /// </summary>
        public virtual Admin_Admina05Nodo Admin_Admina05Nodo { get; set; } // FK_SIR_360_CARACTERISTICAS_MODULOS_ADMINA_05_NODOS

        /// <summary>
        /// Parent SIR_Sir130Caracteristica pointed by [SIR_360_CARACTERISTICAS_MODULOS].([NIdCarac130]) (FK_SIR_360_CARACTERISTICAS_MODULOS_SIR_130_CARACTERISTICAS)
        /// </summary>
        public virtual SIR_Sir130Caracteristica SIR_Sir130Caracteristica { get; set; } // FK_SIR_360_CARACTERISTICAS_MODULOS_SIR_130_CARACTERISTICAS

        /// <summary>
        /// Parent SisRecurso pointed by [SIR_360_CARACTERISTICAS_MODULOS].([NIdNodo]) (FK_SIR_360_CARACTERISTICAS_MODULOS_sis_recursos)
        /// </summary>
        public virtual SisRecurso SisRecurso { get; set; } // FK_SIR_360_CARACTERISTICAS_MODULOS_sis_recursos
    }

}
// </auto-generated>
