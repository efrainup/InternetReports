namespace InternetReports.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddColumn : DbMigration
    {
        public override void Up()
        {
            //AddColumn("dbo.AspNetUsers", "NombreCliente", c => c.String());
        }
        
        public override void Down()
        {
            //DropColumn("dbo.AspNetUsers", "NombreCliente");
        }
    }
}
