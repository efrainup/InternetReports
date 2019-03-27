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

    // SIR_418_NOTIFICACION_PROGRAMACION
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir418NotificacionProgramacionConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir418NotificacionProgramacion>
    {
        public SIR_Sir418NotificacionProgramacionConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir418NotificacionProgramacionConfiguration(string schema)
        {
            ToTable("SIR_418_NOTIFICACION_PROGRAMACION", schema);
            HasKey(x => x.NIdNotificacionProg418);

            Property(x => x.NIdNotificacionProg418).HasColumnName(@"nIdNotificacionProg418").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdNotificacion416).HasColumnName(@"nIdNotificacion416").HasColumnType("int").IsRequired();
            Property(x => x.NTipoProg).HasColumnName(@"nTipoProg").HasColumnType("int").IsRequired();
            Property(x => x.NHora).HasColumnName(@"nHora").HasColumnType("int").IsRequired();
            Property(x => x.NMinuto).HasColumnName(@"nMinuto").HasColumnType("int").IsRequired();
            Property(x => x.NDia).HasColumnName(@"nDia").HasColumnType("int").IsOptional();
            Property(x => x.NDiaSemana).HasColumnName(@"nDiaSemana").HasColumnType("int").IsOptional();
            Property(x => x.BPrimeroMes).HasColumnName(@"bPrimeroMes").HasColumnType("bit").IsOptional();
            Property(x => x.BUltimoMes).HasColumnName(@"bUltimoMes").HasColumnType("bit").IsOptional();
            Property(x => x.BRangoFechas).HasColumnName(@"bRangoFechas").HasColumnType("bit").IsOptional();
            Property(x => x.NInicio).HasColumnName(@"nInicio").HasColumnType("int").IsOptional();
            Property(x => x.NFin).HasColumnName(@"nFin").HasColumnType("int").IsOptional();
            Property(x => x.NFrecuencia).HasColumnName(@"nFrecuencia").HasColumnType("int").IsOptional();

            // Foreign keys
            HasRequired(a => a.SIR_Sir416Notificacione).WithMany(b => b.SIR_Sir418NotificacionProgramacion).HasForeignKey(c => c.NIdNotificacion416).WillCascadeOnDelete(false); // FK_SIR_418_NOTIFICACION_PROGRAMACION_SIR_416_NOTIFICACIONES
        }
    }

}
// </auto-generated>
