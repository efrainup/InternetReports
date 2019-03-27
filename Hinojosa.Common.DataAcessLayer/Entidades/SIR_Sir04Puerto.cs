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

    // SIR_04_PUERTOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir04Puerto
    {
        [Required]
        [Display(Name = "N ID puerto 04")]
        public int NIdPuerto04 { get; set; } // nIdPuerto04 (Primary key)

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S nombre")]
        public string SNombre { get; set; } // sNombre (length: 50)

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S nombre corto")]
        public string SNombreCorto { get; set; } // sNombreCorto (length: 20)

        [Display(Name = "N ID pais 01")]
        public int? NIdPais01 { get; set; } // nIdPais01

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

        [Required]
        [Display(Name = "N registro")]
        public int NRegistro { get; set; } // nRegistro

        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "S clave")]
        public string SClave { get; set; } // sClave (length: 3)

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir206Remesa where [SIR_206_REMESAS].[nIdPuerto04] point to this entity (FK_SIR_206_REMESAS_SIR_04_PUERTOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir206Remesa> SIR_Sir206Remesa { get; set; } // SIR_206_REMESAS.FK_SIR_206_REMESAS_SIR_04_PUERTOS
        /// <summary>
        /// Child SIR_Sir307RefComplementaria where [SIR_307_REF_COMPLEMENTARIAS].[nIdPuertoDestino04] point to this entity (FK_SIR_307_REF_COMPLEMENTARIAS_SIR_04_PUERTOS_DESTINO)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir307RefComplementaria> SIR_Sir307RefComplementaria_NIdPuertoDestino04 { get; set; } // SIR_307_REF_COMPLEMENTARIAS.FK_SIR_307_REF_COMPLEMENTARIAS_SIR_04_PUERTOS_DESTINO
        /// <summary>
        /// Child SIR_Sir307RefComplementaria where [SIR_307_REF_COMPLEMENTARIAS].[nIdPuertoOrigen04] point to this entity (FK_SIR_307_REF_COMPLEMENTARIAS_SIR_04_PUERTOS_ORIGEN)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir307RefComplementaria> SIR_Sir307RefComplementaria_NIdPuertoOrigen04 { get; set; } // SIR_307_REF_COMPLEMENTARIAS.FK_SIR_307_REF_COMPLEMENTARIAS_SIR_04_PUERTOS_ORIGEN
        /// <summary>
        /// Child SIR_Sir370LiberacionElectronicaGuia where [SIR_370_LIBERACION_ELECTRONICA_GUIAS].[nIdPuertoCarga04] point to this entity (FK_SIR_370_LIB_ELECTRONICA_GUIAS_SIR_04_PUERTOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir370LiberacionElectronicaGuia> SIR_Sir370LiberacionElectronicaGuia_NIdPuertoCarga04 { get; set; } // SIR_370_LIBERACION_ELECTRONICA_GUIAS.FK_SIR_370_LIB_ELECTRONICA_GUIAS_SIR_04_PUERTOS
        /// <summary>
        /// Child SIR_Sir370LiberacionElectronicaGuia where [SIR_370_LIBERACION_ELECTRONICA_GUIAS].[nIdPuertoOrigen04] point to this entity (FK_SIR_370_LIB_ELECTRONICA_GUIAS_SIR_04_PUERTOS_ORIGEN)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir370LiberacionElectronicaGuia> SIR_Sir370LiberacionElectronicaGuia_NIdPuertoOrigen04 { get; set; } // SIR_370_LIBERACION_ELECTRONICA_GUIAS.FK_SIR_370_LIB_ELECTRONICA_GUIAS_SIR_04_PUERTOS_ORIGEN
        /// <summary>
        /// Child SIR_Sir60Referencia where [SIR_60_REFERENCIAS].[nIdPuertoDestino04] point to this entity (FK_SIR_60_REFERENCIAS_SIR_04_PUERTOS_DESTINO)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir60Referencia> SIR_Sir60Referencia_NIdPuertoDestino04 { get; set; } // SIR_60_REFERENCIAS.FK_SIR_60_REFERENCIAS_SIR_04_PUERTOS_DESTINO
        /// <summary>
        /// Child SIR_Sir60Referencia where [SIR_60_REFERENCIAS].[nIdPuertoOrigen] point to this entity (FK_SIR_60_REFERENCIAS_SIR_04_PUERTOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir60Referencia> SIR_Sir60Referencia_NIdPuertoOrigen { get; set; } // SIR_60_REFERENCIAS.FK_SIR_60_REFERENCIAS_SIR_04_PUERTOS
        /// <summary>
        /// Child SIR_Sir60Referencia where [SIR_60_REFERENCIAS].[nIdPuertoOrigen04] point to this entity (FK_SIR_60_REFERENCIAS_SIR_04_PUERTOS_ORIGEN)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir60Referencia> SIR_Sir60Referencia_NIdPuertoOrigen04 { get; set; } // SIR_60_REFERENCIAS.FK_SIR_60_REFERENCIAS_SIR_04_PUERTOS_ORIGEN
        /// <summary>
        /// Child SIRAdmin_Sira51BookingContenedor where [SIRA_51_BOOKING_CONTENEDOR].[nIdPuertoSalida04] point to this entity (FK_SIRA_51_BOOKING_CONTENEDOR_SIR_04_PUERTOS)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira51BookingContenedor> SIRAdmin_Sira51BookingContenedor { get; set; } // SIRA_51_BOOKING_CONTENEDOR.FK_SIRA_51_BOOKING_CONTENEDOR_SIR_04_PUERTOS

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_04_PUERTOS].([NIdUsuarioEd]) (FK_SIR_04_PUERTOS_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_04_PUERTOS_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir01Pais pointed by [SIR_04_PUERTOS].([NIdPais01]) (FK_SIR_04_PUERTOS_SIR_01_PAISES)
        /// </summary>
        public virtual SIR_Sir01Pais SIR_Sir01Pais { get; set; } // FK_SIR_04_PUERTOS_SIR_01_PAISES

        public SIR_Sir04Puerto()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            NStatusVig = 1;
            SIR_Sir206Remesa = new System.Collections.Generic.List<SIR_Sir206Remesa>();
            SIR_Sir307RefComplementaria_NIdPuertoDestino04 = new System.Collections.Generic.List<SIR_Sir307RefComplementaria>();
            SIR_Sir307RefComplementaria_NIdPuertoOrigen04 = new System.Collections.Generic.List<SIR_Sir307RefComplementaria>();
            SIR_Sir370LiberacionElectronicaGuia_NIdPuertoCarga04 = new System.Collections.Generic.List<SIR_Sir370LiberacionElectronicaGuia>();
            SIR_Sir370LiberacionElectronicaGuia_NIdPuertoOrigen04 = new System.Collections.Generic.List<SIR_Sir370LiberacionElectronicaGuia>();
            SIR_Sir60Referencia_NIdPuertoDestino04 = new System.Collections.Generic.List<SIR_Sir60Referencia>();
            SIR_Sir60Referencia_NIdPuertoOrigen = new System.Collections.Generic.List<SIR_Sir60Referencia>();
            SIR_Sir60Referencia_NIdPuertoOrigen04 = new System.Collections.Generic.List<SIR_Sir60Referencia>();
            SIRAdmin_Sira51BookingContenedor = new System.Collections.Generic.List<SIRAdmin_Sira51BookingContenedor>();
        }
    }

}
// </auto-generated>