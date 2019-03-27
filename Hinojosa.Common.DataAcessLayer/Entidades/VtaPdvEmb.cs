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

    // vta_pdv_emb
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class VtaPdvEmb
    {
        [Required]
        [Display(Name = "Id rel emb ped")]
        public int IdRelEmbPed { get; set; } // id_rel_emb_ped (Primary key)

        [Required]
        [Display(Name = "Id vta aux")]
        public int IdVtaAux { get; set; } // id_vta_aux (Primary key)

        [Required]
        [Display(Name = "Id vta pdv")]
        public int IdVtaPdv { get; set; } // id_vta_pdv (Primary key)

        [Required]
        [Display(Name = "Cant ent")]
        public double CantEnt { get; set; } // cant_ent (Primary key)

        [Required]
        [Display(Name = "Tip ent")]
        public int TipEnt { get; set; } // tip_ent (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ent")]
        public System.DateTime FecEnt { get; set; } // fec_ent (Primary key)

        [Required]
        [Display(Name = "Id cli emb")]
        public int IdCliEmb { get; set; } // id_cli_emb (Primary key)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Nom cli emb")]
        public string NomCliEmb { get; set; } // nom_cli_emb (Primary key)

        [Required]
        [Display(Name = "Id dir emb")]
        public int IdDirEmb { get; set; } // id_dir_emb (Primary key)

        [Required(AllowEmptyStrings = true)]
        [Display(Name = "Dir ent")]
        public string DirEnt { get; set; } // dir_ent (Primary key)

        [Required]
        [Display(Name = "Id med env")]
        public int IdMedEnv { get; set; } // id_med_env (Primary key)

        [Required]
        [Display(Name = "Id almac")]
        public int IdAlmac { get; set; } // id_almac (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Calle")]
        public string Calle { get; set; } // calle (Primary key) (length: 80)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Num ext")]
        public string NumExt { get; set; } // num_ext (Primary key) (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(13)]
        [StringLength(13)]
        [Display(Name = "Num int")]
        public string NumInt { get; set; } // num_int (Primary key) (length: 13)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Cp")]
        public string Cp { get; set; } // cp (Primary key) (length: 10)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Calles")]
        public string Calles { get; set; } // calles (Primary key) (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Col")]
        public string Col { get; set; } // col (Primary key) (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Deleg")]
        public string Deleg { get; set; } // deleg (Primary key) (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Ciu")]
        public string Ciu { get; set; } // ciu (Primary key) (length: 80)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Pais")]
        public string Pais { get; set; } // pais (Primary key) (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Estado")]
        public string Estado { get; set; } // estado (Primary key) (length: 50)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Teldom")]
        public string Teldom { get; set; } // teldom (Primary key) (length: 30)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Telcel")]
        public string Telcel { get; set; } // telcel (Primary key) (length: 30)

        [Required]
        [Display(Name = "Surt status")]
        public int SurtStatus { get; set; } // surt_status (Primary key)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec surt emb")]
        public System.DateTime FecSurtEmb { get; set; } // fec_surt_emb (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Entrego")]
        public string Entrego { get; set; } // entrego (Primary key) (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Recibio")]
        public string Recibio { get; set; } // recibio (Primary key) (length: 40)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(200)]
        [StringLength(200)]
        [Display(Name = "Obs surt")]
        public string ObsSurt { get; set; } // obs_surt (Primary key) (length: 200)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg ent emb")]
        public System.DateTime FecRegEntEmb { get; set; } // fec_reg_ent_emb (Primary key)

        [Required]
        [Display(Name = "Id usr ent emb")]
        public int IdUsrEntEmb { get; set; } // id_usr_ent_emb (Primary key)

        [Required]
        [Display(Name = "Id viaje")]
        public int IdViaje { get; set; } // id_viaje (Primary key)

        [Required]
        [Display(Name = "Num viaje")]
        public int NumViaje { get; set; } // num_viaje (Primary key)

        [Required]
        [Display(Name = "Id suc ent")]
        public int IdSucEnt { get; set; } // id_suc_ent (Primary key)

        [Required]
        [Display(Name = "Status viaje")]
        public int StatusViaje { get; set; } // status_viaje (Primary key)

        [Required]
        [Display(Name = "Id nota")]
        public int IdNota { get; set; } // id_nota (Primary key)

        [Required]
        [Display(Name = "Id nota e")]
        public int IdNotaE { get; set; } // id_nota_e (Primary key)

        [Required]
        [Display(Name = "No part vta")]
        public int NoPartVta { get; set; } // no_part_vta (Primary key)

        [Required]
        [Display(Name = "Id tip doc")]
        public int IdTipDoc { get; set; } // id_tip_doc (Primary key)

        [Required]
        [Display(Name = "Costo sal")]
        public double CostoSal { get; set; } // costo_sal (Primary key)

        public VtaPdvEmb()
        {
            IdVtaAux = 0;
            IdVtaPdv = 0;
            CantEnt = 0;
            TipEnt = 0;
            IdCliEmb = 0;
            NomCliEmb = "";
            IdDirEmb = 0;
            DirEnt = "";
            IdMedEnv = 0;
            IdAlmac = 0;
            Calle = "";
            NumExt = "";
            NumInt = "";
            Cp = "";
            Calles = "";
            Col = "";
            Deleg = "";
            Ciu = "";
            Pais = "";
            Estado = "";
            Teldom = "";
            Telcel = "";
            SurtStatus = 0;
            Entrego = "";
            Recibio = "";
            ObsSurt = "";
            IdUsrEntEmb = 0;
            IdViaje = 0;
            NumViaje = 0;
            IdSucEnt = 0;
            StatusViaje = 0;
            IdNota = 0;
            IdNotaE = 0;
            NoPartVta = 0;
            IdTipDoc = 0;
            CostoSal = 0.00;
        }
    }

}
// </auto-generated>