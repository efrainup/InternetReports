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
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Hinojosa.Common.DataAccessLayer.Entidades
{

    // cat_clientes
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.36.1.0")]
    public class CatCliente
    {
        
        [Column("id_cli")]
        public int IdCli { get; set; } // id_cli (Primary key)
        public string Clave { get; set; } // clave (length: 12)
        public string Nom1 { get; set; } // nom1 (length: 128)
        public string Nom2 { get; set; } // nom2 (length: 128)
        //public string Dir1 { get; set; } // dir1 (length: 255)
        //public string Dir2 { get; set; } // dir2 (length: 255)
        //public string Ciu { get; set; } // ciu (length: 80)
        //public string Est { get; set; } // est (length: 30)
        //public string Cp { get; set; } // cp (length: 10)
        //public string Rfc { get; set; } // rfc (length: 40)
        //public string Tel1 { get; set; } // tel1 (length: 30)
        //public string Tel2 { get; set; } // tel2 (length: 30)
        //public string Email { get; set; } // email (length: 200)
        //public int IdClas1 { get; set; } // id_clas1
        //public int IdClas2 { get; set; } // id_clas2
        //public byte? Sistema { get; set; } // sistema
        //public byte? Status { get; set; } // status
        //public System.DateTime? UltVta { get; set; } // ult_vta
        //public double? MtoVta { get; set; } // mto_vta
        //public System.DateTime? UltFac { get; set; } // ult_fac
        //public double MtoFac { get; set; } // mto_fac
        //public double Saldo { get; set; } // saldo

        /////<summary>
        ///// Limite de Crédito
        /////</summary>
        //public double Limite { get; set; } // limite

        /////<summary>
        ///// Descuento del Cliente
        /////</summary>
        //public double DctoPtg { get; set; } // dcto_ptg

        /////<summary>
        ///// Saldo en Notas
        /////</summary>
        //public double SaldoNot { get; set; } // saldo_not
        //public byte Dias { get; set; } // dias
        //public double MtoDevV { get; set; } // mto_dev_v
        //public double MtoDevF { get; set; } // mto_dev_f
        //public System.DateTime UltDevV { get; set; } // ult_dev_v
        //public System.DateTime UltDevF { get; set; } // ult_dev_f

        /////<summary>
        ///// Id del Almacen a consignacion
        /////</summary>
        //public byte IdAlmCsgn { get; set; } // id_alm_csgn

        /////<summary>
        ///// Saldo que tiene el cliente por Remisiones sin facturar
        /////</summary>
        //public double SaldoConsig { get; set; } // saldo_consig

        /////<summary>
        ///// Id del Agente de ventas asignado
        /////</summary>
        //public int IdVend { get; set; } // id_vend
        //public string Contacto1 { get; set; } // Contacto1 (length: 40)
        //public string Contacto2 { get; set; } // Contacto2 (length: 40)
        //public int IdRelClas { get; set; } // id_rel_clas
        //public int IdMda { get; set; } // id_mda

        /////<summary>
        ///// 1=Personal Moral 2=Persona Fisica
        /////</summary>
        //public byte TipCli { get; set; } // tip_cli
        //public string ApPat { get; set; } // ap_pat (length: 40)
        //public string ApMat { get; set; } // ap_mat (length: 40)
        //public string Nombre { get; set; } // nombre (length: 48)
        //public string Calle { get; set; } // calle (length: 80)

        /////<summary>
        ///// Numero Interior
        /////</summary>
        //public string NumInt { get; set; } // num_int (length: 30)

        /////<summary>
        ///// numero exterior
        /////</summary>
        //public string NumExt { get; set; } // num_ext (length: 30)

        /////<summary>
        ///// Colonia
        /////</summary>
        //public string Col { get; set; } // col (length: 70)

        /////<summary>
        ///// delegación
        /////</summary>
        //public string Deleg { get; set; } // deleg (length: 50)
        //public string Curp { get; set; } // curp (length: 40)
        //public string Calles { get; set; } // calles (length: 40)

        /////<summary>
        ///// join con la tabla sis_cto de Contactos
        /////</summary>
        //public int IdCtoCat { get; set; } // id_cto_cat

        /////<summary>
        ///// Indica el Cliente padre cuando existe en mas de una moneda
        /////</summary>
        //public int IdCliPad { get; set; } // id_cli_pad
        //public int IdCrp { get; set; } // id_crp
        //public int IdEmpCob { get; set; } // id_emp_cob
        //public int IdEmpEje { get; set; } // id_emp_eje
        //public int IdLisPre { get; set; } // id_lis_pre
        //public string DiasFac { get; set; } // dias_fac (length: 7)
        //public string DiasRev { get; set; } // dias_rev (length: 7)
        //public string DiasPag { get; set; } // dias_pag (length: 7)
        //public string HorRev { get; set; } // hor_rev (length: 16)
        //public string HorPag { get; set; } // hor_pag (length: 16)
        //public int IdEmp { get; set; } // id_emp
        //public int IdSuc { get; set; } // id_suc
        //public int CDsp { get; set; } // c_dsp
        //public System.DateTime FecCsl { get; set; } // fec_csl
        //public int StatusCsl { get; set; } // status_csl

        /////<summary>
        ///// 1=Es el cliente por default 0=Depende de otro cliente
        /////</summary>
        //public byte CDef { get; set; } // c_def
        //public int IdRelFaDa { get; set; } // id_rel_fa_da

        /////<summary>
        ///// join a sis_rel_prov para manejo de comisionistas
        /////</summary>
        //public int IdRelProv { get; set; } // id_rel_prov

        /////<summary>
        ///// id de condiciones de pago
        /////</summary>
        //public int IdCndPag { get; set; } // id_cnd_pag

        /////<summary>
        ///// % de descuento por pronto pago
        /////</summary>
        //public double PtgDctoPp { get; set; } // ptg_dcto_pp
        //public int DiasPrmPag { get; set; } // dias_prm_pag
        //public System.DateTime FecUltCob { get; set; } // fec_ult_cob
        //public double MtoUltCob { get; set; } // mto_ult_cob

        /////<summary>
        ///// dias para que aplique el % de descuento por pronto pago
        /////</summary>
        //public int DiasAPp { get; set; } // dias_a_pp

        /////<summary>
        ///// No de la ultima factura
        /////</summary>
        //public int NoUltFac { get; set; } // no_ult_fac

        /////<summary>
        ///// No del Ultimo cheque
        /////</summary>
        //public int NoUltChq { get; set; } // no_ult_chq

        /////<summary>
        ///// Ventas Año Anterior
        /////</summary>
        //public double VtaAan { get; set; } // vta_aan

        /////<summary>
        ///// Ventas Año a la fecha
        /////</summary>
        //public double VtaAaf { get; set; } // vta_aaf

        /////<summary>
        ///// Ventas Periodo a la fecha
        /////</summary>
        //public double VtaPaf { get; set; } // vta_paf

        /////<summary>
        ///// id de la relación de la dirección alterna
        /////</summary>
        //public int IdRelDa { get; set; } // id_rel_da
        //public double PtgMor { get; set; } // ptg_mor
        //public double MtoMor { get; set; } // mto_mor
        //public int IdMedEnv { get; set; } // id_med_env
        //public int IdImpto { get; set; } // id_impto
        //public int IdBco { get; set; } // id_bco
        //public string Cta { get; set; } // cta (length: 15)
        //public string Clabe { get; set; } // clabe (length: 25)
        //public string IdOtrSis { get; set; } // id_otr_sis (length: 25)
        //public int IdUsr { get; set; } // id_usr
        //public System.DateTime FecReg { get; set; } // fec_reg
        //public int IdRelCar { get; set; } // id_rel_car
        //public int IdEdo { get; set; } // id_edo
        //public int IdPais { get; set; } // id_pais
        //public int IdEmpEje2 { get; set; } // id_emp_eje2
        //public double MtoFin { get; set; } // mto_fin
        //public int IdProv { get; set; } // id_prov
        //public int IdGiro { get; set; } // id_giro
        //public int IdNota { get; set; } // id_nota
        //public int IdRelCtaBco { get; set; } // id_rel_cta_bco
        //public int IdTipTer { get; set; } // id_tip_ter
        //public int IdTipOpe { get; set; } // id_tip_ope
        //public int IdTipInst { get; set; } // id_tip_inst
        //public int IdRelFmto { get; set; } // id_rel_fmto
        //public int IdCliMtz { get; set; } // id_cli_mtz
        //public int CMtz { get; set; } // c_mtz
        //public int IdTipTrnDep { get; set; } // id_tip_trn_dep
        //public int IdTipTrnRet { get; set; } // id_tip_trn_ret
        //public int? NIdCliProceda { get; set; } // nIdCliPROCEDA
        //public int IdTipSocMer { get; set; } // id_tip_soc_mer
        //public byte CValLimCrd { get; set; } // c_val_lim_crd
        //public byte CValDocVenc { get; set; } // c_val_doc_venc
        //public int DiasValVenc { get; set; } // dias_val_venc
        //public int IdRelCliCatProd { get; set; } // id_rel_cli_cat_prod
        //public string Url { get; set; } // url (length: 200)
        //public double PtgValVenc { get; set; } // ptg_val_venc
        //public int IdRelAdd { get; set; } // id_rel_add
        //public byte CParRel { get; set; } // c_par_rel
        //public long IdRelDias { get; set; } // id_rel_dias
        //public int StatusIdRelDias { get; set; } // status_id_rel_dias
        //public int IdCliDist { get; set; } // id_cli_dist
        //public int NumFactor { get; set; } // num_factor

        /////<summary>
        ///// Número de Documento de su respectiva tabla.
        /////</summary>
        //public int TipoCom { get; set; } // tipo_com

        /////<summary>
        ///// Porcentaje de comisión si es por monto documento.
        /////</summary>
        //public double PtgComD { get; set; } // ptg_com_d
        //public int Revision { get; set; } // revision
        //public string Nacionalidad { get; set; } // nacionalidad (length: 40)
        //public string IdFisExt { get; set; } // id_fis_ext (length: 40)
        //public int IdMun { get; set; } // id_mun
        //public int IdLoc { get; set; } // id_loc
        //public int IdCp { get; set; } // id_cp
        //public int IdCol { get; set; } // id_col
        //public bool FluEfe { get; set; } // flu_efe
        //public bool CTimbAnt { get; set; } // c_timb_ant
        //public int IdTipHos { get; set; } // id_tip_hos

        // Reverse navigation

        /// <summary>
        /// Child CatClientesDirs where [cat_clientes_dir].[id_cli] point to this entity (FK_cat_clientes_dir_cat_clientes)
        /// </summary>
       // public virtual System.Collections.Generic.ICollection<CatClientesDir> CatClientesDirs { get; set; } // cat_clientes_dir.FK_cat_clientes_dir_cat_clientes

        public CatCliente()
        {
            //Rfc = "";
            //Email = "";
            //IdClas1 = 0;
            //IdClas2 = 0;
            //Sistema = 0;
            //Status = 99;
            //MtoVta = 0;
            //MtoFac = 0;
            //Saldo = 0;
            //Limite = 0;
            //DctoPtg = 0;
            //SaldoNot = 0;
            //Dias = 0;
            //MtoDevV = 0;
            //MtoDevF = 0;
            //IdAlmCsgn = 0;
            //SaldoConsig = 0;
            //IdVend = 0;
            //Contacto1 = "";
            //Contacto2 = "";
            //IdRelClas = 0;
            //IdMda = 1;
            //TipCli = 0;
            //ApPat = "";
            //ApMat = "";
            //Nombre = "";
            //Calle = "";
            //NumInt = "";
            //NumExt = "";
            //Col = "";
            //Deleg = "";
            //Curp = "";
            //Calles = "";
            //IdCtoCat = 0;
            //IdCliPad = 0;
            //IdCrp = 0;
            //IdEmpCob = 0;
            //IdEmpEje = 0;
            //IdLisPre = 0;
            //DiasFac = "       ";
            //DiasRev = "       ";
            //DiasPag = "       ";
            //HorRev = "0900140016001900";
            //HorPag = "0900140016001900";
            //IdEmp = 0;
            //IdSuc = 0;
            //CDsp = 1;
            //StatusCsl = 1;
            //CDef = 1;
            //IdRelFaDa = 0;
            //IdRelProv = 0;
            //IdCndPag = 0;
            //PtgDctoPp = 0;
            //DiasPrmPag = 0;
            //MtoUltCob = 0;
            //DiasAPp = 0;
            //NoUltFac = 0;
            //NoUltChq = 0;
            //VtaAan = 0;
            //VtaAaf = 0;
            //VtaPaf = 0;
            //IdRelDa = 0;
            //PtgMor = 0;
            //MtoMor = 0;
            //IdMedEnv = 0;
            //IdImpto = 0;
            //IdBco = 0;
            //Cta = "";
            //Clabe = "";
            //IdOtrSis = "";
            //IdUsr = 0;
            //IdRelCar = 0;
            //IdEdo = 0;
            //IdPais = 0;
            //IdEmpEje2 = 0;
            //MtoFin = 0;
            //IdProv = 0;
            //IdGiro = 0;
            //IdNota = 0;
            //IdRelCtaBco = 0;
            //IdTipTer = 0;
            //IdTipOpe = 0;
            //IdTipInst = 0;
            //IdRelFmto = 0;
            //IdCliMtz = 0;
            //CMtz = 0;
            //IdTipTrnDep = 0;
            //IdTipTrnRet = 0;
            //IdTipSocMer = 0;
            //CValLimCrd = 0;
            //CValDocVenc = 0;
            //DiasValVenc = 1;
            //IdRelCliCatProd = 0;
            //Url = "";
            //PtgValVenc = 0;
            //IdRelAdd = 0;
            //CParRel = 0;
            //IdRelDias = 0;
            //StatusIdRelDias = 0;
            //IdCliDist = 0;
            //NumFactor = 0;
            //TipoCom = 0;
            //PtgComD = 0;
            //Revision = 0;
            //Nacionalidad = "";
            //IdFisExt = "";
            //IdMun = 0;
            //IdLoc = 0;
            //IdCp = 0;
            //IdCol = 0;
            //FluEfe = false;
            //CTimbAnt = false;
            //IdTipHos = 0;
            //CatClientesDirs = new System.Collections.Generic.List<CatClientesDir>();
        }
    }

}
// </auto-generated>