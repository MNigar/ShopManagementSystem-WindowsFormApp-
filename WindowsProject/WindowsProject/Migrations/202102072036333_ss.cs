namespace WindowsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ss : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Products", "SoldedTotal", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Products", "SoldedTotal", c => c.Int(nullable: false));
        }
    }
}
