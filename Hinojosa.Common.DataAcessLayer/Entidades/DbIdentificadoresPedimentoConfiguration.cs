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

    // DB_Identificadores_Pedimento
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class DbIdentificadoresPedimentoConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<DbIdentificadoresPedimento>
    {
        public DbIdentificadoresPedimentoConfiguration()
            : this("dbo")
        {
        }

        public DbIdentificadoresPedimentoConfiguration(string schema)
        {
            ToTable("DB_Identificadores_Pedimento", schema);
            HasKey(x => new { x.SReferencia, x.SClave });

            Property(x => x.SReferencia).HasColumnName(@"sReferencia").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SClave).HasColumnName(@"sClave").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(20).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(250);
            Property(x => x.SComplemento1).HasColumnName(@"sComplemento1").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SComplemento2).HasColumnName(@"sComplemento2").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.SComplemento3).HasColumnName(@"sComplemento3").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
        }
    }

}
// </auto-generated>
