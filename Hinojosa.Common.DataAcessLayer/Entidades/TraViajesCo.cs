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

    // tra_viajes_cos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TraViajesCo
    {
        [Required]
        [Display(Name = "Id viaje cos")]
        public int IdViajeCos { get; set; } // id_viaje_cos (Primary key)

        [Required]
        [Display(Name = "Id viaje")]
        public int IdViaje { get; set; } // id_viaje

        [Required]
        [Display(Name = "Id rec")]
        public int IdRec { get; set; } // id_rec

        [Required]
        [Display(Name = "Id")]
        public int Id { get; set; } // id

        [Required]
        [Display(Name = "Id tip documento")]
        public int IdTipDocumento { get; set; } // id_tip_documento

        [Required]
        [Display(Name = "Id cli fa da")]
        public int IdCliFaDa { get; set; } // id_cli_fa_da

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fec exp")]
        public System.DateTime FecExp { get; set; } // fec_exp

        [Required]
        [DataType(DataType.Date)]
        [Display(Name = "Fec ven")]
        public System.DateTime FecVen { get; set; } // fec_ven

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Folio")]
        public string Folio { get; set; } // folio (length: 30)

        [Required]
        [Display(Name = "Id periodicidad")]
        public int IdPeriodicidad { get; set; } // id_periodicidad

        [Required]
        [Display(Name = "Monto")]
        public double Monto { get; set; } // monto

        [Required]
        [Display(Name = "Id mda")]
        public int IdMda { get; set; } // id_mda

        [Required]
        [Display(Name = "Dias")]
        public int Dias { get; set; } // dias

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Comentario")]
        public string Comentario { get; set; } // comentario (length: 250)

        [Required]
        [Display(Name = "Id pais")]
        public int IdPais { get; set; } // id_pais

        [Required]
        [Display(Name = "Status")]
        public int Status { get; set; } // status

        [Required]
        [Display(Name = "Mantenimiento")]
        public double Mantenimiento { get; set; } // mantenimiento

        [Required]
        [Display(Name = "C arrendamiento")]
        public bool CArrendamiento { get; set; } // c_arrendamiento

        [Required]
        [Display(Name = "C aplica costeo")]
        public bool CAplicaCosteo { get; set; } // c_aplica_costeo

        [Required]
        [Display(Name = "Id udm")]
        public int IdUdm { get; set; } // id_udm

        [Required]
        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; } // cantidad

        [Required]
        [Display(Name = "Precio")]
        public double Precio { get; set; } // precio

        [Required]
        [Display(Name = "C aplica anticipo")]
        public bool CAplicaAnticipo { get; set; } // c_aplica_anticipo

        [Required]
        [Display(Name = "C docto adj")]
        public bool CDoctoAdj { get; set; } // c_docto_adj

        [Required]
        [Display(Name = "Id impto")]
        public int IdImpto { get; set; } // id_impto

        [Required]
        [Display(Name = "Impuesto")]
        public double Impuesto { get; set; } // impuesto

        [Required]
        [Display(Name = "Importe")]
        public double Importe { get; set; } // importe

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Tipo")]
        public string Tipo { get; set; } // tipo (length: 250)

        [Required]
        [Display(Name = "Orden")]
        public int Orden { get; set; } // orden

        [Required]
        [Display(Name = "Costo simptos")]
        public double CostoSimptos { get; set; } // costo_simptos

        [Required]
        [Display(Name = "Costo imptos")]
        public double CostoImptos { get; set; } // costo_imptos

        [Required]
        [Display(Name = "Costo cimptos")]
        public double CostoCimptos { get; set; } // costo_cimptos

        [Required]
        [Display(Name = "Chk")]
        public bool Chk { get; set; } // chk

        [Required]
        [Display(Name = "Km")]
        public int Km { get; set; } // km

        [Required]
        [Display(Name = "Factor km")]
        public double FactorKm { get; set; } // factor_km

        [Required]
        [Display(Name = "Chk ind")]
        public bool ChkInd { get; set; } // chk_ind

        public TraViajesCo()
        {
            IdViaje = 0;
            IdRec = 0;
            Id = 0;
            IdTipDocumento = 0;
            IdCliFaDa = 0;
            IdPro = 0;
            Folio = "";
            IdPeriodicidad = 0;
            Monto = 0;
            IdMda = 0;
            Dias = 0;
            Comentario = "";
            IdPais = 0;
            Status = 0;
            Mantenimiento = 0;
            CArrendamiento = false;
            CAplicaCosteo = false;
            IdUdm = 0;
            Cantidad = 0;
            Precio = 0;
            CAplicaAnticipo = false;
            CDoctoAdj = false;
            IdImpto = 0;
            Impuesto = 0;
            Importe = 0;
            Tipo = "";
            Orden = 0;
            CostoSimptos = 0;
            CostoImptos = 0;
            CostoCimptos = 0;
            Chk = false;
            Km = 0;
            FactorKm = 0;
            ChkInd = false;
        }
    }

}
// </auto-generated>
