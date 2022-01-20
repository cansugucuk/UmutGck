namespace LibraryApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Teacher2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Teachers", "UserTypeId", c => c.Int());
            CreateIndex("dbo.Teachers", "UserTypeId");
            AddForeignKey("dbo.Teachers", "UserTypeId", "dbo.UserTypes", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Teachers", "UserTypeId", "dbo.UserTypes");
            DropIndex("dbo.Teachers", new[] { "UserTypeId" });
            AlterColumn("dbo.Teachers", "UserTypeId", c => c.Int(nullable: false));
        }
    }
}
