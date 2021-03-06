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

    // CHECKEXACT
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CheckexactConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Checkexact>
    {
        public CheckexactConfiguration()
            : this("dbo")
        {
        }

        public CheckexactConfiguration(string schema)
        {
            ToTable("CHECKEXACT", schema);
            HasKey(x => x.Exactid);

            Property(x => x.Exactid).HasColumnName(@"EXACTID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Userid).HasColumnName(@"USERID").HasColumnType("int").IsOptional();
            Property(x => x.Checktime).HasColumnName(@"CHECKTIME").HasColumnType("datetime").IsOptional();
            Property(x => x.Checktype).HasColumnName(@"CHECKTYPE").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(2);
            Property(x => x.Isadd).HasColumnName(@"ISADD").HasColumnType("smallint").IsOptional();
            Property(x => x.Yuyin).HasColumnName(@"YUYIN").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(25);
            Property(x => x.Ismodify).HasColumnName(@"ISMODIFY").HasColumnType("smallint").IsOptional();
            Property(x => x.Isdelete).HasColumnName(@"ISDELETE").HasColumnType("smallint").IsOptional();
            Property(x => x.Incount).HasColumnName(@"INCOUNT").HasColumnType("smallint").IsOptional();
            Property(x => x.Iscount).HasColumnName(@"ISCOUNT").HasColumnType("smallint").IsOptional();
            Property(x => x.Modifyby).HasColumnName(@"MODIFYBY").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(20);
            Property(x => x.Date).HasColumnName(@"DATE").HasColumnType("datetime").IsOptional();
        }
    }

}
// </auto-generated>
