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

    // Cat_Terminales
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class CatTerminaleConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<CatTerminale>
    {
        public CatTerminaleConfiguration()
            : this("dbo")
        {
        }

        public CatTerminaleConfiguration(string schema)
        {
            ToTable("Cat_Terminales", schema);
            HasKey(x => x.NIdTerminal);

            Property(x => x.NIdTerminal).HasColumnName(@"nIdTerminal").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SClave).HasColumnName(@"sClave").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(5);
            Property(x => x.STerminal).HasColumnName(@"sTerminal").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(200);
            Property(x => x.SCortoTerminal).HasColumnName(@"sCortoTerminal").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(25);
            Property(x => x.NIdArea).HasColumnName(@"nIdArea").HasColumnType("int").IsOptional();
            Property(x => x.Estado).HasColumnName(@"estado").HasColumnType("int").IsOptional();
        }
    }

}
// </auto-generated>