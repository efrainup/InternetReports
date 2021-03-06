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

    // SIR_02_LABORATORIOS_SAGAR
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir02LaboratoriosSagar
    {
        [Required]
        [Display(Name = "N ID lab sagar 02")]
        public int NIdLabSagar02 { get; set; } // nIdLabSagar02 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "S clave")]
        public string SClave { get; set; } // sClave (length: 2)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "S nombre")]
        public string SNombre { get; set; } // sNombre (length: 80)

        [Required]
        [Display(Name = "N tipo")]
        public short NTipo { get; set; } // nTipo

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir232MuestrasSagarpa where [SIR_232_MUESTRAS_SAGARPA].[nIdLabSagar02] point to this entity (FK_SIR_232_MUESTRAS_SAGARPA_SIR_02_LABORATORIOS_SAGAR)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir232MuestrasSagarpa> SIR_Sir232MuestrasSagarpa { get; set; } // SIR_232_MUESTRAS_SAGARPA.FK_SIR_232_MUESTRAS_SAGARPA_SIR_02_LABORATORIOS_SAGAR

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_02_LABORATORIOS_SAGAR].([NIdUsuarioEd]) (FK_SIR_02_LABORATORIOS_SAGAR_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_02_LABORATORIOS_SAGAR_cat_usr_ed

        public SIR_Sir02LaboratoriosSagar()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            SIR_Sir232MuestrasSagarpa = new System.Collections.Generic.List<SIR_Sir232MuestrasSagarpa>();
        }
    }

}
// </auto-generated>
