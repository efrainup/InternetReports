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

    // SIR_222_OISA_BASE
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir222OisaBase
    {
        [Required]
        [Display(Name = "N ID oisab 222")]
        public int NIdOisab222 { get; set; } // nIdOISAB222 (Primary key)

        [Display(Name = "N clave")]
        public int? NClave { get; set; } // nClave

        [Required(AllowEmptyStrings = true)]
        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "S nombre")]
        public string SNombre { get; set; } // sNombre (length: 60)

        [Required]
        [Display(Name = "N clasificacion")]
        public byte NClasificacion { get; set; } // nClasificacion

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir228RegistrosSagarpa where [SIR_228_REGISTROS_SAGARPA].[nIdOISABE222] point to this entity (FK_SIR_228_REGISTROS_SAGARPA_SIR_222_OISA_BASE)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir228RegistrosSagarpa> SIR_Sir228RegistrosSagarpa { get; set; } // SIR_228_REGISTROS_SAGARPA.FK_SIR_228_REGISTROS_SAGARPA_SIR_222_OISA_BASE

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_222_OISA_BASE].([NIdUsuarioEd]) (FK_SIR_222_OISA_BASE_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_222_OISA_BASE_cat_usr_ed

        public SIR_Sir222OisaBase()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            SIR_Sir228RegistrosSagarpa = new System.Collections.Generic.List<SIR_Sir228RegistrosSagarpa>();
        }
    }

}
// </auto-generated>
