namespace TraverTripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Commands", "Blog_Id", "dbo.Blogs");
            DropIndex("dbo.Commands", new[] { "Blog_Id" });
            RenameColumn(table: "dbo.Commands", name: "Blog_Id", newName: "Blogid");
            AlterColumn("dbo.Commands", "Blogid", c => c.Int(nullable: false));
            CreateIndex("dbo.Commands", "Blogid");
            AddForeignKey("dbo.Commands", "Blogid", "dbo.Blogs", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Commands", "Blogid", "dbo.Blogs");
            DropIndex("dbo.Commands", new[] { "Blogid" });
            AlterColumn("dbo.Commands", "Blogid", c => c.Int());
            RenameColumn(table: "dbo.Commands", name: "Blogid", newName: "Blog_Id");
            CreateIndex("dbo.Commands", "Blog_Id");
            AddForeignKey("dbo.Commands", "Blog_Id", "dbo.Blogs", "Id");
        }
    }
}
