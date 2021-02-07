namespace WindowsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcustomerl : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Customers", "CreatedUserId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "CreatedUserId", c => c.Int(nullable: false));
        }
    }
}
