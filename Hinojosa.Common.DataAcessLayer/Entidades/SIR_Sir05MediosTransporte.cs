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

    // SIR_05_MEDIOS_TRANSPORTE
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir05MediosTransporte
    {
        [Required]
        [Display(Name = "N ID medio trans 05")]
        public int NIdMedioTrans05 { get; set; } // nIdMedioTrans05 (Primary key)

        [Required]
        [Display(Name = "N clave")]
        public byte NClave { get; set; } // nClave

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 100)

        [Display(Name = "N ID tipo trafico 25")]
        public int? NIdTipoTrafico25 { get; set; } // nIdTipoTrafico25

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

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir07AduanaMedio where [SIR_07_ADUANA_MEDIOS].[nIdMedioTrans05] point to this entity (FK_SIR_07_ADUANA_MEDIOS_SIR_05_MEDIOS_TRANSPORTE)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir07AduanaMedio> SIR_Sir07AduanaMedio { get; set; } // SIR_07_ADUANA_MEDIOS.FK_SIR_07_ADUANA_MEDIOS_SIR_05_MEDIOS_TRANSPORTE
        /// <summary>
        /// Child SIR_Sir149Pedimento where [SIR_149_PEDIMENTO].[nIdMedioArribo] point to this entity (FK_SIR_149_PEDIMENTO_SIR_05_MEDIOS_TRANSPORTE)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir149Pedimento> SIR_Sir149Pedimento_NIdMedioArribo { get; set; } // SIR_149_PEDIMENTO.FK_SIR_149_PEDIMENTO_SIR_05_MEDIOS_TRANSPORTE
        /// <summary>
        /// Child SIR_Sir149Pedimento where [SIR_149_PEDIMENTO].[nIdMedioSalida] point to this entity (FK_SIR_149_PEDIMENTO_SIR_05_MEDIOS_TRANSPORTE1)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir149Pedimento> SIR_Sir149Pedimento_NIdMedioSalida { get; set; } // SIR_149_PEDIMENTO.FK_SIR_149_PEDIMENTO_SIR_05_MEDIOS_TRANSPORTE1
        /// <summary>
        /// Child SIR_Sir149Pedimento where [SIR_149_PEDIMENTO].[nIdMedioTrans05] point to this entity (FK_SIR_149_PEDIMENTO_SIR_05_MEDIOS_TRANSPORTE2)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir149Pedimento> SIR_Sir149Pedimento_NIdMedioTrans05 { get; set; } // SIR_149_PEDIMENTO.FK_SIR_149_PEDIMENTO_SIR_05_MEDIOS_TRANSPORTE2
        /// <summary>
        /// Child SIR_Sir156EntradasBodega where [SIR_156_ENTRADAS_BODEGAS].[nIdMedioTrans05] point to this entity (FK_SIR_156_ENTRADAS_BODEGAS_SIR_05_MEDIOS_TRANSPORTE)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir156EntradasBodega> SIR_Sir156EntradasBodega { get; set; } // SIR_156_ENTRADAS_BODEGAS.FK_SIR_156_ENTRADAS_BODEGAS_SIR_05_MEDIOS_TRANSPORTE
        /// <summary>
        /// Child SIR_Sir228RegistrosSagarpa where [SIR_228_REGISTROS_SAGARPA].[nIdMedioTrans05] point to this entity (FK_SIR_228_REGISTROS_SAGARPA_SIR_05_MEDIOS_TRANSPORTE)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir228RegistrosSagarpa> SIR_Sir228RegistrosSagarpa { get; set; } // SIR_228_REGISTROS_SAGARPA.FK_SIR_228_REGISTROS_SAGARPA_SIR_05_MEDIOS_TRANSPORTE
        /// <summary>
        /// Child SIR_Sir273Profepa where [SIR_273_PROFEPA].[nIdMedioTrans05] point to this entity (FK_SIR_273_PROFEPA_SIR_05_MEDIOS_TRANSPORTE)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir273Profepa> SIR_Sir273Profepa { get; set; } // SIR_273_PROFEPA.FK_SIR_273_PROFEPA_SIR_05_MEDIOS_TRANSPORTE
        /// <summary>
        /// Child SIR_Sir41RegTransporte where [SIR_41_REG_TRANSPORTES].[nTipo] point to this entity (FK_SIR_41_REG_TRANSPORTES_SIR_05_MEDIOS_TRANSPORTE)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir41RegTransporte> SIR_Sir41RegTransporte { get; set; } // SIR_41_REG_TRANSPORTES.FK_SIR_41_REG_TRANSPORTES_SIR_05_MEDIOS_TRANSPORTE
        /// <summary>
        /// Child SIR_Sir711AvisoTransportista where [SIR_711_AVISO_TRANSPORTISTA].[nIdMedioTrans05] point to this entity (FK_SIR_711_AVISO_TRANSPORTISTA_SIR_05_MEDIOS_TRANSPORTE)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir711AvisoTransportista> SIR_Sir711AvisoTransportista { get; set; } // SIR_711_AVISO_TRANSPORTISTA.FK_SIR_711_AVISO_TRANSPORTISTA_SIR_05_MEDIOS_TRANSPORTE
        /// <summary>
        /// Child SIR_Sir76Contenedore where [SIR_76_CONTENEDORES].[nIdMedioSalida05] point to this entity (FK_SIR_76_CONTENEDORES_SIR_05_MEDIOS_TRANSPORTE)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir76Contenedore> SIR_Sir76Contenedore { get; set; } // SIR_76_CONTENEDORES.FK_SIR_76_CONTENEDORES_SIR_05_MEDIOS_TRANSPORTE

        // Foreign keys

        /// <summary>
        /// Parent SIR_Sir25TiposTrafico pointed by [SIR_05_MEDIOS_TRANSPORTE].([NIdTipoTrafico25]) (FK_SIR_05_MEDIOS_TRANSPORTE_SIR_25_TIPOS_TRAFICO)
        /// </summary>
        public virtual SIR_Sir25TiposTrafico SIR_Sir25TiposTrafico { get; set; } // FK_SIR_05_MEDIOS_TRANSPORTE_SIR_25_TIPOS_TRAFICO

        public SIR_Sir05MediosTransporte()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            NStatusVig = 1;
            SIR_Sir07AduanaMedio = new System.Collections.Generic.List<SIR_Sir07AduanaMedio>();
            SIR_Sir149Pedimento_NIdMedioArribo = new System.Collections.Generic.List<SIR_Sir149Pedimento>();
            SIR_Sir149Pedimento_NIdMedioSalida = new System.Collections.Generic.List<SIR_Sir149Pedimento>();
            SIR_Sir149Pedimento_NIdMedioTrans05 = new System.Collections.Generic.List<SIR_Sir149Pedimento>();
            SIR_Sir156EntradasBodega = new System.Collections.Generic.List<SIR_Sir156EntradasBodega>();
            SIR_Sir228RegistrosSagarpa = new System.Collections.Generic.List<SIR_Sir228RegistrosSagarpa>();
            SIR_Sir273Profepa = new System.Collections.Generic.List<SIR_Sir273Profepa>();
            SIR_Sir41RegTransporte = new System.Collections.Generic.List<SIR_Sir41RegTransporte>();
            SIR_Sir711AvisoTransportista = new System.Collections.Generic.List<SIR_Sir711AvisoTransportista>();
            SIR_Sir76Contenedore = new System.Collections.Generic.List<SIR_Sir76Contenedore>();
        }
    }

}
// </auto-generated>