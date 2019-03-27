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

    // SIR_224_CORDONES_CLASIF
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir224CordonesClasif
    {
        [Required]
        [Display(Name = "N ID cord clasif 224")]
        public int NIdCordClasif224 { get; set; } // nIdCordClasif224 (Primary key)

        [Required]
        [Display(Name = "N clave")]
        public int NClave { get; set; } // nClave

        [Required(AllowEmptyStrings = true)]
        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "S punto verif")]
        public string SPuntoVerif { get; set; } // sPuntoVerif (length: 60)

        [Required]
        [Display(Name = "N ID cordon 223")]
        public int NIdCordon223 { get; set; } // nIdCordon223

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir228RegistrosSagarpa where [SIR_228_REGISTROS_SAGARPA].[nCordonCentro] point to this entity (FK_SIR_228_REGISTROS_SAGARPA_SIR_224_CORDONES_CLASIF_centro)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir228RegistrosSagarpa> SIR_Sir228RegistrosSagarpa_NCordonCentro { get; set; } // SIR_228_REGISTROS_SAGARPA.FK_SIR_228_REGISTROS_SAGARPA_SIR_224_CORDONES_CLASIF_centro
        /// <summary>
        /// Child SIR_Sir228RegistrosSagarpa where [SIR_228_REGISTROS_SAGARPA].[nCordonIstmo] point to this entity (FK_SIR_228_REGISTROS_SAGARPA_SIR_224_CORDONES_CLASIF_istmo)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir228RegistrosSagarpa> SIR_Sir228RegistrosSagarpa_NCordonIstmo { get; set; } // SIR_228_REGISTROS_SAGARPA.FK_SIR_228_REGISTROS_SAGARPA_SIR_224_CORDONES_CLASIF_istmo
        /// <summary>
        /// Child SIR_Sir228RegistrosSagarpa where [SIR_228_REGISTROS_SAGARPA].[nCordonNorte] point to this entity (FK_SIR_228_REGISTROS_SAGARPA_SIR_224_CORDONES_CLASIF_norte)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir228RegistrosSagarpa> SIR_Sir228RegistrosSagarpa_NCordonNorte { get; set; } // SIR_228_REGISTROS_SAGARPA.FK_SIR_228_REGISTROS_SAGARPA_SIR_224_CORDONES_CLASIF_norte
        /// <summary>
        /// Child SIR_Sir228RegistrosSagarpa where [SIR_228_REGISTROS_SAGARPA].[nCordonPeninsular] point to this entity (FK_SIR_228_REGISTROS_SAGARPA_SIR_224_CORDONES_CLASIF_pen)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir228RegistrosSagarpa> SIR_Sir228RegistrosSagarpa_NCordonPeninsular { get; set; } // SIR_228_REGISTROS_SAGARPA.FK_SIR_228_REGISTROS_SAGARPA_SIR_224_CORDONES_CLASIF_pen
        /// <summary>
        /// Child SIR_Sir228RegistrosSagarpa where [SIR_228_REGISTROS_SAGARPA].[nCordonSur] point to this entity (FK_SIR_228_REGISTROS_SAGARPA_SIR_224_CORDONES_CLASIF_sur)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir228RegistrosSagarpa> SIR_Sir228RegistrosSagarpa_NCordonSur { get; set; } // SIR_228_REGISTROS_SAGARPA.FK_SIR_228_REGISTROS_SAGARPA_SIR_224_CORDONES_CLASIF_sur

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_224_CORDONES_CLASIF].([NIdUsuarioEd]) (FK_SIR_224_CORDONES_CLASIF_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_224_CORDONES_CLASIF_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir223CordonesCarretero pointed by [SIR_224_CORDONES_CLASIF].([NIdCordon223]) (FK_SIR_224_CORDONES_CLASIF_SIR_223_CORDONES_CARRETEROS)
        /// </summary>
        public virtual SIR_Sir223CordonesCarretero SIR_Sir223CordonesCarretero { get; set; } // FK_SIR_224_CORDONES_CLASIF_SIR_223_CORDONES_CARRETEROS

        public SIR_Sir224CordonesClasif()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            SIR_Sir228RegistrosSagarpa_NCordonCentro = new System.Collections.Generic.List<SIR_Sir228RegistrosSagarpa>();
            SIR_Sir228RegistrosSagarpa_NCordonIstmo = new System.Collections.Generic.List<SIR_Sir228RegistrosSagarpa>();
            SIR_Sir228RegistrosSagarpa_NCordonNorte = new System.Collections.Generic.List<SIR_Sir228RegistrosSagarpa>();
            SIR_Sir228RegistrosSagarpa_NCordonPeninsular = new System.Collections.Generic.List<SIR_Sir228RegistrosSagarpa>();
            SIR_Sir228RegistrosSagarpa_NCordonSur = new System.Collections.Generic.List<SIR_Sir228RegistrosSagarpa>();
        }
    }

}
// </auto-generated>