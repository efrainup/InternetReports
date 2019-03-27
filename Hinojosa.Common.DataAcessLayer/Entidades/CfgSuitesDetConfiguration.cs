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

    // cfg_suites_det
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CfgSuitesDetConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CfgSuitesDet>
    {
        public CfgSuitesDetConfiguration()
            : this("dbo")
        {
        }

        public CfgSuitesDetConfiguration(string schema)
        {
            ToTable("cfg_suites_det", schema);
            HasKey(x => x.IdSuiteDet);

            Property(x => x.IdSuiteDet).HasColumnName(@"id_suite_det").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdSuite).HasColumnName(@"id_suite").HasColumnType("int").IsRequired();
            Property(x => x.IdRec).HasColumnName(@"id_rec").HasColumnType("int").IsRequired();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsRequired();
            Property(x => x.FecReg).HasColumnName(@"fec_reg").HasColumnType("datetime").IsRequired();
        }
    }

}
// </auto-generated>
