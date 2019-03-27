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

    // VenVsPreTemp_udm
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VenVsPreTempUdm
    {
        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; } // id (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Clave")]
        public string Clave { get; set; } // clave (length: 10)

        [Required]
        [Display(Name = "Presupuesto")]
        public double Presupuesto { get; set; } // Presupuesto

        [Required]
        [Display(Name = "Id suc")]
        public int IdSuc { get; set; } // id_suc

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ini per")]
        public System.DateTime FecIniPer { get; set; } // fec_ini_per

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Suc")]
        public string Suc { get; set; } // suc (length: 80)

        [Required]
        [Display(Name = "Ventas")]
        public double Ventas { get; set; } // Ventas

        [Display(Name = "Cant vta")]
        public double? CantVta { get; set; } // cant_vta

        [Display(Name = "C est")]
        public int? CEst { get; set; } // c_Est

        [Required]
        [Display(Name = "Presupuesto cant")]
        public double PresupuestoCant { get; set; } // Presupuesto_cant

        [Required]
        [Display(Name = "Id udm peso")]
        public int IdUdmPeso { get; set; } // id_udm_peso

        [Required]
        [Display(Name = "Id udm longitud")]
        public int IdUdmLongitud { get; set; } // id_udm_longitud

        [Required]
        [Display(Name = "Id udm area")]
        public int IdUdmArea { get; set; } // id_udm_area

        [Required]
        [Display(Name = "Id udm volumen")]
        public int IdUdmVolumen { get; set; } // id_udm_volumen

        [Required]
        [Display(Name = "Ftr peso")]
        public decimal FtrPeso { get; set; } // ftr_peso

        [Required]
        [Display(Name = "Ftr longitud")]
        public decimal FtrLongitud { get; set; } // ftr_longitud

        [Required]
        [Display(Name = "Ftr area")]
        public decimal FtrArea { get; set; } // ftr_area

        [Required]
        [Display(Name = "Ftr volumen")]
        public decimal FtrVolumen { get; set; } // ftr_volumen

        [Required]
        [Display(Name = "Inv")]
        public byte Inv { get; set; } // inv

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Clave pro")]
        public string ClavePro { get; set; } // clave_pro (length: 50)

        public VenVsPreTempUdm()
        {
            Clave = "";
            Presupuesto = 0;
            IdSuc = 0;
            Suc = "";
            Ventas = 0;
            CantVta = 0;
            CEst = 0;
            PresupuestoCant = 0;
            IdUdmPeso = 0;
            IdUdmLongitud = 0;
            IdUdmArea = 0;
            IdUdmVolumen = 0;
            FtrPeso = 0m;
            FtrLongitud = 0m;
            FtrArea = 0m;
            FtrVolumen = 0m;
            Inv = 0;
            ClavePro = "";
        }
    }

}
// </auto-generated>