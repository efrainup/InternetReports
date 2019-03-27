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

    // ADMINO_16_DETALLES_CUENTAS_GASTOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Admin_Admino16DetallesCuentasGastoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Admin_Admino16DetallesCuentasGasto>
    {
        public Admin_Admino16DetallesCuentasGastoConfiguration()
            : this("Admin")
        {
        }

        public Admin_Admino16DetallesCuentasGastoConfiguration(string schema)
        {
            ToTable("ADMINO_16_DETALLES_CUENTAS_GASTOS", schema);
            HasKey(x => x.NIdDetCtaGastos16);

            Property(x => x.NIdDetCtaGastos16).HasColumnName(@"nIdDetCtaGastos16").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdCtaGastos15).HasColumnName(@"nIdCtaGastos15").HasColumnType("int").IsRequired();
            Property(x => x.NIdPagoCli13).HasColumnName(@"nIdPagoCli13").HasColumnType("int").IsOptional();
            Property(x => x.NIdPagoCli10).HasColumnName(@"nIdPagoCli10").HasColumnType("int").IsOptional();
            Property(x => x.NIdConcep28).HasColumnName(@"nIdConcep28").HasColumnType("int").IsRequired();
            Property(x => x.DDetalle).HasColumnName(@"dDetalle").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.NImporte).HasColumnName(@"nImporte").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.NIva).HasColumnName(@"nIVA").HasColumnType("money").IsOptional().HasPrecision(19,4);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.NIdReferencia60).HasColumnName(@"nIdReferencia60").HasColumnType("int").IsOptional();
            Property(x => x.NTipoRegistro).HasColumnName(@"nTipoRegistro").HasColumnType("tinyint").IsRequired();
            Property(x => x.NIdSucPatAdu71).HasColumnName(@"nIdSucPatAdu71").HasColumnType("int").IsRequired();
            Property(x => x.NTipoPago).HasColumnName(@"nTipoPago").HasColumnType("tinyint").IsOptional();
            Property(x => x.NIdDetPago09).HasColumnName(@"nIdDetPago09").HasColumnType("int").IsOptional();
            Property(x => x.NIdDetAnticipo12).HasColumnName(@"nIdDetAnticipo12").HasColumnType("int").IsOptional();
            Property(x => x.NIdDetLiquid23).HasColumnName(@"nIdDetLiquid23").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.Admin_Admino09DetallesPagoCliente).WithMany(b => b.Admin_Admino16DetallesCuentasGasto).HasForeignKey(c => c.NIdDetPago09).WillCascadeOnDelete(false); // FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_ADMINO_09_DETALLES_PAGO_CLIENTE
            HasOptional(a => a.Admin_Admino10PagosCliente).WithMany(b => b.Admin_Admino16DetallesCuentasGasto).HasForeignKey(c => c.NIdPagoCli10).WillCascadeOnDelete(false); // FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_ADMINO_10_PAGOS_CLIENTES
            HasOptional(a => a.Admin_Admino12DetallesAnticiposCliente).WithMany(b => b.Admin_Admino16DetallesCuentasGasto).HasForeignKey(c => c.NIdDetAnticipo12).WillCascadeOnDelete(false); // FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_ADMINO_12_DETALLES_ANTICIPOS_CLIENTE
            HasOptional(a => a.Admin_Admino13AnticiposCliente).WithMany(b => b.Admin_Admino16DetallesCuentasGasto).HasForeignKey(c => c.NIdPagoCli13).WillCascadeOnDelete(false); // FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_ADMINO_13_ANTICIPOS_CLIENTES
            HasOptional(a => a.Admin_Admino23DetallesLiquidacione).WithMany(b => b.Admin_Admino16DetallesCuentasGasto).HasForeignKey(c => c.NIdDetLiquid23).WillCascadeOnDelete(false); // FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_ADMINO_23_DETALLES_LIQUIDACIONES
            HasOptional(a => a.SIR_Sir60Referencia).WithMany(b => b.Admin_Admino16DetallesCuentasGasto).HasForeignKey(c => c.NIdReferencia60).WillCascadeOnDelete(false); // FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_SIR_60_REFERENCIAS
            HasRequired(a => a.Admin_Adminc28ConceptosCuenta).WithMany(b => b.Admin_Admino16DetallesCuentasGasto).HasForeignKey(c => c.NIdConcep28).WillCascadeOnDelete(false); // FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_ADMINC_28_CONCEPTOS_CUENTAS
            HasRequired(a => a.Admin_Admino15CuentasGasto).WithMany(b => b.Admin_Admino16DetallesCuentasGasto).HasForeignKey(c => c.NIdCtaGastos15).WillCascadeOnDelete(false); // FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_ADMINO_15_CUENTAS_GASTOS
            HasRequired(a => a.SIR_Sir71SucursalPatenteAduana).WithMany(b => b.Admin_Admino16DetallesCuentasGasto).HasForeignKey(c => c.NIdSucPatAdu71).WillCascadeOnDelete(false); // FK_ADMINO_16_DETALLES_CUENTAS_GASTOS_SIR_71_SUCURSAL_PATENTE_ADUANA
        }
    }

}
// </auto-generated>