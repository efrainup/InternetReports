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

    // SIR_589_BITACORA_CARGA_TERMINAL
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir589BitacoraCargaTerminalConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir589BitacoraCargaTerminal>
    {
        public SIR_Sir589BitacoraCargaTerminalConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir589BitacoraCargaTerminalConfiguration(string schema)
        {
            ToTable("SIR_589_BITACORA_CARGA_TERMINAL", schema);
            HasKey(x => x.NIdBitacora589);

            Property(x => x.NIdBitacora589).HasColumnName(@"nIdBitacora589").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdPeriodo588).HasColumnName(@"nIdPeriodo588").HasColumnType("int").IsRequired();
            Property(x => x.NIdTerminal).HasColumnName(@"nIdTerminal").HasColumnType("int").IsOptional();
            Property(x => x.NIdTerminal42).HasColumnName(@"nIdTerminal42").HasColumnType("int").IsOptional();
            Property(x => x.NTonImpoCs).HasColumnName(@"nTonImpoCS").HasColumnType("decimal").IsOptional().HasPrecision(18,2);
            Property(x => x.NTonExpoCs).HasColumnName(@"nTonExpoCS").HasColumnType("decimal").IsOptional().HasPrecision(18,2);
            Property(x => x.NTonImpoC20).HasColumnName(@"nTonImpoC20").HasColumnType("decimal").IsOptional().HasPrecision(18,2);
            Property(x => x.NTonExpoC20).HasColumnName(@"nTonExpoC20").HasColumnType("decimal").IsOptional().HasPrecision(18,2);
            Property(x => x.NTonImpoC40).HasColumnName(@"nTonImpoC40").HasColumnType("decimal").IsOptional().HasPrecision(18,2);
            Property(x => x.NTonExpoC40).HasColumnName(@"nTonExpoC40").HasColumnType("decimal").IsOptional().HasPrecision(18,2);

            // Foreign keys
            HasOptional(a => a.Admin_Adminc42Proveedore).WithMany(b => b.SIR_Sir589BitacoraCargaTerminal).HasForeignKey(c => c.NIdTerminal42).WillCascadeOnDelete(false); // FK_SIR_589_BITACORA_CARGA_TERMINAL_ADMINC_42_PROVEEDORES
            HasRequired(a => a.SIR_Sir588PeriodoCargaTerminal).WithMany(b => b.SIR_Sir589BitacoraCargaTerminal).HasForeignKey(c => c.NIdPeriodo588).WillCascadeOnDelete(false); // FK_SIR_589_BITACORA_CARGA_TERMINAL_SIR_588_PERIODO_CARGA_TERMINAL
        }
    }

}
// </auto-generated>
