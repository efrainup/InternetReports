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

    // SIR_643_CARACTERISTICAS_SERVICIOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir643CaracteristicasServicio
    {
        [Required]
        [Display(Name = "N ID caract servicio 643")]
        public int NIdCaractServicio643 { get; set; } // nIdCaractServicio643 (Primary key)

        [Required]
        [Display(Name = "N ID catalogo servicio 642")]
        public int NIdCatalogoServicio642 { get; set; } // nIdCatalogoServicio642

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S nombre")]
        public string SNombre { get; set; } // sNombre (length: 50)

        [Required]
        [Display(Name = "N tipo de dato")]
        public byte NTipoDeDato { get; set; } // nTipoDeDato

        [Required]
        [Display(Name = "N longitud")]
        public int NLongitud { get; set; } // nLongitud

        [Required]
        [Display(Name = "B activo")]
        public bool BActivo { get; set; } // bActivo

        [Display(Name = "B requerido")]
        public bool? BRequerido { get; set; } // bRequerido

        [Display(Name = "N ID umax 655")]
        public int? NIdUmax655 { get; set; } // nIdUMAX655

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S campo ax")]
        public string SCampoAx { get; set; } // sCampoAx (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir647DatosServicio where [SIR_647_DATOS_SERVICIOS].[nIdCaractServicio643] point to this entity ([FK_SIR_647_DATOS_SERVICIOS_SIR_643_CARACTERISTICAS_SERVICIOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir647DatosServicio> SIR_Sir647DatosServicio { get; set; } // SIR_647_DATOS_SERVICIOS.[FK_SIR_647_DATOS_SERVICIOS_SIR_643_CARACTERISTICAS_SERVICIOS

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir642CatalogoServicio pointed by [SIR_643_CARACTERISTICAS_SERVICIOS].([NIdCatalogoServicio642]) ([FK_SIR_643_CARACTERISTICAS_SERVICIOS_SIR_642_CATALOGO_SERVICIOS)
        /// </summary>
        public virtual SIR_Sir642CatalogoServicio SIR_Sir642CatalogoServicio { get; set; } // [FK_SIR_643_CARACTERISTICAS_SERVICIOS_SIR_642_CATALOGO_SERVICIOS

        /// <summary>
        /// Parent SIR_Sir655UnidadesMedidaAx pointed by [SIR_643_CARACTERISTICAS_SERVICIOS].([NIdUmax655]) (FK_SIR_643_CARACTERISTICAS_SERVICIOS_SIR_655_UNIDADES_MEDIDA_AX)
        /// </summary>
        public virtual SIR_Sir655UnidadesMedidaAx SIR_Sir655UnidadesMedidaAx { get; set; } // FK_SIR_643_CARACTERISTICAS_SERVICIOS_SIR_655_UNIDADES_MEDIDA_AX

        public SIR_Sir643CaracteristicasServicio()
        {
            SIR_Sir647DatosServicio = new System.Collections.Generic.List<SIR_Sir647DatosServicio>();
        }
    }

}
// </auto-generated>
