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

    // PE_Buques
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class PeBuque
    {
        [Required]
        [Display(Name = "N ID buque")]
        public int NIdBuque { get; set; } // nIdBuque (Primary key)

        [Required]
        [Display(Name = "N ID cat buque")]
        public int NIdCatBuque { get; set; } // nIdCatBuque

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha cierre")]
        public System.DateTime DFechaCierre { get; set; } // dFechaCierre

        [Required]
        [Display(Name = "N ID terminal")]
        public int NIdTerminal { get; set; } // nIdTerminal

        [Required]
        [Display(Name = "N activo")]
        public int NActivo { get; set; } // nActivo

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha alta")]
        public System.DateTime DFechaAlta { get; set; } // dFechaAlta

        [Display(Name = "N ID usuario alta")]
        public int? NIdUsuarioAlta { get; set; } // nIdUsuarioAlta

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime? DFechaEdicion { get; set; } // dFechaEdicion

        [Display(Name = "N ID usuario edicion")]
        public int? NIdUsuarioEdicion { get; set; } // nIdUsuarioEdicion

        [Display(Name = "N finalizado")]
        public int? NFinalizado { get; set; } // nFinalizado

        public PeBuque()
        {
            NActivo = 1;
            DFechaAlta = System.DateTime.Now;
            NFinalizado = 0;
        }
    }

}
// </auto-generated>
