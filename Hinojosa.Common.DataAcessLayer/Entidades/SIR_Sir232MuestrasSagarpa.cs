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

    // SIR_232_MUESTRAS_SAGARPA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir232MuestrasSagarpa
    {
        [Required]
        [Display(Name = "N ID muestra 232")]
        public int NIdMuestra232 { get; set; } // nIdMuestra232 (Primary key)

        [Required]
        [Display(Name = "B requiere fac")]
        public bool BRequiereFac { get; set; } // bRequiereFac

        [Required]
        [Display(Name = "N tipo muestra")]
        public byte NTipoMuestra { get; set; } // nTipoMuestra

        [Display(Name = "N ID lab sagar 02")]
        public int? NIdLabSagar02 { get; set; } // nIdLabSagar02

        [Display(Name = "N nombre de")]
        public int? NNombreDe { get; set; } // nNombreDe

        [Display(Name = "N ID proveedor 42")]
        public int? NIdProveedor42 { get; set; } // nIdProveedor42

        [Display(Name = "N ID cliente")]
        public int? NIdCliente { get; set; } // nIdCliente

        [Display(Name = "N ID estado")]
        public int? NIdEstado { get; set; } // nIdEstado

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S municipio")]
        public string SMunicipio { get; set; } // sMunicipio (length: 100)

        [Display(Name = "N ID uso prod 17")]
        public int? NIdUsoProd17 { get; set; } // nIdUsoProd17

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S variedad producto")]
        public string SVariedadProducto { get; set; } // sVariedadProducto (length: 100)

        [MaxLength(100)]
        [StringLength(100)]
        [Display(Name = "S analisis")]
        public string SAnalisis { get; set; } // sAnalisis (length: 100)

        [Display(Name = "N monto pagado")]
        public decimal? NMontoPagado { get; set; } // nMontoPagado

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S clave cie")]
        public string SClaveCie { get; set; } // sClaveCIE (length: 20)

        [Display(Name = "N cantidad muestras")]
        public int? NCantidadMuestras { get; set; } // nCantidadMuestras

        [Display(Name = "D fecha pago")]
        public System.DateTime? DFechaPago { get; set; } // dFechaPago

        [MaxLength(20)]
        [StringLength(20)]
        [Display(Name = "S numero cuenta")]
        public string SNumeroCuenta { get; set; } // sNumeroCuenta (length: 20)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Display(Name = "N ID clie 07")]
        public int? NIdClie07 { get; set; } // nIdClie07

        [Display(Name = "N ID ent fed 02")]
        public int? NIdEntFed02 { get; set; } // nIdEntFed02

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir229PartidasAgrupSagarpa where [SIR_229_PARTIDAS_AGRUP_SAGARPA].[nIdMuestra232] point to this entity (FK_SIR_229_PARTIDAS_AGRUP_SAGARPA_SIR_232_MUESTRAS_SAGARPA)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir229PartidasAgrupSagarpa> SIR_Sir229PartidasAgrupSagarpa { get; set; } // SIR_229_PARTIDAS_AGRUP_SAGARPA.FK_SIR_229_PARTIDAS_AGRUP_SAGARPA_SIR_232_MUESTRAS_SAGARPA

        // Foreign keys

        /// <summary>
        /// Parent Admin_Adminc02EntidadesFederativa pointed by [SIR_232_MUESTRAS_SAGARPA].([NIdEntFed02]) (FK_SIR_232_MUESTRAS_SAGARPA_ADMINC_42_PROVEEDORES)
        /// </summary>
        public virtual Admin_Adminc02EntidadesFederativa Admin_Adminc02EntidadesFederativa { get; set; } // FK_SIR_232_MUESTRAS_SAGARPA_ADMINC_42_PROVEEDORES

        /// <summary>
        /// Parent Admin_Adminc07Cliente pointed by [SIR_232_MUESTRAS_SAGARPA].([NIdClie07]) (FK_SIR_232_MUESTRAS_SAGARPA_ADMINC_07_CLIENTES)
        /// </summary>
        public virtual Admin_Adminc07Cliente Admin_Adminc07Cliente { get; set; } // FK_SIR_232_MUESTRAS_SAGARPA_ADMINC_07_CLIENTES

        /// <summary>
        /// Parent CatCliente pointed by [SIR_232_MUESTRAS_SAGARPA].([NIdCliente]) (FK_SIR_232_MUESTRAS_SAGARPA_cat_clientes)
        /// </summary>
        public virtual CatCliente CatCliente { get; set; } // FK_SIR_232_MUESTRAS_SAGARPA_cat_clientes

        /// <summary>
        /// Parent CatEdo pointed by [SIR_232_MUESTRAS_SAGARPA].([NIdEstado]) (FK_SIR_232_MUESTRAS_SAGARPA_cat_edos)
        /// </summary>
        public virtual CatEdo CatEdo { get; set; } // FK_SIR_232_MUESTRAS_SAGARPA_cat_edos

        /// <summary>
        /// Parent CatUsr pointed by [SIR_232_MUESTRAS_SAGARPA].([NIdUsuarioEd]) (FK_SIR_232_MUESTRAS_SAGARPA_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_232_MUESTRAS_SAGARPA_cat_usr_ed

        /// <summary>
        /// Parent SIR_Sir02LaboratoriosSagar pointed by [SIR_232_MUESTRAS_SAGARPA].([NIdLabSagar02]) (FK_SIR_232_MUESTRAS_SAGARPA_SIR_02_LABORATORIOS_SAGAR)
        /// </summary>
        public virtual SIR_Sir02LaboratoriosSagar SIR_Sir02LaboratoriosSagar { get; set; } // FK_SIR_232_MUESTRAS_SAGARPA_SIR_02_LABORATORIOS_SAGAR

        /// <summary>
        /// Parent SIR_Sir17UsoProducto pointed by [SIR_232_MUESTRAS_SAGARPA].([NIdUsoProd17]) (FK_SIR_232_MUESTRAS_SAGARPA_SIR_17_USO_PRODUCTO)
        /// </summary>
        public virtual SIR_Sir17UsoProducto SIR_Sir17UsoProducto { get; set; } // FK_SIR_232_MUESTRAS_SAGARPA_SIR_17_USO_PRODUCTO

        /// <summary>
        /// Parent SIR_Sir42Proveedore pointed by [SIR_232_MUESTRAS_SAGARPA].([NIdProveedor42]) (FK_SIR_232_MUESTRAS_SAGARPA_SIR_42_PROVEEDORES)
        /// </summary>
        public virtual SIR_Sir42Proveedore SIR_Sir42Proveedore { get; set; } // FK_SIR_232_MUESTRAS_SAGARPA_SIR_42_PROVEEDORES

        public SIR_Sir232MuestrasSagarpa()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            SIR_Sir229PartidasAgrupSagarpa = new System.Collections.Generic.List<SIR_Sir229PartidasAgrupSagarpa>();
        }
    }

}
// </auto-generated>
