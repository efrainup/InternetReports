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

    // SIR_07_ADUANA_MEDIOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir07AduanaMedio
    {
        [Required]
        [Display(Name = "N ID adu med 07")]
        public int NIdAduMed07 { get; set; } // nIdAduMed07 (Primary key)

        [Required]
        [Display(Name = "N ID medio trans 05")]
        public int NIdMedioTrans05 { get; set; } // nIdMedioTrans05

        [Display(Name = "N tipo prioridad")]
        public byte? NTipoPrioridad { get; set; } // nTipoPrioridad

        [Required]
        [Display(Name = "N ID adu sec 06")]
        public int NIdAduSec06 { get; set; } // nIdAduSec06

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Required]
        [Display(Name = "N tipo operacion")]
        public byte NTipoOperacion { get; set; } // nTipoOperacion

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_07_ADUANA_MEDIOS].([NIdUsuarioEd]) (FK_SIR_07_ADUANA_MEDIOS_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_07_ADUANA_MEDIOS_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir05MediosTransporte pointed by [SIR_07_ADUANA_MEDIOS].([NIdMedioTrans05]) (FK_SIR_07_ADUANA_MEDIOS_SIR_05_MEDIOS_TRANSPORTE)
        /// </summary>
        public virtual SIR_Sir05MediosTransporte SIR_Sir05MediosTransporte { get; set; } // FK_SIR_07_ADUANA_MEDIOS_SIR_05_MEDIOS_TRANSPORTE

        /// <summary>
        /// Parent SIR_Sir06AduanaSec pointed by [SIR_07_ADUANA_MEDIOS].([NIdAduSec06]) (FK_SIR_07_ADUANA_MEDIOS_SIR_06_ADUANA_SEC)
        /// </summary>
        public virtual SIR_Sir06AduanaSec SIR_Sir06AduanaSec { get; set; } // FK_SIR_07_ADUANA_MEDIOS_SIR_06_ADUANA_SEC

        public SIR_Sir07AduanaMedio()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            NTipoOperacion = 1;
        }
    }

}
// </auto-generated>