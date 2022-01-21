namespace LibraryApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class image : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.UserTypes", "Image", c => c.Binary());
        }
        
        public override void Down()
        {
            DropColumn("dbo.UserTypes", "Image");
        }
    }
}
