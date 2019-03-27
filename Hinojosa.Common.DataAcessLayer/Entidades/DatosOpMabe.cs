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

    // Datos_OpMabe
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class DatosOpMabe
    {
        [Required]
        [Display(Name = "N ID")]
        public int NId { get; set; } // nId (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "S referencia")]
        public string SReferencia { get; set; } // sReferencia (length: 15)

        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "S impo")]
        public string SImpo { get; set; } // sImpo (length: 25)

        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "S ee")]
        public string SEe { get; set; } // sEE (length: 25)

        ///<summary>
        /// Valores disponible: 
        /// 1) Activo, 
        /// 2) Baja
        ///</summary>
        [Required]
        [Display(Name = "N estado")]
        public int NEstado { get; set; } // nEstado

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha alta")]
        public System.DateTime DFechaAlta { get; set; } // dFechaAlta

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime? DFechaEdicion { get; set; } // dFechaEdicion

        public DatosOpMabe()
        {
            NEstado = 1;
            DFechaAlta = System.DateTime.Now;
        }
    }

}
// </auto-generated>