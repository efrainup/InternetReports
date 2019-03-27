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

    // SIR_155_PREVALIDADORES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir155Prevalidadore
    {
        [Required]
        [Display(Name = "N ID prevalidador 155")]
        public int NIdPrevalidador155 { get; set; } // nIdPrevalidador155 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "S clave")]
        public string SClave { get; set; } // sClave (length: 3)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(80)]
        [StringLength(80)]
        [Display(Name = "S descripcion")]
        public string SDescripcion { get; set; } // sDescripcion (length: 80)

        [Required]
        [DataType(DataType.DateTime)]
        [Display(Name = "D fecha edicion")]
        public System.DateTime DFechaEdicion { get; set; } // dFechaEdicion

        [Required]
        [Display(Name = "N ID usuario ed")]
        public int NIdUsuarioEd { get; set; } // nIdUsuarioEd

        // Reverse navigation

        /// <summary>
        /// Child SIR_Sir228RegistrosSagarpa where [SIR_228_REGISTROS_SAGARPA].[nIdPrevalidador155] point to this entity (FK_SIR_228_REGISTROS_SAGARPA_SIR_155_PREVALIDADORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir228RegistrosSagarpa> SIR_Sir228RegistrosSagarpa { get; set; } // SIR_228_REGISTROS_SAGARPA.FK_SIR_228_REGISTROS_SAGARPA_SIR_155_PREVALIDADORES
        /// <summary>
        /// Child SIR_Sir247ServicioPrevalidacion where [SIR_247_SERVICIO_PREVALIDACION].[nIdPrevalidador155] point to this entity (FK_SIR_247_SERVICIO_PREVALIDACION_SIR_155_PREVALIDADORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir247ServicioPrevalidacion> SIR_Sir247ServicioPrevalidacion { get; set; } // SIR_247_SERVICIO_PREVALIDACION.FK_SIR_247_SERVICIO_PREVALIDACION_SIR_155_PREVALIDADORES
        /// <summary>
        /// Child SIR_Sir762ConfigPagoPrevalidavor where [SIR_762_CONFIG_PAGO_PREVALIDAVOR].[nIdPrevalidador155] point to this entity (FK_SIR_762_CONFIG_PAGO_PREVALIDAVOR_SIR_155_PREVALIDADORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir762ConfigPagoPrevalidavor> SIR_Sir762ConfigPagoPrevalidavor { get; set; } // SIR_762_CONFIG_PAGO_PREVALIDAVOR.FK_SIR_762_CONFIG_PAGO_PREVALIDAVOR_SIR_155_PREVALIDADORES
        /// <summary>
        /// Child SIR_Sir763ClientesPreciosEspPreval where [SIR_763_CLIENTES_PRECIOS_ESP_PREVAL].[nIdPrevalidador155] point to this entity (FK_SIR_763_CLIENTES_PRECIOS_ESP_PREVAL_SIR_155_PREVALIDADORES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<SIR_Sir763ClientesPreciosEspPreval> SIR_Sir763ClientesPreciosEspPreval { get; set; } // SIR_763_CLIENTES_PRECIOS_ESP_PREVAL.FK_SIR_763_CLIENTES_PRECIOS_ESP_PREVAL_SIR_155_PREVALIDADORES

        // Foreign keys

        /// <summary>
        /// Parent CatUsr pointed by [SIR_155_PREVALIDADORES].([NIdUsuarioEd]) (FK_SIR_155_PREVALIDADORES_cat_usr_ed)
        /// </summary>
        public virtual CatUsr CatUsr { get; set; } // FK_SIR_155_PREVALIDADORES_cat_usr_ed

        public SIR_Sir155Prevalidadore()
        {
            DFechaEdicion = System.DateTime.Now;
            NIdUsuarioEd = 0;
            SIR_Sir228RegistrosSagarpa = new System.Collections.Generic.List<SIR_Sir228RegistrosSagarpa>();
            SIR_Sir247ServicioPrevalidacion = new System.Collections.Generic.List<SIR_Sir247ServicioPrevalidacion>();
            SIR_Sir762ConfigPagoPrevalidavor = new System.Collections.Generic.List<SIR_Sir762ConfigPagoPrevalidavor>();
            SIR_Sir763ClientesPreciosEspPreval = new System.Collections.Generic.List<SIR_Sir763ClientesPreciosEspPreval>();
        }
    }

}
// </auto-generated>
