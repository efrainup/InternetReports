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

    // SIR_389_SERIES_PENDIENTES_HONDA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir389SeriesPendientesHondaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir389SeriesPendientesHonda>
    {
        public SIR_Sir389SeriesPendientesHondaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir389SeriesPendientesHondaConfiguration(string schema)
        {
            ToTable("SIR_389_SERIES_PENDIENTES_HONDA", schema);
            HasKey(x => x.NIdSeriePendiente389);

            Property(x => x.NIdSeriePendiente389).HasColumnName(@"nIdSeriePendiente389").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SFactura).HasColumnName(@"sFactura").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SContador).HasColumnName(@"sContador").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(3);
            Property(x => x.SPartida).HasColumnName(@"sPartida").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(3);
            Property(x => x.SNumSerie).HasColumnName(@"sNumSerie").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SNumMotor).HasColumnName(@"sNumMotor").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.SNumCaja).HasColumnName(@"sNumCaja").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(7);
        }
    }

}
// </auto-generated>
