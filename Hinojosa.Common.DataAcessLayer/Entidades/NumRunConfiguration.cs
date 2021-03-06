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

    // NUM_RUN
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class NumRunConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<NumRun>
    {
        public NumRunConfiguration()
            : this("dbo")
        {
        }

        public NumRunConfiguration(string schema)
        {
            ToTable("NUM_RUN", schema);
            HasKey(x => x.NumRunid);

            Property(x => x.NumRunid).HasColumnName(@"NUM_RUNID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Oldid).HasColumnName(@"OLDID").HasColumnType("int").IsOptional();
            Property(x => x.Name).HasColumnName(@"NAME").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Startdate).HasColumnName(@"STARTDATE").HasColumnType("datetime").IsOptional();
            Property(x => x.Enddate).HasColumnName(@"ENDDATE").HasColumnType("datetime").IsOptional();
            Property(x => x.Cyle).HasColumnName(@"CYLE").HasColumnType("smallint").IsOptional();
            Property(x => x.Units).HasColumnName(@"UNITS").HasColumnType("smallint").IsOptional();
        }
    }

}
// </auto-generated>
