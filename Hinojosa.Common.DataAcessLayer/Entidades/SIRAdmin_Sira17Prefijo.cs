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

    // SIRA_17_PREFIJOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira17Prefijo
    {
        [Required]
        [Display(Name = "N ID pre 17")]
        public int NIdPre17 { get; set; } // nIdPre17 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "S clave")]
        public string SClave { get; set; } // sClave (length: 3)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 50)

        [Required]
        [Display(Name = "N tipo")]
        public byte NTipo { get; set; } // nTipo

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Required]
        [Display(Name = "N status vig")]
        public byte NStatusVig { get; set; } // nStatusVig

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir06AduanaSec where [SIR_06_ADUANA_SEC].[nIdPre17] point to this entity (FK_SIR_06_ADUANA_SEC_SIRA_17_PREFIJOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir06AduanaSec> SIR_Sir06AduanaSec { get; set; } // SIR_06_ADUANA_SEC.FK_SIR_06_ADUANA_SEC_SIRA_17_PREFIJOS

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIRA_17_PREFIJOS].([NIdUsuarioEd]) (FK_SIRA_17_PREFIJOS_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIRA_17_PREFIJOS_cat_usr_ed

        public SIRAdmin_Sira17Prefijo()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            NStatusVig = 1;
            SIR_Sir06AduanaSec = new System.Collections.Generic.List<SIR_Sir06AduanaSec>();
        }
    }

}
// </auto-generated>