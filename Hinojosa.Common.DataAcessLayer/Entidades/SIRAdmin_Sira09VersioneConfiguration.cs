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

    // SIRA_09_VERSIONES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIRAdmin_Sira09VersioneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIRAdmin_Sira09Versione>
    {
        public SIRAdmin_Sira09VersioneConfiguration()
            : this("SIRAdmin")
        {
        }

        public SIRAdmin_Sira09VersioneConfiguration(string schema)
        {
            ToTable("SIRA_09_VERSIONES", schema);
            HasKey(x => x.NIdVer09);

            Property(x => x.NIdVer09).HasColumnName(@"nIdVer09").HasColumnType("bigint").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.DFecha).HasColumnName(@"dFecha").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.SVersion).HasColumnName(@"sVersion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(10);
            Property(x => x.BAplicada).HasColumnName(@"bAplicada").HasColumnType("bit").IsRequired();
            Property(x => x.NTipo).HasColumnName(@"nTipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.NVerSistema).HasColumnName(@"nVerSistema").HasColumnType("int").IsRequired();
        }
    }

}
// </auto-generated>