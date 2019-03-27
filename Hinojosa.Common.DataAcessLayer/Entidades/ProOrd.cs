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

    // pro_ord
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class ProOrd
    {
        [Required]
        [Display(Name = "Id ord pro")]
        public int IdOrdPro { get; set; } // id_ord_pro (Primary key)

        ///<summary>
        /// Tipo de Documento
        ///</summary>
        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota

        [Required]
        [Display(Name = "Id usr")]
        public int IdUsr { get; set; } // id_usr

        [Required]
        [Display(Name = "Num doc")]
        public int NumDoc { get; set; } // num_doc

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ini")]
        public System.DateTime FecIni { get; set; } // fec_ini

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec venc")]
        public System.DateTime FecVenc { get; set; } // fec_venc

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Referencia")]
        public string Referencia { get; set; } // referencia (length: 25)

        [Required]
        [Display(Name = "Id pro")]
        public int IdPro { get; set; } // id_pro

        [Required]
        [Display(Name = "Pre")]
        public double Pre { get; set; } // pre

        [Required]
        [Display(Name = "Costo")]
        public double Costo { get; set; } // costo

        [Required]
        [Display(Name = "Id alm")]
        public int IdAlm { get; set; } // id_alm

        [Required]
        [Display(Name = "Ordenada")]
        public double Ordenada { get; set; } // ordenada

        [Required]
        [Display(Name = "Reportada")]
        public double Reportada { get; set; } // reportada

        [Required]
        [Display(Name = "Pendiente")]
        public double Pendiente { get; set; } // pendiente

        ///<summary>
        /// Fecha del Ultimo Reporte de Produccion
        ///</summary>
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ur")]
        public System.DateTime FecUr { get; set; } // fec_ur

        ///<summary>
        /// Fecha en que se libero la orden
        ///</summary>
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec lib")]
        public System.DateTime FecLib { get; set; } // fec_lib

        ///<summary>
        /// fecha enn que se cerro la orden
        ///</summary>
        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec cer")]
        public System.DateTime FecCer { get; set; } // fec_cer

        ///<summary>
        /// usuario ultimo que reportó
        ///</summary>
        [Required]
        [Display(Name = "Id usr ur")]
        public int IdUsrUr { get; set; } // id_usr_ur

        ///<summary>
        /// usuario que liberó
        ///</summary>
        [Required]
        [Display(Name = "Id usr lib")]
        public int IdUsrLib { get; set; } // id_usr_lib

        ///<summary>
        /// usuario que cerro la orden
        ///</summary>
        [Required]
        [Display(Name = "Id usr cer")]
        public int IdUsrCer { get; set; } // id_usr_cer

        ///<summary>
        /// Join a tabla de Pedidos
        ///</summary>
        [Required]
        [Display(Name = "Id ped")]
        public int IdPed { get; set; } // id_ped

        ///<summary>
        /// Numero de pedido
        ///</summary>
        [Required]
        [Display(Name = "Num ped")]
        public int NumPed { get; set; } // num_ped

        ///<summary>
        /// 1=No Liberada 2=En Proceso 3=Cerrada 0= Cancelada
        ///</summary>
        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [Display(Name = "Tot reportes")]
        public int TotReportes { get; set; } // tot_reportes

        ///<summary>
        /// id de partida del pedido
        ///</summary>
        [Required]
        [Display(Name = "Id fac det ped")]
        public int IdFacDetPed { get; set; } // id_fac_det_ped

        ///<summary>
        /// id de partida de la solicitud de producto terminado
        ///</summary>
        [Required]
        [Display(Name = "Id fac det spt")]
        public int IdFacDetSpt { get; set; } // id_fac_det_spt

        ///<summary>
        /// numero de solicitud de producto terminado
        ///</summary>
        [Required]
        [Display(Name = "Num spt")]
        public int NumSpt { get; set; } // num_spt

        ///<summary>
        /// numero del pedido del cliente
        ///</summary>
        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Num ped cli")]
        public string NumPedCli { get; set; } // num_ped_cli (length: 25)

        ///<summary>
        /// numero de requisicion del cliente
        ///</summary>
        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Num req cli")]
        public string NumReqCli { get; set; } // num_req_cli (length: 25)

        [Required]
        [Display(Name = "Id emp sol")]
        public int IdEmpSol { get; set; } // id_emp_sol

        [Required]
        [Display(Name = "Id emp rec")]
        public int IdEmpRec { get; set; } // id_emp_rec

        [Required]
        [Display(Name = "Id emp rzo")]
        public int IdEmpRzo { get; set; } // id_emp_rzo

        // Reverse navigation

        /// <summary>
        /// Child ProRptDetTmps where [pro_rpt_det_tmp].[id_orden] point to this entity (FK_pro_rpt_det_tmp_pro_ord)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<ProRptDetTmp> ProRptDetTmps { get; set; } // pro_rpt_det_tmp.FK_pro_rpt_det_tmp_pro_ord

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [pro_ord].([IdUsr]) (FK_pro_ord_cat_usr)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_pro_ord_cat_usr

        public ProOrd()
        {
            IdOrdPro = 0;
            IdTipDoc = 0;
            IdNota = 0;
            IdUsr = 0;
            NumDoc = 0;
            Referencia = "";
            IdPro = 0;
            Ordenada = 0;
            Reportada = 0;
            Pendiente = 0;
            IdUsrUr = 0;
            IdUsrLib = 0;
            IdUsrCer = 0;
            IdPed = 0;
            NumPed = 0;
            Status = 0;
            TotReportes = 0;
            IdFacDetPed = 0;
            IdFacDetSpt = 0;
            NumSpt = 0;
            NumPedCli = "";
            NumReqCli = "";
            IdEmpSol = 0;
            IdEmpRec = 0;
            IdEmpRzo = 0;
            ProRptDetTmps = new System.Collections.Generic.List<ProRptDetTmp>();
        }
    }

}
// </auto-generated>
