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

    // SIR_756_BITACORA_NOTIFICACIONES
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir756BitacoraNotificacioneConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir756BitacoraNotificacione>
    {
        public SIR_Sir756BitacoraNotificacioneConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir756BitacoraNotificacioneConfiguration(string schema)
        {
            ToTable("SIR_756_BITACORA_NOTIFICACIONES", schema);
            HasKey(x => x.NIdBitacoraNotificaciones756);

            Property(x => x.NIdBitacoraNotificaciones756).HasColumnName(@"nIdBitacoraNotificaciones756").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdNotificacion416).HasColumnName(@"nIdNotificacion416").HasColumnType("int").IsOptional();
            Property(x => x.NIdUsuario).HasColumnName(@"nIdUsuario").HasColumnType("int").IsOptional();
            Property(x => x.DFecha).HasColumnName(@"dFecha").HasColumnType("datetime").IsRequired();
            Property(x => x.SMensajeLog).HasColumnName(@"sMensajeLog").HasColumnType("varchar(max)").IsRequired().IsUnicode(false);
            Property(x => x.SClase).HasColumnName(@"sClase").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(200);
            Property(x => x.SMetodo).HasColumnName(@"sMetodo").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(250);
            Property(x => x.SIpEquipoEnvia).HasColumnName(@"sIPEquipoEnvia").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.SNombreNotificacion).HasColumnName(@"sNombreNotificacion").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(100);
            Property(x => x.NTipoNotificacion).HasColumnName(@"nTipoNotificacion").HasColumnType("int").IsRequired();
            Property(x => x.NTipoModulo).HasColumnName(@"nTipoModulo").HasColumnType("int").IsRequired();
            Property(x => x.NIdBaseEntity).HasColumnName(@"nIdBaseEntity").HasColumnType("int").IsRequired();
            Property(x => x.XXml).HasColumnName(@"xXml").HasColumnType("xml").IsOptional();

            // Foreign keys
            HasOptional(a => a.SIR_Sir416Notificacione).WithMany(b => b.SIR_Sir756BitacoraNotificacione).HasForeignKey(c => c.NIdNotificacion416).WillCascadeOnDelete(false); // FK_SIR_756_BITACORA_NOTIFICACIONES_SIR_416_NOTIFICACIONES
        }
    }

}
// </auto-generated>