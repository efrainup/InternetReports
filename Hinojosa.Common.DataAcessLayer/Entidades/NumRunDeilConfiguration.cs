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

    // NUM_RUN_DEIL
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class NumRunDeilConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<NumRunDeil>
    {
        public NumRunDeilConfiguration()
            : this("dbo")
        {
        }

        public NumRunDeilConfiguration(string schema)
        {
            ToTable("NUM_RUN_DEIL", schema);
            HasKey(x => new { x.NumRunid, x.Sdays, x.Starttime });

            Property(x => x.NumRunid).HasColumnName(@"NUM_RUNID").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Starttime).HasColumnName(@"STARTTIME").HasColumnType("datetime").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Endtime).HasColumnName(@"ENDTIME").HasColumnType("datetime").IsOptional();
            Property(x => x.Sdays).HasColumnName(@"SDAYS").HasColumnType("smallint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Edays).HasColumnName(@"EDAYS").HasColumnType("smallint").IsOptional();
            Property(x => x.Schclassid).HasColumnName(@"SCHCLASSID").HasColumnType("int").IsOptional();
        }
    }

}
// </auto-generated>
