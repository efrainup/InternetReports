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

    // Cat_Fest
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatFestConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatFest>
    {
        public CatFestConfiguration()
            : this("dbo")
        {
        }

        public CatFestConfiguration(string schema)
        {
            ToTable("Cat_Fest", schema);
            HasKey(x => x.IdFest);

            Property(x => x.IdFest).HasColumnName(@"Id_Fest").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.Dia).HasColumnName(@"Dia").HasColumnType("tinyint").IsRequired();
            Property(x => x.Mes).HasColumnName(@"Mes").HasColumnType("tinyint").IsRequired();
            Property(x => x.Des).HasColumnName(@"Des").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Status).HasColumnName(@"Status").HasColumnType("tinyint").IsRequired();
            Property(x => x.FechaAplica).HasColumnName(@"FechaAplica").HasColumnType("datetime").IsRequired();
        }
    }

}
// </auto-generated>
