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

    // SIR_480_NOTIFICACION_EFILE_ADJ
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir480NotificacionEfileAdjConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir480NotificacionEfileAdj>
    {
        public SIR_Sir480NotificacionEfileAdjConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir480NotificacionEfileAdjConfiguration(string schema)
        {
            ToTable("SIR_480_NOTIFICACION_EFILE_ADJ", schema);
            HasKey(x => x.NIdNotificacionEfileadj480);

            Property(x => x.NIdNotificacionEfileadj480).HasColumnName(@"nIdNotificacionEFILEADJ480").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdNotificacionEfile479).HasColumnName(@"nIdNotificacionEFILE479").HasColumnType("int").IsRequired();
            Property(x => x.NIdTipoDocto62).HasColumnName(@"nIdTipoDocto62").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.SIR_Sir479NotificacionEfile).WithMany(b => b.SIR_Sir480NotificacionEfileAdj).HasForeignKey(c => c.NIdNotificacionEfile479).WillCascadeOnDelete(false); // FK_SIR_SIR_480_NOTIFICACION_EFILE_ADJ_479_NOTIFICACION_EFILE
            HasRequired(a => a.SIR_Sir62TiposDocumento).WithMany(b => b.SIR_Sir480NotificacionEfileAdj).HasForeignKey(c => c.NIdTipoDocto62).WillCascadeOnDelete(false); // FK_SIR_480_NOTIFICACION_EFILE_ADJ_SIR_62_TIPOS_DOCUMENTOS
        }
    }

}
// </auto-generated>
