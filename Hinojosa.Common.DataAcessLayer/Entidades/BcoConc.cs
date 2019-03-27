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

    // bco_conc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class BcoConc
    {
        [Required]
        [Display(Name = "Id conc")]
        public int IdConc { get; set; } // id_conc (Primary key)

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc

        [Required]
        [Display(Name = "Id cta")]
        public int IdCta { get; set; } // id_cta

        [Required]
        [Display(Name = "Num doc")]
        public int NumDoc { get; set; } // num_doc

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec doc")]
        public System.DateTime FecDoc { get; set; } // fec_doc

        ///<summary>
        /// Fecha de registro
        ///</summary>
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        ///<summary>
        /// saldo inicial
        ///</summary>
        [Required]
        [Display(Name = "Si")]
        public double Si { get; set; } // si

        ///<summary>
        /// cargos conciliados
        ///</summary>
        [Required]
        [Display(Name = "Cargos")]
        public double Cargos { get; set; } // cargos

        ///<summary>
        /// abonos conciliados
        ///</summary>
        [Required]
        [Display(Name = "Abonos")]
        public double Abonos { get; set; } // abonos

        ///<summary>
        /// saldo final
        ///</summary>
        [Required]
        [Display(Name = "Sf")]
        public double Sf { get; set; } // sf

        ///<summary>
        /// Saldo inicial conciliado
        ///</summary>
        [Required]
        [Display(Name = "Sic")]
        public double Sic { get; set; } // sic

        ///<summary>
        /// cargos conciliados
        ///</summary>
        [Required]
        [Display(Name = "Cargosc")]
        public double Cargosc { get; set; } // cargosc

        ///<summary>
        /// abonos conciliados
        ///</summary>
        [Required]
        [Display(Name = "Abonosc")]
        public double Abonosc { get; set; } // abonosc

        ///<summary>
        /// saldo final conciliado
        ///</summary>
        [Required]
        [Display(Name = "Sfc")]
        public double Sfc { get; set; } // sfc

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        ///<summary>
        /// cargos en transito
        ///</summary>
        [Required]
        [Display(Name = "Cargost")]
        public double Cargost { get; set; } // cargost

        ///<summary>
        /// depositos en transito
        ///</summary>
        [Required]
        [Display(Name = "Abonost")]
        public double Abonost { get; set; } // abonost

        [Required]
        [Display(Name = "C aut")]
        public byte CAut { get; set; } // c_aut

        [Required]
        [Display(Name = "Sdo fin edo cta")]
        public double SdoFinEdoCta { get; set; } // sdo_fin_edo_cta

        [Required]
        [Display(Name = "Ret bco nc emp")]
        public double RetBcoNcEmp { get; set; } // ret_bco_nc_emp

        [Required]
        [Display(Name = "Dep bco nc emp")]
        public double DepBcoNcEmp { get; set; } // dep_bco_nc_emp

        [Required]
        [Display(Name = "Sdo emp")]
        public double SdoEmp { get; set; } // sdo_emp

        // Reverse navigation

        /// <summary>
        /// Child BcoAuxes where [bco_aux].[id_conc] point to this entity (FK_bco_aux_bco_conc)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<BcoAux> BcoAuxes { get; set; } // bco_aux.FK_bco_aux_bco_conc

        // Foreign keys

        /// <summary>
        /// Parent BcoCuenta pointed by [bco_conc].([IdCta]) (FK_bco_conc_bco_cuentas)
        /// </summary>
        public virtual BcoCuenta BcoCuenta { get; set; } // FK_bco_conc_bco_cuentas

        /// <summary>
        /// Parent CatDocto pointed by [bco_conc].([IdTipDoc]) (FK_bco_conc_cat_doctos)
        /// </summary>
        public virtual CatDocto CatDocto { get; set; } // FK_bco_conc_cat_doctos

        /// <summary>
        /// Parent SisNota pointed by [bco_conc].([IdNota]) (FK_bco_conc_sis_notas)
        /// </summary>
        public virtual SisNota SisNota { get; set; } // FK_bco_conc_sis_notas

        public BcoConc()
        {
            IdConc = 0;
            IdUsr = 0;
            IdNota = 0;
            IdTipDoc = 0;
            IdCta = 0;
            Si = 0;
            Cargos = 0;
            Abonos = 0;
            Sf = 0;
            Sic = 0;
            Cargosc = 0;
            Abonosc = 0;
            Sfc = 0;
            Status = 0;
            Cargost = 0;
            Abonost = 0;
            CAut = 0;
            SdoFinEdoCta = 0;
            RetBcoNcEmp = 0;
            DepBcoNcEmp = 0;
            SdoEmp = 0;
            BcoAuxes = new System.Collections.Generic.List<BcoAux>();
        }
    }

}
// </auto-generated>