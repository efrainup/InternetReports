namespace InternetReports.ReportesDbContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarSolicitudDescargasMasivas : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SolicitudDescargaMasivas",
                c => new
                    {
                        IdSolicitudDescargaMasiva = c.String(nullable: false, maxLength: 128),
                        IdCliente = c.String(),
                        Cliente = c.String(),
                        NombreSolicitud = c.String(),
                        FechaSolicitud = c.DateTime(nullable: false),
                        FechaProcesado = c.DateTime(nullable: false),
                        FechaUltimaDescarga = c.DateTime(nullable: false),
                        FechaVigencia = c.DateTime(nullable: false),
                        Descripcion = c.String(),
                        UrlDescarga = c.String(),
                        Procesado = c.Boolean(nullable: false),
                        UsuarioSolicito = c.String(),
                    })
                .PrimaryKey(t => t.IdSolicitudDescargaMasiva);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SolicitudDescargaMasivas");
        }
    }
}
