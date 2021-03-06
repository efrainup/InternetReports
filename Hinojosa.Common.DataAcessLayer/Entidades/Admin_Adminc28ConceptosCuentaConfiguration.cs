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

    // ADMINC_28_CONCEPTOS_CUENTAS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Admin_Adminc28ConceptosCuentaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Admin_Adminc28ConceptosCuenta>
    {
        public Admin_Adminc28ConceptosCuentaConfiguration()
            : this("Admin")
        {
        }

        public Admin_Adminc28ConceptosCuentaConfiguration(string schema)
        {
            ToTable("ADMINC_28_CONCEPTOS_CUENTAS", schema);
            HasKey(x => x.NIdConcep28);

            Property(x => x.NIdConcep28).HasColumnName(@"nIdConcep28").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SConcepto).HasColumnName(@"sConcepto").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(100);
            Property(x => x.NIdTipo09).HasColumnName(@"nIdTipo09").HasColumnType("int").IsOptional();
            Property(x => x.NIdCuenta27).HasColumnName(@"nIdCuenta27").HasColumnType("int").IsOptional();
            Property(x => x.BUnicoReferencia).HasColumnName(@"bUnicoReferencia").HasColumnType("bit").IsRequired();
            Property(x => x.NIdCuentaCierre27).HasColumnName(@"nIdCuentaCierre27").HasColumnType("int").IsOptional();
            Property(x => x.SClave).HasColumnName(@"sClave").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(12);
            Property(x => x.BDepositoGarantia).HasColumnName(@"bDepositoGarantia").HasColumnType("bit").IsOptional();

            // Foreign keys
            HasOptional(a => a.Admin_Adminc09TiposGasto).WithMany(b => b.Admin_Adminc28ConceptosCuenta).HasForeignKey(c => c.NIdTipo09).WillCascadeOnDelete(false); // FK_ADMINC_28_CONCEPTOS_CUENTAS_ADMINC_09_TIPOS_GASTOS
            HasOptional(a => a.Admin_Adminc27Cuenta_NIdCuenta27).WithMany(b => b.Admin_Adminc28ConceptosCuenta_NIdCuenta27).HasForeignKey(c => c.NIdCuenta27).WillCascadeOnDelete(false); // FK_ADMINC_28_CONCEPTOS_CUENTAS_ADMINC_27_CUENTAS
            HasOptional(a => a.Admin_Adminc27Cuenta_NIdCuentaCierre27).WithMany(b => b.Admin_Adminc28ConceptosCuenta_NIdCuentaCierre27).HasForeignKey(c => c.NIdCuentaCierre27).WillCascadeOnDelete(false); // FK_ADMINC_28_CONCEPTOS_CUENTAS_ADMINC_27_CUENTAS_CIERRE
            HasMany(t => t.Admin_Adminc32TiposReferencia).WithMany(t => t.Admin_Adminc28ConceptosCuenta).Map(m =>
            {
                m.ToTable("ADMINC_33_TIPOS_REFERENCIAS_CONCEPTOS", "Admin");
                m.MapLeftKey("nIdConcep28");
                m.MapRightKey("nIdTipRef32");
            });
        }
    }

}
// </auto-generated>
