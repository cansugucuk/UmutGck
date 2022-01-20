namespace LibraryApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Teacher3 : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Students", "IsActive");
            DropColumn("dbo.Teachers", "IsActive");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "IsActive", c => c.DateTime(nullable: false));
            AddColumn("dbo.Students", "IsActive", c => c.DateTime(nullable: false));
        }
    }
}
