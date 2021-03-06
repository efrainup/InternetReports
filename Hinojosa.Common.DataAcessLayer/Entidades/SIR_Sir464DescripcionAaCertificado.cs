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

    // SIR_464_DESCRIPCION_AA_CERTIFICADO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir464DescripcionAaCertificado
    {
        [Required]
        [Display(Name = "N ID descrip aac ertificado 464")]
        public int NIdDescripAaCertificado464 { get; set; } // nIdDescripAACertificado464 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "S descripcion aa")]
        public string SDescripcionAa { get; set; } // sDescripcionAA (length: 250)

        [Display(Name = "S descripcion certificado")]
        public string SDescripcionCertificado { get; set; } // sDescripcionCertificado

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir167FraccionesArancelaria (Many-to-Many) mapped by table [SIR_465_DESCRIPCIONES_AA_FRACCIONES]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir167FraccionesArancelaria> SIR_Sir167FraccionesArancelaria { get; set; } // Many to many mapping

        public SIR_Sir464DescripcionAaCertificado()
        {
            SIR_Sir167FraccionesArancelaria = new System.Collections.Generic.List<SIR_Sir167FraccionesArancelaria>();
        }
    }

}
// </auto-generated>
