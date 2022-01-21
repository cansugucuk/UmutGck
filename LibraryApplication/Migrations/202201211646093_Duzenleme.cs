namespace LibraryApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Duzenleme : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Admins", "CreatedDate");
            DropColumn("dbo.Students", "Documents");
            DropColumn("dbo.Students", "Photo");
            DropColumn("dbo.Students", "Birthdate");
            DropColumn("dbo.Students", "IsBlocked");
            DropColumn("dbo.Students", "ReasonBlocked");
            DropColumn("dbo.Students", "CreatedDate");
            DropColumn("dbo.Students", "IsActive");
            DropColumn("dbo.Teachers", "Documents");
            DropColumn("dbo.Teachers", "Photo");
            DropColumn("dbo.Teachers", "Birthdate");
            DropColumn("dbo.Teachers", "IsBlocked");
            DropColumn("dbo.Teachers", "ReasonBlocked");
            DropColumn("dbo.Teachers", "CreatedDate");
            DropColumn("dbo.Teachers", "IsActive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Teachers", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Teachers", "ReasonBlocked", c => c.String());
            AddColumn("dbo.Teachers", "IsBlocked", c => c.Boolean(nullable: false));
            AddColumn("dbo.Teachers", "Birthdate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Teachers", "Photo", c => c.String());
            AddColumn("dbo.Teachers", "Documents", c => c.String());
            AddColumn("dbo.Students", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Students", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Students", "ReasonBlocked", c => c.String());
            AddColumn("dbo.Students", "IsBlocked", c => c.Boolean(nullable: false));
            AddColumn("dbo.Students", "Birthdate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Students", "Photo", c => c.String());
            AddColumn("dbo.Students", "Documents", c => c.String());
            AddColumn("dbo.Admins", "CreatedDate", c => c.DateTime(nullable: false));
        }
    }
}
