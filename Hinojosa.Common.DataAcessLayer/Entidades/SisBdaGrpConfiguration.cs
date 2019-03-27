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

    // sis_bda_grp
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SisBdaGrpConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SisBdaGrp>
    {
        public SisBdaGrpConfiguration()
            : this("dbo")
        {
        }

        public SisBdaGrpConfiguration(string schema)
        {
            ToTable("sis_bda_grp", schema);
            HasKey(x => x.IdBdaGrp);

            Property(x => x.IdBdaGrp).HasColumnName(@"id_bda_grp").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IdGrp).HasColumnName(@"id_grp").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
