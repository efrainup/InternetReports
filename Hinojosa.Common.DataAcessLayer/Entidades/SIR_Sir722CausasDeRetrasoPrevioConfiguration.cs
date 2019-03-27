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

    // SIR_722_CAUSAS_DE_RETRASO_PREVIO
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir722CausasDeRetrasoPrevioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir722CausasDeRetrasoPrevio>
    {
        public SIR_Sir722CausasDeRetrasoPrevioConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir722CausasDeRetrasoPrevioConfiguration(string schema)
        {
            ToTable("SIR_722_CAUSAS_DE_RETRASO_PREVIO", schema);
            HasKey(x => x.NIdCausaRetrasoPrevio722);

            Property(x => x.NIdCausaRetrasoPrevio722).HasColumnName(@"nIdCausaRetrasoPrevio722").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdPrevRef161).HasColumnName(@"nIdPrevRef161").HasColumnType("int").IsRequired();
            Property(x => x.NIdCausaRetraso429).HasColumnName(@"nIdCausaRetraso429").HasColumnType("int").IsRequired();
            Property(x => x.SObservaciones).HasColumnName(@"sObservaciones").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.NStatus).HasColumnName(@"nStatus").HasColumnType("int").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.DFechaInicio).HasColumnName(@"dFechaInicio").HasColumnType("datetime").IsRequired();
            Property(x => x.DFechaLiberacion).HasColumnName(@"dFechaLiberacion").HasColumnType("datetime").IsOptional();

            // Foreign keys
            HasRequired(a => a.SIR_Sir161ProgPreviosRef).WithMany(b => b.SIR_Sir722CausasDeRetrasoPrevio).HasForeignKey(c => c.NIdPrevRef161).WillCascadeOnDelete(false); // FK_SIR_722_CAUSAS_DE_RETRASO_PREVIO_SIR_161_PROG_PREVIOS_REF
            HasRequired(a => a.SIR_Sir429CausasDeRetraso).WithMany(b => b.SIR_Sir722CausasDeRetrasoPrevio).HasForeignKey(c => c.NIdCausaRetraso429).WillCascadeOnDelete(false); // FK_SIR_722_CAUSAS_DE_RETRASO_PREVIO_SIR_429_CAUSAS_DE_RETRASO
        }
    }

}
// </auto-generated>
