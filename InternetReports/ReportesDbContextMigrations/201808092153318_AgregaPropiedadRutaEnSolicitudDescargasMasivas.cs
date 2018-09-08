namespace InternetReports.ReportesDbContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregaPropiedadRutaEnSolicitudDescargasMasivas : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SolicitudDescargaMasivas", "RutaArchivo", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SolicitudDescargaMasivas", "RutaArchivo");
        }
    }
}
