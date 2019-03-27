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

    // Flujo_Efec_Enc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class FlujoEfecEnc
    {
        [Required]
        [Display(Name = "Id flujo")]
        public int IdFlujo { get; set; } // id_flujo (Primary key)

        [Required]
        [Display(Name = "Version")]
        public int Version { get; set; } // Version

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; } // Descripcion (length: 50)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ini")]
        public System.DateTime FecIni { get; set; } // Fec_Ini

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec fin")]
        public System.DateTime FecFin { get; set; } // Fec_fin

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // Fec_reg

        [Display(Name = "Tipo")]
        public byte? Tipo { get; set; } // tipo

        [Display(Name = "Natu calen")]
        public byte? NatuCalen { get; set; } // natu_calen

        [Display(Name = "Cantidad")]
        public int? Cantidad { get; set; } // cantidad

        [Required]
        [Display(Name = "Es oficial")]
        public byte EsOficial { get; set; } // es_oficial

        [Display(Name = "Layout")]
        public string Layout { get; set; } // layout

        [Required]
        [Display(Name = "Id usuario")]
        public int IdUsuario { get; set; } // id_usuario

        [Required]
        [Display(Name = "Saldo")]
        public double Saldo { get; set; } // Saldo

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        public FlujoEfecEnc()
        {
            Version = 0;
            EsOficial = 0;
            Saldo = 0;
            Status = 0;
        }
    }

}
// </auto-generated>
