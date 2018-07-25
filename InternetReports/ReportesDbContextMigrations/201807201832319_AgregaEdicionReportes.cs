namespace InternetReports.ReportesDbContextMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AgregaEdicionReportes : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EdicionesReportes",
                c => new
                    {
                        EdicionId = c.Int(nullable: false, identity: true),
                        ReporteId = c.String(),
                        ClienteId = c.String(),
                        IdentificadorRegistro = c.String(),
                        Valor = c.String(),
                        Campo = c.String(),
                        TipoNet = c.String(),
                        TipoSql = c.String(),
                    })
                .PrimaryKey(t => t.EdicionId);
            
            DropTable("dbo.ObservacionesReportes");
        }
        
        public override void Down()
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
            
            DropTable("dbo.EdicionesReportes");
        }
    }
}
