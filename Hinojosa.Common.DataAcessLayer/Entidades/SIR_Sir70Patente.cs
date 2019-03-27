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

    // SIR_70_PATENTES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir70Patente
    {
        [Required]
        [Display(Name = "N ID patente 70")]
        public int NIdPatente70 { get; set; } // nIdPatente70 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(4)]
        [StringLength(4)]
        [Display(Name = "S patente")]
        public string SPatente { get; set; } // sPatente (length: 4)

        [MaxLength(40)]
        [StringLength(40)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 40)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        [Display(Name = "N ID agente aduanal")]
        public int? NIdAgenteAduanal { get; set; } // nIdAgenteAduanal

        [Display(Name = "N ID agente aduanal 02")]
        public int? NIdAgenteAduanal02 { get; set; } // nIdAgenteAduanal02

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir228RegistrosSagarpa where [SIR_228_REGISTROS_SAGARPA].[nIdPatente70] point to this entity (FK_SIR_228_REGISTROS_SAGARPA_SIR_70_PATENTES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir228RegistrosSagarpa> SIR_Sir228RegistrosSagarpa { get; set; } // SIR_228_REGISTROS_SAGARPA.FK_SIR_228_REGISTROS_SAGARPA_SIR_70_PATENTES
        /// <summary>
        /// Child SIR_Sir244ArchivosPago where [SIR_244_ARCHIVOS_PAGOS].[nIdPatente70] point to this entity (FK_SIR_244_ARCHIVO_PAGO_SIR_70_PATENTES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir244ArchivosPago> SIR_Sir244ArchivosPago { get; set; } // SIR_244_ARCHIVOS_PAGOS.FK_SIR_244_ARCHIVO_PAGO_SIR_70_PATENTES
        /// <summary>
        /// Child SIR_Sir249EncargoConferido where [SIR_249_ENCARGO_CONFERIDO].[nIdPatente70] point to this entity (FK_SIR_249_ENCARGO_CONFERIDO_SIR_70_PATENTES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir249EncargoConferido> SIR_Sir249EncargoConferido { get; set; } // SIR_249_ENCARGO_CONFERIDO.FK_SIR_249_ENCARGO_CONFERIDO_SIR_70_PATENTES
        /// <summary>
        /// Child SIR_Sir290RectificPedimento where [SIR_290_RECTIFIC_PEDIMENTO].[nIdPatente70] point to this entity (FK_SIR_290_RECTIFIC_PEDIMENTO_SIR_70_PATENTES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir290RectificPedimento> SIR_Sir290RectificPedimento { get; set; } // SIR_290_RECTIFIC_PEDIMENTO.FK_SIR_290_RECTIFIC_PEDIMENTO_SIR_70_PATENTES
        /// <summary>
        /// Child SIR_Sir293ExtraccionPedimento where [SIR_293_EXTRACCION_PEDIMENTOS].[nIdPatente70] point to this entity (FK_SIR_293_EXTRACCION_PEDIMENTOS_SIR_70_PATENTES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir293ExtraccionPedimento> SIR_Sir293ExtraccionPedimento { get; set; } // SIR_293_EXTRACCION_PEDIMENTOS.FK_SIR_293_EXTRACCION_PEDIMENTOS_SIR_70_PATENTES
        /// <summary>
        /// Child SIR_Sir294CompensacionesPedimento where [SIR_294_COMPENSACIONES_PEDIMENTO].[nIdPatente70] point to this entity (FK_SIR_294_COMPENSACIONES_PEDIMENTO_SIR_70_PATENTES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir294CompensacionesPedimento> SIR_Sir294CompensacionesPedimento { get; set; } // SIR_294_COMPENSACIONES_PEDIMENTO.FK_SIR_294_COMPENSACIONES_PEDIMENTO_SIR_70_PATENTES
        /// <summary>
        /// Child SIR_Sir301Archivos001 where [SIR_301_ARCHIVOS_001].[nIdPatente70] point to this entity (FK_SIR_301_ARCHIVOS_001_SIR_70_PATENTES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir301Archivos001> SIR_Sir301Archivos001 { get; set; } // SIR_301_ARCHIVOS_001.FK_SIR_301_ARCHIVOS_001_SIR_70_PATENTES
        /// <summary>
        /// Child SIR_Sir316ArchivosKeyAa where [SIR_316_ARCHIVOS_KEY_AA].[nIdPatente70] point to this entity (FK_SIR_316_ARCHIVOS_KEY_AA_SIR_70_PATENTES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir316ArchivosKeyAa> SIR_Sir316ArchivosKeyAa { get; set; } // SIR_316_ARCHIVOS_KEY_AA.FK_SIR_316_ARCHIVOS_KEY_AA_SIR_70_PATENTES
        /// <summary>
        /// Child SIR_Sir344ApartadosPedimento where [SIR_344_APARTADOS_PEDIMENTOS].[nIdPatente70] point to this entity (FK_SIR_344_APARTADOS_PEDIMENTOS_SIR_70_PATENTES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir344ApartadosPedimento> SIR_Sir344ApartadosPedimento { get; set; } // SIR_344_APARTADOS_PEDIMENTOS.FK_SIR_344_APARTADOS_PEDIMENTOS_SIR_70_PATENTES
        /// <summary>
        /// Child SIR_Sir72PatentesRepresentante where [SIR_72_PATENTES_REPRESENTANTES].[nIdPatente70] point to this entity (FK_SIR_72_PATENTES_REPRESENTANTES_SIR_70_PATENTES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir72PatentesRepresentante> SIR_Sir72PatentesRepresentante { get; set; } // SIR_72_PATENTES_REPRESENTANTES.FK_SIR_72_PATENTES_REPRESENTANTES_SIR_70_PATENTES
        /// <summary>
        /// Child SIRAdmin_Sira18Consecutivo where [SIRA_18_CONSECUTIVOS].[nIdPatente70] point to this entity (FK_SIRA_18_CONSECUTIVOS_SIR_70_PATENTES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira18Consecutivo> SIRAdmin_Sira18Consecutivo { get; set; } // SIRA_18_CONSECUTIVOS.FK_SIRA_18_CONSECUTIVOS_SIR_70_PATENTES
        /// <summary>
        /// Child SIRAdmin_Sira61FirmaAaCliente where [SIRA_61_FIRMA_AA_CLIENTE].[nIdPatente70] point to this entity (FK_SIRA_61_FIRMA_AA_CLIENTE_SIR_70_PATENTES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIRAdmin_Sira61FirmaAaCliente> SIRAdmin_Sira61FirmaAaCliente { get; set; } // SIRA_61_FIRMA_AA_CLIENTE.FK_SIRA_61_FIRMA_AA_CLIENTE_SIR_70_PATENTES

        // Foreign keys

        /// <summary>
        /// Parent Admin_Admina02Personal pointed by [SIR_70_PATENTES].([NIdAgenteAduanal02]) (FK_SIR_70_PATENTES_ADMINA_02_PERSONAL)
        /// </summary>
        public virtual Admin_Admina02Personal Admin_Admina02Personal { get; set; } // FK_SIR_70_PATENTES_ADMINA_02_PERSONAL

        /// <summary>
        /// Parent CatEmp pointed by [SIR_70_PATENTES].([NIdAgenteAduanal]) (FK_SIR_70_PATENTES_cat_emp)
        /// </summary>
        public virtual CatEmp CatEmp { get; set; } // FK_SIR_70_PATENTES_cat_emp

        /// <summary>
        /// Parent CatUsr pointed by [SIR_70_PATENTES].([NIdUsuarioEd]) (FK_SIR_70_PATENTES_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_70_PATENTES_cat_usr_ed

        public SIR_Sir70Patente()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            SIR_Sir228RegistrosSagarpa = new System.Collections.Generic.List<SIR_Sir228RegistrosSagarpa>();
            SIR_Sir244ArchivosPago = new System.Collections.Generic.List<SIR_Sir244ArchivosPago>();
            SIR_Sir249EncargoConferido = new System.Collections.Generic.List<SIR_Sir249EncargoConferido>();
            SIR_Sir290RectificPedimento = new System.Collections.Generic.List<SIR_Sir290RectificPedimento>();
            SIR_Sir293ExtraccionPedimento = new System.Collections.Generic.List<SIR_Sir293ExtraccionPedimento>();
            SIR_Sir294CompensacionesPedimento = new System.Collections.Generic.List<SIR_Sir294CompensacionesPedimento>();
            SIR_Sir301Archivos001 = new System.Collections.Generic.List<SIR_Sir301Archivos001>();
            SIR_Sir316ArchivosKeyAa = new System.Collections.Generic.List<SIR_Sir316ArchivosKeyAa>();
            SIR_Sir344ApartadosPedimento = new System.Collections.Generic.List<SIR_Sir344ApartadosPedimento>();
            SIR_Sir72PatentesRepresentante = new System.Collections.Generic.List<SIR_Sir72PatentesRepresentante>();
            SIRAdmin_Sira18Consecutivo = new System.Collections.Generic.List<SIRAdmin_Sira18Consecutivo>();
            SIRAdmin_Sira61FirmaAaCliente = new System.Collections.Generic.List<SIRAdmin_Sira61FirmaAaCliente>();
        }
    }

}
// </auto-generated>
