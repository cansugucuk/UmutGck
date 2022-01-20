namespace LibraryApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsActive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Teachers", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "IsActive");
            DropColumn("dbo.Students", "IsActive");
        }
    }
}
