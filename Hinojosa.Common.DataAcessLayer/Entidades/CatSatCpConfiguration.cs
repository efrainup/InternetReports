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

    // cat_sat_cp
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatSatCpConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatSatCp>
    {
        public CatSatCpConfiguration()
            : this("dbo")
        {
        }

        public CatSatCpConfiguration(string schema)
        {
            ToTable("cat_sat_cp", schema);
            HasKey(x => x.IdCp);

            Property(x => x.IdCp).HasColumnName(@"id_cp").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Cp).HasColumnName(@"cp").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.IdEdo).HasColumnName(@"id_edo").HasColumnType("int").IsRequired();
            Property(x => x.IdMun).HasColumnName(@"id_mun").HasColumnType("int").IsRequired();
            Property(x => x.IdLoc).HasColumnName(@"id_loc").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>
