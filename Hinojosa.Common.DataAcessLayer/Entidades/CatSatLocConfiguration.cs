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

    // cat_sat_loc
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatSatLocConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatSatLoc>
    {
        public CatSatLocConfiguration()
            : this("dbo")
        {
        }

        public CatSatLocConfiguration(string schema)
        {
            ToTable("cat_sat_loc", schema);
            HasKey(x => x.IdLoc);

            Property(x => x.IdLoc).HasColumnName(@"id_loc").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Loc).HasColumnName(@"loc").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(6);
            Property(x => x.IdEdo).HasColumnName(@"id_edo").HasColumnType("int").IsRequired();
            Property(x => x.Des).HasColumnName(@"des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(125);
        }
    }

}
// </auto-generated>