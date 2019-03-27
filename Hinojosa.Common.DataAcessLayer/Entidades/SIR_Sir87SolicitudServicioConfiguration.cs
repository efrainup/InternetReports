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

    // SIR_87_SOLICITUD_SERVICIOS
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SIR_Sir87SolicitudServicioConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<SIR_Sir87SolicitudServicio>
    {
        public SIR_Sir87SolicitudServicioConfiguration()
            : this("SIR")
        {
        }

        public SIR_Sir87SolicitudServicioConfiguration(string schema)
        {
            ToTable("SIR_87_SOLICITUD_SERVICIOS", schema);
            HasKey(x => x.NIdSolServ87);

            Property(x => x.NIdSolServ87).HasColumnName(@"nIdSolServ87").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.NIdReferencia60).HasColumnName(@"nIdReferencia60").HasColumnType("int").IsRequired();
            Property(x => x.NIdContenedor76).HasColumnName(@"nIdContenedor76").HasColumnType("int").IsRequired();
            Property(x => x.XSolicitud).HasColumnName(@"xSolicitud").HasColumnType("varchar(max)").IsOptional().IsUnicode(false);
            Property(x => x.SDescripcion).HasColumnName(@"sDescripcion").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(150);
            Property(x => x.SClave).HasColumnName(@"sClave").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NFolio).HasColumnName(@"nFolio").HasColumnType("int").IsOptional();
            Property(x => x.SIdentificador).HasColumnName(@"sIdentificador").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(50);
            Property(x => x.NTurno).HasColumnName(@"nTurno").HasColumnType("tinyint").IsRequired();
            Property(x => x.NGiro).HasColumnName(@"nGiro").HasColumnType("tinyint").IsRequired();
            Property(x => x.DFechaSolicitud).HasColumnName(@"dFechaSolicitud").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.DFechaProg).HasColumnName(@"dFechaProg").HasColumnType("smalldatetime").IsRequired();
            Property(x => x.NIdEmpleado).HasColumnName(@"nIdEmpleado").HasColumnType("int").IsRequired();
            Property(x => x.DFechaEdicion).HasColumnName(@"dFechaEdicion").HasColumnType("datetime").IsRequired();
            Property(x => x.NIdUsuarioEd).HasColumnName(@"nIdUsuarioEd").HasColumnType("int").IsRequired();
            Property(x => x.NStatus).HasColumnName(@"nStatus").HasColumnType("tinyint").IsRequired();
            Property(x => x.SObservaciones).HasColumnName(@"sObservaciones").HasColumnType("varchar").IsOptional().IsUnicode(false).HasMaxLength(700);
            Property(x => x.NModoEnvio).HasColumnName(@"nModoEnvio").HasColumnType("int").IsOptional();
            Property(x => x.NIdDetProgServ48).HasColumnName(@"nIdDetProgServ48").HasColumnType("int").IsOptional();

            // Foreign keys
            HasOptional(a => a.SIRAdmin_Sira48DetalleProgServicio).WithMany(b => b.SIR_Sir87SolicitudServicio).HasForeignKey(c => c.NIdDetProgServ48).WillCascadeOnDelete(false); // FK_SIR_87_SOLICITUD_SERVICIOS_SIRA_48_DETALLE_PROG_SERVICIOS
            HasRequired(a => a.SIR_Sir60Referencia).WithMany(b => b.SIR_Sir87SolicitudServicio).HasForeignKey(c => c.NIdReferencia60).WillCascadeOnDelete(false); // FK_SIR_87_SOLICITUD_SERVICIOS_SIR_60_REFERENCIAS
            HasRequired(a => a.SIR_Sir76Contenedore).WithMany(b => b.SIR_Sir87SolicitudServicio).HasForeignKey(c => c.NIdContenedor76).WillCascadeOnDelete(false); // FK_SIR_87_SOLICITUD_SERVICIOS_SIR_76_CONTENEDORES
        }
    }

}
// </auto-generated>
