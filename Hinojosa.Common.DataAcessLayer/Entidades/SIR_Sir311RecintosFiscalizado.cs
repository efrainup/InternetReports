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

    // SIR_311_RECINTOS_FISCALIZADOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir311RecintosFiscalizado
    {
        [Required]
        [Display(Name = "N ID rec fisc 311")]
        public int NIdRecFisc311 { get; set; } // nIdRecFisc311 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "S clave")]
        public string SClave { get; set; } // sClave (length: 3)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S ciudad")]
        public string SCiudad { get; set; } // sCiudad (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S nombre")]
        public string SNombre { get; set; } // sNombre (length: 100)

        [Display(Name = "N ID adu sec 06")]
        public int? NIdAduSec06 { get; set; } // nIdAduSec06

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Required]
        [Display(Name = "B status")]
        public bool BStatus { get; set; } // bStatus

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir206Remesa where [SIR_206_REMESAS].[nIdRecFisc311] point to this entity (FK_SIR_206_REMESAS_SIR_311_RECINTOS_FISCALIZADOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir206Remesa> SIR_Sir206Remesa { get; set; } // SIR_206_REMESAS.FK_SIR_206_REMESAS_SIR_311_RECINTOS_FISCALIZADOS

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir06AduanaSec pointed by [SIR_311_RECINTOS_FISCALIZADOS].([NIdAduSec06]) (FK_SIR_311_RECINTOS_FISCALIZADOS_SIR_06_ADUANA_SEC)
        /// </summary>
        public virtual SIR_Sir06AduanaSec SIR_Sir06AduanaSec { get; set; } // FK_SIR_311_RECINTOS_FISCALIZADOS_SIR_06_ADUANA_SEC

        public SIR_Sir311RecintosFiscalizado()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            BStatus = true;
            SIR_Sir206Remesa = new System.Collections.Generic.List<SIR_Sir206Remesa>();
        }
    }

}
// </auto-generated>
