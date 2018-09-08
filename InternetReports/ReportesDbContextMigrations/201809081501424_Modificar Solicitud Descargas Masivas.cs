namespace InternetReports.ReportesDbContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificarSolicitudDescargasMasivas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SolicitudDescargaMasivas", "FechaInicio", c => c.DateTime(nullable: false));
            AddColumn("dbo.SolicitudDescargaMasivas", "FechaFin", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SolicitudDescargaMasivas", "FechaProcesado", c => c.DateTime());
            AlterColumn("dbo.SolicitudDescargaMasivas", "FechaUltimaDescarga", c => c.DateTime());
            AlterColumn("dbo.SolicitudDescargaMasivas", "FechaVigencia", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.SolicitudDescargaMasivas", "FechaVigencia", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SolicitudDescargaMasivas", "FechaUltimaDescarga", c => c.DateTime(nullable: false));
            AlterColumn("dbo.SolicitudDescargaMasivas", "FechaProcesado", c => c.DateTime(nullable: false));
            DropColumn("dbo.SolicitudDescargaMasivas", "FechaFin");
            DropColumn("dbo.SolicitudDescargaMasivas", "FechaInicio");
        }
    }
}
