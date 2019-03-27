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

    // SIR_101_METODOS_VALORACION
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir101MetodosValoracion
    {
        [Required]
        [Display(Name = "N ID metodo val 101")]
        public int NIdMetodoVal101 { get; set; } // nIdMetodoVal101 (Primary key)

        [Required]
        [Display(Name = "N clave met val")]
        public byte NClaveMetVal { get; set; } // nClaveMetVal

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 100)

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
        /// Child SIR_Sir100FacPartAgrupada where [SIR_100_FAC_PART_AGRUPADAS].[nIdMetodoVal101] point to this entity (FK_SIR_100_FAC_PART_AGRUPADAS_SIR_101_METODOS_VALORACION)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir100FacPartAgrupada> SIR_Sir100FacPartAgrupada { get; set; } // SIR_100_FAC_PART_AGRUPADAS.FK_SIR_100_FAC_PART_AGRUPADAS_SIR_101_METODOS_VALORACION
        /// <summary>
        /// Child SIR_Sir11FacturasPartida where [SIR_11_FACTURAS_PARTIDAS].[nIdMetodoVal101] point to this entity (FK_SIR_11_FACTURAS_PARTIDAS_SIR_101_METODOS_VALORACION)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir11FacturasPartida> SIR_Sir11FacturasPartida { get; set; } // SIR_11_FACTURAS_PARTIDAS.FK_SIR_11_FACTURAS_PARTIDAS_SIR_101_METODOS_VALORACION
        /// <summary>
        /// Child SIR_Sir376ValorDeterminado where [SIR_376_VALOR_DETERMINADO].[nIdMetodoVal101] point to this entity (FK_SIR_376_VALOR_DETERMINADO_SIR_101_METODOS_VALORACION)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir376ValorDeterminado> SIR_Sir376ValorDeterminado { get; set; } // SIR_376_VALOR_DETERMINADO.FK_SIR_376_VALOR_DETERMINADO_SIR_101_METODOS_VALORACION
        /// <summary>
        /// Child SIR_Sir413HistoricoParte where [SIR_413_HISTORICO_PARTE].[nIdMetodoVal101] point to this entity (FK_SIR_413_HISTORICO_PARTE_SIR_101_METODOS_VALORACION)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir413HistoricoParte> SIR_Sir413HistoricoParte { get; set; } // SIR_413_HISTORICO_PARTE.FK_SIR_413_HISTORICO_PARTE_SIR_101_METODOS_VALORACION
        /// <summary>
        /// Child SIR_Sir577PartidasAvisoArribo where [SIR_577_PARTIDAS_AVISO_ARRIBO].[nIdMetodoVal101] point to this entity (FK_SIR_577_PARTIDAS_AVISO_ARRIBO_SIR_101_METODOS_VALORACION)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir577PartidasAvisoArribo> SIR_Sir577PartidasAvisoArribo { get; set; } // SIR_577_PARTIDAS_AVISO_ARRIBO.FK_SIR_577_PARTIDAS_AVISO_ARRIBO_SIR_101_METODOS_VALORACION
        /// <summary>
        /// Child SIR_Sir99Parte where [SIR_99_PARTES].[nIdMetodoVal101] point to this entity (FK_SIR_99_PARTES_SIR_101_METODOS_VALORACION)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir99Parte> SIR_Sir99Parte { get; set; } // SIR_99_PARTES.FK_SIR_99_PARTES_SIR_101_METODOS_VALORACION

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_101_METODOS_VALORACION].([NIdUsuarioEd]) (FK_SIR_101_METODOS_VALORACION_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_101_METODOS_VALORACION_cat_usr_ed

        public SIR_Sir101MetodosValoracion()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            NStatusVig = 1;
            SIR_Sir100FacPartAgrupada = new System.Collections.Generic.List<SIR_Sir100FacPartAgrupada>();
            SIR_Sir11FacturasPartida = new System.Collections.Generic.List<SIR_Sir11FacturasPartida>();
            SIR_Sir376ValorDeterminado = new System.Collections.Generic.List<SIR_Sir376ValorDeterminado>();
            SIR_Sir413HistoricoParte = new System.Collections.Generic.List<SIR_Sir413HistoricoParte>();
            SIR_Sir577PartidasAvisoArribo = new System.Collections.Generic.List<SIR_Sir577PartidasAvisoArribo>();
            SIR_Sir99Parte = new System.Collections.Generic.List<SIR_Sir99Parte>();
        }
    }

}
// </auto-generated>
