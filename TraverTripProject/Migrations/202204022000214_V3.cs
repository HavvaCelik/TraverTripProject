namespace TraverTripProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Contacts", "NameSurname", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Contacts", "Email", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Contacts", "issue", c => c.String(nullable: false, maxLength: 50));
            AlterColumn("dbo.Contacts", "Message", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Contacts", "Message", c => c.String());
            AlterColumn("dbo.Contacts", "issue", c => c.String());
            AlterColumn("dbo.Contacts", "Email", c => c.String());
            AlterColumn("dbo.Contacts", "NameSurname", c => c.String());
        }
    }
}
