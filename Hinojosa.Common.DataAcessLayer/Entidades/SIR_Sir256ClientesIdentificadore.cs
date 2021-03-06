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

    // SIR_256_CLIENTES_IDENTIFICADORES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir256ClientesIdentificadore
    {
        [Required]
        [Display(Name = "N ID cli ident 256")]
        public int NIdCliIdent256 { get; set; } // nIdCliIdent256 (Primary key)

        [Required]
        [Display(Name = "N ID iden perm 69")]
        public int NIdIdenPerm69 { get; set; } // nIdIdenPerm69

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S complemento 1")]
        public string SComplemento1 { get; set; } // sComplemento1 (length: 30)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S complemento 2")]
        public string SComplemento2 { get; set; } // sComplemento2 (length: 30)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S complemento 3")]
        public string SComplemento3 { get; set; } // sComplemento3 (length: 30)

        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "S firma descargo")]
        public string SFirmaDescargo { get; set; } // sFirmaDescargo (length: 40)

        [MaxLength(30)]
        [StringLength(30)]
        [Display(Name = "S numero")]
        public string SNumero { get; set; } // sNumero (length: 30)

        [Required]
        [Display(Name = "N cantidad mcia")]
        public decimal NCantidadMcia { get; set; } // nCantidadMcia

        [Required]
        [Display(Name = "N valor dolares")]
        public decimal NValorDolares { get; set; } // nValorDolares

        [Required]
        [Display(Name = "N nivel")]
        public byte NNivel { get; set; } // nNivel

        [MaxLength(15)]
        [StringLength(15)]
        [Display(Name = "S certificado")]
        public string SCertificado { get; set; } // sCertificado (length: 15)

        [Required]
        [Display(Name = "B excepcion cert")]
        public bool BExcepcionCert { get; set; } // bExcepcionCert

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Display(Name = "D inicio")]
        public System.DateTime? DInicio { get; set; } // dInicio

        [Display(Name = "D fin")]
        public System.DateTime? DFin { get; set; } // dFin

        [Display(Name = "N ID cli iden 289")]
        public int? NIdCliIden289 { get; set; } // nIdCliIden289

        [Display(Name = "N ID fracc 167")]
        public int? NIdFracc167 { get; set; } // nIdFracc167

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_256_CLIENTES_IDENTIFICADORES].([NIdUsuarioEd]) (FK_SIR_256_CLIENTES_IDENTIFICADORES_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_256_CLIENTES_IDENTIFICADORES_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir167FraccionesArancelaria pointed by [SIR_256_CLIENTES_IDENTIFICADORES].([NIdFracc167]) (FK_SIR_256_CLIENTES_IDENTIFICADORES_SIR_167_FRACCIONES_ARANCELARIAS)
        /// </summary>
        public virtual SIR_Sir167FraccionesArancelaria SIR_Sir167FraccionesArancelaria { get; set; } // FK_SIR_256_CLIENTES_IDENTIFICADORES_SIR_167_FRACCIONES_ARANCELARIAS

        /// <summary>
        /// Parent SIR_Sir289MtraClientesIdent pointed by [SIR_256_CLIENTES_IDENTIFICADORES].([NIdCliIden289]) (FK_SIR_256_CLIENTES_IDENTIFICADORES_SIR_289_MTRA_CLIENTES_IDENT)
        /// </summary>
        public virtual SIR_Sir289MtraClientesIdent SIR_Sir289MtraClientesIdent { get; set; } // FK_SIR_256_CLIENTES_IDENTIFICADORES_SIR_289_MTRA_CLIENTES_IDENT

        /// <summary>
        /// Parent SIR_Sir69IdentificadorPermiso pointed by [SIR_256_CLIENTES_IDENTIFICADORES].([NIdIdenPerm69]) (FK_SIR_256_CLIENTES_IDENTIFICADORES_SIR_69_IDENTIFICADOR_PERMISOS)
        /// </summary>
        public virtual SIR_Sir69IdentificadorPermiso SIR_Sir69IdentificadorPermiso { get; set; } // FK_SIR_256_CLIENTES_IDENTIFICADORES_SIR_69_IDENTIFICADOR_PERMISOS

        public SIR_Sir256ClientesIdentificadore()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
        }
    }

}
// </auto-generated>
