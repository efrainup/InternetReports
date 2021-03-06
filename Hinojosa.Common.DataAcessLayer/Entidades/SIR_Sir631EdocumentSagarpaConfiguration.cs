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

    // SIR_631_EDOCUMENT_SAGARPA
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir631EdocumentSagarpaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir631EdocumentSagarpa>
    {
        public SIR_Sir631EdocumentSagarpaConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir631EdocumentSagarpaConfiguration(string schema)
        {
            ToTable("SIR_631_EDOCUMENT_SAGARPA", schema);
            HasKey(x => x.NIdEDocument631);

            Property(x => x.NIdEDocument631).HasColumnName(@"nIdEDocument631").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdRevisionDocumental626).HasColumnName(@"nIdRevisionDocumental626").HasColumnType("int").IsRequired();
            Property(x => x.SEDocument).HasColumnName(@"sEDocument").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(13);
            Property(x => x.NTipo).HasColumnName(@"nTipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsOptional();
            Property(x => x.DEdicion).HasColumnName(@"dEdicion").HasColumnType("datetime").IsOptional();
            Property(x => x.NIdDocumento63).HasColumnName(@"nIdDocumento63").HasColumnType("int").IsOptional();

            // Foreign keys
            HasRequired(a => a.SIR_Sir626RevisionDocumental).WithMany(b => b.SIR_Sir631EdocumentSagarpa).HasForeignKey(c => c.NIdRevisionDocumental626).WillCascadeOnDelete(false); // FK_SIR_631_EDOCUMENT_SAGARPA_SIR_626_REVISION_DOCUMENTAL
        }
    }

}
// </auto-generated>
