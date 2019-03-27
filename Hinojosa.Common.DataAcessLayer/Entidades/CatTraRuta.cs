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

    // cat_tra_ruta
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatTraRuta
    {
        [Required]
        [Display(Name = "Id ruta")]
        public int IdRuta { get; set; } // id_ruta (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Cod ruta")]
        public string CodRuta { get; set; } // cod_ruta (length: 25)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (length: 50)

        [Required]
        [Display(Name = "Id edo org")]
        public int IdEdoOrg { get; set; } // id_edo_org

        [Required]
        [Display(Name = "Id mpio org")]
        public int IdMpioOrg { get; set; } // id_mpio_org

        [Required]
        [Display(Name = "Id loc org")]
        public int IdLocOrg { get; set; } // id_loc_org

        [Required]
        [Display(Name = "Id edo des")]
        public int IdEdoDes { get; set; } // id_edo_des

        [Required]
        [Display(Name = "Id mpio des")]
        public int IdMpioDes { get; set; } // id_mpio_des

        [Required]
        [Display(Name = "Id loc des")]
        public int IdLocDes { get; set; } // id_loc_des

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Via")]
        public string Via { get; set; } // via (length: 50)

        [Required]
        [Display(Name = "Kms")]
        public double Kms { get; set; } // kms

        [Required]
        [Display(Name = "Casetas")]
        public int Casetas { get; set; } // casetas

        [Required]
        [Display(Name = "Costo")]
        public double Costo { get; set; } // costo

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status

        [Required(AllowEmptyStrings = true)]
        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; } // tipo (length: 2)

        [Required]
        [Display(Name = "Combustible")]
        public double Combustible { get; set; } // combustible

        [Required]
        [Display(Name = "Otros gastos")]
        public double OtrosGastos { get; set; } // otros_gastos

        [Required]
        [Display(Name = "Valor viaje")]
        public double ValorViaje { get; set; } // valor_viaje

        [Required]
        [Display(Name = "Ptg com")]
        public double PtgCom { get; set; } // ptg_com

        [Required]
        [Display(Name = "Tot gas viaje")]
        public double TotGasViaje { get; set; } // tot_gas_viaje

        [Required]
        [Display(Name = "Ptg com full")]
        public double PtgComFull { get; set; } // ptg_com_full

        [Display(Name = "Id pais org")]
        public int? IdPaisOrg { get; set; } // id_pais_org

        [Display(Name = "Id pais des")]
        public int? IdPaisDes { get; set; } // id_pais_des

        [Display(Name = "Id moneda")]
        public int? IdMoneda { get; set; } // id_moneda

        [Display(Name = "Tip cam act")]
        public double? TipCamAct { get; set; } // tip_cam_act

        public CatTraRuta()
        {
            IdRuta = 0;
            CodRuta = "";
            Des = "";
            IdEdoOrg = 0;
            IdMpioOrg = 0;
            IdLocOrg = 0;
            IdEdoDes = 0;
            IdMpioDes = 0;
            IdLocDes = 0;
            Via = "";
            Kms = 0;
            Casetas = 0;
            Costo = 0;
            IdNota = 0;
            IdUsr = 0;
            Status = 0;
            Tipo = "";
            Combustible = 0;
            OtrosGastos = 0;
            ValorViaje = 0;
            PtgCom = 0;
            TotGasViaje = 0;
            PtgComFull = 0;
        }
    }

}
// </auto-generated>