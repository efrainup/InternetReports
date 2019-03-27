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

    // SIR_161_PROG_PREVIOS_REF
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir161ProgPreviosRef
    {
        [Required]
        [Display(Name = "N ID prev ref 161")]
        public int NIdPrevRef161 { get; set; } // nIdPrevRef161 (Primary key)

        [Display(Name = "N ID referencia 60")]
        public int? NIdReferencia60 { get; set; } // nIdReferencia60

        [Display(Name = "N ID responsable")]
        public int? NIdResponsable { get; set; } // nIdResponsable

        [Display(Name = "N prioridad")]
        public byte? NPrioridad { get; set; } // nPrioridad

        [Display(Name = "N ID tipo previo 132")]
        public int? NIdTipoPrevio132 { get; set; } // nIdTipoPrevio132

        [Required]
        [Display(Name = "D fecha")]
        public System.DateTime DFecha { get; set; } // dFecha

        [Required]
        [Display(Name = "N cantidad")]
        public byte NCantidad { get; set; } // nCantidad

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Display(Name = "N ID usuario ed")]
        public int? NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Required]
        [Display(Name = "N ID suc pat adu 71")]
        public int NIdSucPatAdu71 { get; set; } // nIdSucPatAdu71

        [Display(Name = "N ID bl 74")]
        public int? NIdBl74 { get; set; } // nIdBL74

        [Display(Name = "D fecha rev")]
        public System.DateTime? DFechaRev { get; set; } // dFechaRev

        [DataType(DataType.DateTime)]
        [Display(Name = "D rec inicio")]
        public System.DateTime? DRecInicio { get; set; } // dRecInicio

        [DataType(DataType.DateTime)]
        [Display(Name = "D rec fin")]
        public System.DateTime? DRecFin { get; set; } // dRecFin

        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "S revisa")]
        public string SRevisa { get; set; } // sRevisa (length: 80)

        [Display(Name = "N num previo")]
        public int? NNumPrevio { get; set; } // nNumPrevio

        [Display(Name = "N status")]
        public byte? NStatus { get; set; } // nStatus

        [Display(Name = "B de programacion")]
        public bool? BDeProgramacion { get; set; } // bDeProgramacion

        [Display(Name = "N ID terminal")]
        public int? NIdTerminal { get; set; } // nIdTerminal

        [Display(Name = "N num revisores")]
        public int? NNumRevisores { get; set; } // nNumRevisores

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S ruta archivo")]
        public string SRutaArchivo { get; set; } // sRutaArchivo (length: 500)

        [Display(Name = "N ID entrada 156")]
        public int? NIdEntrada156 { get; set; } // nIdEntrada156

        [Display(Name = "N ID terminal 42")]
        public int? NIdTerminal42 { get; set; } // nIdTerminal42

        [Display(Name = "N ID responsable 02")]
        public int? NIdResponsable02 { get; set; } // nIdResponsable02

        [Display(Name = "N tipo carga")]
        public int? NTipoCarga { get; set; } // nTipoCarga

        [Display(Name = "N ID seccion 158")]
        public int? NIdSeccion158 { get; set; } // nIdSeccion158

        [Display(Name = "N ID ejecutivo")]
        public int? NIdEjecutivo { get; set; } // nIdEjecutivo

        [Display(Name = "N ID ejecutivo 02")]
        public int? NIdEjecutivo02 { get; set; } // nIdEjecutivo02

        [DataType(DataType.DateTime)]
        [Display(Name = "D recepcion expediente")]
        public System.DateTime? DRecepcionExpediente { get; set; } // dRecepcionExpediente

        [DataType(DataType.DateTime)]
        [Display(Name = "D asignacion")]
        public System.DateTime? DAsignacion { get; set; } // dAsignacion

        [DataType(DataType.DateTime)]
        [Display(Name = "D asignacion documentos")]
        public System.DateTime? DAsignacionDocumentos { get; set; } // dAsignacionDocumentos

        [DataType(DataType.DateTime)]
        [Display(Name = "D reasignacion")]
        public System.DateTime? DReasignacion { get; set; } // dReasignacion

        [MaxLength(500)]
        [StringLength(500)]
        [Display(Name = "S motivo reasignacion")]
        public string SMotivoReasignacion { get; set; } // sMotivoReasignacion (length: 500)

        [Display(Name = "N ID tipo docto 62")]
        public int? NIdTipoDocto62 { get; set; } // nIdTipoDocto62

        [Display(Name = "N ID seccion 158 ap")]
        public int? NIdSeccion158Ap { get; set; } // nIdSeccion158AP

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha creacion")]
        public System.DateTime? DFechaCreacion { get; set; } // dFechaCreacion

        [Display(Name = "B confirmar previo")]
        public bool? BConfirmarPrevio { get; set; } // bConfirmarPrevio

        [Display(Name = "N ID usu confirmo")]
        public int? NIdUsuConfirmo { get; set; } // nIdUsuConfirmo

        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha confirmacion")]
        public System.DateTime? DFechaConfirmacion { get; set; } // dFechaConfirmacion

        [Display(Name = "S observacion confirmacion")]
        public string SObservacionConfirmacion { get; set; } // sObservacionConfirmacion

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir160ProgPreviosCont where [SIR_160_PROG_PREVIOS_CONT].[nIdPrevRef161] point to this entity (FK_SIR_160_PROG_PREVIOS_CONT_SIR_161_PROG_PREVIOS_REF)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir160ProgPreviosCont> SIR_Sir160ProgPreviosCont { get; set; } // SIR_160_PROG_PREVIOS_CONT.FK_SIR_160_PROG_PREVIOS_CONT_SIR_161_PROG_PREVIOS_REF
        /// <summary>
        /// Child SIR_Sir162ProgPreviosC where [SIR_162_PROG_PREVIOS_CS].[nIdPrevRef161] point to this entity (FK_SIR_162_PROG_PREVIOS_CS_SIR_161_PROG_PREVIOS_REF)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir162ProgPreviosC> SIR_Sir162ProgPreviosC { get; set; } // SIR_162_PROG_PREVIOS_CS.FK_SIR_162_PROG_PREVIOS_CS_SIR_161_PROG_PREVIOS_REF
        /// <summary>
        /// Child SIR_Sir163ProgPreviosOb where [SIR_163_PROG_PREVIOS_OBS].[nIdPrevRef161] point to this entity (FK_SIR_163_PROG_PREVIOS_OBS_SIR_161_PROG_PREVIOS_REF)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir163ProgPreviosOb> SIR_Sir163ProgPreviosOb { get; set; } // SIR_163_PROG_PREVIOS_OBS.FK_SIR_163_PROG_PREVIOS_OBS_SIR_161_PROG_PREVIOS_REF
        /// <summary>
        /// Child SIR_Sir173PrevioContResultado where [SIR_173_PREVIO_CONT_RESULTADO].[nIdPrevRef161] point to this entity (FK_SIR_173_PREVIO_CONT_RESULTADO_SIR_161_PROG_PREVIOS_REF)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir173PrevioContResultado> SIR_Sir173PrevioContResultado { get; set; } // SIR_173_PREVIO_CONT_RESULTADO.FK_SIR_173_PREVIO_CONT_RESULTADO_SIR_161_PROG_PREVIOS_REF
        /// <summary>
        /// Child SIR_Sir174PrevioCsResultado where [SIR_174_PREVIO_CS_RESULTADO].[nIdPrevRef161] point to this entity (FK_SIR_174_PREVIO_CS_RESULTADO_SIR_161_PROG_PREVIOS_REF)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir174PrevioCsResultado> SIR_Sir174PrevioCsResultado { get; set; } // SIR_174_PREVIO_CS_RESULTADO.FK_SIR_174_PREVIO_CS_RESULTADO_SIR_161_PROG_PREVIOS_REF
        /// <summary>
        /// Child SIR_Sir510CaracteristicaPrevio where [SIR_510_CARACTERISTICA_PREVIO].[nIdPrevRef161] point to this entity (FK_SIR_510_CARACTERISTICA_PREVIO_SIR_161_PROG_PREVIOS_REF)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir510CaracteristicaPrevio> SIR_Sir510CaracteristicaPrevio { get; set; } // SIR_510_CARACTERISTICA_PREVIO.FK_SIR_510_CARACTERISTICA_PREVIO_SIR_161_PROG_PREVIOS_REF
        /// <summary>
        /// Child SIR_Sir675PrevioMovil where [SIR_675_PREVIO_MOVIL].[nIdPrevRef161] point to this entity (FK_SIR_675_PREVIO_MOVIL_SIR_161_PROG_PREVIOS_REF)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir675PrevioMovil> SIR_Sir675PrevioMovil { get; set; } // SIR_675_PREVIO_MOVIL.FK_SIR_675_PREVIO_MOVIL_SIR_161_PROG_PREVIOS_REF
        /// <summary>
        /// Child SIR_Sir722CausasDeRetrasoPrevio where [SIR_722_CAUSAS_DE_RETRASO_PREVIO].[nIdPrevRef161] point to this entity (FK_SIR_722_CAUSAS_DE_RETRASO_PREVIO_SIR_161_PROG_PREVIOS_REF)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir722CausasDeRetrasoPrevio> SIR_Sir722CausasDeRetrasoPrevio { get; set; } // SIR_722_CAUSAS_DE_RETRASO_PREVIO.FK_SIR_722_CAUSAS_DE_RETRASO_PREVIO_SIR_161_PROG_PREVIOS_REF

        // Foreign keys

        /// <summary>
        /// Parent Admin_Admina02Personal pointed by [SIR_161_PROG_PREVIOS_REF].([NIdEjecutivo02]) (FK_SIR_161_PROG_PREVIOS_REF_ADMINA_02_PERSONAL)
        /// </summary>
        public virtual Admin_Admina02Personal Admin_Admina02Personal { get; set; } // FK_SIR_161_PROG_PREVIOS_REF_ADMINA_02_PERSONAL

        /// <summary>
        /// Parent Admin_Adminc42Proveedore pointed by [SIR_161_PROG_PREVIOS_REF].([NIdTerminal42]) (FK_SIR_161_PROG_PREVIOS_REF_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual Admin_Adminc42Proveedore Admin_Adminc42Proveedore { get; set; } // FK_SIR_161_PROG_PREVIOS_REF_ADMINC_42_PROVEEDORES

        /// <summary>
        /// Parent CatEmp pointed by [SIR_161_PROG_PREVIOS_REF].([NIdResponsable]) (FK_SIR_161_PROG_PREVIOS_REF_cat_emp)
        /// </summary>
        public virtual CatEmp CatEmp { get; set; } // FK_SIR_161_PROG_PREVIOS_REF_cat_emp

        /// <summary>
        /// Parent CatProv pointed by [SIR_161_PROG_PREVIOS_REF].([NIdTerminal]) (FK_SIR_161_PROG_PREVIOS_REF_cat_prov)
        /// </summary>
        public virtual CatProv CatProv { get; set; } // FK_SIR_161_PROG_PREVIOS_REF_cat_prov

        /// <summary>
        /// Parent CatUsr pointed by [SIR_161_PROG_PREVIOS_REF].([NIdUsuarioEd]) (FK_SIR_161_PROG_PREVIOS_REF_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_161_PROG_PREVIOS_REF_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir132TipoPrevio pointed by [SIR_161_PROG_PREVIOS_REF].([NIdTipoPrevio132]) (FK_SIR_161_PROG_PREVIOS_REF_SIR_132_TIPO_PREVIO)
        /// </summary>
        public virtual SIR_Sir132TipoPrevio SIR_Sir132TipoPrevio { get; set; } // FK_SIR_161_PROG_PREVIOS_REF_SIR_132_TIPO_PREVIO

        /// <summary>
        /// Parent SIR_Sir158SeccionesNave pointed by [SIR_161_PROG_PREVIOS_REF].([NIdSeccion158]) (FK_SIR_161_PROG_PREVIOS_REF_SIR_158_SECCIONES_NAVES)
        /// </summary>
        public virtual SIR_Sir158SeccionesNave SIR_Sir158SeccionesNave_NIdSeccion158 { get; set; } // FK_SIR_161_PROG_PREVIOS_REF_SIR_158_SECCIONES_NAVES

        /// <summary>
        /// Parent SIR_Sir158SeccionesNave pointed by [SIR_161_PROG_PREVIOS_REF].([NIdSeccion158Ap]) (FK_SIR_161_PROG_PREVIOS_REF_SIR_158_SECCIONES_NAVES_AP)
        /// </summary>
        public virtual SIR_Sir158SeccionesNave SIR_Sir158SeccionesNave_NIdSeccion158Ap { get; set; } // FK_SIR_161_PROG_PREVIOS_REF_SIR_158_SECCIONES_NAVES_AP

        /// <summary>
        /// Parent SIR_Sir60Referencia pointed by [SIR_161_PROG_PREVIOS_REF].([NIdReferencia60]) (FK_SIR_161_PROG_PREVIOS_REF_SIR_60_REFERENCIAS)
        /// </summary>
        public virtual SIR_Sir60Referencia SIR_Sir60Referencia { get; set; } // FK_SIR_161_PROG_PREVIOS_REF_SIR_60_REFERENCIAS

        /// <summary>
        /// Parent SIR_Sir62TiposDocumento pointed by [SIR_161_PROG_PREVIOS_REF].([NIdTipoDocto62]) (FK_SIR_161_PROG_PREVIOS_REF_SIR_62_TIPOS_DOCUMENTOS)
        /// </summary>
        public virtual SIR_Sir62TiposDocumento SIR_Sir62TiposDocumento { get; set; } // FK_SIR_161_PROG_PREVIOS_REF_SIR_62_TIPOS_DOCUMENTOS

        /// <summary>
        /// Parent SIR_Sir71SucursalPatenteAduana pointed by [SIR_161_PROG_PREVIOS_REF].([NIdSucPatAdu71]) (FK_SIR_161_PROG_PREVIOS_REF_SIR_71_SUCURSAL_PATENTE_ADUANA)
        /// </summary>
        public virtual SIR_Sir71SucursalPatenteAduana SIR_Sir71SucursalPatenteAduana { get; set; } // FK_SIR_161_PROG_PREVIOS_REF_SIR_71_SUCURSAL_PATENTE_ADUANA

        /// <summary>
        /// Parent SIR_Sir74ConocimientosMaritimo pointed by [SIR_161_PROG_PREVIOS_REF].([NIdBl74]) (FK_SIR_161_PROG_PREVIOS_REF_SIR_74_CONOCIMIENTOS_MARITIMOS)
        /// </summary>
        public virtual SIR_Sir74ConocimientosMaritimo SIR_Sir74ConocimientosMaritimo { get; set; } // FK_SIR_161_PROG_PREVIOS_REF_SIR_74_CONOCIMIENTOS_MARITIMOS

        public SIR_Sir161ProgPreviosRef()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            BDeProgramacion = true;
            SIR_Sir160ProgPreviosCont = new System.Collections.Generic.List<SIR_Sir160ProgPreviosCont>();
            SIR_Sir162ProgPreviosC = new System.Collections.Generic.List<SIR_Sir162ProgPreviosC>();
            SIR_Sir163ProgPreviosOb = new System.Collections.Generic.List<SIR_Sir163ProgPreviosOb>();
            SIR_Sir173PrevioContResultado = new System.Collections.Generic.List<SIR_Sir173PrevioContResultado>();
            SIR_Sir174PrevioCsResultado = new System.Collections.Generic.List<SIR_Sir174PrevioCsResultado>();
            SIR_Sir510CaracteristicaPrevio = new System.Collections.Generic.List<SIR_Sir510CaracteristicaPrevio>();
            SIR_Sir675PrevioMovil = new System.Collections.Generic.List<SIR_Sir675PrevioMovil>();
            SIR_Sir722CausasDeRetrasoPrevio = new System.Collections.Generic.List<SIR_Sir722CausasDeRetrasoPrevio>();
        }
    }

}
// </auto-generated>
