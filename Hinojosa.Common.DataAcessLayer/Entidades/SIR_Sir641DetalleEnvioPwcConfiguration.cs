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

    // SIR_641_DETALLE_ENVIO_PWC
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir641DetalleEnvioPwcConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir641DetalleEnvioPwc>
    {
        public SIR_Sir641DetalleEnvioPwcConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir641DetalleEnvioPwcConfiguration(string schema)
        {
            ToTable("SIR_641_DETALLE_ENVIO_PWC", schema);
            HasKey(x => x.NIdDetalleEnvio641);

            Property(x => x.NIdDetalleEnvio641).HasColumnName(@"nIdDetalleEnvio641").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdBitacoraEnvio640).HasColumnName(@"nIdBitacoraEnvio640").HasColumnType("int").IsRequired();
            Property(x => x.SDocumento).HasColumnName(@"sDocumento").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(3000);
            Property(x => x.NTipo).HasColumnName(@"nTipo").HasColumnType("tinyint").IsRequired();
            Property(x => x.NStatus).HasColumnName(@"nStatus").HasColumnType("tinyint").IsRequired();
            Property(x => x.SMensaje).HasColumnName(@"sMensaje").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.NIdReferencia60).HasColumnName(@"nIdReferencia60").HasColumnType("int").IsRequired();
            Property(x => x.SNumeroDeReferencia).HasColumnName(@"sNumeroDeReferencia").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(64);
            Property(x => x.SNumeroDePedimento).HasColumnName(@"sNumeroDePedimento").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(7);
            Property(x => x.DEnvio).HasColumnName(@"dEnvio").HasColumnType("datetime").IsRequired();

            // Foreign keys
            HasRequired(a => a.SIR_Sir640BitacoraEnvioPwc).WithMany(b => b.SIR_Sir641DetalleEnvioPwc).HasForeignKey(c => c.NIdBitacoraEnvio640).WillCascadeOnDelete(false); // FK_SIR_641_DETALLE_ENVIO_PWC_SIR_640_BITACORA_ENVIO_PWC
        }
    }

}
// </auto-generated>