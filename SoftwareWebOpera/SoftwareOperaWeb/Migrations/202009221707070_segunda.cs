namespace SoftwareOperaWeb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class segunda : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Operas", "UserId", c => c.Int());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Operas", "UserId");
        }
    }
}
