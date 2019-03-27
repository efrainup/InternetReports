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

    // SIR_96_PARQUE_VEHICULAR
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir96ParqueVehicular
    {
        [Required]
        [Display(Name = "N ID veh 96")]
        public int NIdVeh96 { get; set; } // nIdVeh96 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S num serie")]
        public string SNumSerie { get; set; } // sNumSerie (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S num economico")]
        public string SNumEconomico { get; set; } // sNumEconomico (length: 100)

        [Required]
        [Display(Name = "N ID tip veh 108")]
        public int NIdTipVeh108 { get; set; } // nIdTipVeh108

        [Required]
        [Display(Name = "N ID marca 109")]
        public int NIdMarca109 { get; set; } // nIdMarca109

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S modelo")]
        public string SModelo { get; set; } // sModelo (length: 50)

        [Required]
        [Display(Name = "N anio")]
        public short NAnio { get; set; } // nAnio

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S placas")]
        public string SPlacas { get; set; } // sPlacas (length: 20)

        [Required]
        [MaxLength(50)]
        [Display(Name = "S num motor")]
        public byte[] SNumMotor { get; set; } // sNumMotor (length: 50)

        [Required]
        [Display(Name = "N peso")]
        public decimal NPeso { get; set; } // nPeso

        [Required]
        [Display(Name = "N num ejes")]
        public byte NNumEjes { get; set; } // nNumEjes

        [Display(Name = "N alto")]
        public decimal? NAlto { get; set; } // nAlto

        [Display(Name = "N ancho")]
        public decimal? NAncho { get; set; } // nAncho

        [Display(Name = "N largo")]
        public decimal? NLargo { get; set; } // nLargo

        [Display(Name = "N carga")]
        public decimal? NCarga { get; set; } // nCarga

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S ruta foto")]
        public string SRutaFoto { get; set; } // sRutaFoto (length: 500)

        [Display(Name = "N volumen")]
        public decimal? NVolumen { get; set; } // nVolumen

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_96_PARQUE_VEHICULAR].([NIdUsuarioEd]) (FK_SIR_96_PADRON_VEHICULAR_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_96_PADRON_VEHICULAR_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir108TiposVehiculo pointed by [SIR_96_PARQUE_VEHICULAR].([NIdTipVeh108]) (FK_SIR_96_PADRON_VEHICULAR_SIR_108_TIPOS_VEHICULOS)
        /// </summary>
        public virtual SIR_Sir108TiposVehiculo SIR_Sir108TiposVehiculo { get; set; } // FK_SIR_96_PADRON_VEHICULAR_SIR_108_TIPOS_VEHICULOS

        /// <summary>
        /// Parent SIR_Sir109MarcasVehiculo pointed by [SIR_96_PARQUE_VEHICULAR].([NIdMarca109]) (FK_SIR_96_PADRON_VEHICULAR_SIR_109_MARCAS_VEHICULOS)
        /// </summary>
        public virtual SIR_Sir109MarcasVehiculo SIR_Sir109MarcasVehiculo { get; set; } // FK_SIR_96_PADRON_VEHICULAR_SIR_109_MARCAS_VEHICULOS

        public SIR_Sir96ParqueVehicular()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
        }
    }

}
// </auto-generated>