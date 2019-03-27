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

    // SIR_479_NOTIFICACION_EFILE
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir479NotificacionEfileConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir479NotificacionEfile>
    {
        public SIR_Sir479NotificacionEfileConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir479NotificacionEfileConfiguration(string schema)
        {
            ToTable("SIR_479_NOTIFICACION_EFILE", schema);
            HasKey(x => x.NIdNotificacionEfile479);

            Property(x => x.NIdNotificacionEfile479).HasColumnName(@"nIdNotificacionEFILE479").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdNotificacion416).HasColumnName(@"nIdNotificacion416").HasColumnType("int").IsRequired();
            Property(x => x.NIdTipoDocto62).HasColumnName(@"nIdTipoDocto62").HasColumnType("int").IsRequired();
            Property(x => x.STagsNombreArchivo).HasColumnName(@"sTagsNombreArchivo").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(120);
            Property(x => x.NTipoEnvioArchivos).HasColumnName(@"nTipoEnvioArchivos").HasColumnType("tinyint").IsOptional();

            // Foreign keys
            HasRequired(a => a.SIR_Sir416Notificacione).WithMany(b => b.SIR_Sir479NotificacionEfile).HasForeignKey(c => c.NIdNotificacion416).WillCascadeOnDelete(false); // FK_SIR_479_NOTIFICACION_EFILE_SIR_416_NOTIFICACIONES
            HasRequired(a => a.SIR_Sir62TiposDocumento).WithMany(b => b.SIR_Sir479NotificacionEfile).HasForeignKey(c => c.NIdTipoDocto62).WillCascadeOnDelete(false); // FK_SIR_479_NOTIFICACION_EFILE_SIR_62_TIPOS_DOCUMENTOS
        }
    }

}
// </auto-generated>