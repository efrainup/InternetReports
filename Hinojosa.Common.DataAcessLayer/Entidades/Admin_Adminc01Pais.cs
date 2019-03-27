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

    // ADMINC_01_PAISES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Admin_Adminc01Pais
    {
        [Required]
        [Display(Name = "N ID pais 01")]
        public int NIdPais01 { get; set; } // nIdPais01 (Primary key)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "S clave")]
        public string SClave { get; set; } // sClave (length: 3)

        [Required(AllowEmptyStrings = true)]
        [MaxLength(72)]
        [StringLength(72)]
        [Display(Name = "S nombre")]
        public string SNombre { get; set; } // sNombre (length: 72)

        [Display(Name = "N ID moneda 03")]
        public int? NIdMoneda03 { get; set; } // nIdMoneda03

        [Display(Name = "N clave")]
        public int? NClave { get; set; } // nClave

        [MaxLength(2)]
        [StringLength(2)]
        [Display(Name = "S clave alpha 2")]
        public string SClaveAlpha2 { get; set; } // sClaveAlpha2 (length: 2)

        [MaxLength(3)]
        [StringLength(3)]
        [Display(Name = "S clave alpha 3")]
        public string SClaveAlpha3 { get; set; } // sClaveAlpha3 (length: 3)

        [Required]
        [Display(Name = "B status")]
        public bool BStatus { get; set; } // bStatus

        [Display(Name = "N tratado")]
        public byte? NTratado { get; set; } // nTratado

        [MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "S nacionalidad")]
        public string SNacionalidad { get; set; } // sNacionalidad (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child Admin_Admina12Sucursale where [ADMINA_12_SUCURSALES].[nIdPais01] point to this entity (FK_ADMINA_12_SUCURSALES_ADMINC_01_PAISES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Admin_Admina12Sucursale> Admin_Admina12Sucursale { get; set; } // ADMINA_12_SUCURSALES.FK_ADMINA_12_SUCURSALES_ADMINC_01_PAISES
        /// <summary>
        /// Child Admin_Adminc02EntidadesFederativa where [ADMINC_02_ENTIDADES_FEDERATIVAS].[nIdPais01] point to this entity (FK_ADMINC_02_ENTIDADES_FEDERATIVAS_ADMINC_01_PAISES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Admin_Adminc02EntidadesFederativa> Admin_Adminc02EntidadesFederativa { get; set; } // ADMINC_02_ENTIDADES_FEDERATIVAS.FK_ADMINC_02_ENTIDADES_FEDERATIVAS_ADMINC_01_PAISES
        /// <summary>
        /// Child Admin_Adminc04Puerto where [ADMINC_04_PUERTOS].[nIdPais01] point to this entity (FK_ADMINC_04_PUERTOS_ADMINC_01_PAISES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Admin_Adminc04Puerto> Admin_Adminc04Puerto { get; set; } // ADMINC_04_PUERTOS.FK_ADMINC_04_PUERTOS_ADMINC_01_PAISES
        /// <summary>
        /// Child Admin_Adminc47ClientesDir where [ADMINC_47_CLIENTES_DIR].[nIdPais01] point to this entity (FK_ADMINC_47_CLIENTES_DIR_ADMINC_01_PAISES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Admin_Adminc47ClientesDir> Admin_Adminc47ClientesDir { get; set; } // ADMINC_47_CLIENTES_DIR.FK_ADMINC_47_CLIENTES_DIR_ADMINC_01_PAISES
        /// <summary>
        /// Child Admin_Admino15CuentasGasto where [ADMINO_15_CUENTAS_GASTOS].[nIdPais01] point to this entity (FK_ADMINO_15_CUENTAS_GASTOS_ADMINC_01_PAISES)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<Admin_Admino15CuentasGasto> Admin_Admino15CuentasGasto { get; set; } // ADMINO_15_CUENTAS_GASTOS.FK_ADMINO_15_CUENTAS_GASTOS_ADMINC_01_PAISES

        // Foreign keys

        /// <summary>
        /// Parent Admin_Adminc03Moneda pointed by [ADMINC_01_PAISES].([NIdMoneda03]) (FK_ADMINC_01_PAISES_ADMINC_03_MONEDAS)
        /// </summary>
        public virtual Admin_Adminc03Moneda Admin_Adminc03Moneda { get; set; } // FK_ADMINC_01_PAISES_ADMINC_03_MONEDAS

        public Admin_Adminc01Pais()
        {
            Admin_Admina12Sucursale = new System.Collections.Generic.List<Admin_Admina12Sucursale>();
            Admin_Adminc02EntidadesFederativa = new System.Collections.Generic.List<Admin_Adminc02EntidadesFederativa>();
            Admin_Adminc04Puerto = new System.Collections.Generic.List<Admin_Adminc04Puerto>();
            Admin_Adminc47ClientesDir = new System.Collections.Generic.List<Admin_Adminc47ClientesDir>();
            Admin_Admino15CuentasGasto = new System.Collections.Generic.List<Admin_Admino15CuentasGasto>();
        }
    }

}
// </auto-generated>