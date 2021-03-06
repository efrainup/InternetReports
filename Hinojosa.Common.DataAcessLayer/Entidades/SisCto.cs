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

    // sis_cto
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisCto
    {

        ///<summary>
        /// Primary Key
        ///</summary>
        [Required]
        [Display(Name = "Id cto")]
        public int IdCto { get; set; } // id_cto (Primary key)

        ///<summary>
        /// id del contacto asociado a un catalogo
        ///</summary>
        [Required]
        [Display(Name = "Id cto cat")]
        public int IdCtoCat { get; set; } // id_cto_cat

        [Required]
        [Display(Name = "Num cto")]
        public int NumCto { get; set; } // num_cto

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Nom")]
        public string Nom { get; set; } // nom (length: 80)

        [Required]
        [Display(Name = "Id depto")]
        public int IdDepto { get; set; } // id_depto

        [Required]
        [Display(Name = "Id puesto")]
        public int IdPuesto { get; set; } // id_puesto

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Tel 1")]
        public string Tel1 { get; set; } // tel1 (length: 30)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Tel 2")]
        public string Tel2 { get; set; } // tel2 (length: 30)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(200)]
        [StringLength(200)]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; } // email (length: 200)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec nac")]
        public System.DateTime FecNac { get; set; } // fec_nac

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec ani")]
        public System.DateTime FecAni { get; set; } // fec_ani

        ///<summary>
        /// 1=Clientes 2=Proveedores 3=Corporativos
        ///</summary>
        [Required]
        [Display(Name = "Tipo")]
        public byte Tipo { get; set; } // tipo

        ///<summary>
        /// 1=Indica que ya se ha usado en algun documento por lo tanto no se puede eliminar el contacto
        ///</summary>
        [Required]
        [Display(Name = "C uso")]
        public byte CUso { get; set; } // c_uso

        [Required(AllowEmptyStrings = true)]
        [MaxLength(10)]
        [StringLength(10)]
        [Display(Name = "Titulo")]
        public string Titulo { get; set; } // titulo (length: 10)

        [Required]
        [Display(Name = "Cod pais")]
        public int CodPais { get; set; } // cod_pais

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Ap pat")]
        public string ApPat { get; set; } // ap_pat (length: 25)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(25)]
        [StringLength(25)]
        [Display(Name = "Ap mat")]
        public string ApMat { get; set; } // ap_mat (length: 25)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "Nombres")]
        public string Nombres { get; set; } // nombres (length: 30)

        ///<summary>
        /// 1=A el se dirigen los documentos
        ///</summary>
        [Required]
        [Display(Name = "C dirig")]
        public byte CDirig { get; set; } // c_dirig

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fec reg")]
        public System.DateTime FecReg { get; set; } // fec_reg

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Dir")]
        public string Dir { get; set; } // dir (length: 255)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(90)]
        [StringLength(90)]
        [Display(Name = "Calle")]
        public string Calle { get; set; } // calle (length: 90)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "Ciudad")]
        public string Ciudad { get; set; } // ciudad (length: 80)

        [Required]
        [Display(Name = "Cod edo")]
        public byte CodEdo { get; set; } // cod_edo

        [Required(AllowEmptyStrings = true)]
        [MaxLength(5)]
        [StringLength(5)]
        [Display(Name = "Cod pos")]
        public string CodPos { get; set; } // cod_pos (length: 5)

        [Required]
        [Display(Name = "Id pais")]
        public int IdPais { get; set; } // id_pais

        [Required]
        [Display(Name = "Uso email")]
        public byte UsoEmail { get; set; } // uso_email

        // Reverse navigation

        /// <summary>
        /// Parent (One-to-One) SisCto pointed by [sis_cto].[id_cto] (FK_sis_cto_sis_cto)
        /// </summary>
        public virtual SisCto SisCto2 { get; set; } // sis_cto.FK_sis_cto_sis_cto
        /// <summary>
        /// Child VtaFacEncs where [vta_fac_enc].[id_cto] point to this entity (FK_vta_fac_enc_sis_cto)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<VtaFacEnc> VtaFacEncs { get; set; } // vta_fac_enc.FK_vta_fac_enc_sis_cto

        // Foreign keys

        /// <summary>
        /// Parent SisCto pointed by [sis_cto].([IdCto]) (FK_sis_cto_sis_cto)
        /// </summary>
        public virtual SisCto SisCto1 { get; set; } // FK_sis_cto_sis_cto

        public SisCto()
        {
            IdCto = 0;
            IdCtoCat = 0;
            NumCto = 0;
            Nom = "";
            IdDepto = 0;
            IdPuesto = 0;
            Tel1 = "";
            Tel2 = "";
            Email = "";
            Tipo = 1;
            CUso = 0;
            Titulo = "";
            CodPais = 0;
            ApPat = "";
            ApMat = "";
            Nombres = "";
            CDirig = 0;
            Status = 1;
            FecReg = System.DateTime.Now;
            Dir = "";
            Calle = "";
            Ciudad = "";
            CodEdo = 0;
            CodPos = "";
            IdPais = 0;
            UsoEmail = 0;
            VtaFacEncs = new System.Collections.Generic.List<VtaFacEnc>();
        }
    }

}
// </auto-generated>
