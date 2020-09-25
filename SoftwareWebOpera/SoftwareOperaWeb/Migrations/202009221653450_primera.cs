namespace SoftwareOperaWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class primera : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Operas",
                c => new
                    {
                        OperaId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 20),
                        Year = c.Int(nullable: false),
                        Composer = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.OperaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Operas");
        }
    }
}
