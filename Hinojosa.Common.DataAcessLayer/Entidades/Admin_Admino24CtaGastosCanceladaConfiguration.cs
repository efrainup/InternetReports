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

    // ADMINO_24_CTA_GASTOS_CANCELADAS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class Admin_Admino24CtaGastosCanceladaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Admin_Admino24CtaGastosCancelada>
    {
        public Admin_Admino24CtaGastosCanceladaConfiguration()
            : this("Admin")
        {
        }

        public Admin_Admino24CtaGastosCanceladaConfiguration(string schema)
        {
            ToTable("ADMINO_24_CTA_GASTOS_CANCELADAS", schema);
            HasKey(x => x.NIdCtaCancel24);

            Property(x => x.NIdCtaCancel24).HasColumnName(@"nIdCtaCancel24").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdCtaGastos15).HasColumnName(@"nIdCtaGastos15").HasColumnType("int").IsRequired();
            Property(x => x.NIdUsu01).HasColumnName(@"nIdUsu01").HasColumnType("int").IsRequired();
            Property(x => x.DCancelacion).HasColumnName(@"dCancelacion").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.SObservaciones).HasColumnName(@"sObservaciones").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(500);

            // Foreign keys
            HasRequired(a => a.Admin_Admina01Usuario).WithMany(b => b.Admin_Admino24CtaGastosCancelada).HasForeignKey(c => c.NIdUsu01).WillCascadeOnDelete(false); // FK_ADMINO_24_CTA_GASTOS_CANCELADAS_ADMINA_01_USUARIOS
            HasRequired(a => a.Admin_Admino15CuentasGasto).WithMany(b => b.Admin_Admino24CtaGastosCancelada).HasForeignKey(c => c.NIdCtaGastos15).WillCascadeOnDelete(false); // FK_ADMINO_24_CTA_GASTOS_CANCELADAS_ADMINO_15_CUENTAS_GASTOS
        }
    }

}
// </auto-generated>
