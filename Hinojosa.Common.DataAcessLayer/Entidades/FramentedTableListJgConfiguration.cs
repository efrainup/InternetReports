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

    // FramentedTableList_jg
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class FramentedTableListJgConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<FramentedTableListJg>
    {
        public FramentedTableListJgConfiguration()
            : this("dbo")
        {
        }

        public FramentedTableListJgConfiguration(string schema)
        {
            ToTable("FramentedTableList_jg", schema);
            HasKey(x => new { x.IsProcessed, x.FecProcess });

            Property(x => x.TableName).HasColumnName(@"TableName").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
            Property(x => x.AvgFragmentationInPercent).HasColumnName(@"avg_fragmentation_in_percent").HasColumnType("float").IsOptional();
            Property(x => x.IndexName).HasColumnName(@"IndexName").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
            Property(x => x.SchemaName).HasColumnName(@"SchemaName").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
            Property(x => x.IsProcessed).HasColumnName(@"IsProcessed").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.FecProcess).HasColumnName(@"Fec_process").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Pc).HasColumnName(@"pc").HasColumnType("nvarchar").IsOptional().HasMaxLength(128);
        }
    }

}
// </auto-generated>
