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

    // cfg_empresa
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CfgEmpresa
    {
        [Required]
        [Display(Name = "Id cmp")]
        public int IdCmp { get; set; } // id_cmp (Primary key)

        [Required]
        [Display(Name = "No empresa")]
        public int NoEmpresa { get; set; } // No_Empresa

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Nombre pf")]
        public string NombrePf { get; set; } // Nombre_PF (length: 80)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; } // Nombre (length: 128)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "Calle")]
        public string Calle { get; set; } // Calle (length: 128)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Colonia")]
        public string Colonia { get; set; } // Colonia (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; } // Ciudad (length: 25)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Estado")]
        public string Estado { get; set; } // Estado (length: 25)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(8)]
        [StringLength(8)]
        [Display(Name = "Cp")]
        public string Cp { get; set; } // CP (length: 8)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Tel 1")]
        public string Tel1 { get; set; } // Tel1 (length: 20)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Tel 2")]
        public string Tel2 { get; set; } // Tel2 (length: 20)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(45)]
        [StringLength(45)]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; } // email (length: 45)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(70)]
        [StringLength(70)]
        [Url]
        [Display(Name = "Url")]
        public string Url { get; set; } // url (length: 70)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Rfc")]
        public string Rfc { get; set; } // rfc (length: 20)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Server")]
        public string Server { get; set; } // server (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Db")]
        public string Db { get; set; } // db (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Arch")]
        public string Arch { get; set; } // arch (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "Raz soc")]
        public string RazSoc { get; set; } // raz_soc (length: 128)

        [Required]
        [Display(Name = "C mcp")]
        public byte CMcp { get; set; } // c_mcp

        ///<summary>
        /// 1=Moral, 2=Fisica
        ///</summary>
        [Required]
        [Display(Name = "Tip persona")]
        public byte TipPersona { get; set; } // tip_persona

        [Required(AllowEmptyStrings = true)]
        [MaxLength(18)]
        [StringLength(18)]
        [Display(Name = "Curp")]
        public string Curp { get; set; } // curp (length: 18)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Noint")]
        public string Noint { get; set; } // noint (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Noext")]
        public string Noext { get; set; } // noext (length: 10)

        [MaxLength(256)]
        [StringLength(256)]
        [Display(Name = "Entrecalles")]
        public string Entrecalles { get; set; } // entrecalles (length: 256)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Delegacion")]
        public string Delegacion { get; set; } // delegacion (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Phone]
        [Display(Name = "Fax")]
        public string Fax { get; set; } // fax (length: 50)

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [MaxLength(2147483647)]
        [Display(Name = "Logo")]
        public byte[] Logo { get; set; } // logo (length: 2147483647)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(128)]
        [StringLength(128)]
        [Display(Name = "Direccion")]
        public string Direccion { get; set; } // Direccion (length: 128)

        [Required]
        [Display(Name = "C rh")]
        public byte CRh { get; set; } // c_RH

        [Required]
        [Display(Name = "C act")]
        public byte CAct { get; set; } // c_act

        [Required(AllowEmptyStrings = true)]
        [MaxLength(9)]
        [StringLength(9)]
        [Display(Name = "Rgb")]
        public string Rgb { get; set; } // RGB (length: 9)

        [Required]
        [Display(Name = "Id cli")]
        public int IdCli { get; set; } // id_cli

        [Required]
        [Display(Name = "Id prov")]
        public int IdProv { get; set; } // id_prov

        [Required]
        [Display(Name = "Grp mcp")]
        public int GrpMcp { get; set; } // grp_mcp

        [Required]
        [Display(Name = "Id emp pat")]
        public int IdEmpPat { get; set; } // id_emp_pat

        [Required]
        [Display(Name = "Id emp rep")]
        public int IdEmpRep { get; set; } // id_emp_rep

        [MaxLength(2147483647)]
        [Display(Name = "Cedula")]
        public byte[] Cedula { get; set; } // cedula (length: 2147483647)

        [Required]
        [Display(Name = "Id cli tab ar")]
        public long IdCliTabAr { get; set; } // id_cli_tab_ar

        [Required]
        [Display(Name = "Id tip esq")]
        public int IdTipEsq { get; set; } // id_tip_esq

        [Required]
        [Display(Name = "Id rel da")]
        public int IdRelDa { get; set; } // id_rel_da

        [Required]
        [Display(Name = "Id pais")]
        public int IdPais { get; set; } // id_pais

        [Required]
        [Display(Name = "Id edo")]
        public int IdEdo { get; set; } // id_edo

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Clave")]
        public string Clave { get; set; } // clave (length: 40)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required(AllowEmptyStrings = true)]
        [MaxLength(2147483647)]
        [StringLength(2147483647)]
        [Display(Name = "Plan html")]
        public string PlanHtml { get; set; } // plan_html (length: 2147483647)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Cert")]
        public string Cert { get; set; } // cert

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Licencia")]
        public string Licencia { get; set; } // licencia

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Cals")]
        public string Cals { get; set; } // cals

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Llave cert")]
        public string LlaveCert { get; set; } // llave_cert

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Db mcp")]
        public string DbMcp { get; set; } // db_mcp (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(2147483647)]
        [StringLength(2147483647)]
        [Display(Name = "Plan cfdi")]
        public string PlanCfdi { get; set; } // plan_cfdi (length: 2147483647)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Cfd exp")]
        public string CfdExp { get; set; } // cfd_exp

        [Required(AllowEmptyStrings = true)]
        [MaxLength(2147483647)]
        [StringLength(2147483647)]
        [Display(Name = "Plan avisos")]
        public string PlanAvisos { get; set; } // plan_avisos (length: 2147483647)

        [Display(Name = "Exp")]
        public string Exp { get; set; } // exp

        ///<summary>
        /// C
        ///</summary>
        [Required(AllowEmptyStrings = true)]
        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "Reg pat")]
        public string RegPat { get; set; } // reg_pat (length: 20)

        [Required]
        [Display(Name = "C pag cfd")]
        public int CPagCfd { get; set; } // c_pag_cfd

        [Required]
        [Display(Name = "C donat")]
        public byte CDonat { get; set; } // c_donat

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Aut donat")]
        public string AutDonat { get; set; } // aut_donat (length: 50)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec donat")]
        public System.DateTime FecDonat { get; set; } // fec_donat

        [Required(AllowEmptyStrings = true)]
        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "Num escritura")]
        public string NumEscritura { get; set; } // num_escritura (length: 500)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fch escritura")]
        public System.DateTime FchEscritura { get; set; } // fch_escritura

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Dat notariales")]
        public string DatNotariales { get; set; } // dat_notariales

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Num exp con")]
        public string NumExpCon { get; set; } // num_exp_con (length: 50)

        [Required]
        [Display(Name = "Id mun")]
        public int IdMun { get; set; } // id_mun

        [Required]
        [Display(Name = "Id loc")]
        public int IdLoc { get; set; } // id_loc

        [Required]
        [Display(Name = "Id cp")]
        public int IdCp { get; set; } // id_cp

        [Required]
        [Display(Name = "Id col")]
        public int IdCol { get; set; } // id_col

        [Required]
        [Display(Name = "C cons sdo")]
        public int CConsSdo { get; set; } // c_cons_sdo

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) CfgEmpresa pointed by [SIR_766_CONFIGURACION_EMPRESA_1G].[nIdEmpresa] (FK_SIR_766_CONFIGURACION_EMPRESA_1G_cfg_empresa)
        /// </summary>
        public virtual SIR_Sir766ConfiguracionEmpresa1G SIR_Sir766ConfiguracionEmpresa1G { get; set; } // SIR_766_CONFIGURACION_EMPRESA_1G.FK_SIR_766_CONFIGURACION_EMPRESA_1G_cfg_empresa

        public CfgEmpresa()
        {
            IdCmp = 0;
            NombrePf = "";
            Nombre = "";
            Calle = "";
            Colonia = "";
            Ciudad = "";
            Estado = "";
            Cp = "";
            Tel1 = "";
            Tel2 = "";
            Email = "";
            Url = "";
            Server = "";
            Db = "";
            Arch = "";
            RazSoc = "";
            CMcp = 0;
            TipPersona = 0;
            Curp = " ";
            Noint = " ";
            Noext = " ";
            Entrecalles = " ";
            Delegacion = " ";
            Fax = " ";
            Status = 1;
            Direccion = " ";
            CRh = 0;
            CAct = 0;
            Rgb = "000000000";
            IdCli = 0;
            IdProv = 0;
            GrpMcp = 0;
            IdEmpPat = 0;
            IdEmpRep = 0;
            IdCliTabAr = 0;
            IdTipEsq = 0;
            IdRelDa = 0;
            IdPais = 0;
            IdEdo = 0;
            Clave = "";
            FecReg = System.DateTime.Now;
            PlanHtml = "";
            Cert = "";
            Licencia = "";
            Cals = "";
            LlaveCert = "";
            DbMcp = "";
            PlanCfdi = "";
            CfdExp = "";
            PlanAvisos = "";
            RegPat = "";
            CPagCfd = 1;
            CDonat = 0;
            AutDonat = "";
            NumEscritura = "";
            DatNotariales = "";
            NumExpCon = "";
            IdMun = 0;
            IdLoc = 0;
            IdCp = 0;
            IdCol = 0;
            CConsSdo = 0;
        }
    }

}
// </auto-generated>
