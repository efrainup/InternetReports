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

    // SchClass
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SchClassConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SchClass>
    {
        public SchClassConfiguration()
            : this("dbo")
        {
        }

        public SchClassConfiguration(string schema)
        {
            ToTable("SchClass", schema);
            HasKey(x => x.SchClassid);

            Property(x => x.SchClassid).HasColumnName(@"schClassid").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SchName).HasColumnName(@"schName").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20);
            Property(x => x.StartTime).HasColumnName(@"StartTime").HasColumnType("datetime").IsRequired();
            Property(x => x.EndTime).HasColumnName(@"EndTime").HasColumnType("datetime").IsRequired();
            Property(x => x.LateMinutes).HasColumnName(@"LateMinutes").HasColumnType("int").IsOptional();
            Property(x => x.EarlyMinutes).HasColumnName(@"EarlyMinutes").HasColumnType("int").IsOptional();
            Property(x => x.CheckIn).HasColumnName(@"CheckIn").HasColumnType("int").IsOptional();
            Property(x => x.CheckOut).HasColumnName(@"CheckOut").HasColumnType("int").IsOptional();
            Property(x => x.CheckInTime1).HasColumnName(@"CheckInTime1").HasColumnType("datetime").IsOptional();
            Property(x => x.CheckInTime2).HasColumnName(@"CheckInTime2").HasColumnType("datetime").IsOptional();
            Property(x => x.CheckOutTime1).HasColumnName(@"CheckOutTime1").HasColumnType("datetime").IsOptional();
            Property(x => x.CheckOutTime2).HasColumnName(@"CheckOutTime2").HasColumnType("datetime").IsOptional();
            Property(x => x.Color).HasColumnName(@"Color").HasColumnType("int").IsOptional();
            Property(x => x.AutoBind).HasColumnName(@"AutoBind").HasColumnType("smallint").IsOptional();
        }
    }

}
// </auto-generated>