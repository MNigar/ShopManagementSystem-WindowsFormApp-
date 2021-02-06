namespace WindowsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hhddlmkk : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "SoldedCount", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "SoldedTotal", c => c.Int(nullable: false));
            DropColumn("dbo.LogProducts", "Count");
        }
        
        public override void Down()
        {
            AddColumn("dbo.LogProducts", "Count", c => c.Int(nullable: false));
            DropColumn("dbo.Products", "SoldedTotal");
            DropColumn("dbo.Products", "SoldedCount");
        }
    }
}
