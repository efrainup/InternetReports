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

    // SIR_160_PROG_PREVIOS_CONT
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir160ProgPreviosCont
    {
        [Required]
        [Display(Name = "N ID prev cont 160")]
        public int NIdPrevCont160 { get; set; } // nIdPrevCont160 (Primary key)

        [Required]
        [Display(Name = "N ID contenedor 76")]
        public int NIdContenedor76 { get; set; } // nIdContenedor76

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Display(Name = "N ID prev ref 161")]
        public int? NIdPrevRef161 { get; set; } // nIdPrevRef161

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_160_PROG_PREVIOS_CONT].([NIdUsuarioEd]) (FK_SIR_160_PROG_PREVIOS_CONT_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_160_PROG_PREVIOS_CONT_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir161ProgPreviosRef pointed by [SIR_160_PROG_PREVIOS_CONT].([NIdPrevRef161]) (FK_SIR_160_PROG_PREVIOS_CONT_SIR_161_PROG_PREVIOS_REF)
        /// </summary>
        public virtual SIR_Sir161ProgPreviosRef SIR_Sir161ProgPreviosRef { get; set; } // FK_SIR_160_PROG_PREVIOS_CONT_SIR_161_PROG_PREVIOS_REF

        /// <summary>
        /// Parent SIR_Sir76Contenedore pointed by [SIR_160_PROG_PREVIOS_CONT].([NIdContenedor76]) (FK_SIR_160_PROG_PREVIOS_CONT_SIR_76_CONTENEDORES)
        /// </summary>
        public virtual SIR_Sir76Contenedore SIR_Sir76Contenedore { get; set; } // FK_SIR_160_PROG_PREVIOS_CONT_SIR_76_CONTENEDORES

        public SIR_Sir160ProgPreviosCont()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
        }
    }

}
// </auto-generated>