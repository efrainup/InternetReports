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

    // SIR_157_NAVES_BODEGA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir157NavesBodega
    {
        [Required(AllowEmptyStrings = true)]
        [MaxLength(120)]
        [StringLength(120)]
        [Display(Name = "S nombre")]
        public string SNombre { get; set; } // sNombre (length: 120)

        [Required]
        [Display(Name = "N ID almacen")]
        public int NIdAlmacen { get; set; } // nIdAlmacen

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Required]
        [Display(Name = "N ID nave 157")]
        public int NIdNave157 { get; set; } // nIdNave157 (Primary key)

        [Display(Name = "B es patio")]
        public bool? BEsPatio { get; set; } // bEsPatio

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir158SeccionesNave where [SIR_158_SECCIONES_NAVES].[nIdNave157] point to this entity (FK_SIR_158_SECCIONES_NAVES_SIR_157_NAVES_BODEGA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir158SeccionesNave> SIR_Sir158SeccionesNave { get; set; } // SIR_158_SECCIONES_NAVES.FK_SIR_158_SECCIONES_NAVES_SIR_157_NAVES_BODEGA

        // Foreign keys

        /// <summary>
        /// Parent CatAlmac pointed by [SIR_157_NAVES_BODEGA].([NIdAlmacen]) (FK_SIR_157_NAVES_BODEGA_cat_almac)
        /// </summary>
        public virtual CatAlmac CatAlmac { get; set; } // FK_SIR_157_NAVES_BODEGA_cat_almac

        /// <summary>
        /// Parent CatUsr pointed by [SIR_157_NAVES_BODEGA].([NIdUsuarioEd]) (FK_SIR_157_NAVES_BODEGA_cat_usr)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_157_NAVES_BODEGA_cat_usr

        public SIR_Sir157NavesBodega()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            SIR_Sir158SeccionesNave = new System.Collections.Generic.List<SIR_Sir158SeccionesNave>();
        }
    }

}
// </auto-generated>
