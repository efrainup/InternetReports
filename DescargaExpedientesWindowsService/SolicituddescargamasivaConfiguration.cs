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


namespace DescargaExpedientesWindowsService
{

    // SolicitudDescargaMasivas
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.37.1.0")]
    public class SolicituddescargamasivaConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Solicituddescargamasiva>
    {
        public SolicituddescargamasivaConfiguration()
            : this("dbo")
        {
        }

        public SolicituddescargamasivaConfiguration(string schema)
        {
            ToTable("SolicitudDescargaMasivas", schema);
            HasKey(x => x.IdSolicitudDescargaMasiva);

            Property(x => x.IdSolicitudDescargaMasiva).HasColumnName(@"IdSolicitudDescargaMasiva").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.IdCliente).HasColumnName(@"IdCliente").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Cliente).HasColumnName(@"Cliente").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.NombreSolicitud).HasColumnName(@"NombreSolicitud").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.FechaSolicitud).HasColumnName(@"FechaSolicitud").HasColumnType("datetime").IsRequired();
            Property(x => x.FechaProcesado).HasColumnName(@"FechaProcesado").HasColumnType("datetime").IsOptional();
            Property(x => x.FechaUltimaDescarga).HasColumnName(@"FechaUltimaDescarga").HasColumnType("datetime").IsOptional();
            Property(x => x.FechaVigencia).HasColumnName(@"FechaVigencia").HasColumnType("datetime").IsOptional();
            Property(x => x.Descripcion).HasColumnName(@"Descripcion").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.UrlDescarga).HasColumnName(@"UrlDescarga").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.Procesado).HasColumnName(@"Procesado").HasColumnType("bit").IsRequired();
            Property(x => x.UsuarioSolicito).HasColumnName(@"UsuarioSolicito").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.RutaArchivo).HasColumnName(@"RutaArchivo").HasColumnType("nvarchar(max)").IsOptional();
            Property(x => x.FechaInicio).HasColumnName(@"FechaInicio").HasColumnType("datetime").IsRequired();
            Property(x => x.FechaFin).HasColumnName(@"FechaFin").HasColumnType("datetime").IsRequired();
            Property(x => x.Notificar).HasColumnName(@"Notificar").HasColumnType("nvarchar(max)").IsOptional();
        }
    }

}
// </auto-generated>