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

    // SIR_403_ETAPAS_REFERENCIA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir403EtapasReferenciaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir403EtapasReferencia>
    {
        public SIR_Sir403EtapasReferenciaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir403EtapasReferenciaConfiguration(string schema)
        {
            ToTable("SIR_403_ETAPAS_REFERENCIA", schema);
            HasKey(x => new { x.NIdEtapa401, x.NIdReferencia60 });

            Property(x => x.NIdEtapa401).HasColumnName(@"nIdEtapa401").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdReferencia60).HasColumnName(@"nIdReferencia60").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DInicio).HasColumnName(@"dInicio").HasColumnType("datetime").IsOptional();
            Property(x => x.DTermino).HasColumnName(@"dTermino").HasColumnType("datetime").IsOptional();
            Property(x => x.NStatus).HasColumnName(@"nStatus").HasColumnType("tinyint").IsOptional();
            Property(x => x.NDuracion).HasColumnName(@"nDuracion").HasColumnType("int").IsOptional();
            Property(x => x.NOrden).HasColumnName(@"nOrden").HasColumnType("tinyint").IsOptional();
            Property(x => x.BManual).HasColumnName(@"bManual").HasColumnType("bit").IsOptional();
            Property(x => x.DManual).HasColumnName(@"dManual").HasColumnType("datetime").IsOptional();
            Property(x => x.IdUsuarioManual).HasColumnName(@"IdUsuarioManual").HasColumnType("int").IsOptional();
            Property(x => x.NIdEtapaPlantilla401).HasColumnName(@"nIdEtapaPlantilla401").HasColumnType("int").IsOptional();

            // Foreign keys
            HasRequired(a => a.SIR_Sir401Etapa).WithMany(b => b.SIR_Sir403EtapasReferencia).HasForeignKey(c => c.NIdEtapa401).WillCascadeOnDelete(false); // FK_SIR_403_ETAPAS_REFERENCIA_SIR_401_ETAPAS
            HasRequired(a => a.SIR_Sir60Referencia).WithMany(b => b.SIR_Sir403EtapasReferencia).HasForeignKey(c => c.NIdReferencia60).WillCascadeOnDelete(false); // FK_SIR_403_ETAPAS_REFERENCIA_SIR_60_REFERENCIAS
        }
    }

}
// </auto-generated>