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

    // sis_alertas_1g4
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisAlertas1G4
    {
        [Required]
        [Display(Name = "Id alerta")]
        public int IdAlerta { get; set; } // id_alerta (Primary key)

        [Required]
        [Display(Name = "Id sis aviso")]
        public int IdSisAviso { get; set; } // id_sis_aviso

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Campo alerta")]
        public string CampoAlerta { get; set; } // campo_alerta

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Config alerta")]
        public string ConfigAlerta { get; set; } // config_alerta

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status

        [MaxLength(150)]
        [StringLength(150)]
        [Display(Name = "Descripcion alt")]
        public string DescripcionAlt { get; set; } // descripcion_alt (length: 150)

        [MaxLength(150)]
        [StringLength(150)]
        [Display(Name = "Color")]
        public string Color { get; set; } // color (length: 150)

        [Display(Name = "Campos visibles")]
        public string CamposVisibles { get; set; } // campos_visibles

        [Display(Name = "Campo orden")]
        public string CampoOrden { get; set; } // campo_orden

        [Display(Name = "Tipo orden")]
        public string TipoOrden { get; set; } // tipo_orden

        [Display(Name = "Expandir")]
        public string Expandir { get; set; } // expandir

        public SisAlertas1G4()
        {
            IdSisAviso = 0;
            IdUsr = 0;
            CampoAlerta = "";
            ConfigAlerta = "0";
            Status = 0;
        }
    }

}
// </auto-generated>