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

    // Pase_DocumentoLaser
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class PaseDocumentoLaserConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<PaseDocumentoLaser>
    {
        public PaseDocumentoLaserConfiguration()
            : this("dbo")
        {
        }

        public PaseDocumentoLaserConfiguration(string schema)
        {
            ToTable("Pase_DocumentoLaser", schema);
            HasKey(x => x.NIdLaserDocumento);

            Property(x => x.NIdLaserDocumento).HasColumnName(@"nIdLaserDocumento").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdReferencia).HasColumnName(@"nIdReferencia").HasColumnType("int").IsRequired();
            Property(x => x.NIdDocumento).HasColumnName(@"nIdDocumento").HasColumnType("int").IsRequired();
            Property(x => x.BEsta).HasColumnName(@"bEsta").HasColumnType("bit").IsOptional();
        }
    }

}
// </auto-generated>