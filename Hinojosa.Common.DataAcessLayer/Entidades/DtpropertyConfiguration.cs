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

    // dtproperties
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class DtpropertyConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Dtproperty>
    {
        public DtpropertyConfiguration()
            : this("dbo")
        {
        }

        public DtpropertyConfiguration(string schema)
        {
            ToTable("dtproperties", schema);
            HasKey(x => new { x.Id, x.Property });

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Objectid).HasColumnName(@"objectid").HasColumnType("int").IsOptional();
            Property(x => x.Property).HasColumnName(@"property").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Value).HasColumnName(@"value").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.Uvalue).HasColumnName(@"uvalue").HasColumnType("nvarchar").IsOptional().HasMaxLength(255);
            Property(x => x.Lvalue).HasColumnName(@"lvalue").HasColumnType("image").IsOptional().HasMaxLength(2147483647);
            Property(x => x.Version).HasColumnName(@"version").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>