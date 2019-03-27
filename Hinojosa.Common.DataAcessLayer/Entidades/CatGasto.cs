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

    // cat_gastos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatGasto
    {
        [Required]
        [Display(Name = "Id gto")]
        public int IdGto { get; set; } // id_gto (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Clave")]
        public string Clave { get; set; } // clave (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (length: 40)

        [Required]
        [Display(Name = "Id cla gto")]
        public int IdClaGto { get; set; } // id_cla_gto

        ///<summary>
        /// 1=Actuvo 0=desactivo
        ///</summary>
        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [Display(Name = "Acum")]
        public double Acum { get; set; } // acum

        ///<summary>
        /// 1=Gastos de Venta 2=Admon 3=Financieros  4=Impuestos  5=Fabricación 6=otros
        ///</summary>
        [Required]
        [Display(Name = "Tipo")]
        public byte Tipo { get; set; } // tipo

        ///<summary>
        /// 1=Es un Gasto 2=Ingreso 3=Productos Financieros 4=Otros 5=Deudores 6=IVA por Pagary 7=IVA por Cobrar
        ///</summary>
        [Required]
        [Display(Name = "Tip ent")]
        public byte TipEnt { get; set; } // tip_ent

        ///<summary>
        /// 0= Ninguno 1=Utilidad Cambiaria 2=Perdida
        ///</summary>
        [Required]
        [Display(Name = "Tip uti per")]
        public byte TipUtiPer { get; set; } // tip_uti_per

        [Required]
        [Display(Name = "Id tip cto")]
        public int IdTipCto { get; set; } // id_tip_cto

        ///<summary>
        /// 1=El gasto esfijo 0=Variable
        ///</summary>
        [Required]
        [Display(Name = "C fijo")]
        public byte CFijo { get; set; } // c_fijo

        [Required]
        [Display(Name = "Id cta")]
        public int IdCta { get; set; } // id_cta

        [Required]
        [Display(Name = "Id cta 2")]
        public int IdCta2 { get; set; } // id_cta2

        [Required]
        [Display(Name = "C depnoid")]
        public byte CDepnoid { get; set; } // c_depnoid

        [Required]
        [Display(Name = "C edit impto")]
        public byte CEditImpto { get; set; } // c_edit_impto

        [Required]
        [Display(Name = "C aju cxc")]
        public byte CAjuCxc { get; set; } // c_aju_cxc

        [Required]
        [Display(Name = "C aju cxp")]
        public byte CAjuCxp { get; set; } // c_aju_cxp

        [Required]
        [Display(Name = "C pag ret isr")]
        public byte CPagRetIsr { get; set; } // c_pag_ret_isr

        [Required]
        [Display(Name = "C pag ret iva")]
        public byte CPagRetIva { get; set; } // c_pag_ret_iva

        [Required]
        [Display(Name = "Id cta no ded")]
        public int IdCtaNoDed { get; set; } // id_cta_no_ded

        [Required]
        [Display(Name = "Id otr sis")]
        public int IdOtrSis { get; set; } // id_otr_sis

        [Required]
        [Display(Name = "C apl nom")]
        public byte CAplNom { get; set; } // c_apl_nom

        [Required]
        [Display(Name = "Id imp")]
        public int IdImp { get; set; } // id_imp

        [Required]
        [Display(Name = "C ide")]
        public byte CIde { get; set; } // c_ide

        [Required]
        [Display(Name = "C isr pm")]
        public byte CIsrPm { get; set; } // c_ISR_pm

        [Required]
        [Display(Name = "C isr arr")]
        public byte CIsrArr { get; set; } // c_ISR_arr

        [Required]
        [Display(Name = "C isr hon")]
        public byte CIsrHon { get; set; } // c_ISR_hon

        [Required]
        [Display(Name = "C isr sal")]
        public byte CIsrSal { get; set; } // c_ISR_sal

        [Required]
        [Display(Name = "C isr asi")]
        public byte CIsrAsi { get; set; } // c_ISR_asi

        [Required]
        [Display(Name = "C iva")]
        public byte CIva { get; set; } // c_IVA

        [Required]
        [Display(Name = "C ret iva")]
        public byte CRetIva { get; set; } // c_RET_IVA

        [Required]
        [Display(Name = "C ietu")]
        public byte CIetu { get; set; } // c_IETU

        [Required]
        [Display(Name = "Id tip ope srv")]
        public int IdTipOpeSrv { get; set; } // id_tip_ope_srv

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro

        [Required]
        [Display(Name = "C apl com")]
        public byte CAplCom { get; set; } // c_apl_com

        public CatGasto()
        {
            IdGto = 0;
            Clave = "";
            Des = "";
            IdClaGto = 0;
            Status = 1;
            Acum = 0;
            Tipo = 0;
            TipEnt = 1;
            TipUtiPer = 0;
            IdTipCto = 0;
            CFijo = 0;
            IdCta = 0;
            IdCta2 = 0;
            CDepnoid = 0;
            CEditImpto = 0;
            CAjuCxc = 0;
            CAjuCxp = 0;
            CPagRetIsr = 0;
            CPagRetIva = 0;
            IdCtaNoDed = 0;
            IdOtrSis = 0;
            CAplNom = 0;
            IdImp = 0;
            CIde = 0;
            CIsrPm = 0;
            CIsrArr = 0;
            CIsrHon = 0;
            CIsrSal = 0;
            CIsrAsi = 0;
            CIva = 0;
            CRetIva = 0;
            CIetu = 0;
            IdTipOpeSrv = 0;
            IdPro = 0;
            CAplCom = 0;
        }
    }

}
// </auto-generated>
