namespace InternetReports.ReportesDbContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificarSolicitudDescargasNotificaciones : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SolicitudDescargaMasivas", "Notificar", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SolicitudDescargaMasivas", "Notificar");
        }
    }
}
