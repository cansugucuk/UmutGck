namespace LibraryApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NameBugFix : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Lessons", "Name", c => c.String());
            AlterColumn("dbo.Status", "Name", c => c.String());
            AlterColumn("dbo.UserTypes", "Name", c => c.String());
            AlterColumn("dbo.WorkTypes", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.WorkTypes", "Name", c => c.Int());
            AlterColumn("dbo.UserTypes", "Name", c => c.Int());
            AlterColumn("dbo.Status", "Name", c => c.Int());
            AlterColumn("dbo.Lessons", "Name", c => c.Int());
        }
    }
}
