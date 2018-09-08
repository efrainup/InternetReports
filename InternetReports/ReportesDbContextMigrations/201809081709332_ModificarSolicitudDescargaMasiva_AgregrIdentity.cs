namespace InternetReports.ReportesDbContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModificarSolicitudDescargaMasiva_AgregrIdentity : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.SolicitudDescargaMasivas");
            AlterColumn("dbo.SolicitudDescargaMasivas", "IdSolicitudDescargaMasiva", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.SolicitudDescargaMasivas", "IdSolicitudDescargaMasiva");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.SolicitudDescargaMasivas");
            AlterColumn("dbo.SolicitudDescargaMasivas", "IdSolicitudDescargaMasiva", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.SolicitudDescargaMasivas", "IdSolicitudDescargaMasiva");
        }
    }
}
