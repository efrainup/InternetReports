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

    // TBL_DASHBOARDS_QRYS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class TblDashboardsQryConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<TblDashboardsQry>
    {
        public TblDashboardsQryConfiguration()
            : this("dbo")
        {
        }

        public TblDashboardsQryConfiguration(string schema)
        {
            ToTable("TBL_DASHBOARDS_QRYS", schema);
            HasKey(x => x.Id);

            Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdQry).HasColumnName(@"id_qry").HasColumnType("int").IsRequired();
            Property(x => x.IdDash).HasColumnName(@"id_dash").HasColumnType("int").IsRequired();
            Property(x => x.Nom).HasColumnName(@"nom").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.Sql).HasColumnName(@"sql").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
        }
    }

}
// </auto-generated>