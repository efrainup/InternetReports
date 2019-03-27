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

    // SIR_163_PROG_PREVIOS_OBS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir163ProgPreviosOb
    {
        [Required]
        [Display(Name = "N ID prev obs 163")]
        public int NIdPrevObs163 { get; set; } // nIdPrevObs163 (Primary key)

        [Required]
        [Display(Name = "N ID prev ref 161")]
        public int NIdPrevRef161 { get; set; } // nIdPrevRef161

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S observacion")]
        public string SObservacion { get; set; } // sObservacion (length: 500)

        [Display(Name = "N ID usuario")]
        public int? NIdUsuario { get; set; } // nIdUsuario

        [Display(Name = "D alta")]
        public System.DateTime? DAlta { get; set; } // dAlta

        [Display(Name = "N ID usuario 01")]
        public int? NIdUsuario01 { get; set; } // nIdUsuario01

        // Foreign keys

        /// <summary>
        /// Parent Admin_Admina01Usuario pointed by [SIR_163_PROG_PREVIOS_OBS].([NIdUsuario01]) (FK_SIR_163_PROG_PREVIOS_OBS_ADMINA_01_USUARIOS)
        /// </summary>
        public virtual Admin_Admina01Usuario Admin_Admina01Usuario { get; set; } // FK_SIR_163_PROG_PREVIOS_OBS_ADMINA_01_USUARIOS

        /// <summary>
        /// Parent CatUsr pointed by [SIR_163_PROG_PREVIOS_OBS].([NIdUsuario]) (FK_SIR_163_PROG_PREVIOS_OBS_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_163_PROG_PREVIOS_OBS_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir161ProgPreviosRef pointed by [SIR_163_PROG_PREVIOS_OBS].([NIdPrevRef161]) (FK_SIR_163_PROG_PREVIOS_OBS_SIR_161_PROG_PREVIOS_REF)
        /// </summary>
        public virtual SIR_Sir161ProgPreviosRef SIR_Sir161ProgPreviosRef { get; set; } // FK_SIR_163_PROG_PREVIOS_OBS_SIR_161_PROG_PREVIOS_REF
    }

}
// </auto-generated>
