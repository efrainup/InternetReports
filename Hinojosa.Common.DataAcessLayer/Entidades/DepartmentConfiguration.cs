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

    // DEPARTMENTS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class DepartmentConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Department>
    {
        public DepartmentConfiguration()
            : this("dbo")
        {
        }

        public DepartmentConfiguration(string schema)
        {
            ToTable("DEPARTMENTS", schema);
            HasKey(x => x.Deptid);

            Property(x => x.Deptid).HasColumnName(@"DEPTID").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Deptname).HasColumnName(@"DEPTNAME").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
            Property(x => x.Supdeptid).HasColumnName(@"SUPDEPTID").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
