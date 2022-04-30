namespace TraverTripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V4 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "NameSurname", c => c.String());
            AlterColumn("dbo.Contacts", "Email", c => c.String());
            AlterColumn("dbo.Contacts", "issue", c => c.String());
            AlterColumn("dbo.Contacts", "Message", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Message", c => c.String(nullable: false, maxLength: 500));
            AlterColumn("dbo.Contacts", "issue", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Contacts", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Contacts", "NameSurname", c => c.String(nullable: false, maxLength: 50));
        }
    }
}
