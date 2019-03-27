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

    // SIR_162_PROG_PREVIOS_CS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir162ProgPreviosC
    {
        [Required]
        [Display(Name = "N ID prev cs 162")]
        public int NIdPrevCs162 { get; set; } // nIdPrevCS162 (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Display(Name = "N ID prev ref 161")]
        public int? NIdPrevRef161 { get; set; } // nIdPrevRef161

        [Required]
        [Display(Name = "N ID carga det 135")]
        public int NIdCargaDet135 { get; set; } // nIdCargaDet135

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_162_PROG_PREVIOS_CS].([NIdUsuarioEd]) (FK_SIR_162_PROG_PREVIOS_CS_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_162_PROG_PREVIOS_CS_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir135CargaSueltaDetalle pointed by [SIR_162_PROG_PREVIOS_CS].([NIdCargaDet135]) (FK_SIR_162_PROG_PREVIOS_CS_SIR_135_CARGA_SUELTA_DETALLE)
        /// </summary>
        public virtual SIR_Sir135CargaSueltaDetalle SIR_Sir135CargaSueltaDetalle { get; set; } // FK_SIR_162_PROG_PREVIOS_CS_SIR_135_CARGA_SUELTA_DETALLE

        /// <summary>
        /// Parent SIR_Sir161ProgPreviosRef pointed by [SIR_162_PROG_PREVIOS_CS].([NIdPrevRef161]) (FK_SIR_162_PROG_PREVIOS_CS_SIR_161_PROG_PREVIOS_REF)
        /// </summary>
        public virtual SIR_Sir161ProgPreviosRef SIR_Sir161ProgPreviosRef { get; set; } // FK_SIR_162_PROG_PREVIOS_CS_SIR_161_PROG_PREVIOS_REF

        public SIR_Sir162ProgPreviosC()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
        }
    }

}
// </auto-generated>
