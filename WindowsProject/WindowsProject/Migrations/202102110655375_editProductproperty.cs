namespace WindowsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class editProductproperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Products", "ExpireDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Products", "ExpireDate");
        }
    }
}
