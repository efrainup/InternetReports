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

    // Pase_Envio_ErrorLF
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class PaseEnvioErrorLfConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PaseEnvioErrorLf>
    {
        public PaseEnvioErrorLfConfiguration()
            : this("dbo")
        {
        }

        public PaseEnvioErrorLfConfiguration(string schema)
        {
            ToTable("Pase_Envio_ErrorLF", schema);
            HasKey(x => x.IdError);

            Property(x => x.IdError).HasColumnName(@"idError").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.SReferencia).HasColumnName(@"sReferencia").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(15);
            Property(x => x.SError).HasColumnName(@"sError").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(255);
            Property(x => x.SFechaError).HasColumnName(@"sFechaError").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(30);
        }
    }

}
// </auto-generated>
