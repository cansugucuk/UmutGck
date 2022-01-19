namespace LibraryApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Lessons : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Users", "Type", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Users", "Type", c => c.Int(nullable: false));
        }
    }
}
