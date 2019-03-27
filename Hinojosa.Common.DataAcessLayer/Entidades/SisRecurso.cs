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

    // sis_recursos
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisRecurso
    {
        [Required]
        [Display(Name = "Id rec")]
        public int IdRec { get; set; } // id_rec (Primary key)

        [MaxLength(85)]
        [StringLength(85)]
        [Display(Name = "Des")]
        public string Des { get; set; } // des (length: 85)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "Mod")]
        public string Mod { get; set; } // mod (length: 2)

        [Required]
        [Display(Name = "Status")]
        public byte Status { get; set; } // status

        [Required]
        [Display(Name = "Id mod")]
        public int IdMod { get; set; } // id_mod

        ///<summary>
        /// 1=Formulario 3=Subrutina 5=EXE 2 = Stored Procedure
        ///</summary>
        [Required]
        [Display(Name = "Tipo")]
        public byte Tipo { get; set; } // tipo

        [Required(AllowEmptyStrings = true)]
        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Frm")]
        public string Frm { get; set; } // frm (length: 50)

        [Required]
        [Display(Name = "Id img")]
        public int IdImg { get; set; } // id_img

        [Required]
        [Display(Name = "Id rec pad")]
        public int IdRecPad { get; set; } // id_rec_pad

        [Required(AllowEmptyStrings = true)]
        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "Orden")]
        public string Orden { get; set; } // orden (length: 40)

        [Required]
        [Display(Name = "Modo")]
        public byte Modo { get; set; } // modo

        [Required]
        [Display(Name = "Nivel")]
        public byte Nivel { get; set; } // Nivel

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Descripcion")]
        public string Descripcion { get; set; } // descripcion (length: 255)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(255)]
        [StringLength(255)]
        [Display(Name = "Ruta")]
        public string Ruta { get; set; } // ruta (length: 255)

        [Required]
        [Display(Name = "Sis ori")]
        public byte SisOri { get; set; } // sis_ori

        [Required]
        [Display(Name = "Habilitado")]
        public byte Habilitado { get; set; } // habilitado

        [Required(AllowEmptyStrings = true)]
        [MaxLength(60)]
        [StringLength(60)]
        [Display(Name = "Ensamblado")]
        public string Ensamblado { get; set; } // ensamblado (length: 60)

        [Required]
        [Display(Name = "Id tbl")]
        public int IdTbl { get; set; } // id_tbl

        [Required]
        [Display(Name = "Es mod logistica")]
        public bool EsModLogistica { get; set; } // esModLogistica

        [Required]
        [Display(Name = "B enviar ap roceda")]
        public bool BEnviarAProceda { get; set; } // bEnviarAProceda

        [Required]
        [Display(Name = "Vis cmp")]
        public byte VisCmp { get; set; } // vis_cmp

        // Reverse navigation

        /// <summary>
        /// Child CatUsrs (Many-to-Many) mapped by table [SIRA_08_USUARIO_FAVORITOS]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<CatUsr> CatUsrs { get; set; } // Many to many mapping
        /// <summary>
        /// Child SIR_Sir360CaracteristicasModulo where [SIR_360_CARACTERISTICAS_MODULOS].[nIdNodo] point to this entity (FK_SIR_360_CARACTERISTICAS_MODULOS_sis_recursos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir360CaracteristicasModulo> SIR_Sir360CaracteristicasModulo { get; set; } // SIR_360_CARACTERISTICAS_MODULOS.FK_SIR_360_CARACTERISTICAS_MODULOS_sis_recursos
        /// <summary>
        /// Child SIR_Sir38ModulosActividade where [SIR_38_MODULOS_ACTIVIDADES].[nIdNodoActual] point to this entity (FK_SIR_38_MODULOS_ACTIVIDADES_sis_recursos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir38ModulosActividade> SIR_Sir38ModulosActividade_NIdNodoActual { get; set; } // SIR_38_MODULOS_ACTIVIDADES.FK_SIR_38_MODULOS_ACTIVIDADES_sis_recursos
        /// <summary>
        /// Child SIR_Sir38ModulosActividade where [SIR_38_MODULOS_ACTIVIDADES].[nIdNodoDestino] point to this entity (FK_SIR_38_MODULOS_ACTIVIDADES_sis_recursos2)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir38ModulosActividade> SIR_Sir38ModulosActividade_NIdNodoDestino { get; set; } // SIR_38_MODULOS_ACTIVIDADES.FK_SIR_38_MODULOS_ACTIVIDADES_sis_recursos2
        /// <summary>
        /// Child SIR_Sir38ModulosActividade where [SIR_38_MODULOS_ACTIVIDADES].[nIdNodoOrigen] point to this entity (FK_SIR_38_MODULOS_ACTIVIDADES_sis_recursos1)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir38ModulosActividade> SIR_Sir38ModulosActividade_NIdNodoOrigen { get; set; } // SIR_38_MODULOS_ACTIVIDADES.FK_SIR_38_MODULOS_ACTIVIDADES_sis_recursos1
        /// <summary>
        /// Child SIR_Sir83TiposFecha where [SIR_83_TIPOS_FECHAS].[nIdNodo] point to this entity (FK_SIR_83_TIPOS_FECHAS_sis_recursos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir83TiposFecha> SIR_Sir83TiposFecha { get; set; } // SIR_83_TIPOS_FECHAS.FK_SIR_83_TIPOS_FECHAS_sis_recursos
        /// <summary>
        /// Child SIRAdmin_Sira03ColoresMonitore where [SIRA_03_COLORES_MONITORES].[nIdNodo] point to this entity (FK_SIRA_03_COLORES_MONITORES_sis_recursos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira03ColoresMonitore> SIRAdmin_Sira03ColoresMonitore { get; set; } // SIRA_03_COLORES_MONITORES.FK_SIRA_03_COLORES_MONITORES_sis_recursos
        /// <summary>
        /// Child SIRAdmin_Sira07PrivilegiosUsuario where [SIRA_07_PRIVILEGIOS_USUARIOS].[nIdNodo] point to this entity (FK_SIRA_07_PRIVILEGIOS_USUARIOS_sis_recursos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira07PrivilegiosUsuario> SIRAdmin_Sira07PrivilegiosUsuario { get; set; } // SIRA_07_PRIVILEGIOS_USUARIOS.FK_SIRA_07_PRIVILEGIOS_USUARIOS_sis_recursos
        /// <summary>
        /// Child SIRAdmin_Sira13ControlesSistema where [SIRA_13_CONTROLES_SISTEMA].[nIdModulo] point to this entity (FK_SIRA_13_CONTROLES_SISTEMA_sis_recursos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira13ControlesSistema> SIRAdmin_Sira13ControlesSistema { get; set; } // SIRA_13_CONTROLES_SISTEMA.FK_SIRA_13_CONTROLES_SISTEMA_sis_recursos
        /// <summary>
        /// Child SIRAdmin_Sira19ControlesOperativo (Many-to-Many) mapped by table [SIR_126_MOD_CTR_OPERATIVAS]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira19ControlesOperativo> SIRAdmin_Sira19ControlesOperativo { get; set; } // Many to many mapping
        /// <summary>
        /// Child SIRAdmin_Sira92ModulosTipotrafico where [SIRA_92_MODULOS_TIPOTRAFICO].[nIdNodo] point to this entity (FK_SIRA_92_MODULOS_TIPOTRAFICO_sis_recursos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira92ModulosTipotrafico> SIRAdmin_Sira92ModulosTipotrafico { get; set; } // SIRA_92_MODULOS_TIPOTRAFICO.FK_SIRA_92_MODULOS_TIPOTRAFICO_sis_recursos
        /// <summary>
        /// Child SIRWEB_Sw06UsuarioWebaccess (Many-to-Many) mapped by table [SW_09_USUARIO_WEBACCESS_NODOS]
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRWEB_Sw06UsuarioWebaccess> SIRWEB_Sw06UsuarioWebaccess { get; set; } // Many to many mapping
        /// <summary>
        /// Child SisAccesoes where [sis_accesos].[id_rec] point to this entity (FK_sis_accesos_sis_recursos)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SisAcceso> SisAccesoes { get; set; } // sis_accesos.FK_sis_accesos_sis_recursos

        public SisRecurso()
        {
            IdRec = 0;
            Des = "";
            Mod = "";
            Status = 1;
            IdMod = 0;
            Tipo = 0;
            Frm = "";
            IdImg = 0;
            IdRecPad = 0;
            Orden = "";
            Modo = 0;
            Nivel = 0;
            Descripcion = "";
            BEnviarAProceda = false;
            VisCmp = 0;
            SIR_Sir360CaracteristicasModulo = new System.Collections.Generic.List<SIR_Sir360CaracteristicasModulo>();
            SIR_Sir38ModulosActividade_NIdNodoActual = new System.Collections.Generic.List<SIR_Sir38ModulosActividade>();
            SIR_Sir38ModulosActividade_NIdNodoDestino = new System.Collections.Generic.List<SIR_Sir38ModulosActividade>();
            SIR_Sir38ModulosActividade_NIdNodoOrigen = new System.Collections.Generic.List<SIR_Sir38ModulosActividade>();
            SIR_Sir83TiposFecha = new System.Collections.Generic.List<SIR_Sir83TiposFecha>();
            SIRAdmin_Sira03ColoresMonitore = new System.Collections.Generic.List<SIRAdmin_Sira03ColoresMonitore>();
            SIRAdmin_Sira07PrivilegiosUsuario = new System.Collections.Generic.List<SIRAdmin_Sira07PrivilegiosUsuario>();
            SIRAdmin_Sira13ControlesSistema = new System.Collections.Generic.List<SIRAdmin_Sira13ControlesSistema>();
            SIRAdmin_Sira92ModulosTipotrafico = new System.Collections.Generic.List<SIRAdmin_Sira92ModulosTipotrafico>();
            SisAccesoes = new System.Collections.Generic.List<SisAcceso>();
            SIRAdmin_Sira19ControlesOperativo = new System.Collections.Generic.List<SIRAdmin_Sira19ControlesOperativo>();
            CatUsrs = new System.Collections.Generic.List<CatUsr>();
            SIRWEB_Sw06UsuarioWebaccess = new System.Collections.Generic.List<SIRWEB_Sw06UsuarioWebaccess>();
        }
    }

}
// </auto-generated>