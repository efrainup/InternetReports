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

    // sis_rel_adu
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisRelAduConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisRelAdu>
    {
        public SisRelAduConfiguration()
            : this("dbo")
        {
        }

        public SisRelAduConfiguration(string schema)
        {
            ToTable("sis_rel_adu", schema);
            HasKey(x => x.IdRelAdu);

            Property(x => x.IdRelAdu).HasColumnName(@"id_rel_adu").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.NIdAduSec06).HasColumnName(@"nIdAduSec06").HasColumnType("int").IsOptional();
            Property(x => x.IdAduSat).HasColumnName(@"id_adu_sat").HasColumnType("int").IsOptional();
            Property(x => x.Status).HasColumnName(@"status").HasColumnType("tinyint").IsOptional();
        }
    }

}
// </auto-generated>
