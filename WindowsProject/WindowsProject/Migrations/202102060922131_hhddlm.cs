namespace WindowsProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class hhddlm : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.LogProducts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ProductId = c.Int(nullable: false),
                        UserId = c.Int(nullable: false),
                        Description = c.String(),
                        Date = c.DateTime(nullable: false),
                        Count = c.Int(nullable: false),
                        Status = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Products", t => t.ProductId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.ProductId)
                .Index(t => t.UserId);
            
            AddColumn("dbo.Products", "CreatedUserId", c => c.Int(nullable: false));
            AddColumn("dbo.Products", "User_Id", c => c.Int());
            CreateIndex("dbo.Products", "User_Id");
            AddForeignKey("dbo.Products", "User_Id", "dbo.Users", "Id");
            DropColumn("dbo.Products", "CreatedUser");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Products", "CreatedUser", c => c.Int(nullable: false));
            DropForeignKey("dbo.Products", "User_Id", "dbo.Users");
            DropForeignKey("dbo.LogProducts", "UserId", "dbo.Users");
            DropForeignKey("dbo.LogProducts", "ProductId", "dbo.Products");
            DropIndex("dbo.LogProducts", new[] { "UserId" });
            DropIndex("dbo.LogProducts", new[] { "ProductId" });
            DropIndex("dbo.Products", new[] { "User_Id" });
            DropColumn("dbo.Products", "User_Id");
            DropColumn("dbo.Products", "CreatedUserId");
            DropTable("dbo.LogProducts");
        }
    }
}
