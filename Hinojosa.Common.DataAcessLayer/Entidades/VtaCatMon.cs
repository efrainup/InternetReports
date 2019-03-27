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

    // vta_cat_mon
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaCatMon
    {
        [Required]
        [Display(Name = "Id mon")]
        public int IdMon { get; set; } // id_mon (Primary key)

        [Required]
        [Display(Name = "Numero")]
        public int Numero { get; set; } // numero

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ini")]
        public System.DateTime FecIni { get; set; } // fec_ini

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec vig")]
        public System.DateTime FecVig { get; set; } // fec_vig

        [Required]
        [Display(Name = "Tip tarj")]
        public int TipTarj { get; set; } // tip_tarj

        [Required]
        [Display(Name = "Id tip val")]
        public int IdTipVal { get; set; } // id_tip_val

        [Required]
        [Display(Name = "Id tip tarj dto")]
        public int IdTipTarjDto { get; set; } // id_tip_tarj_dto

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Valor")]
        public string Valor { get; set; } // valor (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Nip valor")]
        public string NipValor { get; set; } // nip_valor (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "Nombre c")]
        public string NombreC { get; set; } // nombre_c (length: 128)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Ap pat")]
        public string ApPat { get; set; } // ap_pat (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Ap mat")]
        public string ApMat { get; set; } // ap_mat (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(48)]
        [StringLength(48)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; } // nombre (length: 48)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Tel")]
        public string Tel { get; set; } // tel (length: 30)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Cel")]
        public string Cel { get; set; } // cel (length: 30)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(100)]
        [StringLength(100)]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; } // email (length: 100)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec nac")]
        public System.DateTime FecNac { get; set; } // fec_nac

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec anv")]
        public System.DateTime FecAnv { get; set; } // fec_anv

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Calle")]
        public string Calle { get; set; } // calle (length: 80)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Colonia")]
        public string Colonia { get; set; } // colonia (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Ciu")]
        public string Ciu { get; set; } // ciu (length: 30)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Cp")]
        public string Cp { get; set; } // cp (length: 10)

        [Required]
        [Display(Name = "Id pais")]
        public int IdPais { get; set; } // id_pais

        [Required]
        [Display(Name = "Id edo")]
        public int IdEdo { get; set; } // id_edo

        [Display(Name = "Status")]
        public byte? Status { get; set; } // status

        [Required]
        [Display(Name = "Saldo")]
        public double Saldo { get; set; } // saldo

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required(AllowEmptyStrings = true)]
        [MaxLength(13)]
        [StringLength(13)]
        [Display(Name = "Num int")]
        public string NumInt { get; set; } // num_int (length: 13)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Num ext")]
        public string NumExt { get; set; } // num_ext (length: 10)

        [Required]
        [Display(Name = "Id cli")]
        public int IdCli { get; set; } // id_cli

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Empr")]
        public string Empr { get; set; } // empr (length: 50)

        [Required]
        [Display(Name = "Id suc")]
        public int IdSuc { get; set; } // id_suc

        [Required]
        [Display(Name = "Intentos")]
        public int Intentos { get; set; } // intentos

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ult mod")]
        public System.DateTime FecUltMod { get; set; } // fec_ult_mod

        // Reverse navigation

        /// <summary>
        /// Child VtaAuxes where [vta_aux].[id_mon] point to this entity (FK_vta_aux_vta_cat_mon)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<VtaAux> VtaAuxes { get; set; } // vta_aux.FK_vta_aux_vta_cat_mon

        public VtaCatMon()
        {
            IdMon = 0;
            Numero = 0;
            TipTarj = 0;
            IdTipVal = 0;
            IdTipTarjDto = 0;
            Valor = "";
            NipValor = "";
            NombreC = "";
            ApPat = "";
            ApMat = "";
            Nombre = "";
            Tel = "";
            Cel = "";
            Email = "";
            Calle = "";
            Colonia = "";
            Ciu = "";
            Cp = "";
            IdPais = 0;
            IdEdo = 0;
            Status = 0;
            Saldo = 0;
            IdUsr = 0;
            NumInt = "";
            NumExt = "";
            IdCli = 0;
            Empr = "";
            IdSuc = 0;
            Intentos = 0;
            VtaAuxes = new System.Collections.Generic.List<VtaAux>();
        }
    }

}
// </auto-generated>
