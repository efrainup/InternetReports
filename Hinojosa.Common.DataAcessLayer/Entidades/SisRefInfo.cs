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

    // sis_ref_info
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisRefInfo
    {
        [Required]
        [Display(Name = "Id fac")]
        public int IdFac { get; set; } // id_fac (Primary key)

        [Required]
        [Display(Name = "Id ref")]
        public int IdRef { get; set; } // id_ref (Primary key)

        [MaxLength(64)]
        [StringLength(64)]
        [Display(Name = "Numreferencia")]
        public string Numreferencia { get; set; } // numreferencia (length: 64)

        [Required]
        [Display(Name = "Operacion")]
        public byte Operacion { get; set; } // operacion

        [Required(AllowEmptyStrings = true)]
        [MaxLength(7)]
        [StringLength(7)]
        [Display(Name = "Pedimento")]
        public string Pedimento { get; set; } // pedimento (length: 7)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Blguia")]
        public string Blguia { get; set; } // blguia (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(254)]
        [StringLength(254)]
        [Display(Name = "Marcasnum")]
        public string Marcasnum { get; set; } // marcasnum (length: 254)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(254)]
        [StringLength(254)]
        [Display(Name = "Totalbultos")]
        public string Totalbultos { get; set; } // totalbultos (length: 254)

        [Required]
        [Display(Name = "Pesobruto")]
        public double Pesobruto { get; set; } // pesobruto

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fechaentrada")]
        public System.DateTime Fechaentrada { get; set; } // fechaentrada

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fechapago")]
        public System.DateTime Fechapago { get; set; } // fechapago

        [Required(AllowEmptyStrings = true)]
        [MaxLength(254)]
        [StringLength(254)]
        [Display(Name = "Pais")]
        public string Pais { get; set; } // pais (length: 254)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Cvepedimento")]
        public string Cvepedimento { get; set; } // cvepedimento (length: 3)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(254)]
        [StringLength(254)]
        [Display(Name = "Pedido")]
        public string Pedido { get; set; } // pedido (length: 254)

        [Required]
        [Display(Name = "Tipodecambio")]
        public double Tipodecambio { get; set; } // tipodecambio

        [Required]
        [Display(Name = "Factormoneda")]
        public double Factormoneda { get; set; } // factormoneda

        [Required(AllowEmptyStrings = true)]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Tipopaisfactor")]
        public string Tipopaisfactor { get; set; } // tipopaisfactor (length: 3)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "Cvepaisvc")]
        public string Cvepaisvc { get; set; } // cvepaisvc (length: 3)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Despaisvc")]
        public string Despaisvc { get; set; } // despaisvc (length: 200)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Cvepaisod")]
        public string Cvepaisod { get; set; } // cvepaisod (length: 200)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Despaisod")]
        public string Despaisod { get; set; } // despaisod (length: 200)

        [Required]
        [Display(Name = "Cveprov")]
        public double Cveprov { get; set; } // cveprov

        [Required(AllowEmptyStrings = true)]
        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Nomprov")]
        public string Nomprov { get; set; } // nomprov (length: 200)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Regbarco")]
        public string Regbarco { get; set; } // regbarco (length: 20)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Barco")]
        public string Barco { get; set; } // barco (length: 100)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "Transporte")]
        public string Transporte { get; set; } // transporte (length: 100)

        [Required]
        [Display(Name = "Valoraduana")]
        public double Valoraduana { get; set; } // valoraduana

        [Required]
        [Display(Name = "Valorfactura")]
        public double Valorfactura { get; set; } // valorfactura

        [Required]
        [Display(Name = "Fletes")]
        public double Fletes { get; set; } // fletes

        [Required]
        [Display(Name = "Seguros")]
        public double Seguros { get; set; } // seguros

        [Required]
        [Display(Name = "Embalajes")]
        public double Embalajes { get; set; } // embalajes

        [Required]
        [Display(Name = "Incrementables")]
        public double Incrementables { get; set; } // incrementables

        [Required]
        [Display(Name = "Valorcomercial")]
        public double Valorcomercial { get; set; } // valorcomercial

        [Required]
        [Display(Name = "Valordolar")]
        public double Valordolar { get; set; } // valordolar

        [Required]
        [Display(Name = "Dta")]
        public double Dta { get; set; } // DTA

        [Required]
        [Display(Name = "Cc")]
        public double Cc { get; set; } // CC

        [Required]
        [Display(Name = "Iva")]
        public double Iva { get; set; } // IVA

        [Required]
        [Display(Name = "Isan")]
        public double Isan { get; set; } // ISAN

        [Required]
        [Display(Name = "Ieps")]
        public double Ieps { get; set; } // IEPS

        [Required]
        [Display(Name = "Igie")]
        public double Igie { get; set; } // IGIE

        [Required]
        [Display(Name = "Recargos")]
        public double Recargos { get; set; } // RECARGOS

        [Required]
        [Display(Name = "Otros")]
        public double Otros { get; set; } // OTROS

        [Required]
        [Display(Name = "Dti")]
        public double Dti { get; set; } // DTI

        [Required]
        [Display(Name = "Multas")]
        public double Multas { get; set; } // MULTAS

        [Required]
        [Display(Name = "I 303")]
        public double I303 { get; set; } // I303

        [Required]
        [Display(Name = "Rt")]
        public double Rt { get; set; } // RT

        [Required]
        [Display(Name = "Prev")]
        public double Prev { get; set; } // PREV

        [Required]
        [Display(Name = "Impuestospagados")]
        public double Impuestospagados { get; set; } // impuestospagados

        [Required]
        [Display(Name = "Impuestosnopagados")]
        public double Impuestosnopagados { get; set; } // impuestosnopagados

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "Facturas")]
        public string Facturas { get; set; } // facturas (length: 500)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(150)]
        [StringLength(150)]
        [Display(Name = "Destinatario")]
        public string Destinatario { get; set; } // destinatario (length: 150)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(250)]
        [StringLength(250)]
        [Display(Name = "Desmercancia")]
        public string Desmercancia { get; set; } // desmercancia (length: 250)

        [Required]
        [Display(Name = "Basegrabable")]
        public double Basegrabable { get; set; } // basegrabable

        [Required]
        [Display(Name = "Tipohonorario")]
        public int Tipohonorario { get; set; } // tipohonorario

        [Required]
        [Display(Name = "Porcentaje")]
        public double Porcentaje { get; set; } // porcentaje

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fsalbarco")]
        public System.DateTime Fsalbarco { get; set; } // fsalbarco

        [Required]
        [Display(Name = "Mto ant")]
        public double MtoAnt { get; set; } // mto_ant

        [Required]
        [Display(Name = "Sdo ant")]
        public double SdoAnt { get; set; } // sdo_ant

        [Required]
        [Display(Name = "Mto apl")]
        public double MtoApl { get; set; } // mto_apl

        [Required]
        [Display(Name = "Sdo apl")]
        public double SdoApl { get; set; } // sdo_apl

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Banco")]
        public string Banco { get; set; } // banco (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(12)]
        [StringLength(12)]
        [Display(Name = "Identificador")]
        public string Identificador { get; set; } // identificador (length: 12)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(22)]
        [StringLength(22)]
        [Display(Name = "Nboperacion")]
        public string Nboperacion { get; set; } // nboperacion (length: 22)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(12)]
        [StringLength(12)]
        [Display(Name = "Caja")]
        public string Caja { get; set; } // caja (length: 12)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha")]
        public System.DateTime Fecha { get; set; } // fecha

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Hora")]
        public System.DateTime Hora { get; set; } // hora

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Nomdue")]
        public string Nomdue { get; set; } // nomdue (length: 25)

        [Required]
        [Display(Name = "Pagocliente")]
        public double Pagocliente { get; set; } // pagocliente

        [Required]
        [Display(Name = "Eci")]
        public double Eci { get; set; } // ECI

        [Required]
        [Display(Name = "Cnt")]
        public double Cnt { get; set; } // CNT

        [Required(AllowEmptyStrings = true)]
        [MaxLength(12)]
        [StringLength(12)]
        [Display(Name = "Naviera")]
        public string Naviera { get; set; } // naviera (length: 12)

        public SisRefInfo()
        {
            IdFac = 0;
            IdRef = 0;
            Numreferencia = "";
            Operacion = 0;
            Pedimento = "";
            Blguia = "";
            Marcasnum = "";
            Totalbultos = "";
            Pesobruto = 0;
            Pais = "";
            Cvepedimento = "";
            Pedido = "";
            Tipodecambio = 0;
            Factormoneda = 0;
            Tipopaisfactor = "";
            Cvepaisvc = "";
            Despaisvc = "";
            Cvepaisod = "";
            Despaisod = "";
            Cveprov = 0;
            Nomprov = "";
            Regbarco = "";
            Barco = "";
            Transporte = "";
            Valoraduana = 0;
            Valorfactura = 0;
            Fletes = 0;
            Seguros = 0;
            Embalajes = 0;
            Incrementables = 0;
            Valorcomercial = 0;
            Valordolar = 0;
            Dta = 0;
            Cc = 0;
            Iva = 0;
            Isan = 0;
            Ieps = 0;
            Igie = 0;
            Recargos = 0;
            Otros = 0;
            Dti = 0;
            Multas = 0;
            I303 = 0;
            Rt = 0;
            Prev = 0;
            Impuestospagados = 0;
            Impuestosnopagados = 0;
            Facturas = "";
            Destinatario = "";
            Desmercancia = "";
            Basegrabable = 0;
            Tipohonorario = 0;
            Porcentaje = 0;
            Fsalbarco = System.DateTime.Now;
            MtoAnt = 0;
            SdoAnt = 0;
            MtoApl = 0;
            SdoApl = 0;
            Banco = "";
            Identificador = "";
            Nboperacion = "";
            Caja = "";
            Nomdue = "";
            Pagocliente = 0;
            Eci = 0;
            Cnt = 0;
            Naviera = "";
        }
    }

}
// </auto-generated>
