namespace InternetReports.ReportesDbContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregarObservacionesReportes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ObservacionesReportes",
                c => new
                    {
                        IdAtributo = c.Int(nullable: false, identity: true),
                        ReporteId = c.String(),
                        ClienteId = c.String(),
                        IdentificadorRegistro = c.String(),
                        Observacion = c.String(),
                    })
                .PrimaryKey(t => t.IdAtributo);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ObservacionesReportes");
        }
    }
}
