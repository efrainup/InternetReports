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

    // cfg_layout_bco_edo_cta
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CfgLayoutBcoEdoCta
    {
        [Required]
        [Display(Name = "Id cfg layout")]
        public int IdCfgLayout { get; set; } // id_cfg_layout (Primary key)

        [Required]
        [Display(Name = "Id layout")]
        public int IdLayout { get; set; } // id_layout

        [Required]
        [Display(Name = "Orden")]
        public byte Orden { get; set; } // orden

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (length: 50)

        [Required]
        [Display(Name = "Tipo")]
        public byte Tipo { get; set; } // tipo

        [Required]
        [Display(Name = "Longitud")]
        public byte Longitud { get; set; } // longitud

        [Required]
        [Display(Name = "Posicion ini")]
        public byte PosicionIni { get; set; } // posicion_ini

        [Required]
        [Display(Name = "Posicion fin")]
        public byte PosicionFin { get; set; } // posicion_fin

        [Required]
        [Display(Name = "Es fecha importe")]
        public byte EsFechaImporte { get; set; } // es_fecha_importe

        [Required(AllowEmptyStrings = true)]
        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "Valor fijo")]
        public string ValorFijo { get; set; } // valor_fijo (length: 15)

        [Required]
        [Display(Name = "Rellenar con")]
        public byte RellenarCon { get; set; } // rellenar_con

        [Required]
        [Display(Name = "Direccion relleno")]
        public byte DireccionRelleno { get; set; } // direccion_relleno

        [Required]
        [Display(Name = "Lleva punto")]
        public bool LlevaPunto { get; set; } // lleva_punto

        [Required]
        [Display(Name = "Num decimales")]
        public byte NumDecimales { get; set; } // num_decimales

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Formato")]
        public string Formato { get; set; } // formato (length: 20)

        [Required]
        [Display(Name = "C utiliza")]
        public bool CUtiliza { get; set; } // c_utiliza

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Campo")]
        public string Campo { get; set; } // campo (length: 20)

        [Required]
        [Display(Name = "Posicion define")]
        public byte PosicionDefine { get; set; } // posicion_define

        [Required]
        [Display(Name = "Opcional")]
        public bool Opcional { get; set; } // opcional

        public CfgLayoutBcoEdoCta()
        {
            IdLayout = 0;
            Orden = 0;
            Des = "";
            Tipo = 0;
            Longitud = 0;
            PosicionIni = 0;
            PosicionFin = 0;
            EsFechaImporte = 0;
            ValorFijo = "";
            RellenarCon = 0;
            DireccionRelleno = 0;
            LlevaPunto = false;
            NumDecimales = 0;
            Formato = "";
            CUtiliza = false;
            Campo = "";
            PosicionDefine = 0;
            Opcional = false;
        }
    }

}
// </auto-generated>
