namespace LibraryApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhotoFix : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.UserTypes", "Image");
        }
        
        public override void Down()
        {
            AddColumn("dbo.UserTypes", "Image", c => c.Binary());
        }
    }
}
