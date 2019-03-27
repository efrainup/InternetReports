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

    // PE_Terminales
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class PeTerminale
    {
        [Required]
        [Display(Name = "N ID terminal")]
        public int NIdTerminal { get; set; } // nIdTerminal (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "S nombre terminal")]
        public string SNombreTerminal { get; set; } // sNombreTerminal (length: 250)

        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "S nombre corto")]
        public string SNombreCorto { get; set; } // sNombreCorto (length: 250)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S siglas")]
        public string SSiglas { get; set; } // sSiglas (length: 50)

        [Required]
        [Display(Name = "N activo")]
        public int NActivo { get; set; } // nActivo

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha alta")]
        public System.DateTime DFechaAlta { get; set; } // dFechaAlta

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime? DFechaEdicion { get; set; } // dFechaEdicion

        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "S clave")]
        public string SClave { get; set; } // sClave (length: 15)

        public PeTerminale()
        {
            NActivo = 1;
            DFechaAlta = System.DateTime.Now;
        }
    }

}
// </auto-generated>
